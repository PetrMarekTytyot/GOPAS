using System.Net;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        const string AddressFormat = "https://dummyimage.com/100x100/000/fff&text={0}";
        SemaphoreSlim _sem = new SemaphoreSlim(10, 10);

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.Controls.Clear();
            for (var i = 0; i < 200; i++)
            {
                flowLayoutPanel1.Controls.Add(new PictureBox() { Size = new Size(100, 100) });
            }
            flowLayoutPanel1.ResumeLayout();
            await LoadImages();
        }

        async Task LoadImages()
        {
            var tasks = new Task[flowLayoutPanel1.Controls.Count];
            for (var i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                var item = (PictureBox)flowLayoutPanel1.Controls[i];
                tasks[i] = LoadImage(i, item);
            }
            await Task.WhenAll(tasks);
        }

        async Task LoadImage(int index, PictureBox pictureBox)
        {
            await _sem.WaitAsync();
            try
            {
                var data = await Do(index);
                pictureBox.Image = Image.FromStream(data);
            }
            finally
            {
                _sem.Release();
            }
        }

        static async Task<Stream> Do(int i)
        {
            await Task.Delay(Random.Shared.Next(200, 5000)).ConfigureAwait(false);
            var request = WebRequest.CreateHttp(string.Format(AddressFormat, i));
            using (var response = await request.GetResponseAsync().ConfigureAwait(false))
            {
                var destination = new MemoryStream();
                using (var source = response.GetResponseStream())
                {
                    var buffer = new byte[32 * 1024];
                    while (true)
                    {
                        try
                        {
                            var read = await source.ReadAsync(buffer, 0, buffer.Length).ConfigureAwait(false);
                            if (read == 0)
                                break;
                            await destination.WriteAsync(buffer, 0, read).ConfigureAwait(false);
                        }
                        catch (Exception ex)
                        {
                            throw;
                        }
                    }
                }
                return destination;
            }
        }
    }
}