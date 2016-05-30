
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ImageShowByUrl
{
    [ToolboxItem(true)]
    public class MyURLImage : PictureBox
    {
        private string _url = "";
        public string ImageUrl
        {
            get
            {
                return _url;
            }
            set
            {
                _url = value;
                if (String.IsNullOrEmpty(_url)) return;
                GetImageByWebRequest(this, _url);
            }
        }

        private void GetImageByWebClient(PictureBox edit, string url)
        {
            WebClientImage tt = new WebClientImage(edit, url);
            Thread thread = new Thread(new ThreadStart(tt.Do));
            thread.Start();

        }
        private void GetImageByWebRequest(PictureBox edit, string url)
        {
            WebRequestImage tt = new WebRequestImage(edit, url);
            Thread thread = new Thread(new ThreadStart(tt.Do));
            thread.Start();
        }

        public class WebClientImage
        {
            private PictureBox edit;
            private string url;

            public WebClientImage(PictureBox a, string b)
            {
                edit = a;
                url = b;
            }
            public void Do()
            {
                try
                {
                    using (var client = new System.Net.WebClient())
                    {
                        using (var strream = client.OpenRead(url))
                        {

                            Image Image = new Bitmap(strream);
                            edit.BeginInvoke(new Action(() =>
                            {
                                edit.Image = Image;
                            }));
                        }
                    }
                }
                catch
                {
                    edit.BeginInvoke(new Action(() =>
                    {
                        edit.Image = null;
                    }));
                }
            }
        }
        private class WebRequestImage
        {
            private PictureBox edit;
            private string url;

            public WebRequestImage(PictureBox a, string b)
            {
                edit = a;
                url = b;
            }
            public void Do()
            {
                try
                {
                    var request = (HttpWebRequest)WebRequest.Create(url);

                    using (var response = (HttpWebResponse)request.GetResponse())
                    {
                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            using (var stream = response.GetResponseStream())
                            {
                                Image Image = new Bitmap(stream);// Bitmap.FromStream(stream);
                                edit.BeginInvoke(new Action(() =>
                                {
                                    edit.Image = Image;
                                }));

                            }
                        }
                    }
                }
                catch
                {
                    edit.BeginInvoke(new Action(() =>
                    {
                        edit.Image = null;
                    }));
                }
            }
        }

    }
}
