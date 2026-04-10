using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pasxa
{
    public partial class InfoForm : Form
    {
        private MyPasxa pasxa;
        private Image originalImage;
        private float scaleValue = 1.0f;

        public InfoForm(MyPasxa selected)
        {
            InitializeComponent();

            pasxa = selected;

            lblName.Text = $"Назва: {selected.name}";
            lblWeight.Text = $"Вага: {selected.weight} г";
            lblProducer.Text = $"Виробник: {selected.producer}";
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            
            if (File.Exists(pasxa.image))
            {
                originalImage = Image.FromFile(pasxa.image);
                pbImage.Image = originalImage;
            }

            trbZoom.Minimum = 1;
            trbZoom.Maximum = 30;
            trbZoom.Value = 10;

            trbZoom.Scroll += trbZoom_Scroll;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int scale = trbZoom.Value;

            pbImage.Width = originalImage.Width * scale;
            pbImage.Height = originalImage.Height * scale;
        }

        private void trbZoom_Scroll(object sender, EventArgs e)
        {
            trbZoom.Scroll += (s, e) => ApplyZoom();
        }

        private void ApplyZoom()
        {
            if (originalImage == null) return;

            int newWidth = (int)(originalImage.Width * scaleValue);
            int newHeight = (int)(originalImage.Height * scaleValue);

            pbImage.Size = new Size(newWidth, newHeight);

            // центрування
            int x = (panel1.ClientSize.Width - newWidth) / 2;
            int y = (panel1.ClientSize.Height - newHeight) / 2;

            pbImage.Location = new Point (
                Math.Max(0, x),
                Math.Max(0, y)
            );
        }
    }
}
