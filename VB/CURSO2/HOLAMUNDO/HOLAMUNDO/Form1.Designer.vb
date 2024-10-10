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
        ButtonSaludo = New Button()
        ButtonClose = New Button()
        TextFile = New TextBox()
        SuspendLayout()
        ' 
        ' ButtonSaludo
        ' 
        ButtonSaludo.Location = New Point(58, 324)
        ButtonSaludo.Name = "ButtonSaludo"
        ButtonSaludo.Size = New Size(199, 61)
        ButtonSaludo.TabIndex = 0
        ButtonSaludo.Text = "Saludos"
        ButtonSaludo.UseVisualStyleBackColor = True
        ' 
        ' ButtonClose
        ' 
        ButtonClose.Location = New Point(526, 324)
        ButtonClose.Name = "ButtonClose"
        ButtonClose.Size = New Size(199, 61)
        ButtonClose.TabIndex = 0
        ButtonClose.Text = "Salir"
        ButtonClose.UseVisualStyleBackColor = True
        ' 
        ' TextFile
        ' 
        TextFile.Location = New Point(83, 42)
        TextFile.Multiline = True
        TextFile.Name = "TextFile"
        TextFile.Size = New Size(330, 236)
        TextFile.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextFile)
        Controls.Add(ButtonClose)
        Controls.Add(ButtonSaludo)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonSaludo As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents TextFile As TextBox

End Class
