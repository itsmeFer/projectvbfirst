Imports Microsoft.Reporting.WinForms
Imports Uas.GramediaDataSet3TableAdapters

Public Class laporanreturnjual
    Private Sub laporanreturnjual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataset As New GramediaDataSet3
        Dim adapter As New transaksi_return_penjualanTableAdapter()

        ReportViewer1.LocalReport.ReportEmbeddedResource = "Uas.Report5.rdlc"
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", dataset.Tables(0)))
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class