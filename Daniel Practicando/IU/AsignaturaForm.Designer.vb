<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AsignaturaForm
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
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Modulos = New System.Windows.Forms.Label
        Me.Descripcion = New System.Windows.Forms.Label
        Me.Curso = New System.Windows.Forms.Label
        Me.IdCarrera = New System.Windows.Forms.Label
        Me.Id = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Cancelar = New System.Windows.Forms.Button
        Me.Aceptar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(188, 199)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 25
        '
        'Modulos
        '
        Me.Modulos.AutoSize = True
        Me.Modulos.Location = New System.Drawing.Point(78, 202)
        Me.Modulos.Name = "Modulos"
        Me.Modulos.Size = New System.Drawing.Size(47, 13)
        Me.Modulos.TabIndex = 24
        Me.Modulos.Text = "Modulos"
        '
        'Descripcion
        '
        Me.Descripcion.AutoSize = True
        Me.Descripcion.Location = New System.Drawing.Point(76, 156)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(63, 13)
        Me.Descripcion.TabIndex = 23
        Me.Descripcion.Text = "Descripcion"
        '
        'Curso
        '
        Me.Curso.AutoSize = True
        Me.Curso.Location = New System.Drawing.Point(76, 116)
        Me.Curso.Name = "Curso"
        Me.Curso.Size = New System.Drawing.Size(34, 13)
        Me.Curso.TabIndex = 22
        Me.Curso.Text = "Curso"
        '
        'IdCarrera
        '
        Me.IdCarrera.AutoSize = True
        Me.IdCarrera.Location = New System.Drawing.Point(76, 74)
        Me.IdCarrera.Name = "IdCarrera"
        Me.IdCarrera.Size = New System.Drawing.Size(41, 13)
        Me.IdCarrera.TabIndex = 21
        Me.IdCarrera.Text = "Carrera"
        '
        'Id
        '
        Me.Id.AutoSize = True
        Me.Id.Location = New System.Drawing.Point(76, 28)
        Me.Id.Name = "Id"
        Me.Id.Size = New System.Drawing.Size(16, 13)
        Me.Id.TabIndex = 20
        Me.Id.Text = "Id"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(188, 153)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 19
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(188, 113)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 18
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(188, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 17
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Informatica", "Gestion", "Turismo", " Matematicas", " Ingles"})
        Me.ComboBox1.Location = New System.Drawing.Point(188, 71)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 16
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(213, 282)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Cancelar.TabIndex = 15
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(79, 282)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Aceptar.TabIndex = 14
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'AsignaturaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 326)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Modulos)
        Me.Controls.Add(Me.Descripcion)
        Me.Controls.Add(Me.Curso)
        Me.Controls.Add(Me.IdCarrera)
        Me.Controls.Add(Me.Id)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Aceptar)
        Me.Name = "AsignaturaForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Modulos As System.Windows.Forms.Label
    Friend WithEvents Descripcion As System.Windows.Forms.Label
    Friend WithEvents Curso As System.Windows.Forms.Label
    Friend WithEvents IdCarrera As System.Windows.Forms.Label
    Friend WithEvents Id As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents Aceptar As System.Windows.Forms.Button

End Class
