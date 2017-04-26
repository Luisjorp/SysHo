<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductos
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
        Me.idProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.nombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.descripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.unidadMedida = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.precioVenta = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.cboxUnidadMedida = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPrecioVenta = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescripcionProducto = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNombreProducto = New DevExpress.XtraEditors.TextEdit()
        Me.txtIdProducto = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.puMenu_gridProductos = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.puMenu_btnDropDown_Filtro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cboxUnidadMedida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecioVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.puMenu_gridProductos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupControl2.Location = New System.Drawing.Point(478, 47)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(666, 513)
        Me.GroupControl2.TabIndex = 7
        Me.GroupControl2.Text = "Listado de Productos"
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
        Me.GridControl1.TabIndex = 14
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.idProducto, Me.nombre, Me.descripcion, Me.unidadMedida, Me.precioVenta})
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
        'idProducto
        '
        Me.idProducto.Caption = "ID Producto"
        Me.idProducto.FieldName = "idProducto"
        Me.idProducto.Name = "idProducto"
        Me.idProducto.OptionsColumn.AllowEdit = False
        Me.idProducto.OptionsColumn.FixedWidth = True
        Me.idProducto.OptionsColumn.ReadOnly = True
        Me.idProducto.Tag = "idProducto"
        '
        'nombre
        '
        Me.nombre.Caption = "Nombre"
        Me.nombre.FieldName = "nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.OptionsColumn.AllowEdit = False
        Me.nombre.OptionsColumn.FixedWidth = True
        Me.nombre.OptionsColumn.ReadOnly = True
        Me.nombre.Visible = True
        Me.nombre.VisibleIndex = 0
        Me.nombre.Width = 40
        '
        'descripcion
        '
        Me.descripcion.Caption = "Descripcion"
        Me.descripcion.FieldName = "descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.OptionsColumn.AllowEdit = False
        Me.descripcion.OptionsColumn.FixedWidth = True
        Me.descripcion.OptionsColumn.ReadOnly = True
        Me.descripcion.Visible = True
        Me.descripcion.VisibleIndex = 1
        '
        'unidadMedida
        '
        Me.unidadMedida.Caption = "Unidad de Medida"
        Me.unidadMedida.FieldName = "unidadMedida"
        Me.unidadMedida.Name = "unidadMedida"
        Me.unidadMedida.OptionsColumn.AllowEdit = False
        Me.unidadMedida.OptionsColumn.FixedWidth = True
        Me.unidadMedida.OptionsColumn.ReadOnly = True
        Me.unidadMedida.Visible = True
        Me.unidadMedida.VisibleIndex = 2
        Me.unidadMedida.Width = 20
        '
        'precioVenta
        '
        Me.precioVenta.Caption = "Precio de Venta"
        Me.precioVenta.FieldName = "precioVenta"
        Me.precioVenta.Name = "precioVenta"
        Me.precioVenta.OptionsColumn.AllowEdit = False
        Me.precioVenta.OptionsColumn.FixedWidth = True
        Me.precioVenta.OptionsColumn.ReadOnly = True
        Me.precioVenta.Visible = True
        Me.precioVenta.VisibleIndex = 3
        Me.precioVenta.Width = 20
        '
        'btnCargarLista
        '
        Me.btnCargarLista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCargarLista.ImageUri.Uri = "CustomizeGrid;Size16x16;Office2013"
        Me.btnCargarLista.Location = New System.Drawing.Point(8, 466)
        Me.btnCargarLista.Name = "btnCargarLista"
        Me.btnCargarLista.Size = New System.Drawing.Size(115, 28)
        Me.btnCargarLista.TabIndex = 13
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
        Me.btnReporte.TabIndex = 11
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
        Me.txtBuscar.TabIndex = 10
        '
        'btnDD_Filtro
        '
        Me.btnDD_Filtro.DropDownControl = Me.puMenu_btnDropDown_Filtro
        Me.btnDD_Filtro.ImageUri.Uri = "Filter;Size16x16;Office2013"
        Me.btnDD_Filtro.Location = New System.Drawing.Point(383, 46)
        Me.btnDD_Filtro.Name = "btnDD_Filtro"
        Me.btnDD_Filtro.Size = New System.Drawing.Size(117, 23)
        Me.btnDD_Filtro.TabIndex = 9
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
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.btnCancelar)
        Me.GroupControl1.Controls.Add(Me.btnGuardar)
        Me.GroupControl1.Controls.Add(Me.btnNuevo)
        Me.GroupControl1.Controls.Add(Me.cboxUnidadMedida)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.txtPrecioVenta)
        Me.GroupControl1.Controls.Add(Me.txtDescripcionProducto)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txtNombreProducto)
        Me.GroupControl1.Controls.Add(Me.txtIdProducto)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 47)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(448, 351)
        Me.GroupControl1.TabIndex = 6
        Me.GroupControl1.Text = "Registro de Productos"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(386, 27)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl9.TabIndex = 18
        Me.LabelControl9.Text = "P-"
        '
        'btnCancelar
        '
        Me.btnCancelar.ImageUri.Uri = "Cancel;Size16x16;Office2013"
        Me.btnCancelar.Location = New System.Drawing.Point(353, 256)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 17
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnGuardar
        '
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnGuardar.ImageUri.Uri = "Apply;Size16x16;Office2013"
        Me.btnGuardar.Location = New System.Drawing.Point(272, 256)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 16
        Me.btnGuardar.Text = "Guardar"
        '
        'btnNuevo
        '
        Me.btnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnNuevo.ImageUri.Uri = "AddItem;Size16x16;Office2013"
        Me.btnNuevo.Location = New System.Drawing.Point(109, 256)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 15
        Me.btnNuevo.Text = "Nuevo"
        '
        'cboxUnidadMedida
        '
        Me.cboxUnidadMedida.EditValue = ""
        Me.cboxUnidadMedida.Location = New System.Drawing.Point(108, 175)
        Me.cboxUnidadMedida.Name = "cboxUnidadMedida"
        Me.cboxUnidadMedida.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboxUnidadMedida.Properties.Items.AddRange(New Object() {"KG", "UND", "LT", "MIN", "GLB"})
        Me.cboxUnidadMedida.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboxUnidadMedida.Size = New System.Drawing.Size(145, 20)
        Me.cboxUnidadMedida.TabIndex = 12
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(13, 178)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl7.TabIndex = 11
        Me.LabelControl7.Text = "Unidad de Medida:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(39, 218)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl6.TabIndex = 10
        Me.LabelControl6.Text = "Precio Venta:"
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.Location = New System.Drawing.Point(108, 215)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Properties.Mask.BeepOnError = True
        Me.txtPrecioVenta.Properties.Mask.EditMask = "###,###,##0.00"
        Me.txtPrecioVenta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPrecioVenta.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPrecioVenta.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioVenta.TabIndex = 9
        '
        'txtDescripcionProducto
        '
        Me.txtDescripcionProducto.Location = New System.Drawing.Point(108, 77)
        Me.txtDescripcionProducto.Name = "txtDescripcionProducto"
        Me.txtDescripcionProducto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDescripcionProducto.Properties.Appearance.Options.UseFont = True
        Me.txtDescripcionProducto.Size = New System.Drawing.Size(238, 89)
        Me.txtDescripcionProducto.TabIndex = 6
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(44, 79)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl4.TabIndex = 5
        Me.LabelControl4.Text = "Descripción:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(61, 51)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Nombre:"
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Location = New System.Drawing.Point(108, 48)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(238, 20)
        Me.txtNombreProducto.TabIndex = 1
        '
        'txtIdProducto
        '
        Me.txtIdProducto.EditValue = ""
        Me.txtIdProducto.Enabled = False
        Me.txtIdProducto.Location = New System.Drawing.Point(401, 24)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtIdProducto.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtIdProducto.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtIdProducto.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtIdProducto.Properties.ReadOnly = True
        Me.txtIdProducto.Size = New System.Drawing.Size(42, 20)
        Me.txtIdProducto.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(121, 29)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Productos"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'puMenu_gridProductos
        '
        Me.puMenu_gridProductos.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.pu_btn_Editar), New DevExpress.XtraBars.LinkPersistInfo(Me.pu_btn_Eliminar)})
        Me.puMenu_gridProductos.Manager = Me.BarManager1
        Me.puMenu_gridProductos.Name = "puMenu_gridProductos"
        '
        'frmProductos
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
        Me.Name = "frmProductos"
        Me.Text = "Registro de Productos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
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
        CType(Me.cboxUnidadMedida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecioVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.puMenu_gridProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnReporte As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtBuscar As DevExpress.XtraEditors.SearchControl
    Friend WithEvents btnDD_Filtro As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboxUnidadMedida As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrecioVenta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescripcionProducto As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNombreProducto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtIdProducto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents idProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents descripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents unidadMedida As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents precioVenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCargarLista As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblTotalRegistros As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents puMenu_gridProductos As DevExpress.XtraBars.PopupMenu
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
End Class
