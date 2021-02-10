using System.Collections.Specialized;
using System.Net;
using System.Windows.Forms;

namespace Discord_Arduino_Comms_App
{
    class Http
    {
        // We are creating a public byte array method. With the parameter url, NameValueCollection pairs.
        public static byte[] Post(string url, NameValueCollection pairs)
        {
            // We are creating a new WebClient called webClient
            using (WebClient webClient = new WebClient())
            {
                // Created a try cath, to deal with errors
                try
                {
                    return webClient.UploadValues(url, pairs);
                }
                catch (System.Exception q)
                {
                    // A messagebox will popup when an error may occurr
                    MessageBox.Show($"{q}", "Error :/",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }
    }
}
