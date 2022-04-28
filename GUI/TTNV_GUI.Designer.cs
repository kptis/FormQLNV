
namespace WinFormsApp1
{
     partial class Form_QLNV
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
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
               this.danhsachNhanVien = new System.Windows.Forms.DataGridView();
               this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.NS = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.GT = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.DC = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Ma_NGS = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.MaPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.panel1 = new System.Windows.Forms.Panel();
               this.txtMaNV = new System.Windows.Forms.TextBox();
               this.lb_tongNV = new System.Windows.Forms.Label();
               this.tongNV = new System.Windows.Forms.TextBox();
               this.txtdiachi = new System.Windows.Forms.RichTextBox();
               this.radioButton3_chuaro = new System.Windows.Forms.RadioButton();
               this.radioButton2_nu = new System.Windows.Forms.RadioButton();
               this.radioButton1_nam = new System.Windows.Forms.RadioButton();
               this.dateTimePicker1_NS = new System.Windows.Forms.DateTimePicker();
               this.lb_name = new System.Windows.Forms.Label();
               this.lb_MaPB = new System.Windows.Forms.Label();
               this.lb_MaNGS = new System.Windows.Forms.Label();
               this.lb_luong = new System.Windows.Forms.Label();
               this.lb_diachi = new System.Windows.Forms.Label();
               this.lb_GT = new System.Windows.Forms.Label();
               this.lb_NS = new System.Windows.Forms.Label();
               this.lb_maNV = new System.Windows.Forms.Label();
               this.btnDelete = new System.Windows.Forms.Button();
               this.label1 = new System.Windows.Forms.Label();
               this.btnUpdate = new System.Windows.Forms.Button();
               this.btnReset = new System.Windows.Forms.Button();
               this.btnAdd = new System.Windows.Forms.Button();
               this.txtLuong = new System.Windows.Forms.TextBox();
               this.txtMaNGS = new System.Windows.Forms.TextBox();
               this.txtMaPB = new System.Windows.Forms.TextBox();
               this.txtHoten = new System.Windows.Forms.TextBox();
               this.imageList1 = new System.Windows.Forms.ImageList(this.components);
               this.txtFindSV = new System.Windows.Forms.TextBox();
               this.lbFindSV = new System.Windows.Forms.Label();
               ((System.ComponentModel.ISupportInitialize)(this.danhsachNhanVien)).BeginInit();
               this.panel1.SuspendLayout();
               this.SuspendLayout();
               // 
               // danhsachNhanVien
               // 
               this.danhsachNhanVien.AllowDrop = true;
               this.danhsachNhanVien.AllowUserToAddRows = false;
               this.danhsachNhanVien.AllowUserToDeleteRows = false;
               dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumTurquoise;
               this.danhsachNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
               this.danhsachNhanVien.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
               this.danhsachNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
               this.danhsachNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.danhsachNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.HoTen,
            this.NS,
            this.Luong,
            this.GT,
            this.DC,
            this.Ma_NGS,
            this.MaPB});
               this.danhsachNhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
               this.danhsachNhanVien.GridColor = System.Drawing.SystemColors.ActiveCaption;
               this.danhsachNhanVien.Location = new System.Drawing.Point(0, 283);
               this.danhsachNhanVien.Name = "danhsachNhanVien";
               dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
               dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
               dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Green;
               dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.danhsachNhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
               this.danhsachNhanVien.RowHeadersWidth = 51;
               dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
               this.danhsachNhanVien.RowsDefaultCellStyle = dataGridViewCellStyle3;
               this.danhsachNhanVien.RowTemplate.Height = 29;
               this.danhsachNhanVien.ShowEditingIcon = false;
               this.danhsachNhanVien.Size = new System.Drawing.Size(1046, 228);
               this.danhsachNhanVien.StandardTab = true;
               this.danhsachNhanVien.TabIndex = 0;
               this.danhsachNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.danhsachNhanVien_CellClick);
               // 
               // MaNV
               // 
               this.MaNV.DataPropertyName = "MaNV";
               this.MaNV.HeaderText = "Mã NV";
               this.MaNV.MinimumWidth = 6;
               this.MaNV.Name = "MaNV";
               this.MaNV.Width = 125;
               // 
               // HoTen
               // 
               this.HoTen.DataPropertyName = "HoTen";
               this.HoTen.HeaderText = "Họ tên";
               this.HoTen.MinimumWidth = 6;
               this.HoTen.Name = "HoTen";
               this.HoTen.Width = 125;
               // 
               // NS
               // 
               this.NS.DataPropertyName = "NS";
               this.NS.HeaderText = "Ngày sinh";
               this.NS.MinimumWidth = 6;
               this.NS.Name = "NS";
               this.NS.Width = 125;
               // 
               // Luong
               // 
               this.Luong.DataPropertyName = "Luong";
               this.Luong.HeaderText = "Lương";
               this.Luong.MinimumWidth = 6;
               this.Luong.Name = "Luong";
               this.Luong.Width = 125;
               // 
               // GT
               // 
               this.GT.DataPropertyName = "GT";
               this.GT.HeaderText = "Giới tính";
               this.GT.MinimumWidth = 6;
               this.GT.Name = "GT";
               this.GT.Width = 125;
               // 
               // DC
               // 
               this.DC.DataPropertyName = "DC";
               this.DC.HeaderText = "Địa chỉ";
               this.DC.MinimumWidth = 6;
               this.DC.Name = "DC";
               this.DC.Width = 125;
               // 
               // Ma_NGS
               // 
               this.Ma_NGS.DataPropertyName = "Ma_NGS";
               this.Ma_NGS.HeaderText = "Mã NGS";
               this.Ma_NGS.MinimumWidth = 6;
               this.Ma_NGS.Name = "Ma_NGS";
               this.Ma_NGS.Width = 125;
               // 
               // MaPB
               // 
               this.MaPB.DataPropertyName = "MaPB";
               this.MaPB.HeaderText = "Mã PB";
               this.MaPB.MinimumWidth = 6;
               this.MaPB.Name = "MaPB";
               this.MaPB.Width = 125;
               // 
               // panel1
               // 
               this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
               this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.panel1.Controls.Add(this.lbFindSV);
               this.panel1.Controls.Add(this.txtFindSV);
               this.panel1.Controls.Add(this.txtMaNV);
               this.panel1.Controls.Add(this.lb_tongNV);
               this.panel1.Controls.Add(this.tongNV);
               this.panel1.Controls.Add(this.txtdiachi);
               this.panel1.Controls.Add(this.radioButton3_chuaro);
               this.panel1.Controls.Add(this.radioButton2_nu);
               this.panel1.Controls.Add(this.radioButton1_nam);
               this.panel1.Controls.Add(this.dateTimePicker1_NS);
               this.panel1.Controls.Add(this.lb_name);
               this.panel1.Controls.Add(this.lb_MaPB);
               this.panel1.Controls.Add(this.lb_MaNGS);
               this.panel1.Controls.Add(this.lb_luong);
               this.panel1.Controls.Add(this.lb_diachi);
               this.panel1.Controls.Add(this.lb_GT);
               this.panel1.Controls.Add(this.lb_NS);
               this.panel1.Controls.Add(this.lb_maNV);
               this.panel1.Controls.Add(this.btnDelete);
               this.panel1.Controls.Add(this.label1);
               this.panel1.Controls.Add(this.btnUpdate);
               this.panel1.Controls.Add(this.btnReset);
               this.panel1.Controls.Add(this.btnAdd);
               this.panel1.Controls.Add(this.txtLuong);
               this.panel1.Controls.Add(this.txtMaNGS);
               this.panel1.Controls.Add(this.txtMaPB);
               this.panel1.Controls.Add(this.txtHoten);
               this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
               this.panel1.Location = new System.Drawing.Point(0, 0);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(1046, 283);
               this.panel1.TabIndex = 1;
               this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
               // 
               // txtMaNV
               // 
               this.txtMaNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.txtMaNV.Location = new System.Drawing.Point(129, 6);
               this.txtMaNV.Name = "txtMaNV";
               this.txtMaNV.Size = new System.Drawing.Size(98, 27);
               this.txtMaNV.TabIndex = 58;
               this.txtMaNV.TextChanged += new System.EventHandler(this.txtMaNV_TextChanged);
               // 
               // lb_tongNV
               // 
               this.lb_tongNV.AutoSize = true;
               this.lb_tongNV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
               this.lb_tongNV.ForeColor = System.Drawing.Color.Navy;
               this.lb_tongNV.Location = new System.Drawing.Point(31, 252);
               this.lb_tongNV.Name = "lb_tongNV";
               this.lb_tongNV.Size = new System.Drawing.Size(65, 20);
               this.lb_tongNV.TabIndex = 57;
               this.lb_tongNV.Text = "Tổng số";
               // 
               // tongNV
               // 
               this.tongNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.tongNV.Location = new System.Drawing.Point(127, 249);
               this.tongNV.Name = "tongNV";
               this.tongNV.Size = new System.Drawing.Size(125, 27);
               this.tongNV.TabIndex = 56;
               // 
               // txtdiachi
               // 
               this.txtdiachi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.txtdiachi.Location = new System.Drawing.Point(691, 13);
               this.txtdiachi.Name = "txtdiachi";
               this.txtdiachi.Size = new System.Drawing.Size(315, 85);
               this.txtdiachi.TabIndex = 55;
               this.txtdiachi.Text = "";
               this.txtdiachi.TextChanged += new System.EventHandler(this.txtdiachi_TextChanged);
               // 
               // radioButton3_chuaro
               // 
               this.radioButton3_chuaro.AutoSize = true;
               this.radioButton3_chuaro.Location = new System.Drawing.Point(281, 108);
               this.radioButton3_chuaro.Name = "radioButton3_chuaro";
               this.radioButton3_chuaro.Size = new System.Drawing.Size(82, 24);
               this.radioButton3_chuaro.TabIndex = 54;
               this.radioButton3_chuaro.TabStop = true;
               this.radioButton3_chuaro.Text = "Chưa rõ";
               this.radioButton3_chuaro.UseVisualStyleBackColor = false;
               // 
               // radioButton2_nu
               // 
               this.radioButton2_nu.AutoSize = true;
               this.radioButton2_nu.Location = new System.Drawing.Point(204, 107);
               this.radioButton2_nu.Name = "radioButton2_nu";
               this.radioButton2_nu.Size = new System.Drawing.Size(50, 24);
               this.radioButton2_nu.TabIndex = 53;
               this.radioButton2_nu.TabStop = true;
               this.radioButton2_nu.Text = "Nữ";
               this.radioButton2_nu.UseVisualStyleBackColor = true;
               // 
               // radioButton1_nam
               // 
               this.radioButton1_nam.AutoSize = true;
               this.radioButton1_nam.Location = new System.Drawing.Point(127, 108);
               this.radioButton1_nam.Name = "radioButton1_nam";
               this.radioButton1_nam.Size = new System.Drawing.Size(62, 24);
               this.radioButton1_nam.TabIndex = 52;
               this.radioButton1_nam.TabStop = true;
               this.radioButton1_nam.Text = "Nam";
               this.radioButton1_nam.UseVisualStyleBackColor = true;
               // 
               // dateTimePicker1_NS
               // 
               this.dateTimePicker1_NS.CalendarForeColor = System.Drawing.SystemColors.Highlight;
               this.dateTimePicker1_NS.CustomFormat = "dd/MM/yyyy";
               this.dateTimePicker1_NS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
               this.dateTimePicker1_NS.Location = new System.Drawing.Point(127, 74);
               this.dateTimePicker1_NS.Name = "dateTimePicker1_NS";
               this.dateTimePicker1_NS.Size = new System.Drawing.Size(250, 27);
               this.dateTimePicker1_NS.TabIndex = 51;
               this.dateTimePicker1_NS.Value = new System.DateTime(2022, 4, 27, 0, 0, 0, 0);
               this.dateTimePicker1_NS.ValueChanged += new System.EventHandler(this.dateTimePicker1_NS_ValueChanged);
               // 
               // lb_name
               // 
               this.lb_name.AutoSize = true;
               this.lb_name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
               this.lb_name.ForeColor = System.Drawing.Color.Navy;
               this.lb_name.Location = new System.Drawing.Point(31, 45);
               this.lb_name.Name = "lb_name";
               this.lb_name.Size = new System.Drawing.Size(56, 20);
               this.lb_name.TabIndex = 50;
               this.lb_name.Text = "Họ tên";
               // 
               // lb_MaPB
               // 
               this.lb_MaPB.AutoSize = true;
               this.lb_MaPB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
               this.lb_MaPB.ForeColor = System.Drawing.Color.Navy;
               this.lb_MaPB.Location = new System.Drawing.Point(34, 143);
               this.lb_MaPB.Name = "lb_MaPB";
               this.lb_MaPB.Size = new System.Drawing.Size(54, 20);
               this.lb_MaPB.TabIndex = 49;
               this.lb_MaPB.Text = "Mã PB";
               // 
               // lb_MaNGS
               // 
               this.lb_MaNGS.AutoSize = true;
               this.lb_MaNGS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
               this.lb_MaNGS.ForeColor = System.Drawing.Color.Navy;
               this.lb_MaNGS.Location = new System.Drawing.Point(595, 150);
               this.lb_MaNGS.Name = "lb_MaNGS";
               this.lb_MaNGS.Size = new System.Drawing.Size(66, 20);
               this.lb_MaNGS.TabIndex = 48;
               this.lb_MaNGS.Text = "Mã NGS";
               // 
               // lb_luong
               // 
               this.lb_luong.AutoSize = true;
               this.lb_luong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
               this.lb_luong.ForeColor = System.Drawing.Color.Navy;
               this.lb_luong.Location = new System.Drawing.Point(595, 111);
               this.lb_luong.Name = "lb_luong";
               this.lb_luong.Size = new System.Drawing.Size(54, 20);
               this.lb_luong.TabIndex = 47;
               this.lb_luong.Text = "Lương";
               // 
               // lb_diachi
               // 
               this.lb_diachi.AutoSize = true;
               this.lb_diachi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
               this.lb_diachi.ForeColor = System.Drawing.Color.Navy;
               this.lb_diachi.Location = new System.Drawing.Point(595, 13);
               this.lb_diachi.Name = "lb_diachi";
               this.lb_diachi.Size = new System.Drawing.Size(56, 20);
               this.lb_diachi.TabIndex = 46;
               this.lb_diachi.Text = "Địa chỉ";
               // 
               // lb_GT
               // 
               this.lb_GT.AutoSize = true;
               this.lb_GT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
               this.lb_GT.ForeColor = System.Drawing.Color.Navy;
               this.lb_GT.Location = new System.Drawing.Point(31, 112);
               this.lb_GT.Name = "lb_GT";
               this.lb_GT.Size = new System.Drawing.Size(69, 20);
               this.lb_GT.TabIndex = 45;
               this.lb_GT.Text = "Giới tính";
               // 
               // lb_NS
               // 
               this.lb_NS.AutoSize = true;
               this.lb_NS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
               this.lb_NS.ForeColor = System.Drawing.Color.Navy;
               this.lb_NS.Location = new System.Drawing.Point(31, 78);
               this.lb_NS.Name = "lb_NS";
               this.lb_NS.Size = new System.Drawing.Size(79, 20);
               this.lb_NS.TabIndex = 44;
               this.lb_NS.Text = "Ngày sinh";
               // 
               // lb_maNV
               // 
               this.lb_maNV.AutoSize = true;
               this.lb_maNV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
               this.lb_maNV.ForeColor = System.Drawing.Color.Navy;
               this.lb_maNV.Location = new System.Drawing.Point(31, 12);
               this.lb_maNV.Name = "lb_maNV";
               this.lb_maNV.Size = new System.Drawing.Size(57, 20);
               this.lb_maNV.TabIndex = 43;
               this.lb_maNV.Text = "Mã NV";
               // 
               // btnDelete
               // 
               this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
               this.btnDelete.ForeColor = System.Drawing.Color.DarkRed;
               this.btnDelete.Location = new System.Drawing.Point(327, 182);
               this.btnDelete.Name = "btnDelete";
               this.btnDelete.Size = new System.Drawing.Size(94, 29);
               this.btnDelete.TabIndex = 42;
               this.btnDelete.Text = "Delete";
               this.btnDelete.UseVisualStyleBackColor = true;
               this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
               this.label1.ForeColor = System.Drawing.Color.Navy;
               this.label1.Location = new System.Drawing.Point(378, 214);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(283, 25);
               this.label1.TabIndex = 41;
               this.label1.Text = "THÔNG TIN NHÂN VIÊN";
               // 
               // btnUpdate
               // 
               this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
               this.btnUpdate.ForeColor = System.Drawing.Color.DarkRed;
               this.btnUpdate.Location = new System.Drawing.Point(227, 182);
               this.btnUpdate.Name = "btnUpdate";
               this.btnUpdate.Size = new System.Drawing.Size(94, 29);
               this.btnUpdate.TabIndex = 40;
               this.btnUpdate.Text = "Update";
               this.btnUpdate.UseVisualStyleBackColor = true;
               this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
               // 
               // btnReset
               // 
               this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
               this.btnReset.ForeColor = System.Drawing.Color.DarkRed;
               this.btnReset.Location = new System.Drawing.Point(691, 186);
               this.btnReset.Name = "btnReset";
               this.btnReset.Size = new System.Drawing.Size(94, 29);
               this.btnReset.TabIndex = 39;
               this.btnReset.Text = "Reset";
               this.btnReset.UseVisualStyleBackColor = true;
               this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
               // 
               // btnAdd
               // 
               this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
               this.btnAdd.ForeColor = System.Drawing.Color.DarkRed;
               this.btnAdd.Location = new System.Drawing.Point(127, 182);
               this.btnAdd.Name = "btnAdd";
               this.btnAdd.Size = new System.Drawing.Size(94, 29);
               this.btnAdd.TabIndex = 37;
               this.btnAdd.Text = "Add";
               this.btnAdd.UseVisualStyleBackColor = true;
               this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
               // 
               // txtLuong
               // 
               this.txtLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.txtLuong.Location = new System.Drawing.Point(691, 104);
               this.txtLuong.Name = "txtLuong";
               this.txtLuong.Size = new System.Drawing.Size(171, 27);
               this.txtLuong.TabIndex = 35;
               this.txtLuong.TextChanged += new System.EventHandler(this.txtLuong_TextChanged);
               // 
               // txtMaNGS
               // 
               this.txtMaNGS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.txtMaNGS.Location = new System.Drawing.Point(691, 143);
               this.txtMaNGS.Name = "txtMaNGS";
               this.txtMaNGS.Size = new System.Drawing.Size(125, 27);
               this.txtMaNGS.TabIndex = 34;
               this.txtMaNGS.TextChanged += new System.EventHandler(this.txtMaNGS_TextChanged);
               // 
               // txtMaPB
               // 
               this.txtMaPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.txtMaPB.Location = new System.Drawing.Point(127, 139);
               this.txtMaPB.Name = "txtMaPB";
               this.txtMaPB.Size = new System.Drawing.Size(100, 27);
               this.txtMaPB.TabIndex = 33;
               this.txtMaPB.TextChanged += new System.EventHandler(this.txtMaPB_TextChanged);
               // 
               // txtHoten
               // 
               this.txtHoten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.txtHoten.Location = new System.Drawing.Point(127, 38);
               this.txtHoten.Name = "txtHoten";
               this.txtHoten.Size = new System.Drawing.Size(315, 27);
               this.txtHoten.TabIndex = 36;
               this.txtHoten.TextChanged += new System.EventHandler(this.txtHoten_TextChanged);
               // 
               // imageList1
               // 
               this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
               this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
               this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
               // 
               // txtFindSV
               // 
               this.txtFindSV.Location = new System.Drawing.Point(802, 248);
               this.txtFindSV.Name = "txtFindSV";
               this.txtFindSV.Size = new System.Drawing.Size(204, 27);
               this.txtFindSV.TabIndex = 59;
               this.txtFindSV.TextChanged += new System.EventHandler(this.txtFindSV_TextChanged);
               // 
               // lbFindSV
               // 
               this.lbFindSV.AutoSize = true;
               this.lbFindSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
               this.lbFindSV.ForeColor = System.Drawing.Color.Navy;
               this.lbFindSV.Location = new System.Drawing.Point(595, 251);
               this.lbFindSV.Name = "lbFindSV";
               this.lbFindSV.Size = new System.Drawing.Size(192, 20);
               this.lbFindSV.TabIndex = 60;
               this.lbFindSV.Text = "Tìm kiếm theo tên/mã NV";
               // 
               // Form_QLNV
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1046, 511);
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.danhsachNhanVien);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
               this.Name = "Form_QLNV";
               this.Text = "Quản lý nhân viên";
               this.Load += new System.EventHandler(this.TTNV_load);
               ((System.ComponentModel.ISupportInitialize)(this.danhsachNhanVien)).EndInit();
               this.panel1.ResumeLayout(false);
               this.panel1.PerformLayout();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.DataGridView danhsachNhanVien;
          private System.Windows.Forms.Panel panel1;
          private System.Windows.Forms.Label lb_tongNV;
          private System.Windows.Forms.TextBox tongNV;
          private System.Windows.Forms.RichTextBox txtdiachi;
          private System.Windows.Forms.RadioButton radioButton3_chuaro;
          private System.Windows.Forms.RadioButton radioButton2_nu;
          private System.Windows.Forms.RadioButton radioButton1_nam;
          private System.Windows.Forms.DateTimePicker dateTimePicker1_NS;
          private System.Windows.Forms.Label lb_name;
          private System.Windows.Forms.Label lb_MaPB;
          private System.Windows.Forms.Label lb_MaNGS;
          private System.Windows.Forms.Label lb_luong;
          private System.Windows.Forms.Label lb_diachi;
          private System.Windows.Forms.Label lb_GT;
          private System.Windows.Forms.Label lb_NS;
          private System.Windows.Forms.Label lb_maNV;
          private System.Windows.Forms.Button btnDelete;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Button btnUpdate;
          private System.Windows.Forms.Button btnReset;
          private System.Windows.Forms.Button btnAdd;
          private System.Windows.Forms.TextBox txtHoten;
          private System.Windows.Forms.TextBox txtLuong;
          private System.Windows.Forms.TextBox txtMaNGS;
          private System.Windows.Forms.TextBox txtMaPB;
          private System.Windows.Forms.TextBox txtMaNV;
          private System.Windows.Forms.ImageList imageList1;
          private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
          private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
          private System.Windows.Forms.DataGridViewTextBoxColumn NS;
          private System.Windows.Forms.DataGridViewTextBoxColumn Luong;
          private System.Windows.Forms.DataGridViewTextBoxColumn GT;
          private System.Windows.Forms.DataGridViewTextBoxColumn DC;
          private System.Windows.Forms.DataGridViewTextBoxColumn Ma_NGS;
          private System.Windows.Forms.DataGridViewTextBoxColumn MaPB;
          private System.Windows.Forms.Label lbFindSV;
          private System.Windows.Forms.TextBox txtFindSV;
     }
}