Imports Clases
Public Class Tratamiento
    Dim cadCon As String = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =CamposBD.accdb"
    Dim conBD As New OleDb.OleDbConnection(cadCon)

    Public Function CargarCampos() As List(Of Campo)
        Dim campos As New List(Of Campo)
        conBD.Open()
        Dim sql As String = "SELECT * FROM Campos"
        Dim selectCampos As New OleDb.OleDbCommand(sql, conBD)
        Dim dr As OleDb.OleDbDataReader = selectCampos.ExecuteReader
        While dr.Read
            Dim campoLeido As New Campo
            campoLeido.ID = dr.Item("ID")
            campoLeido.Nombre = dr.Item("Nombre")
            campoLeido.Parcela = dr.Item("Parcela")
            campoLeido.Poligono = dr.Item("Poligono")
            campoLeido.Superficie = dr.Item("Superficie")
            campos.Add(campoLeido)
        End While
        conBD.Close()
        Return campos
    End Function

    Public Function CargarPlantacionesPorAño(ByVal año As Integer) As List(Of Plantacion)
        Dim plantaciones As New List(Of Plantacion)
        conBD.Open()
        Dim sql As String = "SELECT * FROM Plantaciones WHERE (Plantaciones.Año)=Year(Date$())"
        Dim selectPlantaciones As New OleDb.OleDbCommand(sql, conBD)
        Dim dr As OleDb.OleDbDataReader = selectPlantaciones.ExecuteReader
        While dr.Read
            Dim plantacionLeida As New Plantacion
            plantacionLeida.Año = dr.Item("Año")
            plantacionLeida.IdCampo = dr.Item("IdCampo")
            plantacionLeida.IdCultivo = dr.Item("IdCultivo")
            plantacionLeida.MalasHierbas = dr.Item("MalasHierbas")
            plantacionLeida.Abono = dr.Item("Abono")
            plantacionLeida.KilosAbono = dr.Item("KilosAbono")
            plantacionLeida.Tratamiento = dr.Item("Tratamientos")
            plantacionLeida.Labores = dr.Item("Labores")
            plantaciones.Add(plantacionLeida)
        End While
        conBD.Close()
        Return plantaciones
    End Function

    Public Function cargarCultivos() As List(Of Cultivo)
        Dim cultivos As New List(Of Cultivo)
        conBD.Open()
        Dim sql As String = "SELECT * FROM Cultivos"
        Dim selectCampos As New OleDb.OleDbCommand(sql, conBD)
        Dim dr As OleDb.OleDbDataReader = selectCampos.ExecuteReader
        While dr.Read
            Dim cultivoLeido As New Cultivo
            cultivoLeido.ID = dr.Item("ID")
            cultivoLeido.Tipo = dr.Item("Tipo")
            cultivoLeido.Variedad = dr.Item("Variedad")
            cultivos.Add(cultivoLeido)
        End While
        conBD.Close()
        Return cultivos
    End Function
End Class
