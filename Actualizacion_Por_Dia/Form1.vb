Public Class Form1
    Dim accion1 As Boolean
    Dim accion2 As Boolean
    Dim accion3 As Boolean
    Dim accion4 As Boolean

    Private Const CP_NOCLOSE_BUTTON As Integer = &H200
#Region "Desactiva Boton cerrar"
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim myCp As CreateParams = MyBase.CreateParams
            myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
            Return myCp
        End Get
    End Property
#End Region
    'BOTON SALDO
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSaldos.Click
        accion1 = False
#Region "Oculta botones"
        SalirToolStripMenuItem.Visible = False
        BtnExBodega.Enabled = False
        BtnHistServ.Enabled = False
        BtnSaldos.Enabled = False
        BtnUsoMaq.Enabled = False
        BtnIniciar.Visible = False
        BtnDetener.Visible = False
        BtnDetener.Enabled = False
#End Region
#Region "Actualizar"
        Dim objetoActualizarC4CV As New C4C_SaldoClientesV.UpdateResponse
        Dim clienteC4CV As New C4C_SaldoClientesV.Y0ZJU4DVY_ClientesVClient
        clienteC4CV.ClientCredentials.UserName.UserName = "_VIEWS"
        clienteC4CV.ClientCredentials.UserName.Password = "Welcome08"
        Dim leerrequestC4CV As New C4C_SaldoClientesV.UpdateRequest

        Dim objetoActualizarC4CB As New C4C_SaldoClientesB.UpdateResponse
        Dim clienteC4CB As New C4C_SaldoClientesB.Y0ZJU4DVY_ClientesBClient
        clienteC4CB.ClientCredentials.UserName.UserName = "_VIEWS"
        clienteC4CB.ClientCredentials.UserName.Password = "Welcome08"
        Dim leerrequestC4CB As New C4C_SaldoClientesB.UpdateRequest

#End Region
#Region "Escribir"
        Dim objetoEscribir2 As New C4C_SaldoClientesB.CreateResponse
        Dim leerrequest2 As New C4C_SaldoClientesB.CreateRequest
        Dim cliente3 As New C4C_SaldoClientesB.Y0ZJU4DVY_ClientesBClient
        cliente3.ClientCredentials.UserName.UserName = "_VIEWS"
        cliente3.ClientCredentials.UserName.Password = "Welcome08"

        Dim objetoEscribir As New C4C_SaldoClientesV.CreateResponse
        Dim leerrequest As New C4C_SaldoClientesV.CreateRequest
        Dim cliente2 As New C4C_SaldoClientesV.Y0ZJU4DVY_ClientesVClient
        cliente2.ClientCredentials.UserName.UserName = "_VIEWS"
        cliente2.ClientCredentials.UserName.Password = "Welcome08"

        leerrequest2.ClientesBClientesBCreateRequest_sync = New C4C_SaldoClientesB.ClientesBClientesBCreateRequestMessage_sync
        leerrequest2.ClientesBClientesBCreateRequest_sync.ClientesB = New C4C_SaldoClientesB.ClientesBClientesBCreateRequest
        objetoEscribir2.ClientesBClientesBCreateConfirmation_sync = New C4C_SaldoClientesB.ClientesBClientesBCreateConfirmationMessage_sync
        leerrequest2.ClientesBClientesBCreateRequest_sync.ClientesB.Nombre = New C4C_SaldoClientesB.Text
        leerrequest2.ClientesBClientesBCreateRequest_sync.ClientesB.Saldo = New C4C_SaldoClientesB.Text

        leerrequest.ClientesVClientesVCreateRequest_sync = New C4C_SaldoClientesV.ClientesVClientesVCreateRequestMessage_sync
        leerrequest.ClientesVClientesVCreateRequest_sync.ClientesV = New C4C_SaldoClientesV.ClientesVClientesVCreateRequest
        objetoEscribir.ClientesVClientesVCreateConfirmation_sync = New C4C_SaldoClientesV.ClientesVClientesVCreateConfirmationMessage_sync
        leerrequest.ClientesVClientesVCreateRequest_sync.ClientesV.Nombre = New C4C_SaldoClientesV.Text
        leerrequest.ClientesVClientesVCreateRequest_sync.ClientesV.Saldo = New C4C_SaldoClientesV.Quantity
