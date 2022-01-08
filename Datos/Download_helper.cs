using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode.Videos.Streams;
using YoutubeExplode;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;

namespace Downloader.Datos
{
    public class Download_helper
    {
        private static Download_helper _instance;
        public static Download_helper Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Download_helper();
                return _instance;
            }
        }

        public async Task DownloadMP3(string uri, ProgressBar progressBar, Label lbl_progress)
        {
            try
            {
                var yt = new YoutubeClient();
                var streamManifest = await yt.Videos.Streams.GetManifestAsync(uri);
                var video = await yt.Videos.GetAsync(uri);
                string videoTitle = video.Title;

                if (videoTitle.Contains("?"))
                {
                    videoTitle = Regex.Replace(videoTitle, "[?]", " ");
                }

                if (videoTitle.Contains("."))
                {
                    videoTitle = Regex.Replace(videoTitle, "[.]", " ");
                }

                if (videoTitle.Contains("¿"))
                {
                    videoTitle = Regex.Replace(videoTitle, "[¿]", " ");
                }

                if (videoTitle.Contains(":"))
                {
                    videoTitle = Regex.Replace(videoTitle, "[:]", " ");
                }

                if (videoTitle.Contains(";"))
                {
                    videoTitle = Regex.Replace(videoTitle, "[;]", " ");
                }

                if (videoTitle.Contains("@"))
                {
                    videoTitle = Regex.Replace(videoTitle, "[@]", " ");
                }

                if (videoTitle.Contains("<"))
                {
                    videoTitle = Regex.Replace(videoTitle, "[<]", " ");
                }

                if (videoTitle.Contains(">"))
                {
                    videoTitle = Regex.Replace(videoTitle, "[>]", " ");
                }

                if (videoTitle.Contains("!"))
                {
                    videoTitle = Regex.Replace(videoTitle, "[!]", " ");
                }

                var streamInfo = streamManifest.GetAudioOnlyStreams().TryGetWithHighestBitrate();
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
                string path = Path.Combine(folder, videoTitle + ".mp3");
                var progressHandler = new Progress<double>(p =>
                {
                    progressBar.Value = Convert.ToInt32(p * 100);
                    lbl_progress.Text = Convert.ToString(p * 100) + "%";
                });

                var dwl = yt.Videos.Streams.DownloadAsync(streamInfo, path, progressHandler);

                if (streamInfo != null)
                {
                    await Task.Run(async () => { await dwl; });
                    if (dwl.IsCompletedSuccessfully)
                    {
                        progressBar.Value = 0;
                        lbl_progress.Text = "0%";
                        MessageBox.Show("Archivo descargado", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task DownloadMP4(string uri, ProgressBar progressBar, Label lbl_progress)
        {
            try
            {
                var yt = new YoutubeClient();
                var streamManifest = await yt.Videos.Streams.GetManifestAsync(uri);
                var video = await yt.Videos.GetAsync(uri);
                string videoTitle = video.Title;

                if (videoTitle.Contains("?"))
                {
                    videoTitle = Regex.Replace(videoTitle, "[?]", " ");
                }

                if (videoTitle.Contains("."))
                {
                    videoTitle = Regex.Replace(videoTitle, "[.]", " ");
                }

                if (videoTitle.Contains("¿"))
                {
                    videoTitle = Regex.Replace(videoTitle, "[¿]", " ");
                }

                if (videoTitle.Contains(":"))
                {
                    videoTitle = Regex.Replace(videoTitle, "[:]", " ");
                }

                if (videoTitle.Contains(";"))
                {
                    videoTitle = Regex.Replace(videoTitle, "[;]", " ");
                }

                if (videoTitle.Contains("@"))
                {
                    videoTitle = Regex.Replace(videoTitle, "[@]", " ");
                }

                if (videoTitle.Contains("<"))
                {
                    videoTitle = Regex.Replace(videoTitle, "[<]", " ");
                }

                if (videoTitle.Contains(">"))
                {
                    videoTitle = Regex.Replace(videoTitle, "[>]", " ");
                }

                if (videoTitle.Contains("!"))
                {
                    videoTitle = Regex.Replace(videoTitle, "[!]", " ");
                }

                var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
                string path = Path.Combine(folder, videoTitle + ".mp3");
                var progressHandler = new Progress<double>(p => 
                {
                    progressBar.Value = Convert.ToInt32(p * 100);
                    lbl_progress.Text = Convert.ToString(p * 100) + "%";
                });
                
                var dwl = yt.Videos.Streams.DownloadAsync(streamInfo, path, progressHandler);
                
                if (streamInfo != null)
                {
                    await Task.Run(async () => { await dwl; });
                    if (dwl.IsCompletedSuccessfully)
                    {
                        progressBar.Value = 0;
                        lbl_progress.Text = "0%";
                        MessageBox.Show("Archivo descargado", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
