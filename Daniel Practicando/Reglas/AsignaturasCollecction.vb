Imports System.ComponentModel
Imports System.Text

Public Class AsignaturasCollecction
    Inherits BindingList(Of AsignaturaClass)

    Protected Overrides Sub OnAddingNew(ByVal e As System.ComponentModel.AddingNewEventArgs)
        MyBase.OnAddingNew(e)

        e.NewObject = New AsignaturaClass

    End Sub

    Protected Overrides ReadOnly Property SupportsSearchingCore() As Boolean
        Get
            Return True
        End Get
    End Property

    Protected Overrides Function FindCore(ByVal prop As PropertyDescriptor, ByVal key As Object) As Integer
        For Each Asignatura In Me
            If prop.GetValue(Asignatura).Equals(key) Then
                Return Me.IndexOf(Asignatura)
            End If
        Next

        Return -1
    End Function

    Public Sub New()
        Me.TraerAsignaturas()
    End Sub

    Public Function TraerAsignaturas() As AsignaturasCollecction

        Dim objBaseDatos As New BaseDatosClass
        Dim MiDataTable As New DataTable
        Dim MiAsignatura As AsignaturaClass


        objBaseDatos.objTabla = "Asignaturas"
        MiDataTable = objBaseDatos.Consultar

        For Each dr As DataRow In MiDataTable.Rows
            MiAsignatura = New AsignaturaClass


            MiAsignatura.Id = (dr("Id"))
            MiAsignatura.IdCarrera = (dr("IdCarrera"))
            MiAsignatura.Curso = (dr("Curso"))
            MiAsignatura.Descripcion = (dr("Descripcion"))
            MiAsignatura.Modulos = (dr("Modulos"))
            

            Me.Add(MiAsignatura)
        Next

        Return Me

    End Function

    Public Sub InsertarAsignaturas(ByVal MiAsignatura As AsignaturaClass)


        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Asignaturas"

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("(IdCarrera")
        vSQL.Append(",Curso")
        vSQL.Append(",Descripcion")
        vSQL.Append(",Modulos)")
        vSQL.Append(" VALUES ")
        vSQL.Append("('" & MiAsignatura.IdCarrera & "'")
        vSQL.Append(",'" & MiAsignatura.Curso & "'")
        vSQL.Append(",'" & MiAsignatura.Descripcion & "'")
        vSQL.Append(",'" & MiAsignatura.Modulos & "')")
  

        MiAsignatura.Id = objBaseDatos.Insertar(vSQL.ToString)

        Me.Add(MiAsignatura)

    End Sub

    Public Sub EliminarAsignatura(ByVal MiAsignatura As AsignaturaClass)

        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Asignaturas"

        Dim resultado As Boolean
        resultado = objBaseDatos.Eliminar(MiAsignatura.Id)

        If resultado Then

            Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiAsignatura)

            Dim myProperty As PropertyDescriptor = properties.Find("Id", False)

            Me.RemoveAt(Me.FindCore(myProperty, MiAsignatura.Id))
        Else
            MessageBox.Show("No fue posible eliminar el registro.")
        End If

    End Sub

    Public Sub ActualizarAsignaturas(ByVal MiAsignatura As AsignaturaClass)

        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Asignatura"

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("IdCarrera='" & MiAsignatura.IdCarrera.ToString & "'")
        vSQL.Append(",Curso='" & MiAsignatura.Curso & "'")
        vSQL.Append(",Descripcion='" & MiAsignatura.Descripcion.ToString & "'")
        vSQL.Append(",Modulos='" & MiAsignatura.Modulos.ToString & "'")


        Dim resultado As Boolean
        resultado = objBaseDatos.Actualizar(vSQL.ToString, MiAsignatura.Id)

        If resultado Then

            Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiAsignatura)

            Dim myProperty As PropertyDescriptor = properties.Find("Id", False)
            Me.Items.Item(Me.FindCore(myProperty, MiAsignatura.Id)) = MiAsignatura
        Else
            MessageBox.Show("No fue posible modificar el registro.")
        End If

    End Sub
End Class
