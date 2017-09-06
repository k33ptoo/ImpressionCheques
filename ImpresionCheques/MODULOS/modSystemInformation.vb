'-----------------------------------------------------------------------------------------
'
'           MACHINE INFORMATION MODULE
'           by Marcelo L. Ponce F.
'           version: 2017.05.31 16:00
'           note: add System.Management
'
'-----------------------------------------------------------------------------------------

Imports System.Management
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Text

Module ModSystemInformation

    Dim bits As String
    Dim vga As String
    Dim sb As New StringBuilder
    Dim objWMI As New WMIClass()
    Dim SelectWMI As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_VideoController")
    Dim mosProcessor As New ManagementObjectSearcher("Select * from Win32_Processor")
    Dim mosMother As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_BaseBoard")
    Dim mosBios As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_BIOS")

#Region "AUXILIARY FUNCTIONS"

    Public Function GetFistProcessorName() As String
        Try
            For Each mo As ManagementObject In mosProcessor.Get
                Return mo("name")
            Next
            Return ""
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GetFistProcessorSerie() As String
        Try
            For Each mo As ManagementObject In mosProcessor.Get
                Return mo("ProcessorId")
            Next
            Return ""
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function getOSBits() As String
        Try
            If (Environment.Is64BitOperatingSystem) Then
                Return "64bits"
            Else
                Return "32bits"
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Function MemoryCalc(ByVal value As Long) As String
        Try
            Dim MB, GB As Single
            MB = (value / 1024) / 1024
            GB = MB / 1024
            Return Math.Round(MB, 1) & " MB (" & Math.Round(GB, 1) & " GB)"
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function booleanToHuman(ByVal valor As String) As String
        Try
            Select Case valor
                Case "True" : Return "SI"
                Case "False" : Return "NO"
                Case Else : Return "ERROR"
            End Select
        Catch ex As Exception
            Throw
        End Try
    End Function

