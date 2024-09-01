<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Star = New System.Windows.Forms.Button()
        Me.CarroAzulAbj = New System.Windows.Forms.PictureBox()
        Me.CarroRojoArriba = New System.Windows.Forms.PictureBox()
        Me.CarroVerdIzq = New System.Windows.Forms.PictureBox()
        Me.CarroVerdeDer = New System.Windows.Forms.PictureBox()
        Me.DerRoja = New System.Windows.Forms.PictureBox()
        Me.DerVerde = New System.Windows.Forms.PictureBox()
        Me.DerAmarillo = New System.Windows.Forms.PictureBox()
        Me.IzqVerde = New System.Windows.Forms.PictureBox()
        Me.IzqAmarillo = New System.Windows.Forms.PictureBox()
        Me.IzqRoja = New System.Windows.Forms.PictureBox()
        Me.AbjRoja = New System.Windows.Forms.PictureBox()
        Me.ArrRoja = New System.Windows.Forms.PictureBox()
        Me.AbjAmarillo = New System.Windows.Forms.PictureBox()
        Me.ArrAmarillo = New System.Windows.Forms.PictureBox()
        Me.ArrVerde = New System.Windows.Forms.PictureBox()
        Me.AbjVerde = New System.Windows.Forms.PictureBox()
        Me.Timer_semaforos = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_semaforos2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_carro1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.CarroAzulAbj, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarroRojoArriba, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarroVerdIzq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarroVerdeDer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DerRoja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DerVerde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DerAmarillo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IzqVerde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IzqAmarillo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IzqRoja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbjRoja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArrRoja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbjAmarillo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArrAmarillo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArrVerde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbjVerde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btn_Salir)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Btn_Star)
        Me.GroupBox1.Location = New System.Drawing.Point(866, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 125)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Location = New System.Drawing.Point(6, 88)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(188, 31)
        Me.Btn_Salir.TabIndex = 3
        Me.Btn_Salir.Text = "SALIR"
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CONTROLES"
        '
        'Btn_Star
        '
        Me.Btn_Star.Location = New System.Drawing.Point(6, 33)
        Me.Btn_Star.Name = "Btn_Star"
        Me.Btn_Star.Size = New System.Drawing.Size(188, 49)
        Me.Btn_Star.TabIndex = 0
        Me.Btn_Star.Text = "Iniciar"
        Me.Btn_Star.UseVisualStyleBackColor = True
        '
        'CarroAzulAbj
        '
        Me.CarroAzulAbj.BackColor = System.Drawing.Color.Transparent
        Me.CarroAzulAbj.Image = Global.semaforos.My.Resources.Resources.carroazul
        Me.CarroAzulAbj.Location = New System.Drawing.Point(560, 636)
        Me.CarroAzulAbj.Name = "CarroAzulAbj"
        Me.CarroAzulAbj.Size = New System.Drawing.Size(34, 59)
        Me.CarroAzulAbj.TabIndex = 1
        Me.CarroAzulAbj.TabStop = False
        '
        'CarroRojoArriba
        '
        Me.CarroRojoArriba.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CarroRojoArriba.BackColor = System.Drawing.Color.Transparent
        Me.CarroRojoArriba.Image = Global.semaforos.My.Resources.Resources.carrorojo
        Me.CarroRojoArriba.Location = New System.Drawing.Point(501, 12)
        Me.CarroRojoArriba.Name = "CarroRojoArriba"
        Me.CarroRojoArriba.Size = New System.Drawing.Size(34, 59)
        Me.CarroRojoArriba.TabIndex = 2
        Me.CarroRojoArriba.TabStop = False
        '
        'CarroVerdIzq
        '
        Me.CarroVerdIzq.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CarroVerdIzq.BackColor = System.Drawing.Color.Transparent
        Me.CarroVerdIzq.Image = Global.semaforos.My.Resources.Resources.carroverde
        Me.CarroVerdIzq.Location = New System.Drawing.Point(37, 371)
        Me.CarroVerdIzq.Name = "CarroVerdIzq"
        Me.CarroVerdIzq.Size = New System.Drawing.Size(57, 36)
        Me.CarroVerdIzq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CarroVerdIzq.TabIndex = 3
        Me.CarroVerdIzq.TabStop = False
        '
        'CarroVerdeDer
        '
        Me.CarroVerdeDer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CarroVerdeDer.BackColor = System.Drawing.Color.Transparent
        Me.CarroVerdeDer.Image = Global.semaforos.My.Resources.Resources.carroverdeiz
        Me.CarroVerdeDer.Location = New System.Drawing.Point(816, 319)
        Me.CarroVerdeDer.Name = "CarroVerdeDer"
        Me.CarroVerdeDer.Size = New System.Drawing.Size(59, 35)
        Me.CarroVerdeDer.TabIndex = 4
        Me.CarroVerdeDer.TabStop = False
        '
        'DerRoja
        '
        Me.DerRoja.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DerRoja.BackColor = System.Drawing.Color.Transparent
        Me.DerRoja.Image = Global.semaforos.My.Resources.Resources.roja
        Me.DerRoja.Location = New System.Drawing.Point(648, 254)
        Me.DerRoja.Name = "DerRoja"
        Me.DerRoja.Size = New System.Drawing.Size(38, 40)
        Me.DerRoja.TabIndex = 5
        Me.DerRoja.TabStop = False
        '
        'DerVerde
        '
        Me.DerVerde.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DerVerde.BackColor = System.Drawing.Color.Transparent
        Me.DerVerde.Image = Global.semaforos.My.Resources.Resources.verde
        Me.DerVerde.Location = New System.Drawing.Point(718, 254)
        Me.DerVerde.Name = "DerVerde"
        Me.DerVerde.Size = New System.Drawing.Size(38, 40)
        Me.DerVerde.TabIndex = 6
        Me.DerVerde.TabStop = False
        '
        'DerAmarillo
        '
        Me.DerAmarillo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DerAmarillo.BackColor = System.Drawing.Color.Transparent
        Me.DerAmarillo.Image = Global.semaforos.My.Resources.Resources.amarilla
        Me.DerAmarillo.Location = New System.Drawing.Point(683, 254)
        Me.DerAmarillo.Name = "DerAmarillo"
        Me.DerAmarillo.Size = New System.Drawing.Size(37, 40)
        Me.DerAmarillo.TabIndex = 7
        Me.DerAmarillo.TabStop = False
        '
        'IzqVerde
        '
        Me.IzqVerde.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IzqVerde.BackColor = System.Drawing.Color.Transparent
        Me.IzqVerde.Image = Global.semaforos.My.Resources.Resources.verde
        Me.IzqVerde.Location = New System.Drawing.Point(337, 437)
        Me.IzqVerde.Name = "IzqVerde"
        Me.IzqVerde.Size = New System.Drawing.Size(38, 40)
        Me.IzqVerde.TabIndex = 8
        Me.IzqVerde.TabStop = False
        '
        'IzqAmarillo
        '
        Me.IzqAmarillo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IzqAmarillo.BackColor = System.Drawing.Color.Transparent
        Me.IzqAmarillo.Image = Global.semaforos.My.Resources.Resources.amarilla
        Me.IzqAmarillo.Location = New System.Drawing.Point(372, 437)
        Me.IzqAmarillo.Name = "IzqAmarillo"
        Me.IzqAmarillo.Size = New System.Drawing.Size(38, 40)
        Me.IzqAmarillo.TabIndex = 9
        Me.IzqAmarillo.TabStop = False
        '
        'IzqRoja
        '
        Me.IzqRoja.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IzqRoja.BackColor = System.Drawing.Color.Transparent
        Me.IzqRoja.Image = Global.semaforos.My.Resources.Resources.roja
        Me.IzqRoja.Location = New System.Drawing.Point(407, 438)
        Me.IzqRoja.Name = "IzqRoja"
        Me.IzqRoja.Size = New System.Drawing.Size(38, 40)
        Me.IzqRoja.TabIndex = 10
        Me.IzqRoja.TabStop = False
        '
        'AbjRoja
        '
        Me.AbjRoja.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AbjRoja.BackColor = System.Drawing.Color.Transparent
        Me.AbjRoja.Image = Global.semaforos.My.Resources.Resources.roja
        Me.AbjRoja.Location = New System.Drawing.Point(619, 468)
        Me.AbjRoja.Name = "AbjRoja"
        Me.AbjRoja.Size = New System.Drawing.Size(38, 40)
        Me.AbjRoja.TabIndex = 11
        Me.AbjRoja.TabStop = False
        '
        'ArrRoja
        '
        Me.ArrRoja.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ArrRoja.BackColor = System.Drawing.Color.Transparent
        Me.ArrRoja.Image = Global.semaforos.My.Resources.Resources.roja
        Me.ArrRoja.Location = New System.Drawing.Point(433, 232)
        Me.ArrRoja.Name = "ArrRoja"
        Me.ArrRoja.Size = New System.Drawing.Size(38, 40)
        Me.ArrRoja.TabIndex = 12
        Me.ArrRoja.TabStop = False
        '
        'AbjAmarillo
        '
        Me.AbjAmarillo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AbjAmarillo.BackColor = System.Drawing.Color.Transparent
        Me.AbjAmarillo.Image = Global.semaforos.My.Resources.Resources.amarilla
        Me.AbjAmarillo.Location = New System.Drawing.Point(619, 503)
        Me.AbjAmarillo.Name = "AbjAmarillo"
        Me.AbjAmarillo.Size = New System.Drawing.Size(38, 40)
        Me.AbjAmarillo.TabIndex = 13
        Me.AbjAmarillo.TabStop = False
        '
        'ArrAmarillo
        '
        Me.ArrAmarillo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ArrAmarillo.BackColor = System.Drawing.Color.Transparent
        Me.ArrAmarillo.Image = Global.semaforos.My.Resources.Resources.amarilla
        Me.ArrAmarillo.Location = New System.Drawing.Point(432, 197)
        Me.ArrAmarillo.Name = "ArrAmarillo"
        Me.ArrAmarillo.Size = New System.Drawing.Size(38, 37)
        Me.ArrAmarillo.TabIndex = 14
        Me.ArrAmarillo.TabStop = False
        '
        'ArrVerde
        '
        Me.ArrVerde.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ArrVerde.BackColor = System.Drawing.Color.Transparent
        Me.ArrVerde.Image = Global.semaforos.My.Resources.Resources.verde
        Me.ArrVerde.Location = New System.Drawing.Point(432, 163)
        Me.ArrVerde.Name = "ArrVerde"
        Me.ArrVerde.Size = New System.Drawing.Size(38, 36)
        Me.ArrVerde.TabIndex = 15
        Me.ArrVerde.TabStop = False
        '
        'AbjVerde
        '
        Me.AbjVerde.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AbjVerde.BackColor = System.Drawing.Color.Transparent
        Me.AbjVerde.Image = Global.semaforos.My.Resources.Resources.verde
        Me.AbjVerde.Location = New System.Drawing.Point(619, 537)
        Me.AbjVerde.Name = "AbjVerde"
        Me.AbjVerde.Size = New System.Drawing.Size(38, 40)
        Me.AbjVerde.TabIndex = 16
        Me.AbjVerde.TabStop = False
        '
        'Timer_semaforos
        '
        Me.Timer_semaforos.Interval = 3000
        '
        'Timer_semaforos2
        '
        Me.Timer_semaforos2.Interval = 300
        '
        'Timer_carro1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.semaforos.My.Resources.Resources.semaforo1
        Me.ClientSize = New System.Drawing.Size(1078, 719)
        Me.ControlBox = False
        Me.Controls.Add(Me.AbjVerde)
        Me.Controls.Add(Me.ArrVerde)
        Me.Controls.Add(Me.ArrAmarillo)
        Me.Controls.Add(Me.AbjAmarillo)
        Me.Controls.Add(Me.ArrRoja)
        Me.Controls.Add(Me.AbjRoja)
        Me.Controls.Add(Me.IzqRoja)
        Me.Controls.Add(Me.IzqAmarillo)
        Me.Controls.Add(Me.IzqVerde)
        Me.Controls.Add(Me.DerAmarillo)
        Me.Controls.Add(Me.DerVerde)
        Me.Controls.Add(Me.DerRoja)
        Me.Controls.Add(Me.CarroVerdeDer)
        Me.Controls.Add(Me.CarroVerdIzq)
        Me.Controls.Add(Me.CarroRojoArriba)
        Me.Controls.Add(Me.CarroAzulAbj)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cruce de Vehiculos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.CarroAzulAbj, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarroRojoArriba, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarroVerdIzq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarroVerdeDer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DerRoja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DerVerde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DerAmarillo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IzqVerde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IzqAmarillo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IzqRoja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbjRoja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArrRoja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbjAmarillo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArrAmarillo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArrVerde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbjVerde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Btn_Salir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Star As Button
    Friend WithEvents CarroAzulAbj As PictureBox
    Friend WithEvents CarroRojoArriba As PictureBox
    Friend WithEvents CarroVerdIzq As PictureBox
    Friend WithEvents CarroVerdeDer As PictureBox
    Friend WithEvents DerRoja As PictureBox
    Friend WithEvents DerVerde As PictureBox
    Friend WithEvents DerAmarillo As PictureBox
    Friend WithEvents IzqVerde As PictureBox
    Friend WithEvents IzqAmarillo As PictureBox
    Friend WithEvents IzqRoja As PictureBox
    Friend WithEvents AbjRoja As PictureBox
    Friend WithEvents ArrRoja As PictureBox
    Friend WithEvents AbjAmarillo As PictureBox
    Friend WithEvents ArrAmarillo As PictureBox
    Friend WithEvents ArrVerde As PictureBox
    Friend WithEvents AbjVerde As PictureBox
    Friend WithEvents Timer_semaforos As Timer
    Friend WithEvents Timer_semaforos2 As Timer
    Friend WithEvents Timer_carro1 As Timer
End Class
