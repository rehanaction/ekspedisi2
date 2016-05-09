<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ekspedisi
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
        Me.lblrep = New System.Windows.Forms.Label()
        Me.cmbExp2 = New System.Windows.Forms.ComboBox()
        Me.cmbExp = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblIDexp = New System.Windows.Forms.Label()
        Me.lblIDcab = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtHp = New System.Windows.Forms.TextBox()
        Me.cmbnamaCabang = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNE = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbEkspedisi = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbTcabang = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvEkspedisi = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSimpanexp = New System.Windows.Forms.Button()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvEkspedisi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblrep)
        Me.GroupBox1.Controls.Add(Me.cmbExp2)
        Me.GroupBox1.Controls.Add(Me.cmbExp)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblIDexp)
        Me.GroupBox1.Controls.Add(Me.lblIDcab)
        Me.GroupBox1.Controls.Add(Me.btnSimpan)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.txtHp)
        Me.GroupBox1.Controls.Add(Me.cmbnamaCabang)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 110)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Ekspedisi"
        '
        'lblrep
        '
        Me.lblrep.AutoSize = True
        Me.lblrep.Location = New System.Drawing.Point(383, 78)
        Me.lblrep.Name = "lblrep"
        Me.lblrep.Size = New System.Drawing.Size(41, 15)
        Me.lblrep.TabIndex = 14
        Me.lblrep.Text = "Label9"
        Me.lblrep.Visible = False
        '
        'cmbExp2
        '
        Me.cmbExp2.Enabled = False
        Me.cmbExp2.FormattingEnabled = True
        Me.cmbExp2.Location = New System.Drawing.Point(379, 48)
        Me.cmbExp2.Name = "cmbExp2"
        Me.cmbExp2.Size = New System.Drawing.Size(140, 23)
        Me.cmbExp2.TabIndex = 13
        '
        'cmbExp
        '
        Me.cmbExp.FormattingEnabled = True
        Me.cmbExp.Location = New System.Drawing.Point(127, 48)
        Me.cmbExp.Name = "cmbExp"
        Me.cmbExp.Size = New System.Drawing.Size(140, 23)
        Me.cmbExp.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 15)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Nama Ekspedisi"
        '
        'lblIDexp
        '
        Me.lblIDexp.AutoSize = True
        Me.lblIDexp.Location = New System.Drawing.Point(469, 25)
        Me.lblIDexp.Name = "lblIDexp"
        Me.lblIDexp.Size = New System.Drawing.Size(41, 15)
        Me.lblIDexp.TabIndex = 11
        Me.lblIDexp.Text = "Label8"
        Me.lblIDexp.Visible = False
        '
        'lblIDcab
        '
        Me.lblIDcab.AutoSize = True
        Me.lblIDcab.Location = New System.Drawing.Point(416, 25)
        Me.lblIDcab.Name = "lblIDcab"
        Me.lblIDcab.Size = New System.Drawing.Size(41, 15)
        Me.lblIDcab.TabIndex = 10
        Me.lblIDcab.Text = "Label8"
        Me.lblIDcab.Visible = False
        '
        'btnSimpan
        '
        Me.btnSimpan.Enabled = False
        Me.btnSimpan.Location = New System.Drawing.Point(288, 75)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(87, 27)
        Me.btnSimpan.TabIndex = 9
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(290, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Ganti Dengan"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(294, 24)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(106, 19)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Ganti Ekspedisi"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txtHp
        '
        Me.txtHp.Location = New System.Drawing.Point(127, 75)
        Me.txtHp.MaxLength = 10
        Me.txtHp.Name = "txtHp"
        Me.txtHp.Size = New System.Drawing.Size(140, 23)
        Me.txtHp.TabIndex = 5
        '
        'cmbnamaCabang
        '
        Me.cmbnamaCabang.FormattingEnabled = True
        Me.cmbnamaCabang.Location = New System.Drawing.Point(127, 22)
        Me.cmbnamaCabang.Name = "cmbnamaCabang"
        Me.cmbnamaCabang.Size = New System.Drawing.Size(140, 23)
        Me.cmbnamaCabang.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Harga/Kg"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Cabang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(198, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Nama Ekspedisi : &"
        '
        'txtNE
        '
        Me.txtNE.Enabled = False
        Me.txtNE.Location = New System.Drawing.Point(313, 18)
        Me.txtNE.MaxLength = 20
        Me.txtNE.Name = "txtNE"
        Me.txtNE.Size = New System.Drawing.Size(140, 23)
        Me.txtNE.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbEkspedisi)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cmbTcabang)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.dgvEkspedisi)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 178)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(568, 339)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detail Ekspedisi"
        '
        'cmbEkspedisi
        '
        Me.cmbEkspedisi.FormattingEnabled = True
        Me.cmbEkspedisi.Location = New System.Drawing.Point(384, 16)
        Me.cmbEkspedisi.Name = "cmbEkspedisi"
        Me.cmbEkspedisi.Size = New System.Drawing.Size(140, 23)
        Me.cmbEkspedisi.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(318, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 15)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "&Ekspedisi : &"
        '
        'cmbTcabang
        '
        Me.cmbTcabang.FormattingEnabled = True
        Me.cmbTcabang.Location = New System.Drawing.Point(170, 16)
        Me.cmbTcabang.Name = "cmbTcabang"
        Me.cmbTcabang.Size = New System.Drawing.Size(140, 23)
        Me.cmbTcabang.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(72, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "&Tujuan Cabang : &"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "&Filter By :&"
        '
        'dgvEkspedisi
        '
        Me.dgvEkspedisi.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvEkspedisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEkspedisi.Location = New System.Drawing.Point(8, 47)
        Me.dgvEkspedisi.Name = "dgvEkspedisi"
        Me.dgvEkspedisi.Size = New System.Drawing.Size(553, 283)
        Me.dgvEkspedisi.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnSimpanexp)
        Me.GroupBox3.Controls.Add(Me.CheckBox2)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtNE)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(563, 59)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Data Baru"
        '
        'btnSimpanexp
        '
        Me.btnSimpanexp.Enabled = False
        Me.btnSimpanexp.Location = New System.Drawing.Point(461, 16)
        Me.btnSimpanexp.Name = "btnSimpanexp"
        Me.btnSimpanexp.Size = New System.Drawing.Size(87, 27)
        Me.btnSimpanexp.TabIndex = 6
        Me.btnSimpanexp.Text = "Simpan"
        Me.btnSimpanexp.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(20, 21)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(158, 19)
        Me.CheckBox2.TabIndex = 5
        Me.CheckBox2.Text = "&Input Data ekspedisi baru&"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Ekspedisi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(575, 531)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Ekspedisi"
        Me.Text = "Ekspedisi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvEkspedisi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txtHp As TextBox
    Friend WithEvents txtNE As TextBox
    Friend WithEvents cmbnamaCabang As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbEkspedisi As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbTcabang As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvEkspedisi As DataGridView
    Friend WithEvents lblIDcab As Label
    Friend WithEvents lblIDexp As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnSimpanexp As Button
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents cmbExp As ComboBox
    Friend WithEvents cmbExp2 As ComboBox
    Friend WithEvents lblrep As Label
End Class
