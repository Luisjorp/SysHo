<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHabitaciones
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, Nothing, True, False)
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.cboxTipoHabitacion = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.cboxEstado = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPrecioDiario = New DevExpress.XtraEditors.TextEdit()
        Me.txtCaracteristicas = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDescripcion = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cboxPiso = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNoHabitacion = New DevExpress.XtraEditors.TextEdit()
        Me.txtidHabitacion = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.btnReporte = New DevExpress.XtraEditors.SimpleButton()
        Me.txtBuscar = New DevExpress.XtraEditors.SearchControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.pu_btn_Editar = New DevExpress.XtraBars.BarButtonItem()
        Me.pu_btn_Eliminar = New DevExpress.XtraBars.BarButtonItem()
        Me.pu_btn_Car = New DevExpress.XtraBars.BarButtonItem()
        Me.pu_btn_Desc = New DevExpress.XtraBars.BarButtonItem()
        Me.pu_btn_Tipo = New DevExpress.XtraBars.BarButtonItem()
        Me.pu_btn_Precio = New DevExpress.XtraBars.BarButtonItem()
        Me.pu_btn_Estado = New DevExpress.XtraBars.BarButtonItem()
        Me.pu_btn_Piso = New DevExpress.XtraBars.BarButtonItem()
        Me.pu_btn_Numero = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDD_Filtro = New DevExpress.XtraEditors.DropDownButton()
        Me.puMenu_btnDropDown_Filtro = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.idHabitacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.numero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.piso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.descripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.caracteristicas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.precioDiario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.estado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tipoHabitacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnCargarLista = New DevExpress.XtraEditors.SimpleButton()
        Me.lblTotalRegistros = New DevExpress.XtraEditors.LabelControl()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.puMenu_gridHabitaciones = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cboxTipoHabitacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboxEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecioDiario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCaracteristicas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboxPiso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoHabitacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtidHabitacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.puMenu_btnDropDown_Filtro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.puMenu_gridHabitaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplashScreenManager1
        '
        SplashScreenManager1.ClosingDelay = 500
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(128, 29)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Habitación"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.btnCancelar)
        Me.GroupControl1.Controls.Add(Me.btnGuardar)
        Me.GroupControl1.Controls.Add(Me.btnNuevo)
        Me.GroupControl1.Controls.Add(Me.cboxTipoHabitacion)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.cboxEstado)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.txtPrecioDiario)
        Me.GroupControl1.Controls.Add(Me.txtCaracteristicas)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txtDescripcion)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.cboxPiso)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txtNoHabitacion)
        Me.GroupControl1.Controls.Add(Me.txtidHabitacion)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 47)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(448, 454)
        Me.GroupControl1.TabIndex = 3
        Me.GroupControl1.Text = "Registro de Habitaciones"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(386, 27)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(13, 13)
        Me.LabelControl9.TabIndex = 18
        Me.LabelControl9.Text = "H-"
        '
        'btnCancelar
        '
        Me.btnCancelar.ImageUri.Uri = "Cancel;Size16x16;Office2013"
        Me.btnCancelar.Location = New System.Drawing.Point(338, 412)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 17
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnGuardar
        '
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnGuardar.ImageUri.Uri = "Apply;Size16x16;Office2013"
        Me.btnGuardar.Location = New System.Drawing.Point(257, 412)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 16
        Me.btnGuardar.Text = "Guardar"
        '
        'btnNuevo
        '
        Me.btnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnNuevo.ImageUri.Uri = "AddItem;Size16x16;Office2013"
        Me.btnNuevo.Location = New System.Drawing.Point(94, 412)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 15
        Me.btnNuevo.Text = "Nuevo"
        '
        'cboxTipoHabitacion
        '
        Me.cboxTipoHabitacion.EditValue = ""
        Me.cboxTipoHabitacion.Location = New System.Drawing.Point(94, 373)
        Me.cboxTipoHabitacion.Name = "cboxTipoHabitacion"
        Me.cboxTipoHabitacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboxTipoHabitacion.Properties.Items.AddRange(New Object() {"Individual", "Matrimonial", "Familiar", "Presidencial"})
        Me.cboxTipoHabitacion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboxTipoHabitacion.Size = New System.Drawing.Size(145, 20)
        Me.cboxTipoHabitacion.TabIndex = 14
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(13, 376)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl8.TabIndex = 13
        Me.LabelControl8.Text = "Tipo Habitación:"
        '
        'cboxEstado
        '
        Me.cboxEstado.EditValue = ""
        Me.cboxEstado.Location = New System.Drawing.Point(94, 344)
        Me.cboxEstado.Name = "cboxEstado"
        Me.cboxEstado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboxEstado.Properties.Items.AddRange(New Object() {"Disponible", "Ocupado", "Mantenimiento"})
        Me.cboxEstado.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboxEstado.Size = New System.Drawing.Size(145, 20)
        Me.cboxEstado.TabIndex = 12
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(51, 347)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl7.TabIndex = 11
        Me.LabelControl7.Text = "Estado:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(25, 311)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl6.TabIndex = 10
        Me.LabelControl6.Text = "Precio Diario:"
        '
        'txtPrecioDiario
        '
        Me.txtPrecioDiario.Location = New System.Drawing.Point(94, 308)
        Me.txtPrecioDiario.Name = "txtPrecioDiario"
        Me.txtPrecioDiario.Properties.Mask.BeepOnError = True
        Me.txtPrecioDiario.Properties.Mask.EditMask = "###,###,##0.00"
        Me.txtPrecioDiario.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPrecioDiario.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPrecioDiario.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioDiario.TabIndex = 9
        '
        'txtCaracteristicas
        '
        Me.txtCaracteristicas.Location = New System.Drawing.Point(94, 204)
        Me.txtCaracteristicas.Name = "txtCaracteristicas"
        Me.txtCaracteristicas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCaracteristicas.Properties.Appearance.Options.UseFont = True
        Me.txtCaracteristicas.Size = New System.Drawing.Size(238, 90)
        Me.txtCaracteristicas.TabIndex = 8
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(13, 206)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl5.TabIndex = 7
        Me.LabelControl5.Text = "Características:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(94, 108)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDescripcion.Properties.Appearance.Options.UseFont = True
        Me.txtDescripcion.Size = New System.Drawing.Size(238, 89)
        Me.txtDescripcion.TabIndex = 6
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(30, 110)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl4.TabIndex = 5
        Me.LabelControl4.Text = "Descripción:"
        '
        'cboxPiso
        '
        Me.cboxPiso.EditValue = "1"
        Me.cboxPiso.Location = New System.Drawing.Point(94, 76)
        Me.cboxPiso.Name = "cboxPiso"
        Me.cboxPiso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboxPiso.Properties.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        Me.cboxPiso.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboxPiso.Size = New System.Drawing.Size(60, 20)
        Me.cboxPiso.TabIndex = 4
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(65, 79)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl3.TabIndex = 3
        Me.LabelControl3.Text = "Piso:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(13, 51)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "No. Habitación:"
        '
        'txtNoHabitacion
        '
        Me.txtNoHabitacion.Location = New System.Drawing.Point(94, 48)
        Me.txtNoHabitacion.Name = "txtNoHabitacion"
        Me.txtNoHabitacion.Size = New System.Drawing.Size(100, 20)
        Me.txtNoHabitacion.TabIndex = 1
        '
        'txtidHabitacion
        '
        Me.txtidHabitacion.EditValue = ""
        Me.txtidHabitacion.Location = New System.Drawing.Point(401, 24)
        Me.txtidHabitacion.Name = "txtidHabitacion"
        Me.txtidHabitacion.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtidHabitacion.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtidHabitacion.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtidHabitacion.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtidHabitacion.Properties.ReadOnly = True
        Me.txtidHabitacion.Size = New System.Drawing.Size(42, 20)
        Me.txtidHabitacion.TabIndex = 0
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
        Me.GroupControl2.TabIndex = 4
        Me.GroupControl2.Text = "Listado de Habitaciones"
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
        Me.txtBuscar.MenuManager = Me.BarManager1
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton()})
        Me.txtBuscar.Properties.NullValuePrompt = "Escriba el texto a buscar de acuerdo al filtro establecido a la derecha..."
        Me.txtBuscar.Properties.ShowSearchButton = False
        Me.txtBuscar.Size = New System.Drawing.Size(369, 20)
        Me.txtBuscar.TabIndex = 10
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.pu_btn_Editar, Me.pu_btn_Eliminar, Me.pu_btn_Car, Me.pu_btn_Desc, Me.pu_btn_Tipo, Me.pu_btn_Precio, Me.pu_btn_Estado, Me.pu_btn_Piso, Me.pu_btn_Numero})
        Me.BarManager1.MaxItemId = 15
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
        'pu_btn_Car
        '
        Me.pu_btn_Car.Caption = "Características"
        Me.pu_btn_Car.Id = 8
        Me.pu_btn_Car.ImageOptions.ImageUri.Uri = "ListBullets;Size16x16"
        Me.pu_btn_Car.Name = "pu_btn_Car"
        '
        'pu_btn_Desc
        '
        Me.pu_btn_Desc.Caption = "Descripción"
        Me.pu_btn_Desc.Id = 9
        Me.pu_btn_Desc.ImageOptions.ImageUri.Uri = "Columns;Size16x16"
        Me.pu_btn_Desc.Name = "pu_btn_Desc"
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
        'btnDD_Filtro
        '
        Me.btnDD_Filtro.DropDownControl = Me.puMenu_btnDropDown_Filtro
        Me.btnDD_Filtro.ImageUri.Uri = "Filter;Size16x16;Office2013"
        Me.btnDD_Filtro.Location = New System.Drawing.Point(383, 46)
        Me.btnDD_Filtro.MenuManager = Me.BarManager1
        Me.btnDD_Filtro.Name = "btnDD_Filtro"
        Me.btnDD_Filtro.Size = New System.Drawing.Size(117, 23)
        Me.btnDD_Filtro.TabIndex = 9
        Me.btnDD_Filtro.Text = "Características"
        '
        'puMenu_btnDropDown_Filtro
        '
        Me.puMenu_btnDropDown_Filtro.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.pu_btn_Car), New DevExpress.XtraBars.LinkPersistInfo(Me.pu_btn_Desc), New DevExpress.XtraBars.LinkPersistInfo(Me.pu_btn_Tipo), New DevExpress.XtraBars.LinkPersistInfo(Me.pu_btn_Precio), New DevExpress.XtraBars.LinkPersistInfo(Me.pu_btn_Estado), New DevExpress.XtraBars.LinkPersistInfo(Me.pu_btn_Piso), New DevExpress.XtraBars.LinkPersistInfo(Me.pu_btn_Numero)})
        Me.puMenu_btnDropDown_Filtro.Manager = Me.BarManager1
        Me.puMenu_btnDropDown_Filtro.Name = "puMenu_btnDropDown_Filtro"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(8, 109)
        Me.GridControl1.LookAndFeel.SkinName = "Office 2007 Green"
        Me.GridControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.BarManager1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(583, 297)
        Me.GridControl1.TabIndex = 8
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.MintCream
        Me.GridView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Moccasin
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.idHabitacion, Me.numero, Me.piso, Me.descripcion, Me.caracteristicas, Me.precioDiario, Me.estado, Me.tipoHabitacion})
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
        'idHabitacion
        '
        Me.idHabitacion.Caption = "ID Habitacion"
        Me.idHabitacion.FieldName = "idHabitacion"
        Me.idHabitacion.Name = "idHabitacion"
        Me.idHabitacion.OptionsColumn.AllowEdit = False
        Me.idHabitacion.OptionsColumn.ReadOnly = True
        Me.idHabitacion.Tag = "idhabitacion"
        '
        'numero
        '
        Me.numero.Caption = "Numero"
        Me.numero.FieldName = "numero"
        Me.numero.Name = "numero"
        Me.numero.OptionsColumn.AllowEdit = False
        Me.numero.OptionsColumn.ReadOnly = True
        Me.numero.Visible = True
        Me.numero.VisibleIndex = 0
        '
        'piso
        '
        Me.piso.Caption = "Piso"
        Me.piso.FieldName = "piso"
        Me.piso.Name = "piso"
        Me.piso.OptionsColumn.AllowEdit = False
        Me.piso.OptionsColumn.ReadOnly = True
        Me.piso.Visible = True
        Me.piso.VisibleIndex = 1
        '
        'descripcion
        '
        Me.descripcion.Caption = "Descripcion"
        Me.descripcion.FieldName = "descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.OptionsColumn.AllowEdit = False
        Me.descripcion.OptionsColumn.ReadOnly = True
        Me.descripcion.Visible = True
        Me.descripcion.VisibleIndex = 2
        '
        'caracteristicas
        '
        Me.caracteristicas.Caption = "Características"
        Me.caracteristicas.FieldName = "caracteristicas"
        Me.caracteristicas.Name = "caracteristicas"
        Me.caracteristicas.OptionsColumn.AllowEdit = False
        Me.caracteristicas.OptionsColumn.ReadOnly = True
        Me.caracteristicas.Visible = True
        Me.caracteristicas.VisibleIndex = 3
        '
        'precioDiario
        '
        Me.precioDiario.Caption = "Precio Diario"
        Me.precioDiario.FieldName = "precioDiario"
        Me.precioDiario.Name = "precioDiario"
        Me.precioDiario.OptionsColumn.AllowEdit = False
        Me.precioDiario.OptionsColumn.ReadOnly = True
        Me.precioDiario.Visible = True
        Me.precioDiario.VisibleIndex = 4
        '
        'estado
        '
        Me.estado.Caption = "Estado"
        Me.estado.FieldName = "estado"
        Me.estado.Name = "estado"
        Me.estado.OptionsColumn.AllowEdit = False
        Me.estado.OptionsColumn.ReadOnly = True
        Me.estado.Visible = True
        Me.estado.VisibleIndex = 5
        '
        'tipoHabitacion
        '
        Me.tipoHabitacion.Caption = "Tipo Habitación"
        Me.tipoHabitacion.FieldName = "tipoHabitacion"
        Me.tipoHabitacion.Name = "tipoHabitacion"
        Me.tipoHabitacion.OptionsColumn.AllowEdit = False
        Me.tipoHabitacion.OptionsColumn.ReadOnly = True
        Me.tipoHabitacion.Visible = True
        Me.tipoHabitacion.VisibleIndex = 6
        '
        'btnCargarLista
        '
        Me.btnCargarLista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCargarLista.ImageUri.Uri = "CustomizeGrid;Size16x16;Office2013"
        Me.btnCargarLista.Location = New System.Drawing.Point(8, 412)
        Me.btnCargarLista.Name = "btnCargarLista"
        Me.btnCargarLista.Size = New System.Drawing.Size(115, 23)
        Me.btnCargarLista.TabIndex = 7
        Me.btnCargarLista.Text = "Cargar Listado"
        '
        'lblTotalRegistros
        '
        Me.lblTotalRegistros.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalRegistros.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblTotalRegistros.Appearance.Options.UseFont = True
        Me.lblTotalRegistros.Location = New System.Drawing.Point(352, 415)
        Me.lblTotalRegistros.Name = "lblTotalRegistros"
        Me.lblTotalRegistros.Size = New System.Drawing.Size(140, 16)
        Me.lblTotalRegistros.TabIndex = 4
        Me.lblTotalRegistros.Text = "Registro de habitaciones"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'puMenu_gridHabitaciones
        '
        Me.puMenu_gridHabitaciones.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.pu_btn_Editar), New DevExpress.XtraBars.LinkPersistInfo(Me.pu_btn_Eliminar)})
        Me.puMenu_gridHabitaciones.Manager = Me.BarManager1
        Me.puMenu_gridHabitaciones.Name = "puMenu_gridHabitaciones"
        '
        'frmHabitaciones
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
        Me.Name = "frmHabitaciones"
        Me.Text = "Registro de Habitaciones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cboxTipoHabitacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboxEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecioDiario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCaracteristicas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboxPiso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoHabitacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtidHabitacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.puMenu_btnDropDown_Filtro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.puMenu_gridHabitaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboxTipoHabitacion As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboxEstado As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrecioDiario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCaracteristicas As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboxPiso As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNoHabitacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtidHabitacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblTotalRegistros As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents btnCargarLista As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents puMenu_gridHabitaciones As DevExpress.XtraBars.PopupMenu
    Friend WithEvents pu_btn_Editar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pu_btn_Eliminar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents idHabitacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents numero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents piso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents descripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents caracteristicas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents precioDiario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents estado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tipoHabitacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnDD_Filtro As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents puMenu_btnDropDown_Filtro As DevExpress.XtraBars.PopupMenu
    Friend WithEvents pu_btn_Car As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pu_btn_Desc As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pu_btn_Tipo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pu_btn_Precio As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pu_btn_Estado As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pu_btn_Piso As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pu_btn_Numero As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtBuscar As DevExpress.XtraEditors.SearchControl
    Friend WithEvents btnReporte As DevExpress.XtraEditors.SimpleButton
End Class
