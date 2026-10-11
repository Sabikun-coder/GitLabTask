using RetroRides.Data;
using RetroRides.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace RetroRides.BLL.Client
{
    public class MainFormService
    {
        private readonly DatabaseConnection _dbConnection;

        public MainFormService(DatabaseConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        // Load car images from the database or other source (using ImageManager for now)
        public List<Image> LoadCarImages()
        {
            var carImages = new List<Image>();
            try
            {
                carImages.Add(ImageManager.GetImage("Car1"));
                carImages.Add(ImageManager.GetImage("Car2"));
                carImages.Add(ImageManager.GetImage("Car3"));
                carImages.Add(ImageManager.GetImage("Car4"));
            }
            catch (Exception ex)
            {
                throw new Exception($"Error loading images: {ex.Message}");
            }
            return carImages;
        }

    }
}
