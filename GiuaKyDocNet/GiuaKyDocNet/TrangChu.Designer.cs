﻿namespace GiuaKyDocNet
{
    partial class TrangChu
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
            this.tourDLButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tourDLButton
            // 
            this.tourDLButton.Location = new System.Drawing.Point(44, 80);
            this.tourDLButton.Name = "tourDLButton";
            this.tourDLButton.Size = new System.Drawing.Size(129, 123);
            this.tourDLButton.TabIndex = 0;
            this.tourDLButton.Text = "Danh sách tour du lịch";
            this.tourDLButton.UseVisualStyleBackColor = true;
            this.tourDLButton.Click += new System.EventHandler(this.tourDLButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(203, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 123);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(363, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 123);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(533, 80);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 123);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(44, 242);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(129, 123);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tourDLButton);
            this.Name = "TrangChu";
            this.Text = "TrangChu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tourDLButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}