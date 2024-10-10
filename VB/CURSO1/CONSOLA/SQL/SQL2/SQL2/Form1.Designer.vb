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
        ProductBox = New TextBox()
        PriceBox = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        InsertButton = New Button()
        ListBox = New TextBox()
        ListButton = New Button()
        SuspendLayout()
        ' 
        ' ProductBox
        ' 
        ProductBox.Location = New Point(224, 102)
        ProductBox.Name = "ProductBox"
        ProductBox.Size = New Size(207, 31)
        ProductBox.TabIndex = 0
        ' 
        ' PriceBox
        ' 
        PriceBox.Location = New Point(300, 151)
        PriceBox.Name = "PriceBox"
        PriceBox.Size = New Size(131, 31)
        PriceBox.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(91, 108)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 25)
        Label1.TabIndex = 1
        Label1.Text = "Producto"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(91, 157)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 25)
        Label2.TabIndex = 1
        Label2.Text = "Precio"
        ' 
        ' InsertButton
        ' 
        InsertButton.Location = New Point(281, 234)
        InsertButton.Name = "InsertButton"
        InsertButton.Size = New Size(150, 49)
        InsertButton.TabIndex = 2
        InsertButton.Text = "Añadir Producto"
        InsertButton.UseVisualStyleBackColor = True
        ' 
        ' ListBox
        ' 
        ListBox.Location = New Point(514, 102)
        ListBox.Multiline = True
        ListBox.Name = "ListBox"
        ListBox.Size = New Size(553, 237)
        ListBox.TabIndex = 3
        ' 
        ' ListButton
        ' 
        ListButton.Location = New Point(281, 297)
        ListButton.Name = "ListButton"
        ListButton.Size = New Size(150, 42)
        ListButton.TabIndex = 4
        ListButton.Text = "Listado"
        ListButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1123, 380)
        Controls.Add(ListButton)
        Controls.Add(ListBox)
        Controls.Add(InsertButton)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PriceBox)
        Controls.Add(ProductBox)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProductBox As TextBox
    Friend WithEvents PriceBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents InsertButton As Button
    Friend WithEvents ListBox As TextBox
    Friend WithEvents ListButton As Button

End Class
