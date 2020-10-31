namespace Server_Abdul_Eriawan_Nahar_20180140118
{
    partial class Form1
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
            this.Server = new System.Windows.Forms.Label();
            this.ServerOn = new System.Windows.Forms.Label();
            this.ServerOFF = new System.Windows.Forms.Label();
            this.buttonON = new System.Windows.Forms.Button();
            this.buttonOFF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Server
            // 
            this.Server.AutoSize = true;
            this.Server.Location = new System.Drawing.Point(293, 53);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(38, 13);
            this.Server.TabIndex = 0;
            this.Server.Text = "Server";
            // 
            // ServerOn
            // 
            this.ServerOn.AutoSize = true;
            this.ServerOn.Location = new System.Drawing.Point(293, 114);
            this.ServerOn.Name = "ServerOn";
            this.ServerOn.Size = new System.Drawing.Size(57, 13);
            this.ServerOn.TabIndex = 1;
            this.ServerOn.Text = "Server ON";
            // 
            // ServerOFF
            // 
            this.ServerOFF.AutoSize = true;
            this.ServerOFF.Location = new System.Drawing.Point(296, 144);
            this.ServerOFF.Name = "ServerOFF";
            this.ServerOFF.Size = new System.Drawing.Size(166, 13);
            this.ServerOFF.TabIndex = 2;
            this.ServerOFF.Text = "Klik OFF untuk Mematikan Server";
            // 
            // buttonON
            // 
            this.buttonON.Location = new System.Drawing.Point(266, 189);
            this.buttonON.Name = "buttonON";
            this.buttonON.Size = new System.Drawing.Size(75, 23);
            this.buttonON.TabIndex = 3;
            this.buttonON.Text = "ON";
            this.buttonON.UseVisualStyleBackColor = true;
            this.buttonON.Click += new System.EventHandler(this.buttonON_Click);
            // 
            // buttonOFF
            // 
            this.buttonOFF.Location = new System.Drawing.Point(418, 189);
            this.buttonOFF.Name = "buttonOFF";
            this.buttonOFF.Size = new System.Drawing.Size(75, 23);
            this.buttonOFF.TabIndex = 4;
            this.buttonOFF.Text = "OFF";
            this.buttonOFF.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 353);
            this.Controls.Add(this.buttonOFF);
            this.Controls.Add(this.buttonON);
            this.Controls.Add(this.ServerOFF);
            this.Controls.Add(this.ServerOn);
            this.Controls.Add(this.Server);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Server;
        private System.Windows.Forms.Label ServerOn;
        private System.Windows.Forms.Label ServerOFF;
        private System.Windows.Forms.Button buttonON;
        private System.Windows.Forms.Button buttonOFF;
    }
}

