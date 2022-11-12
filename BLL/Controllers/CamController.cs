using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Drawing.Text;
using BE.DTO;

namespace BLL.Controllers
{
    public class CamController
    {
        string path = @"C:\Users\Public\Documents\";
        private bool areCameras = false;
        private FilterInfoCollection myDispositives;
        private VideoCaptureDevice myVideoSource;
        private PictureBox cam;
        private PictureBox photo;
        private FileSystemWatcher watcher;

        public CamController(PictureBox cam, PictureBox photo, FileSystemWatcher watcher)
        {
            this.cam = cam;
            this.photo = photo;
            this.watcher = watcher;
            watcher.Path = path;
        }

        public void LoadDispositives() {
            myDispositives = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (myDispositives.Count == 0)
            {
                areCameras = false;
            }
            else
            {
                areCameras = true;
            }
        }
        public void CloseCam()
        {
            if (myVideoSource !=null && myVideoSource.IsRunning)
            {
                myVideoSource.SignalToStop();
                myVideoSource = null;
            }
        }
        public void init()
        {
            CloseCam();
            string nombre = myDispositives[0].MonikerString;
            myVideoSource = new VideoCaptureDevice(nombre);
            myVideoSource.NewFrame += new NewFrameEventHandler(Capturing);
            myVideoSource.Start();
        }
        private void Capturing(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Img = (Bitmap) eventArgs.Frame.Clone();
            cam.Image = Img;
        }
        public void TakePhoto(LoginDto log)
        {
            if (myVideoSource != null && myVideoSource.IsRunning)
            {
                photo.Image = cam.Image;
                photo.Image.Save($"{path}{log.mail}{DateTime.Now.ToString("hh.mm")}{DateTime.Now.ToLongDateString()}.jpg",ImageFormat.Jpeg);
            }
        }
        public void GetFiles() {
            string[] list = Directory.GetFiles(path);
            MessageBox.Show("archivo log creado");
        }
    }
}
