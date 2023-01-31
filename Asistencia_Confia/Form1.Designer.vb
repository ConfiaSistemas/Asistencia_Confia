<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtruta = New Asistencia_Confia.FlatTextBox()
        Me.FlatAlertBox1 = New Asistencia_Confia.FlatAlertBox()
        Me.FlatStickyButton1 = New Asistencia_Confia.FlatStickyButton()
        Me.FlatStickyButton2 = New Asistencia_Confia.FlatStickyButton()
        Me.FlatLabel1 = New Asistencia_Confia.FlatLabel()
        Me.FlatClose1 = New Asistencia_Confia.FlatClose()
        Me.SuspendLayout()
        '
        'txtruta
        '
        Me.txtruta.BackColor = System.Drawing.Color.Transparent
        Me.txtruta.Location = New System.Drawing.Point(123, 98)
        Me.txtruta.MaxLength = 32767
        Me.txtruta.Multiline = False
        Me.txtruta.Name = "txtruta"
        Me.txtruta.ReadOnly = False
        Me.txtruta.Size = New System.Drawing.Size(356, 29)
        Me.txtruta.TabIndex = 0
        Me.txtruta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtruta.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtruta.UseSystemPasswordChar = False
        '
        'FlatAlertBox1
        '
        Me.FlatAlertBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatAlertBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatAlertBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatAlertBox1.kind = Asistencia_Confia.FlatAlertBox._Kind.Success
        Me.FlatAlertBox1.Location = New System.Drawing.Point(32, 12)
        Me.FlatAlertBox1.Name = "FlatAlertBox1"
        Me.FlatAlertBox1.Size = New System.Drawing.Size(531, 42)
        Me.FlatAlertBox1.TabIndex = 1
        Me.FlatAlertBox1.Visible = False
        '
        'FlatStickyButton1
        '
        Me.FlatStickyButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatStickyButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatStickyButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatStickyButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatStickyButton1.Location = New System.Drawing.Point(497, 98)
        Me.FlatStickyButton1.Name = "FlatStickyButton1"
        Me.FlatStickyButton1.Rounded = False
        Me.FlatStickyButton1.Size = New System.Drawing.Size(34, 29)
        Me.FlatStickyButton1.TabIndex = 2
        Me.FlatStickyButton1.Text = "..."
        Me.FlatStickyButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatStickyButton2
        '
        Me.FlatStickyButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatStickyButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatStickyButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatStickyButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatStickyButton2.Location = New System.Drawing.Point(261, 133)
        Me.FlatStickyButton2.Name = "FlatStickyButton2"
        Me.FlatStickyButton2.Rounded = False
        Me.FlatStickyButton2.Size = New System.Drawing.Size(106, 32)
        Me.FlatStickyButton2.TabIndex = 3
        Me.FlatStickyButton2.Text = "Aceptar"
        Me.FlatStickyButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel1.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel1.Location = New System.Drawing.Point(120, 82)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(134, 13)
        Me.FlatLabel1.TabIndex = 4
        Me.FlatLabel1.Text = "Ruta de la base de datos"
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(604, 12)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 5
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 175)
        Me.Controls.Add(Me.FlatClose1)
        Me.Controls.Add(Me.FlatLabel1)
        Me.Controls.Add(Me.FlatStickyButton2)
        Me.Controls.Add(Me.FlatStickyButton1)
        Me.Controls.Add(Me.FlatAlertBox1)
        Me.Controls.Add(Me.txtruta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtruta As FlatTextBox
    Friend WithEvents FlatAlertBox1 As FlatAlertBox
    Friend WithEvents FlatStickyButton1 As FlatStickyButton
    Friend WithEvents FlatStickyButton2 As FlatStickyButton
    Friend WithEvents FlatLabel1 As FlatLabel
    Friend WithEvents FlatClose1 As FlatClose
End Class
