<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AsignaturasGrid
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AsignaturasGrid))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Agregar = New System.Windows.Forms.ToolStripButton
        Me.Eliminar = New System.Windows.Forms.ToolStripButton
        Me.Modificar = New System.Windows.Forms.ToolStripButton
        Me.Salir = New System.Windows.Forms.ToolStripButton
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.AsignaturasCollecctionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdCarreraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Carrera = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CursoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ModulosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsignaturasCollecctionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Agregar, Me.Eliminar, Me.Modificar, Me.Salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(714, 55)
        Me.ToolStrip1.TabIndex = 10
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Agregar
        '
        Me.Agregar.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Agregar.Image = CType(resources.GetObject("Agregar.Image"), System.Drawing.Image)
        Me.Agregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(115, 52)
        Me.Agregar.Text = "Agregar"
        '
        'Eliminar
        '
        Me.Eliminar.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Eliminar.Image = CType(resources.GetObject("Eliminar.Image"), System.Drawing.Image)
        Me.Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(115, 52)
        Me.Eliminar.Text = "Eliminar"
        '
        'Modificar
        '
        Me.Modificar.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Modificar.Image = CType(resources.GetObject("Modificar.Image"), System.Drawing.Image)
        Me.Modificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(125, 52)
        Me.Modificar.Text = "Modificar"
        '
        'Salir
        '
        Me.Salir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Salir.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Salir.Image = CType(resources.GetObject("Salir.Image"), System.Drawing.Image)
        Me.Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Salir.Name = "Salir"
        Me.Salir.RightToLeftAutoMirrorImage = True
        Me.Salir.Size = New System.Drawing.Size(90, 52)
        Me.Salir.Text = "Salir"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.IdCarreraDataGridViewTextBoxColumn, Me.Carrera, Me.CursoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.ModulosDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AsignaturasCollecctionBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 58)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(714, 335)
        Me.DataGridView1.TabIndex = 11
        '
        'AsignaturasCollecctionBindingSource
        '
        Me.AsignaturasCollecctionBindingSource.DataSource = GetType(Daniel_Practicando.AsignaturasCollecction)
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdCarreraDataGridViewTextBoxColumn
        '
        Me.IdCarreraDataGridViewTextBoxColumn.DataPropertyName = "IdCarrera"
        Me.IdCarreraDataGridViewTextBoxColumn.HeaderText = "IdCarrera"
        Me.IdCarreraDataGridViewTextBoxColumn.Name = "IdCarreraDataGridViewTextBoxColumn"
        Me.IdCarreraDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCarreraDataGridViewTextBoxColumn.Visible = False
        '
        'Carrera
        '
        Me.Carrera.DataPropertyName = "nombrescarreras"
        Me.Carrera.HeaderText = "Carrera"
        Me.Carrera.Name = "Carrera"
        Me.Carrera.ReadOnly = True
        '
        'CursoDataGridViewTextBoxColumn
        '
        Me.CursoDataGridViewTextBoxColumn.DataPropertyName = "Curso"
        Me.CursoDataGridViewTextBoxColumn.HeaderText = "Curso"
        Me.CursoDataGridViewTextBoxColumn.Name = "CursoDataGridViewTextBoxColumn"
        Me.CursoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ModulosDataGridViewTextBoxColumn
        '
        Me.ModulosDataGridViewTextBoxColumn.DataPropertyName = "Modulos"
        Me.ModulosDataGridViewTextBoxColumn.HeaderText = "Modulos"
        Me.ModulosDataGridViewTextBoxColumn.Name = "ModulosDataGridViewTextBoxColumn"
        Me.ModulosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AsignaturasGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 289)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "AsignaturasGrid"
        Me.Text = "Grid"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsignaturasCollecctionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Agregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Modificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents AsignaturasCollecctionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCarreraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Carrera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CursoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModulosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
