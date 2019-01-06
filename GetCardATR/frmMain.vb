Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnRefreshList.PerformClick()
    End Sub

    Private Sub btnRefreshList_Click(sender As Object, e As EventArgs) Handles btnRefreshList.Click
        Try
            cbbReaderList.DataSource = Nothing

            Dim tool As New SmartPCSC
            Dim readerList As String()

            readerList = tool.getReaderList()
            If readerList.Length > 0 Then
                cbbReaderList.DataSource = readerList
            Else
                MessageBox.Show("No card reader detected!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnReadATR_Click(sender As Object, e As EventArgs) Handles btnReadATR.Click
        lblRetrievedDateTime.Text = Nothing
        txtCardATR.Text = Nothing

        Try
            Dim tool As New SmartPCSC
            Dim cardATR As Byte()

            cardATR = tool.getCardATR(cbbReaderList.Text)
            txtCardATR.Text = BitConverter.ToString(cardATR)

            lblRetrievedDateTime.Text = Now.ToShortDateString & " " & Now.ToLongTimeString
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
