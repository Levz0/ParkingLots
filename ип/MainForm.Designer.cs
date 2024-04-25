namespace ип
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Parking_Lot = new System.Windows.Forms.Label();
            this.lbl_parking = new System.Windows.Forms.Label();
            this.lbl_exit = new System.Windows.Forms.Label();
            this.Lb_report = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Parking_Lot
            // 
            this.Parking_Lot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Parking_Lot.AutoSize = true;
            this.Parking_Lot.BackColor = System.Drawing.Color.Transparent;
            this.Parking_Lot.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Parking_Lot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Parking_Lot.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parking_Lot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Parking_Lot.Location = new System.Drawing.Point(309, 75);
            this.Parking_Lot.Name = "Parking_Lot";
            this.Parking_Lot.Size = new System.Drawing.Size(371, 85);
            this.Parking_Lot.TabIndex = 0;
            this.Parking_Lot.Text = "Parking lot";
            this.Parking_Lot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_parking
            // 
            this.lbl_parking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_parking.AutoSize = true;
            this.lbl_parking.BackColor = System.Drawing.Color.Transparent;
            this.lbl_parking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_parking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_parking.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parking.ForeColor = System.Drawing.Color.Blue;
            this.lbl_parking.Location = new System.Drawing.Point(54, 426);
            this.lbl_parking.Name = "lbl_parking";
            this.lbl_parking.Size = new System.Drawing.Size(194, 63);
            this.lbl_parking.TabIndex = 0;
            this.lbl_parking.Text = "Parking";
            this.lbl_parking.Click += new System.EventHandler(this.lbl_parking_Click);
            // 
            // lbl_exit
            // 
            this.lbl_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_exit.AutoSize = true;
            this.lbl_exit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_exit.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exit.ForeColor = System.Drawing.Color.Blue;
            this.lbl_exit.Location = new System.Drawing.Point(774, 426);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(120, 63);
            this.lbl_exit.TabIndex = 0;
            this.lbl_exit.Text = "Exit";
            this.lbl_exit.Click += new System.EventHandler(this.lbl_exit_Click);
            // 
            // Lb_report
            // 
            this.Lb_report.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_report.AutoSize = true;
            this.Lb_report.BackColor = System.Drawing.Color.Transparent;
            this.Lb_report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lb_report.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Lb_report.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_report.ForeColor = System.Drawing.Color.Blue;
            this.Lb_report.Location = new System.Drawing.Point(409, 426);
            this.Lb_report.Name = "Lb_report";
            this.Lb_report.Size = new System.Drawing.Size(187, 63);
            this.Lb_report.TabIndex = 0;
            this.Lb_report.Text = "Report";
            this.Lb_report.Click += new System.EventHandler(this.Lb_report_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(791, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "About programm";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(870, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Reference";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(874, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Intruders";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(996, 594);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_exit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lb_report);
            this.Controls.Add(this.lbl_parking);
            this.Controls.Add(this.Parking_Lot);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parking lot menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Parking_Lot;
        private System.Windows.Forms.Label lbl_parking;
        private System.Windows.Forms.Label lbl_exit;
        private System.Windows.Forms.Label Lb_report;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}

