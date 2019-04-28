Public Class Records
    Private Sub TransactionsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TransactionsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TransactionsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TailoringBusinessDataSet)

    End Sub

    Private Sub Records_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TailoringBusinessDataSet.Transactions' table. You can move, or remove it, as needed.
        Me.TransactionsTableAdapter.Fill(Me.TailoringBusinessDataSet.Transactions)

    End Sub
End Class