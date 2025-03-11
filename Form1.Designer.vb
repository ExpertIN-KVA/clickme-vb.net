<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Impact", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(12, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(226, 69)
        Button1.TabIndex = 0
        Button1.Text = "0"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Impact", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(12, 87)
        Button2.Name = "Button2"
        Button2.Size = New Size(226, 69)
        Button2.TabIndex = 1
        Button2.Text = "5"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Impact", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(12, 162)
        Button3.Name = "Button3"
        Button3.Size = New Size(226, 69)
        Button3.TabIndex = 2
        Button3.Text = "Reset"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ClientSize = New Size(247, 239)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Click me"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Timer1 As Timer

End Class
