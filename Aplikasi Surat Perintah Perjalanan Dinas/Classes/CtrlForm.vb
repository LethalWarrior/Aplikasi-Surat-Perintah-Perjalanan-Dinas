Imports MySql.Data.MySqlClient

Public Class CtrlForm

    Private Controls() As Control.ControlCollection
    Private EProf As ErrorProvider

    Public Sub New(ByVal Controls As Control.ControlCollection(), ByVal EProf As ErrorProvider)
        Me.Controls = Controls
        Me.EProf = EProf
    End Sub

    Public Sub New()

    End Sub

    Public Sub ClearControls()
        For Each cls As Control.ControlCollection In Controls
            For Each c As Control In cls
                If (c.GetType().Equals(GetType(TextBox))) Then
                    c.Text = ""
                End If
            Next
        Next
    End Sub

    Public Sub ClearControls(ByVal Control As Control.ControlCollection)
        For Each c As Control In Control
            If (c.GetType().Equals(GetType(TextBox))) Then
                c.Text = ""
            End If
        Next
    End Sub

    Public Sub EnableControls(ByVal status As Boolean)
        For Each cls As Control.ControlCollection In Controls
            For Each c As Control In cls
                If (Not c.GetType().Equals(GetType(Label))) Then
                    c.Enabled = status
                End If
            Next
        Next
    End Sub

    Public Sub EnableControls(ByVal Status As Boolean, ByVal Controls() As Control)
        For Each c As Control In Controls
            If (Not c.GetType().Equals(GetType(Label))) Then
                c.Enabled = Status
            End If
        Next
    End Sub

    Public Sub VisibleControls(ByVal status As Boolean)
        For Each cls As Control.ControlCollection In Controls
            For Each c As Control In cls
                c.Visible = status
            Next
        Next
    End Sub

    Public Sub VisibleControls(ByVal Status As Boolean, ByVal Controls() As Control)
        For Each c As Control In Controls
            c.Visible = Status
        Next
    End Sub

    Public Sub ShowMessageOK(ByVal Message As String, ByVal Icon As MessageBoxIcon)
        MessageBox.Show(Message, Application.ProductName, MessageBoxButtons.OK, Icon)
    End Sub

    Public Function ShowMessageYesNo(ByVal Message As String, ByVal Icon As MessageBoxIcon)
        If (MessageBox.Show(Message, Application.ProductName, MessageBoxButtons.YesNo, Icon) = DialogResult.Yes) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ValidateEmpty(ByVal EProf As ErrorProvider)
        For Each Cls As Control.ControlCollection In Controls
            For Each c As Control In Cls
                If (c.GetType().Equals(GetType(TextBox))) Then
                    If (String.IsNullOrEmpty(c.Text)) Then
                        ShowMessageOK("Ada input yang salah!", MessageBoxIcon.Error)
                        EProf.SetError(c, "Harus diisi!")
                        Return False
                    Else
                        EProf.SetError(c, "")
                    End If
                End If
            Next
        Next
        Return True
    End Function

End Class
