using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RetroRides.Utilities
{
    public static class FormDesign
    {
        // Apply rounded corners to a KryptonForm or regular Form
        public static void ApplyRoundedCorners(Form form, int radius)
        {
            if (form is KryptonForm kryptonForm)
            {
                // Set KryptonForm to be borderless for manual control of appearance
                kryptonForm.FormBorderStyle = FormBorderStyle.None;
                kryptonForm.StateCommon.Border.Rounding = radius;
                kryptonForm.StateCommon.Border.DrawBorders = PaletteDrawBorders.All; // Ensures border drawing
            }

            if (form.Width > radius * 2 && form.Height > radius * 2)
            {
                // Create the rounded corners path
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);  // Top-left corner
                    path.AddArc(form.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);  // Top-right corner
                    path.AddArc(form.Width - radius * 2, form.Height - radius * 2, radius * 2, radius * 2, 0, 90);  // Bottom-right corner
                    path.AddArc(0, form.Height - radius * 2, radius * 2, radius * 2, 90, 90);  // Bottom-left corner
                    path.CloseFigure();

                    // Apply the rounded region with anti-aliasing
                    using (Graphics g = form.CreateGraphics())
                    {
                        g.SmoothingMode = SmoothingMode.AntiAlias;  // Enable anti-aliasing for smooth edges
                        form.Region = new Region(path);
                    }
                }
            }
        }

        // Make a KryptonForm or regular Form draggable
        public static void MakeFormDraggable(Form form, Control controlToDrag)
        {
            controlToDrag.MouseDown += (sender, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(form.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
                }
            };
        }



        // Fade transition between forms
        public static void FadeTransition(Form currentForm, Form nextForm, int fadeDuration = 50, double stepSize = 0.1)
        {
            // Validate step size to avoid invalid values
            if (stepSize <= 0 || stepSize > 1)
                stepSize = 0.1; // Default to 0.1 for faster transitions

            int interval = fadeDuration / (int)(1.0 / stepSize); // Calculate delay per step

            // If currentForm is null, immediately show nextForm without fade out
            if (currentForm == null)
            {
                nextForm.Opacity = 0;  // Start the next form invisible
                nextForm.Show();

                // Create a Timer for fade-in effect
                Timer fadeInTimer = new Timer { Interval = interval };
                fadeInTimer.Tick += (sender, e) =>
                {
                    nextForm.Opacity += stepSize;
                    if (nextForm.Opacity >= 1.0)
                    {
                        nextForm.Opacity = 1.0;
                        fadeInTimer.Stop();  // Stop when opacity reaches 1
                        nextForm.BringToFront();  // Ensure the next form is in front
                    }
                };
                fadeInTimer.Start();
                return;
            }

            // Proceed with fade out if currentForm is not null
            Timer fadeOutTimer = new Timer { Interval = interval };

            fadeOutTimer.Tick += (sender, e) =>
            {
                currentForm.Opacity -= stepSize;

                if (currentForm.Opacity <= 0)
                {
                    fadeOutTimer.Stop();
                    currentForm.Hide();

                    // Fade in the next form after fade out completes
                    nextForm.Opacity = 0;
                    nextForm.Show();

                    // Create another timer for fade in
                    Timer fadeInTimer = new Timer { Interval = interval };

                    fadeInTimer.Tick += (sender2, e2) =>
                    {
                        nextForm.Opacity += stepSize;

                        if (nextForm.Opacity >= 1.0)
                        {
                            nextForm.Opacity = 1.0;
                            fadeInTimer.Stop();
                            nextForm.BringToFront();
                        }
                    };

                    fadeInTimer.Start();
                }
            };

            fadeOutTimer.Start();
        }




        // Import necessary user32.dll functions for dragging
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
    }
}