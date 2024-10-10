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
        BCalcIVA = New Button()
        TextBruto = New TextBox()
        TextNeto = New TextBox()
        neto = New Label()
        IVA = New Label()
        SuspendLayout()
        ' 
        ' BCalcIVA
        ' 
        BCalcIVA.Location = New Point(56, 310)
        BCalcIVA.Name = "BCalcIVA"
        BCalcIVA.Size = New Size(185, 62)
        BCalcIVA.TabIndex = 0
        BCalcIVA.Text = "Precio Final"
        BCalcIVA.UseVisualStyleBackColor = True
        ' 
        ' TextBruto
        ' 
        TextBruto.Location = New Point(65, 111)
        TextBruto.Name = "TextBruto"
        TextBruto.Size = New Size(194, 31)
        TextBruto.TabIndex = 1
        ' 
        ' TextNeto
        ' 
        TextNeto.Location = New Point(311, 111)
        TextNeto.Name = "TextNeto"
        TextNeto.Size = New Size(194, 31)
        TextNeto.TabIndex = 1
        ' 
        ' neto
        ' 
        neto.AutoSize = True
        neto.Location = New Point(65, 64)
        neto.Name = "neto"
        neto.Size = New Size(104, 25)
        neto.TabIndex = 2
        neto.Text = "Precio Neto"
        ' 
        ' IVA
        ' 
        IVA.AutoSize = True
        IVA.Location = New Point(311, 64)
        IVA.Name = "IVA"
        IVA.Size = New Size(92, 25)
        IVA.TabIndex = 2
        IVA.Text = "Precio IVA"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(IVA)
        Controls.Add(neto)
        Controls.Add(TextNeto)
        Controls.Add(TextBruto)
        Controls.Add(BCalcIVA)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BCalcIVA As Button
    Friend WithEvents TextBruto As TextBox
    Friend WithEvents TextNeto As TextBox
    Friend WithEvents neto As Label
    Friend WithEvents IVA As Label

End Class
