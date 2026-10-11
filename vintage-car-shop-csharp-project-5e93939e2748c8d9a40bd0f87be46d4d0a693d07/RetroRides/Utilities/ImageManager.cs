using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RetroRides.Utilities
{
    public static class ImageManager
    {
        // Dictionary to store image keys
        private static Dictionary<string, string> imageKeys = new Dictionary<string, string>
        {
            { "Car1", "CarSlideshow(MainForm)/Car1.png" },
            { "Car2", "CarSlideshow(MainForm)/Car2.png" },
            { "Car3", "CarSlideshow(MainForm)/Car3.png" },
            { "Car4", "CarSlideshow(MainForm)/Car4.png" },

            { "Placeholder", "placeHolderCar.jpg" }, // Placeholder for gallery

            { "GalCar1", "CarDbImages/mercedes-benz 300sl gullwing.png" },
            { "GalCar2", "CarDbImages/1967 Ford Mustang Fastback.png" },
            { "GalCar3", "CarDbImages/1959 cadillac eldorado.png" },
            { "GalCar4", "CarDbImages/1964 Chevrolet Corvette Stingray.png" },
            { "GalCar5", "CarDbImages/1962 Volkswagen Beetle.png" },

            { "GIF1", "CarGifs(GalleryForm)/Mercedes-Benz 300 SL Gullwing.gif" },
            { "GIF2", "CarGifs(GalleryForm)/FORD MUSTANG 1967 FASTBACK.gif" },
            { "GIF3", "CarGifs(GalleryForm)/1959 Cadillac El Dorado.gif" },
            { "GIF4", "CarGifs(GalleryForm)/1963 Corvette Split Window Coupe.gif" },
            { "GIF5", "CarGifs(GalleryForm)/Rocking Ragtop - 1962 VW Beetle - FRVRBRK.gif" },
        };

        // Dictionary to cache loaded images
        private static Dictionary<string, Image> cachedImages = new Dictionary<string, Image>();

        // Base directory for the resources
        private static string baseDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Resources\Car Images");

        // Method to get an image by key (loads if not already cached)
        public static Image GetImage(string key)
        {
            // Check if the image is already cached
            if (cachedImages.ContainsKey(key))
            {
                return cachedImages[key];
            }

            // If not cached, load from path
            if (imageKeys.ContainsKey(key))
            {
                string relativeImagePath = imageKeys[key];
                string imagePath = Path.Combine(baseDirectory, relativeImagePath);

                // DEBUG: Check if the resolved path is correct
                if (!File.Exists(imagePath))
                {
                    MessageBox.Show($"Image file not found: {imagePath}", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return GetPlaceholderImage(); // Return placeholder image if the file doesn't exist
                }

                try
                {
                    Image img = Image.FromFile(imagePath);
                    cachedImages[key] = img;  // Cache it
                    return img;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // If the image or path is not found, return a default placeholder image
            return GetPlaceholderImage();
        }

        // Method to load a placeholder image
        public static Image GetPlaceholderImage()
        {
            if (cachedImages.ContainsKey("Placeholder"))
            {
                return cachedImages["Placeholder"];
            }

            string placeholderPath = Path.Combine(baseDirectory, imageKeys["Placeholder"]);
            if (File.Exists(placeholderPath))
            {
                Image placeholderImage = Image.FromFile(placeholderPath);
                cachedImages["Placeholder"] = placeholderImage;
                return placeholderImage;
            }

            return null; // Return null if placeholder image is not found
        }

        // Method to dispose of all loaded images
        public static void DisposeAllImages()
        {
            foreach (var image in cachedImages.Values)
            {
                image.Dispose();
            }
            cachedImages.Clear();
        }
    }
}