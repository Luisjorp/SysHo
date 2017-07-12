<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReserva
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, Nothing, True, False)
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.idReserva = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.idHabitacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.numero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.idCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.nombreCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.idTrabajador = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.nombreTrabajador = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tipoReserva = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fechaReserva = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fechaIngreso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fechaSalida = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.costoAlojamiento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.observacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.estado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnCargarLista = New DevExpress.XtraEditors.SimpleButton()
        Me.lblTotalRegistros = New DevExpress.XtraEditors.LabelControl()
        Me.btnReporte = New DevExpress.XtraEditors.SimpleButton()
        Me.txtBuscar = New DevExpress.XtraEditors.SearchControl()
        Me.btnDD_Filtro = New DevExpress.XtraEditors.DropDownButton()
        Me.puMenu_btnDropDown_Filtro = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.pu_btn_Nom = New DevExpress.XtraBars.BarButtonItem()
        Me.pu_btn_Desc = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.pu_btn_Editar = New DevExpress.XtraBars.BarButtonItem()
        Me.pu_btn_Eliminar = New DevExpress.XtraBars.BarButtonItem()
        Me.pu_btn_Tipo = New DevExpress.XtraBars.BarButtonItem()
        Me.pu_btn_Precio = New DevExpress.XtraBars.BarButtonItem()
        Me.pu_btn_Estado = New DevExpress.XtraBars.BarButtonItem()
        Me.pu_btn_Piso = New DevExpress.XtraBars.BarButtonItem()
        Me.pu_btn_Numero = New DevExpress.XtraBars.BarButtonItem()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.MemoExEdit1 = New DevExpress.XtraEditors.MemoExEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCliente = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtNoHabitacion = New DevExpress.XtraEditors.ButtonEdit()
        Me.cboxEstadoReserva = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.SeparatorControl2 = New DevExpress.XtraEditors.SeparatorControl()
        Me.dateFechaSalida = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.dateFechaIngreso = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.dateFechaReserva = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIDTrabajador = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIdCliente = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.cboxTipoReserva = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCosto = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIDHabitacion = New DevExpress.XtraEditors.TextEdit()
        Me.txtIdReserva = New DevExpress.XtraEditors.TextEdit()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.puMenu_gridReservas = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.txtTrabajador = New DevExpress.XtraEditors.TextEdit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.puMenu_btnDropDown_Filtro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.MemoExEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoHabitacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboxEstadoReserva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateFechaSalida.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateFechaSalida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateFechaIngreso.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateFechaIngreso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateFechaReserva.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateFechaReserva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIDTrabajador.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboxTipoReserva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCosto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIDHabitacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdReserva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.puMenu_gridReservas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTrabajador.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplashScreenManager1
        '
        SplashScreenManager1.ClosingDelay = 500
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.Controls.Add(Me.GridControl1)
        Me.GroupControl2.Controls.Add(Me.btnCargarLista)
        Me.GroupControl2.Controls.Add(Me.lblTotalRegistros)
        Me.GroupControl2.Controls.Add(Me.btnReporte)
        Me.GroupControl2.Controls.Add(Me.txtBuscar)
        Me.GroupControl2.Controls.Add(Me.btnDD_Filtro)
        Me.GroupControl2.Location = New System.Drawing.Point(479, 47)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(666, 513)
        Me.GroupControl2.TabIndex = 10
        Me.GroupControl2.Text = "Listado de Reservas"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(8, 79)
        Me.GridControl1.LookAndFeel.SkinName = "Office 2007 Green"
        Me.GridControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(653, 376)
        Me.GridControl1.TabIndex = 20
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.MintCream
        Me.GridView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Moccasin
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.DarkTurquoise
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.idReserva, Me.idHabitacion, Me.numero, Me.idCliente, Me.nombreCliente, Me.idTrabajador, Me.nombreTrabajador, Me.tipoReserva, Me.fechaReserva, Me.fechaIngreso, Me.fechaSalida, Me.costoAlojamiento, Me.observacion, Me.estado})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupPanelText = " "
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowColumnResizing = False
        Me.GridView1.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        '
        'idReserva
        '
        Me.idReserva.Caption = "ID Reserva"
        Me.idReserva.FieldName = "idReserva"
        Me.idReserva.Name = "idReserva"
        Me.idReserva.OptionsColumn.AllowEdit = False
        Me.idReserva.OptionsColumn.ReadOnly = True
        Me.idReserva.Tag = ""
        '
        'idHabitacion
        '
        Me.idHabitacion.Caption = "ID Habitación"
        Me.idHabitacion.FieldName = "idHabitacion"
        Me.idHabitacion.Name = "idHabitacion"
        Me.idHabitacion.OptionsColumn.AllowEdit = False
        Me.idHabitacion.OptionsColumn.ReadOnly = True
        Me.idHabitacion.Visible = True
        Me.idHabitacion.VisibleIndex = 0
        '
        'numero
        '
        Me.numero.Caption = "Número Habitación"
        Me.numero.FieldName = "numero"
        Me.numero.Name = "numero"
        Me.numero.OptionsColumn.AllowEdit = False
        Me.numero.OptionsColumn.ReadOnly = True
        Me.numero.Visible = True
        Me.numero.VisibleIndex = 1
        '
        'idCliente
        '
        Me.idCliente.Caption = "ID Cliente"
        Me.idCliente.FieldName = "idCliente"
        Me.idCliente.Name = "idCliente"
        Me.idCliente.OptionsColumn.AllowEdit = False
        Me.idCliente.OptionsColumn.ReadOnly = True
        Me.idCliente.Visible = True
        Me.idCliente.VisibleIndex = 2
        '
        'nombreCliente
        '
        Me.nombreCliente.Caption = "Cliente"
        Me.nombreCliente.FieldName = "nombreCliente"
        Me.nombreCliente.Name = "nombreCliente"
        Me.nombreCliente.OptionsColumn.AllowEdit = False
        Me.nombreCliente.OptionsColumn.ReadOnly = True
        Me.nombreCliente.Visible = True
        Me.nombreCliente.VisibleIndex = 3
        '
        'idTrabajador
        '
        Me.idTrabajador.Caption = "ID Trabajador"
        Me.idTrabajador.FieldName = "idTrabajador"
        Me.idTrabajador.Name = "idTrabajador"
        Me.idTrabajador.Visible = True
        Me.idTrabajador.VisibleIndex = 4
        '
        'nombreTrabajador
        '
        Me.nombreTrabajador.Caption = "Trabajador"
        Me.nombreTrabajador.FieldName = "nombreTrabajador"
        Me.nombreTrabajador.Name = "nombreTrabajador"
        Me.nombreTrabajador.Visible = True
        Me.nombreTrabajador.VisibleIndex = 5
        '
        'tipoReserva
        '
        Me.tipoReserva.Caption = "Tipo"
        Me.tipoReserva.FieldName = "tipoReserva"
        Me.tipoReserva.Name = "tipoReserva"
        Me.tipoReserva.Visible = True
        Me.tipoReserva.VisibleIndex = 6
        '
        'fechaReserva
        '
        Me.fechaReserva.Caption = "Fecha Reserva"
        Me.fechaReserva.FieldName = "fechaReserva"
        Me.fechaReserva.Name = "fechaReserva"
        Me.fechaReserva.Visible = True
        Me.fechaReserva.VisibleIndex = 7
        '
        'fechaIngreso
        '
        Me.fechaIngreso.Caption = "Fecha Ingreso"
        Me.fechaIngreso.FieldName = "fechaIngreso"
        Me.fechaIngreso.Name = "fechaIngreso"
        Me.fechaIngreso.Visible = True
        Me.fechaIngreso.VisibleIndex = 8
        '
        'fechaSalida
        '
        Me.fechaSalida.Caption = "Salida"
        Me.fechaSalida.FieldName = "fechaSalida"
        Me.fechaSalida.Name = "fechaSalida"
        Me.fechaSalida.Visible = True
        Me.fechaSalida.VisibleIndex = 9
        '
        'costoAlojamiento
        '
        Me.costoAlojamiento.Caption = "Costo"
        Me.costoAlojamiento.FieldName = "costoAlojamiento"
        Me.costoAlojamiento.Name = "costoAlojamiento"
        Me.costoAlojamiento.Visible = True
        Me.costoAlojamiento.VisibleIndex = 10
        '
        'observacion
        '
        Me.observacion.Caption = "Observación"
        Me.observacion.FieldName = "observacion"
        Me.observacion.Name = "observacion"
        Me.observacion.Visible = True
        Me.observacion.VisibleIndex = 11
        '
        'estado
        '
        Me.estado.Caption = "Estado"
        Me.estado.FieldName = "estado"
        Me.estado.Name = "estado"
        Me.estado.Visible = True
        Me.estado.VisibleIndex = 12
        '
        'btnCargarLista
        '
        Me.btnCargarLista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCargarLista.ImageUri.Uri = "CustomizeGrid;Size16x16;Office2013"
        Me.btnCargarLista.Location = New System.Drawing.Point(8, 466)
        Me.btnCargarLista.Name = "btnCargarLista"
        Me.btnCargarLista.Size = New System.Drawing.Size(115, 28)
        Me.btnCargarLista.TabIndex = 16
        Me.btnCargarLista.Text = "Cargar Listado"
        '
        'lblTotalRegistros
        '
        Me.lblTotalRegistros.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalRegistros.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblTotalRegistros.Appearance.Options.UseFont = True
        Me.lblTotalRegistros.Location = New System.Drawing.Point(430, 471)
        Me.lblTotalRegistros.Name = "lblTotalRegistros"
        Me.lblTotalRegistros.Size = New System.Drawing.Size(125, 16)
        Me.lblTotalRegistros.TabIndex = 12
        Me.lblTotalRegistros.Text = "Registro de productos"
        '
        'btnReporte
        '
        Me.btnReporte.ImageUri.Uri = "Print;Size16x16"
        Me.btnReporte.Location = New System.Drawing.Point(506, 46)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(85, 23)
        Me.btnReporte.TabIndex = 19
        Me.btnReporte.Text = "Reporte"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(8, 48)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton()})
        Me.txtBuscar.Properties.NullValuePrompt = "Escriba el texto a buscar de acuerdo al filtro establecido a la derecha..."
        Me.txtBuscar.Properties.ShowSearchButton = False
        Me.txtBuscar.Size = New System.Drawing.Size(369, 20)
        Me.txtBuscar.TabIndex = 17
        '
        'btnDD_Filtro
        '
        Me.btnDD_Filtro.DropDownControl = Me.puMenu_btnDropDown_Filtro
        Me.btnDD_Filtro.ImageUri.Uri = "Filter;Size16x16;Office2013"
        Me.btnDD_Filtro.Location = New System.Drawing.Point(383, 46)
        Me.btnDD_Filtro.Name = "btnDD_Filtro"
        Me.btnDD_Filtro.Size = New System.Drawing.Size(117, 23)
        Me.btnDD_Filtro.TabIndex = 18
        Me.btnDD_Filtro.Text = "Nombre"
        '
        'puMenu_btnDropDown_Filtro
        '
        Me.puMenu_btnDropDown_Filtro.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.pu_btn_Nom), New DevExpress.XtraBars.LinkPersistInfo(Me.pu_btn_Desc)})
        Me.puMenu_btnDropDown_Filtro.Manager = Me.BarManager1
        Me.puMenu_btnDropDown_Filtro.Name = "puMenu_btnDropDown_Filtro"
        '
        'pu_btn_Nom
        '
        Me.pu_btn_Nom.Caption = "Nombre"
        Me.pu_btn_Nom.Id = 8
        Me.pu_btn_Nom.ImageOptions.ImageUri.Uri = "AlignHorizontalTop;Size16x16"
        Me.pu_btn_Nom.Name = "pu_btn_Nom"
        '
        'pu_btn_Desc
        '
        Me.pu_btn_Desc.Caption = "Descripción"
        Me.pu_btn_Desc.Id = 9
        Me.pu_btn_Desc.ImageOptions.ImageUri.Uri = "Columns;Size16x16"
        Me.pu_btn_Desc.Name = "pu_btn_Desc"
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.pu_btn_Editar, Me.pu_btn_Eliminar, Me.pu_btn_Nom, Me.pu_btn_Desc, Me.pu_btn_Tipo, Me.pu_btn_Precio, Me.pu_btn_Estado, Me.pu_btn_Piso, Me.pu_btn_Numero})
        Me.BarManager1.MaxItemId = 15
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1158, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 572)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1158, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 572)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1158, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 572)
        '
        'pu_btn_Editar
        '
        Me.pu_btn_Editar.Caption = "Editar"
        Me.pu_btn_Editar.Id = 0
        Me.pu_btn_Editar.ImageOptions.ImageUri.Uri = "Edit;Size16x16;Colored"
        Me.pu_btn_Editar.Name = "pu_btn_Editar"
        '
        'pu_btn_Eliminar
        '
        Me.pu_btn_Eliminar.Caption = "Eliminar"
        Me.pu_btn_Eliminar.Id = 1
        Me.pu_btn_Eliminar.ImageOptions.ImageUri.Uri = "Delete;Size16x16"
        Me.pu_btn_Eliminar.Name = "pu_btn_Eliminar"
        '
        'pu_btn_Tipo
        '
        Me.pu_btn_Tipo.Caption = "Tipo de Habitación"
        Me.pu_btn_Tipo.Id = 10
        Me.pu_btn_Tipo.ImageOptions.ImageUri.Uri = "ListBullets;Size16x16"
        Me.pu_btn_Tipo.Name = "pu_btn_Tipo"
        '
        'pu_btn_Precio
        '
        Me.pu_btn_Precio.Caption = "Precio"
        Me.pu_btn_Precio.Id = 11
        Me.pu_btn_Precio.ImageOptions.ImageUri.Uri = "Currency;Size16x16"
        Me.pu_btn_Precio.Name = "pu_btn_Precio"
        '
        'pu_btn_Estado
        '
        Me.pu_btn_Estado.Caption = "Estado"
        Me.pu_btn_Estado.Id = 12
        Me.pu_btn_Estado.ImageOptions.ImageUri.Uri = "Apply;Size16x16"
        Me.pu_btn_Estado.Name = "pu_btn_Estado"
        '
        'pu_btn_Piso
        '
        Me.pu_btn_Piso.Caption = "Piso"
        Me.pu_btn_Piso.Id = 13
        Me.pu_btn_Piso.ImageOptions.ImageUri.Uri = "ListNumbers;Size16x16"
        Me.pu_btn_Piso.Name = "pu_btn_Piso"
        '
        'pu_btn_Numero
        '
        Me.pu_btn_Numero.Caption = "No. Habitación"
        Me.pu_btn_Numero.Id = 14
        Me.pu_btn_Numero.ImageOptions.ImageUri.Uri = "Today;Size16x16"
        Me.pu_btn_Numero.Name = "pu_btn_Numero"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.Controls.Add(Me.MemoExEdit1)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Controls.Add(Me.txtCliente)
        Me.GroupControl1.Controls.Add(Me.txtNoHabitacion)
        Me.GroupControl1.Controls.Add(Me.cboxEstadoReserva)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.SeparatorControl2)
        Me.GroupControl1.Controls.Add(Me.dateFechaSalida)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.dateFechaIngreso)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.dateFechaReserva)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.txtIDTrabajador)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtIdCliente)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.btnCancelar)
        Me.GroupControl1.Controls.Add(Me.btnGuardar)
        Me.GroupControl1.Controls.Add(Me.btnNuevo)
        Me.GroupControl1.Controls.Add(Me.cboxTipoReserva)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.txtCosto)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txtIDHabitacion)
        Me.GroupControl1.Controls.Add(Me.txtIdReserva)
        Me.GroupControl1.Controls.Add(Me.SeparatorControl1)
        Me.GroupControl1.Controls.Add(Me.txtTrabajador)
        Me.GroupControl1.Location = New System.Drawing.Point(13, 47)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(448, 513)
        Me.GroupControl1.TabIndex = 9
        Me.GroupControl1.Text = "Registro de Reservas"
        '
        'MemoExEdit1
        '
        Me.MemoExEdit1.Location = New System.Drawing.Point(108, 382)
        Me.MemoExEdit1.MenuManager = Me.BarManager1
        Me.MemoExEdit1.Name = "MemoExEdit1"
        Me.MemoExEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MemoExEdit1.Size = New System.Drawing.Size(291, 20)
        Me.MemoExEdit1.TabIndex = 36
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(39, 382)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl12.TabIndex = 35
        Me.LabelControl12.Text = "Observación:"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(167, 76)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCliente.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtCliente.Size = New System.Drawing.Size(109, 20)
        Me.txtCliente.TabIndex = 4
        '
        'txtNoHabitacion
        '
        Me.txtNoHabitacion.Location = New System.Drawing.Point(166, 48)
        Me.txtNoHabitacion.Name = "txtNoHabitacion"
        Me.txtNoHabitacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtNoHabitacion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtNoHabitacion.Size = New System.Drawing.Size(109, 20)
        Me.txtNoHabitacion.TabIndex = 2
        '
        'cboxEstadoReserva
        '
        Me.cboxEstadoReserva.EditValue = ""
        Me.cboxEstadoReserva.Location = New System.Drawing.Point(109, 335)
        Me.cboxEstadoReserva.Name = "cboxEstadoReserva"
        Me.cboxEstadoReserva.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboxEstadoReserva.Properties.Items.AddRange(New Object() {"Alquiler", "Pagada", "Anulada"})
        Me.cboxEstadoReserva.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboxEstadoReserva.Size = New System.Drawing.Size(166, 20)
        Me.cboxEstadoReserva.TabIndex = 12
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(23, 339)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl11.TabIndex = 34
        Me.LabelControl11.Text = "Estado Reserva:"
        '
        'SeparatorControl2
        '
        Me.SeparatorControl2.BackColor = System.Drawing.Color.Transparent
        Me.SeparatorControl2.Location = New System.Drawing.Point(5, 306)
        Me.SeparatorControl2.Name = "SeparatorControl2"
        Me.SeparatorControl2.Size = New System.Drawing.Size(428, 23)
        Me.SeparatorControl2.TabIndex = 33
        '
        'dateFechaSalida
        '
        Me.dateFechaSalida.EditValue = Nothing
        Me.dateFechaSalida.Location = New System.Drawing.Point(109, 250)
        Me.dateFechaSalida.Name = "dateFechaSalida"
        Me.dateFechaSalida.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateFechaSalida.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateFechaSalida.Size = New System.Drawing.Size(167, 20)
        Me.dateFechaSalida.TabIndex = 10
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(39, 253)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl10.TabIndex = 31
        Me.LabelControl10.Text = "Fecha Salida:"
        '
        'dateFechaIngreso
        '
        Me.dateFechaIngreso.EditValue = Nothing
        Me.dateFechaIngreso.Location = New System.Drawing.Point(109, 219)
        Me.dateFechaIngreso.Name = "dateFechaIngreso"
        Me.dateFechaIngreso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateFechaIngreso.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateFechaIngreso.Size = New System.Drawing.Size(167, 20)
        Me.dateFechaIngreso.TabIndex = 9
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(30, 222)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl8.TabIndex = 29
        Me.LabelControl8.Text = "Fecha Ingreso:"
        '
        'dateFechaReserva
        '
        Me.dateFechaReserva.EditValue = Nothing
        Me.dateFechaReserva.Location = New System.Drawing.Point(109, 187)
        Me.dateFechaReserva.Name = "dateFechaReserva"
        Me.dateFechaReserva.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateFechaReserva.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateFechaReserva.Size = New System.Drawing.Size(167, 20)
        Me.dateFechaReserva.TabIndex = 8
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(27, 190)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl5.TabIndex = 27
        Me.LabelControl5.Text = "Fecha Reserva:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(46, 105)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl4.TabIndex = 24
        Me.LabelControl4.Text = "Trabajador:"
        '
        'txtIDTrabajador
        '
        Me.txtIDTrabajador.Enabled = False
        Me.txtIDTrabajador.Location = New System.Drawing.Point(108, 102)
        Me.txtIDTrabajador.Name = "txtIDTrabajador"
        Me.txtIDTrabajador.Size = New System.Drawing.Size(52, 20)
        Me.txtIDTrabajador.TabIndex = 5
        Me.txtIDTrabajador.Visible = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(66, 79)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl3.TabIndex = 21
        Me.LabelControl3.Text = "Cliente:"
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Enabled = False
        Me.txtIdCliente.Location = New System.Drawing.Point(108, 76)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(52, 20)
        Me.txtIdCliente.TabIndex = 3
        Me.txtIdCliente.Visible = False
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(386, 27)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(13, 13)
        Me.LabelControl9.TabIndex = 18
        Me.LabelControl9.Text = "R-"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.ImageUri.Uri = "Cancel;Size16x16;Office2013"
        Me.btnCancelar.Location = New System.Drawing.Point(358, 467)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnGuardar.ImageUri.Uri = "Apply;Size16x16;Office2013"
        Me.btnGuardar.Location = New System.Drawing.Point(277, 467)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 14
        Me.btnGuardar.Text = "Guardar"
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnNuevo.ImageUri.Uri = "AddItem;Size16x16;Office2013"
        Me.btnNuevo.Location = New System.Drawing.Point(114, 467)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 13
        Me.btnNuevo.Text = "Nuevo"
        '
        'cboxTipoReserva
        '
        Me.cboxTipoReserva.EditValue = ""
        Me.cboxTipoReserva.Location = New System.Drawing.Point(109, 153)
        Me.cboxTipoReserva.Name = "cboxTipoReserva"
        Me.cboxTipoReserva.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboxTipoReserva.Properties.Items.AddRange(New Object() {"Reservada", "Alquilada"})
        Me.cboxTipoReserva.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboxTipoReserva.Size = New System.Drawing.Size(166, 20)
        Me.cboxTipoReserva.TabIndex = 7
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(36, 156)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl7.TabIndex = 11
        Me.LabelControl7.Text = "Tipo Reserva:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(71, 283)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl6.TabIndex = 10
        Me.LabelControl6.Text = "Costo:"
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(109, 280)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Properties.Mask.BeepOnError = True
        Me.txtCosto.Properties.Mask.EditMask = "###,###,##0.00"
        Me.txtCosto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCosto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCosto.Size = New System.Drawing.Size(100, 20)
        Me.txtCosto.TabIndex = 11
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(49, 51)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Habitación:"
        '
        'txtIDHabitacion
        '
        Me.txtIDHabitacion.Enabled = False
        Me.txtIDHabitacion.Location = New System.Drawing.Point(108, 48)
        Me.txtIDHabitacion.Name = "txtIDHabitacion"
        Me.txtIDHabitacion.Size = New System.Drawing.Size(52, 20)
        Me.txtIDHabitacion.TabIndex = 1
        Me.txtIDHabitacion.Visible = False
        '
        'txtIdReserva
        '
        Me.txtIdReserva.EditValue = ""
        Me.txtIdReserva.Enabled = False
        Me.txtIdReserva.Location = New System.Drawing.Point(401, 24)
        Me.txtIdReserva.Name = "txtIdReserva"
        Me.txtIdReserva.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtIdReserva.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtIdReserva.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtIdReserva.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtIdReserva.Properties.ReadOnly = True
        Me.txtIdReserva.Size = New System.Drawing.Size(42, 20)
        Me.txtIdReserva.TabIndex = 0
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.BackColor = System.Drawing.Color.Transparent
        Me.SeparatorControl1.Location = New System.Drawing.Point(5, 124)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(428, 23)
        Me.SeparatorControl1.TabIndex = 26
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(13, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(107, 29)
        Me.LabelControl1.TabIndex = 8
        Me.LabelControl1.Text = "Reservas"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'puMenu_gridReservas
        '
        Me.puMenu_gridReservas.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.pu_btn_Editar), New DevExpress.XtraBars.LinkPersistInfo(Me.pu_btn_Eliminar)})
        Me.puMenu_gridReservas.Manager = Me.BarManager1
        Me.puMenu_gridReservas.Name = "puMenu_gridReservas"
        '
        'txtTrabajador
        '
        Me.txtTrabajador.Enabled = False
        Me.txtTrabajador.Location = New System.Drawing.Point(167, 102)
        Me.txtTrabajador.Name = "txtTrabajador"
        Me.txtTrabajador.Properties.LookAndFeel.SkinMaskColor = System.Drawing.Color.Aquamarine
        Me.txtTrabajador.Size = New System.Drawing.Size(109, 20)
        Me.txtTrabajador.TabIndex = 6
        '
        'frmReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1158, 572)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmReserva"
        Me.Text = "frmReserva"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.puMenu_btnDropDown_Filtro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.MemoExEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoHabitacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboxEstadoReserva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateFechaSalida.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateFechaSalida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateFechaIngreso.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateFechaIngreso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateFechaReserva.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateFechaReserva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIDTrabajador.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboxTipoReserva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCosto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIDHabitacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdReserva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.puMenu_gridReservas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTrabajador.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents idReserva As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents idHabitacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents numero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents idCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nombreCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCargarLista As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblTotalRegistros As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnReporte As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtBuscar As DevExpress.XtraEditors.SearchControl
    Friend WithEvents btnDD_Filtro As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboxTipoReserva As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCosto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIDHabitacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtIdReserva As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIDTrabajador As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIdCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents dateFechaReserva As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dateFechaIngreso As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dateFechaSalida As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SeparatorControl2 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents txtNoHabitacion As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents cboxEstadoReserva As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCliente As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents puMenu_gridReservas As DevExpress.XtraBars.PopupMenu
    Friend WithEvents pu_btn_Editar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pu_btn_Eliminar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents pu_btn_Nom As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pu_btn_Desc As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pu_btn_Tipo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pu_btn_Precio As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pu_btn_Estado As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pu_btn_Piso As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pu_btn_Numero As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents puMenu_btnDropDown_Filtro As DevExpress.XtraBars.PopupMenu
    Friend WithEvents idTrabajador As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nombreTrabajador As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tipoReserva As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fechaReserva As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fechaIngreso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fechaSalida As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents costoAlojamiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents observacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents estado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MemoExEdit1 As DevExpress.XtraEditors.MemoExEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTrabajador As DevExpress.XtraEditors.TextEdit
End Class
