Public Class Form1
    Private Sub Btnaceitar_Click(sender As Object, e As EventArgs) Handles Btnaceitar.Click
        Dim com As String = ""
        Dim cor As String = ""
        Dim med As String = ""

        If CheckMemoria.Checked Then
            com = com + "Mais 1 GB Memoria,"
        End If

        If CheckPlacaGrafica.Checked Then
            com = com + "Placa Gráfica,"
        End If

        If CheckPlacadeRede.Checked Then
            com = com + "Placa de Rede,"
        End If

        If RadiobtnPreto.Checked Then
            cor = cor + "Preto,"
            med = med + "Modelo Base - ASUS Terminator 2,"

        End If

        If RadiobtnCinzento.Checked Then
            cor = cor + "Cinzento,"
            med = med + "Modelo Base - ASUS Terminator 3,"
        End If

        MessageBox.Show("Modelo:" + med + ";Componentes adicionais:" + com + ";Cor" + cor)
    End Sub

    Private Sub brnreconfigurar_Click(sender As Object, e As EventArgs) Handles brnreconfigurar.Click
        CheckMemoria.Checked = CheckState.Unchecked
        CheckPlacadeRede.Checked = CheckState.Unchecked
        CheckPlacaGrafica.Checked = CheckState.Unchecked
        RadiobtnCinzento.Checked = CheckState.Unchecked
        RadiobtnPreto.Checked = CheckState.Unchecked

        RadiobtnPreto.Checked = CheckState.Checked

        brnreconfigurar.Enabled = False
        Btnaceitar.Enabled = False

    End Sub

    Private Sub btnsair_Click(sender As Object, e As EventArgs) Handles btnsair.Click
        Me.Close()
    End Sub

    Private Sub RadiobtnPreto_CheckedChanged(sender As Object, e As EventArgs) Handles RadiobtnPreto.CheckedChanged
        picturebox2.Image = My.Resources.Terminator_2
        If (CheckPlacaGrafica.Checked = True Or CheckMemoria.Checked = True Or CheckPlacadeRede.Checked = True) Then
            Btnaceitar.Enabled = True
            brnreconfigurar.Enabled = True
        Else
            Btnaceitar.Enabled = False
            brnreconfigurar.Enabled = False
        End If
    End Sub

    Private Sub RadiobtnCinzento_CheckedChanged(sender As Object, e As EventArgs) Handles RadiobtnCinzento.CheckedChanged
        picturebox2.Image = My.Resources.Terminator_3_P5G965A
        If (CheckPlacaGrafica.Checked = True Or CheckMemoria.Checked = True Or CheckPlacadeRede.Checked = True) Then
            Btnaceitar.Enabled = True
            brnreconfigurar.Enabled = True
        Else
            Btnaceitar.Enabled = False
            brnreconfigurar.Enabled = False
        End If
    End Sub

    Private Sub CheckPlacaGrafica_CheckedChanged(sender As Object, e As EventArgs) Handles CheckPlacaGrafica.CheckedChanged
        If (CheckPlacaGrafica.Checked = True Or CheckMemoria.Checked = True Or CheckPlacadeRede.Checked = True) Then
            Btnaceitar.Enabled = True
            brnreconfigurar.Enabled = True
        Else
            Btnaceitar.Enabled = False
            brnreconfigurar.Enabled = False
        End If

    End Sub

    Private Sub CheckMemoria_CheckedChanged(sender As Object, e As EventArgs) Handles CheckMemoria.CheckedChanged
        If (CheckPlacaGrafica.Checked = True Or CheckMemoria.Checked = True Or CheckPlacadeRede.Checked = True) Then
            Btnaceitar.Enabled = True
            brnreconfigurar.Enabled = True
        Else
            Btnaceitar.Enabled = False
            brnreconfigurar.Enabled = False
        End If
    End Sub

    Private Sub CheckPlacadeRede_CheckedChanged(sender As Object, e As EventArgs) Handles CheckPlacadeRede.CheckedChanged
        If (CheckPlacaGrafica.Checked = True Or CheckMemoria.Checked = True Or CheckPlacadeRede.Checked = True) Then
            Btnaceitar.Enabled = True
            brnreconfigurar.Enabled = True
        Else
            Btnaceitar.Enabled = False
            brnreconfigurar.Enabled = False
        End If
    End Sub
End Class
