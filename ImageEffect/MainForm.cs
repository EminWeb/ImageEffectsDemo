using System.Windows.Forms;

namespace ImageEffect
{
    public partial class MainForm : Form
    {
        private string _fileFullPath;
        private ImageProcessing imageProcessing = new ImageProcessing();
        private Image _orginalImage;
        private Image _appayedImage;
        private int? _sliderPreviusValue = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            rbStandart.Checked = true;
            btnApply.Enabled = false;
            tbSlider.Enabled = false;
            tbSlider.Value = tbSlider.Maximum;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var imageFileDalog = new OpenFileDialog();
            imageFileDalog.Filter = "Image files (*.jpg, *.jpg)|*.png;*.jpeg";
            imageFileDalog.FilterIndex = 0;
            imageFileDalog.RestoreDirectory = true;

            if (imageFileDalog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            tbSlider.Enabled = true;
            btnApply.Enabled = true;

            _fileFullPath = imageFileDalog.FileName;

            var image = Image.FromFile(_fileFullPath);
            _orginalImage = (Image)image.Clone();
            _orginalImage = imageProcessing.ResizeImage(image, pbImage.Size);
            _appayedImage = imageProcessing.ResizeImage(image, pbImage.Size);
            btnApply.PerformClick();
        }

        private void tbSlider_Scroll(object sender, EventArgs e)
        {
            int direction = 20;
            _sliderPreviusValue = (tbSlider.Value + tbSlider.TickFrequency);
            var width = _orginalImage.Size.Width / direction *  tbSlider.Value;
            var height = _orginalImage.Size.Height / direction *  tbSlider.Value;
            var size = new Size(width, height);
            if (size.Width <= 0 || size.Height <= 0)
            {

                MessageBox.Show("Immage size is sooo smale!");
                tbSlider.Value = _sliderPreviusValue.Value;
                return;
            }
            _appayedImage = _orginalImage;
            _appayedImage = imageProcessing.ResizeImage(_appayedImage, size);

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (_appayedImage != null)
            {
                pbImage.Image = _appayedImage;
            }
        }

        private void rbGrey_CheckedChanged(object sender, EventArgs e)
        {
            _appayedImage = imageProcessing.Grey(_appayedImage);
            btnApply.PerformClick();
        }

        private void rbStandart_CheckedChanged(object sender, EventArgs e)
        {
            if (_orginalImage != null)
            {

                _appayedImage = _orginalImage;
            }
            btnApply.PerformClick();
        }

        private void rbBlur_CheckedChanged(object sender, EventArgs e)
        {
            var bit = new Bitmap(_appayedImage);
            var rec = new Rectangle(0, 0, _appayedImage.Width, _appayedImage.Height);
            _appayedImage = imageProcessing.Blur(bit, rec, 3);
            btnApply.PerformClick();
        }
    }
}