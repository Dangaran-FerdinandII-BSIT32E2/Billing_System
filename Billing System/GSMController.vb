Imports System.IO.Ports

Public Class GSMController
    Private serialPort As SerialPort
    Private Const DEFAULT_TIMEOUT As Integer = 3000 ' 3 seconds timeout

    Public Sub New(portName As String, baudRate As Integer)
        serialPort = New SerialPort() With {
            .PortName = portName,
            .BaudRate = baudRate,
            .DataBits = 8,
            .Parity = Parity.None,
            .StopBits = StopBits.One,
            .ReadTimeout = DEFAULT_TIMEOUT,
            .WriteTimeout = DEFAULT_TIMEOUT
        }
    End Sub

    Public Function Initialize() As Boolean
        Try
            If Not serialPort.IsOpen Then
                serialPort.Open()
            End If

            ' Test AT command to check if module is responding
            If Not SendCommand("AT", "OK") Then
                Return False
            End If

            ' Set SMS text mode
            If Not SendCommand("AT+CMGF=1", "OK") Then
                Return False
            End If

            Return True
        Catch ex As Exception
            Console.WriteLine($"Error initializing GSM module: {ex.Message}")
            Return False
        End Try
    End Function

    Public Function SendSMS(phoneNumber As String, message As String) As Boolean
        Try
            ' Set the phone number
            If Not SendCommand($"AT+CMGS=""{phoneNumber}""", ">") Then
                Return False
            End If

            ' Send the message content
            serialPort.Write(message & Convert.ToChar(26))

            ' Wait for response (may take longer for sending SMS)
            System.Threading.Thread.Sleep(5000)

            ' Check if message was sent successfully
            Dim response As String = serialPort.ReadExisting()
            Return response.Contains("OK")

        Catch ex As Exception
            Console.WriteLine($"Error sending SMS: {ex.Message}")
            Return False
        End Try
    End Function

    Private Function SendCommand(command As String, expectedResponse As String) As Boolean
        Try
            serialPort.WriteLine(command)
            System.Threading.Thread.Sleep(1000)

            Dim response As String = serialPort.ReadExisting()
            Return response.Contains(expectedResponse)

        Catch ex As Exception
            Console.WriteLine($"Error sending command {command}: {ex.Message}")
            Return False
        End Try
    End Function

    Public Sub Close()
        If serialPort IsNot Nothing AndAlso serialPort.IsOpen Then
            serialPort.Close()
        End If
    End Sub
End Class