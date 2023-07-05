Imports Uas.supplier
Imports Uas.GramediaDataSet
Imports Microsoft.Reporting.WinForms
Imports Uas.GramediaDataSetTableAdapters
Imports Uas.supplierTableAdapters

Public Class laporansupplier
    Private Sub laporansupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataset As New supplier
        Dim adapter As New supplierTableAdapter()



        adapter.Fill(dataset._supplier)
        ReportViewer1.LocalReport.ReportEmbeddedResource = "Uas.Report2.rdlc"
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("supplier", dataset.Tables(0)))
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        menuutama.Show()
    End Sub
End Class