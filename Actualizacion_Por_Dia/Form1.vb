Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Button2.Enabled = False
        'Dim objetoEscribir2 As New C4C_SaldoClientesB.CreateResponse
        'Dim leerrequest2 As New C4C_SaldoClientesB.CreateRequest

        'Dim objetoEscribir As New C4C_SaldoClientesV.CreateResponse
        'Dim leerrequest As New C4C_SaldoClientesV.CreateRequest

        Dim request As IF_SaldoClientesA.SaldoClientesAType = New IF_SaldoClientesA.SaldoClientesAType
        Dim response As IF_SaldoClientesA.SaldoClientesAResponseType = New IF_SaldoClientesA.SaldoClientesAResponseType
        Dim cliente As New IF_SaldoClientesA.ipostep_vP001sap0003in_WCSX_comsapb1ivplatformruntime_INB_WS_CALL_SYNC_XPT_INB_WS_CALL_SYNC_XPTipo_procClient
        cliente.ClientCredentials.UserName.UserName = "B1iRuntime"
        cliente.ClientCredentials.UserName.Password = "Welcome08"
        Label1.Visible = True
        Label1.Text = "Conectando, Extrayendo datos B1if"
        If Label3.Text = "" Then
            request.DateA = Date.Now.Date.ToString("yyyy-MM-dd")
        Else
            request.DateA = Label3.Text
        End If
        response = cliente.ZSaldoClientesA(request)
        Label1.Text = "                Cargando datos a C4C                       NO CIERRE LA APLICACION NI APAGUE EL EQUIPO"
        'leerrequest2.Saldo_ClienteBSaldoClienteBCreateRequest_sync = New C4C_SaldoClientesB.Saldo_ClienteBSaldoClienteBCreateRequestMessage_sync
        'leerrequest2.Saldo_ClienteBSaldoClienteBCreateRequest_sync.Saldo_ClienteB = New C4C_SaldoClientesB.Saldo_ClienteBSaldoClienteBCreateRequest
        'objetoEscribir2.Saldo_ClienteBSaldoClienteBCreateConfirmation_sync = New C4C_SaldoClientesB.Saldo_ClienteBSaldoClienteBCreateConfirmationMessage_sync
        'leerrequest2.Saldo_ClienteBSaldoClienteBCreateRequest_sync.Saldo_ClienteB.Nombre = New C4C_SaldoClientesB.Text
        'leerrequest2.Saldo_ClienteBSaldoClienteBCreateRequest_sync.Saldo_ClienteB.Saldo = New C4C_SaldoClientesB.Text


        'leerrequest.Saldo_ClienteVSaldoClienteVCreateRequest_sync = New C4C_SaldoClientesV.Saldo_ClienteVSaldoClienteVCreateRequestMessage_sync
        'leerrequest.Saldo_ClienteVSaldoClienteVCreateRequest_sync.Saldo_ClienteV = New C4C_SaldoClientesV.Saldo_ClienteVSaldoClienteVCreateRequest
        'objetoEscribir.Saldo_ClienteVSaldoClienteVCreateConfirmation_sync = New C4C_SaldoClientesV.Saldo_ClienteVSaldoClienteVCreateConfirmationMessage_sync
        'leerrequest.Saldo_ClienteVSaldoClienteVCreateRequest_sync.Saldo_ClienteV.Nombre = New C4C_SaldoClientesV.Text
        'leerrequest.Saldo_ClienteVSaldoClienteVCreateRequest_sync.Saldo_ClienteV.Saldo = New C4C_SaldoClientesV.Quantity


        'Dim cliente2 As New C4C_SaldoClientesV.YGGG2714Y_Saldo_ClienteVClient
        'cliente2.ClientCredentials.UserName.UserName = "_VIEWS"
        'cliente2.ClientCredentials.UserName.Password = "Welcome08"

        'Dim cliente3 As New C4C_SaldoClientesB.Y3YVY3FOY_SaldoClienteBClient
        'cliente3.ClientCredentials.UserName.UserName = "_VIEWS"
        'cliente3.ClientCredentials.UserName.Password = "Welcome08"
        Try

            For Each a As IF_SaldoClientesA.SaldoClientesAResponseTypeRow In response.SaldoClientesAResult
                'leerrequest.Saldo_ClienteVSaldoClienteVCreateRequest_sync.Saldo_ClienteV.Entry = a.CardCode
                'leerrequest.Saldo_ClienteVSaldoClienteVCreateRequest_sync.Saldo_ClienteV.Nombre.Value = a.CardName
                'leerrequest.Saldo_ClienteVSaldoClienteVCreateRequest_sync.Saldo_ClienteV.Saldo.Value = a.Balance
                'objetoEscribir.Saldo_ClienteVSaldoClienteVCreateConfirmation_sync = cliente2.Create(leerrequest.Saldo_ClienteVSaldoClienteVCreateRequest_sync)
                DataGridView1.Rows.Add(New String() {a.CardCode, a.CardName, a.Balance})
                'If a.Balance > 0 Then
                '    leerrequest2.Saldo_ClienteBSaldoClienteBCreateRequest_sync.Saldo_ClienteB.Entry = a.CardCode
                '    leerrequest2.Saldo_ClienteBSaldoClienteBCreateRequest_sync.Saldo_ClienteB.Nombre.Value = a.CardName
                '    leerrequest2.Saldo_ClienteBSaldoClienteBCreateRequest_sync.Saldo_ClienteB.Saldo.Value = "TRUE"
                '    objetoEscribir2.Saldo_ClienteBSaldoClienteBCreateConfirmation_sync = cliente3.Create(leerrequest2.Saldo_ClienteBSaldoClienteBCreateRequest_sync)
                'Else
                '    leerrequest2.Saldo_ClienteBSaldoClienteBCreateRequest_sync.Saldo_ClienteB.Entry = a.CardCode
                '    leerrequest2.Saldo_ClienteBSaldoClienteBCreateRequest_sync.Saldo_ClienteB.Nombre.Value = a.CardName
                '    leerrequest2.Saldo_ClienteBSaldoClienteBCreateRequest_sync.Saldo_ClienteB.Saldo.Value = "FALSE"
                '    objetoEscribir2.Saldo_ClienteBSaldoClienteBCreateConfirmation_sync = cliente3.Create(leerrequest2.Saldo_ClienteBSaldoClienteBCreateRequest_sync)
                'End If

            Next
            Button1.Enabled = Enabled
            Button2.Enabled = Enabled
            Label1.Text = "CARGA MASIVA COMPLETADA!!"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Label2.Visible = True
        Label3.Visible = True
        Label3.Text = MonthCalendar1.SelectionStart.Date.ToString("yyyy-MM-dd")
    End Sub
End Class
