namespace ип
{
    partial class DataChangeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataChangeForm));
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Cmb_changing_color = new System.Windows.Forms.ComboBox();
            this.Lb_color = new System.Windows.Forms.Label();
            this.Lb_fio = new System.Windows.Forms.Label();
            this.Lb_number = new System.Windows.Forms.Label();
            this.Btn_MakeFree = new System.Windows.Forms.Button();
            this.Lb_cars_type = new System.Windows.Forms.Label();
            this.Txt_fio = new System.Windows.Forms.TextBox();
            this.Txt_number = new System.Windows.Forms.TextBox();
            this.Txt_cars_type = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_typeofts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Dtp_picker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Dtp_picker_end = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Btn_Add
            // 
            this.Btn_Add.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_Add.Enabled = false;
            this.Btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Add.Location = new System.Drawing.Point(12, 537);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(214, 83);
            this.Btn_Add.TabIndex = 8;
            this.Btn_Add.UseVisualStyleBackColor = true;
            // 
            // Cmb_changing_color
            // 
            this.Cmb_changing_color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_changing_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cmb_changing_color.FormattingEnabled = true;
            this.Cmb_changing_color.Location = new System.Drawing.Point(363, 152);
            this.Cmb_changing_color.Name = "Cmb_changing_color";
            this.Cmb_changing_color.Size = new System.Drawing.Size(245, 41);
            this.Cmb_changing_color.TabIndex = 3;
            // 
            // carsColorBindingSource
            // 
            // 
            // Lb_color
            // 
            this.Lb_color.AutoSize = true;
            this.Lb_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lb_color.Location = new System.Drawing.Point(12, 150);
            this.Lb_color.Name = "Lb_color";
            this.Lb_color.Size = new System.Drawing.Size(112, 39);
            this.Lb_color.TabIndex = 13;
            this.Lb_color.Text = "Цвет:";
            // 
            // Lb_fio
            // 
            this.Lb_fio.AutoSize = true;
            this.Lb_fio.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lb_fio.Location = new System.Drawing.Point(12, 21);
            this.Lb_fio.Name = "Lb_fio";
            this.Lb_fio.Size = new System.Drawing.Size(113, 39);
            this.Lb_fio.TabIndex = 11;
            this.Lb_fio.Text = "ФИО:";
            // 
            // Lb_number
            // 
            this.Lb_number.AutoSize = true;
            this.Lb_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lb_number.Location = new System.Drawing.Point(12, 228);
            this.Lb_number.Name = "Lb_number";
            this.Lb_number.Size = new System.Drawing.Size(198, 39);
            this.Lb_number.TabIndex = 14;
            this.Lb_number.Text = "Номер ТС:";
            // 
            // Btn_MakeFree
            // 
            this.Btn_MakeFree.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Btn_MakeFree.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_MakeFree.Location = new System.Drawing.Point(382, 537);
            this.Btn_MakeFree.Name = "Btn_MakeFree";
            this.Btn_MakeFree.Size = new System.Drawing.Size(214, 83);
            this.Btn_MakeFree.TabIndex = 9;
            this.Btn_MakeFree.Text = "Освободить место";
            this.Btn_MakeFree.UseVisualStyleBackColor = true;
            // 
            // Lb_cars_type
            // 
            this.Lb_cars_type.AutoSize = true;
            this.Lb_cars_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lb_cars_type.Location = new System.Drawing.Point(12, 84);
            this.Lb_cars_type.Name = "Lb_cars_type";
            this.Lb_cars_type.Size = new System.Drawing.Size(195, 39);
            this.Lb_cars_type.TabIndex = 12;
            this.Lb_cars_type.Text = "Марка ТС:";
            // 
            // Txt_fio
            // 
            this.Txt_fio.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Txt_fio.Location = new System.Drawing.Point(363, 16);
            this.Txt_fio.MaxLength = 35;
            this.Txt_fio.Name = "Txt_fio";
            this.Txt_fio.Size = new System.Drawing.Size(245, 44);
            this.Txt_fio.TabIndex = 1;
            this.Txt_fio.TextChanged += new System.EventHandler(this.Txt_fio_TextChanged);
            this.Txt_fio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_fio_KeyPress);
            // 
            // Txt_number
            // 
            this.Txt_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Txt_number.Location = new System.Drawing.Point(363, 228);
            this.Txt_number.MaxLength = 15;
            this.Txt_number.Name = "Txt_number";
            this.Txt_number.Size = new System.Drawing.Size(245, 44);
            this.Txt_number.TabIndex = 4;
            this.Txt_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_number_KeyPress);
            // 
            // Txt_cars_type
            // 
            this.Txt_cars_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Txt_cars_type.Location = new System.Drawing.Point(363, 79);
            this.Txt_cars_type.MaxLength = 20;
            this.Txt_cars_type.Name = "Txt_cars_type";
            this.Txt_cars_type.Size = new System.Drawing.Size(245, 44);
            this.Txt_cars_type.TabIndex = 2;
            this.Txt_cars_type.TextChanged += new System.EventHandler(this.Txt_cars_type_TextChanged);
            this.Txt_cars_type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_cars_type_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 39);
            this.label1.TabIndex = 15;
            this.label1.Text = "Тип ТС:";
            // 
            // Cmb_typeofts
            // 
            this.Cmb_typeofts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_typeofts.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Cmb_typeofts.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cmb_typeofts.FormattingEnabled = true;
            this.Cmb_typeofts.Location = new System.Drawing.Point(362, 300);
            this.Cmb_typeofts.Name = "Cmb_typeofts";
            this.Cmb_typeofts.Size = new System.Drawing.Size(245, 41);
            this.Cmb_typeofts.TabIndex = 5;
            // 
            // typeTsBindingSource
            // 
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 39);
            this.label2.TabIndex = 16;
            this.label2.Text = "Дата начала брони:";
            // 
            // Dtp_picker
            // 
            this.Dtp_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dtp_picker.Location = new System.Drawing.Point(363, 368);
            this.Dtp_picker.MaxDate = new System.DateTime(2400, 12, 31, 0, 0, 0, 0);
            this.Dtp_picker.MinDate = new System.DateTime(2017, 1, 3, 0, 0, 0, 0);
            this.Dtp_picker.Name = "Dtp_picker";
            this.Dtp_picker.Size = new System.Drawing.Size(244, 35);
            this.Dtp_picker.TabIndex = 6;
            this.Dtp_picker.Value = new System.DateTime(2023, 5, 6, 17, 47, 40, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 39);
            this.label3.TabIndex = 17;
            this.label3.Text = "Дата конца брони:";
            // 
            // Dtp_picker_end
            // 
            this.Dtp_picker_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dtp_picker_end.Location = new System.Drawing.Point(364, 426);
            this.Dtp_picker_end.MaxDate = new System.DateTime(2400, 12, 31, 0, 0, 0, 0);
            this.Dtp_picker_end.MinDate = new System.DateTime(2023, 5, 6, 0, 0, 0, 0);
            this.Dtp_picker_end.Name = "Dtp_picker_end";
            this.Dtp_picker_end.Size = new System.Drawing.Size(244, 35);
            this.Dtp_picker_end.TabIndex = 7;
            // 
            // typeTsBindingSource1
            // 
            // 
            // DataChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 640);
            this.Controls.Add(this.Dtp_picker_end);
            this.Controls.Add(this.Dtp_picker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cmb_typeofts);
            this.Controls.Add(this.Txt_cars_type);
            this.Controls.Add(this.Txt_number);
            this.Controls.Add(this.Txt_fio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lb_cars_type);
            this.Controls.Add(this.Lb_number);
            this.Controls.Add(this.Lb_fio);
            this.Controls.Add(this.Lb_color);
            this.Controls.Add(this.Cmb_changing_color);
            this.Controls.Add(this.Btn_MakeFree);
            this.Controls.Add(this.Btn_Add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataChangeForm";
            this.Text = "Изменить парковочное место";
            this.Load += new System.EventHandler(this.DataChangeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button Btn_Add;
        public System.Windows.Forms.ComboBox Cmb_changing_color;
        public System.Windows.Forms.Label Lb_color;
        public System.Windows.Forms.Label Lb_fio;
        public System.Windows.Forms.Label Lb_number;
        public System.Windows.Forms.Button Btn_MakeFree;
        public System.Windows.Forms.Label Lb_cars_type;
        public System.Windows.Forms.TextBox Txt_fio;
        public System.Windows.Forms.TextBox Txt_number;
        public System.Windows.Forms.TextBox Txt_cars_type;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox Cmb_typeofts;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker Dtp_picker;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker Dtp_picker_end;
  
    }
}