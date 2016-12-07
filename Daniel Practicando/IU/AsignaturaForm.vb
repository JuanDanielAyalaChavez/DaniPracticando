Imports System.IO

Public Class AsignaturaForm
    Dim operacion_ As String

    Public Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property

    Dim indice_ As Byte

    Public Property indice() As Byte
        Get
            Return indice_
        End Get
        Set(ByVal value As Byte)
            indice_ = value
        End Set
    End Property

    Dim MiAsignatura As New AsignaturaClass


    Private Sub aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click
        If TextBox1.Text <> "" Then
            MiAsignatura.Id = CInt(TextBox1.Text)
        End If

        If TextBox2.Text = "" Then

            MessageBox.Show("Debe ingresar datos")
            Exit Sub

        End If

        MiAsignatura.IdCarrera = ComboBox1.SelectedIndex
        MiAsignatura.Curso = TextBox2.Text
        MiAsignatura.Descripcion = TextBox3.Text
        MiAsignatura.Modulos = TextBox4.Text
        

        Select Case operacion_

            Case "Alta"
                lstAsignaturas.InsertarAsignaturas(MiAsignatura)

            Case "Elimina"
                lstAsignaturas.EliminarAsignatura(MiAsignatura)

            Case "Modifica"
                lstAsignaturas.ActualizarAsignaturas(MiAsignatura)

                AsignaturasGrid.DataGridView1.RefreshEdit()

        End Select

        Me.Close()
    End Sub

    Private Sub cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click

        Me.Close()

    End Sub
End Class
