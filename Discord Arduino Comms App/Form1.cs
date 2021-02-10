﻿using System;
using System.Windows.Forms;

namespace Discord_Arduino_Comms_App
{
    public partial class DiscordArduinoCommsApp : Form
    {
        public DiscordArduinoCommsApp()
        {
            InitializeComponent();
        }

        // We are creating a method with the parameters, url, msg, and username.
        //
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

        // Automatically send the message, in case the user doesn't have access to keyboard, mouse to press the button.
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.bSendIt_Click(null, null);
        }
        private void bSendIt_Click(object sender, EventArgs e)
        {
            // Run sendWebHook, to the giving address, then the message, and at last the name of the "user"
            sendWebhook("https://discord.com/api/webhooks/808678091244830731/elm2te9hn77oL4lkbZz-yYqMXgKF0sYNi_YPvwx-lzfSnj5ONCdH8B49YtaANynvNaU0", lAutoBesked.Text, "Mark Watney");
        }
    }
}
