Imports CrystalDecisions.CrystalReports.Engine

Public Class FrPrint
    Private reportClass As ReportClass

    Public Sub New(ByVal reportClass As ReportClass)
        InitializeComponent()
        Me.reportClass = reportClass
    End Sub

    Private Sub FrPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrViewer.ReportSource = reportClass
        CrViewer.Refresh()
    End Sub
End Class