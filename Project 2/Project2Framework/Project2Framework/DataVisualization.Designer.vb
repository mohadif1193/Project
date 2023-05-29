<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataVisualization
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea10 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend10 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series16 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series17 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series18 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title10 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea11 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend11 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series19 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title11 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea12 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend12 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series20 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title12 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.BTNBack = New System.Windows.Forms.Button()
        Me.BTNShow = New System.Windows.Forms.Button()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.BorderlineColor = System.Drawing.Color.LimeGreen
        Me.Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea10.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea10)
        Legend10.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend10)
        Me.Chart1.Location = New System.Drawing.Point(41, 22)
        Me.Chart1.Name = "Chart1"
        Series16.ChartArea = "ChartArea1"
        Series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series16.Color = System.Drawing.Color.Blue
        Series16.Legend = "Legend1"
        Series16.Name = "NewLoanApplication"
        Series17.ChartArea = "ChartArea1"
        Series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series17.Color = System.Drawing.Color.Lime
        Series17.Legend = "Legend1"
        Series17.Name = "LoansApproved"
        Series18.ChartArea = "ChartArea1"
        Series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series18.Color = System.Drawing.Color.Red
        Series18.Legend = "Legend1"
        Series18.Name = "LoansDeclined"
        Me.Chart1.Series.Add(Series16)
        Me.Chart1.Series.Add(Series17)
        Me.Chart1.Series.Add(Series18)
        Me.Chart1.Size = New System.Drawing.Size(318, 210)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        Title10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title10.ForeColor = System.Drawing.Color.Green
        Title10.Name = "Title1"
        Title10.Text = "Total Loans vs Approved vs Declined"
        Me.Chart1.Titles.Add(Title10)
        '
        'Chart2
        '
        Me.Chart2.BorderlineColor = System.Drawing.Color.GreenYellow
        Me.Chart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea11.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea11)
        Legend11.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend11)
        Me.Chart2.Location = New System.Drawing.Point(436, 22)
        Me.Chart2.Name = "Chart2"
        Series19.ChartArea = "ChartArea1"
        Series19.Color = System.Drawing.Color.Lime
        Series19.Legend = "Legend1"
        Series19.Name = "Quantity"
        Me.Chart2.Series.Add(Series19)
        Me.Chart2.Size = New System.Drawing.Size(323, 210)
        Me.Chart2.TabIndex = 1
        Me.Chart2.Text = "Chart2"
        Title11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title11.ForeColor = System.Drawing.Color.YellowGreen
        Title11.Name = "Title2"
        Title11.Text = "Loan Default Count Trend"
        Me.Chart2.Titles.Add(Title11)
        '
        'Chart3
        '
        Me.Chart3.BorderlineColor = System.Drawing.Color.SpringGreen
        Me.Chart3.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea12.Name = "ChartArea1"
        Me.Chart3.ChartAreas.Add(ChartArea12)
        Legend12.Name = "Legend1"
        Me.Chart3.Legends.Add(Legend12)
        Me.Chart3.Location = New System.Drawing.Point(252, 249)
        Me.Chart3.Name = "Chart3"
        Series20.ChartArea = "ChartArea1"
        Series20.Legend = "Legend1"
        Series20.Name = "RM Million"
        Me.Chart3.Series.Add(Series20)
        Me.Chart3.Size = New System.Drawing.Size(297, 210)
        Me.Chart3.TabIndex = 2
        Me.Chart3.Text = "Chart3"
        Title12.BorderColor = System.Drawing.Color.Transparent
        Title12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title12.ForeColor = System.Drawing.Color.MediumSpringGreen
        Title12.Name = "Title3"
        Title12.Text = "Loan Approval Amount By Product"
        Me.Chart3.Titles.Add(Title12)
        '
        'BTNBack
        '
        Me.BTNBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNBack.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BTNBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTNBack.Location = New System.Drawing.Point(575, 419)
        Me.BTNBack.Name = "BTNBack"
        Me.BTNBack.Size = New System.Drawing.Size(103, 40)
        Me.BTNBack.TabIndex = 4
        Me.BTNBack.Text = "Back"
        Me.BTNBack.UseVisualStyleBackColor = True
        '
        'BTNShow
        '
        Me.BTNShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNShow.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNShow.ForeColor = System.Drawing.Color.Blue
        Me.BTNShow.Location = New System.Drawing.Point(684, 419)
        Me.BTNShow.Name = "BTNShow"
        Me.BTNShow.Size = New System.Drawing.Size(104, 40)
        Me.BTNShow.TabIndex = 5
        Me.BTNShow.Text = "Show Data"
        Me.BTNShow.UseVisualStyleBackColor = True
        '
        'DataVisualization
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 471)
        Me.Controls.Add(Me.BTNShow)
        Me.Controls.Add(Me.BTNBack)
        Me.Controls.Add(Me.Chart3)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "DataVisualization"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan Data Collector"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Chart1 As Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart3 As Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents BTNBack As Button
    Friend WithEvents BTNShow As Button

    Private Sub BTNShow_Click(sender As Object, e As EventArgs) Handles BTNShow.Click
        Me.Chart1.Series("NewLoanApplication").Points.AddXY("Jan", 5500)
        Me.Chart1.Series("NewLoanApplication").Points.AddXY("Feb", 6400)
        Me.Chart1.Series("NewLoanApplication").Points.AddXY("Mar", 5900)
        Me.Chart1.Series("NewLoanApplication").Points.AddXY("Apr", 6000)
        Me.Chart1.Series("NewLoanApplication").Points.AddXY("May", 5800)
        Me.Chart1.Series("NewLoanApplication").Points.AddXY("Jun", 5100)
        Me.Chart1.Series("NewLoanApplication").Points.AddXY("Jul", 5900)
        Me.Chart1.Series("NewLoanApplication").Points.AddXY("Aug", 5300)
        Me.Chart1.Series("NewLoanApplication").Points.AddXY("Sep", 6300)
        Me.Chart1.Series("NewLoanApplication").Points.AddXY("Oct", 6700)
        Me.Chart1.Series("NewLoanApplication").Points.AddXY("Nov", 5600)
        Me.Chart1.Series("NewLoanApplication").Points.AddXY("Dec", 5000)

        Me.Chart1.Series("LoansApproved").Points.AddXY("Jan", 3300)
        Me.Chart1.Series("LoansApproved").Points.AddXY("Feb", 3800)
        Me.Chart1.Series("LoansApproved").Points.AddXY("Mar", 3700)
        Me.Chart1.Series("LoansApproved").Points.AddXY("Apr", 3800)
        Me.Chart1.Series("LoansApproved").Points.AddXY("May", 3400)
        Me.Chart1.Series("LoansApproved").Points.AddXY("Jun", 3200)
        Me.Chart1.Series("LoansApproved").Points.AddXY("Jul", 3400)
        Me.Chart1.Series("LoansApproved").Points.AddXY("Aug", 3700)
        Me.Chart1.Series("LoansApproved").Points.AddXY("Sep", 3900)
        Me.Chart1.Series("LoansApproved").Points.AddXY("Oct", 4000)
        Me.Chart1.Series("LoansApproved").Points.AddXY("Nov", 3700)
        Me.Chart1.Series("LoansApproved").Points.AddXY("Dec", 3000)

        Me.Chart1.Series("LoansDeclined").Points.AddXY("Jan", 2200)
        Me.Chart1.Series("LoansDeclined").Points.AddXY("Feb", 2700)
        Me.Chart1.Series("LoansDeclined").Points.AddXY("Mar", 2100)
        Me.Chart1.Series("LoansDeclined").Points.AddXY("Apr", 2100)
        Me.Chart1.Series("LoansDeclined").Points.AddXY("May", 2200)
        Me.Chart1.Series("LoansDeclined").Points.AddXY("Jun", 1900)
        Me.Chart1.Series("LoansDeclined").Points.AddXY("Jul", 2200)
        Me.Chart1.Series("LoansDeclined").Points.AddXY("Aug", 1800)
        Me.Chart1.Series("LoansDeclined").Points.AddXY("Sep", 2300)
        Me.Chart1.Series("LoansDeclined").Points.AddXY("Oct", 2500)
        Me.Chart1.Series("LoansDeclined").Points.AddXY("Nov", 2000)
        Me.Chart1.Series("LoansDeclined").Points.AddXY("Dec", 2000)

        Me.Chart2.Series("Quantity").Points.AddXY("Jan", 2100)
        Me.Chart2.Series("Quantity").Points.AddXY("Feb", 1800)
        Me.Chart2.Series("Quantity").Points.AddXY("Mar", 1700)
        Me.Chart2.Series("Quantity").Points.AddXY("Apr", 1900)
        Me.Chart2.Series("Quantity").Points.AddXY("May", 2300)
        Me.Chart2.Series("Quantity").Points.AddXY("Jun", 1800)
        Me.Chart2.Series("Quantity").Points.AddXY("Jul", 2300)
        Me.Chart2.Series("Quantity").Points.AddXY("Aug", 2000)
        Me.Chart2.Series("Quantity").Points.AddXY("Sep", 2200)
        Me.Chart2.Series("Quantity").Points.AddXY("Oct", 1700)
        Me.Chart2.Series("Quantity").Points.AddXY("Sep", 1800)
        Me.Chart2.Series("Quantity").Points.AddXY("Dec", 2300)

        Me.Chart3.Series("RM Million").Points.AddXY("Jan", 680000)
        Me.Chart3.Series("RM Million").Points.AddXY("Feb", 470000)
        Me.Chart3.Series("RM Million").Points.AddXY("Mac", 980000)
        Me.Chart3.Series("RM Million").Points.AddXY("Apr", 570000)
        Me.Chart3.Series("RM Million").Points.AddXY("May", 680000)
        Me.Chart3.Series("RM Million").Points.AddXY("Jun", 800000)
    End Sub

    Private Sub BTNBack_Click(sender As Object, e As EventArgs) Handles BTNBack.Click
        Dashboard.Show()
    End Sub
End Class
