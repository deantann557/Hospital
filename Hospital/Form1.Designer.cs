namespace Hospital
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
            this.option1 = new System.Windows.Forms.Button();
            this.option2 = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.option1Label = new System.Windows.Forms.Label();
            this.option2Label = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // option1
            // 
            this.option1.Location = new System.Drawing.Point(331, 303);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(75, 46);
            this.option1.TabIndex = 0;
            this.option1.UseVisualStyleBackColor = true;
            this.option1.Click += new System.EventHandler(this.option1_Click);
            // 
            // option2
            // 
            this.option2.Location = new System.Drawing.Point(331, 376);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(75, 48);
            this.option2.TabIndex = 1;
            this.option2.UseVisualStyleBackColor = true;
            this.option2.Click += new System.EventHandler(this.option2_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.outputLabel.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.outputLabel.Location = new System.Drawing.Point(0, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(476, 300);
            this.outputLabel.TabIndex = 2;
            // 
            // option1Label
            // 
            this.option1Label.BackColor = System.Drawing.SystemColors.Control;
            this.option1Label.Location = new System.Drawing.Point(32, 303);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(293, 46);
            this.option1Label.TabIndex = 3;
            // 
            // option2Label
            // 
            this.option2Label.BackColor = System.Drawing.SystemColors.Control;
            this.option2Label.Location = new System.Drawing.Point(32, 376);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(293, 48);
            this.option2Label.TabIndex = 4;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox.ErrorImage = null;
            this.pictureBox.Image = global::Hospital.Properties.Resources.Abandoned_hospitals;
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(467, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(381, 449);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(848, 450);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.option1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hospital";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button option1;
        private System.Windows.Forms.Button option2;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

