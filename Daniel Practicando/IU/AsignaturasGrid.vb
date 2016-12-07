
Imports System.ComponentModel

Public Class AsignaturasGrid

    Dim frmAsignaturas As AsignaturaForm

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click

        frmAsignaturas = New AsignaturaForm

        frmAsignaturas.operacion = "Alta"

        frmAsignaturas.Text = "Agregar Asignatura"

        frmAsignaturas.ShowDialog()

        frmAsignaturas.Dispose()
    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click

        If lstAsignaturas.Count = 0 Then Exit Sub

        frmAsignaturas = New AsignaturaForm

        frmAsignaturas.operacion = "Elimina"

        llenarAsignaturaForm()

        frmAsignaturas.Text = "Eliminar Asignatura"

        frmAsignaturas.ShowDialog()

        frmAsignaturas.Dispose()

    End Sub

    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click

        If lstAsignaturas.Count = 0 Then Exit Sub

        frmAsignaturas = New AsignaturaForm

        frmAsignaturas.operacion = "Modifica"

        llenarAsignaturaForm()

        frmAsignaturas.Text = "Modificar Asignatura"

        frmAsignaturas.ShowDialog()

        frmAsignaturas.Dispose()

    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Me.Close()
    End Sub


    Private Sub AsignaturasGrid_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DataGridView1.DataSource = lstAsignaturas
    End Sub

    Private Sub llenarAsignaturaForm()

        frmAsignaturas.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
        frmAsignaturas.ComboBox1.SelectedItem = DataGridView1.CurrentRow.Cells(1).Value
        frmAsignaturas.TextBox2.Text = DataGridView1.CurrentRow.Cells(3).Value
        frmAsignaturas.TextBox3.Text = DataGridView1.CurrentRow.Cells(4).Value
        frmAsignaturas.TextBox4.Text = DataGridView1.CurrentRow.Cells(5).Value


    End Sub
End Class