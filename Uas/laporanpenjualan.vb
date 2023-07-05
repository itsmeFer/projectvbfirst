Imports Uas.GramediaDataSet2
Imports Uas.laporanpenjualan
Imports Microsoft.Reporting.WinForms
Imports Uas.GramediaDataSet2TableAdapters

Public Class laporanpenjualan
    Private Sub laporanpenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataset As New GramediaDataSet2
        Dim adapter As New transaksipenjualanTableAdapter()

        ReportViewer1.LocalReport.ReportEmbeddedResource = "Uas.Report4.rdlc"
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", dataset.Tables(0)))
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        menuutama.Show()
    End Sub
End Class