Module modVariablesConstantes

    'CONSTANTES GENERALES
    Public Const encryptPass As String = "hfdSw$m#ww@"
    Public Const superUserPass As String = "selfdestruction"
    Public Const encryptPassReport As String = "hfdSw$m#"

    'COLORS
    Public ColorControlPrimario As New Color
    Public ColorControlSecundario As New Color
    Public ColorPanelPrimario As New Color
    Public ColorPanelSecundario As New Color

    'PATHS
    Public StartPath As String = Application.StartupPath
    Public ImagenesPath As String = StartPath & "\IMG"
    Public HTMLPath As String = StartPath & "\HTML"
    Public pathArchivoIni As String = StartPath & "\config.ini"
    Public pathArchivoUTC As String = StartPath & "\UTC.ini"
    Public pathAyuda As String = StartPath & "\AYUDA"

    'LISTAS
    Public _lista_bancos As New List(Of banco)
    Public _lista_cheques As New List(Of cheque)
    Public _lista_cuentas As New List(Of cuenta)
    Public _lista_proveedores As New List(Of proveedor)

    Public listaEquiposDeLosDesarrolladores As New List(Of String)
    Public listaConfiguracionesEnDB As New List(Of CONFIGURACION)
    Public listaConfiguracionesEnArchivoINI As New List(Of CONFIGURACION)
    Public listaConfiguraciones As New List(Of CONFIGURACION)

    'ACCESO
    Public _bancoAcceso As New bancoAcceso
    Public _chequeAcceso As New chequeAcceso
    Public _cuentaAcceso As New cuentaAcceso
    Public _proveedorAcceso As New proveedorAcceso
    Public lector_texto As New modTExtFileAccess

    'TRANSICIONES
    Public animation_vertical As New BunifuAnimatorNS.BunifuTransition
    Public animation_horizontal As New BunifuAnimatorNS.BunifuTransition

End Module

