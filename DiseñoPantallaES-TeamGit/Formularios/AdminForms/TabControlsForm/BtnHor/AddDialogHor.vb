Imports System.Data.SqlClient

Public Class AddDialogHor
    Dim DBHorario As New BDSistemaEySDataSetTableAdapters.HorarioTableAdapter
    Dim comparacion As Integer
    Dim comparacionM As Integer
    Dim comparacionX As Integer
    Dim comparacionJ As Integer
    Dim comparacionV As Integer
    Dim comparacionS As Integer
    Dim comparacionD As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        comparacion = StrComp(lunesIni.Text, lunesSal.Text)
        comparacionM = StrComp(martesIni.Text, martesSal.Text)
        comparacionX = StrComp(miercolesIni.Text, miercolesSal.Text)
        comparacionJ = StrComp(juevesIni.Text, juevesSal.Text)
        comparacionV = StrComp(viernesIni.Text, viernesSal.Text)
        comparacionS = StrComp(sabadoIni.Text, sabadoSal.Text)
        comparacionD = StrComp(domingoIni.Text, domingoSal.Text)

        'Vacio'
        If (String.IsNullOrEmpty(lunesIni.Text) Or
            String.IsNullOrEmpty(lunesSal.Text) Or
            String.IsNullOrEmpty(martesIni.Text) Or
            String.IsNullOrEmpty(martesSal.Text) Or
            String.IsNullOrEmpty(miercolesIni.Text) Or
            String.IsNullOrEmpty(miercolesSal.Text) Or
            String.IsNullOrEmpty(juevesIni.Text) Or
            String.IsNullOrEmpty(juevesSal.Text) Or
            String.IsNullOrEmpty(viernesIni.Text) Or
            String.IsNullOrEmpty(viernesSal.Text) Or
            String.IsNullOrEmpty(sabadoIni.Text) Or
            String.IsNullOrEmpty(sabadoSal.Text) Or
            String.IsNullOrEmpty(domingoIni.Text) Or
            String.IsNullOrEmpty(sabadoSal.Text)) Then

            MsgBox("No pueden haber datos vacios", MsgBoxStyle.Exclamation, "ERROR")

        Else
            'Igual'
            If (comparacion = 0 Or
                comparacionM = 0 Or
                comparacionX = 0 Or
                comparacionJ = 0 Or
                comparacionV = 0 Or
                comparacionS = 0 Or
                comparacionD = 0) Then

                MsgBox("No pueden haber datos iguales", MsgBoxStyle.Exclamation, "ERROR")

            Else
                'Mayor'
                If (comparacion = -1 Or
                    comparacionM = -1 Or
                    comparacionX = -1 Or
                    comparacionJ = -1 Or
                    comparacionV = -1 Or
                    comparacionS = -1 Or
                    comparacionD = -1) Then

                    MsgBox("La entrada no puede ser mayor a la salida", MsgBoxStyle.Exclamation, "ERROR")

                Else
                    DBHorario.InsertHorario(lunesIni.Text, lunesSal.Text,
                                          martesIni.Text, martesSal.Text,
                                          miercolesIni.Text, miercolesSal.Text,
                                          juevesIni.Text, juevesSal.Text,
                                          viernesIni.Text, viernesSal.Text,
                                          sabadoIni.Text, sabadoSal.Text,
                                          domingoIni.Text, domingoSal.Text)
                    MsgBox("Guardado")

                End If


            End If


        End If

    End Sub

    Public Sub actualizarRegistro()
        Dim conexion As String
        conexion = "Data Source=localhost;Initial Catalog=BDSistemaEyS;Integrated Security=True"
        Dim sqll As String
        sqll = "Select * from Horario"
        Dim adaptador As New SqlClient.SqlDataAdapter(sqll, conexion)
        Dim obtenerDatos As New DataSet
        adaptador.Fill(obtenerDatos, "idHorario")
        HorarioForm.DataGridView1.DataSource = obtenerDatos
        HorarioForm.DataGridView1.DataMember = "IdHorario"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        HorarioForm.Show()
    End Sub

End Class