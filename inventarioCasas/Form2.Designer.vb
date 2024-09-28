<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Button1 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Button2 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(5), CByte(29), CByte(101))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(34, 23)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 30)
        Button1.TabIndex = 0
        Button1.Text = "<"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(239, 110)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(174, 23)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(239, 155)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(174, 23)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(239, 203)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(174, 23)
        TextBox3.TabIndex = 3
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(239, 251)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(174, 23)
        TextBox4.TabIndex = 4
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(239, 302)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(174, 23)
        TextBox5.TabIndex = 5
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(5), CByte(29), CByte(101))
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(34, 368)
        Button2.Name = "Button2"
        Button2.Size = New Size(379, 29)
        Button2.TabIndex = 6
        Button2.Text = "Guardar Datos"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 9F)
        Label1.ForeColor = Color.FromArgb(CByte(5), CByte(29), CByte(101))
        Label1.Location = New Point(34, 109)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 17)
        Label1.TabIndex = 7
        Label1.Text = "Nombre de la Casa"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 9F)
        Label2.ForeColor = Color.FromArgb(CByte(5), CByte(29), CByte(101))
        Label2.Location = New Point(34, 157)
        Label2.Name = "Label2"
        Label2.Size = New Size(135, 17)
        Label2.TabIndex = 8
        Label2.Text = "Ubicacion de la Casa"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(5), CByte(29), CByte(101))
        Label3.Location = New Point(34, 205)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 17)
        Label3.TabIndex = 9
        Label3.Text = "Precio"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 9F)
        Label4.ForeColor = Color.FromArgb(CByte(5), CByte(29), CByte(101))
        Label4.Location = New Point(34, 253)
        Label4.Name = "Label4"
        Label4.Size = New Size(186, 17)
        Label4.TabIndex = 10
        Label4.Text = "Metros Cuadrados del Terreno"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 9F)
        Label5.ForeColor = Color.FromArgb(CByte(5), CByte(29), CByte(101))
        Label5.Location = New Point(34, 304)
        Label5.Name = "Label5"
        Label5.Size = New Size(199, 17)
        Label5.TabIndex = 11
        Label5.Text = "Metros Cuadrados Construcción"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(454, 461)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
