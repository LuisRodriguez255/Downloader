using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Downloader.Datos;

namespace Downloader.Presentación
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            txt_url.Focus();
        }

        private async void DownloadMP3()
        {
            await Download_helper.Instance.DownloadMP3(txt_url.Text, progressBar, lbl_progress);
        }

        private async void DownloadMP4()
        {
            await Download_helper.Instance.DownloadMP4(txt_url.Text, progressBar, lbl_progress);
        }

        private void btn_mp3_Click(object sender, EventArgs e)
        {
            DownloadMP3();
        }

        private void btn_mp4_Click(object sender, EventArgs e)
        {
            DownloadMP4();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
