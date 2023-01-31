Imports System.ComponentModel
Imports System.Data.SQLite

Public Class Principal
    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox1.SelectedIndexChanged
        Dim numMes As Integer
        numMes = MetroComboBox1.SelectedIndex + 1
        Dim yearActual As Integer
        yearActual = Date.Now.Year
        Dim cantDias As Integer
        cantDias = System.DateTime.DaysInMonth(yearActual, numMes)
        Dim nombreDia As String
        Dim fechaDia As DateTime = New DateTime(yearActual, numMes, 1)
        nombreDia = fechaDia.DayOfWeek
        Dim iniciofecha As Integer

        Select Case nombreDia
            Case "Domingo"
                iniciofecha = 1
            Case "Lunes"
                iniciofecha = 2
            Case "Martes"
                iniciofecha = 3
            Case "Miércoles"
                iniciofecha = 4
            Case "Jueves"
                iniciofecha = 5
            Case "Viernes"
                iniciofecha = 6
            Case "Sábado"
                iniciofecha = 7
        End Select

    End Sub

    Private Sub MetroGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellContentClick

    End Sub

    Private Sub MetroGrid1_Paint(sender As Object, e As PaintEventArgs) Handles MetroGrid1.Paint
        Dim monthes As String() = {"", "Entrada", "Salida a Comer", "Entrada de comer", "Salida"}

        Dim j As Integer = 0
        While j < 10
            Dim r1 As Rectangle = Me.MetroGrid1.GetCellDisplayRectangle(j, -1, True)
            r1.X += 1
            r1.Y += 1
            r1.Width = r1.Width * 2 - 2
            r1.Height = r1.Height / 2 - 2

            e.Graphics.FillRectangle(New SolidBrush(Me.MetroGrid1.ColumnHeadersDefaultCellStyle.BackColor), r1)

            Dim format As New StringFormat()

            format.Alignment = StringAlignment.Center
            format.LineAlignment = StringAlignment.Center
            e.Graphics.DrawString(monthes(j \ 2), Me.MetroGrid1.ColumnHeadersDefaultCellStyle.Font,
                                  New SolidBrush(Me.MetroGrid1.ColumnHeadersDefaultCellStyle.ForeColor), r1, format)
            j += 2
        End While
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        With MetroGrid1
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            .ColumnHeadersHeight = .ColumnHeadersHeight * 2
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        End With
    End Sub



    Private Sub txt_idempleado_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_idempleado.KeyDown
        If e.KeyCode = Keys.F2 Then
            Empleados.ShowDialog()
        End If
    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        MetroGrid1.ScrollBars = ScrollBars.None
        MetroGrid2.ScrollBars = ScrollBars.None
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'MetroGrid1.AutoGenerateColumns = False
        Dim cadena As String
        cadena = "Data Source=" & rutabdConsultas & ";Version=3;MultipleActiveResultSets=True;HDR=N0;"
        Dim consulta As String
        Dim fechainserciondesde As String
        fechainserciondesde = DateDesde.Value.Date

        Dim fechasqldesde As Date
        fechasqldesde = fechainserciondesde
        fechainserciondesde = Format(fechasqldesde, "yyyy-MM-dd")

        Dim fechainsercionhasta As String
        fechainsercionhasta = DateHasta.Value.Date

        Dim fechasqlhasta As Date
        fechasqlhasta = fechainsercionhasta
        fechainsercionhasta = Format(fechasqlhasta, "yyyy-MM-dd")
        If tolerancia = "" Then
            tolerancia = 0
        End If
        consulta = "select strftime('%Y-%m-%d',  punches.punch_time) as fecha, case when
	strftime('%H:%M:%S',punches.punch_time) >= '07:00:00' and strftime('%H:%M:%S',punches.punch_time) <= '11:59:00' then strftime('%H:%M:%S',punches.punch_time) end  as Entrada_turno,
  case when
	strftime('%H:%M:%S',punches.punch_time) >= '12:00:00' and strftime('%H:%M:%S',punches.punch_time) <= '14:50:00' then strftime('%H:%M:%S',punches.punch_time) end  as Salida_Comida,
case when
	strftime('%H:%M:%S',punches.punch_time) >= '14:51:00' and strftime('%H:%M:%S',punches.punch_time) <= '17:30:00' then strftime('%H:%M:%S',punches.punch_time) end  as Entrada_comida,
case when
	strftime('%H:%M:%S',punches.punch_time) >= '18:00:00' and strftime('%H:%M:%S',punches.punch_time) <= '23:30:00' then strftime('%H:%M:%S',punches.punch_time) end  as Salida_turno	
  from
