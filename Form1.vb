
Imports System.Net.Mime.MediaTypeNames

Public Class Form1
    Dim ColorIndex As Integer = 0 'recorre los ciclos de cambios acumulador
    Dim CantColor As Integer = 3   'cantidad de ciclos de cambios
    Dim ColorIndex2 As Integer = 0 'recorre los ciclos de cambios acumulador
    Dim CantColor2 As Integer = 3   'cantidad de ciclos de cambios
    Dim tiempoEspera As Integer = 10 '10x1000 = 10 segundo
    Dim tiempoCambioColor As Integer = 2 '2x1000 = 2 segundo

    Dim Pos_carI As Integer
    Dim Pos_carD As Integer
    Dim Pos_carAr As Integer
    Dim Pos_carAb As Integer
    Dim Velocidad As Integer = 10 '20


    Enum Colores
        Col_Amarillo = 0
        Col_Rojo = 1
        Col_Verde = 2
        Col_espera = 3
    End Enum

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DerRoja.Visible = False
        DerAmarillo.Visible = False
        DerVerde.Visible = False
        IzqRoja.Visible = False
        IzqAmarillo.Visible = False
        IzqVerde.Visible = False
        AbjRoja.Visible = False
        AbjAmarillo.Visible = False
        AbjVerde.Visible = False
        ArrRoja.Visible = False
        ArrAmarillo.Visible = False
        ArrVerde.Visible = False

        Pos_carI = 0 '37
        Pos_carD = 816
        Pos_carAb = 636
        Pos_carAr = 12




    End Sub
    Private Sub Btn_Salir_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click
        Dim result As DialogResult = MessageBox.Show("¿Seguro que desea cerrar el formulario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Sub semaforos(ByVal pictureBox1 As PictureBox, ByVal pictureBox2 As PictureBox, ByVal pictureBox3 As PictureBox, ByVal pictureBox4 As PictureBox, ByVal pictureBox5 As PictureBox, ByVal pictureBox6 As PictureBox)

        ColorIndex += 1
        If ColorIndex >= CantColor Then 'si esta en verde
            ColorIndex = 0
            Timer_semaforos.Interval = tiempoEspera * 1000 + 2000  ' 10 segundos para el siguiente ciclo
        ElseIf ColorIndex >= 2 Then 'si esta en rojo
            Timer_semaforos.Interval = tiempoEspera * 1000    ' 10 segundos para el siguiente ciclo
        Else
            Timer_semaforos.Interval = tiempoCambioColor * 1000
        End If
        ' Oculta todas las imágenes
        pictureBox1.Visible = False
        pictureBox2.Visible = False
        pictureBox3.Visible = False
        pictureBox4.Visible = False
        pictureBox5.Visible = False
        pictureBox6.Visible = False

        ' Muestra la imagen correspondiente al índice actual
        Select Case ColorIndex
            Case 0
                pictureBox1.Visible = True
                pictureBox4.Visible = True
            Case 1
                pictureBox2.Visible = True
                pictureBox5.Visible = True
            Case 2
                pictureBox3.Visible = True
                pictureBox6.Visible = True


        End Select

    End Sub


    Sub semaforos2(ByVal rojo As PictureBox, ByVal amarillo As PictureBox, ByVal verde As PictureBox, ByVal rojo2 As PictureBox, ByVal amarillo2 As PictureBox, ByVal verde2 As PictureBox)
        ' Incrementar ColorIndex2
        ColorIndex2 += 1
        If ColorIndex2 > Colores.Col_Verde Then
            ColorIndex2 = 0
        End If
        ' Establecer el intervalo del Timer según el estado actual
        Select Case ColorIndex2
            Case Colores.Col_Amarillo
                Timer_semaforos2.Interval = tiempoCambioColor * 1000 ' 2 segundos para el color rojo
            Case Colores.Col_Rojo
                Timer_semaforos2.Interval = tiempoEspera * 1000   ' 10 segundos para el color verde
            Case Colores.Col_Verde
                Timer_semaforos2.Interval = tiempoEspera * 1000 + tiempoCambioColor * 1000   ' 14 segundos para el color amarillo
        End Select
        ' Ocultar todas las imágenes
        rojo.Visible = False
        amarillo.Visible = False
        verde.Visible = False
        rojo2.Visible = False
        amarillo2.Visible = False
        verde2.Visible = False
        ' Mostrar la imagen correspondiente al índice actual
        Select Case ColorIndex2
            Case Colores.Col_Amarillo
                amarillo.Visible = True
                amarillo2.Visible = True
            Case Colores.Col_Rojo
                verde.Visible = True
                verde2.Visible = True
            Case Colores.Col_Verde
                rojo.Visible = True
                rojo2.Visible = True
        End Select

    End Sub

    Private Sub Timer_semaforos_Tick(sender As Object, e As EventArgs) Handles Timer_semaforos.Tick
        semaforos(DerRoja, DerAmarillo, DerVerde, IzqRoja, IzqAmarillo, IzqVerde)

    End Sub

    Private Sub Timer_semaforos2_Tick(sender As Object, e As EventArgs) Handles Timer_semaforos2.Tick
        semaforos2(ArrRoja, ArrAmarillo, ArrVerde, AbjRoja, AbjAmarillo, AbjVerde)
    End Sub

    Private Sub Btn_Star_Click(sender As Object, e As EventArgs) Handles Btn_Star.Click

        Timer_semaforos.Interval = 100  ' 3 segundos
        AddHandler Timer_semaforos.Tick, AddressOf Timer_semaforos_Tick
        Timer_semaforos.Start()

        Timer_semaforos2.Interval = 100  ' 3 segundos
        AddHandler Timer_semaforos2.Tick, AddressOf Timer_semaforos2_Tick
        Timer_semaforos2.Start()

        Timer_carro1.Interval = 100  ' 3 segundos
        AddHandler Timer_carro1.Tick, AddressOf Timer_carro1_Tick
        Timer_carro1.Start()
        Btn_Star.Enabled = False
    End Sub

    Private Sub Timer_carro1_Tick(sender As Object, e As EventArgs) Handles Timer_carro1.Tick
        'Carro derecho 
        CarroVerdIzq.Location = New Point(Pos_carI, 371)
        If CarroVerdIzq.Location.X >= 375 AndAlso CarroVerdIzq.Location.X <= 385 AndAlso IzqRoja.Visible Then
            Console.WriteLine("Deteniendo vehiculo esta en rojo el semaro.")
        Else
            If CarroVerdIzq.Location.X > 1080 Then
                Pos_carI = 0 '37
            End If
            Pos_carI = Pos_carI + Velocidad
        End If

        'Carro Izquierdo 
        CarroVerdeDer.Location = New Point(Pos_carD, 319)
        If CarroVerdeDer.Location.X >= 650 AndAlso CarroVerdeDer.Location.X <= 660 AndAlso DerRoja.Visible Then
            Console.WriteLine("Deteniendo vehiculo esta en rojo el semaro.")
        Else
            If CarroVerdeDer.Location.X <= 0 Then
                Pos_carD = 1080
            End If
            Pos_carD = Pos_carD - Velocidad
        End If

        'Carro Arriba 
        CarroRojoArriba.Location = New Point(501, Pos_carAr)
        If CarroRojoArriba.Location.Y >= 191 AndAlso CarroRojoArriba.Location.Y <= 204 AndAlso ArrRoja.Visible Then
            Console.WriteLine("Deteniendo vehiculo esta en rojo el semaro.")
        Else

            If CarroRojoArriba.Location.Y >= 700 Then
                Pos_carAr = 0
            End If
            Pos_carAr = Pos_carAr + Velocidad
        End If

        'Carro Abajo 
        CarroAzulAbj.Location = New Point(560, Pos_carAb)
        If CarroAzulAbj.Location.Y >= 460 AndAlso CarroAzulAbj.Location.Y <= 470 AndAlso AbjRoja.Visible Then
            Console.WriteLine("Deteniendo vehiculo esta en rojo el semaro.")
        Else
            If CarroAzulAbj.Location.Y <= 0 Then
                Pos_carAb = 700
            End If
            Pos_carAb = Pos_carAb - Velocidad
        End If
    End Sub


End Class
