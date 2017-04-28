using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Xml;

namespace music
{
    public static class PlayList
    {
        public static List<Music> current = new List<Music>();
        public static Dictionary<String , List<Music>> local = new Dictionary<string, List<Music>>();
        public static Dictionary<String , List<Music>> account = new Dictionary<string , List<Music>>();

        public static void save()
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement( "current" );
            XmlElement leaf;
            foreach ( Music m in PlayList.current )
            {
                leaf = doc.CreateElement( "music" );
                leaf.SetAttribute( "ID" , m.ID );
                root.AppendChild( leaf );
            }
            doc.AppendChild( root );
            foreach ( String l in PlayList.local.Keys )
            {
                root = doc.CreateElement( l );
                foreach ( Music m in PlayList.local[l] )
                {
                    leaf = doc.CreateElement( "music" );
                    leaf.SetAttribute( "ID" , m.ID );
                    root.AppendChild( leaf );
                }
                doc.AppendChild( root );
            }
            doc.Save( "music.xml" );
        }
        public static void load()
        {
            if ( Account.islogin )
            {
                DataTable result = DB.Select( String.Format( "select name , music from playlist where email = '{0}'" , Account.email ) );
                foreach ( DataRow row in result.Rows )
                {
                    if( !account.ContainsKey( row[ 0 ].ToString() ) )
                        account.Add( row[0].ToString() , new List<Music>() );
                    account[ row[ 0 ].ToString() ].Add( new Music( row[1].ToString() ) );
                }
            }
            else if ( File.Exists( "music.xml" ) )
            {
                XmlDocument doc = new XmlDocument();
                doc.Load( "music.xml" );
                foreach ( XmlNode root in doc.ChildNodes )
                {
                    if ( root.Name == "current" )
                    {
                        foreach ( XmlNode leaf in root.ChildNodes )
                        {
                            current.Add( new Music( leaf.Attributes["ID"].InnerText ) );
                        }
                    }
                    else
                    {

                        local.Add( root.Name , new List<Music>() );
                        foreach ( XmlNode leaf in root.ChildNodes )
                            local[ root.Name ].Add( new Music( leaf.Attributes[ "IS" ].InnerText ) );
                    }
                }
            }
        }

    }
}
