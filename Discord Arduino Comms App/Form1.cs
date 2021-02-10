using System;
using System.Windows.Forms;

namespace Discord_Arduino_Comms_App
{
    public partial class DiscordArduinoCommsApp : Form
    {
        public DiscordArduinoCommsApp()
        {
            InitializeComponent();
        }
        public static void sendWebhook(string url, string msg, string username)
        {
            Http.Post(url, new System.Collections.Specialized.NameValueCollection()
            {
                {
                    "username",
                    username
                },
                {
                    "content",
                    msg
                }
            });
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.bSendIt_Click(null, null);
        }
        private void bSendIt_Click(object sender, EventArgs e)
        {
            sendWebhook("https://discord.com/api/webhooks/808678967837851708/92SfwqlblxIc70KNWgaJEDTSrIt4Cir-JCf5LuHen1c4v9rcx_IuPTdw-sB8LRdIKrMq", lAutoBesked.Text, "Mark Watney");
        }
    }
}
