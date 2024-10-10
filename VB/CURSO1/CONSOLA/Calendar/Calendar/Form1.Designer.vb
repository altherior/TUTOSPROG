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
        MonthCalendar = New MonthCalendar()
        LabelDate = New Label()
        ButtonDate = New Button()
        SuspendLayout()
        ' 
        ' MonthCalendar
        ' 
        MonthCalendar.Location = New Point(87, 45)
        MonthCalendar.Name = "MonthCalendar"
        MonthCalendar.ShowTodayCircle = False
        MonthCalendar.TabIndex = 0
        ' 
        ' LabelDate
        ' 
        LabelDate.AutoSize = True
        LabelDate.Location = New Point(476, 49)
        LabelDate.Name = "LabelDate"
        LabelDate.Size = New Size(0, 25)
        LabelDate.TabIndex = 1
        ' 
        ' ButtonDate
        ' 
        ButtonDate.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonDate.Location = New Point(87, 343)
        ButtonDate.Name = "ButtonDate"
        ButtonDate.Size = New Size(256, 56)
        ButtonDate.TabIndex = 2
        ButtonDate.Text = "Fecha"
        ButtonDate.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonDate)
        Controls.Add(LabelDate)
        Controls.Add(MonthCalendar)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MonthCalendar As MonthCalendar
    Friend WithEvents LabelDate As Label
    Friend WithEvents ButtonDate As Button

End Class
