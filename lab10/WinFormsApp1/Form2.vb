Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DataSet1.kat_obuch". При необходимости она может быть перемещена или удалена.
        Me.Kat_obuchTableAdapter.Fill(Me.DataSet1.kat_obuch)

    End Sub
End Class
