namespace DeThiThu_C_2
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
            groupBox1 = new GroupBox();
            cbbLuaChon = new ComboBox();
            lblLuaChon = new Label();
            txtThongDiep = new TextBox();
            lblThongDiep = new Label();
            btnLoad = new Button();
            btnThongBao = new Button();
            groupBox2 = new GroupBox();
            txtcau2 = new TextBox();
            btnGhi = new Button();
            btnDoc = new Button();
            groupBox3 = new GroupBox();
            txtNganh = new TextBox();
            dgvCau3 = new DataGridView();
            rdoNu = new RadioButton();
            rdoNam = new RadioButton();
            lblGioiTinh = new Label();
            lblNganh = new Label();
            txtTen = new TextBox();
            lblTen = new Label();
            btnXoa = new Button();
            btnLoad1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCau3).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbbLuaChon);
            groupBox1.Controls.Add(lblLuaChon);
            groupBox1.Controls.Add(txtThongDiep);
            groupBox1.Controls.Add(lblThongDiep);
            groupBox1.Controls.Add(btnLoad);
            groupBox1.Controls.Add(btnThongBao);
            groupBox1.Location = new Point(4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(448, 247);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Câu 1";
            // 
            // cbbLuaChon
            // 
            cbbLuaChon.FormattingEnabled = true;
            cbbLuaChon.Location = new Point(28, 195);
            cbbLuaChon.Name = "cbbLuaChon";
            cbbLuaChon.Size = new Size(388, 28);
            cbbLuaChon.TabIndex = 5;
            // 
            // lblLuaChon
            // 
            lblLuaChon.AutoSize = true;
            lblLuaChon.Location = new Point(27, 153);
            lblLuaChon.Name = "lblLuaChon";
            lblLuaChon.Size = new Size(71, 20);
            lblLuaChon.TabIndex = 4;
            lblLuaChon.Text = "Lựa Chọn";
            // 
            // txtThongDiep
            // 
            txtThongDiep.Location = new Point(26, 107);
            txtThongDiep.Name = "txtThongDiep";
            txtThongDiep.Size = new Size(390, 27);
            txtThongDiep.TabIndex = 3;
            // 
            // lblThongDiep
            // 
            lblThongDiep.AutoSize = true;
            lblThongDiep.Location = new Point(26, 84);
            lblThongDiep.Name = "lblThongDiep";
            lblThongDiep.Size = new Size(87, 20);
            lblThongDiep.TabIndex = 2;
            lblThongDiep.Text = "Thông Điệp";
            lblThongDiep.Click += label1_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(205, 35);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 39);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnThongBao
            // 
            btnThongBao.Location = new Point(26, 35);
            btnThongBao.Name = "btnThongBao";
            btnThongBao.Size = new Size(94, 39);
            btnThongBao.TabIndex = 0;
            btnThongBao.Text = "Thông Báo";
            btnThongBao.UseVisualStyleBackColor = true;
            btnThongBao.Click += btnThongBao_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtcau2);
            groupBox2.Controls.Add(btnGhi);
            groupBox2.Controls.Add(btnDoc);
            groupBox2.Location = new Point(4, 257);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(448, 247);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Câu 2";
            // 
            // txtcau2
            // 
            txtcau2.Location = new Point(30, 90);
            txtcau2.Multiline = true;
            txtcau2.Name = "txtcau2";
            txtcau2.Size = new Size(412, 151);
            txtcau2.TabIndex = 4;
            // 
            // btnGhi
            // 
            btnGhi.Location = new Point(207, 45);
            btnGhi.Name = "btnGhi";
            btnGhi.Size = new Size(94, 39);
            btnGhi.TabIndex = 3;
            btnGhi.Text = "Ghi";
            btnGhi.UseVisualStyleBackColor = true;
            btnGhi.Click += btnGhi_Click;
            // 
            // btnDoc
            // 
            btnDoc.Location = new Point(28, 45);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(94, 39);
            btnDoc.TabIndex = 2;
            btnDoc.Text = "Đọc";
            btnDoc.UseVisualStyleBackColor = true;
            btnDoc.Click += btnDoc_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtNganh);
            groupBox3.Controls.Add(dgvCau3);
            groupBox3.Controls.Add(rdoNu);
            groupBox3.Controls.Add(rdoNam);
            groupBox3.Controls.Add(lblGioiTinh);
            groupBox3.Controls.Add(lblNganh);
            groupBox3.Controls.Add(txtTen);
            groupBox3.Controls.Add(lblTen);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(btnLoad1);
            groupBox3.Location = new Point(461, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(421, 494);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Câu 3";
            // 
            // txtNganh
            // 
            txtNganh.Location = new Point(27, 196);
            txtNganh.Name = "txtNganh";
            txtNganh.Size = new Size(390, 27);
            txtNganh.TabIndex = 16;
            // 
            // dgvCau3
            // 
            dgvCau3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCau3.Location = new Point(32, 258);
            dgvCau3.Name = "dgvCau3";
            dgvCau3.RowHeadersWidth = 51;
            dgvCau3.RowTemplate.Height = 29;
            dgvCau3.Size = new Size(383, 222);
            dgvCau3.TabIndex = 15;
            dgvCau3.CellClick += dgvCau3_CellClick;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(251, 229);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(50, 24);
            rdoNu.TabIndex = 14;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(117, 229);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(62, 24);
            rdoNam.TabIndex = 13;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(28, 233);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(68, 20);
            lblGioiTinh.TabIndex = 12;
            lblGioiTinh.Text = "Giới Tính";
            // 
            // lblNganh
            // 
            lblNganh.AutoSize = true;
            lblNganh.Location = new Point(27, 145);
            lblNganh.Name = "lblNganh";
            lblNganh.Size = new Size(53, 20);
            lblNganh.TabIndex = 10;
            lblNganh.Text = "Ngành";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(26, 99);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(390, 27);
            txtTen.TabIndex = 9;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(26, 76);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(32, 20);
            lblTen.TabIndex = 8;
            lblTen.Text = "Tên";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(205, 27);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 39);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Clear";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLoad1
            // 
            btnLoad1.Location = new Point(26, 27);
            btnLoad1.Name = "btnLoad1";
            btnLoad1.Size = new Size(94, 39);
            btnLoad1.TabIndex = 6;
            btnLoad1.Text = "Load";
            btnLoad1.UseVisualStyleBackColor = true;
            btnLoad1.Click += btnLoad1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 510);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCau3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox txtThongDiep;
        private Label lblThongDiep;
        private Button btnLoad;
        private Button btnThongBao;
        private ComboBox cbbLuaChon;
        private Label lblLuaChon;
        private Button btnGhi;
        private Button btnDoc;
        private TextBox txtcau2;
        private DataGridView dgvCau3;
        private RadioButton rdoNu;
        private RadioButton rdoNam;
        private Label lblGioiTinh;
        private Label lblNganh;
        private TextBox txtTen;
        private Label lblTen;
        private Button btnXoa;
        private Button btnLoad1;
        private TextBox txtNganh;
    }
}
