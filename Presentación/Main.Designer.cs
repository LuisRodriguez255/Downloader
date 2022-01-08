
namespace Downloader.Presentación
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_progress = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btn_mp4 = new System.Windows.Forms.Button();
            this.btn_mp3 = new System.Windows.Forms.Button();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbl_progress);
            this.panel1.Controls.Add(this.progressBar);
            this.panel1.Controls.Add(this.btn_mp4);
            this.panel1.Controls.Add(this.btn_mp3);
            this.panel1.Controls.Add(this.txt_url);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 342);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panel2.Location = new System.Drawing.Point(207, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 1);
            this.panel2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(719, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 57);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_progress
            // 
            this.lbl_progress.AutoSize = true;
            this.lbl_progress.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_progress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lbl_progress.Location = new System.Drawing.Point(551, 213);
            this.lbl_progress.Name = "lbl_progress";
            this.lbl_progress.Size = new System.Drawing.Size(45, 30);
            this.lbl_progress.TabIndex = 4;
            this.lbl_progress.Text = "0%";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(207, 213);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(316, 31);
            this.progressBar.TabIndex = 3;
            // 
            // btn_mp4
            // 
            this.btn_mp4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btn_mp4.FlatAppearance.BorderSize = 0;
            this.btn_mp4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mp4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_mp4.ForeColor = System.Drawing.Color.Black;
            this.btn_mp4.Location = new System.Drawing.Point(487, 93);
            this.btn_mp4.Name = "btn_mp4";
            this.btn_mp4.Size = new System.Drawing.Size(107, 51);
            this.btn_mp4.TabIndex = 2;
            this.btn_mp4.Text = "Descargar MP4";
            this.btn_mp4.UseVisualStyleBackColor = false;
            this.btn_mp4.Click += new System.EventHandler(this.btn_mp4_Click);
            // 
            // btn_mp3
            // 
            this.btn_mp3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btn_mp3.FlatAppearance.BorderSize = 0;
            this.btn_mp3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mp3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_mp3.ForeColor = System.Drawing.Color.Black;
            this.btn_mp3.Location = new System.Drawing.Point(207, 93);
            this.btn_mp3.Name = "btn_mp3";
            this.btn_mp3.Size = new System.Drawing.Size(107, 51);
            this.btn_mp3.TabIndex = 1;
            this.btn_mp3.Text = "Descargar MP3";
            this.btn_mp3.UseVisualStyleBackColor = false;
            this.btn_mp3.Click += new System.EventHandler(this.btn_mp3_Click);
            // 
            // txt_url
            // 
            this.txt_url.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(33)))));
            this.txt_url.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_url.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_url.ForeColor = System.Drawing.Color.White;
            this.txt_url.Location = new System.Drawing.Point(207, 35);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(387, 34);
            this.txt_url.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 342);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_progress;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btn_mp4;
        private System.Windows.Forms.Button btn_mp3;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
    }
}