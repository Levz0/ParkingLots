
namespace ип.Reg_Vhod
{
    partial class Log_in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_in));
            this.login = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxpass = new System.Windows.Forms.TextBox();
            this.Btn_Enter = new System.Windows.Forms.Button();
            this.Pict_close_eye = new System.Windows.Forms.PictureBox();
            this.Pict_open_eye = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBoxlog = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pict_close_eye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pict_open_eye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.Font = new System.Drawing.Font("Rage Italic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(115, 161);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(78, 30);
            this.login.TabIndex = 10;
            this.login.Text = "Логин:";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.BackColor = System.Drawing.Color.Transparent;
            this.pass.Font = new System.Drawing.Font("Rage Italic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.White;
            this.pass.Location = new System.Drawing.Point(109, 216);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(93, 30);
            this.pass.TabIndex = 11;
            this.pass.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rage Italic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(241, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 44);
            this.label1.TabIndex = 12;
            this.label1.Text = "Авторизация";
            // 
            // textBoxpass
            // 
            this.textBoxpass.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxpass.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpass.ForeColor = System.Drawing.Color.White;
            this.textBoxpass.Location = new System.Drawing.Point(231, 213);
            this.textBoxpass.Name = "textBoxpass";
            this.textBoxpass.Size = new System.Drawing.Size(262, 39);
            this.textBoxpass.TabIndex = 2;
            // 
            // Btn_Enter
            // 
            this.Btn_Enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Enter.Font = new System.Drawing.Font("Rage Italic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Enter.Location = new System.Drawing.Point(231, 270);
            this.Btn_Enter.Name = "Btn_Enter";
            this.Btn_Enter.Size = new System.Drawing.Size(262, 51);
            this.Btn_Enter.TabIndex = 3;
            this.Btn_Enter.Text = "Войти";
            this.Btn_Enter.UseVisualStyleBackColor = false;
            this.Btn_Enter.Click += new System.EventHandler(this.Btn_Enter_Click);
            // 
            // Pict_close_eye
            // 
            this.Pict_close_eye.BackColor = System.Drawing.Color.Transparent;
            this.Pict_close_eye.Image = ((System.Drawing.Image)(resources.GetObject("Pict_close_eye.Image")));
            this.Pict_close_eye.InitialImage = ((System.Drawing.Image)(resources.GetObject("Pict_close_eye.InitialImage")));
            this.Pict_close_eye.Location = new System.Drawing.Point(503, 213);
            this.Pict_close_eye.Name = "Pict_close_eye";
            this.Pict_close_eye.Size = new System.Drawing.Size(35, 35);
            this.Pict_close_eye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pict_close_eye.TabIndex = 15;
            this.Pict_close_eye.TabStop = false;
            this.Pict_close_eye.Click += new System.EventHandler(this.Pict_close_eye_Click);
            // 
            // Pict_open_eye
            // 
            this.Pict_open_eye.BackColor = System.Drawing.Color.Transparent;
            this.Pict_open_eye.Image = ((System.Drawing.Image)(resources.GetObject("Pict_open_eye.Image")));
            this.Pict_open_eye.Location = new System.Drawing.Point(503, 213);
            this.Pict_open_eye.Name = "Pict_open_eye";
            this.Pict_open_eye.Size = new System.Drawing.Size(35, 35);
            this.Pict_open_eye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pict_open_eye.TabIndex = 16;
            this.Pict_open_eye.TabStop = false;
            this.Pict_open_eye.Click += new System.EventHandler(this.Pict_open_eye_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(243, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ещё нет аккаунта?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // textBoxlog
            // 
            this.textBoxlog.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxlog.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxlog.ForeColor = System.Drawing.Color.White;
            this.textBoxlog.Location = new System.Drawing.Point(231, 161);
            this.textBoxlog.Name = "textBoxlog";
            this.textBoxlog.Size = new System.Drawing.Size(262, 39);
            this.textBoxlog.TabIndex = 1;
            // 
            // Log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(684, 415);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pict_open_eye);
            this.Controls.Add(this.Pict_close_eye);
            this.Controls.Add(this.Btn_Enter);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxlog);
            this.Controls.Add(this.textBoxpass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Log_in";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Log_in_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pict_close_eye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pict_open_eye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxpass;
        private System.Windows.Forms.Button Btn_Enter;
        private System.Windows.Forms.PictureBox Pict_close_eye;
        private System.Windows.Forms.PictureBox Pict_open_eye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBoxlog;
    }
}