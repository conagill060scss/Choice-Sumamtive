namespace Choice_Sumamtive
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonBlue = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.outputLabel.Location = new System.Drawing.Point(0, -1);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(500, 159);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Visible = false;
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.Black;
            this.buttonRed.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonRed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonRed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRed.ForeColor = System.Drawing.Color.Red;
            this.buttonRed.Location = new System.Drawing.Point(3, 161);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(201, 51);
            this.buttonRed.TabIndex = 1;
            this.buttonRed.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Visible = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonBlue
            // 
            this.buttonBlue.BackColor = System.Drawing.Color.Black;
            this.buttonBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBlue.ForeColor = System.Drawing.Color.Blue;
            this.buttonBlue.Location = new System.Drawing.Point(3, 272);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(201, 48);
            this.buttonBlue.TabIndex = 2;
            this.buttonBlue.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonBlue.UseVisualStyleBackColor = false;
            this.buttonBlue.Visible = false;
            this.buttonBlue.Click += new System.EventHandler(this.buttonBlue_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startButton.Location = new System.Drawing.Point(189, 44);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(111, 49);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Location = new System.Drawing.Point(225, 161);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(275, 173);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.Location = new System.Drawing.Point(3, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 48);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Choice_Sumamtive.Properties.Resources._04KJER0243;
            this.ClientSize = new System.Drawing.Size(500, 332);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.buttonBlue);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.outputLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonBlue;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button3;
    }
}

