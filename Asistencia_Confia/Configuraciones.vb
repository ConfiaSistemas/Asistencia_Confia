Imports System.Text
Imports MadMilkman.Ini

Public Class Configuraciones
    Private Sub Configuraciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim iniFile As New IniFile()
            iniFile.Load("C:\Asistencias\SetConfig.ini")
            rutabd = iniFile.Sections(0).Keys(0).Value
            Try
                tolerancia = iniFile.Sections(0).Keys("Tolerancia").Value
            Catch ex As System.ArgumentOutOfRangeException
                FlatAlertBox1.Visible = True
                FlatAlertBox1.kind = FlatAlertBox._Kind.Error
                FlatAlertBox1.Text = "No se encontró el valor tolerancia configurado"
            Catch ex As NullReferenceException
                FlatAlertBox1.Visible = True
                FlatAlertBox1.kind = FlatAlertBox._Kind.Error
                FlatAlertBox1.Text = "No se encontró el valor tolerancia configurado"


            End Try

            Try
                leyenda = iniFile.Sections(0).Keys("Leyenda").Value
            Catch ex As System.ArgumentOutOfRangeException
                FlatAlertBox1.Visible = True
                FlatAlertBox1.kind = FlatAlertBox._Kind.Error
                FlatAlertBox1.Text = "No se encontró el valor leyenda configurado"
            Catch ex As NullReferenceException
                FlatAlertBox1.Visible = True
                FlatAlertBox1.kind = FlatAlertBox._Kind.Error
                FlatAlertBox1.Text = "No se encontró el valor leyenda configurado"
            End Try

            If tolerancia = "" Then
                txtTolerancia.Text = 0
            Else
                txtTolerancia.Text = tolerancia
            End If
            If leyenda = "" Then
                txtleyenda.Text = ""
            Else
                txtleyenda.Text = leyenda
            End If
            txtrutabd.Text = rutabd

        Catch ex As System.IO.FileNotFoundException
            FlatAlertBox1.Visible = True
            FlatAlertBox1.kind = FlatAlertBox._Kind.Error
            FlatAlertBox1.Text = "No se encontró el archivo de configuración"
        End Try
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Try
            Dim inioptions As IniOptions = New IniOptions() With {.Encoding = Encoding.UTF8}
            Dim file As IniFile = New IniFile(inioptions)
            rutabd = txtrutabd.Text
            tolerancia = txtTolerancia.Text
            leyenda = txtleyenda.Text
            Dim section As IniSection = file.Sections.Add("Ruta")
            section.Keys.Add("RutaBD", txtrutabd.Text)
            section.Keys.Add("Tolerancia", txtTolerancia.Text)

            section.Keys.Add("Leyenda", txtleyenda.Text)

            ' Save and encrypt the file.
            file.Save("C:\Asistencias\SetConfig.ini")

            file.Sections.Clear()
            FlatAlertBox1.Visible = True
            FlatAlertBox1.kind = FlatAlertBox._Kind.Success
            FlatAlertBox1.Text = "Guardado correctamente"

        Catch ex As Exception
            FlatAlertBox1.Visible = True
            FlatAlertBox1.kind = FlatAlertBox._Kind.Error
            FlatAlertBox1.Text = ex.Message

        End Try
    End Sub

    Private Sub ColorWheel1_ColorChanged(sender As Object, e As EventArgs) Handles ColorWheel1.ColorChanged
        MessageBox.Show(ColorWheel1.Color.ToKnownColor)
    End Sub
End Class