using System.Collections.Specialized;
using System.Net;
using System.Windows.Forms;

namespace Discord_Arduino_Comms_App
{
    class Http
    {
        public static byte[] Post(string url, NameValueCollection pairs)
        {
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    return webClient.UploadValues(url, pairs);
                }
                catch (System.Exception)
                {
                    MessageBox.Show("The remote server returned an error: (429) Too Many Requests", "Error :/",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }
    }
}
