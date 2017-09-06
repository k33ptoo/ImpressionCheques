Imports System.Text
Imports System.Threading

Module modConfiguracion

    Dim accesoConfiguraciones As New configuracionAcceso

    Public Function Inicializar_aplicacion() As Boolean
        Try

            Cargar_equipos_desarrolladores() 'evita el envio de información sobre excepciones, trackeo del usuario y demás...

            'crear estructura de archivos del sistema
            create_Log_file()
            Create_INI_file()

            'comprobar si esta instalado el motor de access
            If thisProgramIsInstalled("Microsoft Access database engine 2010 (Spanish)") = False Then

                addEvent("No se encuentra instalado el componente Microsoft Access database engine 2010")

                mensaje_Frm.title = "Configuración inicial"
                mensaje_Frm.Height = 140
                mensaje_Frm.Width = 300
                mensaje_Frm.mensaje = "Por favor espera un momento..."
                mensaje_Frm.ShowDialog2(3)

                Dim psi As New ProcessStartInfo(StartPath & "\AccessDatabaseEngine 2010.exe", "/passive")
                Dim p As New Process
                p.StartInfo = psi
                p.Start()
                p.WaitForExit()

            End If

            'cargar configuraciones a partir del archivo hc.ini
            RecuperarTodasLasConfigDelINI()

            'comprobar PATH de la BASE
            RecuperarConfigDeLaListaEnElINI("pathBase", db_path_data_base)

            'comprobar conexion a la DB
            If startConnection() = False Then
                mensaje_Frm.ShowDialog("No se encuentra el archivo de la base de datos.")
                addEvent("No se encuentra el archivo de la base de datos.")
                Return False
            End If

            'cargar configuraciones desde la base de datos
            RecuperarTodasLasConfigDeLaDB()

            'juntar todas las configuraciones en una sola lista para unificar
            FusionarConfiguraciones()

            'comprobar configuración de copias de respaldo, a menos que en el INI diga que no controle...
            'If recuperarConfig("sinBackUp") = "True" Then
            '    GoTo todolisto
            'Else
            '    If validarConfigBK() = False Then
            '        mensaje_Frm.ancho = 500
            '        mensaje_Frm.title = "IMPORTANTE"
            '        mensaje_Frm.ShowDialog("El sistema no se encuentra correctamente " & vbCrLf &
            '                               "configurado para realizar copias de respaldo." & vbCrLf &
            '                    "Ingresá a CONFIGURACIÓN > OPCIONES > COPIAS DE RESPALDO")
            '        addEvent("El sistema no se encuentra correctamente configurado para realizar copias de respaldo.")
            '    Else
            '        'If existePathBK() = False Then
            '        '    showMessage("IMPORTANTE: el directorio de respaldo no fue encontrado." & vbCrLf & "Ingresá a CONFIGURACIÓN > OPCIONES > COPIAS DE RESPALDO", False)
            '        '    addEvent("El directorio de respaldo no fue encontrado.")
            '        'End If
            '    End If
            'End If

todolisto:

            'inicializar el tamaño de las fuentes
            'If IsNothing(recuperarConfig("tamañoFuente")) = True Then
            '    salvarConfig(New CONFIGURACION With {.nombre = "tamañoFuente", .valor = 10, .origen = "BASE"})
            '    actualizarListaConfigs()
            'End If

            'verificar que la fecha del sistema sea correcta
            'tareaSincronizarFechaHora = New Threading.Thread(AddressOf checkDateTime)
            'tareaSincronizarFechaHora.IsBackground = True
            'tareaSincronizarFechaHora.Start()

            'Dim updaterPath As String = StartPath & "\hcUpdater.exe"

            'If IO.File.Exists(updaterPath) = True Then
            '    Process.Start(updaterPath)
            'End If

            Configurar_animaciones()
            Cargar_listas_parametricas()

            Return True

        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Sub Configurar_animaciones()
        Try
            animation_vertical.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
            animation_horizontal.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub Cargar_listas_parametricas()
        Try
            _lista_bancos = _bancoAcceso.recuperar
        Catch ex As Exception
            Throw
        End Try
    End Sub

