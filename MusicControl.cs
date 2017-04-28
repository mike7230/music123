using System;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace music
{
    class MusicControl
    {
        public MusicControl()
        {
        }

        public void Upload()
        {
            Stream musicStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "wav files (*.wav)|*.wav|mp3 files (*.mp3)|*.mp3";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if ( openFileDialog1.ShowDialog() == DialogResult.OK )
            {
                try
                {
                    if ( ( musicStream = openFileDialog1.OpenFile() ) != null )
                    {
                        using ( musicStream )
                        {
                            FtpWebRequest request = (FtpWebRequest) WebRequest.Create( @"ftp:\\1.34.30.96:21\" );
                            request.Method = WebRequestMethods.Ftp.UploadFile;
                            request.Credentials = new NetworkCredential( "UploadMusic" , "UploadMusic" );
                            request.ContentLength = musicStream.Length;
                            using ( Stream ftpStream = request.GetRequestStream() )
                            {
                                musicStream.CopyTo( ftpStream );
                            }
                            FtpWebResponse response = (FtpWebResponse) request.GetResponse();
                            Console.WriteLine( "Upload status: {0}, {1}" , response.StatusCode , response.StatusDescription );
                            response.Close();
                        }
                    }
                }
                catch ( Exception ex )
                {
                    MessageBox.Show( ex.Message );
                }
            }

        }
    }
}
