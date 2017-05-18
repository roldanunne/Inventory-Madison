Imports MySql.Data.MySqlClient

Public Class frmReports
    Private Sub setFromDefault()
        btnRecord.Show()
        btnStocks.Show()
        btnDelivery.Show()
        btnSales.Show()
        btnLogs.Show()
        pnlCustomRange.Hide()
    End Sub
    Private Sub btnStocksDefault()
        cboViewBy.SelectedIndex = 0
    End Sub
    Private Sub frmReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.rvReport.RefreshReport()
        'btnStocksDefault()
        pnlRecord.SendToBack()
        pnlDateFromTo.SendToBack()
        setFromDefault()
    End Sub
    '
    'record
    '
    Private Sub btnRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecord.Click
        txtReportName.Text = vbNullString
        txtReportName.Text = "record"
    End Sub

    Private Sub btnProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProduct.Click
        Dim columnName = "barcode,prod_name,prod_desc,prod_class,prod_price"
        Dim tableName = " product"
        Dim rptReportName As String = "rptProduct.rdlc"
        Dim DataSetName As String = "productDataSet"
        modSqlFunction.loadReport(columnName, tableName, rptReportName, DataSetName, rvReport)
    End Sub

    Private Sub btnBranch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBranch.Click
        Dim columnName = "branch_code,branch_name,branch_address,branch_contact"
        Dim tableName = " branch"
        Dim rptReportName As String = "rptBranch.rdlc"
        Dim DataSetName As String = "branchDataSet"
        modSqlFunction.loadReport(columnName, tableName, rptReportName, DataSetName, rvReport)

    End Sub
    Private Sub btnSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupplier.Click
        Dim columnName = "sup_name,sup_address,sup_contact"
        Dim tableName = " supplier"
        Dim rptReportName As String = "rptSupplier.rdlc"
        Dim DataSetName As String = "supplierDataSet"
        modSqlFunction.loadReport(columnName, tableName, rptReportName, DataSetName, rvReport)

    End Sub

    Private Sub btnEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmployee.Click
        Dim columnName = "fname,lname,gender,address,status"
        Dim tableName = " employee"
        Dim rptReportName As String = "rptEmployee.rdlc"
        Dim DataSetName As String = "employeeDataSet"
        modSqlFunction.loadReport(columnName, tableName, rptReportName, DataSetName, rvReport)
    End Sub

    Private Sub btnRack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRack.Click
        Dim columnName = "rack_name,rack_desc,prod_id"
        Dim tableName = " rack"
        Dim rptReportName As String = "rptRack.rdlc"
        Dim DataSetName As String = "rackDataSet"
        modSqlFunction.loadReport(columnName, tableName, rptReportName, DataSetName, rvReport)
    End Sub
    
    Private Sub btnStocks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStocks.Click
        txtReportName.Text = vbNullString
        txtReportName.Text = "stocks"
        cboViewBy.SelectedIndex = -1
        cboViewBy.SelectedIndex = 0
    End Sub
   
    Private Sub btnDelivery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelivery.Click
        txtReportName.Text = vbNullString
        txtReportName.Text = "delivery"
        cboViewBy.SelectedIndex = -1
        cboViewBy.SelectedIndex = 0
    End Sub
   
    Private Sub btnSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSales.Click
        txtReportName.Text = vbNullString
        txtReportName.Text = "sales"
        cboViewBy.SelectedIndex = -1
        cboViewBy.SelectedIndex = 0
    End Sub
   
    Private Sub btnLogs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogs.Click
        txtReportName.Text = vbNullString
        txtReportName.Text = "logs"
        cboViewBy.SelectedIndex = -1
        cboViewBy.SelectedIndex = 0
    End Sub

    Private Sub cboViewBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboViewBy.SelectedIndexChanged
       
        If txtReportName.Text = "stocks" Then
            Dim columnName = "prod_name,rack_name,level_name,prod_qty, prod_price"
            Dim tableName = "stocks INNER JOIN product ON stocks.prod_id=product.id"
            Dim rptReportName As String = "rptStocks.rdlc"
            Dim DataSetName As String = "stocksDataSet"
            Dim columnDate As String = "created_at"

            If cboViewBy.Text = "This Month-to-date" Then
                Dim firstDay As Date = DateSerial(Today.Year, Today.Month, 1)
                Dim dateFrom As String = firstDay.ToString("yyyy-MM-dd 00:00:00")
                Dim dateTo As String = DateTime.Now.ToString("yyyy-MM-dd 00:00:00")
                modSqlFunction.loadReportRange(columnName, tableName, columnDate, dateFrom, dateTo, rptReportName, DataSetName, rvReport)
            ElseIf cboViewBy.Text = "Last Month" Then
                Dim beginPrevMonth As Date = DateAdd("m", -1, DateSerial(Year(Today), Month(Today), 1))
                Dim dateFrom As String = beginPrevMonth.ToString("yyyy-MM-dd 00:00:00")
                Dim endPrevMonth As Date = DateSerial(Year(Today()), Month(Today()), 0)
                Dim dateTo As String = endPrevMonth.ToString("yyyy-MM-dd 00:00:00")
                modSqlFunction.loadReportRange(columnName, tableName, columnDate, dateFrom, dateTo, rptReportName, DataSetName, rvReport)
            ElseIf cboViewBy.Text = "Last 6 Months" Then
                Dim lastSixMonth As Date = DateAdd("m", -1, DateSerial(Year(Today), Month(Today), 1)).AddMonths(-6)
                Dim dateFrom As String = lastSixMonth.ToString("yyyy-MM-dd 00:00:00")
                Dim endPrevMonth As Date = DateSerial(Year(Today()), Month(Today()), 0)
                Dim dateTo As String = endPrevMonth.ToString("yyyy-MM-dd 00:00:00")
                modSqlFunction.loadReportRange(columnName, tableName, columnDate, dateFrom, dateTo, rptReportName, DataSetName, rvReport)
            ElseIf cboViewBy.Text = "Custom Range" Then
                pnlCustomRange.Show()
                dtpFrom.Text = "01/01/1998"
                dtpTo.Text = "01/01/1998"
            End If
        
        ElseIf txtReportName.Text = "delivery" Then
            Dim columnName = "prod_name,DATE_FORMAT(date,'%b %d %Y %h:%i %p') As date,quantity,prod_qty, ref_number,branch_code"
            Dim tableName = "stock_out INNER JOIN product ON stock_out.prod_id=product.id INNER JOIN reference ON stock_out.ref_id=reference.ref_id INNER JOIN branch ON branch.branch_id=stock_out.branch_id"
            Dim rptReportName As String = "rptDelivery.rdlc"
            Dim DataSetName As String = "deliveryDataSet"
            Dim columnDate As String = "date"

            If cboViewBy.Text = "This Month-to-date" Then
                Dim firstDay As Date = DateSerial(Today.Year, Today.Month, 1)
                Dim dateFrom As String = firstDay.ToString("yyyy-MM-dd 00:00:00")
                Dim dateTo As String = DateTime.Now.ToString("yyyy-MM-dd 00:00:00")
                modSqlFunction.loadReportRange(columnName, tableName, columnDate, dateFrom, dateTo, rptReportName, DataSetName, rvReport)
            ElseIf cboViewBy.Text = "Last Month" Then
                Dim beginPrevMonth As Date = DateAdd("m", -1, DateSerial(Year(Today), Month(Today), 1))
                Dim dateFrom As String = beginPrevMonth.ToString("yyyy-MM-dd 00:00:00")
                Dim endPrevMonth As Date = DateSerial(Year(Today()), Month(Today()), 0)
                Dim dateTo As String = endPrevMonth.ToString("yyyy-MM-dd 00:00:00")
                modSqlFunction.loadReportRange(columnName, tableName, columnDate, dateFrom, dateTo, rptReportName, DataSetName, rvReport)
            ElseIf cboViewBy.Text = "Last 6 Months" Then
                Dim lastSixMonth As Date = DateAdd("m", -1, DateSerial(Year(Today), Month(Today), 1)).AddMonths(-6)
                Dim dateFrom As String = lastSixMonth.ToString("yyyy-MM-dd 00:00:00")
                Dim endPrevMonth As Date = DateSerial(Year(Today()), Month(Today()), 0)
                Dim dateTo As String = endPrevMonth.ToString("yyyy-MM-dd 00:00:00")
                modSqlFunction.loadReportRange(columnName, tableName, columnDate, dateFrom, dateTo, rptReportName, DataSetName, rvReport)
            ElseIf cboViewBy.Text = "Custom Range" Then
                pnlCustomRange.Show()
                dtpFrom.Text = "01/01/1998"
                dtpTo.Text = "01/01/1998"
            End If
        ElseIf txtReportName.Text = "sales" Then
            Dim columnName = "tran_number,tran_date,prod_name,sales_amount,sales_tax,sales_total"
            Dim tableName = "sales INNER JOIN product ON sales.prod_id=product.id"
            Dim rptReportName As String = "rptSales.rdlc"
            Dim DataSetName As String = "salesDataSet"
            Dim columnDate As String = "created_at"

            If cboViewBy.Text = "This Month-to-date" Then
                Dim firstDay As Date = DateSerial(Today.Year, Today.Month, 1)
                Dim dateFrom As String = firstDay.ToString("yyyy-MM-dd 00:00:00")
                Dim dateTo As String = DateTime.Now.ToString("yyyy-MM-dd 00:00:00")
                modSqlFunction.loadReportRange(columnName, tableName, columnDate, dateFrom, dateTo, rptReportName, DataSetName, rvReport)
            ElseIf cboViewBy.Text = "Last Month" Then
                Dim beginPrevMonth As Date = DateAdd("m", -1, DateSerial(Year(Today), Month(Today), 1))
                Dim dateFrom As String = beginPrevMonth.ToString("yyyy-MM-dd 00:00:00")
                Dim endPrevMonth As Date = DateSerial(Year(Today()), Month(Today()), 0)
                Dim dateTo As String = endPrevMonth.ToString("yyyy-MM-dd 00:00:00")
                modSqlFunction.loadReportRange(columnName, tableName, columnDate, dateFrom, dateTo, rptReportName, DataSetName, rvReport)
            ElseIf cboViewBy.Text = "Last 6 Months" Then
                Dim lastSixMonth As Date = DateAdd("m", -1, DateSerial(Year(Today), Month(Today), 1)).AddMonths(-6)
                Dim dateFrom As String = lastSixMonth.ToString("yyyy-MM-dd 00:00:00")
                Dim endPrevMonth As Date = DateSerial(Year(Today()), Month(Today()), 0)
                Dim dateTo As String = endPrevMonth.ToString("yyyy-MM-dd 00:00:00")
                modSqlFunction.loadReportRange(columnName, tableName, columnDate, dateFrom, dateTo, rptReportName, DataSetName, rvReport)
            ElseIf cboViewBy.Text = "Custom Range" Then
                pnlCustomRange.Show()
                dtpFrom.Text = "01/01/1998"
                dtpTo.Text = "01/01/1998"
            End If
        End If
    End Sub
    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        txtStateGo.Text = vbNullString
        txtStateGo.Text = txtReportName.Text & "go"
        
        If txtStateGo.Text = "stocksgo" Then
            Dim columnName = "prod_name,rack_name,level_name,prod_qty, prod_price"
            Dim tableName = "stocks INNER JOIN product ON stocks.prod_id=product.id"
            Dim rptReportName As String = "rptStocks.rdlc"
            Dim DataSetName As String = "stocksDataSet"
            Dim columnDate As String = "created_at"
            Dim from As String = dtpFrom.Text
            Dim dto As String = dtpTo.Text
            Dim dateFrom As String = Format(Convert.ToDateTime(from.ToString), "yyyy-MM-dd 00:00:00")
            Dim dateTo As String = Format(Convert.ToDateTime(dto.ToString), "yyyy-MM-dd 00:00:00")
            modSqlFunction.loadReportRange(columnName, tableName, columnDate, dateFrom, dateTo, rptReportName, DataSetName, rvReport)
        ElseIf txtStateGo.Text = "deliverygo" Then
            Dim columnName = "prod_name,DATE_FORMAT(date,'%b %d %Y %h:%i %p') As date,quantity,prod_qty, ref_number,branch_code"
            Dim tableName = "stock_out INNER JOIN product ON stock_out.prod_id=product.id INNER JOIN reference ON stock_out.ref_id=reference.ref_id INNER JOIN branch ON branch.branch_id=stock_out.branch_id"
            Dim rptReportName As String = "rptDelivery.rdlc"
            Dim DataSetName As String = "deliveryDataSet"
            Dim columnDate As String = "date"
            Dim from As String = dtpFrom.Text
            Dim dto As String = dtpTo.Text
            Dim dateFrom As String = Format(Convert.ToDateTime(from.ToString), "yyyy-MM-dd 00:00:00")
            Dim dateTo As String = Format(Convert.ToDateTime(dto.ToString), "yyyy-MM-dd 00:00:00")
            modSqlFunction.loadReportRange(columnName, tableName, columnDate, dateFrom, dateTo, rptReportName, DataSetName, rvReport)
        ElseIf txtStateGo.Text = "salesgo" Then
            Dim columnName = "tran_number,tran_date,prod_name,sales_amount,sales_tax,sales_total"
            Dim tableName = "sales INNER JOIN product ON sales.prod_id=product.id"
            Dim rptReportName As String = "rptSales.rdlc"
            Dim DataSetName As String = "salesDataSet"
            Dim columnDate As String = "created_at"
            Dim from As String = dtpFrom.Text
            Dim dto As String = dtpTo.Text
            Dim dateFrom As String = Format(Convert.ToDateTime(from.ToString), "yyyy-MM-dd 00:00:00")
            Dim dateTo As String = Format(Convert.ToDateTime(dto.ToString), "yyyy-MM-dd 00:00:00")
            modSqlFunction.loadReportRange(columnName, tableName, columnDate, dateFrom, dateTo, rptReportName, DataSetName, rvReport)
        
        End If
    End Sub
   
    Private Sub txtReportName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReportName.TextChanged
        If txtReportName.Text = "record" Then
            If pnlRecord.Width = 0 Then
                btnStocks.Hide()
                btnDelivery.Hide()
                btnSales.Hide()
                btnLogs.Hide()
                Do While pnlRecord.Width < 1100
                    pnlRecord.Width = pnlRecord.Width + 1
                Loop
                pnlGreen.Hide()
            Else
                pnlGreen.Show()
                Do While pnlRecord.Width > 0
                    pnlRecord.Width = pnlRecord.Width - 1
                Loop
                setFromDefault()
            End If
        ElseIf txtReportName.Text = "stocks" Or txtReportName.Text = "delivery" Or txtReportName.Text = "sales" Or txtReportName.Text = "logs" Then

            If pnlDateFromTo.Width = 0 Then
                If txtReportName.Text = "stocks" Then
                    btnRecord.Hide()
                    btnDelivery.Hide()
                    btnSales.Hide()
                    btnLogs.Hide()
                    btnStocks.Location = New Point(40, 10)
                ElseIf txtReportName.Text = "delivery" Then
                    btnRecord.Hide()
                    btnStocks.Hide()
                    btnSales.Hide()
                    btnLogs.Hide()
                    btnDelivery.Location = New Point(40, 10)
                ElseIf txtReportName.Text = "sales" Then
                    btnRecord.Hide()
                    btnStocks.Hide()
                    btnDelivery.Hide()
                    btnLogs.Hide()
                    btnSales.Location = New Point(40, 10)
                ElseIf txtReportName.Text = "logs" Then
                    btnRecord.Hide()
                    btnStocks.Hide()
                    btnDelivery.Hide()
                    btnSales.Hide()
                    btnLogs.Location = New Point(40, 10)
                End If
                Do While pnlDateFromTo.Width < 1100
                    pnlDateFromTo.Width = pnlDateFromTo.Width + 1
                Loop
                pnlDftGreen.Hide()
            Else
                pnlDftGreen.Show()
                Do While pnlDateFromTo.Width > 0
                    pnlDateFromTo.Width = pnlDateFromTo.Width - 1
                Loop
                If txtReportName.Text = "stocks" Then
                    btnStocks.Location = New Point(130, 10)
                ElseIf txtReportName.Text = "delivery" Then
                    btnDelivery.Location = New Point(220, 10)
                ElseIf txtReportName.Text = "sales" Then
                    btnSales.Location = New Point(310, 10)
                ElseIf txtReportName.Text = "logs" Then
                    btnLogs.Location = New Point(400, 10)
                End If
                setFromDefault()
            End If
        End If
    End Sub

End Class