Imports SQL_ServerBasicExample.Classes

Public Class Form1
    Private bsData As New BindingSource
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ops As New DataOperations
        bsData.DataSource = ops.GetCustomersByStatus()
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = bsData
    End Sub
    ''' <summary>
    ''' Since primary keys are not in the DataGridView but in the underlying DataTable
    ''' this event shows how to get at the keys.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub currentRowDetailsButton_Click(sender As Object, e As EventArgs) Handles currentRowDetailsButton.Click
        If bsData.Current IsNot Nothing Then
            Dim currentRow As DataRow = bsData.CurrentRow()
            Dim companyIdentifier As Integer = currentRow.Field(Of Integer)("CustomerIdentifier")
            Dim contactIdentifier As Integer = currentRow.Field(Of Integer)("ContactIdentifier")
            Dim contactTypeIdentifier As Integer = currentRow.Field(Of Integer)("ContactTypeIdentifier")
            Dim countryIdentifier As Integer = currentRow.Field(Of Integer)("CountryIdentfier")

            MessageBox.Show(
                $"Company id: {companyIdentifier} " &
                $"contact id: {contactIdentifier} " &
                $"contact type id: {contactTypeIdentifier} " &
                $"country id: {countryIdentifier}")

        End If
    End Sub
End Class
