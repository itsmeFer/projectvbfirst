Imports System.Data.SqlClient
Imports System.Data

Module autocodeidpembelian


    Function Autocode1(X As String, Y As DateTime) As String
        Dim Z As Boolean = True
        Dim Last As Integer

        Using conn = New SqlConnection
            conn.ConnectionString = "Data Source = LAPTOP-0HATQUNE; Initial Catalog = Gramedia; Integrated Security = True"

            Using cmdX As New SqlCommand
                conn.Open()
                cmdX.Connection = conn

                Select Case X
                    Case "id_pembeliann"
                        cmdX.CommandText = "SELECT TOP 1 id_pembelian from transaksi_pembeliann WHERE SUBSTRING(id_pembelian,3,2) = '" & Format(Y, "yy") &
                                           "'AND SUBSTRING(id_pembelian,5,2) = '" & Format(Y, "MM") & "' ORDER BY id_pembelian DESC"
                End Select

                Using drX As SqlDataReader = cmdX.ExecuteReader
                    If drX.HasRows Then
                        While drX.Read
                            Last = CInt(Mid(drX.Item("id_pembelian"), 7, 4))
                            Z = False
                        End While
                    End If
                    drX.Close()
                End Using
            End Using
        End Using

        Select Case X
            Case "id_pembeliann"
                If Z Then
                    Return "TP" & Format(Y, "yyMM") & "101"
                Else
                    Return "TP" & Format(Y, "yyMM") & (Last + 1).ToString
                End If
        End Select
        Return ""
    End Function
End Module


