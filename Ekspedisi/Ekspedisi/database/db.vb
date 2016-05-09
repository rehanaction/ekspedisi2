Imports MySql.Data.MySqlClient
Module db
    Public conn As New MySqlConnection
    Public CMD As MySqlCommand
    Public DS, SDS As New DataSet
    Public DA, SDA As MySqlDataAdapter
    Public RD As MySqlDataReader
    Public dt As DataTable
    Public lokasiData As String
    Private bindingSource1 As New BindingSource()

    Public con_server As String
    Public con_userid As String
    Public con_password As String
    Public con_database As String
    Public con_string As String
    Public Function con_open() As Boolean
        Try
            con_string = "Server={0};user id={1};password={2};database=ekspedisi;"
            con_string = String.Format(con_string, con_server, con_userid, con_password, con_database)
            conn = New MySqlConnection(con_string)
            conn.Open()

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function
    Public Sub con_getsetting()
        con_server = GetSetting("duta", "config", "server", "")
        con_userid = GetSetting("duta", "config", "userid", "")
        con_password = GetSetting("duta", "config", "password", "")
        con_database = GetSetting("duta", "config", "database", "")
    End Sub

    Public Sub con_savesetting(ByVal server As String, ByVal userid As String, ByVal password As String)
        Call SaveSetting("duta", "config", "server", server)
        Call SaveSetting("duta", "config", "userid", userid)
        Call SaveSetting("duta", "config", "password", password)
        Call SaveSetting("uta", "config", "database", "ekspedisi")
        Call con_getsetting()
    End Sub
    Public Sub koneksidb()
        Dim konstring As String
        konstring = "Server=localhost;user id=root;password=;database=ekspedisi;"
        Try
            conn = New MySqlConnection(konstring)
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Gagal")
            Application.Exit()
        End Try
    End Sub
    Public Sub listcabang()
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        Dim query As String
        'Dim a As Integer
        query = "select nama_cabang from cabang ORDER BY nama_cabang asc"
        CMD = New MySqlCommand(query, conn)
        RD = CMD.ExecuteReader
        While RD.Read
            Ekspedisi.cmbnamaCabang.Items.Add(RD.Item(0))
            Ekspedisi.cmbTcabang.Items.Add(RD.Item(0))
        End While
        conn.Close()
    End Sub
    Public Sub listexp(ByVal attr As ComboBox)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        Dim query As String
        'Dim a As Integer
        query = "select nama_ekspedisi from ekspedisi ORDER BY nama_ekspedisi asc"
        CMD = New MySqlCommand(query, conn)
        RD = CMD.ExecuteReader
        attr.Items.Clear()
        While RD.Read
            attr.Items.Add(RD.Item(0))
        End While
        conn.Close()
    End Sub
    Public Sub listcab(ByVal attr As ComboBox, ByVal criteria As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        Dim query As String
        'Dim a As Integer
        query = "select c.nama_cabang from ekspedisi e join detai_ekspedisi de on e.id=de.id_ekspedisi join cabang c on de.id_cabang=c.id where de.id_ekspedisi='" & criteria & "'"
        CMD = New MySqlCommand(query, conn)
        RD = CMD.ExecuteReader
        attr.Items.Clear()
        While RD.Read
            attr.Items.Add(RD.Item(0))
        End While
        conn.Close()
    End Sub
    Public Sub getHarga(ByVal idc As Integer, ByVal idx As Integer,attr As TextBox)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        Dim query As String
        'Dim a As Integer
        query = "select de.harga from ekspedisi e join detai_ekspedisi de on e.id=de.id_ekspedisi join cabang c on de.id_cabang=c.id where de.id_ekspedisi='" & idx & "' and de.id_cabang='" & idc & "'"
        CMD = New MySqlCommand(query, conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then

            attr.Text = RD(0).ToString
            attr.Text = FormatNumber(attr.Text, 0)
            attr.SelectionStart = Microsoft.VisualBasic.Len(attr.Text)
        End If
        conn.Close()
    End Sub
    Public Sub getID(ByVal nc As String, ByVal field As String, ByVal table As String, ByVal attr As Label)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If

        Dim query As String
        query = "select id from " & table & " where " & field & "='" & nc & "'"
        CMD = New MySqlCommand(query, conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            attr.Text = RD(0).ToString
        End If
        conn.Close()
    End Sub
    Public Sub saveEkspedisi(ByVal id As Integer, ByVal hp As String, ByVal rep As Integer, ByVal id_exp As Integer)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        Dim query As String
        query = "select c.nama_cabang,e.nama_ekspedisi,de.harga from ekspedisi e join detai_ekspedisi de on e.id=de.id_ekspedisi join cabang c on de.id_cabang=c.id where de.id_cabang=" & id & " and id_ekspedisi='" & id_exp & "'"
        CMD = New MySqlCommand(query, conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            conn.Close()
            conn.Open()
            Try
                Dim update As String = "Update detai_ekspedisi set harga='" & hp & "',id_ekspedisi='" & rep & "' where id_cabang='" & id & "'"
                CMD = New MySqlCommand(update, conn)
                CMD.ExecuteNonQuery()
                CMD.Dispose()
                MsgBox("Data Tersimpan ", MsgBoxStyle.Information, "Informasi")
                Ekspedisi.dgvEkspedisi.DataSource = Nothing
                Ekspedisidgv("", "")
                def()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        Else
            conn.Close()
            conn.Open()
            Ekspedisi.btnSimpan.Enabled = True
            Try
                Dim insert As String = "insert into detai_ekspedisi (id_ekspedisi,id_cabang,harga) values('" & id_exp & "','" & id & "','" & hp & "')"
                CMD = New MySqlCommand(insert, conn)
                CMD.ExecuteNonQuery()
                CMD.Dispose()
                MsgBox("Data Tersimpan ", MsgBoxStyle.Information, "Informasi")
                def()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End If
        conn.Close()
    End Sub
    Public Sub checkdata(ByVal id As Integer)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        Dim query As String
        query = "select c.nama_cabang,e.nama_ekspedisi,de.harga,de.id_ekspedisi from ekspedisi e join detai_ekspedisi de on e.id=de.id_ekspedisi join cabang c on de.id_cabang=c.id where de.id_cabang=" & id & ""
        CMD = New MySqlCommand(query, conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            RemoveHandler Ekspedisi.cmbExp.SelectedIndexChanged, AddressOf Ekspedisi.cmbExp_SelectedIndexChanged
            Ekspedisi.cmbnamaCabang.Text = RD(0).ToString
            Ekspedisi.cmbExp.Text = RD(1).ToString
            Ekspedisi.txtHp.Text = RD(2)
            Ekspedisi.lblIDexp.Text = RD(3).ToString
            Ekspedisi.btnSimpan.Enabled = True
            AddHandler Ekspedisi.cmbExp.SelectedIndexChanged, AddressOf Ekspedisi.cmbExp_SelectedIndexChanged
        Else

            MsgBox("Data Ekspedisi Cabang belum Input ", MsgBoxStyle.Information, "Informasi")

            def()
            Ekspedisi.btnSimpan.Enabled = True
        End If
    End Sub
    Public Sub simpannewEXp(ByVal ne As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        Dim query As String
        query = "select * from ekspedisi where nama_ekspedisi='" & ne & "'"
        CMD = New MySqlCommand(query, conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            conn.Close()
            conn.Open()
            Try
                Dim simpan As String = "Insert into ekspedisi (nama_ekspedisi) values('" & ne & "')"
                CMD = New MySqlCommand(simpan, conn)
                CMD.ExecuteNonQuery()
                CMD.Dispose()
                MsgBox("Data Berhasil Tersimpan", MsgBoxStyle.Information, "Informasi")
                Ekspedisi.CheckBox2.Checked = False
                Ekspedisi.txtNE.Text = ""
                Ekspedisi.btnSimpanexp.Enabled = False
                listexp(Ekspedisi.cmbExp)
                listexp(Ekspedisi.cmbExp2)
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        Else
            MsgBox("Ekspedisi dengan nama " & ne & " Telah terdaftar", MsgBoxStyle.Information, "Information")
            Ekspedisi.txtNE.Text = ""
        End If
        conn.Close()
    End Sub
    Sub def()
        Ekspedisi.cmbnamaCabang.Text = ""
        Ekspedisi.cmbExp.Text = ""
        Ekspedisi.txtHp.Text = ""
        Ekspedisi.CheckBox1.Checked = False
        Ekspedisi.cmbExp2.Text = ""
        Ekspedisi.btnSimpan.Enabled = False
    End Sub
    Public Sub Ekspedisidgv(ByVal criteria As String, ByVal field As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        If criteria = "" Then
            DA = New MySqlDataAdapter("select e.nama_ekspedisi,c.nama_cabang,de.harga from ekspedisi e join detai_ekspedisi de on e.id=de.id_ekspedisi join cabang c on de.id_cabang=c.id", conn)
            DS.Reset()
            DS.Clear()
            DS.Tables.Clear()
            DA.Fill(DS)
            Ekspedisi.dgvEkspedisi.DataSource = DS.Tables(0)
        Else
            DA = New MySqlDataAdapter("select e.nama_ekspedisi,c.nama_cabang,de.harga from ekspedisi e join detai_ekspedisi de on e.id=de.id_ekspedisi join cabang c on de.id_cabang=c.id where " & field & "='" & criteria & "'", conn)
            DS.Reset()
            DS.Clear()
            DS.Tables.Clear()
            DA.Fill(DS)
            Ekspedisi.dgvEkspedisi.DataSource = DS.Tables(0)
        End If
        conn.Close()
    End Sub
    Public Sub getDataBuku(ByVal param As String, ByVal attr As DataGridView, ByVal baris As Integer, ByVal field As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("select kode_buku,judul," & field & ",jumlah_koli from buku where kode_buku='" & param & "'", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            attr.Rows(baris).Cells(1).Value = RD.Item(1)
            attr.Rows(baris).Cells(2).Value = RD.Item(2)
            attr.Rows(baris).Cells(3).Value = 0
            attr.Rows(baris).Cells(4).Value = 0
            attr.Rows(baris).Cells(6).Value = RD.Item(3)
            attr.Rows(baris).Cells(1).ReadOnly = True
            attr.Rows(baris).Cells(2).ReadOnly = True
            attr.Rows(baris).Cells(5).ReadOnly = True
        Else
            MsgBox("Kode Buku Tidak Ditemukan !!", MsgBoxStyle.Information)
        End If
    End Sub
    Public Sub SimpanInvoice(ByVal nsj As String, ByVal Tgl As String, ByVal idx As Integer, ByVal idc As Integer, ByVal tk As String, ByVal tb As String, ByVal st As String, ByVal uid As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("select * from invoice i join detail_invoice di on i.nsj=di.nsj where i.nsj='" & nsj & "'", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            conn.Close()
            conn.Open()
            Try
                Dim simpan As String = "Insert into invoice (nsj,Tanggal,id_ekspedisi,id_cabang,total_koli,total_berat,sub_total_tagihan,insert_by) values('" & nsj & "','" & Tgl & "'," & idx & "," & idc & "," & tk & "," & tb & "," & st & "," & uid & ")"
                CMD = New MySqlCommand(simpan, conn)
                CMD.ExecuteNonQuery()
                CMD.Dispose()
                MsgBox("Data Berhasil Tersimpan", MsgBoxStyle.Information, "Informasi")
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        Else
            MsgBox("No Surat Jalan Sudah terdaftar", MsgBoxStyle.Exclamation, "Informasi")
        End If
    End Sub
    Public Sub simpandetailInvoice(ByVal nsj As String, ByVal kb As String, ByVal jk As String, ByVal je As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("select * from invoice i join detail_invoice di on i.nsj=di.nsj where i.nsj='" & nsj & "'", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            conn.Close()
            conn.Open()
            Try
                Dim simpan As String = "Insert into detail_invoice (nsj,kode_buku,jumlah_koli,jumlah_exp) values('" & nsj & "','" & kb & "'," & jk & "," & je & ")"
                CMD = New MySqlCommand(simpan, conn)
                CMD.ExecuteNonQuery()
                CMD.Dispose()

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        Else
            MsgBox("No Surat Jalan Sudah terdaftar", MsgBoxStyle.Exclamation, "Informasi")
        End If
    End Sub
    Public Sub ReportEkspedisi(ByVal idx As String, ByVal dari As String, ByVal sampai As String, ByVal grid As DataGridView, ByVal criteria As String)
        Dim total, tb, tk As Double
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        If criteria = "" Then
            DA = New MySqlDataAdapter("select i.nsj,i.no_invoice,i.tgl_invoice,i.Tanggal,e.nama_ekspedisi,c.nama_cabang as Tujuan,de.harga,i.total_berat as Berat,i.total_koli,i.sub_total_tagihan,COALESCE(i.status,'0') as status from invoice i join cabang c on i.id_cabang=c.id join ekspedisi e on i.id_ekspedisi=e.id join detai_ekspedisi de on de.id_cabang=c.id  where  i.id_ekspedisi='" & idx & "' and i.Tanggal >= '" & dari & "' and i.Tanggal <='" & sampai & "'", conn)
            DS.Reset()
            DS.Clear()
            DS.Tables.Clear()
            DA.Fill(DS)
        ElseIf criteria = "1" Then
            DA = New MySqlDataAdapter("select i.nsj,i.no_invoice,i.tgl_invoice,i.Tanggal,e.nama_ekspedisi,c.nama_cabang as Tujuan,de.harga,i.total_berat as Berat,i.total_koli,i.sub_total_tagihan,COALESCE(i.status,'0') as status from invoice i join cabang c on i.id_cabang=c.id join ekspedisi e on i.id_ekspedisi=e.id join detai_ekspedisi de on de.id_cabang=c.id  where i.id_ekspedisi='" & idx & "' and i.Tanggal >= '" & dari & "' and i.Tanggal <='" & sampai & "' and status='" & criteria & "'", conn)
            DS.Reset()
            DS.Clear()
            DS.Tables.Clear()
            DA.Fill(DS)
        ElseIf criteria = "0" Then
            DA = New MySqlDataAdapter("select i.nsj,i.no_invoice,i.tgl_invoice,i.Tanggal,e.nama_ekspedisi,c.nama_cabang as Tujuan,de.harga,i.total_berat as Berat,i.total_koli,i.sub_total_tagihan,COALESCE(i.status,'0') as status from invoice i join cabang c on i.id_cabang=c.id join ekspedisi e on i.id_ekspedisi=e.id join detai_ekspedisi de on de.id_cabang=c.id  where i.id_ekspedisi='" & idx & "' and i.Tanggal >= '" & dari & "' and i.Tanggal <='" & sampai & "' and status IS NULL ", conn)
            DS.Reset()
            DS.Clear()
            DS.Tables.Clear()
            DA.Fill(DS)
        End If

        If DS.Tables(0).Rows.Count > 0 Then
            grid.DataSource = Nothing
            grid.Columns.Clear()
            grid.DataSource = DS.Tables(0)
            grid.Columns(10).Visible = False
            Dim ck As New DataGridViewCheckBoxColumn
            Dim chk As New DataGridViewCheckBoxColumn()
            grid.Columns.Add(chk)
            chk.HeaderText = "Status"
            chk.Name = "chk"
            For i = 0 To DS.Tables(0).Rows.Count - 1
                total += grid.Rows(i).Cells(9).Value
                tk += grid.Rows(i).Cells(8).Value
                tb += grid.Rows(i).Cells(7).Value
                If grid.Rows(i).Cells(10).Value = "1" Then
                    grid.Rows(i).Cells(11).Value = True
                Else
                    grid.Rows(i).Cells(11).Value = False
                End If
            Next
            Dim akhir As Integer = DS.Tables(0).Rows.Count
            grid.Rows(akhir).Cells(11).ReadOnly = True
            grid.Rows(akhir).Cells(9).Value = total
            grid.Rows(akhir).Cells(8).Value = tk
            grid.Rows(akhir).Cells(7).Value = tb
            grid.Rows(akhir).Cells(6).Value = "Total Seluruh-nya"
        Else
            grid.DataSource = Nothing
            grid.Columns.Clear()
            MsgBox("Data tidak ditemukan periksa kembali data yang anda cari", MsgBoxStyle.Information, "Informasi")
        End If
        conn.Close()
    End Sub
    Public Sub updateStatus(ByVal nsj As String, ByVal status As String, ByVal ni As String, ByVal ti As String, ByVal uid As String)
        If status = True Then
            status = "1"
        Else
            status = "0"
        End If
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("SELECT * FROM invoice WHERE nsj='" & nsj & "'", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            conn.Close()
            conn.Open()
            Try
                Dim simpan As String = "Update invoice set status='" & status & "',no_invoice='" & ni & "',tgl_invoice='" & ti & "',user_id='" & uid & "' where nsj='" & nsj & "'"
                CMD = New MySqlCommand(simpan, conn)
                CMD.ExecuteNonQuery()
                CMD.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        Else
            MsgBox("No Surat Jalan Sudah terdaftar", MsgBoxStyle.Exclamation, "Informasi")
        End If
    End Sub
    Public Sub newUser(ByVal name As String, ByVal uname As String, ByVal pwd As String, ByVal type As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("SELECT * FROM users WHERE user_username='" & uname & "'", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            conn.Close()
            conn.Open()
            Try
                Dim simpan As String = "Insert into users (user_name,user_username,user_pass,user_type) values('" & name & "','" & uname & "','" & pwd & "','" & type & "')"
                CMD = New MySqlCommand(simpan, conn)
                CMD.ExecuteNonQuery()
                CMD.Dispose()
                MsgBox("Data Berhasil tersimpan", MsgBoxStyle.Information, "Informasi")
                Daftar_User_Baru.Close()
                User_Login.Show()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        Else
            MsgBox("Nama user Sudah terdaftar harap gunakan nama lain", MsgBoxStyle.Exclamation, "Peringatan")
        End If
    End Sub
    Public Sub cekLogin(ByVal uname As String, ByVal pwd As String, ByVal type As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("SELECT * FROM users WHERE user_username='" & uname & "' and user_pass='" & pwd & "' and user_type='" & type & "' and status='aktif'", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Menu.Show()
            User_Login.Label2.Text = RD(0).ToString
            User_Login.Hide()
        Else
            MsgBox("User Name atau password yang anda masukan salah", MsgBoxStyle.Exclamation, "Peringatan")
        End If

    End Sub

End Module
