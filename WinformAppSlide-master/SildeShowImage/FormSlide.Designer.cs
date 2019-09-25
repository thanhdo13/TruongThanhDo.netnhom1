﻿namespace SildeShowImage
{
    partial class FormSlide
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
            this.panel_slide = new System.Windows.Forms.Panel();
            this.pic_slide = new System.Windows.Forms.PictureBox();
            this.panel_controll = new System.Windows.Forms.Panel();
            this.pic_right = new System.Windows.Forms.PictureBox();
            this.pic_left = new System.Windows.Forms.PictureBox();
            this.pic_center = new System.Windows.Forms.PictureBox();
            this.timer_slide = new System.Windows.Forms.Timer(this.components);
            this.picleftleft = new System.Windows.Forms.PictureBox();
            this.picrightright = new System.Windows.Forms.PictureBox();
            this.panel_slide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_slide)).BeginInit();
            this.panel_controll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_center)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picleftleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picrightright)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_slide
            // 
            this.panel_slide.Controls.Add(this.pic_slide);
            this.panel_slide.Controls.Add(this.panel_controll);
            this.panel_slide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_slide.Location = new System.Drawing.Point(0, 0);
            this.panel_slide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_slide.Name = "panel_slide";
            this.panel_slide.Size = new System.Drawing.Size(1045, 469);
            this.panel_slide.TabIndex = 0;
            // 
            // pic_slide
            // 
            this.pic_slide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_slide.Location = new System.Drawing.Point(0, 0);
            this.pic_slide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_slide.Name = "pic_slide";
            this.pic_slide.Size = new System.Drawing.Size(1045, 404);
            this.pic_slide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_slide.TabIndex = 1;
            this.pic_slide.TabStop = false;
            // 
            // panel_controll
            // 
            this.panel_controll.Controls.Add(this.picrightright);
            this.panel_controll.Controls.Add(this.picleftleft);
            this.panel_controll.Controls.Add(this.pic_right);
            this.panel_controll.Controls.Add(this.pic_left);
            this.panel_controll.Controls.Add(this.pic_center);
            this.panel_controll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_controll.Location = new System.Drawing.Point(0, 404);
            this.panel_controll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_controll.Name = "panel_controll";
            this.panel_controll.Size = new System.Drawing.Size(1045, 65);
            this.panel_controll.TabIndex = 0;
            // 
            // pic_right
            // 
            this.pic_right.Location = new System.Drawing.Point(608, 16);
            this.pic_right.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_right.Name = "pic_right";
            this.pic_right.Size = new System.Drawing.Size(80, 37);
            this.pic_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_right.TabIndex = 2;
            this.pic_right.TabStop = false;
            this.pic_right.Click += new System.EventHandler(this.Pic_right_Click);
            // 
            // pic_left
            // 
            this.pic_left.Location = new System.Drawing.Point(380, 15);
            this.pic_left.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_left.Name = "pic_left";
            this.pic_left.Size = new System.Drawing.Size(80, 39);
            this.pic_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_left.TabIndex = 1;
            this.pic_left.TabStop = false;
            this.pic_left.Click += new System.EventHandler(this.Pic_left_Click);
            // 
            // pic_center
            // 
            this.pic_center.Location = new System.Drawing.Point(481, 10);
            this.pic_center.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_center.Name = "pic_center";
            this.pic_center.Size = new System.Drawing.Size(107, 49);
            this.pic_center.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_center.TabIndex = 0;
            this.pic_center.TabStop = false;
            this.pic_center.Click += new System.EventHandler(this.Pic_center_Click);
            // 
            // timer_slide
            // 
            this.timer_slide.Enabled = true;
            this.timer_slide.Interval = 2000;
            this.timer_slide.Tick += new System.EventHandler(this.Timer_slide_Tick);
            // 
            // picleftleft
            // 
            this.picleftleft.Location = new System.Drawing.Point(281, 13);
            this.picleftleft.Name = "picleftleft";
            this.picleftleft.Size = new System.Drawing.Size(79, 40);
            this.picleftleft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picleftleft.TabIndex = 3;
            this.picleftleft.TabStop = false;
            // 
            // picrightright
            // 
            this.picrightright.Location = new System.Drawing.Point(707, 15);
            this.picrightright.Name = "picrightright";
            this.picrightright.Size = new System.Drawing.Size(79, 39);
            this.picrightright.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picrightright.TabIndex = 4;
            this.picrightright.TabStop = false;
            // 
            // FormSlide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 469);
            this.Controls.Add(this.panel_slide);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSlide";
            this.Text = "Form_Slide";
            this.panel_slide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_slide)).EndInit();
            this.panel_controll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_center)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picleftleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picrightright)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_slide;
        private System.Windows.Forms.PictureBox pic_slide;
        private System.Windows.Forms.Panel panel_controll;
        private System.Windows.Forms.Timer timer_slide;
        private System.Windows.Forms.PictureBox pic_right;
        private System.Windows.Forms.PictureBox pic_left;
        private System.Windows.Forms.PictureBox pic_center;
        private System.Windows.Forms.PictureBox picleftleft;
        private System.Windows.Forms.PictureBox picrightright;
    }
}

