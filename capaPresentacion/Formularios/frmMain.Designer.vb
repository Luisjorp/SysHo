<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

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
        Dim SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, Nothing, True, True)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.RepositoryItemTimeEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit()
        Me.lblHora = New DevExpress.XtraBars.BarStaticItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage4 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPage5 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timerSplash = New System.Windows.Forms.Timer(Me.components)
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplashScreenManager1
        '
        SplashScreenManager1.ClosingDelay = 500
        '
        'RibbonControl
        '
        Me.RibbonControl.ApplicationIcon = CType(resources.GetObject("RibbonControl.ApplicationIcon"), System.Drawing.Bitmap)
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.BarButtonItem1, Me.lblHora, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 18
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.RibbonPage2, Me.RibbonPage3, Me.RibbonPage4, Me.RibbonPage5})
        Me.RibbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTimeEdit1})
        Me.RibbonControl.Size = New System.Drawing.Size(602, 150)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Habitaciones"
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.ImageOptions.Image = Global.capaPresentacion.My.Resources.Resources._002_bed
        Me.BarButtonItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H))
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'RepositoryItemTimeEdit1
        '
        Me.RepositoryItemTimeEdit1.AutoHeight = False
        Me.RepositoryItemTimeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemTimeEdit1.Name = "RepositoryItemTimeEdit1"
        '
        'lblHora
        '
        Me.lblHora.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.lblHora.AllowRightClickInMenu = False
        Me.lblHora.Caption = "hora:"
        Me.lblHora.Id = 5
        Me.lblHora.ImageOptions.ImageUri.Uri = "SwitchTimeScalesTo;Size16x16;Colored"
        Me.lblHora.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblHora.ItemAppearance.Normal.Options.UseFont = True
        Me.lblHora.Name = "lblHora"
        Me.lblHora.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Agregar Producto"
        Me.BarButtonItem2.Id = 6
        Me.BarButtonItem2.ImageOptions.ImageUri.Uri = "Add;Size16x16"
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "BarButtonItem3"
        Me.BarButtonItem3.Id = 7
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Productos"
        Me.BarButtonItem4.Id = 8
        Me.BarButtonItem4.ImageOptions.Image = Global.capaPresentacion.My.Resources.Resources._005_shop
        Me.BarButtonItem4.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Reservas y Consumos"
        Me.BarButtonItem5.Id = 9
        Me.BarButtonItem5.ImageOptions.Image = Global.capaPresentacion.My.Resources.Resources._16reservas1
        Me.BarButtonItem5.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R))
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Clientes"
        Me.BarButtonItem6.Id = 10
        Me.BarButtonItem6.ImageOptions.Image = Global.capaPresentacion.My.Resources.Resources._16clientes
        Me.BarButtonItem6.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C))
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Pagos"
        Me.BarButtonItem7.Id = 12
        Me.BarButtonItem7.ImageOptions.Image = Global.capaPresentacion.My.Resources.Resources._16pagos
        Me.BarButtonItem7.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G))
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Consultas"
        Me.BarButtonItem8.Id = 13
        Me.BarButtonItem8.ImageOptions.Image = Global.capaPresentacion.My.Resources.Resources._16consultas
        Me.BarButtonItem8.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S))
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Usuarios y Accesos"
        Me.BarButtonItem9.Id = 14
        Me.BarButtonItem9.ImageOptions.Image = Global.capaPresentacion.My.Resources.Resources._16users
        Me.BarButtonItem9.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U))
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RibbonPage1.Appearance.Options.UseFont = True
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Image = Global.capaPresentacion.My.Resources.Resources._16admon
        Me.RibbonPage1.ImageAlign = DevExpress.Utils.HorzAlignment.Near
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Administración"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem4)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Gestión de Servicios"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RibbonPage2.Appearance.Options.UseFont = True
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2, Me.RibbonPageGroup3})
        Me.RibbonPage2.Image = Global.capaPresentacion.My.Resources.Resources._16reservas
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Reservas"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem5)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem6)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem7)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Reservas"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItem8)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Consultas"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RibbonPage3.Appearance.Options.UseFont = True
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup4})
        Me.RibbonPage3.Image = Global.capaPresentacion.My.Resources.Resources.conf162
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Text = "Configuración"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButtonItem9)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "Configuración"
        '
        'RibbonPage4
        '
        Me.RibbonPage4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RibbonPage4.Appearance.Options.UseFont = True
        Me.RibbonPage4.Image = Global.capaPresentacion.My.Resources.Resources.conf16
        Me.RibbonPage4.Name = "RibbonPage4"
        Me.RibbonPage4.Text = "Herramientas"
        '
        'RibbonPage5
        '
        Me.RibbonPage5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RibbonPage5.Appearance.Options.UseFont = True
        Me.RibbonPage5.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup5})
        Me.RibbonPage5.Image = Global.capaPresentacion.My.Resources.Resources._16ayuda
        Me.RibbonPage5.Name = "RibbonPage5"
        Me.RibbonPage5.Text = "Ayuda"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.Text = "RibbonPageGroup5"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.ItemLinks.Add(Me.lblHora)
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 426)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(602, 23)
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinMaskColor = System.Drawing.Color.Aquamarine
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'timerSplash
        '
        Me.timerSplash.Interval = 1000
        '
        'frmMain
        '
        Me.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 449)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "SysHo 1.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents RepositoryItemTimeEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblHora As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents timerSplash As Timer
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage4 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPage5 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
End Class
