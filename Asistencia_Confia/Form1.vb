Imports MadMilkman.Ini
Public Class Form1
    Private Sub FlatStickyButton1_Click(sender As Object, e As EventArgs) Handles FlatStickyButton1.Click
        Dim OpenFileDialog1 As OpenFileDialog
        OpenFileDialog1 = New OpenFileDialog
        OpenFileDialog1.Title = "Elige la base de datos"
        OpenFileDialog1.Filter = "SQLITE ZKTECO|*.db"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            txtruta.Text = OpenFileDialog1.FileName
        Else
            MessageBox.Show("No seleccionaste ningún archivo")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim iniFile As New IniFile()
            iniFile.Load("C:\Asistencias\SetConfig.ini")


            rutabd = iniFile.Sections(0).Keys("RutaBD").Value

                Try
                tolerancia = iniFile.Sections(0).Keys("Tolerancia").Value
            Catch ex As System.ArgumentOutOfRangeException
                MessageBox.Show("No se encontró el valor tolerancia configurado, se recomienda revisar la configuración")
            Catch ex As NullReferenceException
                MessageBox.Show("No se encontró el valor tolerancia configurado, se recomienda revisar la configuración")
            End Try
            Try
                leyenda = iniFile.Sections(0).Keys("Leyenda").Value
            Catch ex As System.ArgumentOutOfRangeException
                leyenda = ""
                MessageBox.Show("No se encontró el valor leyenda configurado, se recomienda revisar la configuración")
            Catch ex As NullReferenceException
                leyenda = ""
                MessageBox.Show("No se encontró el valor leyenda configurado, se recomienda revisar la configuración")
            End Try


            If rutabd <> "" Then
                ' Menu_Principal.Show()
                Empresas.Show()
                Me.Close()
            Else

            End If
        Catch ex As System.IO.FileNotFoundException
            FlatAlertBox1.kind = FlatAlertBox._Kind.Error
            FlatAlertBox1.Text = "No se encontró el archivo de configuración"
        Catch ex As System.ArgumentOutOfRangeException
            FlatAlertBox1.kind = FlatAlertBox._Kind.Error
            FlatAlertBox1.Text = "No se encontró la ruta de la base de datos"
        Catch ex As NullReferenceException
            FlatAlertBox1.kind = FlatAlertBox._Kind.Error
            FlatAlertBox1.Text = "No se encontró la ruta de la base de datos"

        End Try
    End Sub



    Private Sub FlatStickyButton2_Click_1(sender As Object, e As EventArgs) Handles FlatStickyButton2.Click
        Try
            Dim file As IniFile = New IniFile
            rutabd = txtruta.Text
            tolerancia = 0
            leyenda = ""
            Dim section As IniSection = file.Sections.Add("Ruta")
            section.Keys.Add("RutaBD", txtruta.Text)


            ' Save and encrypt the file.
            file.Save("C:\Asistencias\SetConfig.ini")

            file.Sections.Clear()
            MessageBox.Show("Listo")
            Menu_Principal.Show()

            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            FlatAlertBox1.kind = FlatAlertBox._Kind.Error
            FlatAlertBox1.Text = ex.Message

        End Try
    End Sub
End Class
