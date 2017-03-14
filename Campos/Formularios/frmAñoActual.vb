Imports Clases
Public Class frmAñoActual
    Dim campos As New List(Of Campo)
    Dim plantaciones As New List(Of Plantacion)
    Dim cultivos As New List(Of Cultivo)

    Private Sub frmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cultivos = trat.cargarCultivos
        campos = trat.CargarCampos
        plantaciones = trat.CargarPlantacionesPorAño(System.DateTime.Today.Year)
        For Each campo In campos
            lstboxNombre.Items.Add(campo.Nombre)
            lstboxParcela.Items.Add(campo.Parcela)
            lstboxPoligono.Items.Add(campo.Poligono)
            lstboxSuperficie.Items.Add(campo.Superficie)

            For Each plantacion In plantaciones
                If plantacion.IdCampo = campo.ID Then
                    lstboxAbonoYKilos.Items.Add(plantacion.Abono & " " & plantacion.KilosAbono & " Kilos")
                    lstboxMalasHierbas.Items.Add(plantacion.MalasHierbas)
                    lstboxTratamientos.Items.Add(plantacion.Tratamiento)
                    lstboxLabores.Items.Add(plantacion.Labores)
                    plantaciones.Remove(plantacion)
                    For Each cultivo In cultivos
                        If cultivo.ID = plantacion.IdCultivo Then
                            lstboxCultivoTipo.Items.Add(cultivo.Tipo)
                            lstboxCultivoVariedad.Items.Add(cultivo.Variedad)
                        End If
                    Next
                    Exit For
                Else
                    lstboxCultivoTipo.Items.Add("----")
                    lstboxAbonoYKilos.Items.Add("----")
                    lstboxMalasHierbas.Items.Add("----")
                    lstboxTratamientos.Items.Add("----")
                    lstboxLabores.Items.Add("----")
                    lstboxCultivoVariedad.Items.Add("----")
                End If

            Next
        Next
        lblTitulo.Text = lblTitulo.Text & " " & System.DateTime.Today.Year
    End Sub

    Private Sub lstboxSelectedIndexChanged(sender As Object, e As EventArgs) Handles lstboxPoligono.SelectedIndexChanged, lstboxAbonoYKilos.SelectedIndexChanged, lstboxCultivoTipo.SelectedIndexChanged, lstboxCultivoVariedad.SelectedIndexChanged, lstboxLabores.SelectedIndexChanged, lstboxMalasHierbas.SelectedIndexChanged, lstboxNombre.SelectedIndexChanged, lstboxParcela.SelectedIndexChanged, lstboxSuperficie.SelectedIndexChanged, lstboxTratamientos.SelectedIndexChanged
        Dim lstbox As ListBox = TryCast(sender, ListBox)
        lstboxAbonoYKilos.SelectedIndex = lstbox.SelectedIndex
        lstboxCultivoTipo.SelectedIndex = lstbox.SelectedIndex
        lstboxCultivoVariedad.SelectedIndex = lstbox.SelectedIndex
        lstboxLabores.SelectedIndex = lstbox.SelectedIndex
        lstboxMalasHierbas.SelectedIndex = lstbox.SelectedIndex
        lstboxNombre.SelectedIndex = lstbox.SelectedIndex
        lstboxParcela.SelectedIndex = lstbox.SelectedIndex
        lstboxPoligono.SelectedIndex = lstbox.SelectedIndex
        lstboxSuperficie.SelectedIndex = lstbox.SelectedIndex
        lstboxTratamientos.SelectedIndex = lstbox.SelectedIndex
    End Sub

End Class