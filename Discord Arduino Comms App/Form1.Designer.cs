
namespace Discord_Arduino_Comms_App
{
    partial class DiscordArduinoCommsApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bSendIt = new System.Windows.Forms.Button();
            this.lAutoBesked = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bSendIt
            // 
            this.bSendIt.Location = new System.Drawing.Point(12, 47);
            this.bSendIt.Name = "bSendIt";
            this.bSendIt.Size = new System.Drawing.Size(180, 80);
            this.bSendIt.TabIndex = 3;
            this.bSendIt.Text = "BESKED SENDT!";
            this.bSendIt.UseVisualStyleBackColor = true;
            this.bSendIt.Click += new System.EventHandler(this.bSendIt_Click);
            // 
            // lAutoBesked
            // 
            this.lAutoBesked.AutoSize = true;
            this.lAutoBesked.Location = new System.Drawing.Point(12, 9);
            this.lAutoBesked.Name = "lAutoBesked";
            this.lAutoBesked.Size = new System.Drawing.Size(156, 26);
            this.lAutoBesked.TabIndex = 4;
            this.lAutoBesked.Text = "Min kommunikation virker ikke. \r\nDette er en automatisk besked.\r\n";
            // 
            // DiscordArduinoCommsApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(204, 148);
            this.Controls.Add(this.lAutoBesked);
            this.Controls.Add(this.bSendIt);
            this.MaximizeBox = false;
            this.Name = "DiscordArduinoCommsApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discord Arduino Comms App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bSendIt;
        private System.Windows.Forms.Label lAutoBesked;
    }
}

