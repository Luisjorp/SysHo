<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmerHabitación
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
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.txtBuscar = New DevExpress.XtraEditors.SearchControl()
        Me.btnDD_Filtro = New DevExpress.XtraEditors.DropDownButton()
        Me.puMenu_btnDropDown_Filtro = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.pu_btn_Car = New DevExpress.XtraBars.BarButtonItem()
        Me.pu_btn_Desc = New DevExpress.XtraBars.BarButtonItem()
        Me.pu_btn_Tipo = New DevExpress.XtraBars.BarButtonItem()
        Me.pu_btn_Precio = New DevExpress.XtraBars.BarButtonItem()
        Me.pu_btn_Estado = New DevExpress.XtraBars.BarButtonItem()
        Me.pu_btn_Piso = New DevExpress.XtraBars.BarButtonItem()
        Me.pu_btn_Numero = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.pu_btn_Editar = New DevExpress.XtraBars.BarButtonItem()
        Me.pu_btn_Eliminar = New DevExpress.XtraBars.BarButtonItem()
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
        Me.lblTotalRegistros = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.puMenu_btnDropDown_Filtro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.Controls.Add(Me.txtBuscar)
        Me.GroupControl2.Controls.Add(Me.btnDD_Filtro)
        Me.GroupControl2.Controls.Add(Me.GridControl1)
        Me.GroupControl2.Controls.Add(Me.lblTotalRegistros)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(892, 406)
        Me.GroupControl2.TabIndex = 5
        Me.GroupControl2.Text = "Listado de Habitaciones"
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
        Me.btnDD_Filtro.Text = "Características"
        '
        'puMenu_btnDropDown_Filtro
        '
        Me.puMenu_btnDropDown_Filtro.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.pu_btn_Car), New DevExpress.XtraBars.LinkPersistInfo(Me.pu_btn_Desc), New DevExpress.XtraBars.LinkPersistInfo(Me.pu_btn_Tipo), New DevExpress.XtraBars.LinkPersistInfo(Me.pu_btn_Precio), New DevExpress.XtraBars.LinkPersistInfo(Me.pu_btn_Estado), New DevExpress.XtraBars.LinkPersistInfo(Me.pu_btn_Piso), New DevExpress.XtraBars.LinkPersistInfo(Me.pu_btn_Numero)})
        Me.puMenu_btnDropDown_Filtro.Manager = Me.BarManager1
        Me.puMenu_btnDropDown_Filtro.Name = "puMenu_btnDropDown_Filtro"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(916, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 430)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(916, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 430)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(916, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 430)
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
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(8, 75)
        Me.GridControl1.LookAndFeel.SkinName = "Office 2007 Green"
        Me.GridControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(879, 283)
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
        'lblTotalRegistros
        '
        Me.lblTotalRegistros.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalRegistros.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblTotalRegistros.Appearance.Options.UseFont = True
        Me.lblTotalRegistros.Location = New System.Drawing.Point(648, 367)
        Me.lblTotalRegistros.Name = "lblTotalRegistros"
        Me.lblTotalRegistros.Size = New System.Drawing.Size(140, 16)
        Me.lblTotalRegistros.TabIndex = 4
        Me.lblTotalRegistros.Text = "Registro de habitaciones"
        '
        'frmEmerHabitación
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 430)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmEmerHabitación"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Habitaciones Disponibles"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.puMenu_btnDropDown_Filtro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
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
    Friend WithEvents lblTotalRegistros As DevExpress.XtraEditors.LabelControl
    Friend WithEvents puMenu_btnDropDown_Filtro As DevExpress.XtraBars.PopupMenu
    Friend WithEvents pu_btn_Car As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pu_btn_Desc As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pu_btn_Tipo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pu_btn_Precio As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pu_btn_Estado As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pu_btn_Piso As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pu_btn_Numero As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents pu_btn_Editar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pu_btn_Eliminar As DevExpress.XtraBars.BarButtonItem
End Class
