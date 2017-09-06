<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Banco_detalle
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.components = New System.ComponentModel.Container()
        Me.Txt_Nombre = New System.Windows.Forms.TextBox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Txt_Nombre
        '
        Me.Txt_Nombre.BackColor = System.Drawing.Color.White
        Me.Txt_Nombre.Font = New System.Drawing.Font("Century Gothic", 16.5!)
        Me.Txt_Nombre.ForeColor = System.Drawing.Color.Black
        Me.Txt_Nombre.Location = New System.Drawing.Point(35, 70)
        Me.Txt_Nombre.MaxLength = 255
        Me.Txt_Nombre.Name = "Txt_Nombre"
        Me.Txt_Nombre.Size = New System.Drawing.Size(350, 34)
        Me.Txt_Nombre.TabIndex = 14
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 15
        Me.BunifuElipse1.TargetControl = Me
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.BackColor = System.Drawing.Color.DarkGray
        Me.Btn_Cancelar.FlatAppearance.BorderSize = 0
        Me.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Btn_Cancelar.ForeColor = System.Drawing.Color.White
        Me.Btn_Cancelar.Location = New System.Drawing.Point(80, 150)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(150, 40)
        Me.Btn_Cancelar.TabIndex = 156
        Me.Btn_Cancelar.Text = "CANCELAR"
        Me.Btn_Cancelar.UseVisualStyleBackColor = False
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Btn_Guardar.FlatAppearance.BorderSize = 0
        Me.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Guardar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Btn_Guardar.ForeColor = System.Drawing.Color.White
        Me.Btn_Guardar.Location = New System.Drawing.Point(235, 150)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(150, 40)
        Me.Btn_Guardar.TabIndex = 155
        Me.Btn_Guardar.Text = "GUARDAR"
        Me.Btn_Guardar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(35, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 21)
        Me.Label1.TabIndex = 157
        Me.Label1.Text = "Nombre"
        '
        'Banco_detalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Me.Txt_Nombre)
        Me.Name = "Banco_detalle"
        Me.Size = New System.Drawing.Size(420, 220)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_Nombre As TextBox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents Label1 As Label
End Class
