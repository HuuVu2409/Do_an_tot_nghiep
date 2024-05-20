namespace testapp
{
    partial class fWaitingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fWaitingScreen));
            panel_mainposter = new Panel();
            panel_extraposter = new Panel();
            button1 = new Button();
            button_prebanner = new Button();
            panel_Button = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button_scan = new Button();
            button_product = new Button();
            panel_extraposter.SuspendLayout();
            panel_Button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel_mainposter
            // 
            panel_mainposter.BorderStyle = BorderStyle.Fixed3D;
            panel_mainposter.Location = new Point(0, 0);
            panel_mainposter.Name = "panel_mainposter";
            panel_mainposter.Size = new Size(1920, 480);
            panel_mainposter.TabIndex = 0;
            // 
            // panel_extraposter
            // 
            panel_extraposter.BorderStyle = BorderStyle.FixedSingle;
            panel_extraposter.Controls.Add(button1);
            panel_extraposter.Controls.Add(button_prebanner);
            panel_extraposter.Location = new Point(40, 530);
            panel_extraposter.Name = "panel_extraposter";
            panel_extraposter.Size = new Size(1200, 500);
            panel_extraposter.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1119, 210);
            button1.Name = "button1";
            button1.Size = new Size(80, 80);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            // 
            // button_prebanner
            // 
            button_prebanner.BackColor = Color.Transparent;
            button_prebanner.FlatStyle = FlatStyle.Flat;
            button_prebanner.Image = (Image)resources.GetObject("button_prebanner.Image");
            button_prebanner.Location = new Point(0, 210);
            button_prebanner.Name = "button_prebanner";
            button_prebanner.Size = new Size(80, 80);
            button_prebanner.TabIndex = 0;
            button_prebanner.UseVisualStyleBackColor = false;
            // 
            // panel_Button
            // 
            panel_Button.Controls.Add(pictureBox2);
            panel_Button.Controls.Add(pictureBox1);
            panel_Button.Controls.Add(button_scan);
            panel_Button.Controls.Add(button_product);
            panel_Button.Location = new Point(1280, 530);
            panel_Button.Name = "panel_Button";
            panel_Button.Size = new Size(600, 500);
            panel_Button.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(84, 93);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 80);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += button_product_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.camera1;
            pictureBox1.Location = new Point(84, 332);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += button_scan_Click;
            // 
            // button_scan
            // 
            button_scan.Font = new Font("Segoe UI", 20F);
            button_scan.Location = new Point(47, 277);
            button_scan.Name = "button_scan";
            button_scan.Size = new Size(519, 186);
            button_scan.TabIndex = 1;
            button_scan.Text = "Scan";
            button_scan.UseVisualStyleBackColor = true;
            button_scan.Click += button_scan_Click;
            // 
            // button_product
            // 
            button_product.Font = new Font("Segoe UI", 20F);
            button_product.Location = new Point(47, 34);
            button_product.Name = "button_product";
            button_product.Size = new Size(519, 186);
            button_product.TabIndex = 0;
            button_product.Text = "Sản phẩm khác";
            button_product.UseVisualStyleBackColor = true;
            button_product.Click += button_product_Click;
            // 
            // fWaitingScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(panel_Button);
            Controls.Add(panel_extraposter);
            Controls.Add(panel_mainposter);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fWaitingScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Màn hình chờ";
            WindowState = FormWindowState.Maximized;
            panel_extraposter.ResumeLayout(false);
            panel_Button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_mainposter;
        private Panel panel_extraposter;
        private Panel panel_Button;
        private Button button_prebanner;
        private Button button1;
        private Button button_scan;
        private Button button_product;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
