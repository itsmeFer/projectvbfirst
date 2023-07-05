Imports Microsoft.Reporting.WinForms
Imports Uas.GramediaDataSet1
Imports Uas.GramediaDataSet1TableAdapters

Public Class laporanpembelian
    Private Sub laporanpembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataset As New GramediaDataSet1
        Dim adapter As New transaksi_pembeliannTableAdapter()
        adapter.Fill(dataset.transaksi_pembeliann)

        ReportViewer1.LocalReport.ReportEmbeddedResource = "Uas.Report3.rdlc"
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