#End Region

        Dim request As IF_SaldoClientesA.SaldoClientesAType = New IF_SaldoClientesA.SaldoClientesAType
        Dim response As IF_SaldoClientesA.SaldoClientesAResponseType = New IF_SaldoClientesA.SaldoClientesAResponseType
        Dim cliente As New IF_SaldoClientesA.ipostep_vP001sap0003in_WCSX_comsapb1ivplatformruntime_INB_WS_CALL_SYNC_XPT_INB_WS_CALL_SYNC_XPTipo_procClient
        cliente.ClientCredentials.UserName.UserName = "B1iRuntime"
        cliente.ClientCredentials.UserName.Password = "Welcome08"
        If Label3.Text = "" Then
            request.DateA = Date.Now.Date.ToString("yyyy-MM-dd")
        Else
            request.DateA = Label3.Text
        End If
        response = cliente.ZSaldoClientesA(request)


        Try
#Region "update"
            leerrequestC4CV.ClientesVClientesVUpdateRequest_sync = New C4C_SaldoClientesV.ClientesVClientesVUpdateRequestMessage_sync
            leerrequestC4CV.ClientesVClientesVUpdateRequest_sync.ClientesV = New C4C_SaldoClientesV.ClientesVClientesVUpdateRequest
            leerrequestC4CB.ClientesBClientesBUpdateRequest_sync = New C4C_SaldoClientesB.ClientesBClientesBUpdateRequestMessage_sync
            leerrequestC4CB.ClientesBClientesBUpdateRequest_sync.ClientesB = New C4C_SaldoClientesB.ClientesBClientesBUpdateRequest
            leerrequestC4CV.ClientesVClientesVUpdateRequest_sync.ClientesV.Saldo = New C4C_SaldoClientesV.Quantity
            leerrequestC4CB.ClientesBClientesBUpdateRequest_sync.ClientesB.Saldo = New C4C_SaldoClientesB.Text
#End Region
            For Each a As IF_SaldoClientesA.SaldoClientesAResponseTypeRow In response.SaldoClientesAResult

                If leerrequestC4CV.ClientesVClientesVUpdateRequest_sync.ClientesV.Entry = a.CardCode Then

                    leerrequestC4CV.ClientesVClientesVUpdateRequest_sync.ClientesV.Entry = a.CardCode
                    objetoActualizarC4CV.ClientesVClientesVUpdateConfirmation_sync = New C4C_SaldoClientesV.ClientesVClientesVUpdateConfirmationMessage_sync
                    leerrequestC4CV.ClientesVClientesVUpdateRequest_sync.ClientesV.Saldo.Value = a.Balance
                    objetoActualizarC4CV.ClientesVClientesVUpdateConfirmation_sync = clienteC4CV.Update(leerrequestC4CV.ClientesVClientesVUpdateRequest_sync)

                    leerrequestC4CB.ClientesBClientesBUpdateRequest_sync.ClientesB.Entry = a.CardCode
                    objetoActualizarC4CB.ClientesBClientesBUpdateConfirmation_sync = New C4C_SaldoClientesB.ClientesBClientesBUpdateConfirmationMessage_sync
                    leerrequestC4CB.ClientesBClientesBUpdateRequest_sync.ClientesB.Saldo.Value = a.Balance
                    objetoActualizarC4CB.ClientesBClientesBUpdateConfirmation_sync = clienteC4CB.Update(leerrequestC4CB.ClientesBClientesBUpdateRequest_sync)
                Else
                    leerrequest.ClientesVClientesVCreateRequest_sync.ClientesV.Entry = a.CardCode
                    leerrequest.ClientesVClientesVCreateRequest_sync.ClientesV.Nombre.Value = a.CardName
                    leerrequest.ClientesVClientesVCreateRequest_sync.ClientesV.Saldo.Value = a.Balance
                    objetoEscribir.ClientesVClientesVCreateConfirmation_sync = cliente2.Create(leerrequest.ClientesVClientesVCreateRequest_sync)

                    If a.Balance > 0 Then
                        leerrequest2.ClientesBClientesBCreateRequest_sync.ClientesB.Entry = a.CardCode
                        leerrequest2.ClientesBClientesBCreateRequest_sync.ClientesB.Nombre.Value = a.CardName
                        leerrequest2.ClientesBClientesBCreateRequest_sync.ClientesB.Saldo.Value = "TRUE"
                        objetoEscribir2.ClientesBClientesBCreateConfirmation_sync = cliente3.Create(leerrequest2.ClientesBClientesBCreateRequest_sync)
                    Else
                        leerrequest2.ClientesBClientesBCreateRequest_sync.ClientesB.Entry = a.CardCode
                        leerrequest2.ClientesBClientesBCreateRequest_sync.ClientesB.Nombre.Value = a.CardName
                        leerrequest2.ClientesBClientesBCreateRequest_sync.ClientesB.Saldo.Value = "FALSE"
                        objetoEscribir2.ClientesBClientesBCreateConfirmation_sync = cliente3.Create(leerrequest2.ClientesBClientesBCreateRequest_sync)
                    End If

                End If

            Next
