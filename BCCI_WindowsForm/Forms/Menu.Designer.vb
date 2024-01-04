<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Menu))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Panel1 = New Panel()
        btnGenerate = New Button()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Impact", 37F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Chocolate
        Label1.Location = New Point(75, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(431, 91)
        Label1.TabIndex = 0
        Label1.Text = "BCCI System"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(18, 184)
        Label2.Name = "Label2"
        Label2.Size = New Size(189, 22)
        Label2.TabIndex = 1
        Label2.Text = "Name of Employee:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(21, 253)
        Label3.Name = "Label3"
        Label3.Size = New Size(186, 22)
        Label3.TabIndex = 2
        Label3.Text = "Name of Company:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(54, 321)
        Label4.Name = "Label4"
        Label4.Size = New Size(153, 22)
        Label4.TabIndex = 3
        Label4.Text = "Monthly Salary:"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(btnGenerate)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(257, 43)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(569, 552)
        Panel1.TabIndex = 0
        ' 
        ' btnGenerate
        ' 
        btnGenerate.BackColor = Color.SandyBrown
        btnGenerate.FlatAppearance.BorderColor = Color.DarkGray
        btnGenerate.FlatAppearance.MouseDownBackColor = Color.LightSalmon
        btnGenerate.FlatAppearance.MouseOverBackColor = Color.PeachPuff
        btnGenerate.FlatStyle = FlatStyle.Flat
        btnGenerate.Font = New Font("Berlin Sans FB", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnGenerate.Location = New Point(161, 418)
        btnGenerate.Name = "btnGenerate"
        btnGenerate.Size = New Size(228, 52)
        btnGenerate.TabIndex = 7
        btnGenerate.Text = "GENERATE"
        btnGenerate.UseVisualStyleBackColor = False
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(213, 316)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(315, 31)
        TextBox3.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(213, 248)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(315, 31)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(213, 179)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(315, 31)
        TextBox1.TabIndex = 4
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1109, 652)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Menu"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Benefits, Coverage and Contribution Inquiry System"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnGenerate As Button
End Class
