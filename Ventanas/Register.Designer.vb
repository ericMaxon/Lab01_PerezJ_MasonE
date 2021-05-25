<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tbxPass = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.tbxUser = New System.Windows.Forms.TextBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.Label()
        Me.btnHveAcc = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnShowPassword = New System.Windows.Forms.Button()
        Me.namelbl = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbxPass
        '
        Me.tbxPass.Location = New System.Drawing.Point(291, 196)
        Me.tbxPass.Name = "tbxPass"
        Me.tbxPass.PlaceholderText = "Contraseña"
        Me.tbxPass.Size = New System.Drawing.Size(100, 23)
        Me.tbxPass.TabIndex = 16
        Me.tbxPass.UseSystemPasswordChar = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(181, 199)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(57, 16)
        Me.lblPassword.TabIndex = 15
        Me.lblPassword.Text = "Password"
        '
        'tbxUser
        '
        Me.tbxUser.Location = New System.Drawing.Point(291, 139)
        Me.tbxUser.Name = "tbxUser"
        Me.tbxUser.PlaceholderText = "Usuario"
        Me.tbxUser.Size = New System.Drawing.Size(100, 23)
        Me.tbxUser.TabIndex = 14
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(208, 142)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(30, 16)
        Me.lblUser.TabIndex = 13
        Me.lblUser.Text = "User"
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Segoe UI Emoji", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Title.Location = New System.Drawing.Point(248, 30)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(123, 16)
        Me.Title.TabIndex = 12
        Me.Title.Text = "Crear nuevo miembro"
        '
        'btnHveAcc
        '
        Me.btnHveAcc.Location = New System.Drawing.Point(395, 321)
        Me.btnHveAcc.Name = "btnHveAcc"
        Me.btnHveAcc.Size = New System.Drawing.Size(112, 29)
        Me.btnHveAcc.TabIndex = 11
        Me.btnHveAcc.Text = "Ya tengo cuenta"
        Me.btnHveAcc.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(119, 321)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(119, 29)
        Me.btnCreate.TabIndex = 10
        Me.btnCreate.Text = "Crear usuario"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnShowPassword
        '
        Me.btnShowPassword.Location = New System.Drawing.Point(397, 196)
        Me.btnShowPassword.Name = "btnShowPassword"
        Me.btnShowPassword.Size = New System.Drawing.Size(140, 23)
        Me.btnShowPassword.TabIndex = 17
        Me.btnShowPassword.Text = "Mostrar contraseña"
        Me.btnShowPassword.UseVisualStyleBackColor = False
        '
        'namelbl
        '
        Me.namelbl.AutoSize = True
        Me.namelbl.Location = New System.Drawing.Point(187, 98)
        Me.namelbl.Name = "namelbl"
        Me.namelbl.Size = New System.Drawing.Size(51, 16)
        Me.namelbl.TabIndex = 18
        Me.namelbl.Text = "Nombre"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(291, 91)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PlaceholderText = "Nombre"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 19
        '
        'btnFinish
        '
        Me.btnFinish.Location = New System.Drawing.Point(280, 376)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(75, 23)
        Me.btnFinish.TabIndex = 20
        Me.btnFinish.Text = "Terminar"
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 411)
        Me.Controls.Add(Me.btnFinish)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.namelbl)
        Me.Controls.Add(Me.btnShowPassword)
        Me.Controls.Add(Me.tbxPass)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.tbxUser)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.btnHveAcc)
        Me.Controls.Add(Me.btnCreate)
        Me.Font = New System.Drawing.Font("Segoe UI Emoji", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "Register"
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbxPass As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents tbxUser As TextBox
    Friend WithEvents lblUser As Label
    Friend WithEvents Title As Label
    Friend WithEvents btnHveAcc As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnShowPassword As Button
    Friend WithEvents namelbl As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnFinish As Button
End Class
