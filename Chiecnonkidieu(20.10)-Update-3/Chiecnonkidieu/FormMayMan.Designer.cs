﻿namespace Chiecnonkidieu
{
    partial class Formmayman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formmayman));
            this.txtmayman = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timerProgressBar = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btsubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtmayman
            // 
            this.txtmayman.Location = new System.Drawing.Point(461, 116);
            this.txtmayman.Name = "txtmayman";
            this.txtmayman.Size = new System.Drawing.Size(100, 20);
            this.txtmayman.TabIndex = 1;
            this.txtmayman.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmayman_KeyPress);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(388, 142);
            this.progressBar1.Maximum = 95;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(173, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // timerProgressBar
            // 
            this.timerProgressBar.Enabled = true;
            this.timerProgressBar.Tick += new System.EventHandler(this.timerProgressBar_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(272, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thời gian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(272, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vị trí ô muốn mở";
            // 
            // btsubmit
            // 
            this.btsubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btsubmit.BackgroundImage")));
            this.btsubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btsubmit.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btsubmit.Location = new System.Drawing.Point(586, 109);
            this.btsubmit.Name = "btsubmit";
            this.btsubmit.Size = new System.Drawing.Size(84, 30);
            this.btsubmit.TabIndex = 2;
            this.btsubmit.Text = "Xác nhận";
            this.btsubmit.UseVisualStyleBackColor = true;
            this.btsubmit.Click += new System.EventHandler(this.btsubmit_Click);
            // 
            // Formmayman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(735, 233);
            this.Controls.Add(this.btsubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtmayman);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Formmayman";
            this.Text = "May Mắn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtmayman;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timerProgressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btsubmit;
    }
}