#End Region

    Public Function get_operative_system_information() As String
        Try
            sb.Clear()

            With objWMI
                sb.AppendLine("")
                sb.AppendLine("CARACTERISTICAS")
                sb.AppendLine("Nombre = " & My.Computer.Info.OSFullName.ToString())
                sb.AppendLine("Version = " & .OSVersion)
                sb.AppendLine("Arquitectura = " & getOSBits())
                sb.AppendLine("Plataforma = " & My.Computer.Info.OSPlatform.ToString())
                sb.AppendLine("")
                sb.AppendLine("CONFIGURACIÓN")
                sb.AppendLine("Nombre de equipo = " & My.Computer.Name.ToString())
                sb.AppendLine("Usuario actual = " & Environment.UserName.ToString.ToUpper)
                sb.AppendLine("Lenguaje de equipo = " & Globalization.CultureInfo.CurrentCulture.DisplayName)
                sb.AppendLine("Directorio de Windows = " & .WindowsDirectory)
            End With
            Return sb.ToString
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function getCurrentDriveSerialNumber() As String
        Try
            Dim DriveSerial As Integer
            'Create a FileSystemObject object
            Dim fso As Object = CreateObject("Scripting.FileSystemObject")
            Dim Drv As Object = fso.GetDrive(fso.GetDriveName(Application.StartupPath))
            With Drv
                If .IsReady Then
                    DriveSerial = .SerialNumber
                Else    '"Drive Not Ready!"
                    DriveSerial = ""
                End If
            End With
            Return DriveSerial.ToString("X2")

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function getPartitionFreeSpace() As String
        Try
            Dim cdrive As System.IO.DriveInfo
            Dim fso As Object = CreateObject("Scripting.FileSystemObject")
            cdrive = My.Computer.FileSystem.GetDriveInfo(fso.GetDriveName(Application.StartupPath) & "\")
            Return MemoryCalc(CStr(cdrive.TotalFreeSpace))
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function getPartitionTotalSize() As String
        Try
            Dim cdrive As System.IO.DriveInfo
            Dim fso As Object = CreateObject("Scripting.FileSystemObject")
            cdrive = My.Computer.FileSystem.GetDriveInfo(fso.GetDriveName(Application.StartupPath) & "\")
            Return MemoryCalc(CStr(cdrive.TotalSize))
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function getPartitionFileSystem() As String
        Try
            Dim cdrive As System.IO.DriveInfo
            Dim fso As Object = CreateObject("Scripting.FileSystemObject")
            cdrive = My.Computer.FileSystem.GetDriveInfo(fso.GetDriveName(Application.StartupPath) & "\")
            Return cdrive.DriveFormat
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function get_hardware_information() As String
        Try
            sb.Clear()

            For Each WmiResults As ManagementObject In SelectWMI.Get()
                vga = WmiResults.GetPropertyValue("Name").ToString
            Next

            With objWMI
                sb.AppendLine("")
                sb.AppendLine("EQUIPO")
                sb.AppendLine("Fabricante = " & .Manufacturer)
                sb.AppendLine("Modelo = " & .Model)
                sb.AppendLine("")
                sb.AppendLine("PROCESADOR")
                For Each mo As ManagementObject In mosProcessor.Get
                    sb.AppendLine("Modelo =  " & mo("name"))
                    sb.AppendLine("Serie =  " & mo("ProcessorId"))
                Next
                sb.AppendLine("Arquitectura = " & .SystemType)
                sb.AppendLine("")
                sb.AppendLine("PLACA MADRE")
                For Each mo As ManagementObject In mosMother.Get()
                    sb.AppendLine("Fabricante: " & mo("Manufacturer"))
                    sb.AppendLine("Modelo: " & mo("Product"))
                    sb.AppendLine("Serie: " & mo("SerialNumber"))
                Next
                sb.AppendLine("")
                sb.AppendLine("BIOS")
                For Each mo As ManagementObject In mosBios.Get()
                    sb.AppendLine("Fabricante: " & mo("Manufacturer"))
                    sb.AppendLine("Version: " & mo("SMBIOSBIOSVersion"))
                Next
                sb.AppendLine("")
                sb.AppendLine("MEMORIA")
                sb.AppendLine("Memoria física = " & MemoryCalc(My.Computer.Info.TotalPhysicalMemory.ToString()))
                sb.AppendLine("Memoria física disponible = " & MemoryCalc(My.Computer.Info.AvailablePhysicalMemory.ToString()))
                sb.AppendLine("Memoria virtual = " & MemoryCalc(My.Computer.Info.TotalVirtualMemory.ToString()))
                sb.AppendLine("Memoria virtual disponible = " & MemoryCalc(My.Computer.Info.AvailableVirtualMemory.ToString()))
                sb.AppendLine("")
                sb.AppendLine("PANTALLA")
                sb.AppendLine("Procesador = " & vga)
                sb.AppendLine("Resolución = " & Screen.PrimaryScreen.Bounds.Width & " X " & Screen.PrimaryScreen.Bounds.Height)
                sb.AppendLine("")
                sb.AppendLine("RED")
                sb.AppendLine("Conectado a una red = " & booleanToHuman(My.Computer.Network.IsAvailable.ToString()))
                sb.AppendLine("Internet (HTTP) = " & booleanToHuman(CheckForInternetConnection("http://www.google.com.ar")))
                sb.AppendLine("Internet (HTTPS)= " & booleanToHuman(CheckForInternetConnection("https://www.google.com.ar")))
                sb.AppendLine("")
                sb.AppendLine("TECLADO")
                sb.AppendLine("Scroll Lock = " & booleanToHuman(My.Computer.Keyboard.ScrollLock))
                sb.AppendLine("Num Lock = " & booleanToHuman(My.Computer.Keyboard.NumLock))
                sb.AppendLine("Caps Lock = " & booleanToHuman(My.Computer.Keyboard.CapsLock))
                sb.AppendLine("")
                sb.AppendLine("DISCO")
                sb.AppendLine("Capacidad total = " & getPartitionTotalSize())
                sb.AppendLine("Espacio libre = " & getPartitionFreeSpace())
                sb.AppendLine("Sistema de archivos = " & getPartitionFileSystem())
                sb.AppendLine("Serie = " & getCurrentDriveSerialNumber())

            End With

            Return sb.ToString

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CheckForInternetConnection(Optional ByVal url As String = "https://www.google.com") As Boolean
        Try
            Using client = New WebClient()
                Using stream = client.OpenRead(url)
                    Return True
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

    Public Function ping(ByVal url As String) As Boolean
        Try
            If My.Computer.Network.IsAvailable() Then
                Try
                    If My.Computer.Network.Ping(url, 1000) Then
                        Return True
                    Else
                        Return False
                    End If

                Catch ex As PingException
                    Return False
                End Try
            Else
                Return False
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function get_current_app_information()
        Try
            sb.Clear()

            If (IntPtr.Size = 4) Then
                bits = "32bits"
            ElseIf (IntPtr.Size = 8) Then
                bits = "64bits"
            Else
                bits = "Arquitectura Futurista!"
            End If

            sb.AppendLine("")
            sb.AppendLine("APLICACIÓN: ")
            sb.AppendLine("Nombre = " & My.Application.Info.ProductName)
            sb.AppendLine("Versión = " & My.Application.Info.Version.ToString)
            sb.AppendLine("Arquitectura = " & bits)
            sb.AppendLine("Memoria del contexto = " & MemoryCalc(My.Application.Info.WorkingSet))
            sb.AppendLine("Carpeta = " & My.Application.Info.DirectoryPath)

            Return sb.ToString

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function get_process() As String
        Try
            sb.Clear()

            sb.AppendLine("")
            sb.AppendLine("PROCESOS ACTUALES ")

            Dim query =
                From p As Process In Process.GetProcesses
                Order By p.ProcessName Ascending
                Select p.ProcessName

            sb.AppendLine("Cantidad = " & query.Count)
            sb.AppendLine("")
            sb.AppendLine("POR NOMBRES (A-Z):")
            For Each p In query
                sb.AppendLine(p)
            Next

            Return sb.ToString

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function get_installed_programs()
        Try
            sb.Clear()
            sb.AppendLine("")
            sb.AppendLine("PROGRAMAS INSTALADOS: ")

            Dim query =
                From p In get_all_installed_programs_from_registry()
                Order By p Ascending
                Select p.Trim

            sb.AppendLine("Cantidad = " & query.Count)
            sb.AppendLine("")
            sb.AppendLine("LISTADO:")
            For Each p In query
                sb.AppendLine(p)
            Next

            Return sb.ToString
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function get_all_system_Information() As String
        Try
            Dim sb1 As New StringBuilder
            sb1.Append(get_hardware_information())
            sb1.Append(get_operative_system_information())
            sb1.Append(get_current_app_information())
            sb1.Append(get_installed_programs())
            sb1.Append(get_process())
            Return sb1.ToString
        Catch ex As Exception
            Throw
        End Try
    End Function

End Module

Public Class WMIClass
    Private objOS As Management.ManagementObjectSearcher
    Private objCS As Management.ManagementObjectSearcher
    Private objMgmt As Management.ManagementObject
    Private m_strComputerName As String
    Private m_strManufacturer As String
    Private m_StrModel As String
    Private m_strOSName As String
    Private m_strOSVersion As String
    Private m_strSystemType As String
    Private m_strTPM As String
    Private m_strWindowsDir As String

    Public Sub New()
        objOS = New Management.ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem")
        objCS = New Management.ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem")
        For Each objMgmt In objOS.Get
            m_strOSName = objMgmt("name").ToString()
            m_strOSVersion = objMgmt("version").ToString()
            m_strComputerName = objMgmt("csname").ToString()
            m_strWindowsDir = objMgmt("windowsdirectory").ToString()
        Next
        For Each objMgmt In objCS.Get
            m_strManufacturer = objMgmt("manufacturer").ToString()
            m_StrModel = objMgmt("model").ToString()
            m_strSystemType = objMgmt("systemtype").ToString
            m_strTPM = objMgmt("totalphysicalmemory").ToString()
        Next
    End Sub
    Public ReadOnly Property ComputerName()
        Get
            ComputerName = m_strComputerName
        End Get
    End Property
    Public ReadOnly Property Manufacturer()
        Get
            Manufacturer = m_strManufacturer
        End Get
    End Property
    Public ReadOnly Property Model()
        Get
            Model = m_StrModel
        End Get
    End Property
    Public ReadOnly Property OsName()
        Get
            OsName = m_strOSName
        End Get
    End Property
    Public ReadOnly Property OSVersion()
        Get
            OSVersion = m_strOSVersion
        End Get
    End Property
    Public ReadOnly Property SystemType()
        Get
            SystemType = m_strSystemType
        End Get
    End Property
    Public ReadOnly Property TotalPhysicalMemory()
        Get
            TotalPhysicalMemory = m_strTPM
        End Get
    End Property
    Public ReadOnly Property WindowsDirectory()
        Get
            WindowsDirectory = m_strWindowsDir
        End Get
    End Property
End Class