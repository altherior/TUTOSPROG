<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Title = New Label()
        Label1 = New Label()
        Data001 = New TextBox()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Title
        ' 
        Title.AutoSize = True
        Title.Font = New Font("Impact", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Title.ForeColor = SystemColors.ControlLightLight
        Title.Location = New Point(239, 9)
        Title.Margin = New Padding(0)
        Title.Name = "Title"
        Title.Size = New Size(292, 60)
        Title.TabIndex = 0
        Title.Text = "CALCULADORA"
        Title.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Impact", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(251, 9)
        Label1.Margin = New Padding(0)
        Label1.Name = "Label1"
        Label1.Size = New Size(292, 60)
        Label1.TabIndex = 0
        Label1.Text = "CALCULADORA"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Data001
        ' 
        Data001.Location = New Point(239, 89)
        Data001.Name = "Data001"
        Data001.Size = New Size(204, 31)
        Data001.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(32, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(166, 25)
        Label2.TabIndex = 2
        Label2.Text = "Introduzca un texto"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Data001)
        Controls.Add(Label1)
        Controls.Add(Title)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Data001 As TextBox
    Friend WithEvents Label2 As Label

End Class
