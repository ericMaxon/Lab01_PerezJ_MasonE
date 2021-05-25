<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.title = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.tbxUser = New System.Windows.Forms.TextBox()
        Me.tbxPass = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.btnGB = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Location = New System.Drawing.Point(256, 37)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(66, 15)
        Me.title.TabIndex = 0
        Me.title.Text = "Bienvenido"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(191, 93)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(30, 15)
        Me.lblUser.TabIndex = 1
        Me.lblUser.Text = "User"
        '
        'tbxUser
        '
        Me.tbxUser.Location = New System.Drawing.Point(304, 85)
        Me.tbxUser.Name = "tbxUser"
        Me.tbxUser.ReadOnly = True
        Me.tbxUser.Size = New System.Drawing.Size(75, 23)
        Me.tbxUser.TabIndex = 2
        '
        'tbxPass
        '
        Me.tbxPass.Location = New System.Drawing.Point(304, 165)
        Me.tbxPass.Name = "tbxPass"
        Me.tbxPass.ReadOnly = True
        Me.tbxPass.Size = New System.Drawing.Size(75, 23)
        Me.tbxPass.TabIndex = 4
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(191, 173)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(57, 15)
        Me.lblPass.TabIndex = 3
        Me.lblPass.Text = "Password"
        '
        'btnGB
        '
        Me.btnGB.Location = New System.Drawing.Point(447, 333)
        Me.btnGB.Name = "btnGB"
        Me.btnGB.Size = New System.Drawing.Size(75, 23)
        Me.btnGB.TabIndex = 6
        Me.btnGB.Text = "Go back"
        Me.btnGB.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 405)
        Me.Controls.Add(Me.btnGB)
        Me.Controls.Add(Me.tbxPass)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.tbxUser)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.title)
        Me.Name = "Main"
        Me.Text = "Main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents title As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents tbxUser As TextBox
    Friend WithEvents tbxPass As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents btnGB As Button
End Class
