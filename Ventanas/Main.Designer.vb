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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.title = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.tbxUser = New System.Windows.Forms.TextBox()
        Me.tbxPass = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.btnGB = New System.Windows.Forms.Button()
        Me.btnShowPassword = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbData = New System.Windows.Forms.ListBox()
        Me.btnStartRitual = New System.Windows.Forms.Button()
        Me.btnChangeW = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.title.Location = New System.Drawing.Point(178, 9)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(121, 30)
        Me.title.TabIndex = 0
        Me.title.Text = "Bienvenido"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(26, 88)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(30, 15)
        Me.lblUser.TabIndex = 1
        Me.lblUser.Text = "User"
        '
        'tbxUser
        '
        Me.tbxUser.Location = New System.Drawing.Point(139, 80)
        Me.tbxUser.Name = "tbxUser"
        Me.tbxUser.ReadOnly = True
        Me.tbxUser.Size = New System.Drawing.Size(75, 23)
        Me.tbxUser.TabIndex = 2
        '
        'tbxPass
        '
        Me.tbxPass.Location = New System.Drawing.Point(139, 109)
        Me.tbxPass.Name = "tbxPass"
        Me.tbxPass.ReadOnly = True
        Me.tbxPass.Size = New System.Drawing.Size(75, 23)
        Me.tbxPass.TabIndex = 4
        Me.tbxPass.UseSystemPasswordChar = True
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(26, 117)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(57, 15)
        Me.lblPass.TabIndex = 3
        Me.lblPass.Text = "Password"
        '
        'btnGB
        '
        Me.btnGB.BackgroundImage = CType(resources.GetObject("btnGB.BackgroundImage"), System.Drawing.Image)
        Me.btnGB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGB.FlatAppearance.BorderSize = 0
        Me.btnGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGB.Location = New System.Drawing.Point(378, 318)
        Me.btnGB.Name = "btnGB"
        Me.btnGB.Size = New System.Drawing.Size(99, 36)
        Me.btnGB.TabIndex = 6
        Me.btnGB.Text = "Go back"
        Me.btnGB.UseVisualStyleBackColor = True
        '
        'btnShowPassword
        '
        Me.btnShowPassword.Location = New System.Drawing.Point(220, 109)
        Me.btnShowPassword.Name = "btnShowPassword"
        Me.btnShowPassword.Size = New System.Drawing.Size(105, 23)
        Me.btnShowPassword.TabIndex = 7
        Me.btnShowPassword.Text = "Ver contraseña"
        Me.btnShowPassword.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Promedios pasados"
        '
        'lbData
        '
        Me.lbData.CausesValidation = False
        Me.lbData.FormattingEnabled = True
        Me.lbData.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.lbData.ItemHeight = 15
        Me.lbData.Location = New System.Drawing.Point(142, 179)
        Me.lbData.MultiColumn = True
        Me.lbData.Name = "lbData"
        Me.lbData.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lbData.Size = New System.Drawing.Size(186, 94)
        Me.lbData.TabIndex = 9
        Me.lbData.TabStop = False
        '
        'btnStartRitual
        '
        Me.btnStartRitual.Location = New System.Drawing.Point(26, 281)
        Me.btnStartRitual.Name = "btnStartRitual"
        Me.btnStartRitual.Size = New System.Drawing.Size(95, 23)
        Me.btnStartRitual.TabIndex = 10
        Me.btnStartRitual.Text = "Empezar ritual"
        Me.btnStartRitual.UseVisualStyleBackColor = True
        '
        'btnChangeW
        '
        Me.btnChangeW.AutoSize = True
        Me.btnChangeW.Location = New System.Drawing.Point(157, 280)
        Me.btnChangeW.Name = "btnChangeW"
        Me.btnChangeW.Size = New System.Drawing.Size(129, 25)
        Me.btnChangeW.TabIndex = 11
        Me.btnChangeW.Text = "¿Subí o baje de peso?"
        Me.btnChangeW.UseVisualStyleBackColor = False
        Me.btnChangeW.Visible = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(521, 372)
        Me.Controls.Add(Me.btnChangeW)
        Me.Controls.Add(Me.btnStartRitual)
        Me.Controls.Add(Me.lbData)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnShowPassword)
        Me.Controls.Add(Me.btnGB)
        Me.Controls.Add(Me.tbxPass)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.tbxUser)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.title)
        Me.MaximumSize = New System.Drawing.Size(537, 411)
        Me.MinimumSize = New System.Drawing.Size(537, 411)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents btnShowPassword As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbData As ListBox
    Friend WithEvents btnStartRitual As Button
    Friend WithEvents btnChangeW As Button
End Class
