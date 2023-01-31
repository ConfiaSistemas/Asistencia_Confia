Imports System.ComponentModel

Public Class Empleados


    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub

    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        dtdatos.ScrollBars = ScrollBars.None
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim comando As SQLite.SQLiteCommand
        conexionConsultas()
        Dim sql As String
        Dim reader As SQLite.SQLiteDataReader


        comando = New SQLite.SQLiteCommand
        comando.Connection = conexionConsulta
        sql = "select * from hr_employee"

        comando.CommandText = sql
        reader = comando.ExecuteReader()
        While reader.Read
            dtdatos.Rows.Add(reader("id"), reader("emp_firstname"), reader("emp_lastname"))
        End While
        conexionConsulta.Close()
    End Sub

    Private Sub txtnombre_OnValueChanged(sender As Object, e As EventArgs) Handles txtnombre.OnValueChanged
        dtdatos.Rows.Clear()
        Dim comando As SQLite.SQLiteCommand
        conexionConsultas()
        Dim sql As String
        Dim reader As SQLite.SQLiteDataReader


        comando = New SQLite.SQLiteCommand
        comando.Connection = conexionConsulta
        sql = "select * from hr_employee where emp_firstname like '%" & txtnombre.Text & "%' or emp_lastname like '%" & txtnombre.Text & "%' "

        comando.CommandText = sql
        reader = comando.ExecuteReader()
        While reader.Read
            dtdatos.Rows.Add(reader("id"), reader("emp_firstname"), reader("emp_lastname"))
        End While
        conexion1.Close()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        dtdatos.ScrollBars = ScrollBars.Both
    End Sub



    Private Sub dtdatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtdatos.CellDoubleClick
        Principal.txt_idempleado.Text = dtdatos.CurrentRow.Cells(0).Value
        Me.Close()
    End Sub
End Class