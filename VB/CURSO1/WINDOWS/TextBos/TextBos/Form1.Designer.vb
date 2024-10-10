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
        NumberOne = New TextBox()
        NumberTwo = New TextBox()
        Sum = New Button()
        Resultado = New Label()
        ReadText = New TextBox()
        Message = New Button()
        CheckBox1 = New CheckBox()
        SuspendLayout()
        ' 
        ' NumberOne
        ' 
        NumberOne.Location = New Point(91, 65)
        NumberOne.Name = "NumberOne"
        NumberOne.Size = New Size(135, 31)
        NumberOne.TabIndex = 0
        ' 
        ' NumberTwo
        ' 
        NumberTwo.Location = New Point(91, 115)
        NumberTwo.Name = "NumberTwo"
        NumberTwo.Size = New Size(135, 31)
        NumberTwo.TabIndex = 1
        ' 
        ' Sum
        ' 
        Sum.Location = New Point(92, 188)
        Sum.Name = "Sum"
        Sum.Size = New Size(134, 38)
        Sum.TabIndex = 2
        Sum.Text = "Suma"
        Sum.UseVisualStyleBackColor = True
        ' 
        ' Resultado
        ' 
        Resultado.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Resultado.Location = New Point(313, 65)
        Resultado.Name = "Resultado"
        Resultado.Size = New Size(255, 58)
        Resultado.TabIndex = 2
        Resultado.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' ReadText
        ' 
        ReadText.Location = New Point(335, 188)
        ReadText.Multiline = True
        ReadText.Name = "ReadText"
        ReadText.Size = New Size(520, 218)
        ReadText.TabIndex = 3
        ReadText.Text = "El acuerdo de licencia establece que acepta todo el acuerdo de licenia y las normativas indicadas en el mismo"
        ' 
        ' Message
        ' 
        Message.Enabled = False
        Message.Location = New Point(340, 453)
        Message.Name = "Message"
        Message.Size = New Size(168, 50)
        Message.TabIndex = 4
        Message.Text = "Mensaje"
        Message.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(342, 414)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(268, 29)
        CheckBox1.TabIndex = 5
        CheckBox1.Text = "Acepto el acuerdo de licencia"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(927, 525)
        Controls.Add(CheckBox1)
        Controls.Add(Message)
        Controls.Add(ReadText)
        Controls.Add(Resultado)
        Controls.Add(Sum)
        Controls.Add(NumberTwo)
        Controls.Add(NumberOne)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sumatorio"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NumberOne As TextBox
    Friend WithEvents NumberTwo As TextBox
    Friend WithEvents Sum As Button
    Friend WithEvents Resultado As Label
    Friend WithEvents ReadText As TextBox
    Friend WithEvents Message As Button
    Friend WithEvents CheckBox1 As CheckBox

End Class
