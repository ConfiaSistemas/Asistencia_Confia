Public Class Empresas
    Private Sub Empresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            '
            conexion()

            Dim sql As String
            Dim comando As SQLite.SQLiteCommand
            Dim milector As SQLite.SQLiteDataReader

            comando = New SQLite.SQLiteCommand

            comando.Connection = conexion1
            sql = "select id,nombre,ruta from empresas"
            comando.CommandText = sql
            milector = comando.ExecuteReader
            While milector.Read
                Dim botonempresa As New Bunifu.Framework.UI.BunifuFlatButton

                botonempresa.Normalcolor = Color.FromArgb(48, 55, 76)
                botonempresa.Iconimage = My.Resources.empresa_azul
                botonempresa.Size = New Size(390, 48)
                botonempresa.Name = milector("ruta")
                botonempresa.Text = milector("nombre")
                botonempresa.Tag = milector("ruta")
                AddHandler botonempresa.Click, AddressOf clickevennt
                FlowLayoutPanel1.Controls.Add(botonempresa)
            End While
            milector.Close()
            conexion1.Close()

            'Timer1.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub clickevennt(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            '  Dim iniFile As New IniFile()
            'iniFile.Load("C:\Modulo\SetConfig.ini")
            ' Dim section As IniSection = iniFile.Sections.Add("Sucursal")
            ' section.Keys.Add("BdSucursal", sender.name)

            rutabdConsultas = sender.name
            ' Save and encrypt the file.
            ' iniFile.Save("C:\Modulo\SetConfig.ini")
            ' IPConsultas = sender.tag

            ' iniFile.Sections.Clear()
            '  MessageBox.Show("Listo")

            Timer1.Interval = 5000
            Timer1.Enabled = True
            ' Me.Close()
            Menu_Principal.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If rutabdConsultas <> "" Then

            Timer1.Stop()
            Timer1.Enabled = False
            Me.Close()
        End If
    End Sub
End Class