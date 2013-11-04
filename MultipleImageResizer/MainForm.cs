using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleImageResizer
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Selected folder path
        /// </summary>
        private string folderPath;

        /// <summary>
        /// File list in selected folder
        /// </summary>
        private List<string> imageFilesList;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            // Control user select a folder
            if (fbdSelectImageFolder.ShowDialog() == DialogResult.OK)
            {
                // Get the path of selected folder
                folderPath = fbdSelectImageFolder.SelectedPath;

                // Set the files name to the list
                imageFilesList = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories).ToList();

                // Write selected folder to textbox
                rtbSelectedFolder.Text = folderPath;

                // Enable export files button
                gbExportOptions.Enabled = true;
            }
            else
            {
                // Set empty textbox of selected folder
                rtbSelectedFolder.Text = "";

                // Disable export files button
                gbExportOptions.Enabled = false;
            }

            // Set text of status strip
            SetStatusStripText("");
        }


        private void btnExportFiles_Click(object sender, EventArgs e)
        {
            pbExportFiles.Maximum = imageFilesList.Count;
            // Start the background operations
            bwExportFiles.RunWorkerAsync();
        }

        /// <summary>
        /// Set status stript text
        /// </summary>
        /// <param name="text">Status text</param>
        private void SetStatusStripText(string text)
        {
            tssl_Status.Text = text;
        }


        /// <summary>
        /// Method to resize, convert and save the image.
        /// </summary>
        /// <param name="image">Bitmap image.</param>
        /// <param name="maxWidth">resize width.</param>
        /// <param name="maxHeight">resize height.</param>
        /// <param name="quality">quality setting value.</param>
        /// <param name="filePath">file path.</param>      
        public void Save(Bitmap image, int maxWidth, int maxHeight, int quality, string filePath)
        {
            // Get the image's original width and height
            int originalWidth = image.Width;
            int originalHeight = image.Height;

            // To preserve the aspect ratio
            float ratioX = (float)maxWidth / (float)originalWidth;
            float ratioY = (float)maxHeight / (float)originalHeight;
            float ratio = Math.Min(ratioX, ratioY);

            // New width and height based on aspect ratio
            int newWidth = (int)(originalWidth * ratio);
            int newHeight = (int)(originalHeight * ratio);

            // Convert other formats (including CMYK) to RGB.
            Bitmap newImage;
            if (cbMaintainAspectRatio.Checked)
            {
                newImage = new Bitmap(newWidth, newHeight, PixelFormat.Format24bppRgb);
            }
            else
            {
                newImage = new Bitmap(maxWidth, maxHeight, PixelFormat.Format24bppRgb);
            }

            // Draws the image in the specified size with quality mode set to HighQuality
            using (Graphics graphics = Graphics.FromImage(newImage))
            {
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;

                if (cbMaintainAspectRatio.Checked)
                {
                    graphics.DrawImage(image, 0, 0, newWidth, newHeight);
                }
                else
                {
                    graphics.DrawImage(image, 0, 0, maxWidth, maxHeight);
                }
            }

            // Get an ImageCodecInfo object that represents the JPEG codec.
            ImageCodecInfo imageCodecInfo = this.GetEncoderInfo(ImageFormat.Jpeg);

            // Create an Encoder object for the Quality parameter.
            Encoder encoder = Encoder.Quality;

            // Create an EncoderParameters object. 
            EncoderParameters encoderParameters = new EncoderParameters(1);

            // Save the image as a JPEG file with quality level.
            EncoderParameter encoderParameter = new EncoderParameter(encoder, quality);
            encoderParameters.Param[0] = encoderParameter;
            newImage.Save(filePath, imageCodecInfo, encoderParameters);
        }

        /// <summary>
        /// Method to get encoder infor for given image format.
        /// </summary>
        /// <param name="format">Image format</param>
        /// <returns>image codec info.</returns>
        private ImageCodecInfo GetEncoderInfo(ImageFormat format)
        {
            return ImageCodecInfo.GetImageDecoders().SingleOrDefault(c => c.FormatID == format.Guid);
        }

        private void bwExportFiles_DoWork(object sender, DoWorkEventArgs e)
        {
            Bitmap newImage;

            string subPath = folderPath + "/" + tbfolder.Text + "/";

            bool isExists = System.IO.Directory.Exists(subPath);

            if (!isExists)
                System.IO.Directory.CreateDirectory(subPath);

            int filesCount = imageFilesList.Count;
            int i = 0;
            
            foreach (string fileName in imageFilesList)
            {
                try
                {
                    Console.WriteLine(subPath + fileName);
                    newImage = new Bitmap(Image.FromFile(fileName));
                    Save(newImage, Convert.ToInt16(tbWidth.Text), Convert.ToInt16(tbHeight.Text), 100, subPath + Path.GetFileName(fileName));
                }
                catch (Exception ex)
                {
                }

                bwExportFiles.ReportProgress(++i);
            }
        }

        private void bwExportFiles_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbExportFiles.Value = e.ProgressPercentage;
        }

        private void bwExportFiles_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SetStatusStripText("All image files export succesfully");
            pbExportFiles.Value = 0;
        }
    }

}
