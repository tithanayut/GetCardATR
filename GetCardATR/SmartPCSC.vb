Imports PCSC
Imports PCSC.Utils

Public Class SmartPCSC

    Dim contextFactory As IContextFactory = PCSC.ContextFactory.Instance
    Dim hContext As ISCardContext

    Dim reader As SCardReader

    Public Function getReaderList()
        Dim readerList As String()

        Try
            hContext = contextFactory.Establish(SCardScope.System)
            readerList = hContext.GetReaders()
            hContext.Release()

            Return readerList
        Catch ex As Exceptions.PCSCException
            Throw New Exception("Error: getReaderList() : " & ex.Message & " (" & ex.SCardError.ToString() & ")")
        End Try
    End Function

    Public Function getCardATR(ByVal readerName As String)
        hContext = contextFactory.Establish(SCardScope.System)
        reader = New SCardReader(hContext)

        If readerName = Nothing Then
            Throw New ArgumentException("Error: getCardATR() : No card reader specified")
        End If

        Dim connection As SCardError
        connection = reader.Connect(readerName, SCardShareMode.Shared, SCardProtocol.T0 Or SCardProtocol.T1)
        If connection <> SCardError.Success Then
            Throw New Exception("Error: getCardATR() : Connection fail (" & SCardHelper.StringifyError(connection) & ")")
        End If

        Dim sc = hContext.ConnectReader(readerName, SCardShareMode.Shared, SCardProtocol.T0 Or SCardProtocol.T1)
        Dim cardAtr As Byte() = sc.GetAttrib(SCardAttribute.AtrString)

        Return cardAtr
    End Function

End Class
