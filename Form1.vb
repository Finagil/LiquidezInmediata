Public Class Form1
    Const TasaIva As Double = 0.16
    Dim TasaVidaMes As Double = 0
    Dim TasaVidaDia As Double = TasaVidaMes / 30.4
    Dim TasaVidaAnual As Double = TasaVidaMes * 12
    Dim TasaAnual As Double = 0
    Dim TasaAnualIva As Double = 0.0 * (1 + TasaIva)
    Dim Bandera As Boolean = False
    Dim Cat As String
    Dim ContRecur As Double = 0
    Dim FinDeMes As Boolean = False


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TasaVidaMes = Me.ClientesTableAdapter.SacaConfiguracion("porc_seg")
        TasaVidaDia = TasaVidaMes / 30.4
        TasaVidaAnual = TasaVidaMes * 12
        'BusquedaTasa(100000, 180, 900)
        Me.ClientesTableAdapter.Fill(Me.ProductionDataSet.Clientes)
        Me.LI_PeriodosTableAdapter.Fill(Me.ProductionDataSet.LI_Periodos)

        Me.LI_PlazosTableAdapter.Fill(Me.ProductionDataSet.LI_Plazos)
        FijaTasa()
        TasaAnualIva = Math.Round(TasaAnualIva, 4)

        Me.ComboSeguro.Text = "SI"
        Me.ComboCapital.Text = "SI"
        Me.ComboPagoIgual.Text = "NO"
        ''PRUEBAS+++++++++++++++++++++++++++++
        ' Dfechacon.Value = "26/08/2015"
        'DfechaVenc.Value = "04/09/2015"
        'ComboPlazo.Text = "24 meses"
        'ComboPeriodo.Text = "Semanal"
        'TxtMonto.Text = "40000"
        'Bandera = True
        ''PRUEBAS+++++++++++++++++++++++++++++

    End Sub

    Private Sub Bcalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bcalcular.Click
        If Bandera = False Then
            'If Dfechacon.Value <= Date.Now.AddDays(-1) Then
            '    MessageBox.Show("Fecha de Contrato No valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Dfechacon.Select()
            '    Exit Sub
            'End If
            If DfechaVenc.Value <= Date.Now Then
                MessageBox.Show("Fecha de 1er vencimiento No valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DfechaVenc.Select()
                Exit Sub
            End If
            If DfechaVenc.Value <= Dfechacon.Value Then
                MessageBox.Show("Fecha de 1er vencimiento No puede ser menor o igual a la fecha de contratacion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DfechaVenc.Select()
                Exit Sub
            End If
            If DfechaVenc.Value.DayOfWeek <> DayOfWeek.Friday And ComboPeriodo.Text <> "Mensual" And ComboPeriodo.Text <> "Quincenal" Then
                MessageBox.Show("Fecha de 1er vencimiento No es dia Viernes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DfechaVenc.Select()
                Exit Sub
            End If
            If ComboPeriodo.Text = "Mensual" And DfechaVenc.Value.Day <> 6 And DfechaVenc.Value.Day <> 20 Then
                MessageBox.Show("Fecha mensual no valida (debe ser día 6 o 20).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DfechaVenc.Select()
                Exit Sub
            End If
            DfechaVenc.Value = DfechaVenc.Value.ToShortDateString
            Dim DiaUltimo As Date = DfechaVenc.Value
            DiaUltimo = DiaUltimo.AddMonths(1)
            DiaUltimo = DiaUltimo.AddDays(DiaUltimo.Day * (-1))
            If ComboPeriodo.Text = "Quincenal" And DfechaVenc.Value.Day <> 15 And DfechaVenc.Value <> DiaUltimo Then
                MessageBox.Show("Fecha Quincenal no valida (debe ser día 15 o ultimo dia de mes).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DfechaVenc.Select()
                Exit Sub
            End If
        End If
        
         If IsNumeric(TxtMonto.Text) = False Then
            MessageBox.Show("Monto Financiado No valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtMonto.Text = 0
            TxtMonto.SelectAll()
            Exit Sub
        ElseIf CDbl(TxtMonto.Text) < 2000 Or CDbl(TxtMonto.Text) > 1000000 Then
            MessageBox.Show("Monto Financiado fuera de Rango valido. (de 2,000 hasta 1,000,000)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtMonto.Text = 0
            TxtMonto.SelectAll()
            Exit Sub
        Else
            TxtMonto.Text = Format(CDbl(TxtMonto.Text), "N")
        End If
        CalculaTabla()
        BtPrint.Enabled = True
        CrystalReportViewer1.Visible = False
        GridAmortizaciones.Visible = True
    End Sub

    Private Sub Dfechacon_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dfechacon.LostFocus
        If Bandera = False Then
            'If Dfechacon.Value <= Date.Now.AddDays(-1) Then
            'MessageBox.Show("Fecha de Contrato No valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Dfechacon.Select()
            'Exit Sub
            'End If
        End If
    End Sub

    Private Sub DfechaVenc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DfechaVenc.LostFocus
        If Bandera = False Then
            'If DfechaVenc.Value <= Date.Now Then
            '    MessageBox.Show("Fecha de 1er vencimiento No valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    DfechaVenc.Select()
            '    Exit Sub
            'End If
            If DfechaVenc.Value.DayOfWeek <> DayOfWeek.Friday And ComboPeriodo.Text <> "Mensual" And ComboPeriodo.Text <> "Quincenal" Then
                MessageBox.Show("Fecha de 1er vencimiento No es dia Viernes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DfechaVenc.Select()
                Exit Sub
            End If
            If ComboPeriodo.Text = "Mensual" And DfechaVenc.Value.Day <> 6 And DfechaVenc.Value.Day <> 20 Then
                MessageBox.Show("Fecha mensual no valida (debe ser día 6 o 20).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DfechaVenc.Select()
                Exit Sub
            End If
            DfechaVenc.Value = DfechaVenc.Value.ToShortDateString
            Dim DiaUltimo As Date = DfechaVenc.Value
            DiaUltimo = DiaUltimo.AddMonths(1)
            DiaUltimo = DiaUltimo.AddDays(DiaUltimo.Day * (-1))
            If ComboPeriodo.Text = "Quincenal" And DfechaVenc.Value.Day <> 15 And DfechaVenc.Value <> DiaUltimo Then
                MessageBox.Show("Fecha Quincenal no valida (debe ser día 15 o ultimo dia de mes).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DfechaVenc.Select()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub TxtMonto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtMonto.LostFocus
        If IsNumeric(TxtMonto.Text) = False Then
            MessageBox.Show("Monto Financiado No valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtMonto.Text = 0
        ElseIf CDbl(TxtMonto.Text) < 2000 Or CDbl(TxtMonto.Text) > 1000000 And Bandera = False Then
            MessageBox.Show("Monto Financiado fuera de Rango valido. (de 2,000 hasta 1,000,000)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtMonto.Text = 0
        Else
            TxtMonto.Text = Format(CDbl(TxtMonto.Text), "N")
        End If
    End Sub

    Private Sub TxtExtra_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtExtra.LostFocus
        If IsNumeric(TxtExtra.Text) = False Then
            MessageBox.Show("Monto Extraordinario No valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtExtra.Text = 0
        ElseIf CDbl(TxtExtra.Text) >= CDbl(TxtMonto.Text) Then
            MessageBox.Show("Monto Extraordinario mayor que el financiado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtExtra.Text = 0
        Else
            TxtExtra.Text = Format(CDbl(TxtExtra.Text), "N")
        End If
    End Sub

    Private Sub BaddExtra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BaddExtra.Click
        Dim suma As Double = 0
        For Each r As DataGridViewRow In GridExtra.Rows
            suma = suma + r.Cells(1).Value
        Next
        Dim FecTerminacion As Date = DfechaVenc.Value
        Dim Semanas As Integer = Me.LI_PlazosTableAdapter.ScalarSemanas(ComboPlazo.SelectedValue)
        Dim Catorcenas As Integer = Me.LI_PlazosTableAdapter.ScalarCatorcenas(ComboPlazo.SelectedValue)
        Dim Meses As Integer = Me.LI_PlazosTableAdapter.ScalarMeses(ComboPlazo.SelectedValue)
        Dim Quincenas As Integer = Meses * 2
        'If DfechaVenc.Value.Day = 15 Then Quincenas += 1

        Select Case ComboPeriodo.Text
            Case "Semanal"
                FecTerminacion = DfechaVenc.Value.AddDays(ComboPeriodo.SelectedValue * Semanas)
            Case "Catorcenal"
                FecTerminacion = DfechaVenc.Value.AddDays(ComboPeriodo.SelectedValue * Catorcenas)
            Case "Mensual"
                FecTerminacion = DfechaVenc.Value.AddMonths(ComboPeriodo.SelectedValue * Meses)
            Case "Quincenal"
                FecTerminacion = DfechaVenc.Value.AddMonths((Quincenas / 2))
        End Select
        If IsNumeric(TxtExtra.Text) = False Then
            MessageBox.Show("Monto de Amortizacion Extra No valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtExtra.SelectAll()
            Exit Sub
        End If
        If CDbl(TxtExtra.Text) < 0 Then
            MessageBox.Show("Monto de Amortizacion Extra Inferior a 0.00 pesos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtExtra.SelectAll()
            Exit Sub
        End If
        If CDbl(TxtExtra.Text) < 1000 Then
            MessageBox.Show("Monto de Amortizacion Extra Inferior a 1,000 pesos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtExtra.SelectAll()
            Exit Sub
        End If
        If CDbl(TxtExtra.Text) + suma >= 100000 Then
            'MessageBox.Show("Monto de Amortizacion Extra superior a 100,000 pesos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'TxtExtra.SelectAll()
            'Exit Sub
        End If
        If CDbl(TxtExtra.Text) + suma >= CDbl(TxtMonto.Text) Then
            MessageBox.Show("Monto de Amortizacion Extra sobrepasa el monto financiado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtExtra.SelectAll()
            Exit Sub
        End If
        If DfechaAmort.Value < DfechaVenc.Value Then
            MessageBox.Show("la fecha de amortizacion extra es menor a la del 1er vencimiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DfechaAmort.Select()
            Exit Sub
        End If
        If DfechaAmort.Value.DayOfWeek <> DfechaVenc.Value.DayOfWeek And ComboPeriodo.Text <> "Mensual" And ComboPeriodo.Text <> "Quincenal" Then
            MessageBox.Show("Fecha de Amortizacion extra no valida. (no es Viernes)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DfechaAmort.Select()
            Exit Sub
        End If
        If ComboPeriodo.Text = "Mensual" And DfechaAmort.Value.Day <> DfechaVenc.Value.Day Then
            MessageBox.Show("Fecha de Amortizacion extra no valida (debe ser igual al dia de la fecha de vencimiento).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DfechaAmort.Select()
            Exit Sub
        End If
        If DfechaAmort.Value > FecTerminacion Then
            MessageBox.Show("Fecha de Amortizacion Fuera de tiempo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DfechaAmort.Select()
            Exit Sub
        End If
        If CalculaFechasTabla(DfechaAmort.Value) = False Then
            MessageBox.Show("Fecha de Amortizacion no coincide con los vencimientos. No se permite Amortizaciones extras en la primera ni en la ultima", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DfechaAmort.Select()
            Exit Sub
        End If
        For Each r As DataGridViewRow In GridExtra.Rows
            If r.Cells(0).Value = DfechaAmort.Value.ToShortDateString Then
                MessageBox.Show("Fecha de Amortizacion ya esta agregada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DfechaAmort.Select()
                Exit Sub
            End If
        Next

        Dim filas As Integer = GridExtra.Rows.Count
        GridExtra.Rows.Add(1)
        GridExtra.Rows(filas).Cells(0).Value = DfechaAmort.Value.ToShortDateString
        suma = CDbl(TxtExtra.Text)
        GridExtra.Rows(filas).Cells(1).Value = suma.ToString("N2")
        TxtExtra.Text = 0.0
        suma = 0
        For Each r As DataGridViewRow In GridExtra.Rows
            suma = suma + r.Cells(1).Value
        Next
        Label9.Text = "Fec. Amortizacion Ext. (" & suma.ToString("N2") & ")"
    End Sub

    Private Sub ComboPeriodo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboPeriodo.SelectedIndexChanged
        ''If Me.ComboPeriodo.Text <> "Mensual" Then
        ''    ComboPagoIgual.Enabled = True
        ''Else
        ''    ComboPagoIgual.Text = "NO"
        ''    ComboPagoIgual.Enabled = False
        ''End If
        GridExtra.Rows.Clear()
        Dim suma As Double = 0
        Label9.Text = "Fec. Amortizacion Ext. (" & suma.ToString("N2") & ")"
    End Sub

    Private Sub BtPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtPrint.Click
        Dim rep As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim DS As New ProductionDataSet
        Dim R As ProductionDataSet.ReporteRow
        For Each rr As DataGridViewRow In GridAmortizaciones.Rows
            R = DS.Tables("Reporte").NewRow
            R.NoPago = rr.Cells("Pago").Value
            R.FecCon = Dfechacon.Value
            R.FecVen = rr.Cells("FechaVencimiento").Value
            R.Dias = rr.Cells("Dias").Value
            R.Saldo = rr.Cells("SaldoInsoluto").Value
            R.Extra = rr.Cells("extra").Value
            R.Capital = rr.Cells("capital").Value
            R.Interes = rr.Cells("Interes").Value
            R.Pago = rr.Cells("Pagos").Value
            R.Iva = rr.Cells("IvaInteres").Value
            R.Seguro = rr.Cells("seguro").Value
            R.PagoT = rr.Cells("PagoTotal").Value
            R.Tasa = TxtTasa.Text
            R.Seg = TasaVidaMes
            DS.Tables("Reporte").Rows.Add(R)
        Next
        Dim newrptRepSalCli As New LiquidezInmediata.Cotizacion
        newrptRepSalCli.SetDataSource(DS)
        If CheckBox1.Checked = True Then
            newrptRepSalCli.SetParameterValue("Nombre", ComboCliente.Text)
        Else
            newrptRepSalCli.SetParameterValue("Nombre", "")
        End If
        newrptRepSalCli.SetParameterValue("CAT", Cat)
        CrystalReportViewer1.ReportSource = newrptRepSalCli
        CrystalReportViewer1.Visible = True
        GridAmortizaciones.Visible = False
        BtPrint.Enabled = False

    End Sub

    Private Sub ComboPagoIgual_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboPagoIgual.SelectedIndexChanged
        If Me.ComboPagoIgual.Text = "NO" Then
            BaddExtra.Enabled = True
            ComboCapital.Enabled = True
            
        Else
            'BaddExtra.Enabled = False

            ComboCapital.Text = "SI"
            ComboCapital.Enabled = False
            
        End If
        GridExtra.Rows.Clear()
        Dim suma As Double = 0
        Label9.Text = "Fec. Amortizacion Ext. (" & suma.ToString("N2") & ")"
    End Sub

    Private Sub ComboCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboCliente.SelectedIndexChanged
        If ComboCliente.SelectedValue <> Nothing Then
            Me.AnexosTableAdapter.Fill(Me.ProductionDataSet.Anexos, ComboCliente.SelectedValue)
            FijaTasa()
        End If
    End Sub

    Private Sub GridExtra_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles GridExtra.RowsRemoved
        Dim suma As Double = 0
        For Each r As DataGridViewRow In GridExtra.Rows
            suma = suma + r.Cells(1).Value
        Next
        Label9.Text = "Fec. Amortizacion Ext. (" & suma.ToString("N2") & ")"
    End Sub

    Sub CalculaTabla()
        Dim NoPagos As Integer = 0
        Dim NoPagosAnual As Integer = 0
        Dim Capital As Double = CDbl(TxtMonto.Text).ToString("N2")
        Dim CapitalSEG As Double = CDbl(TxtMonto.Text).ToString("N2")
        Dim MesSeguro As String = ""
        Dim FechaAux As Date = DfechaVenc.Value.ToShortDateString
        Dim FechaFin As Date = DfechaVenc.Value
        Dim SegVidaX As Double = TasaVidaDia
        Dim ErrorEnero As Date = DfechaVenc.Value.ToShortDateString
        Dim AmorExtra As Boolean = False

        Dim Semanas As Integer = Me.LI_PlazosTableAdapter.ScalarSemanas(ComboPlazo.SelectedValue)
        Dim Catorcenas As Integer = Me.LI_PlazosTableAdapter.ScalarCatorcenas(ComboPlazo.SelectedValue)
        Dim Meses As Integer = Me.LI_PlazosTableAdapter.ScalarMeses(ComboPlazo.SelectedValue)
        Dim Quincenas As Integer = (Meses * 2)
        'If DfechaVenc.Value.Day = 15 Then Quincenas += 1
        If ComboSeguro.Text = "NO" Then SegVidaX = 0
        Select Case ComboPeriodo.Text
            Case "Semanal"
                FechaFin = DfechaVenc.Value.AddDays(ComboPeriodo.SelectedValue * Semanas)
                NoPagos = Semanas
                NoPagosAnual = 52
            Case "Catorcenal"
                FechaFin = DfechaVenc.Value.AddDays(ComboPeriodo.SelectedValue * Catorcenas)
                NoPagos = Catorcenas
                NoPagosAnual = 26
            Case "Mensual"
                FechaFin = DfechaVenc.Value.AddMonths(ComboPeriodo.SelectedValue * Meses)
                NoPagos = Meses
                NoPagosAnual = 12
            Case "Quincenal"
                FechaFin = DfechaVenc.Value.AddMonths((Quincenas / 2))
                NoPagos = Quincenas
                NoPagosAnual = 24
        End Select
        If Val(TxtGracia.Text) >= NoPagos Then
            MessageBox.Show("Periodos de gracias invalidos.", "Error Semanas.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GridAmortizaciones.Rows.Clear()
            Exit Sub
        End If

        Dim FechaAnt As Date = Dfechacon.Value.ToShortDateString
        Dim Cont As Integer = 0
        Dim Dias As Double = 0
        Dim DiasX As Double = 0
        Dim Interes As Double = 0

        Dim PagoX As Double = 0
        Dim PagoY As Double = 0
        Dim Extra As Double = 0
        Dim Aux As Double = 0

        GridAmortizaciones.Rows.Clear()
        MesSeguro = FechaAux.ToString("yyyyMM")
        If ComboPagoIgual.Text = "NO" Then
            While FechaAux < FechaFin.ToShortDateString
                Cont += 1
                If Cont = 1 Then
                    If FechaAux.AddDays(1).Day = 1 And FechaAux.Month <> 2 Then
                        FinDeMes = True
                    Else
                        FinDeMes = False
                    End If
                End If
                If ComboCapital.Text = "SI" And Cont = 2 Then
                    Aux = CDbl(GridAmortizaciones.Rows(0).Cells("Interes").Value)
                    Capital = (CDbl(TxtMonto.Text) - (PagoY - Aux)).ToString("N2")
                End If
                Dias = DateDiff(DateInterval.Day, FechaAnt, FechaAux)
                If Dias > ComboPeriodo.SelectedValue * 3 And ComboPeriodo.Text = "Semanal" Then
                    MessageBox.Show("los dias del vencimiento sobrepasa tres veces el periodo.", "Error Semanas.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    GridAmortizaciones.Rows.Clear()
                    Exit Sub
                End If
                If Dias > ComboPeriodo.SelectedValue * 2 And ComboPeriodo.Text = "Catorcenal" Then
                    MessageBox.Show("los dias del vencimiento sobrepasa dos veces el periodo.", "Error Catorcena.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    GridAmortizaciones.Rows.Clear()
                    Exit Sub
                End If
                If Dias > 45 And ComboPeriodo.Text = "Mensual" Then
                    MessageBox.Show("los dias del vencimiento sobrepasa 45 días.", "Error Meses.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    GridAmortizaciones.Rows.Clear()
                    Exit Sub
                End If
                If Dias > 45 And ComboPeriodo.Text = "Quincenal" Then
                    MessageBox.Show("los dias del vencimiento sobrepasa 45 días.", "Error Quincenas.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    GridAmortizaciones.Rows.Clear()
                    Exit Sub
                End If
                Interes = (Capital * (TasaAnual / 360) * Dias).ToString("N2")
                GridAmortizaciones.Rows.Add(1)
                GridAmortizaciones.Rows(Cont - 1).Cells("pago").Value = Cont
                GridAmortizaciones.Rows(Cont - 1).Cells("FechaVencimiento").Value = FechaAux.ToShortDateString
                GridAmortizaciones.Rows(Cont - 1).Cells("dias").Value = Dias 'DIAS
                If ComboCapital.Text = "NO" And Cont <= Val(TxtGracia.Text) Then
                    PagoX = Interes.ToString("N2")
                    GridAmortizaciones.Rows(Cont - 1).Cells("Capital").Value = 0
                    GridAmortizaciones.Rows(Cont - 1).Cells("Pagos").Value = PagoX.ToString("N2")
                    AmorExtra = True
                Else
                    If Cont = 1 Then

                        If ComboPeriodo.Text <> "Mensual" Then
                            DiasX = ComboPeriodo.SelectedValue
                        Else
                            DiasX = DateDiff(DateInterval.Day, FechaAnt, FechaAnt.AddMonths(ComboPeriodo.SelectedValue))
                        End If
                        PagoX = Pmt((TasaAnual / 360) * Dias, NoPagos, Capital * -1, 0, DueDate.EndOfPeriod)
                        PagoY = Pmt((TasaAnual / 360) * Dias, NoPagos, Capital * -1, 0, DueDate.EndOfPeriod)
                        'PagoX = Pmt((TasaAnual / 12), NoPagos, Capital * -1, 0, DueDate.EndOfPeriod)
                        'PagoY = Pmt((TasaAnual / 12), NoPagos, Capital * -1, 0, DueDate.EndOfPeriod)
                    Else
                        If AmorExtra = True Then
                            PagoX = Pmt((TasaAnual / 360) * Dias, NoPagos - (Cont - 1), Capital * -1, 0, DueDate.EndOfPeriod).ToString("N2")
                            AmorExtra = False
                        End If
                        'PagoX = Pmt((TasaAnual / 12), NoPagos - (Cont - 1), Capital * -1, 0, DueDate.EndOfPeriod).ToString("N2")
                        If ComboCapital.Text = "SI" And Cont = 2 Then 'CORRIGE PRIMERA AMORTIZACION POR DIFERENCIA 
                            Aux = (PagoX - CDbl(GridAmortizaciones.Rows(0).Cells("Interes").Value)).ToString("N2")
                            Capital = CDbl(TxtMonto.Text) - Aux
                            PagoX = Pmt((TasaAnual / 360) * Dias, NoPagos - (Cont - 1), Capital * -1, 0, DueDate.EndOfPeriod).ToString("N2")
                            Interes = (Capital * (TasaAnual / 360) * Dias).ToString("N2")
                            GridAmortizaciones.Rows(0).Cells("Capital").Value = PagoX.ToString("N2") - GridAmortizaciones.Rows(0).Cells("Interes").Value ' CAPITAL
                            GridAmortizaciones.Rows(0).Cells("Pagos").Value = PagoX.ToString("N2")
                            Capital += Aux - (GridAmortizaciones.Rows(0).Cells("Capital").Value)
                            GridAmortizaciones.Rows(0).Cells("PagoTotal").Value = (CDec(GridAmortizaciones.Rows(0).Cells("IvaInteres").Value) + CDec(GridAmortizaciones.Rows(0).Cells("Pagos").Value) + CDec(GridAmortizaciones.Rows(0).Cells("Seguro").Value)).ToString("n2")
                        End If
                    End If
                End If
                GridAmortizaciones.Rows(Cont - 1).Cells("SaldoInsoluto").Value = Capital.ToString("N2")
                GridAmortizaciones.Rows(Cont - 1).Cells("Interes").Value = Interes.ToString("N2") ' INTERES
                If NoPagos = Cont Then
                    GridAmortizaciones.Rows(Cont - 1).Cells("Capital").Value = Capital.ToString("N2") ' CAPITAL
                    GridAmortizaciones.Rows(Cont - 1).Cells("Pagos").Value = (Capital + Interes).ToString("N2")
                    PagoX = (Capital + Interes)
                Else
                    GridAmortizaciones.Rows(Cont - 1).Cells("Capital").Value = (PagoX - Interes).ToString("N2") ' CAPITAL
                    GridAmortizaciones.Rows(Cont - 1).Cells("Pagos").Value = PagoX.ToString("N2")
                End If

                
                If MesSeguro <> FechaAux.ToString("yyyyMM") Then
                    CapitalSEG = Capital
                End If
                MesSeguro = FechaAux.ToString("yyyyMM")



                GridAmortizaciones.Rows(Cont - 1).Cells("IvaInteres").Value = (Interes * TasaIva).ToString("N2")
                GridAmortizaciones.Rows(Cont - 1).Cells("Seguro").Value = (((Capital + Interes) / 1000) * SegVidaX * Dias).ToString("N2")
                GridAmortizaciones.Rows(Cont - 1).Cells("PagoTotal").Value = ((((Capital + Interes) / 1000) * SegVidaX * Dias) + (Interes * TasaIva) + PagoX).ToString("N2")

                Capital = Capital.ToString("N2") - (PagoX.ToString("N2") - Interes.ToString("N2"))

                For Each r As DataGridViewRow In GridExtra.Rows
                    If r.Cells("FechaAmort").Value = GridAmortizaciones.Rows(Cont - 1).Cells("FechaVencimiento").Value Then
                        Extra = r.Cells("monto").Value
                        AmorExtra = True
                        If Extra > CDbl(GridAmortizaciones.Rows(Cont - 1).Cells("SaldoInsoluto").Value) Then
                            MessageBox.Show("amortizacion extra sobrepasa el saldo insoluto.", "Error Saldo Insoluto.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            GridAmortizaciones.Rows.Clear()
                            Exit Sub
                        End If
                        If Extra < CDbl(GridAmortizaciones.Rows(Cont - 1).Cells("PagoTotal").Value) Then
                            MessageBox.Show("amortizacion extra es menor al pago.", "Error Saldo Insoluto.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            GridAmortizaciones.Rows.Clear()
                            Exit Sub
                        End If

                        GridAmortizaciones.Rows(Cont - 1).Cells("Extra").Value = Extra.ToString("N2")
                        Aux = GridAmortizaciones.Rows(Cont - 1).Cells("Capital").Value
                        GridAmortizaciones.Rows(Cont - 1).Cells("Capital").Value = (Extra - Interes - (Interes * TasaIva) - CDbl(GridAmortizaciones.Rows(Cont - 1).Cells("Seguro").Value)).ToString("N2") ' CAPITAL
                        Capital = Capital + Aux - CDbl(GridAmortizaciones.Rows(Cont - 1).Cells("Capital").Value)
                        GridAmortizaciones.Rows(Cont - 1).Cells("PagoTotal").Value = Extra.ToString("N2")
                        GridAmortizaciones.Rows(Cont - 1).Cells("Pagos").Value = (CDbl(GridAmortizaciones.Rows(Cont - 1).Cells("Capital").Value) + Interes).ToString("N2")
                        Exit For
                    End If
                Next

                FechaAnt = FechaAux
                If ComboPeriodo.Text = "Quincenal" Then
                    If FechaAux.Day = 15 Then
                        FechaAux = FechaAux.AddMonths(1)
                        FechaAux = FechaAux.AddDays(FechaAux.Day * (-1))
                    Else
                        FechaAux = FechaAux.AddDays(15)
                    End If
                ElseIf ComboPeriodo.Text <> "Mensual" Then
                    FechaAux = FechaAnt.AddDays(ComboPeriodo.SelectedValue)
                Else
                    If FinDeMes = False Then
                        FechaAux = FechaAnt.AddMonths(ComboPeriodo.SelectedValue)
                        If Cont = 2 And FechaAnt.Month = 2 And FechaAnt.AddDays(1).Day = 1 Then
                            If ErrorEnero.Day = 29 And FechaAux.Day = 28 Then FechaAux = FechaAux.AddDays(1)
                            If ErrorEnero.Day = 30 And FechaAux.Day = 28 Then FechaAux = FechaAux.AddDays(2)
                            If ErrorEnero.Day = 30 And FechaAux.Day = 29 Then FechaAux = FechaAux.AddDays(1)
                        End If
                    Else
                        FechaAux = FechaAnt.AddDays(1)
                        FechaAux = FechaAux.AddMonths(ComboPeriodo.SelectedValue)
                        FechaAux = FechaAux.AddDays(-1)
                End If

                End If
                If Cont = 1 Then
                    If GridAmortizaciones.Rows(0).Cells("Capital").Value < 0 Then
                        MessageBox.Show("Primera amortizacion Menor a cero, reconsidere las fecha de contratacion.", "Error de fechas.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        GridAmortizaciones.Rows.Clear()
                        Exit Sub
                    End If
                End If
            End While
        Else 'PAGOS IGUALES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            PagosIguales(NoPagos, Capital, 0, FechaFin)
        End If

        Dim CapitaT As Double = 0
        Dim PagoT As Double = 0
        Dim InteresT As Double = 0
        Dim IvaT As Double = 0
        Dim SegT As Double = 0
        Dim TotalT As Double = 0
        Dim Diferencia As Double = 0
        Dim DiasT As Double = 0
        Dim PagoS(NoPagos) As Double
        Cont = 0
        PagoS(0) = CDbl(TxtMonto.Text) * -1
        For Each rr As DataGridViewRow In GridAmortizaciones.Rows
            Cont += 1
            PagoS(Cont) = CDbl(rr.Cells("PagoTotal").Value) - CDbl(rr.Cells("IvaInteres").Value)
            Capital = CDbl(rr.Cells("Capital").Value)
            CapitaT = CapitaT + Capital
            PagoT = PagoT + CDbl(rr.Cells("Pagos").Value)
            DiasT = DiasT + CDbl(rr.Cells("Dias").Value)
            InteresT = InteresT + CDbl(rr.Cells("Interes").Value)
            IvaT = IvaT + CDbl(rr.Cells("IvaInteres").Value)
            SegT = SegT + CDbl(rr.Cells("Seguro").Value)
            TotalT = TotalT + CDbl(rr.Cells("PagoTotal").Value)
        Next


        'ajuste de captital por diferencia de decimales
        If ComboPagoIgual.Text = "SI" And GridAmortizaciones.Rows.Count > 0 Then
            Diferencia = (CapitaT - CDbl(TxtMonto.Text)).ToString("N2")
            GridAmortizaciones.Rows(NoPagos - 1).Cells("Capital").Value = Capital - Diferencia
            GridAmortizaciones.Rows(NoPagos - 1).Cells("Pagos").Value = CDbl(GridAmortizaciones.Rows(NoPagos - 1).Cells("Pagos").Value) - Diferencia
            GridAmortizaciones.Rows(NoPagos - 1).Cells("PagoTotal").Value = CDbl(GridAmortizaciones.Rows(NoPagos - 1).Cells("PagoTotal").Value) - Diferencia
        End If
        If GridAmortizaciones.Rows.Count > 0 Then
            Dim TIR As Double = IRR(PagoS, 0.01)
            Cat = Math.Round((((1 + (TIR)) ^ NoPagosAnual) - 1), 3).ToString("p1")
            LbAjuste.Text = "CAT: " & Cat & "  Ajuste: " & Diferencia.ToString
        End If


        TxtTCAP.Text = (CapitaT - Diferencia).ToString("N2")
        TxtTpag.Text = PagoT.ToString("N2")
        TxtTint.Text = InteresT.ToString("N2")
        TxtTiva.Text = IvaT.ToString("N2")
        TxtTseg.Text = SegT.ToString("N2")
        TxtTtot.Text = TotalT.ToString("N2")
        TxtDiasT.Text = DiasT.ToString("N0")

    End Sub

    Function CalculaFechasTabla(ByVal FechaExtra As Date) As Boolean
        FechaExtra = FechaExtra.ToShortDateString
        Dim NoPagos As Integer = 0
        Dim Poss As Integer = 0
        Dim FechaAux As Date = DfechaVenc.Value.ToShortDateString
        Dim ErrorEnero As Date = DfechaVenc.Value.ToShortDateString
        Dim FechaFin As Date = DfechaVenc.Value
        Dim Semanas As Integer = Me.LI_PlazosTableAdapter.ScalarSemanas(ComboPlazo.SelectedValue)
        Dim Catorcenas As Integer = Me.LI_PlazosTableAdapter.ScalarCatorcenas(ComboPlazo.SelectedValue)
        Dim Meses As Integer = Me.LI_PlazosTableAdapter.ScalarMeses(ComboPlazo.SelectedValue)
        Dim Quincenas As Integer = (Meses * 2)
        'If DfechaVenc.Value.Day = 15 Then Quincenas += 1

        If FechaAux.AddDays(1).Day = 1 And FechaAux.Month <> 2 Then
            FinDeMes = True
        Else
            FinDeMes = False
        End If

        Select Case ComboPeriodo.Text
            Case "Semanal"
                FechaFin = DfechaVenc.Value.AddDays(ComboPeriodo.SelectedValue * Semanas)
                NoPagos = Semanas
            Case "Catorcenal"
                FechaFin = DfechaVenc.Value.AddDays(ComboPeriodo.SelectedValue * Catorcenas)
                NoPagos = Catorcenas
            Case "Mensual"
                FechaFin = DfechaVenc.Value.AddMonths(ComboPeriodo.SelectedValue * Meses)
                NoPagos = Meses
            Case "Quincenal"
                FechaFin = DfechaVenc.Value.AddMonths((Quincenas / 2))
                NoPagos = Quincenas
        End Select
        While FechaAux < FechaFin.ToShortDateString
            Poss += 1
            If FechaExtra = FechaAux.ToShortDateString Then

                If Poss = 1 Or Poss = NoPagos Then
                    Return (False)
                    Exit Function
                End If

                Return (True)
                Exit Function
            End If
            If FechaExtra < FechaAux.ToShortDateString Then
                Return (False)
                Exit Function
            End If
            If ComboPeriodo.Text = "Quincenal" Then
                If FechaAux.Day = 15 Then
                    FechaAux = FechaAux.AddMonths(1)
                    FechaAux = FechaAux.AddDays(FechaAux.Day * (-1))
                Else
                    FechaAux = FechaAux.AddDays(15)
                End If
            ElseIf ComboPeriodo.Text <> "Mensual" Then
                FechaAux = FechaAux.AddDays(ComboPeriodo.SelectedValue)
            Else
                If FinDeMes = False Then

                    FechaAux = FechaAux.AddMonths(ComboPeriodo.SelectedValue)
                    If Poss = 2 And FechaAux.Month = 2 And FechaAux.AddDays(1).Day = 1 Then
                        If ErrorEnero.Day = 29 And FechaAux.Day = 28 Then FechaAux = FechaAux.AddDays(1)
                        If ErrorEnero.Day = 30 And FechaAux.Day = 28 Then FechaAux = FechaAux.AddDays(2)
                        If ErrorEnero.Day = 30 And FechaAux.Day = 29 Then FechaAux = FechaAux.AddDays(1)
                    End If
                Else
                    FechaAux = FechaAux.AddDays(1)
                    FechaAux = FechaAux.AddMonths(ComboPeriodo.SelectedValue)
                    FechaAux = FechaAux.AddDays(-1)

                End If
            End If
        End While
        Return (False)
    End Function

    Sub PagosIguales(ByRef NoPagos As Double, ByRef Capital As Double, ByVal Objetivo As Double, ByRef FechaFin As Date)
        GridAmortizaciones.Rows.Clear()
        Dim FechaAux As Date = DfechaVenc.Value.ToShortDateString
        Dim FechaAnt As Date = Dfechacon.Value.ToShortDateString
        Dim DiasX As Double
        Dim Extra As Double
        Dim Interes As Double = 0
        Dim Aux As Double
        Dim Dias As Double
        Dim cont As Double
        Dim SegVidaX As Double = TasaVidaDia
        Dim SegVidaAnualX As Double = TasaVidaAnual
        If ComboSeguro.Text = "NO" Then SegVidaX = 0
        If ComboSeguro.Text = "NO" Then SegVidaAnualX = 0
        DiasX = ComboPeriodo.SelectedValue
        Dim diaUno As Double = 0
        If ComboPeriodo.Text = "Mensual" Then DiasX = 30
        Dim PagoIgual As Double = Pmt(((TasaAnualIva + SegVidaAnualX) / 360) * DiasX, NoPagos, Capital * -1, 0, DueDate.EndOfPeriod).ToString("N2")
        If Objetivo <> 0 Then
            PagoIgual = Objetivo
            Capital = CDbl(TxtMonto.Text)
        End If
        While FechaAux < FechaFin.ToShortDateString
            cont += 1
            Dias = DateDiff(DateInterval.Day, FechaAnt, FechaAux)
            If cont = 1 Then
                diaUno = Dias
            End If
            If Dias > ComboPeriodo.SelectedValue * 3 And ComboPeriodo.Text = "Semanal" Then
                MessageBox.Show("los dias del vencimiento sobrepasa tres veces el periodo.", "Error Semanas.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                GridAmortizaciones.Rows.Clear()
                Exit Sub
            End If
            If Dias > ComboPeriodo.SelectedValue * 2 And ComboPeriodo.Text = "Catorcenal" Then
                MessageBox.Show("los dias del vencimiento sobrepasa dos veces el periodo.", "Error Catorcena.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                GridAmortizaciones.Rows.Clear()
                Exit Sub
            End If
            If Dias > 45 And ComboPeriodo.Text = "Mensual" Then
                MessageBox.Show("los dias del vencimiento sobrepasa 45 días.", "Error fechas.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                GridAmortizaciones.Rows.Clear()
                Exit Sub
            End If
            GridAmortizaciones.Rows.Add(1)
            GridAmortizaciones.Rows(cont - 1).Cells("pago").Value = cont
            GridAmortizaciones.Rows(cont - 1).Cells("FechaVencimiento").Value = FechaAux.ToShortDateString
            GridAmortizaciones.Rows(cont - 1).Cells("dias").Value = Dias 'DIAS

            If ComboCapital.Text = "SI" And cont = 2 And Objetivo = 0 Then 'CORRIGE PRIMERA AMORTIZACION POR DIFERENCIA 
                PagoIgual = Pmt(((TasaAnualIva + SegVidaAnualX) / 360) * Dias, NoPagos - (cont - 1), Capital * -1, 0, DueDate.EndOfPeriod).ToString("N2")
                ContRecur = 0
                CalculaResto(Capital, Dias, PagoIgual, cont, NoPagos, FechaAnt, FechaAux, True)
                If Objetivo <> 0 Then PagoIgual = Objetivo
                Aux = (PagoIgual - CDbl(GridAmortizaciones.Rows(0).Cells("Interes").Value)).ToString("N2")
                Aux = Aux - CDbl(GridAmortizaciones.Rows(0).Cells("IvaInteres").Value).ToString("N2")
                Aux = Aux - CDbl(GridAmortizaciones.Rows(0).Cells("Seguro").Value).ToString("N2")
                Capital = CDbl(TxtMonto.Text) - Aux
                GridAmortizaciones.Rows(0).Cells("Capital").Value = Aux.ToString("N2") ' CAPITAL
                GridAmortizaciones.Rows(0).Cells("PagoTotal").Value = PagoIgual.ToString("N2")
                GridAmortizaciones.Rows(0).Cells("Pagos").Value = (PagoIgual - CDbl(GridAmortizaciones.Rows(0).Cells("IvaInteres").Value) - CDbl(GridAmortizaciones.Rows(0).Cells("Seguro").Value)).ToString("N2") ' CAPITAL
            End If

            Interes = (Capital * (TasaAnual / 360) * Dias).ToString("N2")

            GridAmortizaciones.Rows(cont - 1).Cells("SaldoInsoluto").Value = Capital.ToString("N2")
            GridAmortizaciones.Rows(cont - 1).Cells("Interes").Value = Interes.ToString("N2") ' INTERES
            GridAmortizaciones.Rows(cont - 1).Cells("IvaInteres").Value = (Interes * TasaIva).ToString("N2")
            GridAmortizaciones.Rows(cont - 1).Cells("Seguro").Value = (Dias * ((Capital / 1000) * SegVidaX)).ToString("N2")
            GridAmortizaciones.Rows(cont - 1).Cells("PagoTotal").Value = PagoIgual.ToString("N2")

            Aux = (PagoIgual - Interes).ToString("N2")
            Aux = Aux - (Interes * TasaIva).ToString("N2")
            Aux = Aux - (Dias * (Capital * SegVidaX)).ToString("N2")

            GridAmortizaciones.Rows(cont - 1).Cells("Capital").Value = Aux ' CAPITAL
            GridAmortizaciones.Rows(cont - 1).Cells("Pagos").Value = Aux + Interes
            Capital = Capital - Aux

            For Each r As DataGridViewRow In GridExtra.Rows
                If r.Cells("FechaAmort").Value = GridAmortizaciones.Rows(cont - 1).Cells("FechaVencimiento").Value Then
                    Extra = r.Cells("monto").Value
                    If Extra > CDbl(GridAmortizaciones.Rows(cont - 1).Cells("SaldoInsoluto").Value) Then
                        MessageBox.Show("amortizacion extra sobrepasa el saldo insoluto.", "Error Saldo Insoluto.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        GridAmortizaciones.Rows.Clear()
                        Exit Sub
                    End If
                    If Extra < CDbl(GridAmortizaciones.Rows(cont - 1).Cells("PagoTotal").Value) Then
                        MessageBox.Show("amortizacion extra es menor al pago.", "Error Saldo Insoluto.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        GridAmortizaciones.Rows.Clear()
                        Exit Sub
                    End If

                    GridAmortizaciones.Rows(cont - 1).Cells("Extra").Value = Extra.ToString("N2")
                    Aux = GridAmortizaciones.Rows(cont - 1).Cells("Capital").Value
                    GridAmortizaciones.Rows(cont - 1).Cells("Capital").Value = (Extra - Interes - (Interes * TasaIva) - CDbl(GridAmortizaciones.Rows(cont - 1).Cells("Seguro").Value)).ToString("N2") ' CAPITAL
                    Capital = Capital + Aux - CDbl(GridAmortizaciones.Rows(cont - 1).Cells("Capital").Value)
                    GridAmortizaciones.Rows(cont - 1).Cells("PagoTotal").Value = Extra.ToString("N2")
                    GridAmortizaciones.Rows(cont - 1).Cells("Pagos").Value = (CDbl(GridAmortizaciones.Rows(cont - 1).Cells("Capital").Value) + Interes).ToString("N2")
                    PagoIgual = Pmt(((TasaAnualIva + TasaVidaAnual) / 360) * Dias, NoPagos - (cont - 1), Capital * -1, 0, DueDate.EndOfPeriod).ToString("N2")
                    ContRecur = 0
                    CalculaResto(Capital, Dias, PagoIgual, cont + 1, NoPagos, FechaAnt, FechaAux, False)
                    Exit For
                End If
            Next

            FechaAnt = FechaAux
            If ComboPeriodo.Text = "Quincenal" Then
                If FechaAux.Day = 15 Then
                    FechaAux = FechaAux.AddMonths(1)
                    FechaAux = FechaAux.AddDays(FechaAux.Day * (-1))
                Else
                    FechaAux = FechaAux.AddDays(15)
                End If
            ElseIf ComboPeriodo.Text <> "Mensual" Then
                FechaAux = FechaAnt.AddDays(ComboPeriodo.SelectedValue)
            Else
                FechaAux = FechaAnt.AddMonths(ComboPeriodo.SelectedValue)
            End If
            If cont = 1 Then
                If GridAmortizaciones.Rows(0).Cells("Capital").Value < 0 Then
                    MessageBox.Show("Primera amortizacion Menor a cero, reconsidere las fecha de contratacion.", "Error de fechas.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    GridAmortizaciones.Rows.Clear()
                    Exit Sub
                End If
            End If
        End While
        'Dim CapitalT As Double = 0
        'For Each rr As DataGridViewRow In GridAmortizaciones.Rows
        '    CapitalT = CapitalT + CDbl(rr.Cells("Capital").Value)
        'Next
        'If CapitalT < CDbl(TxtMonto.Text) And Extra = 0 Then
        '    Objetivo = PagoIgual + 1
        '    PagosIguales(NoPagos, Capital, Objetivo, FechaFin)
        'End If

    End Sub

    Sub CalculaResto(ByVal CapitalORG As Double, ByVal dias As Double, ByRef PagoIgual As Double, ByVal cont As Double, ByVal NoPagos As Double, ByVal FechaAntORG As Date, ByVal FechaAuxORG As Date, ByVal NuevoORG As Boolean)
        Dim Capital As Double = CapitalORG
        Dim FechaAux As Date = FechaAuxORG
        Dim FechaAnt As Date = FechaAntORG
        Dim SegVidaX As Double = TasaVidaDia
        If ComboSeguro.Text = "NO" Then SegVidaX = 0
        Dim Nuevo As Boolean = NuevoORG
        Dim Interes As Double
        Dim Aux As Double
        For X = cont To NoPagos
            dias = DateDiff(DateInterval.Day, FechaAnt, FechaAux)
            If Nuevo = True Then
                Aux = (PagoIgual - CDbl(GridAmortizaciones.Rows(0).Cells("Interes").Value)).ToString("N2")
                Aux = Aux - CDbl(GridAmortizaciones.Rows(0).Cells("IvaInteres").Value).ToString("N2")
                Aux = Aux - CDbl(GridAmortizaciones.Rows(0).Cells("Seguro").Value).ToString("N2")
                Capital = CDbl(TxtMonto.Text) - Aux
                CapitalORG = Capital
                GridAmortizaciones.Rows(0).Cells("Capital").Value = Aux.ToString("N2") ' CAPITAL
                GridAmortizaciones.Rows(0).Cells("PagoTotal").Value = PagoIgual.ToString("N2")
                GridAmortizaciones.Rows(0).Cells("Pagos").Value = (PagoIgual - CDbl(GridAmortizaciones.Rows(0).Cells("IvaInteres").Value) - CDbl(GridAmortizaciones.Rows(0).Cells("Seguro").Value)).ToString("N2") ' CAPITAL

                Interes = (Capital * (TasaAnual / 360) * dias).ToString("N2")
                Aux = (PagoIgual - Interes).ToString("N2")
                Aux = Aux - (Interes * TasaIva).ToString("N2")
                Aux = Aux - (dias * (Capital * SegVidaX)).ToString("N2")
                Capital = Capital - Aux
                Nuevo = False
            Else
                Interes = Math.Round((Capital * (TasaAnual / 360) * dias), 2)
                Aux = Math.Round((PagoIgual - Interes), 2)
                Aux = Aux - Math.Round((Interes * TasaIva), 2)
                Aux = Aux - Math.Round((dias * (Capital * SegVidaX)), 2)
                Capital = Capital - Aux
            End If


            FechaAnt = FechaAux
            If ComboPeriodo.Text = "Quincenal" Then
                If FechaAux.Day = 15 Then
                    FechaAux = FechaAux.AddMonths(1)
                    FechaAux = FechaAux.AddDays(FechaAux.Day * (-1))
                Else
                    FechaAux = FechaAux.AddDays(15)
                End If
            ElseIf ComboPeriodo.Text <> "Mensual" Then
                FechaAux = FechaAnt.AddDays(ComboPeriodo.SelectedValue)
            Else
                FechaAux = FechaAnt.AddMonths(ComboPeriodo.SelectedValue)
            End If
        Next
        If Capital < (PagoIgual * -1) Then ' corrige cuando pagan mas de capital
            PagoIgual = PagoIgual - (PagoIgual * 0.1)
            Capital = 1
        End If
        If Capital > 0 Then
            PagoIgual = PagoIgual + (PagoIgual * 0.001)
            ContRecur += 1
            CalculaResto(CapitalORG, dias, PagoIgual, cont, NoPagos, FechaAntORG, FechaAuxORG, NuevoORG)
        End If

    End Sub

    Sub BusquedaTasa(ByVal Capital As Double, ByVal NoPagos As Double, ByVal PagoOBJ As Double)
        Dim Tasa As Double = 0
        Dim Incremento As Double = 0.1
        Dim pago As Double = 0
        Dim Baja As Boolean = False
        Dim Sube As Boolean = True
        Do
            Tasa += Incremento
            pago = Pmt(Tasa / 12, NoPagos, Capital * -1).ToString("N2")

            If pago > PagoOBJ And sube = True Then
                Incremento = Incremento / 10
                Incremento = Incremento * -1
                Sube = False
                Baja = True
            End If
            If pago < PagoOBJ And Baja = True Then
                Incremento = Incremento / 10
                Incremento = Incremento * -1
                Sube = True
                Baja = False
            End If
        Loop While pago <> PagoOBJ
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCargar.Click
        If Bandera = True Then
            MessageBox.Show("Modo Simulador Activado.", "Modo Simulador", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Me.LI_PlazosTableAdapter.ScalarMeses(ComboPlazo.SelectedValue) > 36 Then
            MessageBox.Show("El plazo no puede ser mayor a 36 meses.", "Error de Tabla de Amortizacion.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If MessageBox.Show("Está seguro de sobreescribir la tabla de Amortizacion", "Cambiar Contrato", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> Windows.Forms.DialogResult.Yes Then
            Exit Sub
        End If
        If GridAmortizaciones.Rows.Count > 0 Then
            If CDbl(TxtMonto.Text) <> CDbl(LbImporte.Text) Then
                MessageBox.Show("El importe del contrato no coincide con la tabla.", "Error de Tabla de Amortizacion.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim Taa As New LiquidezInmediata.ProductionDataSetTableAdapters.EdoctavTableAdapter
            Dim Frecuencia As String = ""
            Dim NoPagos As Integer = 0
            Dim Semanas As Integer = Me.LI_PlazosTableAdapter.ScalarSemanas(ComboPlazo.SelectedValue)
            Dim Catorcenas As Integer = Me.LI_PlazosTableAdapter.ScalarCatorcenas(ComboPlazo.SelectedValue)
            Dim Meses As Integer = Me.LI_PlazosTableAdapter.ScalarMeses(ComboPlazo.SelectedValue)
            Dim Quincenas As Integer = Meses * 2
            'If DfechaVenc.Value.Day = 15 Then Quincenas += 1
            Select Case ComboPeriodo.Text
                Case "Semanal"
                    NoPagos = Semanas
                    Frecuencia = "DIAS"
                Case "Catorcenal"
                    NoPagos = Catorcenas
                    Frecuencia = "DIAS"
                Case "Mensual"
                    NoPagos = Meses
                    Frecuencia = "MESES"
                Case "Quincenal"
                    NoPagos = Quincenas
                    Frecuencia = "DIAS"
            End Select
            Dim ta As New LiquidezInmediata.ProductionDataSetTableAdapters.AnexosTableAdapter
            Dim taS As New LiquidezInmediata.ProductionDataSetTableAdapters.CreditTableAdapter
            Dim Fven As Date = GridAmortizaciones.Rows(GridAmortizaciones.Rows.Count - 1).Cells("FechaVencimiento").Value

            ta.UpdateAnexo(GridAmortizaciones.Rows(0).Cells("SaldoInsoluto").Value, Me.LI_PlazosTableAdapter.ScalarMeses(ComboPlazo.SelectedValue), TasaAnual * 100, Dfechacon.Value.ToString("yyyyMMdd"), GridAmortizaciones.Rows(1).Cells("pagos").Value, DfechaVenc.Value.ToString("yyyyMMdd"), Frecuencia, GridAmortizaciones.Rows(1).Cells("dias").Value, NoPagos, TasaVidaMes, ComboAnexo.SelectedValue)
            Dim letra As String = ""
            Taa.DeleteAnexo(ComboAnexo.SelectedValue)
            For Each rr As DataGridViewRow In GridAmortizaciones.Rows
                Fven = rr.Cells("FechaVencimiento").Value
                letra = rr.Cells("pago").Value
                If letra.Length = 1 Then letra = "00" & letra
                If letra.Length = 2 Then letra = "0" & letra
                Taa.Insert(ComboAnexo.SelectedValue, letra, Fven.ToString("yyyyMMdd"), 0, "S", CDbl(rr.Cells("SaldoInsoluto").Value), CDbl(rr.Cells("capital").Value), CDbl(rr.Cells("Interes").Value), CDbl(rr.Cells("IvaInteres").Value), 0, 0, 0)
            Next
            ComboCliente_SelectedIndexChanged(Nothing, Nothing)
            MessageBox.Show("La tabla del contrato " & ComboAnexo.Text & " se cambio con existo.", "Anexo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End
        Else
            MessageBox.Show("No exsiste tabla para cargar.", "Error de Tabla de Amortizacion.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboAnexo.SelectedIndexChanged
        ButtonCargar.Enabled = True
    End Sub

    Private Sub txtSimulador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSimulador.Click
        If Bandera = True Then
            Bandera = False
            Me.Text = "Liquidez Inmediata"
        Else
            Bandera = True
            Me.Text = "Liquidez Inmediata - Modo Simulador (No valida Fecha)"
        End If
    End Sub

    Private Sub CheckFinagil_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckFinagil.CheckedChanged
        FijaTasa()
    End Sub

    ' ''Private Sub BtCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    ' ''    If MessageBox.Show("Está seguro de crear el contrato", "Generar Contrato", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> Windows.Forms.DialogResult.Yes Then
    ' ''        Exit Sub
    ' ''    End If
    ' ''    If GridAmortizaciones.Rows.Count > 0 Then
    ' ''        'If CDbl(TxtMonto.Text) <> CDbl(LbImporte.Text) Then
    ' ''        'MessageBox.Show("El importe del contrato no coincide con la tabla.", "Error de Tabla de Amortizacion.", MessageBoxButtons.OK, MessageBoxIcon.Error)
    ' ''        'Exit Sub
    ' ''        'End If
    ' ''        Dim Taa As New LiquidezInmediata.ProductionDataSetTableAdapters.EdoctavTableAdapter
    ' ''        Dim Frecuencia As String = ""
    ' ''        Dim NoPagos As Integer = 0
    ' ''        Dim Semanas As Integer = Me.LI_PlazosTableAdapter.ScalarSemanas(ComboPlazo.SelectedValue)
    ' ''        Dim Catorcenas As Integer = Me.LI_PlazosTableAdapter.ScalarCatorcenas(ComboPlazo.SelectedValue)
    ' ''        Dim Meses As Integer = Me.LI_PlazosTableAdapter.ScalarMeses(ComboPlazo.SelectedValue)
    ' ''        Dim Quincenas As Integer = Meses * 2
    ' ''        Select Case ComboPeriodo.Text
    ' ''            Case "Semanal"
    ' ''                NoPagos = Semanas
    ' ''                Frecuencia = "DIAS"
    ' ''            Case "Catorcenal"
    ' ''                NoPagos = Catorcenas
    ' ''                Frecuencia = "DIAS"

    ' ''            Case "Mensual"
    ' ''                NoPagos = Meses
    ' ''                Frecuencia = "MESES"
    ' ''            Case "Quincenal"
    ' ''                NoPagos = Quincenas
    ' ''                Frecuencia = "DIAS"
    ' ''        End Select
    ' ''        Dim ta As New LiquidezInmediata.ProductionDataSetTableAdapters.AnexosTableAdapter
    ' ''        Dim taS As New LiquidezInmediata.ProductionDataSetTableAdapters.CreditTableAdapter
    ' ''        'ta.UpdateAnexo(GridAmortizaciones.Rows(0).Cells("SaldoInsoluto").Value, Me.LI_PlazosTableAdapter.ScalarMeses(ComboPlazo.SelectedValue), TasaAnual * 100, Dfechacon.Value, GridAmortizaciones.Rows(1).Cells("pagos").Value, DfechaVenc.Value, Frecuencia, GridAmortizaciones.Rows(1).Cells("dias").Value, NoPagos, ComboAnexo.SelectedValue)
    ' ''        Dim anexo As String = ta.UltimoContrato()
    ' ''        Dim Solicitud As String = taS.UltimaSolicitud
    ' ''        Dim AnexoN As Double = Mid(anexo, 2, 4)
    ' ''        Dim SoliN As Double = Mid(Solicitud, 1, 6)
    ' ''        AnexoN += 1
    ' ''        SoliN += 1
    ' ''        Dim Fven As Date = GridAmortizaciones.Rows(0).Cells("FechaVencimiento").Value
    ' ''        anexo = "0" & AnexoN.ToString("F0") & "0001"
    ' ''        Solicitud = "00" & SoliN.ToString("F0")
    ' ''        taS.Insert(Solicitud, Dfechacon.Value.ToString("yyyyMMdd"), 5, "", "19990101", "A", TxtMonto.Text, Date.Now.ToString("yyyyMMdd"), Mid(anexo, 1, 5), Fven.ToString("yyyyMMdd"), 0, "", "")
    ' ''        ta.Insertanexo(anexo, ComboCliente.SelectedValue, TxtMonto.Text, Trim(Mid(ComboPlazo.Text, 1, 2)), TasaAnual * 100, Dfechacon.Value.ToString("yyyyMMdd"), Fven.ToString("yyyyMMdd"), GridAmortizaciones.Rows(0).Cells("PagoTotal").Value, Frecuencia, ComboPeriodo.SelectedValue, NoPagos, ComboCliente.Text)
    ' ''        Dim letra As String = ""
    ' ''        Taa.DeleteAnexo(anexo)
    ' ''        For Each rr As DataGridViewRow In GridAmortizaciones.Rows
    ' ''            Fven = rr.Cells("FechaVencimiento").Value
    ' ''            letra = rr.Cells("pago").Value
    ' ''            If letra.Length = 1 Then letra = "00" & letra
    ' ''            If letra.Length = 2 Then letra = "0" & letra
    ' ''            Taa.Insert(anexo, letra, Fven.ToString("yyyyMMdd"), 0, "L", CDbl(rr.Cells("SaldoInsoluto").Value), CDbl(rr.Cells("capital").Value), CDbl(rr.Cells("Interes").Value), CDbl(rr.Cells("IvaInteres").Value), 0, 0, 0)
    ' ''        Next
    ' ''        Dim TAO As New LiquidezInmediata.ProductionDataSetTableAdapters.OpcionesTableAdapter
    ' ''        TAO.Insert(anexo, 0, 0.16, 0, "N", "N")
    ' ''        ComboCliente_SelectedIndexChanged(Nothing, Nothing)
    ' ''        MessageBox.Show("Anexo creado " & Mid(anexo, 1, 5) & "/0001", "Anexo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    ' ''        End
    ' ''    Else
    ' ''        MessageBox.Show("No exsiste tabla para cargar.", "Error de Tabla de Amortizacion.", MessageBoxButtons.OK, MessageBoxIcon.Error)
    ' ''    End If
    ' ''End Sub

    Private Sub ComboCapital_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboCapital.SelectedIndexChanged
        If ComboCapital.Text = "SI" Then
            TxtGracia.Enabled = False
            TxtGracia.Text = 0
        Else
            TxtGracia.Enabled = True
            TxtGracia.Text = 1
        End If
    End Sub

    Private Sub ComboPlazo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboPlazo.SelectedIndexChanged
        FijaTasa()
    End Sub

    Sub FijaTasa(Optional b As Boolean = False)
        If ComboPlazo.SelectedIndex >= 0 Then
            Dim Meses As Integer = Me.LI_PlazosTableAdapter.ScalarMeses(ComboPlazo.SelectedValue)
            If CheckFinagil.Checked = True Then
                TasaAnual = 0.14
                TasaAnualIva = TasaAnual * (1 + TasaIva)
            Else
                If Meses <= 18 Then
                    TasaAnual = 0.25
                    TasaAnualIva = TasaAnual * (1 + TasaIva)
                Else
                    TasaAnual = 0.25
                    TasaAnualIva = TasaAnual * (1 + TasaIva)
                End If
                If b = True Then
                    TasaAnual = 0.2
                    TasaAnualIva = TasaAnual * (1 + TasaIva)
                End If
            End If

            If ComboCliente.Text.Trim = "ESTEBAN GIL SERRANO" Then
                TasaAnual = 0.2
            End If

            TxtTasa.Text = TasaAnual.ToString("P02")
        End If
    End Sub

End Class
