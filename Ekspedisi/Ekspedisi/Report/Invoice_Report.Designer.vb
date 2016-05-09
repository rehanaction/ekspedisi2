<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Invoice_Report
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RbtnBelum = New System.Windows.Forms.RadioButton()
        Me.RbtnLunas = New System.Windows.Forms.RadioButton()
        Me.RbtnSemua = New System.Windows.Forms.RadioButton()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.dtpSampai = New System.Windows.Forms.DateTimePicker()
        Me.lblSmpai = New System.Windows.Forms.Label()
        Me.dtpDari = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbExp = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvReport = New System.Windows.Forms.DataGridView()
        Me.btnStatus = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNoInvoice = New System.Windows.Forms.TextBox()
        Me.dtpInvoice = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.RbtnBelum)
        Me.GroupBox1.Controls.Add(Me.RbtnLunas)
        Me.GroupBox1.Controls.Add(Me.RbtnSemua)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Controls.Add(Me.btnCari)
        Me.GroupBox1.Controls.Add(Me.dtpSampai)
        Me.GroupBox1.Controls.Add(Me.lblSmpai)
        Me.GroupBox1.Controls.Add(Me.dtpDari)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbExp)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(671, 82)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter Data"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "&Tampilkan : &"
        '
        'RbtnBelum
        '
        Me.RbtnBelum.AutoSize = True
        Me.RbtnBelum.Location = New System.Drawing.Point(285, 21)
        Me.RbtnBelum.Name = "RbtnBelum"
        Me.RbtnBelum.Size = New System.Drawing.Size(103, 19)
        Me.RbtnBelum.TabIndex = 9
        Me.RbtnBelum.TabStop = True
        Me.RbtnBelum.Text = "Belum Di Bayar"
        Me.RbtnBelum.UseVisualStyleBackColor = True
        '
        'RbtnLunas
        '
        Me.RbtnLunas.AutoSize = True
        Me.RbtnLunas.Location = New System.Drawing.Point(167, 21)
        Me.RbtnLunas.Name = "RbtnLunas"
        Me.RbtnLunas.Size = New System.Drawing.Size(101, 19)
        Me.RbtnLunas.TabIndex = 8
        Me.RbtnLunas.TabStop = True
        Me.RbtnLunas.Text = "Telah Di Bayar"
        Me.RbtnLunas.UseVisualStyleBackColor = True
        '
        'RbtnSemua
        '
        Me.RbtnSemua.AutoSize = True
        Me.RbtnSemua.Location = New System.Drawing.Point(92, 21)
        Me.RbtnSemua.Name = "RbtnSemua"
        Me.RbtnSemua.Size = New System.Drawing.Size(59, 19)
        Me.RbtnSemua.TabIndex = 7
        Me.RbtnSemua.TabStop = True
        Me.RbtnSemua.Text = "Semua"
        Me.RbtnSemua.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(89, 3)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(41, 15)
        Me.lblID.TabIndex = 1
        Me.lblID.Text = "Label3"
        Me.lblID.Visible = False
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(614, 48)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(49, 27)
        Me.btnCari.TabIndex = 6
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'dtpSampai
        '
        Me.dtpSampai.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSampai.Location = New System.Drawing.Point(484, 51)
        Me.dtpSampai.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.dtpSampai.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtpSampai.Name = "dtpSampai"
        Me.dtpSampai.Size = New System.Drawing.Size(122, 23)
        Me.dtpSampai.TabIndex = 5
        '
        'lblSmpai
        '
        Me.lblSmpai.AutoSize = True
        Me.lblSmpai.Location = New System.Drawing.Point(434, 54)
        Me.lblSmpai.Name = "lblSmpai"
        Me.lblSmpai.Size = New System.Drawing.Size(45, 15)
        Me.lblSmpai.TabIndex = 4
        Me.lblSmpai.Text = "&Sampai&"
        '
        'dtpDari
        '
        Me.dtpDari.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDari.Location = New System.Drawing.Point(317, 51)
        Me.dtpDari.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.dtpDari.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtpDari.Name = "dtpDari"
        Me.dtpDari.Size = New System.Drawing.Size(111, 23)
        Me.dtpDari.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(237, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Dari Tanggal&"
        '
        'cmbExp
        '
        Me.cmbExp.FormattingEnabled = True
        Me.cmbExp.Location = New System.Drawing.Point(92, 51)
        Me.cmbExp.Name = "cmbExp"
        Me.cmbExp.Size = New System.Drawing.Size(140, 23)
        Me.cmbExp.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Pilih Ekspedisi&"
        '
        'dgvReport
        '
        Me.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReport.Location = New System.Drawing.Point(3, 91)
        Me.dgvReport.Name = "dgvReport"
        Me.dgvReport.Size = New System.Drawing.Size(671, 388)
        Me.dgvReport.TabIndex = 1
        '
        'btnStatus
        '
        Me.btnStatus.Location = New System.Drawing.Point(558, 486)
        Me.btnStatus.Name = "btnStatus"
        Me.btnStatus.Size = New System.Drawing.Size(117, 27)
        Me.btnStatus.TabIndex = 2
        Me.btnStatus.Text = "Perbaharui Status"
        Me.btnStatus.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(142, 492)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "&No Invoice&"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(342, 492)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "&Tanggal Invoice&"
        Me.Label5.Visible = False
        '
        'txtNoInvoice
        '
        Me.txtNoInvoice.Location = New System.Drawing.Point(218, 488)
        Me.txtNoInvoice.MaxLength = 15
        Me.txtNoInvoice.Name = "txtNoInvoice"
        Me.txtNoInvoice.Size = New System.Drawing.Size(116, 23)
        Me.txtNoInvoice.TabIndex = 5
        Me.txtNoInvoice.Visible = False
        '
        'dtpInvoice
        '
        Me.dtpInvoice.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInvoice.Location = New System.Drawing.Point(444, 489)
        Me.dtpInvoice.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.dtpInvoice.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtpInvoice.Name = "dtpInvoice"
        Me.dtpInvoice.Size = New System.Drawing.Size(101, 23)
        Me.dtpInvoice.TabIndex = 6
        Me.dtpInvoice.Visible = False
        '
        'Invoice_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(677, 526)
        Me.Controls.Add(Me.dtpInvoice)
        Me.Controls.Add(Me.txtNoInvoice)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnStatus)
        Me.Controls.Add(Me.dgvReport)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Invoice_Report"
        Me.Text = "Invoice_Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCari As Button
    Friend WithEvents dtpSampai As DateTimePicker
    Friend WithEvents lblSmpai As Label
    Friend WithEvents dtpDari As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbExp As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblID As Label
    Friend WithEvents dgvReport As DataGridView
    Friend WithEvents btnStatus As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents RbtnBelum As RadioButton
    Friend WithEvents RbtnLunas As RadioButton
    Friend WithEvents RbtnSemua As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNoInvoice As TextBox
    Friend WithEvents dtpInvoice As DateTimePicker
End Class
