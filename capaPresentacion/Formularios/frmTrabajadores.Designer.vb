<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrabajadores
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
        Me.btnReporte = New DevExpress.XtraEditors.SimpleButton()
        Me.txtBuscar = New DevExpress.XtraEditors.SearchControl()
        Me.btnDD_Filtro = New DevExpress.XtraEditors.DropDownButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.idPersona = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.nombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.apellido = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tipoDocumento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.noDocumento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.direccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.telefono = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.email = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sueldo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.acceso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.login = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.password = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.estado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnCargarLista = New DevExpress.XtraEditors.SimpleButton()
        Me.lblTotalRegistros = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.cboxEstado = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtLogin = New DevExpress.XtraEditors.TextEdit()
        Me.cboxAcceso = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSueldo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTelefono = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDireccion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNoDocumento = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtApellido = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.cboxTipoDocumento = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIdPersona = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.puMenu_gridClientes = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.pu_btn_Editar = New DevExpress.XtraBars.BarButtonItem()
        Me.pu_btn_Eliminar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.pu_btn_Nom = New DevExpress.XtraBars.BarButtonItem()
        Me.pu_btn_Ape = New DevExpress.XtraBars.BarButtonItem()
        Me.pu_btn_Tipo = New DevExpress.XtraBars.BarButtonItem()
        Me.pu_btn_Precio = New DevExpress.XtraBars.BarButtonItem()
        Me.pu_btn_Estado = New DevExpress.XtraBars.BarButtonItem()
        Me.pu_btn_Piso = New DevExpress.XtraBars.BarButtonItem()
        Me.pu_btn_Numero = New DevExpress.XtraBars.BarButtonItem()
        Me.pu_btn_Doc = New DevExpress.XtraBars.BarButtonItem()
        Me.puMenu_btnDropDown_Filtro = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cboxEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLogin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboxAcceso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSueldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApellido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboxTipoDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdPersona.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.puMenu_gridClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.puMenu_btnDropDown_Filtro, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupControl2.Controls.Add(Me.btnReporte)
        Me.GroupControl2.Controls.Add(Me.txtBuscar)
        Me.GroupControl2.Controls.Add(Me.btnDD_Filtro)
        Me.GroupControl2.Controls.Add(Me.GridControl1)
        Me.GroupControl2.Controls.Add(Me.btnCargarLista)
        Me.GroupControl2.Controls.Add(Me.lblTotalRegistros)
        Me.GroupControl2.Location = New System.Drawing.Point(478, 47)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(596, 454)
        Me.GroupControl2.TabIndex = 10
        Me.GroupControl2.Text = "Listado de Trabajadores"
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
        Me.btnDD_Filtro.ImageUri.Uri = "Filter;Size16x16;Office2013"
        Me.btnDD_Filtro.Location = New System.Drawing.Point(383, 46)
        Me.btnDD_Filtro.Name = "btnDD_Filtro"
        Me.btnDD_Filtro.Size = New System.Drawing.Size(117, 23)
        Me.btnDD_Filtro.TabIndex = 18
        Me.btnDD_Filtro.Text = "No. Documento"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(8, 109)
        Me.GridControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(583, 297)
        Me.GridControl1.TabIndex = 20
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.MintCream
        Me.GridView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Moccasin
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.idPersona, Me.nombre, Me.apellido, Me.tipoDocumento, Me.noDocumento, Me.direccion, Me.telefono, Me.email, Me.sueldo, Me.acceso, Me.login, Me.password, Me.estado})
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
        'idPersona
        '
        Me.idPersona.Caption = "ID Persona"
        Me.idPersona.FieldName = "idPersona"
        Me.idPersona.Name = "idPersona"
        Me.idPersona.OptionsColumn.AllowEdit = False
        Me.idPersona.OptionsColumn.ReadOnly = True
        Me.idPersona.Tag = ""
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
        Me.nombre.Width = 72
        '
        'apellido
        '
        Me.apellido.Caption = "Apellido"
        Me.apellido.FieldName = "apellido"
        Me.apellido.Name = "apellido"
        Me.apellido.OptionsColumn.FixedWidth = True
        Me.apellido.Visible = True
        Me.apellido.VisibleIndex = 1
        Me.apellido.Width = 72
        '
        'tipoDocumento
        '
        Me.tipoDocumento.Caption = "Documento"
        Me.tipoDocumento.FieldName = "tipoDocumento"
        Me.tipoDocumento.Name = "tipoDocumento"
        Me.tipoDocumento.Visible = True
        Me.tipoDocumento.VisibleIndex = 2
        Me.tipoDocumento.Width = 30
        '
        'noDocumento
        '
        Me.noDocumento.Caption = "No. Documento"
        Me.noDocumento.FieldName = "noDocumento"
        Me.noDocumento.Name = "noDocumento"
        Me.noDocumento.Visible = True
        Me.noDocumento.VisibleIndex = 3
        Me.noDocumento.Width = 60
        '
        'direccion
        '
        Me.direccion.Caption = "Dirección"
        Me.direccion.FieldName = "direccion"
        Me.direccion.Name = "direccion"
        Me.direccion.Visible = True
        Me.direccion.VisibleIndex = 4
        Me.direccion.Width = 130
        '
        'telefono
        '
        Me.telefono.Caption = "Teléfono"
        Me.telefono.FieldName = "telefono"
        Me.telefono.Name = "telefono"
        Me.telefono.OptionsColumn.FixedWidth = True
        Me.telefono.Visible = True
        Me.telefono.VisibleIndex = 5
        Me.telefono.Width = 56
        '
        'email
        '
        Me.email.Caption = "Email"
        Me.email.FieldName = "email"
        Me.email.Name = "email"
        Me.email.OptionsColumn.FixedWidth = True
        Me.email.Visible = True
        Me.email.VisibleIndex = 6
        Me.email.Width = 117
        '
        'sueldo
        '
        Me.sueldo.Caption = "Sueldo"
        Me.sueldo.FieldName = "sueldo"
        Me.sueldo.Name = "sueldo"
        Me.sueldo.Visible = True
        Me.sueldo.VisibleIndex = 7
        Me.sueldo.Width = 30
        '
        'acceso
        '
        Me.acceso.Caption = "Acceso"
        Me.acceso.FieldName = "acceso"
        Me.acceso.Name = "acceso"
        Me.acceso.Visible = True
        Me.acceso.VisibleIndex = 8
        '
        'login
        '
        Me.login.Caption = "Usuario"
        Me.login.FieldName = "login"
        Me.login.Name = "login"
        Me.login.Visible = True
        Me.login.VisibleIndex = 9
        '
        'password
        '
        Me.password.Caption = "Password"
        Me.password.FieldName = "password"
        Me.password.Name = "password"
        '
        'estado
        '
        Me.estado.Caption = "Estado"
        Me.estado.FieldName = "estado"
        Me.estado.Name = "estado"
        Me.estado.Visible = True
        Me.estado.VisibleIndex = 11
        '
        'btnCargarLista
        '
        Me.btnCargarLista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCargarLista.ImageUri.Uri = "CustomizeGrid;Size16x16;Office2013"
        Me.btnCargarLista.Location = New System.Drawing.Point(8, 412)
        Me.btnCargarLista.Name = "btnCargarLista"
        Me.btnCargarLista.Size = New System.Drawing.Size(115, 23)
        Me.btnCargarLista.TabIndex = 16
        Me.btnCargarLista.Text = "Cargar Listado"
        '
        'lblTotalRegistros
        '
        Me.lblTotalRegistros.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalRegistros.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblTotalRegistros.Appearance.Options.UseFont = True
        Me.lblTotalRegistros.Location = New System.Drawing.Point(352, 415)
        Me.lblTotalRegistros.Name = "lblTotalRegistros"
        Me.lblTotalRegistros.Size = New System.Drawing.Size(130, 16)
        Me.lblTotalRegistros.TabIndex = 4
        Me.lblTotalRegistros.Text = "Empleados registrados"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.cboxEstado)
        Me.GroupControl1.Controls.Add(Me.LabelControl13)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Controls.Add(Me.txtPassword)
        Me.GroupControl1.Controls.Add(Me.SeparatorControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.txtLogin)
        Me.GroupControl1.Controls.Add(Me.cboxAcceso)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.txtSueldo)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.txtEmail)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.txtTelefono)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.txtDireccion)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txtNoDocumento)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.txtApellido)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txtNombre)
        Me.GroupControl1.Controls.Add(Me.btnCancelar)
        Me.GroupControl1.Controls.Add(Me.btnGuardar)
        Me.GroupControl1.Controls.Add(Me.btnNuevo)
        Me.GroupControl1.Controls.Add(Me.cboxTipoDocumento)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtIdPersona)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 47)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(448, 454)
        Me.GroupControl1.TabIndex = 9
        Me.GroupControl1.Text = "Registro de Trabajadores"
        '
        'cboxEstado
        '
        Me.cboxEstado.EditValue = "A"
        Me.cboxEstado.Location = New System.Drawing.Point(101, 374)
        Me.cboxEstado.Name = "cboxEstado"
        Me.cboxEstado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboxEstado.Properties.DropDownRows = 5
        Me.cboxEstado.Properties.Items.AddRange(New Object() {"A", "I"})
        Me.cboxEstado.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboxEstado.Size = New System.Drawing.Size(41, 20)
        Me.cboxEstado.TabIndex = 12
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(58, 377)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl13.TabIndex = 41
        Me.LabelControl13.Text = "Estado:"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(45, 347)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl12.TabIndex = 39
        Me.LabelControl12.Text = "Password:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(101, 344)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.Mask.BeepOnError = True
        Me.txtPassword.Properties.Mask.EditMask = "f"
        Me.txtPassword.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPassword.Size = New System.Drawing.Size(153, 20)
        Me.txtPassword.TabIndex = 11
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Location = New System.Drawing.Point(14, 265)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(381, 23)
        Me.SeparatorControl1.TabIndex = 37
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(55, 321)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl11.TabIndex = 36
        Me.LabelControl11.Text = "Usuario:"
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(101, 318)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Properties.Mask.BeepOnError = True
        Me.txtLogin.Properties.Mask.EditMask = "f"
        Me.txtLogin.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtLogin.Size = New System.Drawing.Size(153, 20)
        Me.txtLogin.TabIndex = 10
        '
        'cboxAcceso
        '
        Me.cboxAcceso.EditValue = "Recepcionista"
        Me.cboxAcceso.Location = New System.Drawing.Point(101, 289)
        Me.cboxAcceso.Name = "cboxAcceso"
        Me.cboxAcceso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboxAcceso.Properties.DropDownRows = 5
        Me.cboxAcceso.Properties.Items.AddRange(New Object() {"Administrador", "Digitador", "Empleado", "Recepcionista"})
        Me.cboxAcceso.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboxAcceso.Size = New System.Drawing.Size(153, 20)
        Me.cboxAcceso.TabIndex = 9
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(57, 292)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl10.TabIndex = 34
        Me.LabelControl10.Text = "Acceso:"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(59, 245)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl9.TabIndex = 32
        Me.LabelControl9.Text = "Sueldo:"
        '
        'txtSueldo
        '
        Me.txtSueldo.Location = New System.Drawing.Point(101, 242)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Properties.Mask.BeepOnError = True
        Me.txtSueldo.Properties.Mask.EditMask = "f"
        Me.txtSueldo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSueldo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtSueldo.Size = New System.Drawing.Size(123, 20)
        Me.txtSueldo.TabIndex = 8
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(63, 219)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl8.TabIndex = 30
        Me.LabelControl8.Text = "E-mail:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(101, 216)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Properties.Mask.BeepOnError = True
        Me.txtEmail.Properties.Mask.EditMask = "(0?\d|1\d|2[0-3])\:[0-5]\d"
        Me.txtEmail.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtEmail.Size = New System.Drawing.Size(178, 20)
        Me.txtEmail.TabIndex = 7
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(49, 192)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl7.TabIndex = 28
        Me.LabelControl7.Text = "Teléfono:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(101, 189)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Properties.Mask.BeepOnError = True
        Me.txtTelefono.Properties.Mask.EditMask = "(999) 000-0000"
        Me.txtTelefono.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTelefono.Size = New System.Drawing.Size(123, 20)
        Me.txtTelefono.TabIndex = 6
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(48, 164)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl6.TabIndex = 26
        Me.LabelControl6.Text = "Dirección:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(101, 161)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Properties.Mask.BeepOnError = True
        Me.txtDireccion.Properties.Mask.EditMask = "###,###,##0.00"
        Me.txtDireccion.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDireccion.Size = New System.Drawing.Size(294, 20)
        Me.txtDireccion.TabIndex = 5
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(17, 136)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl5.TabIndex = 24
        Me.LabelControl5.Text = "No. Documento:"
        '
        'txtNoDocumento
        '
        Me.txtNoDocumento.Location = New System.Drawing.Point(101, 133)
        Me.txtNoDocumento.Name = "txtNoDocumento"
        Me.txtNoDocumento.Properties.Mask.BeepOnError = True
        Me.txtNoDocumento.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNoDocumento.Size = New System.Drawing.Size(178, 20)
        Me.txtNoDocumento.TabIndex = 4
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(54, 84)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl4.TabIndex = 22
        Me.LabelControl4.Text = "Apellido:"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(101, 81)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Properties.Mask.BeepOnError = True
        Me.txtApellido.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtApellido.Size = New System.Drawing.Size(231, 20)
        Me.txtApellido.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(54, 53)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl2.TabIndex = 20
        Me.LabelControl2.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(101, 50)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.Mask.BeepOnError = True
        Me.txtNombre.Properties.Mask.EditMask = "###,###,##0.00"
        Me.txtNombre.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNombre.Size = New System.Drawing.Size(231, 20)
        Me.txtNombre.TabIndex = 1
        '
        'btnCancelar
        '
        Me.btnCancelar.ImageUri.Uri = "Cancel;Size16x16;Office2013"
        Me.btnCancelar.Location = New System.Drawing.Point(345, 412)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnGuardar
        '
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnGuardar.ImageUri.Uri = "Apply;Size16x16;Office2013"
        Me.btnGuardar.Location = New System.Drawing.Point(264, 412)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 14
        Me.btnGuardar.Text = "Guardar"
        '
        'btnNuevo
        '
        Me.btnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnNuevo.ImageUri.Uri = "AddItem;Size16x16;Office2013"
        Me.btnNuevo.Location = New System.Drawing.Point(101, 412)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 13
        Me.btnNuevo.Text = "Nuevo"
        '
        'cboxTipoDocumento
        '
        Me.cboxTipoDocumento.EditValue = "DPI"
        Me.cboxTipoDocumento.Location = New System.Drawing.Point(101, 106)
        Me.cboxTipoDocumento.Name = "cboxTipoDocumento"
        Me.cboxTipoDocumento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboxTipoDocumento.Properties.DropDownRows = 5
        Me.cboxTipoDocumento.Properties.Items.AddRange(New Object() {"DPI", "DUI", "LIBRETA MILITAR", "PASAPORTE", "Otro"})
        Me.cboxTipoDocumento.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboxTipoDocumento.Size = New System.Drawing.Size(153, 20)
        Me.cboxTipoDocumento.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(14, 109)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl3.TabIndex = 3
        Me.LabelControl3.Text = "Tipo Documento:"
        '
        'txtIdPersona
        '
        Me.txtIdPersona.Location = New System.Drawing.Point(343, 50)
        Me.txtIdPersona.Name = "txtIdPersona"
        Me.txtIdPersona.Size = New System.Drawing.Size(100, 20)
        Me.txtIdPersona.TabIndex = 1
        Me.txtIdPersona.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(157, 29)
        Me.LabelControl1.TabIndex = 8
        Me.LabelControl1.Text = "Trabajadores"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'puMenu_gridClientes
        '
        Me.puMenu_gridClientes.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.pu_btn_Editar), New DevExpress.XtraBars.LinkPersistInfo(Me.pu_btn_Eliminar)})
        Me.puMenu_gridClientes.Manager = Me.BarManager1
        Me.puMenu_gridClientes.Name = "puMenu_gridClientes"
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
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.pu_btn_Editar, Me.pu_btn_Eliminar, Me.pu_btn_Nom, Me.pu_btn_Ape, Me.pu_btn_Tipo, Me.pu_btn_Precio, Me.pu_btn_Estado, Me.pu_btn_Piso, Me.pu_btn_Numero, Me.pu_btn_Doc})
        Me.BarManager1.MaxItemId = 16
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1086, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 513)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1086, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 513)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1086, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 513)
        '
        'pu_btn_Nom
        '
        Me.pu_btn_Nom.Caption = "Nombre"
        Me.pu_btn_Nom.Id = 8
        Me.pu_btn_Nom.ImageOptions.ImageUri.Uri = "AlignHorizontalTop;Size16x16"
        Me.pu_btn_Nom.Name = "pu_btn_Nom"
        '
        'pu_btn_Ape
        '
        Me.pu_btn_Ape.Caption = "Apellido"
        Me.pu_btn_Ape.Id = 9
        Me.pu_btn_Ape.ImageOptions.ImageUri.Uri = "AlignHorizontalCenter;Size16x16"
        Me.pu_btn_Ape.Name = "pu_btn_Ape"
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
        'pu_btn_Doc
        '
        Me.pu_btn_Doc.Caption = "No. Documento"
        Me.pu_btn_Doc.Id = 15
        Me.pu_btn_Doc.ImageOptions.ImageUri.Uri = "Edit;Size16x16"
        Me.pu_btn_Doc.Name = "pu_btn_Doc"
        '
        'puMenu_btnDropDown_Filtro
        '
        Me.puMenu_btnDropDown_Filtro.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.pu_btn_Nom), New DevExpress.XtraBars.LinkPersistInfo(Me.pu_btn_Ape), New DevExpress.XtraBars.LinkPersistInfo(Me.pu_btn_Doc)})
        Me.puMenu_btnDropDown_Filtro.Manager = Me.BarManager1
        Me.puMenu_btnDropDown_Filtro.Name = "puMenu_btnDropDown_Filtro"
        '
        'frmTrabajadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 513)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmTrabajadores"
        Me.Text = "Registro de Trabajadores"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cboxEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLogin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboxAcceso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSueldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApellido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboxTipoDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdPersona.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.puMenu_gridClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.puMenu_btnDropDown_Filtro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnReporte As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtBuscar As DevExpress.XtraEditors.SearchControl
    Friend WithEvents btnDD_Filtro As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents idPersona As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents apellido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tipoDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents noDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents direccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents telefono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents email As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sueldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCargarLista As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblTotalRegistros As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTelefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDireccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNoDocumento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtApellido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboxTipoDocumento As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIdPersona As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSueldo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboxEstado As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLogin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboxAcceso As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents puMenu_gridClientes As DevExpress.XtraBars.PopupMenu
    Friend WithEvents pu_btn_Editar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pu_btn_Eliminar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents pu_btn_Nom As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pu_btn_Ape As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pu_btn_Tipo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pu_btn_Precio As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pu_btn_Estado As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pu_btn_Piso As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pu_btn_Numero As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pu_btn_Doc As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents puMenu_btnDropDown_Filtro As DevExpress.XtraBars.PopupMenu
    Friend WithEvents acceso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents login As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents password As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents estado As DevExpress.XtraGrid.Columns.GridColumn
End Class
