using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace lawstud
{
    public partial class MainForm : Form
    {
        private Bitmap _bm;
        private string _upperText = "СТУДЕНТЪ";
        private string _bottomText = "МЕМ";

        public MainForm()
        {
            InitializeComponent();
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                _bm.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
            }
        }

        private void LawStPicturePaint(object sender, PaintEventArgs e)
        {
            SizeF size;
            int upperTextSize = 50;
            int bottomTextSize = 50;

            _bm = Properties.Resources.lawstud;

            Graphics g = Graphics.FromImage(_bm);

            // Upper Text
            do
            {
                size = g.MeasureString(_upperText, new Font("Arial", upperTextSize));
                upperTextSize--;
            } while (size.Width >= 480);
            upperTextSize++;

            g.DrawString(_upperText,
                new Font("Arial", upperTextSize),
                Brushes.Black,
                new Point(
                    (int)(247 - Math.Round(size.Width / 2))+2, 
                    52 - 20*((int)Math.Round((double)(upperTextSize-12) / 38))));

            g.DrawString(_upperText, 
                new Font("Arial", upperTextSize), 
                Brushes.White,
                new Point(
                    (int)(247 - Math.Round(size.Width / 2)),
                    50 - 20 * ((int)Math.Round((double)(upperTextSize - 12) / 38))));

            // Bottom Text
            do
            {
                size = g.MeasureString(_bottomText, new Font("Arial", bottomTextSize));
                bottomTextSize--;
            } while (size.Width >= 480);
            bottomTextSize++;

            g.DrawString(_bottomText,
                new Font("Arial", bottomTextSize),
                Brushes.Black,
                new Point(
                    (int)(247 - Math.Round(size.Width / 2))+2, 
                    382 - 20*((int)Math.Round((double)(bottomTextSize-12) / 38))));
                

            g.DrawString(_bottomText,
                new Font("Arial", bottomTextSize),
                Brushes.White,
                new Point(
                    (int)(247 - Math.Round(size.Width / 2)) + 2,
                    380 - 20 * ((int)Math.Round((double)(bottomTextSize - 12) / 38))));

            e.Graphics.DrawImageUnscaled(_bm, 0, 0);
        }

        private void UpperTextBoxTextChanged(object sender, EventArgs e)
        {
            _upperText = UpperTextBox.Text;
            LawStPicture.Refresh();
        }

        private void BottomTextBoxTextChanged(object sender, EventArgs e)
        {
            _bottomText = BottomTextBox.Text;
            LawStPicture.Refresh();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            UpperTextBox.Text = _upperText;
            BottomTextBox.Text = _bottomText;

            LawStPicture.Refresh();
        }
    }
}
