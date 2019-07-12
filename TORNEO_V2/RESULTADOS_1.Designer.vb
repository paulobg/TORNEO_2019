<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RESULTADOS_1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_1 = New System.Windows.Forms.TextBox()
        Me.TB_2 = New System.Windows.Forms.TextBox()
        Me.B_ACEPTAR = New System.Windows.Forms.Button()
        Me.B_CANCELAR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EQUIPO 1 VS EQUIPO 2"
        '
        'TB_1
        '
        Me.TB_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_1.Location = New System.Drawing.Point(32, 53)
        Me.TB_1.Name = "TB_1"
        Me.TB_1.Size = New System.Drawing.Size(125, 38)
        Me.TB_1.TabIndex = 1
        '
        'TB_2
        '
        Me.TB_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_2.Location = New System.Drawing.Point(275, 53)
        Me.TB_2.Name = "TB_2"
        Me.TB_2.Size = New System.Drawing.Size(117, 38)
        Me.TB_2.TabIndex = 2
        '
        'B_ACEPTAR
        '
        Me.B_ACEPTAR.Location = New System.Drawing.Point(44, 121)
        Me.B_ACEPTAR.Name = "B_ACEPTAR"
        Me.B_ACEPTAR.Size = New System.Drawing.Size(103, 33)
        Me.B_ACEPTAR.TabIndex = 3
        Me.B_ACEPTAR.Text = "ACEPTAR"
        Me.B_ACEPTAR.UseVisualStyleBackColor = True
        '
        'B_CANCELAR
        '
        Me.B_CANCELAR.Location = New System.Drawing.Point(275, 121)
        Me.B_CANCELAR.Name = "B_CANCELAR"
        Me.B_CANCELAR.Size = New System.Drawing.Size(103, 33)
        Me.B_CANCELAR.TabIndex = 4
        Me.B_CANCELAR.Text = "CANCELAR"
        Me.B_CANCELAR.UseVisualStyleBackColor = True
        '
        'RESULTADOS_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 167)
        Me.Controls.Add(Me.B_CANCELAR)
        Me.Controls.Add(Me.B_ACEPTAR)
        Me.Controls.Add(Me.TB_2)
        Me.Controls.Add(Me.TB_1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RESULTADOS_1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RESULTADOS"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TB_1 As TextBox
    Friend WithEvents TB_2 As TextBox
    Friend WithEvents B_ACEPTAR As Button
    Friend WithEvents B_CANCELAR As Button
End Class
