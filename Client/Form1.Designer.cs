namespace Client
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
            this.components = new System.ComponentModel.Container();
            this.status_txt = new System.Windows.Forms.TextBox();
            this.port_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.host_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.message_txt = new System.Windows.Forms.TextBox();
            this.connection_btn = new System.Windows.Forms.Button();
            this.send_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // status_txt
            // 
            this.status_txt.Location = new System.Drawing.Point(17, 259);
            this.status_txt.Multiline = true;
            this.status_txt.Name = "status_txt";
            this.status_txt.ReadOnly = true;
            this.status_txt.Size = new System.Drawing.Size(326, 66);
            this.status_txt.TabIndex = 7;
            // 
            // port_txt
            // 
            this.port_txt.Location = new System.Drawing.Point(265, 59);
            this.port_txt.Name = "port_txt";
            this.port_txt.Size = new System.Drawing.Size(50, 20);
            this.port_txt.TabIndex = 2;
            this.port_txt.Text = "8190";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(202, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // host_txt
            // 
            this.host_txt.Location = new System.Drawing.Point(80, 59);
            this.host_txt.Name = "host_txt";
            this.host_txt.Size = new System.Drawing.Size(100, 20);
            this.host_txt.TabIndex = 1;
            this.host_txt.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Host";
            // 
            // message_txt
            // 
            this.message_txt.Location = new System.Drawing.Point(17, 144);
            this.message_txt.Multiline = true;
            this.message_txt.Name = "message_txt";
            this.message_txt.Size = new System.Drawing.Size(326, 51);
            this.message_txt.TabIndex = 4;
            // 
            // connection_btn
            // 
            this.connection_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(183)))), ((int)(((byte)(194)))));
            this.connection_btn.FlatAppearance.BorderSize = 0;
            this.connection_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connection_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connection_btn.Location = new System.Drawing.Point(17, 108);
            this.connection_btn.Name = "connection_btn";
            this.connection_btn.Size = new System.Drawing.Size(124, 31);
            this.connection_btn.TabIndex = 3;
            this.connection_btn.Text = "Connect";
            this.connection_btn.UseVisualStyleBackColor = false;
            this.connection_btn.Click += new System.EventHandler(this.connection_btn_Click);
            // 
            // send_btn
            // 
            this.send_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(142)))), ((int)(((byte)(74)))));
            this.send_btn.FlatAppearance.BorderSize = 0;
            this.send_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_btn.Location = new System.Drawing.Point(17, 222);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(124, 31);
            this.send_btn.TabIndex = 5;
            this.send_btn.Text = "Send";
            this.send_btn.UseVisualStyleBackColor = false;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(114)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 33);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(336, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "CLIENT";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(361, 347);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.connection_btn);
            this.Controls.Add(this.message_txt);
            this.Controls.Add(this.status_txt);
            this.Controls.Add(this.port_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.host_txt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox status_txt;
        private System.Windows.Forms.TextBox port_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox host_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox message_txt;
        private System.Windows.Forms.Button connection_btn;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