(select * from att_punches where emp_id = '" & clave_trabajador & "' and punch_time >= '" & fechainserciondesde & " 00:00:00' and punch_time <= '" & fechainsercionhasta & " 23:00:00') punches order by punch_time asc "
        ' MessageBox.Show(consulta)
        Dim tablaEsta As New DataTable
        Try
            Using conne As New SQLiteConnection(cadena)

                Dim command As New SQLiteDataAdapter(consulta, conne)

                conne.Open()

                command.Fill(tablaEsta)
                MetroGrid2.DataSource = tablaEsta

                conne.Close()
            End Using
            MetroGrid1.Rows.Clear()
            For Each row In MetroGrid2.Rows
                Dim existe As Integer = 0
                For Each row2 In MetroGrid1.Rows
                    If row.cells(0).value = row2.cells(0).value Then
                        existe = 1
                        Exit For
                    End If
                Next
                If existe Then
                Else
                    MetroGrid1.Rows.Add(row.cells(0).value)
                End If
            Next
            '  For Each row As DataGridViewRow In MetroGrid2.Rows
            'MetroGrid1.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value, row.Cells(8).Value, row.Cells(9).Value)
            'etroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            For Each row In MetroGrid1.Rows
                Dim diafecha As DateTime
                diafecha = Convert.ToDateTime(row.cells(0).value)
                Dim dia As String
                dia = diafecha.DayOfWeek.ToString

                Select Case dia
                    Case "Sunday"
                        row.cells(1).value = "Domingo"
                    Case "Monday"
                        row.cells(1).value = "Lunes"
                    Case "Tuesday"
                        row.cells(1).value = "Martes"
                    Case "Wednesday"
                        row.cells(1).value = "Miércoles"
                    Case "Thursday"
                        row.cells(1).value = "Jueves"
                    Case "Friday"
                        row.cells(1).value = "Viernes"
                    Case "Saturday"
                        row.cells(1).value = "Sábado"
                End Select
                For Each row2 In MetroGrid2.Rows
                    If row.cells(0).value = row2.cells(0).value Then
                        If Not IsDBNull(row2.cells(1).value) Then
                            row.cells(2).value = row2.cells(1).value
                        End If
                        If Not IsDBNull(row2.cells(2).value) Then
                            row.cells(4).value = row2.cells(2).value
                        End If
                        If Not IsDBNull(row2.cells(3).value) Then
                            row.cells(6).value = row2.cells(3).value
                        End If
                        If Not IsDBNull(row2.cells(4).value) Then
                            row.cells(8).value = row2.cells(4).value
                        End If
                    End If
                Next
            Next

            For Each row In MetroGrid1.Rows
                Dim entrada_turno As DateTime
                Dim salida_comida As DateTime
                Dim entrada_comida As DateTime
                Dim salida_turno As DateTime

                entrada_turno = Convert.ToDateTime(row.cells(0).value & " 09:00:00")
                salida_comida = Convert.ToDateTime(row.cells(0).value & " 14:00:00")
                entrada_comida = Convert.ToDateTime(row.cells(0).value & " 16:00:00")
                salida_turno = Convert.ToDateTime(row.cells(0).value & " 19:00:00")

                Dim entrada_turno_empleado As DateTime
                Dim salida_comida_empleado As DateTime
                Dim entrada_comida_empleado As DateTime
                Dim salida_turno_empleado As DateTime
                ' MessageBox.Show(row.cells(2).value)

                If row.cells(2).value = "" Then
                    row.cells(3).value = "Sin registro"
                Else

                    entrada_turno_empleado = Convert.ToDateTime(row.cells(0).value & " " & row.cells(2).value)
                    Dim diffentrada As String
                    diffentrada = sTiempo(entrada_turno, entrada_turno_empleado)
                    If Convert.ToInt32((DateDiff("s", entrada_turno, entrada_turno_empleado) \ 60) Mod 60) < tolerancia Then
                        row.cells(3).value = "Sin insidencia"
                    Else
                        '    MessageBox.Show(Str((DateDiff("s", entrada_turno, entrada_turno_empleado) \ 60) Mod 60))
                        Dim dtTime As DateTime = Convert.ToDateTime(row.cells(0).value & " " & diffentrada)
                        'row.cells(3).value = sTiempo(entrada_turno, entrada_turno_empleado)
                        row.cells(3).value = "Retardo por " & dtTime.ToString("HH:mm:ss")
                    End If

                End If

                If row.cells(4).value = "" Then
                    row.cells(5).value = "Sin registro"
                Else

                    salida_comida_empleado = Convert.ToDateTime(row.cells(0).value & " " & row.cells(4).value)
                    Dim diffSalidaComida As String
                    diffSalidaComida = sTiempo(salida_comida, salida_comida_empleado)
                    If Convert.ToInt32((DateDiff("s", salida_comida, salida_comida_empleado) \ 60) Mod 60) < tolerancia Then
                        row.cells(5).value = "Sin insidencia"
                    Else
                        Dim timesalidacomida As DateTime = Convert.ToDateTime(row.cells(0).value & " " & diffSalidaComida)
                        row.cells(5).value = "Retardo por " & timesalidacomida.ToString("HH:mm:ss")
                    End If
                    ' row.cells(5).value = sTiempo(salida_comida, salida_comida_empleado)

                End If

                If row.cells(6).value = "" Then
                    row.cells(7).value = "Sin registro"
                Else
                    entrada_comida_empleado = Convert.ToDateTime(row.cells(0).value & " " & row.cells(6).value)
                    Dim diffEntradaComida As String
                    diffEntradaComida = sTiempo(entrada_comida, entrada_comida_empleado)
                    If Convert.ToInt32((DateDiff("s", entrada_comida, entrada_comida_empleado) \ 60) Mod 60) < tolerancia Then
                        row.cells(7).value = "Sin insidencia"
                    Else
                        Dim timeEntradaComida As DateTime = Convert.ToDateTime(row.cells(0).value & " " & diffEntradaComida)
                        row.cells(7).value = "Retardo por " & timeEntradaComida.ToString("HH:mm:ss")
                    End If
                    ' row.cells(7).value = sTiempo(entrada_comida, entrada_comida_empleado)
                End If

                If row.cells(8).value = "" Then
                    row.cells(9).value = "Sin registro"
                Else

                    salida_turno_empleado = Convert.ToDateTime(row.cells(0).value & " " & row.cells(8).value)
                    Dim diffSalidaTurno As String
                    diffSalidaTurno = sTiempo(salida_turno, salida_turno_empleado)
                    If Convert.ToInt32((DateDiff("s", salida_turno, salida_turno_empleado) \ 60) Mod 60) < tolerancia Then
                        row.cells(9).value = "Sin insidencia"
                    Else
                        Dim timeSalidaTurno As DateTime = Convert.ToDateTime(row.cells(0).value & " " & diffSalidaTurno)
                        ' row.cells(9).value = "Salió tarde por " & timeSalidaTurno.ToString("HH:mm:ss")
                        row.cells(9).value = "Sin incidencia"
                    End If
                    ' row.cells(9).value = sTiempo(salida_turno, salida_turno_empleado)
                End If








            Next
            MetroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Function sTiempo(dInicio As Date, dFin As Date) As String

        sTiempo = Str((DateDiff("s", dInicio, dFin) \ 3600) Mod 24) & ":"
        sTiempo = sTiempo & Str((DateDiff("s", dInicio, dFin) \ 60) Mod 60) & ":"
        sTiempo = sTiempo & Str(DateDiff("s", dInicio, dFin) Mod 60) & ""
    End Function
    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        MetroGrid1.ScrollBars = ScrollBars.Both
    End Sub

    Private Sub txt_idempleado_Click(sender As Object, e As EventArgs) Handles txt_idempleado.Click

    End Sub

    Private Sub txt_idempleado_TextChanged(sender As Object, e As EventArgs) Handles txt_idempleado.TextChanged

        Dim comando As SQLite.SQLiteCommand
        conexionConsultas()
        Dim sql As String
        Dim reader As SQLite.SQLiteDataReader
        Dim nombre As String
        Dim apellido As String

        comando = New SQLite.SQLiteCommand
        comando.Connection = conexionConsulta
        sql = "select hr_employee.id as id,hr_employee.emp_firstname as firstname, hr_employee.emp_lastname as lastname, hr_department.dept_name as dept_name from hr_employee inner join hr_department on hr_employee.emp_dept = hr_department.dept_code where hr_employee.id = '" & txt_idempleado.Text & "' "

        comando.CommandText = sql
        reader = comando.ExecuteReader()
        If reader.HasRows Then
            While reader.Read

                lblnombre.Text = reader("firstname") & " " & reader("lastname")
                nombre_trabajador = reader("firstname") & " " & reader("lastname")
                departamento = reader("dept_name")
                clave_trabajador = reader("id")
                ' periodo = DateDesde.Value.ToShortDateString & "-" & DateHasta.Value.ToShortDateString
            End While
        Else
            lblnombre.Text = "No existe"
        End If

        conexionConsulta.Close()
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        nuevolibro()
        ' Try
        GridAExcel(MetroGrid1)

        ' Catch ex As Exception
        ' 'MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        cerrarlibro()
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        periodo = DateDesde.Value.ToShortDateString & "-" & DateHasta.Value.ToShortDateString
        BackgroundWorker2.RunWorkerAsync()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub
End Class