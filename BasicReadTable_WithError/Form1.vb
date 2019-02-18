Imports BasicReadTable_WithError.Classes

Public Class Form1
    Private bsCustomers As New BindingSource
    Private Sub Form1_Shown(sender As Object, e As EventArgs) _
        Handles Me.Shown

        Dim ops As New DatabaseOperations

        bsCustomers.DataSource = ops.LoadCustomers
        If ops.IsSuccessFul Then
            DataGridView1.DataSource = bsCustomers
        Else
            Dim lastException As Exception = ops.LastException
            MessageBox.Show(ops.LastExceptionMessage)
        End If

    End Sub

End Class
