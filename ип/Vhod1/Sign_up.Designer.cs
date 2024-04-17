
namespace ип.Vhod
{
    partial class Sign_up
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_up));
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.avtoriz = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.Btn_Create = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pict_open_eye = new System.Windows.Forms.PictureBox();
            this.Pict_close_eye = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pict_open_eye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pict_close_eye)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_login
            // 
            this.textBox_login.Font = new System.Drawing.Font("Rage Italic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_login.Location = new System.Drawing.Point(231, 161);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(262, 38);
            this.textBox_login.TabIndex = 0;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Rage Italic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(231, 213);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(262, 38);
            this.textBox_password.TabIndex = 1;
            // 
            // avtoriz
            // 
            this.avtoriz.AutoSize = true;
            this.avtoriz.Font = new System.Drawing.Font("Rage Italic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avtoriz.Location = new System.Drawing.Point(261, 12);
            this.avtoriz.Name = "avtoriz";
            this.avtoriz.Size = new System.Drawing.Size(214, 44);
            this.avtoriz.TabIndex = 2;
            this.avtoriz.Text = "Регистрация";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Rage Italic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(109, 216);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(93, 30);
            this.pass.TabIndex = 2;
            this.pass.Text = "Пароль:";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Rage Italic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(115, 161);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(78, 30);
            this.login.TabIndex = 2;
            this.login.Text = "Логин:";
            // 
            // Btn_Create
            // 
            this.Btn_Create.Font = new System.Drawing.Font("Rage Italic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Create.Location = new System.Drawing.Point(231, 270);
            this.Btn_Create.Name = "Btn_Create";
            this.Btn_Create.Size = new System.Drawing.Size(262, 51);
            this.Btn_Create.TabIndex = 3;
            this.Btn_Create.Text = "Зарегистрироваться";
            this.Btn_Create.UseVisualStyleBackColor = true;
            this.Btn_Create.Click += new System.EventHandler(this.Btn_Create_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rage Italic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 30);
            this.label2.TabIndex = 20;
            this.label2.Text = "Уже есть аккаунт?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Pict_open_eye
            // 
            this.Pict_open_eye.Image = ((System.Drawing.Image)(resources.GetObject("Pict_open_eye.Image")));
            this.Pict_open_eye.Location = new System.Drawing.Point(503, 213);
            this.Pict_open_eye.Name = "Pict_open_eye";
            this.Pict_open_eye.Size = new System.Drawing.Size(35, 35);
            this.Pict_open_eye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pict_open_eye.TabIndex = 19;
            this.Pict_open_eye.TabStop = false;
            this.Pict_open_eye.Click += new System.EventHandler(this.Pict_open_eye_Click);
            // 
            // Pict_close_eye
            // 
            this.Pict_close_eye.Image = ((System.Drawing.Image)(resources.GetObject("Pict_close_eye.Image")));
            this.Pict_close_eye.InitialImage = ((System.Drawing.Image)(resources.GetObject("Pict_close_eye.InitialImage")));
            this.Pict_close_eye.Location = new System.Drawing.Point(503, 213);
            this.Pict_close_eye.Name = "Pict_close_eye";
            this.Pict_close_eye.Size = new System.Drawing.Size(35, 35);
            this.Pict_close_eye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pict_close_eye.TabIndex = 18;
            this.Pict_close_eye.TabStop = false;
            this.Pict_close_eye.Click += new System.EventHandler(this.Pict_close_eye_Click);
            // 
            // Sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(684, 415);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pict_open_eye);
            this.Controls.Add(this.Pict_close_eye);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Create);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.avtoriz);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sign_up";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Sign_up_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pict_open_eye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pict_close_eye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label avtoriz;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Button Btn_Create;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Pict_open_eye;
        private System.Windows.Forms.PictureBox Pict_close_eye;
    }
}