<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogIn
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(LogIn))
        btnContinue = New Button()
        Panel1 = New Panel()
        DateTimePicker1 = New DateTimePicker()
        CheckBox1 = New CheckBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnContinue
        ' 
        btnContinue.BackColor = Color.DodgerBlue
        btnContinue.FlatAppearance.MouseDownBackColor = Color.DodgerBlue
        btnContinue.FlatAppearance.MouseOverBackColor = Color.LightCyan
        btnContinue.FlatStyle = FlatStyle.Flat
        btnContinue.Font = New Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnContinue.Location = New Point(425, 396)
        btnContinue.Name = "btnContinue"
        btnContinue.Size = New Size(258, 53)
        btnContinue.TabIndex = 0
        btnContinue.Text = "Continue"
        btnContinue.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Location = New Point(1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1109, 330)
        Panel1.TabIndex = 1
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(776, 27)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(300, 31)
        DateTimePicker1.TabIndex = 3
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.Transparent
        CheckBox1.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox1.Location = New Point(134, 484)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(844, 26)
        CheckBox1.TabIndex = 2
        CheckBox1.Text = "I agree to the Terms of Service and Privacy Policy and consent to continue using this app."
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' LogIn
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1108, 561)
        Controls.Add(CheckBox1)
        Controls.Add(Panel1)
        Controls.Add(btnContinue)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "LogIn"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Benefits, Coverage and Contribution Inquiry System"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnContinue As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
