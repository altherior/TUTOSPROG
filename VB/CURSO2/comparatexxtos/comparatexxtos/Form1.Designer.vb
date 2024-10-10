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
        ButtonCheck = New Button()
        TextInput01 = New TextBox()
        Label1 = New Label()
        TextWord01 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' ButtonCheck
        ' 
        ButtonCheck.Location = New Point(308, 241)
        ButtonCheck.Name = "ButtonCheck"
        ButtonCheck.Size = New Size(131, 40)
        ButtonCheck.TabIndex = 0
        ButtonCheck.Text = "Comprobar"
        ButtonCheck.UseVisualStyleBackColor = True
        ' 
        ' TextInput01
        ' 
        TextInput01.Location = New Point(43, 139)
        TextInput01.Name = "TextInput01"
        TextInput01.Size = New Size(396, 35)
        TextInput01.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(187, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(310, 30)
        Label1.TabIndex = 2
        Label1.Text = "Comprador de cadenas de texto"
        ' 
        ' TextWord01
        ' 
        TextWord01.Location = New Point(43, 241)
        TextWord01.Name = "TextWord01"
        TextWord01.Size = New Size(175, 35)
        TextWord01.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(43, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(185, 30)
        Label2.TabIndex = 4
        Label2.Text = "Introduzca la frase"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(43, 190)
        Label3.Name = "Label3"
        Label3.Size = New Size(293, 30)
        Label3.TabIndex = 4
        Label3.Text = "Introduzca la palabra a buscar"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextWord01)
        Controls.Add(Label1)
        Controls.Add(TextInput01)
        Controls.Add(ButtonCheck)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonCheck As Button
    Friend WithEvents TextInput01 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextWord01 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
