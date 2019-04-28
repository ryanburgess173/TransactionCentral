Public Class Form1
    Dim RecordsView As New Records
    Private Sub TransactionsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TransactionsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TransactionsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TailoringBusinessDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TailoringBusinessDataSet.Transactions' table. You can move, or remove it, as needed.
        Me.TransactionsTableAdapter.Fill(Me.TailoringBusinessDataSet.Transactions)

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Created by Johnathan R. Burgess of GTCC.", , "Transaction Central")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub TransactionRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransactionRecordsToolStripMenuItem.Click
        RecordsView = New Records
        RecordsView.Show()
        RecordsView.Activate()
    End Sub

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Sales_TaxTextBox.Text = Convert.ToDouble(Sub_TotalTextBox.Text) * 0.065
        TotalTextBox.Text = Convert.ToDouble(Sub_TotalTextBox.Text) + Convert.ToDouble(Sales_TaxTextBox.Text)
    End Sub
End Class
