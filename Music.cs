using System;
using AxWMPLib;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Data;

namespace music
{
    public class Music
    {
        public String ID;
        public String name;
        public String singer;
        public String email;
        public String tag;
        public String info;
        public Lyrics lyrics;
        public String time;

        public Music()
        {
            ID = "";
            name = "";
            singer = "";
            email = "";
            tag = "";
            info = "";
            time = "";
            lyrics = new Lyrics("");
        }

        public Music(String id)
        {
            DataTable result = DB.Select(String.Format("select name , singer , email , tag , lyrics , info from uploadmusic where ID = '{0}'", id));
            if ( result.Rows.Count == 1 )
            {
                ID = id;
                name = result.Rows[ 0 ][ 0 ].ToString();
                singer = result.Rows[ 0 ][ 1 ].ToString();
                email = result.Rows[0][2].ToString();
                tag = result.Rows[ 0 ][ 3 ].ToString();
                lyrics = new Lyrics( result.Rows[ 0 ][ 4 ].ToString() );
                info = result.Rows[ 0 ][ 5 ].ToString();
                time = "";
            }
            else
            {
                ID = "";
                name = "";
                singer = "";
                email = "";
                tag = "";
                info = "";
                time = "";
                lyrics = new Lyrics( "" );
                 throw new Exception( "music not found in DB" );
            }
        }

        public Music( String n , String s , String t , String i , String l )
        {
            ID = "";
            name = n;
            singer = s;
            email = "";
            tag = t;
            info = i;
            time = "";
            lyrics = new Lyrics(l);
        }

        public String Upload( String filename )
        {
            if ( name == "" )
                return "你必須輸入歌曲名稱";
            if ( singer == "" )
                return "你必須輸入創作者/團體";
            if ( !tag.StartsWith( "原創" ) && !tag.StartsWith( "翻唱" ) )
                return "你必須選擇一項分類";
            if( !filename.EndsWith( ".mp3" ) && !filename.EndsWith( ".wav" ) )
                return "你必須選擇正確的音樂檔案";
            generateID();
            if ( DB.SQL( String.Format( "insert into uploadmusic( ID , name , singer , upload , tag , lyrics , info ) values( '{0}' , '{1}' , '{2}' , '{3}' , '{4}' , '{5}' , '{6}' )" , ID , name , singer , Account.email , tag , lyrics.completeLyrics , info ) ) != 1 )
                return "Fail";
            try
            {
                using ( Stream musicStream = new FileStream(filename, FileMode.Open))
                {
                    {
                        FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://1.34.30.96:21/" + Path.GetFileName(filename));
                        request.Method = WebRequestMethods.Ftp.UploadFile;
                        request.Credentials = new NetworkCredential("UploadMusic", "UploadMusic");

                        using (Stream requestStream = request.GetRequestStream())
                        {
                            musicStream.CopyTo(requestStream);
                        }

                        using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                        {
                            if ( response.StatusDescription == "226 Transfer complete." )
                                return "Success";
                            DB.SQL( String.Format( "delete from uploadmusic where ID = '{0}'" , ID ) );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return "Fail";
        }

        public void generateID()
        {
            Random random = new Random();
            String s = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
            while ( true )
            {
                ID = "";
                for ( int i = 0 ; i < 10 ; i++ )
                    ID += s[ random.Next( 0 , s.Length - 1 ) ];
                if ( DB.Select( String.Format( "select * from uploadmusic where ID = '{0}'" , ID ) ).Rows.Count == 0 )
                    break;
            }
        }
    }

}