<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class reporteHabitaciones
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ShapeBrace1 As DevExpress.XtraPrinting.Shape.ShapeBrace = New DevExpress.XtraPrinting.Shape.ShapeBrace()
        Dim ShapeBrace2 As DevExpress.XtraPrinting.Shape.ShapeBrace = New DevExpress.XtraPrinting.Shape.ShapeBrace()
        Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.Lines = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.OddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.EvenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.xrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.xrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.xrShape2 = New DevExpress.XtraReports.UI.XRShape()
        Me.Header = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.TableHeader = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.xrShape1 = New DevExpress.XtraReports.UI.XRShape()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.FooterLine = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'xrTable2
        '
        Me.xrTable2.Dpi = 100.0!
        Me.xrTable2.EvenStyleName = "EvenStyle"
        Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.xrTable2.Name = "xrTable2"
        Me.xrTable2.OddStyleName = "OddStyle"
        Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow2})
        Me.xrTable2.SizeF = New System.Drawing.SizeF(787.0!, 62.5!)
        '
        'xrTableRow2
        '
        Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell4, Me.xrTableCell5, Me.xrTableCell8, Me.xrTableCell6, Me.XrTableCell10})
        Me.xrTableRow2.Dpi = 100.0!
        Me.xrTableRow2.Name = "xrTableRow2"
        Me.xrTableRow2.Weight = 1.0R
        '
        'xrTableCell4
        '
        Me.xrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "numero")})
        Me.xrTableCell4.Dpi = 100.0!
        Me.xrTableCell4.Name = "xrTableCell4"
        Me.xrTableCell4.Weight = 0.19768436209830886R
        '
        'xrTableCell5
        '
        Me.xrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Descripcion")})
        Me.xrTableCell5.Dpi = 100.0!
        Me.xrTableCell5.Multiline = True
        Me.xrTableCell5.Name = "xrTableCell5"
        Me.xrTableCell5.Weight = 1.0712528539787452R
        '
        'xrTableCell8
        '
        Me.xrTableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Caracteristicas")})
        Me.xrTableCell8.Dpi = 100.0!
        Me.xrTableCell8.Name = "xrTableCell8"
        Me.xrTableCell8.Weight = 1.3465435365912042R
        '
        'xrTableCell6
        '
        Me.xrTableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "tipoHabitacion")})
        Me.xrTableCell6.Dpi = 100.0!
        Me.xrTableCell6.Name = "xrTableCell6"
        Me.xrTableCell6.StylePriority.UseTextAlignment = False
        Me.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.xrTableCell6.Weight = 0.62490321305545948R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "precioDiario")})
        Me.XrTableCell10.Dpi = 100.0!
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.StylePriority.UseTextAlignment = False
        Me.XrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell10.Weight = 0.39192369032834445R
        '
        'Lines
        '
        Me.Lines.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.Lines.Name = "Lines"
        Me.Lines.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        '
        'xrLine1
        '
        Me.xrLine1.Dpi = 100.0!
        Me.xrLine1.LineWidth = 2
        Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 75.41666!)
        Me.xrLine1.Name = "xrLine1"
        Me.xrLine1.SizeF = New System.Drawing.SizeF(777.0001!, 2.083336!)
        Me.xrLine1.StyleName = "Lines"
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 100.0!
        Me.BottomMargin.HeightF = 0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'OddStyle
        '
        Me.OddStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.OddStyle.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.OddStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.OddStyle.Name = "OddStyle"
        Me.OddStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.OddStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrTable1
        '
        Me.xrTable1.BackColor = System.Drawing.Color.White
        Me.xrTable1.Dpi = 100.0!
        Me.xrTable1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.xrTable1.Name = "xrTable1"
        Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1})
        Me.xrTable1.SizeF = New System.Drawing.SizeF(787.0!, 75.41666!)
        Me.xrTable1.StyleName = "TableHeader"
        '
        'xrTableRow1
        '
        Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell7, Me.xrTableCell3, Me.XrTableCell9})
        Me.xrTableRow1.Dpi = 100.0!
        Me.xrTableRow1.Name = "xrTableRow1"
        Me.xrTableRow1.Weight = 1.0R
        '
        'xrTableCell1
        '
        Me.xrTableCell1.Dpi = 100.0!
        Me.xrTableCell1.Multiline = True
        Me.xrTableCell1.Name = "xrTableCell1"
        Me.xrTableCell1.Text = "No."
        Me.xrTableCell1.Weight = 0.19738027309093892R
        '
        'xrTableCell2
        '
        Me.xrTableCell2.Dpi = 100.0!
        Me.xrTableCell2.Name = "xrTableCell2"
        Me.xrTableCell2.StylePriority.UseTextAlignment = False
        Me.xrTableCell2.Text = "Descripción"
        Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrTableCell2.Weight = 1.0696051062834007R
        '
        'xrTableCell7
        '
        Me.xrTableCell7.Dpi = 100.0!
        Me.xrTableCell7.Name = "xrTableCell7"
        Me.xrTableCell7.StylePriority.UseTextAlignment = False
        Me.xrTableCell7.Text = "Caracteristicas"
        Me.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrTableCell7.Weight = 1.3444722100046893R
        '
        'xrTableCell3
        '
        Me.xrTableCell3.Dpi = 100.0!
        Me.xrTableCell3.Name = "xrTableCell3"
        Me.xrTableCell3.StylePriority.UseTextAlignment = False
        Me.xrTableCell3.Text = "Tipo"
        Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrTableCell3.Weight = 0.623941931217058R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Dpi = 100.0!
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Text = "Precio"
        Me.XrTableCell9.Weight = 0.39132085224306234R
        '
        'EvenStyle
        '
        Me.EvenStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EvenStyle.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.EvenStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.EvenStyle.Name = "EvenStyle"
        Me.EvenStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.EvenStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable1, Me.xrLine1})
        Me.GroupHeader1.Dpi = 100.0!
        Me.GroupHeader1.HeightF = 86.87499!
        Me.GroupHeader1.KeepTogether = True
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.RepeatEveryPage = True
        '
        'xrPageInfo1
        '
        Me.xrPageInfo1.Dpi = 100.0!
        Me.xrPageInfo1.Format = "Page {0} of {1}"
        Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(721.3959!, 76.99998!)
        Me.xrPageInfo1.Name = "xrPageInfo1"
        Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(65.60406!, 23.0!)
        Me.xrPageInfo1.StyleName = "EvenStyle"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLine2, Me.xrPageInfo1})
        Me.PageFooter.Dpi = 100.0!
        Me.PageFooter.HeightF = 100.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'xrLine2
        '
        Me.xrLine2.Dpi = 100.0!
        Me.xrLine2.LocationFloat = New DevExpress.Utils.PointFloat(0.00003178914!, 64.58334!)
        Me.xrLine2.Name = "xrLine2"
        Me.xrLine2.SizeF = New System.Drawing.SizeF(786.9999!, 2.083328!)
        Me.xrLine2.StyleName = "FooterLine"
        '
        'xrLine3
        '
        Me.xrLine3.Dpi = 100.0!
        Me.xrLine3.LineWidth = 2
        Me.xrLine3.LocationFloat = New DevExpress.Utils.PointFloat(0.0001271566!, 0!)
        Me.xrLine3.Name = "xrLine3"
        Me.xrLine3.SizeF = New System.Drawing.SizeF(786.9999!, 3.041649!)
        Me.xrLine3.StyleName = "Lines"
        '
        'xrShape2
        '
        Me.xrShape2.Angle = 180
        Me.xrShape2.Dpi = 100.0!
        Me.xrShape2.LocationFloat = New DevExpress.Utils.PointFloat(758.8749!, 10.00001!)
        Me.xrShape2.Name = "xrShape2"
        Me.xrShape2.Shape = ShapeBrace1
        Me.xrShape2.SizeF = New System.Drawing.SizeF(28.12512!, 76.12501!)
        Me.xrShape2.Stretch = True
        Me.xrShape2.StyleName = "Header"
        '
        'Header
        '
        Me.Header.Font = New System.Drawing.Font("Poor Richard", 48.0!)
        Me.Header.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Header.Name = "Header"
        Me.Header.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Header.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'TableHeader
        '
        Me.TableHeader.BackColor = System.Drawing.Color.White
        Me.TableHeader.Font = New System.Drawing.Font("Californian FB", 18.0!, System.Drawing.FontStyle.Bold)
        Me.TableHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.TableHeader.Name = "TableHeader"
        Me.TableHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TableHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrShape1
        '
        Me.xrShape1.Dpi = 100.0!
        Me.xrShape1.ForeColor = System.Drawing.Color.Black
        Me.xrShape1.LocationFloat = New DevExpress.Utils.PointFloat(0.00003178914!, 10.00001!)
        Me.xrShape1.Name = "xrShape1"
        Me.xrShape1.Shape = ShapeBrace2
        Me.xrShape1.SizeF = New System.Drawing.SizeF(29.16667!, 76.12502!)
        Me.xrShape1.Stretch = True
        Me.xrShape1.StyleName = "Header"
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrShape1, Me.xrShape2, Me.xrLabel1})
        Me.TopMargin.Dpi = 100.0!
        Me.TopMargin.HeightF = 86.12503!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrLabel1
        '
        Me.xrLabel1.Dpi = 100.0!
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(29.1667!, 10.00001!)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(729.7082!, 76.12502!)
        Me.xrLabel1.StyleName = "Header"
        Me.xrLabel1.Text = "Habitaciones"
        '
        'FooterLine
        '
        Me.FooterLine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.FooterLine.Name = "FooterLine"
        Me.FooterLine.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable2})
        Me.Detail.Dpi = 100.0!
        Me.Detail.HeightF = 68.75!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLine3})
        Me.GroupFooter1.Dpi = 100.0!
        Me.GroupFooter1.HeightF = 3.041649!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = GetType(capaEntidad.ceHabitacion)
        '
        'ReportFooter
        '
        Me.ReportFooter.Dpi = 100.0!
        Me.ReportFooter.HeightF = 23.00002!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'reporteHabitaciones
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageFooter, Me.GroupHeader1, Me.GroupFooter1, Me.ReportFooter})
        Me.DataSource = Me.BindingSource1
        Me.Margins = New System.Drawing.Printing.Margins(35, 28, 86, 0)
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Header, Me.TableHeader, Me.OddStyle, Me.EvenStyle, Me.Lines, Me.FooterLine})
        Me.Version = "16.2"
        CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents xrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Lines As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents xrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents OddStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents xrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents EvenStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents xrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents xrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents xrShape2 As DevExpress.XtraReports.UI.XRShape
    Friend WithEvents Header As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents TableHeader As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents xrShape1 As DevExpress.XtraReports.UI.XRShape
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents FooterLine As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
End Class