#Region "Muestra botones"
            BtnExBodega.Enabled = True
            BtnHistServ.Enabled = True
            BtnSaldos.Enabled = True
            BtnUsoMaq.Enabled = True
            BtnIniciar.Visible = True
            SalirToolStripMenuItem.Visible = True
#End Region
            accion1 = True
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    'CALENDARIO
    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Label2.Visible = True
        Label3.Visible = True
        Label3.Text = MonthCalendar1.SelectionStart.Date.ToString("yyyy-MM-dd")
    End Sub

    'LOAD
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New System.Drawing.Size(381, 265)
        SalirToolStripMenuItem.Visible = False
        BtnIniciar.Visible = False
        BtnDetener.Enabled = True
        BtnHistServ.Enabled = False
        BtnSaldos.Enabled = False
        BtnUsoMaq.Enabled = False
        BtnExBodega.Enabled = False
    End Sub

    'USO MAQUINA
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnUsoMaq.Click
        accion2 = False
#Region "Oculta botones"
        SalirToolStripMenuItem.Visible = False
        BtnExBodega.Enabled = False
        BtnHistServ.Enabled = False
        BtnSaldos.Enabled = False
        BtnUsoMaq.Enabled = False
        BtnIniciar.Visible = False
        BtnDetener.Visible = False
        BtnDetener.Enabled = False
#End Region
#Region "update"
        Dim objetoActualizarC4C As New C4C_UsoMaquina.UpdateResponse
        Dim clienteC4C As New C4C_UsoMaquina.Y0ZJU4DVY_UsoMaquinaClient
        clienteC4C.ClientCredentials.UserName.UserName = "_VIEWS"
        clienteC4C.ClientCredentials.UserName.Password = "Welcome08"
        Dim leerrequestC4C As New C4C_UsoMaquina.UpdateRequest
#End Region
#Region "escribir"
        Dim objetoEscribir As New C4C_UsoMaquina.CreateResponse
        Dim leerrequest As New C4C_UsoMaquina.CreateRequest
        Dim cliente2 As New C4C_UsoMaquina.Y0ZJU4DVY_UsoMaquinaClient
        cliente2.ClientCredentials.UserName.UserName = "_VIEWS"
        cliente2.ClientCredentials.UserName.Password = "Welcome08"
