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
        BtnProc = New Button()
        BtnFunc = New Button()
        TextBoxMessage = New TextBox()
        BtnFncVal = New Button()
        BtnFuncRef = New Button()
        SuspendLayout()
        ' 
        ' BtnProc
        ' 
        BtnProc.Location = New Point(65, 317)
        BtnProc.Name = "BtnProc"
        BtnProc.Size = New Size(158, 39)
        BtnProc.TabIndex = 0
        BtnProc.Text = "Procedimiento"
        BtnProc.UseVisualStyleBackColor = True
        ' 
        ' BtnFunc
        ' 
        BtnFunc.Location = New Point(229, 317)
        BtnFunc.Name = "BtnFunc"
        BtnFunc.Size = New Size(158, 39)
        BtnFunc.TabIndex = 0
        BtnFunc.Text = "Función"
        BtnFunc.UseVisualStyleBackColor = True
        ' 
        ' TextBoxMessage
        ' 
        TextBoxMessage.Location = New Point(65, 41)
        TextBoxMessage.Multiline = True
        TextBoxMessage.Name = "TextBoxMessage"
        TextBoxMessage.Size = New Size(654, 89)
        TextBoxMessage.TabIndex = 1
        ' 
        ' BtnFncVal
        ' 
        BtnFncVal.Location = New Point(393, 317)
        BtnFncVal.Name = "BtnFncVal"
        BtnFncVal.Size = New Size(158, 39)
        BtnFncVal.TabIndex = 0
        BtnFncVal.Text = "FuncValor"
        BtnFncVal.UseVisualStyleBackColor = True
        ' 
        ' BtnFuncRef
        ' 
        BtnFuncRef.Location = New Point(561, 317)
        BtnFuncRef.Name = "BtnFuncRef"
        BtnFuncRef.Size = New Size(158, 39)
        BtnFuncRef.TabIndex = 0
        BtnFuncRef.Text = "FuncRef"
        BtnFuncRef.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBoxMessage)
        Controls.Add(BtnFuncRef)
        Controls.Add(BtnFncVal)
        Controls.Add(BtnFunc)
        Controls.Add(BtnProc)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnProc As Button
    Friend WithEvents BtnFunc As Button
    Friend WithEvents TextBoxMessage As TextBox
    Friend WithEvents BtnFncVal As Button
    Friend WithEvents BtnFuncRef As Button

End Class
