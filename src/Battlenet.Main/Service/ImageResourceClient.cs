using System.Net;

namespace Battlenet.Main.Service
{
    public class ImageResourceClient
    {
        public Byte[] GetData(string url)
        {
            using (WebClient client = new WebClient ())
            {
                byte[] imgArray;
                imgArray = client.DownloadData (url);

                return imgArray;
            }
        }
    }
}