#Region "CREAR ESTRUCTURA DE ARCHIVOS"

    Sub Create_IMG_directory()
        Try
            If IO.Directory.Exists(ImagenesPath) = False Then
                IO.Directory.CreateDirectory(ImagenesPath)
                addEvent("Se creo la carpeta \IMG")
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub Create_HTML_directory()
        Try
            If IO.Directory.Exists(HTMLPath) = False Then
                IO.Directory.CreateDirectory(HTMLPath)
                addEvent("Se creo la carpeta \HTML")
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub Create_INI_file()
        Try
            If IO.File.Exists(pathArchivoIni) = False Then
                Dim iniVirgen As New StringBuilder
                iniVirgen.AppendLine("'ARCHIVO DE CONFIGURACIONES")
                iniVirgen.AppendLine("'Versión 1.0")
                iniVirgen.AppendLine("'---")
                iniVirgen.AppendLine("'ATENCIÓN: NO MODIFIQUE ESTE ARCHIVO SI NO ESTA COMPLETAMENTE SEGURO DE LO QUE ESTA HACIENDO.")
                iniVirgen.AppendLine("'----")
                iniVirgen.AppendLine("pathBase=""""")
                lector_texto.append(pathArchivoIni, iniVirgen.ToString)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub Create_UTC_file()
        Try
            Dim lineas As New StringBuilder
            lineas.AppendLine("'NIST Internet Time Servers (26/05/2016)")
            lineas.AppendLine("129.6.15.28")
            lineas.AppendLine("129.6.15.29")
            lineas.AppendLine("129.6.15.30")
            lineas.AppendLine("98.175.203.200")
            lineas.AppendLine("66.199.22.67")
            lineas.AppendLine("64.113.32.5")
            lineas.AppendLine("198.111.152.100")
            lineas.AppendLine("216.229.0.179")
            lineas.AppendLine("24.56.178.140")
            lineas.AppendLine("132.163.4.101")
            lineas.AppendLine("132.163.4.102")
            lineas.AppendLine("132.163.4.103")
            lineas.AppendLine("128.138.140.44")
            lineas.AppendLine("128.138.141.172")
            lineas.AppendLine("198.60.73.8")
            lineas.AppendLine("131.107.13.100")
            lineas.AppendLine("216.228.192.69")
            lector_texto.append(pathArchivoUTC, lineas.ToString)
        Catch ex As Exception
            Throw
        End Try
    End Sub

#End Region

    Sub FusionarConfiguraciones()
        Try
            Dim unionConfigs = (From a In listaConfiguracionesEnArchivoINI Select a).Union(From b In listaConfiguracionesEnDB Select b).ToList
            Dim unionFinal = From config In unionConfigs Where config.valor <> "" Distinct Select config
            listaConfiguraciones = unionFinal.ToList
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub ActualizarListaConfigs()
        Try
            RecuperarTodasLasConfigDeLaDB()
            RecuperarTodasLasConfigDelINI()
            FusionarConfiguraciones()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Function Leer_archivoINI() As String()
        Try
            If lector_texto.existFile(pathArchivoIni) = True Then
                Dim texto As String = lector_texto.readFile(pathArchivoIni)
                If texto = "" Then
                    Create_INI_file()
                End If
                Return texto.Split(vbCrLf)
            Else
                Create_INI_file()
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Sub RecuperarTodasLasConfigDelINI()
        Try
            Dim lineas() As String = Leer_archivoINI()
            For Each linea As String In lineas
                If linea.Trim.StartsWith("'") = False Then ' si no es una linea comentada
                    Dim campos() As String = linea.Trim.Split("=")
                    If campos.Length = 2 Then
                        listaConfiguracionesEnArchivoINI.Add(New CONFIGURACION With {.valor = campos(1).Replace("""", ""), .nombre = campos(0), .origen = "INI"})
                    End If
                End If
            Next
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub Cargar_equipos_desarrolladores()
        Try
            Dim valores() As String = Nothing
            If IO.File.Exists(StartPath & "\equiposDesarrolladores.txt") Then
                For Each linea As String In IO.File.ReadAllLines(StartPath & "\equiposDesarrolladores.txt")
                    listaEquiposDeLosDesarrolladores.Add(linea.ToUpper)
                Next
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub RecuperarTodasLasConfigDeLaDB()
        Try
            listaConfiguracionesEnDB = accesoConfiguraciones.recuperar
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub ActualizarConfigEnINI(ByVal config As CONFIGURACION)
        Try
            Dim lineas() As String = Leer_archivoINI()
            Dim lineasActualizadas As New StringBuilder
            For Each linea As String In lineas
                If linea.Trim.StartsWith("'") = False Then ' si no es una linea comentada
                    Dim campos() As String = linea.Trim.Split("=")
                    If campos.Length = 2 Then
                        If campos(0) = config.nombre Then
                            lineasActualizadas.AppendLine(campos(0) & "=""" & config.valor & """")
                        Else
                            lineasActualizadas.AppendLine(linea.Trim)
                        End If
                    End If
                Else
                    lineasActualizadas.AppendLine(linea.Trim)
                End If
            Next
            lector_texto.writeTextFile(pathArchivoIni, lineasActualizadas.ToString)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub InsertarConfigEnINI(ByVal config As CONFIGURACION)
        Try
            Dim lineas() As String = Leer_archivoINI()
            Dim lineasActualizadas As New StringBuilder
            For Each linea As String In lineas
                If linea.Trim.StartsWith("'") = False Then ' si no es una linea comentada
                    Dim campos() As String = linea.Trim.Split("=")
                    If campos.Length = 2 Then
                        lineasActualizadas.AppendLine(linea.Trim)
                    End If
                Else
                    lineasActualizadas.AppendLine(linea.Trim)
                End If
            Next
            lineasActualizadas.AppendLine(config.nombre & "=""" & config.valor & """")
            lector_texto.writeTextFile(pathArchivoIni, lineasActualizadas.ToString)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub SalvarConfig(ByVal config As CONFIGURACION)
        Try
            Select Case config.origen

                Case "BASE"
                    If IsNothing(listaConfiguracionesEnDB.FirstOrDefault(Function(c) c.nombre.ToLower = config.nombre.ToLower)) = True Then
                        accesoConfiguraciones.insertar(New CONFIGURACION With {.nombre = config.nombre.ToLower, .valor = config.valor})
                    Else
                        accesoConfiguraciones.actualizar(New CONFIGURACION With {.nombre = config.nombre.ToLower, .valor = config.valor})
                    End If

                Case "INI"
                    If IsNothing(listaConfiguracionesEnArchivoINI.FirstOrDefault(Function(c) c.nombre.ToLower = config.nombre.ToLower)) = True Then
                        InsertarConfigEnINI(New CONFIGURACION With {.nombre = config.nombre.ToLower, .valor = config.valor})
                    Else
                        ActualizarConfigEnINI(New CONFIGURACION With {.nombre = config.nombre.ToLower, .valor = config.valor})
                    End If

            End Select

            ActualizarListaConfigs()

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function RecuperarConfigDeLaListaEnLaDB(ByVal nombreConfiguracion As String, ByRef propiedadDestino As Object) As String
        Try
            Dim configuracionActual As CONFIGURACION

            configuracionActual = listaConfiguracionesEnDB.FirstOrDefault(Function(c) c.nombre.ToLower = nombreConfiguracion.ToLower)
            If IsNothing(configuracionActual) = False Then
                propiedadDestino = configuracionActual.valor
                Return configuracionActual.valor
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function RecuperarConfigDeLaListaEnElINI(ByVal nombreConfiguracion As String, ByRef propiedadDestino As Object) As String
        Try
            Dim configuracionActual As CONFIGURACION

            configuracionActual = listaConfiguracionesEnArchivoINI.FirstOrDefault(Function(c) c.nombre.ToLower = nombreConfiguracion.ToLower)
            If IsNothing(configuracionActual) = False Then
                propiedadDestino = configuracionActual.valor
                Return configuracionActual.valor
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function RecuperarConfig(ByVal nombreConfiguracion As String) As Object
        Try
            Dim configuracionActual As CONFIGURACION
            configuracionActual = listaConfiguraciones.FirstOrDefault(Function(c) c.nombre.ToLower = nombreConfiguracion.ToLower)
            If IsNothing(configuracionActual) = False Then
                Return configuracionActual.valor
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

End Module
