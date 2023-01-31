<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.MetroButton1)
        Me.FlowLayoutPanel1.Controls.Add(Me.MetroButton2)
        Me.FlowLayoutPanel1.Controls.Add(Me.MetroButton3)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(9, 61)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(794, 139)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'MetroButton1
        '
        Me.MetroButton1.BackColor = System.Drawing.Color.White
        Me.MetroButton1.BackgroundImage = Global.Asistencia_Confia.My.Resources.Resources.consultar_png_5_280x200
        Me.MetroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MetroButton1.Location = New System.Drawing.Point(3, 3)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(180, 125)
        Me.MetroButton1.TabIndex = 1
        Me.MetroButton1.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.BackColor = System.Drawing.Color.White
        Me.MetroButton2.BackgroundImage = Global.Asistencia_Confia.My.Resources.Resources._52672
        Me.MetroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MetroButton2.Location = New System.Drawing.Point(189, 3)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(161, 125)
        Me.MetroButton2.TabIndex = 2
        Me.MetroButton2.UseSelectable = True
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(356, 3)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(166, 125)
        Me.MetroButton3.TabIndex = 3
        Me.MetroButton3.UseSelectable = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 323)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
End Class
