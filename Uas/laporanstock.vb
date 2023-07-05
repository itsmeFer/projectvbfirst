Imports Uas.GramediaDataSetTableAdapters
Imports Uas.GramediaDataSet
Imports Microsoft.Reporting.WinForms

Public Class laporanstock
    Private Sub laporanstock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataset As New GramediaDataSet
        Dim adapter As New stock_barangTableAdapter()
        adapter.Fill(dataset.stock_barang)
        ReportViewer1.LocalReport.ReportEmbeddedResource = "Uas.Report1.rdlc"
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", dataset.Tables(0)))
        Me.ReportViewer1.RefreshReport()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        menuutama.Show()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class