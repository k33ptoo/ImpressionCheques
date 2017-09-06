<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pregunta_Frm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pregunta_Frm))
        Me.txtMensaje = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnNuevo = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMensaje
        '
        Me.txtMensaje.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMensaje.BackColor = System.Drawing.Color.Silver
        Me.txtMensaje.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.txtMensaje.ForeColor = System.Drawing.Color.White
        Me.txtMensaje.Location = New System.Drawing.Point(15, 100)
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(315, 65)
        Me.txtMensaje.TabIndex = 3
        Me.txtMensaje.Text = "Linea 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Linea 2"
        Me.txtMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.BackColor = System.Drawing.Color.DarkGray
        Me.BtnCancel.FlatAppearance.BorderSize = 0
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(15, 185)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(150, 40)
        Me.BtnCancel.TabIndex = 158
        Me.BtnCancel.Text = "CANCELAR"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnOk
        '
        Me.BtnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnOk.FlatAppearance.BorderSize = 0
        Me.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOk.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.BtnOk.ForeColor = System.Drawing.Color.White
        Me.BtnOk.Location = New System.Drawing.Point(175, 185)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(150, 40)
        Me.BtnOk.TabIndex = 157
        Me.BtnOk.Text = "GUARDAR"
        Me.BtnOk.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.BtnNuevo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 170)
        Me.Panel1.TabIndex = 159
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNuevo.BackColor = System.Drawing.Color.Silver
        Me.BtnNuevo.color = System.Drawing.Color.Silver
        Me.BtnNuevo.colorActive = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNuevo.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BtnNuevo.ForeColor = System.Drawing.Color.White
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.ImagePosition = 7
        Me.BtnNuevo.ImageZoom = 60
        Me.BtnNuevo.LabelPosition = 0
        Me.BtnNuevo.LabelText = ""
        Me.BtnNuevo.Location = New System.Drawing.Point(305, 10)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(35, 35)
        Me.BtnNuevo.TabIndex = 160
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ImpresionCheques.My.Resources.Resources.Help_96px
        Me.PictureBox1.Location = New System.Drawing.Point(130, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(85, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 160
        Me.PictureBox1.TabStop = False
        '
        'pregunta_Frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(350, 245)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.txtMensaje)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "pregunta_Frm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmDialogos_Pregunta"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtMensaje As Label
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnOk As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnNuevo As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PictureBox1 As PictureBox
End Class
