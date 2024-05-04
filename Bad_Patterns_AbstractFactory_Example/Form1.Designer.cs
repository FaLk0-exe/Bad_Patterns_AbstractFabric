namespace Bad_Patterns_AbstractFactory_Example
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
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.vodkaDrinkButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.coffeeDrinkButton = new System.Windows.Forms.Button();
            this.waterDrinkButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.alcoholicHealthLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(147, 49);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(533, 295);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // vodkaDrinkButton
            // 
            this.vodkaDrinkButton.Location = new System.Drawing.Point(185, 377);
            this.vodkaDrinkButton.Name = "vodkaDrinkButton";
            this.vodkaDrinkButton.Size = new System.Drawing.Size(75, 23);
            this.vodkaDrinkButton.TabIndex = 1;
            this.vodkaDrinkButton.Text = "Водка";
            this.vodkaDrinkButton.UseVisualStyleBackColor = true;
            this.vodkaDrinkButton.Click += new System.EventHandler(this.vodkaDrinkButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bad_Patterns_AbstractFactory_Example.Properties.Resources.stop_video_image;
            this.pictureBox1.Location = new System.Drawing.Point(147, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(533, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // coffeeDrinkButton
            // 
            this.coffeeDrinkButton.Location = new System.Drawing.Point(377, 377);
            this.coffeeDrinkButton.Name = "coffeeDrinkButton";
            this.coffeeDrinkButton.Size = new System.Drawing.Size(75, 23);
            this.coffeeDrinkButton.TabIndex = 3;
            this.coffeeDrinkButton.Text = "Кофе";
            this.coffeeDrinkButton.UseVisualStyleBackColor = true;
            this.coffeeDrinkButton.Click += new System.EventHandler(this.coffeeDrinkButton_Click);
            // 
            // waterDrinkButton
            // 
            this.waterDrinkButton.Location = new System.Drawing.Point(570, 377);
            this.waterDrinkButton.Name = "waterDrinkButton";
            this.waterDrinkButton.Size = new System.Drawing.Size(75, 23);
            this.waterDrinkButton.TabIndex = 4;
            this.waterDrinkButton.Text = "Вода";
            this.waterDrinkButton.UseVisualStyleBackColor = true;
            this.waterDrinkButton.Click += new System.EventHandler(this.waterDrinkButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(170, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "ХП АЛКОГОЛИКА:";
            // 
            // alcoholicHealthLabel
            // 
            this.alcoholicHealthLabel.AutoSize = true;
            this.alcoholicHealthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alcoholicHealthLabel.Location = new System.Drawing.Point(372, 9);
            this.alcoholicHealthLabel.Name = "alcoholicHealthLabel";
            this.alcoholicHealthLabel.Size = new System.Drawing.Size(0, 25);
            this.alcoholicHealthLabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.alcoholicHealthLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.waterDrinkButton);
            this.Controls.Add(this.coffeeDrinkButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.vodkaDrinkButton);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlcoholicGame";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button vodkaDrinkButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button coffeeDrinkButton;
        private System.Windows.Forms.Button waterDrinkButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label alcoholicHealthLabel;
    }
}