#End Region
        Dim request As IF_UsoMaquinaA.AUsoMaquinaType = New IF_UsoMaquinaA.AUsoMaquinaType
        Dim response As IF_UsoMaquinaA.AUsoMaquinaResponseType = New IF_UsoMaquinaA.AUsoMaquinaResponseType
        Dim cliente As New IF_UsoMaquinaA.ipostep_vP001sap0003in_WCSX_comsapb1ivplatformruntime_INB_WS_CALL_SYNC_XPT_INB_WS_CALL_SYNC_XPTipo_procClient
        cliente.ClientCredentials.UserName.UserName = "B1iRuntime"
        cliente.ClientCredentials.UserName.Password = "Welcome08"
        If Label3.Text = "" Then
            request.DateA = Date.Now.Date.ToString("yyyy-MM-dd")
        Else
            request.DateA = Label3.Text
        End If
        response = cliente.ZAUsoMaquina(request)
#Region "updates"
        leerrequestC4C.UsoMaquinaUsoMaquinaUpdateRequest_sync = New C4C_UsoMaquina.UsoMaquinaUsoMaquinaUpdateRequestMessage_sync
        leerrequestC4C.UsoMaquinaUsoMaquinaUpdateRequest_sync.UsoMaquina = New C4C_UsoMaquina.UsoMaquinaUsoMaquinaUpdateRequest
        leerrequestC4C.UsoMaquinaUsoMaquinaUpdateRequest_sync.UsoMaquina.Odometro = New C4C_UsoMaquina.Text
#End Region
#Region "Escribirs"

        leerrequest.UsoMaquinaUsoMaquinaCreateRequest_sync = New C4C_UsoMaquina.UsoMaquinaUsoMaquinaCreateRequestMessage_sync
        leerrequest.UsoMaquinaUsoMaquinaCreateRequest_sync.UsoMaquina = New C4C_UsoMaquina.UsoMaquinaUsoMaquinaCreateRequest
        objetoEscribir.UsoMaquinaUsoMaquinaCreateConfirmation_sync = New C4C_UsoMaquina.UsoMaquinaUsoMaquinaCreateConfirmationMessage_sync
        leerrequest.UsoMaquinaUsoMaquinaCreateRequest_sync.UsoMaquina.ItemName = New C4C_UsoMaquina.Text
        leerrequest.UsoMaquinaUsoMaquinaCreateRequest_sync.UsoMaquina.Odometro = New C4C_UsoMaquina.Text

#End Region
        Try
            For Each a As IF_UsoMaquinaA.AUsoMaquinaResponseTypeRow In response.AUsoMaquinaResult
                If leerrequestC4C.UsoMaquinaUsoMaquinaUpdateRequest_sync.UsoMaquina.Entry = a.Serie Then
                    leerrequestC4C.UsoMaquinaUsoMaquinaUpdateRequest_sync.UsoMaquina.Entry = a.Serie
                    objetoActualizarC4C.UsoMaquinaUsoMaquinaUpdateConfirmation_sync = New C4C_UsoMaquina.UsoMaquinaUsoMaquinaUpdateConfirmationMessage_sync
                    leerrequestC4C.UsoMaquinaUsoMaquinaUpdateRequest_sync.UsoMaquina.Odometro.Value = a.Odometro
                    objetoActualizarC4C.UsoMaquinaUsoMaquinaUpdateConfirmation_sync = clienteC4C.Update(leerrequestC4C.UsoMaquinaUsoMaquinaUpdateRequest_sync)
                Else
                    leerrequest.UsoMaquinaUsoMaquinaCreateRequest_sync.UsoMaquina.Entry = a.Serie
                    leerrequest.UsoMaquinaUsoMaquinaCreateRequest_sync.UsoMaquina.ItemName.Value = a.ItemName
                    leerrequest.UsoMaquinaUsoMaquinaCreateRequest_sync.UsoMaquina.Odometro.Value = a.Odometro
                    objetoEscribir.UsoMaquinaUsoMaquinaCreateConfirmation_sync = cliente2.Create(leerrequest.UsoMaquinaUsoMaquinaCreateRequest_sync)
                End If
            Next
