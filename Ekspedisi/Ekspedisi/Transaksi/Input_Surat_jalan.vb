Imports System.Math
Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Globalization
Public Class Input_Surat_jalan

    Dim totalkoli, total As Double
    Dim berat, tb As Decimal
    Dim tblImport As DataTable
    Dim con As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim RD As OleDbDataReader
    Dim ds As New DataSet
    Dim cmd As OleDbCommand
    Dim source1 As New BindingSource

    Private Sub Input_Surat_jalan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call con_getsetting()
        If con_open() = True Then
            listexp(cmbExp)
        Else
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
            GroupBox3.Enabled = False
            MsgBox("Database Tidak Terhubung", MsgBoxStyle.Exclamation, "Peringatan")

        End If

    End Sub

    Private Sub cmbCabang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCabang.SelectedIndexChanged
        If cmbCabang.Text <> "" Then
            getID(cmbCabang.Text, "nama_cabang", "cabang", Label7)
            getHarga(Label7.Text, Label6.Text, txtHarga)
        End If
    End Sub

    Private Sub cmbExp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbExp.SelectedIndexChanged
        If cmbExp.Text <> "" Then
            getID(cmbExp.Text, "nama_ekspedisi", "Ekspedisi", Label6)
            listcab(cmbCabang, Label6.Text)
        End If
    End Sub
    Sub addcolumndgv()
        dgvSJ.Columns.Clear()
        dgvSJ.Columns.Add("Kode Buku", "Kode buku")
        dgvSJ.Columns.Add("Judul", "Judul")
        dgvSJ.Columns.Add("Berat(Kg)", "Berat(Kg)")
        dgvSJ.Columns.Add("Jumlah Eksemplar", "Jumlah eksemplar")
        dgvSJ.Columns.Add("Jumlah Koli", "Jumlah koli")
        dgvSJ.Columns.Add("Sub Total", "Sub Total")
        dgvSJ.Columns.Add("Jumlah Buku/Koli", "Jumlah Buku/Koli")
    End Sub

    Private Sub dgvSJ_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSJ.CellContentClick, DataGridView1.CellContentClick

    End Sub
    Private Sub dgvSJ_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSJ.CellValueChanged, DataGridView1.CellValueChanged
        Dim harga As Double
        harga = Convert.ToDouble(txtHarga.Text.Replace(".", ""))
        If dgvSJ.Rows(0).Cells(0).Value.ToString.Length <> 0 Then
            If RbtnKoli.Checked = True Then
                For baris As Integer = 0 To dgvSJ.RowCount - 2
                    dgvSJ.Rows(baris).Cells(3).ReadOnly = True
                    If (e.ColumnIndex = 0 And e.RowIndex = baris) Then
                        getDataBuku(dgvSJ.Rows(baris).Cells(0).Value, dgvSJ, baris, "berat_koli")
                    End If
                    If (e.ColumnIndex = 4 And e.RowIndex = baris And checkexcel.Checked = True) Then
                        dgvSJ.Rows(baris).Cells(5).Value = Round((dgvSJ.Rows(baris).Cells(2).Value * dgvSJ.Rows(baris).Cells(4).Value) * harga)
                        dgvSJ.Rows(baris).Cells(3).Value = Round((dgvSJ.Rows(baris).Cells(4).Value * dgvSJ.Rows(baris).Cells(6).Value))

                    End If
                Next

            ElseIf RbtnExp.Checked = True Then
                For baris As Integer = 0 To dgvSJ.RowCount - 2
                    dgvSJ.Rows(baris).Cells(4).ReadOnly = True
                    If (e.ColumnIndex = 0 And e.RowIndex = baris) Then
                        getDataBuku(dgvSJ.Rows(baris).Cells(0).Value, dgvSJ, baris, "berat_exp")
                    End If
                    If (e.ColumnIndex = 3 And e.RowIndex = baris And checkexcel.Checked = True) Then
                        dgvSJ.Rows(baris).Cells(5).Value = Round((dgvSJ.Rows(baris).Cells(2).Value * dgvSJ.Rows(baris).Cells(3).Value) * harga)
                        dgvSJ.Rows(baris).Cells(4).Value = Round((dgvSJ.Rows(baris).Cells(3).Value / dgvSJ.Rows(baris).Cells(6).Value))
                    End If
                Next


            Else
                MsgBox("Harap Pilih Satuan Terlebih Dahulu !!", MsgBoxStyle.Information, "Informasi")
            End If
        Else
            MsgBox("Kode Buku Harus Diisi", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub txtHarga_TextChanged(sender As Object, e As EventArgs) Handles txtHarga.TextChanged
        If txtHarga.Text <> "" Then
            addcolumndgv()
        End If
    End Sub

    Private Sub checkexcel_CheckedChanged(sender As Object, e As EventArgs) Handles checkexcel.CheckedChanged
        If checkexcel.Checked = True Then
            btnBrowse.Enabled = True
        Else
            txtFile.Text = ""
            btnBrowse.Enabled = False
        End If
    End Sub

    Private Sub RbtnKoli_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnKoli.CheckedChanged
        If RbtnKoli.Checked = True Then
            dgvSJ.Rows.Clear()
        End If
    End Sub
    Private Sub RbtnExp_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnExp.CheckedChanged
        If RbtnExp.Checked = True Then
            dgvSJ.Rows.Clear()
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim kb As New List(Of String)()
        Dim fBrowse As New OpenFileDialog
        Dim xlApp As Excel.Application
        Dim xlBook As Excel.Workbook
        Dim xlSheet As Excel.Worksheet
        With fBrowse
            .Filter = "excel files 2003-2007 (*.xls)|*.xls|all files (*.*)|*.*"
            .FilterIndex = 1
            .Title = "Import data From Excel File"
        End With
        If cmbCabang.Text <> "" And cmbExp.Text <> "" Then
            If fBrowse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                txtFile.Text = fBrowse.FileName
                xlApp = New Excel.Application
                xlBook = xlApp.Workbooks.Open(fBrowse.FileName)
                xlSheet = xlBook.Worksheets("Sheet1")
                If RbtnExp.Checked = True Then
                    For x = 1 To xlSheet.UsedRange.Rows.Count - 1
                        dgvSJ.Rows.Add()
                        dgvSJ.Item(0, x - 1).Value = xlSheet.Cells(1 + x, 1).value
                        dgvSJ.Item(3, x - 1).Value = xlSheet.Cells(1 + x, xlSheet.UsedRange.Columns.Count).value
                    Next
                ElseIf RbtnKoli.Checked = True Then
                    For x = 1 To xlSheet.UsedRange.Rows.Count - 1
                        dgvSJ.Rows.Add()
                        dgvSJ.Item(0, x - 1).Value = xlSheet.Cells(1 + x, 1).value
                        dgvSJ.Item(4, x - 1).Value = xlSheet.Cells(1 + x, xlSheet.UsedRange.Columns.Count).value
                    Next
                Else
                    MsgBox("Pilih Satuan Terlebih Dahulu", MsgBoxStyle.Exclamation, "Informasi")
                    txtFile.Text = ""
                End If
            Else
            End If
        Else
            MsgBox("Pilih Cabang dan Ekspedisi Terlebih Dahulu", MsgBoxStyle.Exclamation, "Informasi")
        End If
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If (txtSJ.Text <> "" And cmbCabang.Text <> "" And cmbExp.Text <> "" And txtHarga.Text <> "") And (RbtnExp.Checked = True Or RbtnKoli.Checked = True) Then
            For baris As Integer = 0 To dgvSJ.RowCount - 2
                berat = dgvSJ.Rows(baris).Cells(2).Value * dgvSJ.Rows(baris).Cells(3).Value
                tb = Round(tb + berat)
                totalkoli = totalkoli + dgvSJ.Rows(baris).Cells(4).Value
                total = total + dgvSJ.Rows(baris).Cells(5).Value
                simpandetailInvoice(txtSJ.Text, dgvSJ.Rows(baris).Cells(0).Value, dgvSJ.Rows(baris).Cells(4).Value, dgvSJ.Rows(baris).Cells(3).Value)
            Next
            SimpanInvoice(txtSJ.Text, dtpTanggal.Text, Label6.Text, Label7.Text, totalkoli, tb, total, User_Login.Label2.Text)
            def()
        Else
            MsgBox("Semua Data Wajib diisi", MsgBoxStyle.Exclamation, "Informasi")
        End If
    End Sub
    Private Sub dgvSJ_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSJ.CellEndEdit, DataGridView1.CellEndEdit
        Dim harga As Double
        harga = Convert.ToDouble(txtHarga.Text.Replace(".", ""))
        If RbtnExp.Checked = True Then
            If (e.ColumnIndex = 3) Then
                For baris As Integer = 0 To dgvSJ.RowCount - 2
                    dgvSJ.Rows(baris).Cells(5).Value = Round((dgvSJ.Rows(baris).Cells(2).Value * dgvSJ.Rows(baris).Cells(3).Value) * harga)
                    dgvSJ.Rows(baris).Cells(4).Value = Round((dgvSJ.Rows(baris).Cells(3).Value / dgvSJ.Rows(baris).Cells(6).Value))
                Next
            End If
        ElseIf RbtnKoli.Checked = True Then
            If (e.ColumnIndex = 4) Then
                For baris As Integer = 0 To dgvSJ.RowCount - 2
                    dgvSJ.Rows(baris).Cells(5).Value = Round((dgvSJ.Rows(baris).Cells(2).Value * dgvSJ.Rows(baris).Cells(4).Value) * harga)
                    dgvSJ.Rows(baris).Cells(4).Value = Round((dgvSJ.Rows(baris).Cells(4).Value * dgvSJ.Rows(baris).Cells(6).Value))
                Next
            End If
        End If
    End Sub
    Sub def()
        RbtnExp.Checked = False
        RbtnKoli.Checked = False
        checkexcel.Checked = False
        btnBrowse.Enabled = False
        txtSJ.Text = ""
        txtHarga.Text = ""
        txtFile.Text = ""
        dgvSJ.Columns.Clear()
    End Sub
End Class