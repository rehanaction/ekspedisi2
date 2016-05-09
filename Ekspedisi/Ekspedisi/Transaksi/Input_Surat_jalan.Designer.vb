<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Input_Surat_jalan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.checkexcel = New System.Windows.Forms.CheckBox()
        Me.RbtnExp = New System.Windows.Forms.RadioButton()
        Me.RbtnKoli = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbCabang = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbExp = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSJ = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.dgvSJ = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvSJ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBrowse)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtFile)
        Me.GroupBox1.Controls.Add(Me.checkexcel)
        Me.GroupBox1.Controls.Add(Me.RbtnExp)
        Me.GroupBox1.Controls.Add(Me.RbtnKoli)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtHarga)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbCabang)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpTanggal)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbExp)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSJ)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(714, 117)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Surat Jalan"
        '
        'btnBrowse
        '
        Me.btnBrowse.Enabled = False
        Me.btnBrowse.Location = New System.Drawing.Point(589, 16)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(87, 27)
        Me.btnBrowse.TabIndex = 18
        Me.btnBrowse.Text = "Browse..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(380, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 15)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "&Lokasi File&"
        '
        'txtFile
        '
        Me.txtFile.Enabled = False
        Me.txtFile.Location = New System.Drawing.Point(454, 17)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(116, 23)
        Me.txtFile.TabIndex = 16
        '
        'checkexcel
        '
        Me.checkexcel.AutoSize = True
        Me.checkexcel.Location = New System.Drawing.Point(269, 21)
        Me.checkexcel.Name = "checkexcel"
        Me.checkexcel.Size = New System.Drawing.Size(93, 19)
        Me.checkexcel.TabIndex = 15
        Me.checkexcel.Text = "Upload Excel"
        Me.checkexcel.UseVisualStyleBackColor = True
        '
        'RbtnExp
        '
        Me.RbtnExp.AutoSize = True
        Me.RbtnExp.Location = New System.Drawing.Point(176, 21)
        Me.RbtnExp.Name = "RbtnExp"
        Me.RbtnExp.Size = New System.Drawing.Size(77, 19)
        Me.RbtnExp.TabIndex = 14
        Me.RbtnExp.TabStop = True
        Me.RbtnExp.Text = "Eksemplar"
        Me.RbtnExp.UseVisualStyleBackColor = True
        '
        'RbtnKoli
        '
        Me.RbtnKoli.AutoSize = True
        Me.RbtnKoli.Location = New System.Drawing.Point(108, 21)
        Me.RbtnKoli.Name = "RbtnKoli"
        Me.RbtnKoli.Size = New System.Drawing.Size(45, 19)
        Me.RbtnKoli.TabIndex = 13
        Me.RbtnKoli.TabStop = True
        Me.RbtnKoli.Text = "Koli"
        Me.RbtnKoli.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 15)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "&Pilih Satuan&"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 115)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(602, 367)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detail Surat Jalan"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(507, 332)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 27)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(7, 23)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(588, 300)
        Me.DataGridView1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(498, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Label7"
        Me.Label7.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(549, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Label6"
        Me.Label6.Visible = False
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(565, 53)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.ReadOnly = True
        Me.txtHarga.Size = New System.Drawing.Size(140, 23)
        Me.txtHarga.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(495, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "&Harga/Kg&"
        '
        'cmbCabang
        '
        Me.cmbCabang.FormattingEnabled = True
        Me.cmbCabang.Location = New System.Drawing.Point(346, 84)
        Me.cmbCabang.Name = "cmbCabang"
        Me.cmbCabang.Size = New System.Drawing.Size(140, 23)
        Me.cmbCabang.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(266, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cabang"
        '
        'dtpTanggal
        '
        Me.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTanggal.Location = New System.Drawing.Point(108, 84)
        Me.dtpTanggal.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.dtpTanggal.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(140, 23)
        Me.dtpTanggal.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tanggal"
        '
        'cmbExp
        '
        Me.cmbExp.FormattingEnabled = True
        Me.cmbExp.Location = New System.Drawing.Point(346, 53)
        Me.cmbExp.Name = "cmbExp"
        Me.cmbExp.Size = New System.Drawing.Size(140, 23)
        Me.cmbExp.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(266, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ekspedisi"
        '
        'txtSJ
        '
        Me.txtSJ.Location = New System.Drawing.Point(108, 54)
        Me.txtSJ.MaxLength = 20
        Me.txtSJ.Name = "txtSJ"
        Me.txtSJ.Size = New System.Drawing.Size(140, 23)
        Me.txtSJ.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Surat Jalan"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnSimpan)
        Me.GroupBox2.Controls.Add(Me.dgvSJ)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 120)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(714, 367)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detail Surat Jalan"
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(618, 330)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(87, 27)
        Me.BtnSimpan.TabIndex = 1
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'dgvSJ
        '
        Me.dgvSJ.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.dgvSJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSJ.Location = New System.Drawing.Point(7, 23)
        Me.dgvSJ.Name = "dgvSJ"
        Me.dgvSJ.Size = New System.Drawing.Size(699, 300)
        Me.dgvSJ.TabIndex = 0
        '
        'Input_Surat_jalan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(726, 493)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Input_Surat_jalan"
        Me.Text = "Input_Surat_jalan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvSJ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSJ As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbCabang As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbExp As ComboBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvSJ As DataGridView
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtFile As TextBox
    Friend WithEvents checkexcel As CheckBox
    Friend WithEvents RbtnExp As RadioButton
    Friend WithEvents RbtnKoli As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
