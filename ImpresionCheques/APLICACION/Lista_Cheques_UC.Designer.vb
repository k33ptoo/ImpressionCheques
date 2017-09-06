<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Lista_Cheques_UC
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lista_Cheques_UC))
        Dim Cheque1 As ImpresionCheques.cheque = New ImpresionCheques.cheque()
        Me.Dgv_Entidades = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton7 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton6 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnNuevo = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BtnEditar = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BtnEliminar = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BtnActualizar = New Bunifu.Framework.UI.BunifuTileButton()
        Me._Cheque_detalle = New ImpresionCheques.Cheque_detalle()
        CType(Me.Dgv_Entidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dgv_Entidades
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Dgv_Entidades.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_Entidades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv_Entidades.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.Dgv_Entidades.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgv_Entidades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_Entidades.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv_Entidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Entidades.DoubleBuffered = True
        Me.Dgv_Entidades.EnableHeadersVisualStyles = False
        Me.Dgv_Entidades.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Dgv_Entidades.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Dgv_Entidades.Location = New System.Drawing.Point(10, 150)
        Me.Dgv_Entidades.Name = "Dgv_Entidades"
        Me.Dgv_Entidades.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Dgv_Entidades.Size = New System.Drawing.Size(850, 380)
        Me.Dgv_Entidades.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Panel4.Controls.Add(Me.BunifuFlatButton7)
        Me.Panel4.Controls.Add(Me.BunifuFlatButton6)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(870, 80)
        Me.Panel4.TabIndex = 124
        '
        'BunifuFlatButton7
        '
        Me.BunifuFlatButton7.Activecolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuFlatButton7.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.BunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton7.BorderRadius = 0
        Me.BunifuFlatButton7.ButtonText = "Imprimir"
        Me.BunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton7.DisabledColor = System.Drawing.Color.DimGray
        Me.BunifuFlatButton7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton7.Iconimage = CType(resources.GetObject("BunifuFlatButton7.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton7.Iconimage_right = Nothing
        Me.BunifuFlatButton7.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton7.Iconimage_Selected = Nothing
        Me.BunifuFlatButton7.IconMarginLeft = 10
        Me.BunifuFlatButton7.IconMarginRight = 0
        Me.BunifuFlatButton7.IconRightVisible = True
        Me.BunifuFlatButton7.IconRightZoom = 0R
        Me.BunifuFlatButton7.IconVisible = True
        Me.BunifuFlatButton7.IconZoom = 70.0R
        Me.BunifuFlatButton7.IsTab = False
        Me.BunifuFlatButton7.Location = New System.Drawing.Point(610, 15)
        Me.BunifuFlatButton7.Name = "BunifuFlatButton7"
        Me.BunifuFlatButton7.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.BunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton7.selected = False
        Me.BunifuFlatButton7.Size = New System.Drawing.Size(125, 50)
        Me.BunifuFlatButton7.TabIndex = 101
        Me.BunifuFlatButton7.Text = "Imprimir"
        Me.BunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton7.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton7.TextFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton6
        '
        Me.BunifuFlatButton6.Activecolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuFlatButton6.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.BunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton6.BorderRadius = 0
        Me.BunifuFlatButton6.ButtonText = "Filtros"
        Me.BunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton6.DisabledColor = System.Drawing.Color.DimGray
        Me.BunifuFlatButton6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton6.Iconimage = CType(resources.GetObject("BunifuFlatButton6.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton6.Iconimage_right = Nothing
        Me.BunifuFlatButton6.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton6.Iconimage_Selected = Nothing
        Me.BunifuFlatButton6.IconMarginLeft = 10
        Me.BunifuFlatButton6.IconMarginRight = 0
        Me.BunifuFlatButton6.IconRightVisible = True
        Me.BunifuFlatButton6.IconRightZoom = 0R
        Me.BunifuFlatButton6.IconVisible = True
        Me.BunifuFlatButton6.IconZoom = 70.0R
        Me.BunifuFlatButton6.IsTab = False
        Me.BunifuFlatButton6.Location = New System.Drawing.Point(745, 15)
        Me.BunifuFlatButton6.Name = "BunifuFlatButton6"
        Me.BunifuFlatButton6.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.BunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton6.selected = False
        Me.BunifuFlatButton6.Size = New System.Drawing.Size(110, 50)
        Me.BunifuFlatButton6.TabIndex = 100
        Me.BunifuFlatButton6.Text = "Filtros"
        Me.BunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton6.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton6.TextFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(35, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Lista de cheques"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 85)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(870, 55)
        Me.TableLayoutPanel1.TabIndex = 125
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnNuevo)
        Me.Panel1.Controls.Add(Me.BtnEditar)
        Me.Panel1.Controls.Add(Me.BtnEliminar)
        Me.Panel1.Controls.Add(Me.BtnActualizar)
        Me.Panel1.Location = New System.Drawing.Point(317, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(235, 49)
        Me.Panel1.TabIndex = 126
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnNuevo.color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnNuevo.colorActive = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNuevo.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BtnNuevo.ForeColor = System.Drawing.Color.White
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.ImagePosition = 7
        Me.BtnNuevo.ImageZoom = 60
        Me.BtnNuevo.LabelPosition = 0
        Me.BtnNuevo.LabelText = ""
        Me.BtnNuevo.Location = New System.Drawing.Point(0, 0)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(55, 50)
        Me.BtnNuevo.TabIndex = 120
        '
        'BtnEditar
        '
        Me.BtnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnEditar.color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnEditar.colorActive = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditar.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BtnEditar.ForeColor = System.Drawing.Color.White
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.ImagePosition = 7
        Me.BtnEditar.ImageZoom = 60
        Me.BtnEditar.LabelPosition = 0
        Me.BtnEditar.LabelText = ""
        Me.BtnEditar.Location = New System.Drawing.Point(60, 0)
        Me.BtnEditar.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(55, 50)
        Me.BtnEditar.TabIndex = 121
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnEliminar.color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnEliminar.colorActive = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminar.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.ImagePosition = 7
        Me.BtnEliminar.ImageZoom = 60
        Me.BtnEliminar.LabelPosition = 0
        Me.BtnEliminar.LabelText = ""
        Me.BtnEliminar.Location = New System.Drawing.Point(120, 0)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(55, 50)
        Me.BtnEliminar.TabIndex = 122
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnActualizar.color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnActualizar.colorActive = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnActualizar.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BtnActualizar.ForeColor = System.Drawing.Color.White
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.ImagePosition = 7
        Me.BtnActualizar.ImageZoom = 60
        Me.BtnActualizar.LabelPosition = 0
        Me.BtnActualizar.LabelText = ""
        Me.BtnActualizar.Location = New System.Drawing.Point(180, 0)
        Me.BtnActualizar.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(55, 50)
        Me.BtnActualizar.TabIndex = 123
        '
        '_Cheque_detalle
        '
        Cheque1.Cruzado = False
        Cheque1.Fecha_Emision = New Date(CType(0, Long))
        Cheque1.Fecha_Vencimiento = New Date(CType(0, Long))
        Cheque1.Id_cheque = 0
        Cheque1.Id_cuenta = 0
        Cheque1.Id_proveedor = 0
        Cheque1.Importe = 0!
        Cheque1.No_a_la_orden = False
        Cheque1.Numero = Nothing
        Me._Cheque_detalle.Actual = Cheque1
        Me._Cheque_detalle.BackColor = System.Drawing.Color.White
        Me._Cheque_detalle.Location = New System.Drawing.Point(80, 140)
        Me._Cheque_detalle.Name = "_Cheque_detalle"
        Me._Cheque_detalle.Size = New System.Drawing.Size(710, 325)
        Me._Cheque_detalle.TabIndex = 126
        Me._Cheque_detalle.Visible = False
        '
        'Lista_Cheques_UC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me._Cheque_detalle)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Dgv_Entidades)
        Me.Name = "Lista_Cheques_UC"
        Me.Size = New System.Drawing.Size(870, 540)
        CType(Me.Dgv_Entidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Dgv_Entidades As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BtnActualizar As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BtnEliminar As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BtnEditar As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BtnNuevo As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BunifuFlatButton7 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton6 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents _Cheque_detalle As Cheque_detalle
End Class
