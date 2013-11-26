namespace Oro2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.world = new System.Windows.Forms.PictureBox();
            this.input = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.story = new System.Windows.Forms.TextBox();
            this.frame = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.world)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame)).BeginInit();
            this.SuspendLayout();
            // 
            // world
            // 
            this.world.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.world.BackColor = System.Drawing.Color.Transparent;
            this.world.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.world.ErrorImage = null;
            this.world.Location = new System.Drawing.Point(37, 17);
            this.world.Name = "world";
            this.world.Size = new System.Drawing.Size(860, 425);
            this.world.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.world.TabIndex = 0;
            this.world.TabStop = false;
            // 
            // input
            // 
            this.input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.Location = new System.Drawing.Point(37, 584);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(860, 30);
            this.input.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(822, 584);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // story
            // 
            this.story.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.story.BackColor = System.Drawing.Color.Black;
            this.story.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.story.Cursor = System.Windows.Forms.Cursors.Default;
            this.story.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.story.ForeColor = System.Drawing.Color.White;
            this.story.Location = new System.Drawing.Point(37, 448);
            this.story.Multiline = true;
            this.story.Name = "story";
            this.story.ReadOnly = true;
            this.story.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.story.Size = new System.Drawing.Size(860, 130);
            this.story.TabIndex = 4;
            this.story.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frame
            // 
            this.frame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.frame.Location = new System.Drawing.Point(12, 7);
            this.frame.Name = "frame";
            this.frame.Size = new System.Drawing.Size(910, 640);
            this.frame.TabIndex = 5;
            this.frame.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(934, 622);
            this.Controls.Add(this.story);
            this.Controls.Add(this.world);
            this.Controls.Add(this.input);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.frame);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "A Short Tail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.world)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox world;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox story;
        private System.Windows.Forms.PictureBox frame;
    }
}