#Region "Muestra botones"
            BtnExBodega.Enabled = True
            BtnHistServ.Enabled = True
            BtnSaldos.Enabled = True
            BtnUsoMaq.Enabled = True
            BtnIniciar.Visible = True
            SalirToolStripMenuItem.Visible = True
#End Region
            accion2 = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'HISTORIAL DE SERVICIO
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnHistServ.Click
        accion3 = False
#Region "Oculta botones"
        SalirToolStripMenuItem.Visible = False
        BtnExBodega.Enabled = False
        BtnHistServ.Enabled = False
        BtnSaldos.Enabled = False
        BtnUsoMaq.Enabled = False
        BtnIniciar.Visible = False
        BtnDetener.Visible = False
        BtnDetener.Enabled = False
#End Region
        Dim objetoEscribir As New C4C_HistServ.CreateResponse
        Dim leerrequest As New C4C_HistServ.CreateRequest

        Dim request As IF_HistServ.HistorialDeServAType = New IF_HistServ.HistorialDeServAType
        Dim response As IF_HistServ.HistorialDeServAResponseType = New IF_HistServ.HistorialDeServAResponseType
        Dim cliente As New IF_HistServ.ipostep_vP001sap0003in_WCSX_comsapb1ivplatformruntime_INB_WS_CALL_SYNC_XPT_INB_WS_CALL_SYNC_XPTipo_procClient
        cliente.ClientCredentials.UserName.UserName = "B1iRuntime"
        cliente.ClientCredentials.UserName.Password = "Welcome08"

        If Label3.Text = "" Then
            request.DateA = Date.Now.Date.ToString("yyyy-MM-dd")
        Else
            request.DateA = Label3.Text
        End If

        response = cliente.ZHistorialDeServA(request)
        leerrequest.HistServHistServCreateRequest_sync = New C4C_HistServ.HistServHistServCreateRequestMessage_sync
        leerrequest.HistServHistServCreateRequest_sync.HistServ = New C4C_HistServ.HistServHistServCreateRequest
        objetoEscribir.HistServHistServCreateConfirmation_sync = New C4C_HistServ.HistServHistServCreateConfirmationMessage_sync
        leerrequest.HistServHistServCreateRequest_sync.HistServ.CodCliente = New C4C_HistServ.Text
        leerrequest.HistServHistServCreateRequest_sync.HistServ.NomCliente = New C4C_HistServ.Text
        leerrequest.HistServHistServCreateRequest_sync.HistServ.CodMaquina = New C4C_HistServ.Text
        leerrequest.HistServHistServCreateRequest_sync.HistServ.DesMaquina = New C4C_HistServ.Text
        leerrequest.HistServHistServCreateRequest_sync.HistServ.CodItem = New C4C_HistServ.Text
        leerrequest.HistServHistServCreateRequest_sync.HistServ.DesItem = New C4C_HistServ.Text
        leerrequest.HistServHistServCreateRequest_sync.HistServ.CantItem = New C4C_HistServ.Text
        leerrequest.HistServHistServCreateRequest_sync.HistServ.NumFactura = New C4C_HistServ.Text
        leerrequest.HistServHistServCreateRequest_sync.HistServ.FechaFactura = New C4C_HistServ.Text
        Dim cliente2 As New C4C_HistServ.Y0ZJU4DVY_HistServClient
        cliente2.ClientCredentials.UserName.UserName = "_VIEWS"
        cliente2.ClientCredentials.UserName.Password = "Welcome08"

        Try
            For Each a As IF_HistServ.HistorialDeServAResponseTypeRow In response.HistorialDeServAResult
                leerrequest.HistServHistServCreateRequest_sync.HistServ.Entry = a.Entry
                leerrequest.HistServHistServCreateRequest_sync.HistServ.CodCliente.Value = a.CardCode
                leerrequest.HistServHistServCreateRequest_sync.HistServ.NomCliente.Value = a.CardName
                leerrequest.HistServHistServCreateRequest_sync.HistServ.CodMaquina.Value = a.Serie
                leerrequest.HistServHistServCreateRequest_sync.HistServ.DesMaquina.Value = a.Dscription
                leerrequest.HistServHistServCreateRequest_sync.HistServ.CodItem.Value = a.ItemCode
                leerrequest.HistServHistServCreateRequest_sync.HistServ.DesItem.Value = a.ItemName
                leerrequest.HistServHistServCreateRequest_sync.HistServ.CantItem.Value = a.Quantity
                leerrequest.HistServHistServCreateRequest_sync.HistServ.NumFactura.Value = a.DocNum
                leerrequest.HistServHistServCreateRequest_sync.HistServ.FechaFactura.Value = a.DocDate
                objetoEscribir.HistServHistServCreateConfirmation_sync = cliente2.Create(leerrequest.HistServHistServCreateRequest_sync)
            Next
