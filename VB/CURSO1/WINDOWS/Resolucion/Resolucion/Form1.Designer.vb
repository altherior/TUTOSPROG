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
        Radio640 = New RadioButton()
        Radio800 = New RadioButton()
        Radio1024 = New RadioButton()
        SetRes = New Button()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Radio640
        ' 
        Radio640.AutoSize = True
        Radio640.Location = New Point(6, 36)
        Radio640.Name = "Radio640"
        Radio640.Size = New Size(115, 29)
        Radio640.TabIndex = 0
        Radio640.TabStop = True
        Radio640.Text = "640 x 480"
        Radio640.UseVisualStyleBackColor = True
        ' 
        ' Radio800
        ' 
        Radio800.AutoSize = True
        Radio800.Location = New Point(6, 71)
        Radio800.Name = "Radio800"
        Radio800.Size = New Size(115, 29)
        Radio800.TabIndex = 0
        Radio800.TabStop = True
        Radio800.Text = "800 x 600"
        Radio800.UseVisualStyleBackColor = True
        ' 
        ' Radio1024
        ' 
        Radio1024.AutoSize = True
        Radio1024.Location = New Point(6, 106)
        Radio1024.Name = "Radio1024"
        Radio1024.Size = New Size(125, 29)
        Radio1024.TabIndex = 0
        Radio1024.TabStop = True
        Radio1024.Text = "1024 x 768"
        Radio1024.UseVisualStyleBackColor = True
        ' 
        ' SetRes
        ' 
        SetRes.Location = New Point(435, 349)
        SetRes.Name = "SetRes"
        SetRes.Size = New Size(171, 63)
        SetRes.TabIndex = 1
        SetRes.Text = "Resolución"
        SetRes.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Radio1024)
        GroupBox1.Controls.Add(Radio800)
        GroupBox1.Controls.Add(Radio640)
        GroupBox1.Location = New Point(12, 22)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(145, 157)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Resolución"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(RadioButton2)
        GroupBox2.Controls.Add(RadioButton1)
        GroupBox2.Location = New Point(212, 18)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(144, 161)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Género"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(6, 40)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(117, 29)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Masculino"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(8, 75)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(115, 29)
        RadioButton2.TabIndex = 0
        RadioButton2.TabStop = True
        RadioButton2.Text = "Femenino"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(618, 424)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(SetRes)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Radio640 As RadioButton
    Friend WithEvents Radio800 As RadioButton
    Friend WithEvents Radio1024 As RadioButton
    Friend WithEvents SetRes As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton

End Class
