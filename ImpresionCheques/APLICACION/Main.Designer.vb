<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.btnEditar = New Bunifu.Framework.UI.BunifuTileButton()
        Me.Panel_menu = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnMenu_Cerrar = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnMenu_Abrir = New Bunifu.Framework.UI.BunifuTileButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel_Main = New System.Windows.Forms.Panel()
        Me.Btn_Prueba_Impresion = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnSalir = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_Configuraciones = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_CuentasCorrientes = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_Bancos = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_Proveedores = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_Cheques = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel_menu.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.btnEditar.color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.btnEditar.colorActive = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImagePosition = 7
        Me.btnEditar.ImageZoom = 60
        Me.btnEditar.LabelPosition = 0
        Me.btnEditar.LabelText = ""
        Me.btnEditar.Location = New System.Drawing.Point(250, 0)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(6)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(40, 40)
        Me.btnEditar.TabIndex = 91
        '
        'Panel_menu
        '
        Me.Panel_menu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel_menu.BackColor = System.Drawing.Color.White
        Me.Panel_menu.Controls.Add(Me.BtnSalir)
        Me.Panel_menu.Controls.Add(Me.Panel2)
        Me.Panel_menu.Controls.Add(Me.Btn_Cheques)
        Me.Panel_menu.Controls.Add(Me.Btn_Prueba_Impresion)
        Me.Panel_menu.Controls.Add(Me.btnEditar)
        Me.Panel_menu.Controls.Add(Me.Btn_Proveedores)
        Me.Panel_menu.Controls.Add(Me.BunifuSeparator1)
        Me.Panel_menu.Controls.Add(Me.Btn_Configuraciones)
        Me.Panel_menu.Controls.Add(Me.Btn_CuentasCorrientes)
        Me.Panel_menu.Controls.Add(Me.Btn_Bancos)
        Me.Panel_menu.Location = New System.Drawing.Point(0, 0)
        Me.Panel_menu.Name = "Panel_menu"
        Me.Panel_menu.Size = New System.Drawing.Size(290, 506)
        Me.Panel_menu.TabIndex = 92
        Me.Panel_menu.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.BtnMenu_Cerrar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(290, 65)
        Me.Panel2.TabIndex = 93
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(65, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lattay"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ImpresionCheques.My.Resources.Resources.Print_96px
        Me.PictureBox1.Location = New System.Drawing.Point(15, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BtnMenu_Cerrar
        '
        Me.BtnMenu_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMenu_Cerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.BtnMenu_Cerrar.color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.BtnMenu_Cerrar.colorActive = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.BtnMenu_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMenu_Cerrar.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BtnMenu_Cerrar.ForeColor = System.Drawing.Color.White
        Me.BtnMenu_Cerrar.Image = CType(resources.GetObject("BtnMenu_Cerrar.Image"), System.Drawing.Image)
        Me.BtnMenu_Cerrar.ImagePosition = 20
        Me.BtnMenu_Cerrar.ImageZoom = 35
        Me.BtnMenu_Cerrar.LabelPosition = 0
        Me.BtnMenu_Cerrar.LabelText = ""
        Me.BtnMenu_Cerrar.Location = New System.Drawing.Point(225, 0)
        Me.BtnMenu_Cerrar.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnMenu_Cerrar.Name = "BtnMenu_Cerrar"
        Me.BtnMenu_Cerrar.Size = New System.Drawing.Size(65, 65)
        Me.BtnMenu_Cerrar.TabIndex = 91
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(15, 280)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(275, 35)
        Me.BunifuSeparator1.TabIndex = 0
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BtnMenu_Abrir)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(65, 65)
        Me.Panel1.TabIndex = 93
        '
        'BtnMenu_Abrir
        '
        Me.BtnMenu_Abrir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMenu_Abrir.BackColor = System.Drawing.Color.White
        Me.BtnMenu_Abrir.color = System.Drawing.Color.White
        Me.BtnMenu_Abrir.colorActive = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnMenu_Abrir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMenu_Abrir.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BtnMenu_Abrir.ForeColor = System.Drawing.Color.White
        Me.BtnMenu_Abrir.Image = CType(resources.GetObject("BtnMenu_Abrir.Image"), System.Drawing.Image)
        Me.BtnMenu_Abrir.ImagePosition = 17
        Me.BtnMenu_Abrir.ImageZoom = 50
        Me.BtnMenu_Abrir.LabelPosition = 0
        Me.BtnMenu_Abrir.LabelText = ""
        Me.BtnMenu_Abrir.Location = New System.Drawing.Point(0, 0)
        Me.BtnMenu_Abrir.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnMenu_Abrir.Name = "BtnMenu_Abrir"
        Me.BtnMenu_Abrir.Size = New System.Drawing.Size(65, 65)
        Me.BtnMenu_Abrir.TabIndex = 92
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(65, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(825, 65)
        Me.Panel3.TabIndex = 94
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(10, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(231, 30)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Impresion de Cheques"
        '
        'Panel_Main
        '
        Me.Panel_Main.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Main.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel_Main.Location = New System.Drawing.Point(0, 65)
        Me.Panel_Main.Name = "Panel_Main"
        Me.Panel_Main.Size = New System.Drawing.Size(890, 440)
        Me.Panel_Main.TabIndex = 96
        '
        'Btn_Prueba_Impresion
        '
        Me.Btn_Prueba_Impresion.Activecolor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Btn_Prueba_Impresion.BackColor = System.Drawing.Color.White
        Me.Btn_Prueba_Impresion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Prueba_Impresion.BorderRadius = 0
        Me.Btn_Prueba_Impresion.ButtonText = "Prueba de impresión"
        Me.Btn_Prueba_Impresion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Prueba_Impresion.DisabledColor = System.Drawing.Color.DimGray
        Me.Btn_Prueba_Impresion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Prueba_Impresion.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_Prueba_Impresion.Iconimage = CType(resources.GetObject("Btn_Prueba_Impresion.Iconimage"), System.Drawing.Image)
        Me.Btn_Prueba_Impresion.Iconimage_right = Nothing
        Me.Btn_Prueba_Impresion.Iconimage_right_Selected = Nothing
        Me.Btn_Prueba_Impresion.Iconimage_Selected = Nothing
        Me.Btn_Prueba_Impresion.IconMarginLeft = 18
        Me.Btn_Prueba_Impresion.IconMarginRight = 0
        Me.Btn_Prueba_Impresion.IconRightVisible = False
        Me.Btn_Prueba_Impresion.IconRightZoom = 0R
        Me.Btn_Prueba_Impresion.IconVisible = True
        Me.Btn_Prueba_Impresion.IconZoom = 70.0R
        Me.Btn_Prueba_Impresion.IsTab = False
        Me.Btn_Prueba_Impresion.Location = New System.Drawing.Point(0, 420)
        Me.Btn_Prueba_Impresion.Name = "Btn_Prueba_Impresion"
        Me.Btn_Prueba_Impresion.Normalcolor = System.Drawing.Color.White
        Me.Btn_Prueba_Impresion.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Btn_Prueba_Impresion.OnHoverTextColor = System.Drawing.Color.DimGray
        Me.Btn_Prueba_Impresion.selected = False
        Me.Btn_Prueba_Impresion.Size = New System.Drawing.Size(290, 50)
        Me.Btn_Prueba_Impresion.TabIndex = 98
        Me.Btn_Prueba_Impresion.Text = "Prueba de impresión"
        Me.Btn_Prueba_Impresion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Prueba_Impresion.Textcolor = System.Drawing.Color.DimGray
        Me.Btn_Prueba_Impresion.TextFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnSalir
        '
        Me.BtnSalir.Activecolor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BtnSalir.BackColor = System.Drawing.Color.White
        Me.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalir.BorderRadius = 0
        Me.BtnSalir.ButtonText = "Salir"
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.DisabledColor = System.Drawing.Color.DimGray
        Me.BtnSalir.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnSalir.Iconimage = CType(resources.GetObject("BtnSalir.Iconimage"), System.Drawing.Image)
        Me.BtnSalir.Iconimage_right = Nothing
        Me.BtnSalir.Iconimage_right_Selected = Nothing
        Me.BtnSalir.Iconimage_Selected = Nothing
        Me.BtnSalir.IconMarginLeft = 18
        Me.BtnSalir.IconMarginRight = 0
        Me.BtnSalir.IconRightVisible = False
        Me.BtnSalir.IconRightZoom = 0R
        Me.BtnSalir.IconVisible = True
        Me.BtnSalir.IconZoom = 70.0R
        Me.BtnSalir.IsTab = False
        Me.BtnSalir.Location = New System.Drawing.Point(0, 365)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Normalcolor = System.Drawing.Color.White
        Me.BtnSalir.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BtnSalir.OnHoverTextColor = System.Drawing.Color.DimGray
        Me.BtnSalir.selected = False
        Me.BtnSalir.Size = New System.Drawing.Size(290, 50)
        Me.BtnSalir.TabIndex = 99
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Textcolor = System.Drawing.Color.DimGray
        Me.BtnSalir.TextFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Btn_Configuraciones
        '
        Me.Btn_Configuraciones.Activecolor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Btn_Configuraciones.BackColor = System.Drawing.Color.White
        Me.Btn_Configuraciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Configuraciones.BorderRadius = 0
        Me.Btn_Configuraciones.ButtonText = "Configuraciones"
        Me.Btn_Configuraciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Configuraciones.DisabledColor = System.Drawing.Color.DimGray
        Me.Btn_Configuraciones.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Configuraciones.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_Configuraciones.Iconimage = CType(resources.GetObject("Btn_Configuraciones.Iconimage"), System.Drawing.Image)
        Me.Btn_Configuraciones.Iconimage_right = Nothing
        Me.Btn_Configuraciones.Iconimage_right_Selected = Nothing
        Me.Btn_Configuraciones.Iconimage_Selected = Nothing
        Me.Btn_Configuraciones.IconMarginLeft = 18
        Me.Btn_Configuraciones.IconMarginRight = 0
        Me.Btn_Configuraciones.IconRightVisible = False
        Me.Btn_Configuraciones.IconRightZoom = 0R
        Me.Btn_Configuraciones.IconVisible = True
        Me.Btn_Configuraciones.IconZoom = 70.0R
        Me.Btn_Configuraciones.IsTab = False
        Me.Btn_Configuraciones.Location = New System.Drawing.Point(0, 310)
        Me.Btn_Configuraciones.Name = "Btn_Configuraciones"
        Me.Btn_Configuraciones.Normalcolor = System.Drawing.Color.White
        Me.Btn_Configuraciones.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Btn_Configuraciones.OnHoverTextColor = System.Drawing.Color.DimGray
        Me.Btn_Configuraciones.selected = False
        Me.Btn_Configuraciones.Size = New System.Drawing.Size(290, 50)
        Me.Btn_Configuraciones.TabIndex = 97
        Me.Btn_Configuraciones.Text = "Configuraciones"
        Me.Btn_Configuraciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Configuraciones.Textcolor = System.Drawing.Color.DimGray
        Me.Btn_Configuraciones.TextFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Btn_CuentasCorrientes
        '
        Me.Btn_CuentasCorrientes.Activecolor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Btn_CuentasCorrientes.BackColor = System.Drawing.Color.White
        Me.Btn_CuentasCorrientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_CuentasCorrientes.BorderRadius = 0
        Me.Btn_CuentasCorrientes.ButtonText = "Cuentas Corrientes"
        Me.Btn_CuentasCorrientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_CuentasCorrientes.DisabledColor = System.Drawing.Color.DimGray
        Me.Btn_CuentasCorrientes.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_CuentasCorrientes.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_CuentasCorrientes.Iconimage = CType(resources.GetObject("Btn_CuentasCorrientes.Iconimage"), System.Drawing.Image)
        Me.Btn_CuentasCorrientes.Iconimage_right = Nothing
        Me.Btn_CuentasCorrientes.Iconimage_right_Selected = Nothing
        Me.Btn_CuentasCorrientes.Iconimage_Selected = Nothing
        Me.Btn_CuentasCorrientes.IconMarginLeft = 18
        Me.Btn_CuentasCorrientes.IconMarginRight = 0
        Me.Btn_CuentasCorrientes.IconRightVisible = False
        Me.Btn_CuentasCorrientes.IconRightZoom = 0R
        Me.Btn_CuentasCorrientes.IconVisible = True
        Me.Btn_CuentasCorrientes.IconZoom = 70.0R
        Me.Btn_CuentasCorrientes.IsTab = False
        Me.Btn_CuentasCorrientes.Location = New System.Drawing.Point(0, 235)
        Me.Btn_CuentasCorrientes.Name = "Btn_CuentasCorrientes"
        Me.Btn_CuentasCorrientes.Normalcolor = System.Drawing.Color.White
        Me.Btn_CuentasCorrientes.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Btn_CuentasCorrientes.OnHoverTextColor = System.Drawing.Color.DimGray
        Me.Btn_CuentasCorrientes.selected = False
        Me.Btn_CuentasCorrientes.Size = New System.Drawing.Size(290, 50)
        Me.Btn_CuentasCorrientes.TabIndex = 95
        Me.Btn_CuentasCorrientes.Text = "Cuentas Corrientes"
        Me.Btn_CuentasCorrientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_CuentasCorrientes.Textcolor = System.Drawing.Color.DimGray
        Me.Btn_CuentasCorrientes.TextFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Btn_Bancos
        '
        Me.Btn_Bancos.Activecolor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Btn_Bancos.BackColor = System.Drawing.Color.White
        Me.Btn_Bancos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Bancos.BorderRadius = 0
        Me.Btn_Bancos.ButtonText = "Bancos"
        Me.Btn_Bancos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Bancos.DisabledColor = System.Drawing.Color.DimGray
        Me.Btn_Bancos.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Bancos.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_Bancos.Iconimage = CType(resources.GetObject("Btn_Bancos.Iconimage"), System.Drawing.Image)
        Me.Btn_Bancos.Iconimage_right = Nothing
        Me.Btn_Bancos.Iconimage_right_Selected = Nothing
        Me.Btn_Bancos.Iconimage_Selected = Nothing
        Me.Btn_Bancos.IconMarginLeft = 18
        Me.Btn_Bancos.IconMarginRight = 0
        Me.Btn_Bancos.IconRightVisible = False
        Me.Btn_Bancos.IconRightZoom = 0R
        Me.Btn_Bancos.IconVisible = True
        Me.Btn_Bancos.IconZoom = 70.0R
        Me.Btn_Bancos.IsTab = False
        Me.Btn_Bancos.Location = New System.Drawing.Point(0, 180)
        Me.Btn_Bancos.Name = "Btn_Bancos"
        Me.Btn_Bancos.Normalcolor = System.Drawing.Color.White
        Me.Btn_Bancos.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Btn_Bancos.OnHoverTextColor = System.Drawing.Color.DimGray
        Me.Btn_Bancos.selected = False
        Me.Btn_Bancos.Size = New System.Drawing.Size(290, 50)
        Me.Btn_Bancos.TabIndex = 94
        Me.Btn_Bancos.Text = "Bancos"
        Me.Btn_Bancos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Bancos.Textcolor = System.Drawing.Color.DimGray
        Me.Btn_Bancos.TextFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Btn_Proveedores
        '
        Me.Btn_Proveedores.Activecolor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Btn_Proveedores.BackColor = System.Drawing.Color.White
        Me.Btn_Proveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Proveedores.BorderRadius = 0
        Me.Btn_Proveedores.ButtonText = "Proveedores"
        Me.Btn_Proveedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Proveedores.DisabledColor = System.Drawing.Color.DimGray
        Me.Btn_Proveedores.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Proveedores.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_Proveedores.Iconimage = CType(resources.GetObject("Btn_Proveedores.Iconimage"), System.Drawing.Image)
        Me.Btn_Proveedores.Iconimage_right = Nothing
        Me.Btn_Proveedores.Iconimage_right_Selected = Nothing
        Me.Btn_Proveedores.Iconimage_Selected = Nothing
        Me.Btn_Proveedores.IconMarginLeft = 18
        Me.Btn_Proveedores.IconMarginRight = 0
        Me.Btn_Proveedores.IconRightVisible = False
        Me.Btn_Proveedores.IconRightZoom = 0R
        Me.Btn_Proveedores.IconVisible = True
        Me.Btn_Proveedores.IconZoom = 70.0R
        Me.Btn_Proveedores.IsTab = False
        Me.Btn_Proveedores.Location = New System.Drawing.Point(0, 125)
        Me.Btn_Proveedores.Name = "Btn_Proveedores"
        Me.Btn_Proveedores.Normalcolor = System.Drawing.Color.White
        Me.Btn_Proveedores.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Btn_Proveedores.OnHoverTextColor = System.Drawing.Color.DimGray
        Me.Btn_Proveedores.selected = False
        Me.Btn_Proveedores.Size = New System.Drawing.Size(290, 50)
        Me.Btn_Proveedores.TabIndex = 1
        Me.Btn_Proveedores.Text = "Proveedores"
        Me.Btn_Proveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Proveedores.Textcolor = System.Drawing.Color.DimGray
        Me.Btn_Proveedores.TextFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Btn_Cheques
        '
        Me.Btn_Cheques.Activecolor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Btn_Cheques.BackColor = System.Drawing.Color.White
        Me.Btn_Cheques.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Cheques.BorderRadius = 0
        Me.Btn_Cheques.ButtonText = "Cheques"
        Me.Btn_Cheques.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cheques.DisabledColor = System.Drawing.Color.DimGray
        Me.Btn_Cheques.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cheques.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_Cheques.Iconimage = CType(resources.GetObject("Btn_Cheques.Iconimage"), System.Drawing.Image)
        Me.Btn_Cheques.Iconimage_right = Nothing
        Me.Btn_Cheques.Iconimage_right_Selected = Nothing
        Me.Btn_Cheques.Iconimage_Selected = Nothing
        Me.Btn_Cheques.IconMarginLeft = 18
        Me.Btn_Cheques.IconMarginRight = 0
        Me.Btn_Cheques.IconRightVisible = False
        Me.Btn_Cheques.IconRightZoom = 0R
        Me.Btn_Cheques.IconVisible = True
        Me.Btn_Cheques.IconZoom = 70.0R
        Me.Btn_Cheques.IsTab = False
        Me.Btn_Cheques.Location = New System.Drawing.Point(0, 70)
        Me.Btn_Cheques.Name = "Btn_Cheques"
        Me.Btn_Cheques.Normalcolor = System.Drawing.Color.White
        Me.Btn_Cheques.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Btn_Cheques.OnHoverTextColor = System.Drawing.Color.DimGray
        Me.Btn_Cheques.selected = False
        Me.Btn_Cheques.Size = New System.Drawing.Size(290, 50)
        Me.Btn_Cheques.TabIndex = 96
        Me.Btn_Cheques.Text = "Cheques"
        Me.Btn_Cheques.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cheques.Textcolor = System.Drawing.Color.DimGray
        Me.Btn_Cheques.TextFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(890, 505)
        Me.Controls.Add(Me.Panel_menu)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel_Main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel_menu.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEditar As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents Panel_menu As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnMenu_Cerrar As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnMenu_Abrir As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel_Main As Panel
    Friend WithEvents BtnSalir As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Btn_Cheques As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Btn_Prueba_Impresion As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Btn_Proveedores As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Btn_Configuraciones As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Btn_CuentasCorrientes As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Btn_Bancos As Bunifu.Framework.UI.BunifuFlatButton
End Class
