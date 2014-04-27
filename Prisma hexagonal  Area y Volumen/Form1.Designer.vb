<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label_hipotenusa = New System.Windows.Forms.Label()
        Me.TextBox_Lado = New System.Windows.Forms.TextBox()
        Me.TextBox_ALtura = New System.Windows.Forms.TextBox()
        Me.Label_adyacente = New System.Windows.Forms.Label()
        Me.Label_Pitagora = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label_Volumen = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label_AreaBase = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label_AreaLateral = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label_AreaTolal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(29, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(268, 273)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "cm"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "cm"
        '
        'Label_hipotenusa
        '
        Me.Label_hipotenusa.AutoSize = True
        Me.Label_hipotenusa.Location = New System.Drawing.Point(262, 240)
        Me.Label_hipotenusa.Name = "Label_hipotenusa"
        Me.Label_hipotenusa.Size = New System.Drawing.Size(34, 15)
        Me.Label_hipotenusa.TabIndex = 4
        Me.Label_hipotenusa.Text = "0 cm"
        '
        'TextBox_Lado
        '
        Me.TextBox_Lado.Location = New System.Drawing.Point(61, 189)
        Me.TextBox_Lado.Name = "TextBox_Lado"
        Me.TextBox_Lado.Size = New System.Drawing.Size(38, 20)
        Me.TextBox_Lado.TabIndex = 2
        '
        'TextBox_ALtura
        '
        Me.TextBox_ALtura.Location = New System.Drawing.Point(12, 134)
        Me.TextBox_ALtura.Name = "TextBox_ALtura"
        Me.TextBox_ALtura.Size = New System.Drawing.Size(46, 20)
        Me.TextBox_ALtura.TabIndex = 1
        '
        'Label_adyacente
        '
        Me.Label_adyacente.AutoSize = True
        Me.Label_adyacente.Location = New System.Drawing.Point(241, 296)
        Me.Label_adyacente.Name = "Label_adyacente"
        Me.Label_adyacente.Size = New System.Drawing.Size(34, 15)
        Me.Label_adyacente.TabIndex = 8
        Me.Label_adyacente.Text = "0 cm"
        '
        'Label_Pitagora
        '
        Me.Label_Pitagora.AutoSize = True
        Me.Label_Pitagora.Location = New System.Drawing.Point(49, 281)
        Me.Label_Pitagora.Name = "Label_Pitagora"
        Me.Label_Pitagora.Size = New System.Drawing.Size(39, 15)
        Me.Label_Pitagora.TabIndex = 9
        Me.Label_Pitagora.Text = "0² - 0²"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 281)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "√"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "_______________"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 281)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "a = "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(117, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Volumen:"
        '
        'Label_Volumen
        '
        Me.Label_Volumen.AutoSize = True
        Me.Label_Volumen.Location = New System.Drawing.Point(196, 73)
        Me.Label_Volumen.Name = "Label_Volumen"
        Me.Label_Volumen.Size = New System.Drawing.Size(38, 15)
        Me.Label_Volumen.TabIndex = 14
        Me.Label_Volumen.Text = "0 cm³"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(117, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Area base:"
        '
        'Label_AreaBase
        '
        Me.Label_AreaBase.AutoSize = True
        Me.Label_AreaBase.Location = New System.Drawing.Point(197, 26)
        Me.Label_AreaBase.Name = "Label_AreaBase"
        Me.Label_AreaBase.Size = New System.Drawing.Size(38, 15)
        Me.Label_AreaBase.TabIndex = 16
        Me.Label_AreaBase.Text = "0 cm²"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(115, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 15)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Area lateral:"
        '
        'Label_AreaLateral
        '
        Me.Label_AreaLateral.AutoSize = True
        Me.Label_AreaLateral.Location = New System.Drawing.Point(196, 42)
        Me.Label_AreaLateral.Name = "Label_AreaLateral"
        Me.Label_AreaLateral.Size = New System.Drawing.Size(38, 15)
        Me.Label_AreaLateral.TabIndex = 18
        Me.Label_AreaLateral.Text = "0 cm²"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(117, 56)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(62, 15)
        Me.Label.TabIndex = 19
        Me.Label.Text = "Area Total"
        '
        'Label_AreaTolal
        '
        Me.Label_AreaTolal.AutoSize = True
        Me.Label_AreaTolal.Location = New System.Drawing.Point(197, 58)
        Me.Label_AreaTolal.Name = "Label_AreaTolal"
        Me.Label_AreaTolal.Size = New System.Drawing.Size(41, 15)
        Me.Label_AreaTolal.TabIndex = 20
        Me.Label_AreaTolal.Text = "0  cm²"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(93, 353)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 15)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "©Programadores HN"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(80, 326)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(154, 15)
        Me.LinkLabel1.TabIndex = 22
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Para mas videos tutoriales."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(47, 258)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 15)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Teorema de pitágoras"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(363, 377)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label_AreaTolal)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Label_AreaLateral)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label_AreaBase)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label_Volumen)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label_Pitagora)
        Me.Controls.Add(Me.Label_adyacente)
        Me.Controls.Add(Me.TextBox_ALtura)
        Me.Controls.Add(Me.TextBox_Lado)
        Me.Controls.Add(Me.Label_hipotenusa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prisma hexagonal"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label_hipotenusa As System.Windows.Forms.Label
    Friend WithEvents TextBox_Lado As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_ALtura As System.Windows.Forms.TextBox
    Friend WithEvents Label_adyacente As System.Windows.Forms.Label
    Friend WithEvents Label_Pitagora As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label_Volumen As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label_AreaBase As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label_AreaLateral As System.Windows.Forms.Label
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents Label_AreaTolal As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label10 As System.Windows.Forms.Label

End Class
