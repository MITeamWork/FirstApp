namespace FirstApp
{
    partial class frmMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.pbSignIn = new System.Windows.Forms.PictureBox();
            this.pbLogin = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSignIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(241, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME TO ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Stencil", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(241, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(461, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "StudentHub";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(164, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(651, 140);
            this.label3.TabIndex = 1;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // lblLogin
            // 
            this.lblLogin.BackColor = System.Drawing.Color.Black;
            this.lblLogin.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Red;
            this.lblLogin.Location = new System.Drawing.Point(311, 611);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(116, 50);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogin.Click += new System.EventHandler(this.login_click);
            this.lblLogin.MouseHover += new System.EventHandler(this.login_hover);
            // 
            // lblSignIn
            // 
            this.lblSignIn.BackColor = System.Drawing.Color.Black;
            this.lblSignIn.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIn.ForeColor = System.Drawing.Color.Red;
            this.lblSignIn.Location = new System.Drawing.Point(572, 611);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(116, 50);
            this.lblSignIn.TabIndex = 1;
            this.lblSignIn.Text = "Sign in";
            this.lblSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSignIn.Click += new System.EventHandler(this.SignIn_click);
            this.lblSignIn.MouseHover += new System.EventHandler(this.login_hover);
            // 
            // pbSignIn
            // 
            this.pbSignIn.Image = global::FirstApp.Properties.Resources.edit_12_48;
            this.pbSignIn.Location = new System.Drawing.Point(509, 611);
            this.pbSignIn.Name = "pbSignIn";
            this.pbSignIn.Size = new System.Drawing.Size(57, 50);
            this.pbSignIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSignIn.TabIndex = 2;
            this.pbSignIn.TabStop = false;
            this.pbSignIn.Click += new System.EventHandler(this.SignIn_click);
            this.pbSignIn.MouseHover += new System.EventHandler(this.login_hover);
            // 
            // pbLogin
            // 
            this.pbLogin.Image = global::FirstApp.Properties.Resources.login_48;
            this.pbLogin.Location = new System.Drawing.Point(248, 611);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(57, 50);
            this.pbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogin.TabIndex = 2;
            this.pbLogin.TabStop = false;
            this.pbLogin.Click += new System.EventHandler(this.login_click);
            this.pbLogin.MouseHover += new System.EventHandler(this.login_hover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FirstApp.Properties.Resources.book_16_256;
            this.pictureBox1.Location = new System.Drawing.Point(342, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(944, 771);
            this.Controls.Add(this.pbSignIn);
            this.Controls.Add(this.pbLogin);
            this.Controls.Add(this.lblSignIn);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentHub";
            ((System.ComponentModel.ISupportInitialize)(this.pbSignIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.PictureBox pbSignIn;
    }
}

