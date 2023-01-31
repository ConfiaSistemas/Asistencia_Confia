<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Days = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hora_entrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Incidencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hora_sal_comida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Incidencia_sal_comida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hora_entrada_comer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.incidencia_entrada_comer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hora_Salida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Incidencia_salida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDesde = New MetroFramework.Controls.MetroDateTime()
        Me.DateHasta = New MetroFramework.Controls.MetroDateTime()
        Me.txt_idempleado = New MetroFramework.Controls.MetroTextBox()
        Me.FlatLabel1 = New Asistencia_Confia.FlatLabel()
        Me.btn_consultar = New Asistencia_Confia.FlatButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.MetroGrid2 = New MetroFramework.Controls.MetroGrid()
        Me.lblnombre = New Asistencia_Confia.FlatLabel()
        Me.FlatLabel2 = New Asistencia_Confia.FlatLabel()
        Me.FlatLabel3 = New Asistencia_Confia.FlatLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlatMini1 = New Asistencia_Confia.FlatMini()
        Me.FlatClose1 = New Asistencia_Confia.FlatClose()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FlatButton1 = New Asistencia_Confia.FlatButton()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetroGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 23
        Me.MetroComboBox1.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.MetroComboBox1.Location = New System.Drawing.Point(1027, 90)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(121, 29)
        Me.MetroComboBox1.TabIndex = 8
        Me.MetroComboBox1.UseSelectable = True
        Me.MetroComboBox1.Visible = False
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToAddRows = False
        Me.MetroGrid1.AllowUserToResizeRows = False
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha, Me.Days, Me.Hora_entrada, Me.Incidencia, Me.Hora_sal_comida, Me.Incidencia_sal_comida, Me.Hora_entrada_comer, Me.incidencia_entrada_comer, Me.Hora_Salida, Me.Incidencia_salida})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle8
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(12, 256)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.MetroGrid1.RowHeadersVisible = False
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(1556, 402)
        Me.MetroGrid1.TabIndex = 9
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        '
        'Days
        '
        Me.Days.HeaderText = "Días"
        Me.Days.Name = "Days"
        '
        'Hora_entrada
        '
        Me.Hora_entrada.HeaderText = "Registro"
        Me.Hora_entrada.Name = "Hora_entrada"
        '
        'Incidencia
        '
        Me.Incidencia.HeaderText = "Incidencia"
        Me.Incidencia.Name = "Incidencia"
        '
        'Hora_sal_comida
        '
        Me.Hora_sal_comida.HeaderText = "Registro"
        Me.Hora_sal_comida.Name = "Hora_sal_comida"
        '
        'Incidencia_sal_comida
        '
        Me.Incidencia_sal_comida.HeaderText = "Incidencia"
        Me.Incidencia_sal_comida.Name = "Incidencia_sal_comida"
        '
        'Hora_entrada_comer
        '
        Me.Hora_entrada_comer.HeaderText = "Registro"
        Me.Hora_entrada_comer.Name = "Hora_entrada_comer"
        '
        'incidencia_entrada_comer
        '
        Me.incidencia_entrada_comer.HeaderText = "Incidencia"
        Me.incidencia_entrada_comer.Name = "incidencia_entrada_comer"
        '
        'Hora_Salida
        '
        Me.Hora_Salida.HeaderText = "Registro"
        Me.Hora_Salida.Name = "Hora_Salida"
        '
        'Incidencia_salida
        '
        Me.Incidencia_salida.HeaderText = "Incidencia"
        Me.Incidencia_salida.Name = "Incidencia_salida"
        '
        'DateDesde
        '
        Me.DateDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDesde.Location = New System.Drawing.Point(183, 211)
        Me.DateDesde.MinimumSize = New System.Drawing.Size(0, 29)
        Me.DateDesde.Name = "DateDesde"
        Me.DateDesde.Size = New System.Drawing.Size(200, 29)
        Me.DateDesde.TabIndex = 10
        '
        'DateHasta
        '
        Me.DateHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateHasta.Location = New System.Drawing.Point(418, 211)
        Me.DateHasta.MinimumSize = New System.Drawing.Size(0, 29)
        Me.DateHasta.Name = "DateHasta"
        Me.DateHasta.Size = New System.Drawing.Size(200, 29)
        Me.DateHasta.TabIndex = 11
        Me.DateHasta.UseStyleColors = True
        '
        'txt_idempleado
        '
        '
        '
        '
        Me.txt_idempleado.CustomButton.Image = Nothing
        Me.txt_idempleado.CustomButton.Location = New System.Drawing.Point(367, 1)
        Me.txt_idempleado.CustomButton.Name = ""
        Me.txt_idempleado.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_idempleado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_idempleado.CustomButton.TabIndex = 1
        Me.txt_idempleado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_idempleado.CustomButton.UseSelectable = True
        Me.txt_idempleado.CustomButton.Visible = False
        Me.txt_idempleado.Lines = New String(-1) {}
        Me.txt_idempleado.Location = New System.Drawing.Point(183, 153)
        Me.txt_idempleado.MaxLength = 32767
        Me.txt_idempleado.Name = "txt_idempleado"
        Me.txt_idempleado.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_idempleado.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_idempleado.SelectedText = ""
        Me.txt_idempleado.SelectionLength = 0
        Me.txt_idempleado.SelectionStart = 0
        Me.txt_idempleado.ShortcutsEnabled = True
        Me.txt_idempleado.Size = New System.Drawing.Size(389, 23)
        Me.txt_idempleado.TabIndex = 12
        Me.txt_idempleado.UseSelectable = True
        Me.txt_idempleado.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_idempleado.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel1.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel1.Location = New System.Drawing.Point(180, 135)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(90, 13)
        Me.FlatLabel1.TabIndex = 13
        Me.FlatLabel1.Text = "Id del empleado"
        '
        'btn_consultar
        '
        Me.btn_consultar.BackColor = System.Drawing.Color.Transparent
        Me.btn_consultar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btn_consultar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_consultar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btn_consultar.Location = New System.Drawing.Point(591, 153)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Rounded = False
        Me.btn_consultar.Size = New System.Drawing.Size(106, 23)
        Me.btn_consultar.TabIndex = 14
        Me.btn_consultar.Text = "Consultar"
        Me.btn_consultar.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'BackgroundWorker1
        '
        '
        'MetroGrid2
        '
        Me.MetroGrid2.AllowUserToAddRows = False
        Me.MetroGrid2.AllowUserToResizeRows = False
        Me.MetroGrid2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.MetroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid2.DefaultCellStyle = DataGridViewCellStyle11
        Me.MetroGrid2.EnableHeadersVisualStyles = False
        Me.MetroGrid2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid2.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid2.Location = New System.Drawing.Point(759, 90)
        Me.MetroGrid2.Name = "MetroGrid2"
        Me.MetroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid2.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.MetroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid2.Size = New System.Drawing.Size(597, 150)
        Me.MetroGrid2.TabIndex = 15
        Me.MetroGrid2.Visible = False
        '
        'lblnombre
        '
        Me.lblnombre.BackColor = System.Drawing.Color.Transparent
        Me.lblnombre.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.ForeColor = System.Drawing.Color.DimGray
        Me.lblnombre.Location = New System.Drawing.Point(118, 52)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(823, 67)
        Me.lblnombre.TabIndex = 16
        Me.lblnombre.Text = "."
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel2.ForeColor = System.Drawing.Color.DimGray
        Me.FlatLabel2.Location = New System.Drawing.Point(180, 195)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(39, 13)
        Me.FlatLabel2.TabIndex = 17
        Me.FlatLabel2.Text = "Desde"
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel3.ForeColor = System.Drawing.Color.DimGray
        Me.FlatLabel3.Location = New System.Drawing.Point(415, 195)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(36, 13)
        Me.FlatLabel3.TabIndex = 18
        Me.FlatLabel3.Text = "Hasta"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Panel1.Controls.Add(Me.FlatMini1)
        Me.Panel1.Controls.Add(Me.FlatClose1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1570, 34)
        Me.Panel1.TabIndex = 19
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(1525, 3)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 16
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(1549, 3)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 15
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(8, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Consulta"
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(883, 217)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(106, 23)
        Me.FlatButton1.TabIndex = 20
        Me.FlatButton1.Text = "Exportar"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'BackgroundWorker2
        '
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1580, 663)
        Me.Controls.Add(Me.FlatButton1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FlatLabel3)
        Me.Controls.Add(Me.FlatLabel2)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.MetroGrid2)
        Me.Controls.Add(Me.btn_consultar)
        Me.Controls.Add(Me.FlatLabel1)
        Me.Controls.Add(Me.txt_idempleado)
        Me.Controls.Add(Me.DateHasta)
        Me.Controls.Add(Me.DateDesde)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Controls.Add(Me.MetroComboBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Principal"
        Me.Text = "Principal"
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetroGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents DateDesde As MetroFramework.Controls.MetroDateTime
    Friend WithEvents DateHasta As MetroFramework.Controls.MetroDateTime
    Friend WithEvents txt_idempleado As MetroFramework.Controls.MetroTextBox
    Friend WithEvents FlatLabel1 As FlatLabel
    Friend WithEvents btn_consultar As FlatButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents MetroGrid2 As MetroFramework.Controls.MetroGrid
    Friend WithEvents lblnombre As FlatLabel
    Friend WithEvents FlatLabel2 As FlatLabel
    Friend WithEvents FlatLabel3 As FlatLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlatClose1 As FlatClose
    Friend WithEvents Label3 As Label
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents FlatMini1 As FlatMini
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Days As DataGridViewTextBoxColumn
    Friend WithEvents Hora_entrada As DataGridViewTextBoxColumn
    Friend WithEvents Incidencia As DataGridViewTextBoxColumn
    Friend WithEvents Hora_sal_comida As DataGridViewTextBoxColumn
    Friend WithEvents Incidencia_sal_comida As DataGridViewTextBoxColumn
    Friend WithEvents Hora_entrada_comer As DataGridViewTextBoxColumn
    Friend WithEvents incidencia_entrada_comer As DataGridViewTextBoxColumn
    Friend WithEvents Hora_Salida As DataGridViewTextBoxColumn
    Friend WithEvents Incidencia_salida As DataGridViewTextBoxColumn
End Class