#Region "Muestra botones"
            BtnExBodega.Enabled = True
            BtnHistServ.Enabled = True
            BtnSaldos.Enabled = True
            BtnUsoMaq.Enabled = True
            BtnIniciar.Visible = True
            SalirToolStripMenuItem.Visible = True
#End Region
            accion3 = True
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    'BOTON MINIMIZAR
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        Me.Hide()
    End Sub

    'ICONO DE NOTIFICACION
    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Dim frm As New Form1()
        frm.Show()
    End Sub

    'BOTON DETENER
    Private Sub BtnDetener_Click(sender As Object, e As EventArgs) Handles BtnDetener.Click
        'Boton Detener
        If (accion1 = True And accion2 = True And accion3 = True And accion4 = True) Then
            Timer1.Stop()
            Return
        End If
        Label1.Text = "Detenido! Forma Manual"
        Me.Size = New System.Drawing.Size(601, 265)
        SalirToolStripMenuItem.Visible = True
        BtnExBodega.Enabled = True
        BtnHistServ.Enabled = True
        BtnSaldos.Enabled = True
        BtnUsoMaq.Enabled = True
        BtnDetener.Visible = False
        BtnIniciar.Visible = True
    End Sub

    'BOTON BODEGA
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnExBodega.Click
        accion4 = False
#Region "Oculta botones"
        SalirToolStripMenuItem.Visible = False
        BtnExBodega.Enabled = False
        BtnHistServ.Enabled = False
        BtnSaldos.Enabled = False
        BtnUsoMaq.Enabled = False
        BtnIniciar.Visible = False
        BtnDetener.Visible = False
        BtnDetener.Enabled = False
#End Region
#Region "Muestra botones"
        BtnExBodega.Enabled = True
        BtnHistServ.Enabled = True
        BtnSaldos.Enabled = True
        BtnUsoMaq.Enabled = True
        BtnIniciar.Visible = True
        SalirToolStripMenuItem.Visible = True
#End Region
        accion4 = True
    End Sub

    'TIMER
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Button1_Click_1(sender, e)
        Button1_Click(sender, e)
        Button3_Click(sender, e)
        Button4_Click(sender, e)
        Timer1.Start()
    End Sub

    'BOTON INICIAR
    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles BtnIniciar.Click
        'Boton Iniciar nuevamente
#Region "Oculta botones"
        SalirToolStripMenuItem.Visible = False
        BtnExBodega.Enabled = False
        BtnHistServ.Enabled = False
        BtnSaldos.Enabled = False
        BtnUsoMaq.Enabled = False
        BtnIniciar.Visible = False
        BtnDetener.Visible = True
#End Region
        Timer1.Start()
        Label1.Text = "Actualizando!"
        Me.Size = New System.Drawing.Size(381, 265)
    End Sub

    'BOTON SALIR
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim result As Integer = MessageBox.Show("Esta seguro de Finalizar la Aplicacion?", "ALERTA", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Dim result2 As Integer = MessageBox.Show("Esta seguro?", "Confirmacion", MessageBoxButtons.YesNo)
            If result2 = DialogResult.No Then

            ElseIf result2 = DialogResult.Yes Then
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim form = New Acercade()
        form.Show()
    End Sub
End Class
