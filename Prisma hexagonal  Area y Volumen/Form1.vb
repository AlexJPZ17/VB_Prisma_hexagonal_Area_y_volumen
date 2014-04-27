Public Class Form1
    'Declaramos las siguientes variables 
    Dim perimetro As Double
    Dim adyacente As Double
    Dim apotema As Double
    Dim volumen As Double
    Dim areaBase As Double
    Dim areaLateral As Double
    Dim altura As Double
    Dim areaTotal As Double
    Dim lado As Double

    Private Sub PrismaHexagonal()
        Try
            'calculamos la hipotenusa y el lado adyacente del triángulo 
            'para calcular  la apotema
            lado = Convert.ToDouble(TextBox_Lado.Text)
            adyacente = lado / 2
            perimetro = lado * 6
            Label_adyacente.Text = adyacente & " cm"
            Label_hipotenusa.Text = lado & " cm"
            'calculamos el área lateral del prisma hexagonal 
            altura = Convert.ToDouble(TextBox_ALtura.Text)
            areaLateral = perimetro * altura
            Label_AreaLateral.Text = areaLateral & " cm²"
        Catch ex As Exception

        End Try
        'calculamos la apotema del prisma hexagonal 
        apotema = Math.Sqrt(Math.Pow(lado, 2) - Math.Pow(adyacente, 2))
        Label_Pitagora.Text = lado & "²" & " - " & adyacente & "² = " & apotema & " a"
        'calculamos el área base  del prisma hexagonal 
        areaBase = perimetro * apotema / 2
        Label_AreaBase.Text = areaBase & " cm²"
        'calculamos el área total del prisma hexagonal 
        areaTotal = areaLateral + 2 * areaBase
        Label_AreaTolal.Text = areaTotal & " cm²"
        'calculamos el volumen del prisma hexagonal 
        volumen = areaBase * altura
        Label_Volumen.Text = volumen & " cm³"

        If TextBox_Lado.Text = "" Then
            Label_adyacente.Text = 0 & " cm"
            Label_hipotenusa.Text = 0 & " cm"
            Label_AreaBase.Text = 0 & " cm²"
            Label_AreaTolal.Text = 0 & " cm²"
            Label_Pitagora.Text = "0² - 0²"
        End If
        If TextBox_ALtura.Text = "" Then
            Label_AreaLateral.Text = 0 & " cm²"
            Label_Volumen.Text = 0 & " cm³"

        End If

    End Sub

    Private Sub TextBox_ALtura_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox_ALtura.KeyUp
        PrismaHexagonal()
    End Sub

    Private Sub TextBox_Lado_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox_Lado.KeyUp
        PrismaHexagonal()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LinkLabel1.Links.Add(9, 8, "")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("www.youtube.com/alexjpz17")
    End Sub
End Class
