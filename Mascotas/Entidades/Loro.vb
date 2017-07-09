Public Class Loro
    Private _memoria As Queue(Of String)
    Private _edad As Short
    Private _fechanacimiento As Date
    Private _nombre As String

    Sub New()
        _nombre = ""
        _memoria = New Queue(Of String)
        _edad = 0
        _fechanacimiento = Nothing
    End Sub

    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public ReadOnly Property Edad() As Short
        Get
            Return _edad
        End Get
    End Property

    Public Property FechaNac As Date
        Get
            Return _fechanacimiento
        End Get
        Set(value As Date)
            _fechanacimiento = value
        End Set
    End Property

    Public Property Memoria() As Queue(Of String)
        Get
            Return _memoria
        End Get
        Set(value As Queue(Of String))
            _memoria = value
        End Set
    End Property

    Public Function CalcularEdad(fechanac As Date) As UShort
        Dim años As UShort
        años = Year(Now) - Year(fechanac)
        Return años
    End Function

    Public Function Escuchar(frase As String) As Boolean
        _memoria.Enqueue(frase)
        Return True
    End Function

End Class
