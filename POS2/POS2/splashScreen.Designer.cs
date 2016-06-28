namespace POS2
{
    partial class splashScreen
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
            this.loadingBar = new System.Windows.Forms.ProgressBar();
            this.loadingTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // loadingBar
            // 
            this.loadingBar.Location = new System.Drawing.Point(0, 317);
            this.loadingBar.MarqueeAnimationSpeed = 1;
            this.loadingBar.Name = "loadingBar";
            this.loadingBar.Size = new System.Drawing.Size(636, 19);
            this.loadingBar.TabIndex = 1;
            // 
            // loadingTimer
            // 
            this.loadingTimer.Enabled = true;
            this.loadingTimer.Interval = 9;
            this.loadingTimer.Tick += new System.EventHandler(this.loadingTimer_Tick_1);
            // 
            // splashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::POS2.Properties.Resources.Price_Chopper1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 336);
            this.Controls.Add(this.loadingBar);
            this.Name = "splashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Price Chopper POS";
            this.Load += new System.EventHandler(this.splashScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar loadingBar;
        private System.Windows.Forms.Timer loadingTimer;
    }
}