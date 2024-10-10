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
        LabelMessage = New Label()
        ButtonHello = New Button()
        ButtonExit = New Button()
        SuspendLayout()
        ' 
        ' LabelMessage
        ' 
        LabelMessage.AutoSize = True
        LabelMessage.Location = New Point(70, 39)
        LabelMessage.Name = "LabelMessage"
        LabelMessage.Size = New Size(0, 25)
        LabelMessage.TabIndex = 0
        ' 
        ' ButtonHello
        ' 
        ButtonHello.Location = New Point(519, 347)
        ButtonHello.Name = "ButtonHello"
        ButtonHello.Size = New Size(195, 56)
        ButtonHello.TabIndex = 1
        ButtonHello.Text = "Saludos"
        ButtonHello.UseVisualStyleBackColor = True
        ' 
        ' ButtonExit
        ' 
        ButtonExit.Location = New Point(306, 347)
        ButtonExit.Name = "ButtonExit"
        ButtonExit.Size = New Size(195, 56)
        ButtonExit.TabIndex = 1
        ButtonExit.Text = "Salir"
        ButtonExit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonExit)
        Controls.Add(ButtonHello)
        Controls.Add(LabelMessage)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelMessage As Label
    Friend WithEvents ButtonHello As Button
    Friend WithEvents ButtonExit As Button

End Class
