using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;


namespace RetroRides.Utilities
{
    public static class KeyStrokes
    {
        // Method to attach KeyDown event handlers to multiple textboxes
        public static void SubscribeToEnterKey(KryptonTextBox textBox, KryptonButton button)
        {
            textBox.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    // Simulate button click when Enter key is pressed
                    button.PerformClick();
                }
            };
        }
    }
}
