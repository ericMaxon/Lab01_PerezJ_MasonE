<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogIn
    Inherits System.Windows.Forms.Form
    Private Store As ClubDeObesidad
    Private userCred As IUserCredentials = New UserCredentials()
    Private navHistory As List(Of Form)

    Public Sub New(ByRef _Store As ClubDeObesidad, ByRef _NavHistory As List(Of Form))
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Store = _Store
        Me.navHistory = _NavHistory
    End Sub
    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    Friend WithEvents tbxPass As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents tbxUser As TextBox
    Friend WithEvents lblUser As Label
    Friend WithEvents Title As Label
    Friend WithEvents btnGoBack As Button
    Friend WithEvents btnLng As Button
    Friend WithEvents btnShowPassword As Button

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tbxPass = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.tbxUser = New System.Windows.Forms.TextBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.Label()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.btnLng = New System.Windows.Forms.Button()
        Me.btnShowPassword = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbxPass
        '
        Me.tbxPass.Location = New System.Drawing.Point(252, 167)
        Me.tbxPass.Name = "tbxPass"
        Me.tbxPass.PlaceholderText = "Contraseña"
        Me.tbxPass.Size = New System.Drawing.Size(100, 23)
        Me.tbxPass.TabIndex = 16
        Me.tbxPass.UseSystemPasswordChar = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(114, 167)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(67, 15)
        Me.lblPassword.TabIndex = 15
        Me.lblPassword.Text = "Contraseña"
        '
        'tbxUser
        '
        Me.tbxUser.Location = New System.Drawing.Point(252, 101)
        Me.tbxUser.Name = "tbxUser"
        Me.tbxUser.PlaceholderText = "Usuario"
        Me.tbxUser.Size = New System.Drawing.Size(100, 23)
        Me.tbxUser.TabIndex = 14
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(131, 101)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(47, 15)
        Me.lblUser.TabIndex = 13
        Me.lblUser.Text = "Usuario"
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Title.Location = New System.Drawing.Point(184, 24)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(100, 21)
        Me.Title.TabIndex = 12
        Me.Title.Text = "Iniciar sesion"
        '
        'btnGoBack
        '
        Me.btnGoBack.Location = New System.Drawing.Point(277, 284)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(75, 29)
        Me.btnGoBack.TabIndex = 11
        Me.btnGoBack.Text = "Regresar"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'btnLng
        '
        Me.btnLng.Location = New System.Drawing.Point(148, 284)
        Me.btnLng.Name = "btnLng"
        Me.btnLng.Size = New System.Drawing.Size(75, 29)
        Me.btnLng.TabIndex = 10
        Me.btnLng.Text = "Iniciar sesion"
        Me.btnLng.UseVisualStyleBackColor = True
        '
        'btnShowPassword
        '
        Me.btnShowPassword.Location = New System.Drawing.Point(358, 167)
        Me.btnShowPassword.Name = "btnShowPassword"
        Me.btnShowPassword.Size = New System.Drawing.Size(127, 23)
        Me.btnShowPassword.TabIndex = 18
        Me.btnShowPassword.Text = "Mostrar contraseña"
        Me.btnShowPassword.UseVisualStyleBackColor = False
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 379)
        Me.Controls.Add(Me.btnShowPassword)
        Me.Controls.Add(Me.tbxPass)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.tbxUser)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.btnLng)
        Me.MaximumSize = New System.Drawing.Size(570, 418)
        Me.MinimumSize = New System.Drawing.Size(570, 39)
        Me.Name = "LogIn"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub CrearUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tbxUser_TextChanged(sender As Object, e As EventArgs) Handles tbxUser.TextChanged
        Me.userCred.UserProp = Me.tbxUser.Text
    End Sub
    Private Sub tbxPass_TextChanged(sender As Object, e As EventArgs) Handles tbxPass.TextChanged
        Me.userCred.PwProp = Me.tbxPass.Text
    End Sub
    Private Sub btnLng_Click(sender As Object, e As EventArgs) Handles btnLng.Click
        Dim responseID As String = Me.Store.ValidateUser(Me.userCred.UserProp, Me.userCred.PwProp)
        If (responseID IsNot Nothing) Then
            Dim response As Miembro = Me.Store.GetMember(responseID)
            navHistory.Last().Hide()
            navHistory.Add(New Main(Me.Store, response, Me.navHistory))
            ResetValue()
            navHistory.Last().Show()
        Else
            MsgBox("Wrong information try again", vbOKOnly, Me.Title.Text)
        End If
    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        navHistory.Last().Hide()
        navHistory.Remove(Me)
        ResetValue()
        navHistory.Last().Show()
    End Sub

    Private Sub btnShowPassword_Click(sender As Object, e As EventArgs) Handles btnShowPassword.Click
        Me.tbxPass.UseSystemPasswordChar = Not Me.tbxPass.UseSystemPasswordChar
    End Sub
    Private Sub ResetValue()
        Me.userCred.UserProp = ""
        Me.userCred.PwProp = ""
        Me.tbxPass.ResetText()
        Me.tbxUser.ResetText()
    End Sub
End Class
