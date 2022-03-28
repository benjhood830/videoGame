namespace videoGame
{
    partial class videoGame
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.option2Button = new System.Windows.Forms.Button();
            this.option1Button = new System.Windows.Forms.Button();
            this.option3Button = new System.Windows.Forms.Button();
            this.option1Label = new System.Windows.Forms.Label();
            this.option2Label = new System.Windows.Forms.Label();
            this.option3Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Rockwell", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(105, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(614, 77);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "School Simulation ";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Lime;
            this.startButton.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(262, 129);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(250, 250);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.BackColor = System.Drawing.Color.Black;
            this.descriptionLabel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.White;
            this.descriptionLabel.Location = new System.Drawing.Point(89, 9);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(621, 107);
            this.descriptionLabel.TabIndex = 2;
            // 
            // option2Button
            // 
            this.option2Button.Location = new System.Drawing.Point(140, 312);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(54, 52);
            this.option2Button.TabIndex = 3;
            this.option2Button.UseVisualStyleBackColor = true;
            this.option2Button.Visible = false;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option1Button
            // 
            this.option1Button.Location = new System.Drawing.Point(140, 234);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(54, 52);
            this.option1Button.TabIndex = 4;
            this.option1Button.UseVisualStyleBackColor = true;
            this.option1Button.Visible = false;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // option3Button
            // 
            this.option3Button.Location = new System.Drawing.Point(140, 386);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(54, 52);
            this.option3Button.TabIndex = 5;
            this.option3Button.UseVisualStyleBackColor = true;
            this.option3Button.Visible = false;
            this.option3Button.Click += new System.EventHandler(this.option3Button_Click);
            // 
            // option1Label
            // 
            this.option1Label.BackColor = System.Drawing.Color.Black;
            this.option1Label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Label.ForeColor = System.Drawing.Color.White;
            this.option1Label.Location = new System.Drawing.Point(200, 248);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(581, 52);
            this.option1Label.TabIndex = 6;
            // 
            // option2Label
            // 
            this.option2Label.BackColor = System.Drawing.Color.Black;
            this.option2Label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Label.ForeColor = System.Drawing.Color.White;
            this.option2Label.Location = new System.Drawing.Point(200, 327);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(581, 52);
            this.option2Label.TabIndex = 7;
            // 
            // option3Label
            // 
            this.option3Label.BackColor = System.Drawing.Color.Black;
            this.option3Label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3Label.ForeColor = System.Drawing.Color.White;
            this.option3Label.Location = new System.Drawing.Point(200, 400);
            this.option3Label.Name = "option3Label";
            this.option3Label.Size = new System.Drawing.Size(581, 52);
            this.option3Label.TabIndex = 8;
            // 
            // videoGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option3Label);
            this.Name = "videoGame";
            this.Text = "School Day";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Button option3Button;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.Label option3Label;
    }
}

