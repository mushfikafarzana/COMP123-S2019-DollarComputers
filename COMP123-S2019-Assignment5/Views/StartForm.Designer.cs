namespace COMP123_S2019_Assignment5.Views
{
    partial class StartForm
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
            this.StartANewOrderButton = new System.Windows.Forms.Button();
            this.LoadASavedOrderButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.StartFormLabel = new System.Windows.Forms.Label();
            this.StartFormPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.StartFormPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StartANewOrderButton
            // 
            this.StartANewOrderButton.BackColor = System.Drawing.Color.Navy;
            this.StartANewOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartANewOrderButton.ForeColor = System.Drawing.Color.White;
            this.StartANewOrderButton.Location = new System.Drawing.Point(184, 304);
            this.StartANewOrderButton.Name = "StartANewOrderButton";
            this.StartANewOrderButton.Size = new System.Drawing.Size(167, 48);
            this.StartANewOrderButton.TabIndex = 0;
            this.StartANewOrderButton.Text = "Start a New Order";
            this.StartANewOrderButton.UseVisualStyleBackColor = false;
            this.StartANewOrderButton.Click += new System.EventHandler(this.StartANewOrderButton_Click);
            // 
            // LoadASavedOrderButton
            // 
            this.LoadASavedOrderButton.BackColor = System.Drawing.Color.DarkGreen;
            this.LoadASavedOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadASavedOrderButton.ForeColor = System.Drawing.Color.White;
            this.LoadASavedOrderButton.Location = new System.Drawing.Point(444, 304);
            this.LoadASavedOrderButton.Name = "LoadASavedOrderButton";
            this.LoadASavedOrderButton.Size = new System.Drawing.Size(167, 48);
            this.LoadASavedOrderButton.TabIndex = 0;
            this.LoadASavedOrderButton.Text = "Open a Saved Order";
            this.LoadASavedOrderButton.UseVisualStyleBackColor = false;
            this.LoadASavedOrderButton.Click += new System.EventHandler(this.LoadASavedOrderButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Maroon;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(354, 378);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(97, 42);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StartFormLabel
            // 
            this.StartFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartFormLabel.ForeColor = System.Drawing.Color.Navy;
            this.StartFormLabel.Location = new System.Drawing.Point(208, 9);
            this.StartFormLabel.Name = "StartFormLabel";
            this.StartFormLabel.Size = new System.Drawing.Size(363, 65);
            this.StartFormLabel.TabIndex = 2;
            this.StartFormLabel.Text = "Order Your Computer Today!";
            this.StartFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartFormPictureBox
            // 
            this.StartFormPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartFormPictureBox.BackColor = System.Drawing.Color.Black;
            this.StartFormPictureBox.BackgroundImage = global::COMP123_S2019_Assignment5.Properties.Resources.all_laptops;
            this.StartFormPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StartFormPictureBox.Location = new System.Drawing.Point(267, 96);
            this.StartFormPictureBox.Name = "StartFormPictureBox";
            this.StartFormPictureBox.Size = new System.Drawing.Size(249, 177);
            this.StartFormPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StartFormPictureBox.TabIndex = 3;
            this.StartFormPictureBox.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.StartFormPictureBox);
            this.Controls.Add(this.StartFormLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoadASavedOrderButton);
            this.Controls.Add(this.StartANewOrderButton);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Dollar Computers";
            ((System.ComponentModel.ISupportInitialize)(this.StartFormPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartANewOrderButton;
        private System.Windows.Forms.Button LoadASavedOrderButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label StartFormLabel;
        private System.Windows.Forms.PictureBox StartFormPictureBox;
    }
}