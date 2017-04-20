Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Button2.Enabled = False

        Dim objetoActualizarC4CV As New C4C_SaldoClientesV.UpdateResponse
        Dim clienteC4CV As New C4C_SaldoClientesV.Y0I9I95ZY_VistasClient
        clienteC4CV.ClientCredentials.UserName.UserName = "_VIEWS"
        clienteC4CV.ClientCredentials.UserName.Password = "Welcome08"
        Dim leerrequestC4CV As New C4C_SaldoClientesV.UpdateRequest

        Dim objetoActualizarC4CB As New C4C_SaldoClientesB.UpdateResponse
        Dim clienteC4CB As New C4C_SaldoClientesB.Y0I9I95ZY_ClientesBClient
        clienteC4CB.ClientCredentials.UserName.UserName = "_VIEWS"
        clienteC4CB.ClientCredentials.UserName.Password = "Welcome08"
        Dim leerrequestC4CB As New C4C_SaldoClientesB.UpdateRequest


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


        Try
            leerrequestC4CV.ClientesVClientesVUpdateRequest_sync = New C4C_SaldoClientesV.ClientesVClientesVUpdateRequestMessage_sync
            leerrequestC4CV.ClientesVClientesVUpdateRequest_sync.ClientesV = New C4C_SaldoClientesV.ClientesVClientesVUpdateRequest
            leerrequestC4CB.ClientesBClientesBUpdateRequest_sync = New C4C_SaldoClientesB.ClientesBClientesBUpdateRequestMessage_sync
            leerrequestC4CB.ClientesBClientesBUpdateRequest_sync.ClientesB = New C4C_SaldoClientesB.ClientesBClientesBUpdateRequest
            leerrequestC4CV.ClientesVClientesVUpdateRequest_sync.ClientesV.Saldo = New C4C_SaldoClientesV.Quantity
            leerrequestC4CB.ClientesBClientesBUpdateRequest_sync.ClientesB.Saldo = New C4C_SaldoClientesB.Text
            For Each a As IF_SaldoClientesA.SaldoClientesAResponseTypeRow In response.SaldoClientesAResult
                leerrequestC4CV.ClientesVClientesVUpdateRequest_sync.ClientesV.Entry = a.CardCode
                objetoActualizarC4CV.ClientesVClientesVUpdateConfirmation_sync = New C4C_SaldoClientesV.ClientesVClientesVUpdateConfirmationMessage_sync
                leerrequestC4CV.ClientesVClientesVUpdateRequest_sync.ClientesV.Saldo.Value = a.Balance
                objetoActualizarC4CV.ClientesVClientesVUpdateConfirmation_sync = clienteC4CV.Update(leerrequestC4CV.ClientesVClientesVUpdateRequest_sync)

                leerrequestC4CB.ClientesBClientesBUpdateRequest_sync.ClientesB.Entry = a.CardCode
                objetoActualizarC4CB.ClientesBClientesBUpdateConfirmation_sync = New C4C_SaldoClientesB.ClientesBClientesBUpdateConfirmationMessage_sync
                leerrequestC4CB.ClientesBClientesBUpdateRequest_sync.ClientesB.Saldo.Value = a.Balance
                objetoActualizarC4CB.ClientesBClientesBUpdateConfirmation_sync = clienteC4CB.Update(leerrequestC4CB.ClientesBClientesBUpdateRequest_sync)


                DataGridView1.Rows.Add(New String() {a.CardCode, a.CardName, a.Balance})
            Next
            Button1.Enabled = Enabled
            Button2.Enabled = Enabled
            Label1.Text = "Actualizado!!"
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
