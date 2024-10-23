namespace Topic_10___GUIs_Part_2___Adding_Images_to_Reasources
{
    partial class FormAddResouces
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
            this.imgMario = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgMario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imgMario
            // 
            this.imgMario.Image = global::Topic_10___GUIs_Part_2___Adding_Images_to_Reasources.Properties.Resources.MarioSleep;
            this.imgMario.Location = new System.Drawing.Point(197, 254);
            this.imgMario.Name = "imgMario";
            this.imgMario.Size = new System.Drawing.Size(280, 164);
            this.imgMario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMario.TabIndex = 0;
            this.imgMario.TabStop = false;
            this.imgMario.Click += new System.EventHandler(this.imgMario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Topic_10___GUIs_Part_2___Adding_Images_to_Reasources.Properties.Resources.SheepSleep;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 455);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormAddResouces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgMario);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormAddResouces";
            this.Text = "Resources";
            ((System.ComponentModel.ISupportInitialize)(this.imgMario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgMario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

