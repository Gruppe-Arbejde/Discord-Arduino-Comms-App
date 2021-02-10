
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscordArduinoCommsApp));
            this.bSendIt = new System.Windows.Forms.Button();
            this.lAutoBesked = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bSendIt
            // 
            this.bSendIt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bSendIt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bSendIt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bSendIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSendIt.Location = new System.Drawing.Point(352, 411);
            this.bSendIt.Name = "bSendIt";
            this.bSendIt.Size = new System.Drawing.Size(180, 80);
            this.bSendIt.TabIndex = 3;
            this.bSendIt.Text = "SEND BESKED IGEN!";
            this.bSendIt.UseVisualStyleBackColor = false;
            this.bSendIt.Click += new System.EventHandler(this.bSendIt_Click);
            // 
            // lAutoBesked
            // 
            this.lAutoBesked.AutoSize = true;
            this.lAutoBesked.Location = new System.Drawing.Point(12, 9);
            this.lAutoBesked.Name = "lAutoBesked";
            this.lAutoBesked.Size = new System.Drawing.Size(242, 26);
            this.lAutoBesked.TabIndex = 4;
            this.lAutoBesked.Text = "My communications are down. I need assistance! \r\n*This is an automated message.*";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Discord_Arduino_Comms_App.Properties.Resources.MARK_HELP_GIF;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(911, 537);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // DiscordArduinoCommsApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(911, 537);
            this.Controls.Add(this.bSendIt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lAutoBesked);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DiscordArduinoCommsApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discord Arduino Comms App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bSendIt;
        private System.Windows.Forms.Label lAutoBesked;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

