Public Class AsignaturaClass

    Dim Id_ As Integer
    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property

    Dim idCarrera_ As Integer


    Public Property IdCarrera() As Integer
        Get
            Return idCarrera_
        End Get
        Set(ByVal value As Integer)
            idCarrera_ = value
        End Set
    End Property
    Dim curso_ As Integer

    Public Property Curso() As Integer
        Get
            Return curso_
        End Get
        Set(ByVal value As Integer)
            curso_ = value
        End Set
    End Property


    Dim Descripcion_ As String

    Public Property Descripcion() As String
        Get
            Return Descripcion_
        End Get
        Set(ByVal value As String)
            Descripcion_ = value
        End Set
    End Property

    Dim Modulos_ As Integer

    Public Property Modulos() As Integer
        Get
            Return Modulos_
        End Get
        Set(ByVal value As Integer)
            Modulos_ = value
        End Set
    End Property

    Public ReadOnly Property nombrescarreras() As String

        Get
            If idCarrera_ < 0 Then
                Return ""
            End If

            Return Carreras(CInt(idCarrera_))
        End Get
    End Property


    Dim Carreras() As String = _
  {"Informatica", _
  "Gestion", _
  "Turismo", _
  "Matematicas", _
  "Ingles"}
End Class
