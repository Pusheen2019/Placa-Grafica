<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupComponentes = New System.Windows.Forms.GroupBox()
        Me.CheckPlacadeRede = New System.Windows.Forms.CheckBox()
        Me.CheckMemoria = New System.Windows.Forms.CheckBox()
        Me.CheckPlacaGrafica = New System.Windows.Forms.CheckBox()
        Me.GroupCor = New System.Windows.Forms.GroupBox()
        Me.RadiobtnCinzento = New System.Windows.Forms.RadioButton()
        Me.RadiobtnPreto = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsair = New System.Windows.Forms.Button()
        Me.Btnaceitar = New System.Windows.Forms.Button()
        Me.brnreconfigurar = New System.Windows.Forms.Button()
        Me.picturebox2 = New System.Windows.Forms.PictureBox()
        Me.GroupComponentes.SuspendLayout()
        Me.GroupCor.SuspendLayout()
        CType(Me.picturebox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupComponentes
        '
        Me.GroupComponentes.Controls.Add(Me.CheckPlacadeRede)
        Me.GroupComponentes.Controls.Add(Me.CheckMemoria)
        Me.GroupComponentes.Controls.Add(Me.CheckPlacaGrafica)
        Me.GroupComponentes.Location = New System.Drawing.Point(336, 40)
        Me.GroupComponentes.Name = "GroupComponentes"
        Me.GroupComponentes.Size = New System.Drawing.Size(180, 157)
        Me.GroupComponentes.TabIndex = 1
        Me.GroupComponentes.TabStop = False
        Me.GroupComponentes.Text = "Componentes Adicionais"
        '
        'CheckPlacadeRede
        '
        Me.CheckPlacadeRede.AutoSize = True
        Me.CheckPlacadeRede.Location = New System.Drawing.Point(11, 133)
        Me.CheckPlacadeRede.Name = "CheckPlacadeRede"
        Me.CheckPlacadeRede.Size = New System.Drawing.Size(97, 17)
        Me.CheckPlacadeRede.TabIndex = 2
        Me.CheckPlacadeRede.Text = "Placa de Rede"
        Me.CheckPlacadeRede.UseVisualStyleBackColor = True
        '
        'CheckMemoria
        '
        Me.CheckMemoria.AutoSize = True
        Me.CheckMemoria.Location = New System.Drawing.Point(11, 81)
        Me.CheckMemoria.Name = "CheckMemoria"
        Me.CheckMemoria.Size = New System.Drawing.Size(117, 17)
        Me.CheckMemoria.TabIndex = 1
        Me.CheckMemoria.Text = "Mais 1 Gb Memória"
        Me.CheckMemoria.UseVisualStyleBackColor = True
        '
        'CheckPlacaGrafica
        '
        Me.CheckPlacaGrafica.AutoSize = True
        Me.CheckPlacaGrafica.Location = New System.Drawing.Point(11, 32)
        Me.CheckPlacaGrafica.Name = "CheckPlacaGrafica"
        Me.CheckPlacaGrafica.Size = New System.Drawing.Size(90, 17)
        Me.CheckPlacaGrafica.TabIndex = 0
        Me.CheckPlacaGrafica.Text = "Placa Gráfica"
        Me.CheckPlacaGrafica.UseVisualStyleBackColor = True
        '
        'GroupCor
        '
        Me.GroupCor.Controls.Add(Me.RadiobtnCinzento)
        Me.GroupCor.Controls.Add(Me.RadiobtnPreto)
        Me.GroupCor.Location = New System.Drawing.Point(336, 224)
        Me.GroupCor.Name = "GroupCor"
        Me.GroupCor.Size = New System.Drawing.Size(200, 100)
        Me.GroupCor.TabIndex = 2
        Me.GroupCor.TabStop = False
        Me.GroupCor.Text = "Cor"
        '
        'RadiobtnCinzento
        '
        Me.RadiobtnCinzento.AutoSize = True
        Me.RadiobtnCinzento.Location = New System.Drawing.Point(15, 68)
        Me.RadiobtnCinzento.Name = "RadiobtnCinzento"
        Me.RadiobtnCinzento.Size = New System.Drawing.Size(66, 17)
        Me.RadiobtnCinzento.TabIndex = 1
        Me.RadiobtnCinzento.TabStop = True
        Me.RadiobtnCinzento.Text = "Cinzento"
        Me.RadiobtnCinzento.UseVisualStyleBackColor = True
        '
        'RadiobtnPreto
        '
        Me.RadiobtnPreto.AutoSize = True
        Me.RadiobtnPreto.Location = New System.Drawing.Point(15, 19)
        Me.RadiobtnPreto.Name = "RadiobtnPreto"
        Me.RadiobtnPreto.Size = New System.Drawing.Size(50, 17)
        Me.RadiobtnPreto.TabIndex = 0
        Me.RadiobtnPreto.TabStop = True
        Me.RadiobtnPreto.Text = "Preto"
        Me.RadiobtnPreto.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(25, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Modelo Base - ASUS Terminator 2"
        '
        'btnsair
        '
        Me.btnsair.Location = New System.Drawing.Point(441, 372)
        Me.btnsair.Name = "btnsair"
        Me.btnsair.Size = New System.Drawing.Size(143, 51)
        Me.btnsair.TabIndex = 4
        Me.btnsair.Text = "Sair"
        Me.btnsair.UseVisualStyleBackColor = True
        '
        'Btnaceitar
        '
        Me.Btnaceitar.Enabled = False
        Me.Btnaceitar.Location = New System.Drawing.Point(249, 372)
        Me.Btnaceitar.Name = "Btnaceitar"
        Me.Btnaceitar.Size = New System.Drawing.Size(143, 51)
        Me.Btnaceitar.TabIndex = 5
        Me.Btnaceitar.Text = "Aceitar"
        Me.Btnaceitar.UseVisualStyleBackColor = True
        '
        'brnreconfigurar
        '
        Me.brnreconfigurar.Enabled = False
        Me.brnreconfigurar.Location = New System.Drawing.Point(51, 372)
        Me.brnreconfigurar.Name = "brnreconfigurar"
        Me.brnreconfigurar.Size = New System.Drawing.Size(143, 51)
        Me.brnreconfigurar.TabIndex = 6
        Me.brnreconfigurar.Text = "Reconfigurar"
        Me.brnreconfigurar.UseVisualStyleBackColor = True
        '
        'picturebox2
        '
        Me.picturebox2.Image = Global.ex1.My.Resources.Resources.Terminator_3_P5G965A
        Me.picturebox2.Location = New System.Drawing.Point(28, 72)
        Me.picturebox2.Name = "picturebox2"
        Me.picturebox2.Size = New System.Drawing.Size(200, 200)
        Me.picturebox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picturebox2.TabIndex = 0
        Me.picturebox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 468)
        Me.Controls.Add(Me.brnreconfigurar)
        Me.Controls.Add(Me.Btnaceitar)
        Me.Controls.Add(Me.btnsair)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupCor)
        Me.Controls.Add(Me.GroupComponentes)
        Me.Controls.Add(Me.picturebox2)
        Me.Name = "Form1"
        Me.Text = "Caracteristicas do Computador"
        Me.GroupComponentes.ResumeLayout(False)
        Me.GroupComponentes.PerformLayout()
        Me.GroupCor.ResumeLayout(False)
        Me.GroupCor.PerformLayout()
        CType(Me.picturebox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picturebox2 As PictureBox
    Friend WithEvents GroupComponentes As GroupBox
    Friend WithEvents CheckPlacadeRede As CheckBox
    Friend WithEvents CheckMemoria As CheckBox
    Friend WithEvents CheckPlacaGrafica As CheckBox
    Friend WithEvents GroupCor As GroupBox
    Friend WithEvents RadiobtnCinzento As RadioButton
    Friend WithEvents RadiobtnPreto As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents btnsair As Button
    Friend WithEvents Btnaceitar As Button
    Friend WithEvents brnreconfigurar As Button
End Class
