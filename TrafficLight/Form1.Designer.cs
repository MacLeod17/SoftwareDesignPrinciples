
namespace TrafficLight
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NextButton = new System.Windows.Forms.Button();
            this.RedButton = new System.Windows.Forms.Button();
            this.YellowButton = new System.Windows.Forms.Button();
            this.GreenButton = new System.Windows.Forms.Button();
            this.TrafficLight = new System.Windows.Forms.Panel();
            this.Green = new System.Windows.Forms.TextBox();
            this.Yellow = new System.Windows.Forms.TextBox();
            this.Red = new System.Windows.Forms.TextBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.TrafficLight.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(97, 83);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(61, 29);
            this.NextButton.TabIndex = 0;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // RedButton
            // 
            this.RedButton.Location = new System.Drawing.Point(202, 143);
            this.RedButton.Name = "RedButton";
            this.RedButton.Size = new System.Drawing.Size(94, 29);
            this.RedButton.TabIndex = 1;
            this.RedButton.Text = "Red";
            this.RedButton.UseVisualStyleBackColor = true;
            this.RedButton.Click += new System.EventHandler(this.RedButton_Click);
            // 
            // YellowButton
            // 
            this.YellowButton.Location = new System.Drawing.Point(202, 193);
            this.YellowButton.Name = "YellowButton";
            this.YellowButton.Size = new System.Drawing.Size(94, 29);
            this.YellowButton.TabIndex = 2;
            this.YellowButton.Text = "Yellow";
            this.YellowButton.UseVisualStyleBackColor = true;
            this.YellowButton.Click += new System.EventHandler(this.YellowButton_Click);
            // 
            // GreenButton
            // 
            this.GreenButton.Location = new System.Drawing.Point(202, 243);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Size = new System.Drawing.Size(94, 29);
            this.GreenButton.TabIndex = 3;
            this.GreenButton.Text = "Green";
            this.GreenButton.UseVisualStyleBackColor = true;
            this.GreenButton.Click += new System.EventHandler(this.GreenButton_Click);
            // 
            // TrafficLight
            // 
            this.TrafficLight.BackColor = System.Drawing.Color.Gold;
            this.TrafficLight.Controls.Add(this.Green);
            this.TrafficLight.Controls.Add(this.Yellow);
            this.TrafficLight.Controls.Add(this.Red);
            this.TrafficLight.Location = new System.Drawing.Point(97, 133);
            this.TrafficLight.Name = "TrafficLight";
            this.TrafficLight.Size = new System.Drawing.Size(61, 159);
            this.TrafficLight.TabIndex = 4;
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.Gray;
            this.Green.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Green.Location = new System.Drawing.Point(12, 110);
            this.Green.Margin = new System.Windows.Forms.Padding(10);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(39, 39);
            this.Green.TabIndex = 2;
            // 
            // Yellow
            // 
            this.Yellow.BackColor = System.Drawing.Color.Gray;
            this.Yellow.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Yellow.Location = new System.Drawing.Point(11, 60);
            this.Yellow.Margin = new System.Windows.Forms.Padding(10);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(39, 39);
            this.Yellow.TabIndex = 1;
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Gray;
            this.Red.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Red.Location = new System.Drawing.Point(10, 10);
            this.Red.Margin = new System.Windows.Forms.Padding(10);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(39, 39);
            this.Red.TabIndex = 0;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TrafficLight);
            this.Controls.Add(this.GreenButton);
            this.Controls.Add(this.YellowButton);
            this.Controls.Add(this.RedButton);
            this.Controls.Add(this.NextButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TrafficLight.ResumeLayout(false);
            this.TrafficLight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button RedButton;
        private System.Windows.Forms.Button YellowButton;
        private System.Windows.Forms.Button GreenButton;
        private System.Windows.Forms.Panel TrafficLight;
        private System.Windows.Forms.TextBox Red;
        private System.Windows.Forms.TextBox Green;
        private System.Windows.Forms.TextBox Yellow;
        private System.Windows.Forms.Timer Timer;
    }
}

