﻿namespace GiuaKyDocNet
{
    partial class frmTourDL
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
            this.trangChuBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trangChuBtn
            // 
            this.trangChuBtn.Location = new System.Drawing.Point(12, 12);
            this.trangChuBtn.Name = "trangChuBtn";
            this.trangChuBtn.Size = new System.Drawing.Size(116, 33);
            this.trangChuBtn.TabIndex = 0;
            this.trangChuBtn.Text = "Trang chủ";
            this.trangChuBtn.UseVisualStyleBackColor = true;
            this.trangChuBtn.Click += new System.EventHandler(this.trangChuBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Trang chủ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmTourDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.trangChuBtn);
            this.Name = "frmTourDL";
            this.Text = "frmTourDL";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button trangChuBtn;
        private System.Windows.Forms.Button button2;
    }
}