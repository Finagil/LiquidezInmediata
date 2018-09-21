<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTasa = New System.Windows.Forms.TextBox()
        Me.ComboPlazo = New System.Windows.Forms.ComboBox()
        Me.LIPlazosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionDataSet = New LiquidezInmediata.ProductionDataSet()
        Me.ComboPeriodo = New System.Windows.Forms.ComboBox()
        Me.LIPeriodosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboSeguro = New System.Windows.Forms.ComboBox()
        Me.TxtExtra = New System.Windows.Forms.TextBox()
        Me.LI_PlazosTableAdapter = New LiquidezInmediata.ProductionDataSetTableAdapters.LI_PlazosTableAdapter()
        Me.LI_PeriodosTableAdapter = New LiquidezInmediata.ProductionDataSetTableAdapters.LI_PeriodosTableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtMonto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Dfechacon = New System.Windows.Forms.DateTimePicker()
        Me.DfechaVenc = New System.Windows.Forms.DateTimePicker()
        Me.BaddExtra = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DfechaAmort = New System.Windows.Forms.DateTimePicker()
        Me.GridExtra = New System.Windows.Forms.DataGridView()
        Me.FechaAmort = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bcalcular = New System.Windows.Forms.Button()
        Me.GridAmortizaciones = New System.Windows.Forms.DataGridView()
        Me.Pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoInsoluto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Extra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Capital = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Interes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pagos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IvaInteres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Seguro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagoTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboCapital = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtTCAP = New System.Windows.Forms.TextBox()
        Me.TxtTint = New System.Windows.Forms.TextBox()
        Me.TxtTpag = New System.Windows.Forms.TextBox()
        Me.TxtTiva = New System.Windows.Forms.TextBox()
        Me.TxtTseg = New System.Windows.Forms.TextBox()
        Me.TxtTtot = New System.Windows.Forms.TextBox()
        Me.BtPrint = New System.Windows.Forms.Button()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Cotizacion1 = New LiquidezInmediata.Cotizacion()
        Me.ComboCliente = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ClientesTableAdapter = New LiquidezInmediata.ProductionDataSetTableAdapters.ClientesTableAdapter()
        Me.ComboPagoIgual = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LbAjuste = New System.Windows.Forms.Label()
        Me.TxtDiasT = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ComboAnexo = New System.Windows.Forms.ComboBox()
        Me.AnexosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.AnexosTableAdapter = New LiquidezInmediata.ProductionDataSetTableAdapters.AnexosTableAdapter()
        Me.ButtonCargar = New System.Windows.Forms.Button()
        Me.LbImporte = New System.Windows.Forms.Label()
        Me.txtSimulador = New System.Windows.Forms.Button()
        Me.CheckFinagil = New System.Windows.Forms.CheckBox()
        Me.TxtGracia = New System.Windows.Forms.TextBox()
        CType(Me.LIPlazosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIPeriodosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridExtra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridAmortizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnexosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tasa Anual"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Plazo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Periodicidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(383, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Amortizaciones Extras"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Seguro de Vida"
        '
        'TxtTasa
        '
        Me.TxtTasa.Enabled = False
        Me.TxtTasa.Location = New System.Drawing.Point(19, 180)
        Me.TxtTasa.Name = "TxtTasa"
        Me.TxtTasa.Size = New System.Drawing.Size(74, 20)
        Me.TxtTasa.TabIndex = 5
        Me.TxtTasa.Text = "20"
        '
        'ComboPlazo
        '
        Me.ComboPlazo.DataSource = Me.LIPlazosBindingSource
        Me.ComboPlazo.DisplayMember = "Descripcion"
        Me.ComboPlazo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboPlazo.FormattingEnabled = True
        Me.ComboPlazo.Location = New System.Drawing.Point(19, 21)
        Me.ComboPlazo.Name = "ComboPlazo"
        Me.ComboPlazo.Size = New System.Drawing.Size(94, 21)
        Me.ComboPlazo.TabIndex = 0
        Me.ComboPlazo.ValueMember = "id"
        '
        'LIPlazosBindingSource
        '
        Me.LIPlazosBindingSource.DataMember = "LI_Plazos"
        Me.LIPlazosBindingSource.DataSource = Me.ProductionDataSet
        '
        'ProductionDataSet
        '
        Me.ProductionDataSet.DataSetName = "ProductionDataSet"
        Me.ProductionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboPeriodo
        '
        Me.ComboPeriodo.DataSource = Me.LIPeriodosBindingSource
        Me.ComboPeriodo.DisplayMember = "Descripcion"
        Me.ComboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboPeriodo.FormattingEnabled = True
        Me.ComboPeriodo.Location = New System.Drawing.Point(19, 61)
        Me.ComboPeriodo.Name = "ComboPeriodo"
        Me.ComboPeriodo.Size = New System.Drawing.Size(94, 21)
        Me.ComboPeriodo.TabIndex = 2
        Me.ComboPeriodo.ValueMember = "Dias"
        '
        'LIPeriodosBindingSource
        '
        Me.LIPeriodosBindingSource.DataMember = "LI_Periodos"
        Me.LIPeriodosBindingSource.DataSource = Me.ProductionDataSet
        '
        'ComboSeguro
        '
        Me.ComboSeguro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboSeguro.FormattingEnabled = True
        Me.ComboSeguro.Items.AddRange(New Object() {"SI", "NO"})
        Me.ComboSeguro.Location = New System.Drawing.Point(19, 101)
        Me.ComboSeguro.Name = "ComboSeguro"
        Me.ComboSeguro.Size = New System.Drawing.Size(59, 21)
        Me.ComboSeguro.TabIndex = 3
        '
        'TxtExtra
        '
        Me.TxtExtra.Location = New System.Drawing.Point(386, 60)
        Me.TxtExtra.Name = "TxtExtra"
        Me.TxtExtra.Size = New System.Drawing.Size(92, 20)
        Me.TxtExtra.TabIndex = 11
        Me.TxtExtra.Text = "0"
        '
        'LI_PlazosTableAdapter
        '
        Me.LI_PlazosTableAdapter.ClearBeforeFill = True
        '
        'LI_PeriodosTableAdapter
        '
        Me.LI_PeriodosTableAdapter.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Monto Financiado"
        '
        'TxtMonto
        '
        Me.TxtMonto.Location = New System.Drawing.Point(19, 141)
        Me.TxtMonto.Name = "TxtMonto"
        Me.TxtMonto.Size = New System.Drawing.Size(92, 20)
        Me.TxtMonto.TabIndex = 4
        Me.TxtMonto.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(162, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Fecha Contrato"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(162, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Fecha 1er Vencimiento"
        '
        'Dfechacon
        '
        Me.Dfechacon.CustomFormat = ""
        Me.Dfechacon.Location = New System.Drawing.Point(165, 21)
        Me.Dfechacon.Name = "Dfechacon"
        Me.Dfechacon.Size = New System.Drawing.Size(198, 20)
        Me.Dfechacon.TabIndex = 6
        '
        'DfechaVenc
        '
        Me.DfechaVenc.Location = New System.Drawing.Point(165, 60)
        Me.DfechaVenc.Name = "DfechaVenc"
        Me.DfechaVenc.Size = New System.Drawing.Size(200, 20)
        Me.DfechaVenc.TabIndex = 7
        '
        'BaddExtra
        '
        Me.BaddExtra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BaddExtra.Location = New System.Drawing.Point(386, 125)
        Me.BaddExtra.Name = "BaddExtra"
        Me.BaddExtra.Size = New System.Drawing.Size(200, 24)
        Me.BaddExtra.TabIndex = 13
        Me.BaddExtra.Text = "Agrega Extra >>"
        Me.BaddExtra.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(383, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(134, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Fec. Amortizacion Ext."
        '
        'DfechaAmort
        '
        Me.DfechaAmort.CustomFormat = ""
        Me.DfechaAmort.Location = New System.Drawing.Point(386, 99)
        Me.DfechaAmort.Name = "DfechaAmort"
        Me.DfechaAmort.Size = New System.Drawing.Size(200, 20)
        Me.DfechaAmort.TabIndex = 12
        '
        'GridExtra
        '
        Me.GridExtra.AllowUserToAddRows = False
        Me.GridExtra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridExtra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaAmort, Me.Monto})
        Me.GridExtra.Location = New System.Drawing.Point(597, 9)
        Me.GridExtra.Name = "GridExtra"
        Me.GridExtra.ReadOnly = True
        Me.GridExtra.Size = New System.Drawing.Size(258, 163)
        Me.GridExtra.TabIndex = 99
        '
        'FechaAmort
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.FechaAmort.DefaultCellStyle = DataGridViewCellStyle1
        Me.FechaAmort.HeaderText = "Fecha Amortizacion"
        Me.FechaAmort.Name = "FechaAmort"
        Me.FechaAmort.ReadOnly = True
        Me.FechaAmort.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'Monto
        '
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Monto.DefaultCellStyle = DataGridViewCellStyle2
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        '
        'Bcalcular
        '
        Me.Bcalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bcalcular.Location = New System.Drawing.Point(597, 178)
        Me.Bcalcular.Name = "Bcalcular"
        Me.Bcalcular.Size = New System.Drawing.Size(258, 23)
        Me.Bcalcular.TabIndex = 13
        Me.Bcalcular.Text = "Calcular Amortizaciones"
        Me.Bcalcular.UseVisualStyleBackColor = True
        '
        'GridAmortizaciones
        '
        Me.GridAmortizaciones.AllowUserToAddRows = False
        Me.GridAmortizaciones.AllowUserToDeleteRows = False
        Me.GridAmortizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridAmortizaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Pago, Me.FechaVencimiento, Me.Dias, Me.SaldoInsoluto, Me.Extra, Me.Capital, Me.Interes, Me.pagos, Me.IvaInteres, Me.Seguro, Me.PagoTotal})
        Me.GridAmortizaciones.Location = New System.Drawing.Point(18, 206)
        Me.GridAmortizaciones.Name = "GridAmortizaciones"
        Me.GridAmortizaciones.ReadOnly = True
        Me.GridAmortizaciones.Size = New System.Drawing.Size(979, 364)
        Me.GridAmortizaciones.TabIndex = 16
        '
        'Pago
        '
        Me.Pago.HeaderText = "No Pago"
        Me.Pago.Name = "Pago"
        Me.Pago.ReadOnly = True
        Me.Pago.Width = 40
        '
        'FechaVencimiento
        '
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.FechaVencimiento.DefaultCellStyle = DataGridViewCellStyle3
        Me.FechaVencimiento.HeaderText = "Fecha Vencimiento"
        Me.FechaVencimiento.Name = "FechaVencimiento"
        Me.FechaVencimiento.ReadOnly = True
        Me.FechaVencimiento.Width = 70
        '
        'Dias
        '
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Dias.DefaultCellStyle = DataGridViewCellStyle4
        Me.Dias.HeaderText = "Días"
        Me.Dias.Name = "Dias"
        Me.Dias.ReadOnly = True
        Me.Dias.Width = 40
        '
        'SaldoInsoluto
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.SaldoInsoluto.DefaultCellStyle = DataGridViewCellStyle5
        Me.SaldoInsoluto.HeaderText = "Saldo Insoluto"
        Me.SaldoInsoluto.Name = "SaldoInsoluto"
        Me.SaldoInsoluto.ReadOnly = True
        Me.SaldoInsoluto.Width = 80
        '
        'Extra
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Extra.DefaultCellStyle = DataGridViewCellStyle6
        Me.Extra.HeaderText = "Pago Ext."
        Me.Extra.Name = "Extra"
        Me.Extra.ReadOnly = True
        Me.Extra.Width = 80
        '
        'Capital
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        Me.Capital.DefaultCellStyle = DataGridViewCellStyle7
        Me.Capital.HeaderText = "Capital"
        Me.Capital.Name = "Capital"
        Me.Capital.ReadOnly = True
        Me.Capital.Width = 80
        '
        'Interes
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        Me.Interes.DefaultCellStyle = DataGridViewCellStyle8
        Me.Interes.HeaderText = "Interes"
        Me.Interes.Name = "Interes"
        Me.Interes.ReadOnly = True
        Me.Interes.Width = 80
        '
        'pagos
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        Me.pagos.DefaultCellStyle = DataGridViewCellStyle9
        Me.pagos.HeaderText = "Pago"
        Me.pagos.Name = "pagos"
        Me.pagos.ReadOnly = True
        Me.pagos.Width = 80
        '
        'IvaInteres
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        Me.IvaInteres.DefaultCellStyle = DataGridViewCellStyle10
        Me.IvaInteres.HeaderText = "Iva Interes"
        Me.IvaInteres.Name = "IvaInteres"
        Me.IvaInteres.ReadOnly = True
        Me.IvaInteres.Width = 80
        '
        'Seguro
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        Me.Seguro.DefaultCellStyle = DataGridViewCellStyle11
        Me.Seguro.HeaderText = "Seguro de Vida"
        Me.Seguro.Name = "Seguro"
        Me.Seguro.ReadOnly = True
        Me.Seguro.Width = 80
        '
        'PagoTotal
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N2"
        Me.PagoTotal.DefaultCellStyle = DataGridViewCellStyle12
        Me.PagoTotal.HeaderText = "Pago Total"
        Me.PagoTotal.Name = "PagoTotal"
        Me.PagoTotal.ReadOnly = True
        Me.PagoTotal.Width = 80
        '
        'ComboCapital
        '
        Me.ComboCapital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboCapital.FormattingEnabled = True
        Me.ComboCapital.Items.AddRange(New Object() {"SI", "NO"})
        Me.ComboCapital.Location = New System.Drawing.Point(165, 140)
        Me.ComboCapital.Name = "ComboCapital"
        Me.ComboCapital.Size = New System.Drawing.Size(59, 21)
        Me.ComboCapital.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(161, 124)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Capital 1ra Amortizacion"
        '
        'TxtTCAP
        '
        Me.TxtTCAP.Enabled = False
        Me.TxtTCAP.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTCAP.Location = New System.Drawing.Point(371, 576)
        Me.TxtTCAP.Name = "TxtTCAP"
        Me.TxtTCAP.Size = New System.Drawing.Size(80, 18)
        Me.TxtTCAP.TabIndex = 19
        Me.TxtTCAP.Text = "0.00"
        Me.TxtTCAP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTint
        '
        Me.TxtTint.Enabled = False
        Me.TxtTint.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTint.Location = New System.Drawing.Point(451, 576)
        Me.TxtTint.Name = "TxtTint"
        Me.TxtTint.Size = New System.Drawing.Size(80, 18)
        Me.TxtTint.TabIndex = 20
        Me.TxtTint.Text = "0.00"
        Me.TxtTint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTpag
        '
        Me.TxtTpag.Enabled = False
        Me.TxtTpag.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTpag.Location = New System.Drawing.Point(531, 576)
        Me.TxtTpag.Name = "TxtTpag"
        Me.TxtTpag.Size = New System.Drawing.Size(80, 18)
        Me.TxtTpag.TabIndex = 21
        Me.TxtTpag.Text = "0.00"
        Me.TxtTpag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTiva
        '
        Me.TxtTiva.Enabled = False
        Me.TxtTiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTiva.Location = New System.Drawing.Point(611, 576)
        Me.TxtTiva.Name = "TxtTiva"
        Me.TxtTiva.Size = New System.Drawing.Size(80, 18)
        Me.TxtTiva.TabIndex = 22
        Me.TxtTiva.Text = "0.00"
        Me.TxtTiva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTseg
        '
        Me.TxtTseg.Enabled = False
        Me.TxtTseg.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTseg.Location = New System.Drawing.Point(691, 576)
        Me.TxtTseg.Name = "TxtTseg"
        Me.TxtTseg.Size = New System.Drawing.Size(80, 18)
        Me.TxtTseg.TabIndex = 23
        Me.TxtTseg.Text = "0.00"
        Me.TxtTseg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTtot
        '
        Me.TxtTtot.Enabled = False
        Me.TxtTtot.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTtot.Location = New System.Drawing.Point(771, 576)
        Me.TxtTtot.Name = "TxtTtot"
        Me.TxtTtot.Size = New System.Drawing.Size(80, 18)
        Me.TxtTtot.TabIndex = 24
        Me.TxtTtot.Text = "0.00"
        Me.TxtTtot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtPrint
        '
        Me.BtPrint.Enabled = False
        Me.BtPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtPrint.Location = New System.Drawing.Point(19, 576)
        Me.BtPrint.Name = "BtPrint"
        Me.BtPrint.Size = New System.Drawing.Size(131, 37)
        Me.BtPrint.TabIndex = 25
        Me.BtPrint.Text = "Imprimir"
        Me.BtPrint.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(20, 206)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(931, 364)
        Me.CrystalReportViewer1.TabIndex = 26
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        Me.CrystalReportViewer1.Visible = False
        '
        'ComboCliente
        '
        Me.ComboCliente.DataSource = Me.ClientesBindingSource
        Me.ComboCliente.DisplayMember = "Nombre"
        Me.ComboCliente.FormattingEnabled = True
        Me.ComboCliente.Location = New System.Drawing.Point(162, 180)
        Me.ComboCliente.Name = "ComboCliente"
        Me.ComboCliente.Size = New System.Drawing.Size(424, 21)
        Me.ComboCliente.TabIndex = 9
        Me.ComboCliente.ValueMember = "Cliente"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.ProductionDataSet
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(162, 164)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(141, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Cliente (Persona Fisica)"
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'ComboPagoIgual
        '
        Me.ComboPagoIgual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboPagoIgual.FormattingEnabled = True
        Me.ComboPagoIgual.Items.AddRange(New Object() {"SI", "NO"})
        Me.ComboPagoIgual.Location = New System.Drawing.Point(165, 101)
        Me.ComboPagoIgual.Name = "ComboPagoIgual"
        Me.ComboPagoIgual.Size = New System.Drawing.Size(59, 21)
        Me.ComboPagoIgual.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(161, 85)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 13)
        Me.Label12.TabIndex = 101
        Me.Label12.Text = "Pagos Iguales"
        '
        'LbAjuste
        '
        Me.LbAjuste.AutoSize = True
        Me.LbAjuste.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAjuste.Location = New System.Drawing.Point(384, 600)
        Me.LbAjuste.Name = "LbAjuste"
        Me.LbAjuste.Size = New System.Drawing.Size(45, 12)
        Me.LbAjuste.TabIndex = 102
        Me.LbAjuste.Text = "Ajuste :"
        '
        'TxtDiasT
        '
        Me.TxtDiasT.Enabled = False
        Me.TxtDiasT.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDiasT.Location = New System.Drawing.Point(165, 576)
        Me.TxtDiasT.Name = "TxtDiasT"
        Me.TxtDiasT.Size = New System.Drawing.Size(45, 18)
        Me.TxtDiasT.TabIndex = 108
        Me.TxtDiasT.Text = "0"
        Me.TxtDiasT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(164, 595)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(65, 17)
        Me.CheckBox1.TabIndex = 109
        Me.CheckBox1.Text = "Cliente"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ComboAnexo
        '
        Me.ComboAnexo.DataSource = Me.AnexosBindingSource
        Me.ComboAnexo.DisplayMember = "AnexoX"
        Me.ComboAnexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboAnexo.FormattingEnabled = True
        Me.ComboAnexo.Location = New System.Drawing.Point(871, 24)
        Me.ComboAnexo.Name = "ComboAnexo"
        Me.ComboAnexo.Size = New System.Drawing.Size(126, 21)
        Me.ComboAnexo.TabIndex = 110
        Me.ComboAnexo.ValueMember = "Anexo"
        '
        'AnexosBindingSource
        '
        Me.AnexosBindingSource.DataMember = "Anexos"
        Me.AnexosBindingSource.DataSource = Me.ProductionDataSet
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(868, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 13)
        Me.Label13.TabIndex = 111
        Me.Label13.Text = "Anexos Sin Pago"
        '
        'AnexosTableAdapter
        '
        Me.AnexosTableAdapter.ClearBeforeFill = True
        '
        'ButtonCargar
        '
        Me.ButtonCargar.Enabled = False
        Me.ButtonCargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCargar.Location = New System.Drawing.Point(869, 73)
        Me.ButtonCargar.Name = "ButtonCargar"
        Me.ButtonCargar.Size = New System.Drawing.Size(128, 37)
        Me.ButtonCargar.TabIndex = 112
        Me.ButtonCargar.Text = "Cargar Tabla"
        Me.ButtonCargar.UseVisualStyleBackColor = True
        '
        'LbImporte
        '
        Me.LbImporte.AutoSize = True
        Me.LbImporte.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosBindingSource, "Impeq", True))
        Me.LbImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbImporte.Location = New System.Drawing.Point(868, 49)
        Me.LbImporte.Name = "LbImporte"
        Me.LbImporte.Size = New System.Drawing.Size(19, 13)
        Me.LbImporte.TabIndex = 113
        Me.LbImporte.Text = "..."
        '
        'txtSimulador
        '
        Me.txtSimulador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSimulador.Location = New System.Drawing.Point(869, 125)
        Me.txtSimulador.Name = "txtSimulador"
        Me.txtSimulador.Size = New System.Drawing.Size(128, 37)
        Me.txtSimulador.TabIndex = 114
        Me.txtSimulador.Text = "Simulador"
        Me.txtSimulador.UseVisualStyleBackColor = True
        '
        'CheckFinagil
        '
        Me.CheckFinagil.AutoSize = True
        Me.CheckFinagil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckFinagil.Location = New System.Drawing.Point(386, 21)
        Me.CheckFinagil.Name = "CheckFinagil"
        Me.CheckFinagil.Size = New System.Drawing.Size(122, 17)
        Me.CheckFinagil.TabIndex = 10
        Me.CheckFinagil.Text = "Empleado Finagil"
        Me.CheckFinagil.UseVisualStyleBackColor = True
        '
        'TxtGracia
        '
        Me.TxtGracia.Location = New System.Drawing.Point(230, 140)
        Me.TxtGracia.Name = "TxtGracia"
        Me.TxtGracia.Size = New System.Drawing.Size(26, 20)
        Me.TxtGracia.TabIndex = 115
        Me.TxtGracia.Text = "1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1007, 617)
        Me.Controls.Add(Me.TxtGracia)
        Me.Controls.Add(Me.CheckFinagil)
        Me.Controls.Add(Me.txtSimulador)
        Me.Controls.Add(Me.LbImporte)
        Me.Controls.Add(Me.ButtonCargar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ComboAnexo)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TxtDiasT)
        Me.Controls.Add(Me.LbAjuste)
        Me.Controls.Add(Me.ComboPagoIgual)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ComboCliente)
        Me.Controls.Add(Me.BtPrint)
        Me.Controls.Add(Me.TxtTtot)
        Me.Controls.Add(Me.TxtTseg)
        Me.Controls.Add(Me.TxtTiva)
        Me.Controls.Add(Me.TxtTpag)
        Me.Controls.Add(Me.TxtTint)
        Me.Controls.Add(Me.TxtTCAP)
        Me.Controls.Add(Me.ComboCapital)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GridAmortizaciones)
        Me.Controls.Add(Me.Bcalcular)
        Me.Controls.Add(Me.GridExtra)
        Me.Controls.Add(Me.DfechaAmort)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BaddExtra)
        Me.Controls.Add(Me.DfechaVenc)
        Me.Controls.Add(Me.Dfechacon)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtMonto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtExtra)
        Me.Controls.Add(Me.ComboSeguro)
        Me.Controls.Add(Me.ComboPeriodo)
        Me.Controls.Add(Me.ComboPlazo)
        Me.Controls.Add(Me.TxtTasa)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "Form1"
        Me.Text = "Liquidez Inmediata "
        CType(Me.LIPlazosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIPeriodosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridExtra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridAmortizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnexosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtTasa As System.Windows.Forms.TextBox
    Friend WithEvents ComboPlazo As System.Windows.Forms.ComboBox
    Friend WithEvents ComboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents ComboSeguro As System.Windows.Forms.ComboBox
    Friend WithEvents TxtExtra As System.Windows.Forms.TextBox
    Friend WithEvents ProductionDataSet As LiquidezInmediata.ProductionDataSet
    Friend WithEvents LIPlazosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LI_PlazosTableAdapter As LiquidezInmediata.ProductionDataSetTableAdapters.LI_PlazosTableAdapter
    Friend WithEvents LIPeriodosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LI_PeriodosTableAdapter As LiquidezInmediata.ProductionDataSetTableAdapters.LI_PeriodosTableAdapter
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtMonto As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Dfechacon As System.Windows.Forms.DateTimePicker
    Friend WithEvents DfechaVenc As System.Windows.Forms.DateTimePicker
    Friend WithEvents BaddExtra As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DfechaAmort As System.Windows.Forms.DateTimePicker
    Friend WithEvents GridExtra As System.Windows.Forms.DataGridView
    Friend WithEvents Bcalcular As System.Windows.Forms.Button
    Friend WithEvents GridAmortizaciones As System.Windows.Forms.DataGridView
    Friend WithEvents FechaAmort As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboCapital As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtTCAP As System.Windows.Forms.TextBox
    Friend WithEvents TxtTint As System.Windows.Forms.TextBox
    Friend WithEvents TxtTpag As System.Windows.Forms.TextBox
    Friend WithEvents TxtTiva As System.Windows.Forms.TextBox
    Friend WithEvents TxtTseg As System.Windows.Forms.TextBox
    Friend WithEvents TxtTtot As System.Windows.Forms.TextBox
    Friend WithEvents BtPrint As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Cotizacion1 As LiquidezInmediata.Cotizacion
    Friend WithEvents ComboCliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As LiquidezInmediata.ProductionDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents ComboPagoIgual As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LbAjuste As System.Windows.Forms.Label
    Friend WithEvents Pago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaVencimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dias As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoInsoluto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Extra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Capital As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Interes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pagos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IvaInteres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Seguro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PagoTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtDiasT As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ComboAnexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents AnexosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnexosTableAdapter As LiquidezInmediata.ProductionDataSetTableAdapters.AnexosTableAdapter
    Friend WithEvents ButtonCargar As System.Windows.Forms.Button
    Friend WithEvents LbImporte As System.Windows.Forms.Label
    Friend WithEvents txtSimulador As System.Windows.Forms.Button
    Friend WithEvents CheckFinagil As System.Windows.Forms.CheckBox
    Friend WithEvents TxtGracia As System.Windows.Forms.TextBox

End Class
