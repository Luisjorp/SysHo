<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.btnReporte = New DevExpress.XtraEditors.SimpleButton()
        Me.txtBuscar = New DevExpress.XtraEditors.SearchControl()
        Me.btnDD_Filtro = New DevExpress.XtraEditors.DropDownButton()
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
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
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
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.cboxTipoDocumento = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIdPersona = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodCliente = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApellido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboxTipoDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdPersona.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GroupControl2.TabIndex = 7
        Me.GroupControl2.Text = "Listado de Clientes"
        '
        'btnReporte
        '
        Me.btnReporte.ImageUri.Uri = "Print;Size16x16"
        Me.btnReporte.Location = New System.Drawing.Point(506, 46)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(85, 23)
        Me.btnReporte.TabIndex = 14
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
        Me.txtBuscar.TabIndex = 12
        '
        'btnDD_Filtro
        '
        Me.btnDD_Filtro.ImageUri.Uri = "Filter;Size16x16;Office2013"
        Me.btnDD_Filtro.Location = New System.Drawing.Point(383, 46)
        Me.btnDD_Filtro.Name = "btnDD_Filtro"
        Me.btnDD_Filtro.Size = New System.Drawing.Size(117, 23)
        Me.btnDD_Filtro.TabIndex = 13
        Me.btnDD_Filtro.Text = "Características"
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
        Me.GridControl1.TabIndex = 15
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.MintCream
        Me.GridView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Moccasin
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
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
        Me.btnCargarLista.TabIndex = 11
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
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.btnCancelar)
        Me.GroupControl1.Controls.Add(Me.btnGuardar)
        Me.GroupControl1.Controls.Add(Me.btnNuevo)
        Me.GroupControl1.Controls.Add(Me.cboxTipoDocumento)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtIdPersona)
        Me.GroupControl1.Controls.Add(Me.txtCodCliente)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 47)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(448, 315)
        Me.GroupControl1.TabIndex = 6
        Me.GroupControl1.Text = "Registro de Clientes"
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
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(372, 27)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl9.TabIndex = 18
        Me.LabelControl9.Text = "CLI-"
        '
        'btnCancelar
        '
        Me.btnCancelar.ImageUri.Uri = "Cancel;Size16x16;Office2013"
        Me.btnCancelar.Location = New System.Drawing.Point(345, 272)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnGuardar
        '
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnGuardar.ImageUri.Uri = "Apply;Size16x16;Office2013"
        Me.btnGuardar.Location = New System.Drawing.Point(264, 272)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        '
        'btnNuevo
        '
        Me.btnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnNuevo.ImageUri.Uri = "AddItem;Size16x16;Office2013"
        Me.btnNuevo.Location = New System.Drawing.Point(101, 272)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 8
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
        'txtCodCliente
        '
        Me.txtCodCliente.EditValue = ""
        Me.txtCodCliente.Location = New System.Drawing.Point(401, 24)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCodCliente.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtCodCliente.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtCodCliente.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtCodCliente.Properties.ReadOnly = True
        Me.txtCodCliente.Size = New System.Drawing.Size(42, 20)
        Me.txtCodCliente.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(95, 29)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Clientes"
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 513)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "frmClientes"
        Me.Text = "Registro de Clientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApellido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboxTipoDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdPersona.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnReporte As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtBuscar As DevExpress.XtraEditors.SearchControl
    Friend WithEvents btnDD_Filtro As DevExpress.XtraEditors.DropDownButton
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
    Friend WithEvents btnCargarLista As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblTotalRegistros As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboxTipoDocumento As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIdPersona As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtApellido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNoDocumento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTelefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDireccion As DevExpress.XtraEditors.TextEdit
End Class
