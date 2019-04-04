namespace GUI_Csharp
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.IntroTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Login = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.UserNameText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.SuspendLayout();
            // 
            // IntroTransition
            // 
            this.IntroTransition.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.IntroTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0.5F;
            animation1.RotateLimit = 0.2F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.IntroTransition.DefaultAnimation = animation1;
            // 
            // Login
            // 
            this.IntroTransition.SetDecoration(this.Login, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.Login, BunifuAnimatorNS.DecorationType.None);
            this.Login.Location = new System.Drawing.Point(306, 215);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(109, 36);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Exit
            // 
            this.IntroTransition.SetDecoration(this.Exit, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.Exit, BunifuAnimatorNS.DecorationType.None);
            this.Exit.Location = new System.Drawing.Point(444, 215);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(110, 36);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserNameText
            // 
            this.IntroTransition.SetDecoration(this.UserNameText, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.UserNameText, BunifuAnimatorNS.DecorationType.None);
            this.UserNameText.Location = new System.Drawing.Point(200, 126);
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.Size = new System.Drawing.Size(100, 20);
            this.UserNameText.TabIndex = 4;
            this.UserNameText.Text = "User Name:";
            this.UserNameText.TextChanged += new System.EventHandler(this.UserNameText_TextChanged);
            // 
            // PasswordText
            // 
            this.IntroTransition.SetDecoration(this.PasswordText, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.PasswordText, BunifuAnimatorNS.DecorationType.None);
            this.PasswordText.Location = new System.Drawing.Point(200, 175);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(100, 20);
            this.PasswordText.TabIndex = 5;
            this.PasswordText.Text = "Password: ";
            // 
            // textBox1
            // 
            this.IntroTransition.SetDecoration(this.textBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.textBox1, BunifuAnimatorNS.DecorationType.None);
            this.textBox1.Location = new System.Drawing.Point(307, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox2
            // 
            this.IntroTransition.SetDecoration(this.textBox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.textBox2, BunifuAnimatorNS.DecorationType.None);
            this.textBox2.Location = new System.Drawing.Point(306, 175);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(253, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.IntroTransition.SetDecoration(this.checkBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.checkBox1, BunifuAnimatorNS.DecorationType.None);
            this.checkBox1.Location = new System.Drawing.Point(590, 177);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.bunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0.5F;
            animation2.RotateLimit = 0.2F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 471);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.UserNameText);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Login);
            this.IntroTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "School DataBase";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BunifuAnimatorNS.BunifuTransition IntroTransition;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox UserNameText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
    }
}

