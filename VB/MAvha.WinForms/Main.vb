Imports MAvha.WinForms.MAvhaService

Public Class Main
    Private ReadOnly _serviceClient As ServiceSoapClient = New ServiceSoapClient()

    Public CurrentPerson As Person = New Person

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDOB.Value = DateTime.Today

        ddlGender.DataSource = System.Enum.GetValues(GetType(Gender))
        ddlGender.Refresh

        Call LoadResults()

        btnDelete.Enabled = False
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call LoadResults(_serviceClient.List())
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        With CurrentPerson
            .Fullname = txtFullname.Text
            .DOB = dtpDOB.Value
            .Age = Convert.ToInt32(txtAge.Value)
            .Gender = ddlGender.SelectedValue
        End With

        _serviceClient.Save(CurrentPerson)

        Call LoadResults()

        Call Reset()

        btnRefresh.Enabled = True
        btnDelete.Enabled = False
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        _serviceClient.Delete(CurrentPerson.Id)

        Call Reset()

        Call LoadResults()

        btnRefresh.Enabled = true
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call Reset()

        btnRefresh.Enabled = True
        btnDelete.Enabled = False
    End Sub

    Private Sub grdResults_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles grdResults.CellDoubleClick

        If (e.RowIndex < 0)
            Return
        End If

        CurrentPerson = CType(grdResults.Rows(e.RowIndex).DataBoundItem, Person)

        txtFullname.Text = CurrentPerson.Fullname
        dtpDOB.Value = CurrentPerson.DOB
        txtAge.Text = CurrentPerson.Age.ToString()
        ddlGender.SelectedItem = CurrentPerson.Gender

        btnRefresh.Enabled = False
        btnDelete.Enabled = True
    End Sub

#Region "Functions"

    Private Sub LoadResults(optional results As IEnumerable(Of Person) = nothing)
        grdResults.DataSource = IIf(results Is Nothing, _serviceClient.List(), results)
        grdResults.Refresh

        SetupGrid()
    End Sub

    Private Sub Reset()
        txtFullname.Text = String.Empty
        dtpDOB.Value = DateTime.Today
        txtAge.Value = txtAge.Minimum
        ddlGender.SelectedItem = Gender.Masculino
    End Sub

    Private Sub SetupGrid
        For Each column As DataGridViewColumn In grdResults.Columns
            column.Visible = False
        Next

        With grdResults
            .Columns(0).Visible = False
            .Columns(0).HeaderText = $"Id"
            .Columns(0).DisplayIndex = 0

            .Columns(1).Visible = True
            .Columns(1).HeaderText = $"Nombre completo"
            .Columns(1).Width = 350
            .Columns(1).DisplayIndex = 1

            .Columns(2).Visible = True
            .Columns(2).HeaderText = $"Fecha nacimiento"
            .Columns(2).Width = 150
            .Columns(2).DisplayIndex = 2

            .Columns(3).Visible = True
            .Columns(3).HeaderText = $"Edad"
            .Columns(3).Width = 50
            .Columns(3).DisplayIndex = 3

            .Columns(4).Visible = True
            .Columns(4).HeaderText = $"Sexo"
            .Columns(4).Width = 100
            .Columns(4).DisplayIndex = 4

            .Columns(5).Visible = False
            .Columns(5).HeaderText = $"Id"
            .Columns(5).DisplayIndex = 5
        End With
    End Sub

#End Region
End Class
