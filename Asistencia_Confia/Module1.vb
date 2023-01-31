Imports System.Data.SQLite
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop
Module Module1
    Public rutabd As String
    Public conexion1 As SQLiteConnection = New SQLiteConnection
    Public conexionstring As String
    Public conexionConsulta As SQLiteConnection = New SQLiteConnection
    Public conexionStringConsulta As String
    Public rutabdConsultas As String
    Public ventanaempleado As String
    Public tolerancia As String
    Public nombre_trabajador As String
    Public departamento As String
    Public clave_trabajador As String
    Public periodo As String
    Public leyenda As String

    Dim exApp As New Microsoft.Office.Interop.Excel.Application
    Dim exLibro As Microsoft.Office.Interop.Excel.Workbook

    Public Sub conexion()

        conexionstring = "Data Source=" & rutabd & ";Version=3;MultipleActiveResultSets=True;"
        conexion1.ConnectionString = conexionstring
        conexion1.Open()

    End Sub

    Public Sub conexionConsultas()

        conexionStringConsulta = "Data Source=" & rutabdConsultas & ";Version=3;MultipleActiveResultSets=True;"
        conexionConsulta.ConnectionString = conexionStringConsulta
        conexionConsulta.Open()

    End Sub

    Function GridAExcel(ByVal ElGrid As DataGridView) As Boolean

        'Creamos las variables

        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try

            'Añadimos el Libro al programa, y la hoja al libro

            exHoja = exLibro.Worksheets.Add()
            If ElGrid.Name = "dtdatos" Then
                exHoja.Name = "Inventario"
            End If

            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = ElGrid.ColumnCount
            Dim NRow As Integer = ElGrid.RowCount

            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            exHoja.Range("A1:J1").Merge(True)
            exHoja.Range("B2:C2").Merge(True)
            exHoja.Range("D2:E2").Merge(True)
            exHoja.Range("F2:G2").Merge(True)
            exHoja.Range("B3:C3").Merge(True)
            exHoja.Range("D3:E3").Merge(True)
            exHoja.Range("F3:G3").Merge(True)
            exHoja.Range("C4:D4").Merge(True)
            exHoja.Range("E4:F4").Merge(True)
            exHoja.Range("G4:H4").Merge(True)
            exHoja.Range("I4:J4").Merge(True)
            exHoja.Cells.Item(1, 1) = "Reporte de incidencias por trabajador Préstamos Confía"
            exHoja.Cells.Item(2, 1) = "Clave"
            exHoja.Cells.Item(2, 2) = "Empleado"
            exHoja.Cells.Item(2, 4) = "Departamento"
            exHoja.Cells.Item(2, 6) = "Periodo"
            exHoja.Cells.Item(3, 1) = clave_trabajador
            exHoja.Cells.Item(3, 2) = nombre_trabajador
            exHoja.Cells.Item(3, 4) = departamento
            exHoja.Cells.Item(3, 6) = periodo
            exHoja.Cells.Item(4, 3) = "Entrada"
            exHoja.Cells.Item(4, 5) = "Salida a comer"
            exHoja.Cells.Item(4, 7) = "Entrada de comer"
            exHoja.Cells.Item(4, 9) = "Salida"
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(5, i) = ElGrid.Columns(i - 1).HeaderText.ToString
                'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
            Next

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 6, Col + 1) = ElGrid.Rows(Fila).Cells(Col).Value
                Next
            Next
            exHoja.Range("G" & NRow + 7 & ":J" & NRow + 7).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            exHoja.Range("G" & NRow + 8 & ":J" & NRow + 8).Merge(True)
            exHoja.Range("G" & NRow + 8).HorizontalAlignment = 3
            exHoja.Cells.Item(NRow + 8, 7) = nombre_trabajador

            exHoja.Range("A" & NRow + 7 & ":D" & NRow + 10).MergeCells = True
            exHoja.Cells.Item(NRow + 7, 1) = leyenda
            exHoja.Range("A" & NRow + 7).HorizontalAlignment = 3
            exHoja.Range("A" & NRow + 7).WrapText = True
            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(2).HorizontalAlignment = 3
            exHoja.Rows.Item(2).Font.Bold = 1
            exHoja.Rows.Item(3).HorizontalAlignment = 3
            exHoja.Rows.Item(4).Font.Bold = 1
            exHoja.Rows.Item(4).HorizontalAlignment = 3

            exHoja.Rows.Item(5).Font.Bold = 1
            exHoja.Rows.Item(5).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()
            exHoja.Range("A1" & ":J" & NRow + 5).Cells.Borders.LineStyle = XlLineStyle.xlContinuous
            exHoja.Columns.AutoFit()
            'Aplicación visible

            exHoja = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")

        Return False
        End Try


        Return True

    End Function
    Public Sub nuevolibro()
        exLibro = exApp.Workbooks.Add
    End Sub
    Public Sub cerrarlibro()
        Try
            Dim nombre As String
            nombre = Date.Today.ToString

            Dim sfd As New SaveFileDialog() ' this creates an instance of the SaveFileDialog called "sfd"
            sfd.Filter = "Archivo de Excel (*.xlsx)|*.xlsx|All files (*.*)|*.*"
            sfd.FilterIndex = 1
            sfd.RestoreDirectory = True
            If sfd.ShowDialog() = DialogResult.OK Then
                exApp.Application.Visible = True
                exLibro.SaveAs(sfd.FileName)
            End If

            '  exLibro.SaveAs(Environ("UserProfile") & "\desktop\" & "Inventario .xls")
            ' exLibro.SaveAs(Environ("UserProfile") & "\desktop\NombreDeTuArchivo.xls")
            ' exLibro = Nothing
            'exApp = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Module
