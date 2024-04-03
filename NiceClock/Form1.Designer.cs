namespace NiceClock
{
    partial class NiceClock
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ClockLabel = new System.Windows.Forms.Label();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.redButton = new System.Windows.Forms.Button();
            this.BlueButton = new System.Windows.Forms.Button();
            this.YellowButton = new System.Windows.Forms.Button();
            this.PurpleButton = new System.Windows.Forms.Button();
            this.OrangeButton = new System.Windows.Forms.Button();
            this.StyleButton1 = new System.Windows.Forms.Button();
            this.StyleButton2 = new System.Windows.Forms.Button();
            this.StyleButton3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClockLabel
            // 
            this.ClockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 92.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClockLabel.ForeColor = System.Drawing.Color.Red;
            this.ClockLabel.Location = new System.Drawing.Point(12, 9);
            this.ClockLabel.Name = "ClockLabel";
            this.ClockLabel.Size = new System.Drawing.Size(875, 437);
            this.ClockLabel.TabIndex = 0;
            this.ClockLabel.Text = "Loading...";
            this.ClockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClockLabel.Click += new System.EventHandler(this.ClockLabel_Click);
            // 
            // ClockTimer
            // 
            this.ClockTimer.Interval = 1000;
            this.ClockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.Location = new System.Drawing.Point(12, 456);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(36, 23);
            this.redButton.TabIndex = 1;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // BlueButton
            // 
            this.BlueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BlueButton.Location = new System.Drawing.Point(66, 456);
            this.BlueButton.Name = "BlueButton";
            this.BlueButton.Size = new System.Drawing.Size(34, 23);
            this.BlueButton.TabIndex = 2;
            this.BlueButton.UseVisualStyleBackColor = false;
            this.BlueButton.Click += new System.EventHandler(this.BlueButton_Click);
            // 
            // YellowButton
            // 
            this.YellowButton.BackColor = System.Drawing.Color.Yellow;
            this.YellowButton.Location = new System.Drawing.Point(124, 456);
            this.YellowButton.Name = "YellowButton";
            this.YellowButton.Size = new System.Drawing.Size(35, 23);
            this.YellowButton.TabIndex = 3;
            this.YellowButton.UseVisualStyleBackColor = false;
            this.YellowButton.Click += new System.EventHandler(this.YellowButton_Click);
            // 
            // PurpleButton
            // 
            this.PurpleButton.BackColor = System.Drawing.Color.Purple;
            this.PurpleButton.Location = new System.Drawing.Point(186, 456);
            this.PurpleButton.Name = "PurpleButton";
            this.PurpleButton.Size = new System.Drawing.Size(34, 23);
            this.PurpleButton.TabIndex = 4;
            this.PurpleButton.UseVisualStyleBackColor = false;
            this.PurpleButton.Click += new System.EventHandler(this.PurpleButton_Click);
            // 
            // OrangeButton
            // 
            this.OrangeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.OrangeButton.Location = new System.Drawing.Point(247, 456);
            this.OrangeButton.Name = "OrangeButton";
            this.OrangeButton.Size = new System.Drawing.Size(41, 23);
            this.OrangeButton.TabIndex = 5;
            this.OrangeButton.UseVisualStyleBackColor = false;
            this.OrangeButton.Click += new System.EventHandler(this.OrangeButton_Click);
            // 
            // StyleButton1
            // 
            this.StyleButton1.BackColor = System.Drawing.Color.White;
            this.StyleButton1.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StyleButton1.Location = new System.Drawing.Point(360, 456);
            this.StyleButton1.Name = "StyleButton1";
            this.StyleButton1.Size = new System.Drawing.Size(75, 23);
            this.StyleButton1.TabIndex = 6;
            this.StyleButton1.Text = "Style1";
            this.StyleButton1.UseVisualStyleBackColor = false;
            this.StyleButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StyleButton2
            // 
            this.StyleButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StyleButton2.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StyleButton2.Location = new System.Drawing.Point(500, 456);
            this.StyleButton2.Name = "StyleButton2";
            this.StyleButton2.Size = new System.Drawing.Size(75, 23);
            this.StyleButton2.TabIndex = 7;
            this.StyleButton2.Text = "Style2";
            this.StyleButton2.UseVisualStyleBackColor = false;
            this.StyleButton2.Click += new System.EventHandler(this.StyleButton2_Click);
            // 
            // StyleButton3
            // 
            this.StyleButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StyleButton3.Font = new System.Drawing.Font("MS Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StyleButton3.Location = new System.Drawing.Point(652, 456);
            this.StyleButton3.Name = "StyleButton3";
            this.StyleButton3.Size = new System.Drawing.Size(75, 23);
            this.StyleButton3.TabIndex = 8;
            this.StyleButton3.Text = "Style3";
            this.StyleButton3.UseVisualStyleBackColor = false;
            this.StyleButton3.Click += new System.EventHandler(this.StyleButton3_Click);
            // 
            // NiceClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(899, 491);
            this.Controls.Add(this.StyleButton3);
            this.Controls.Add(this.StyleButton2);
            this.Controls.Add(this.StyleButton1);
            this.Controls.Add(this.OrangeButton);
            this.Controls.Add(this.PurpleButton);
            this.Controls.Add(this.YellowButton);
            this.Controls.Add(this.BlueButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.ClockLabel);
            this.Name = "NiceClock";
            this.Text = "Nice Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ClockLabel;
        private System.Windows.Forms.Timer ClockTimer;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button BlueButton;
        private System.Windows.Forms.Button YellowButton;
        private System.Windows.Forms.Button PurpleButton;
        private System.Windows.Forms.Button OrangeButton;
        private System.Windows.Forms.Button StyleButton1;
        private System.Windows.Forms.Button StyleButton2;
        private System.Windows.Forms.Button StyleButton3;
    }
}

