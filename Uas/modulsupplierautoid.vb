Imports System.Data
Imports System.Data.SqlClient
Module modulsupplierautoid
    Function Autocode(X As String, Y As DateTime) As String
        Dim Z As Boolean = True
        Dim Last As Integer

        Using conn = New SqlConnection
            conn.ConnectionString = "Data Source = LAPTOP-0HATQUNE; Initial Catalog = Gramedia; Integrated Security = True"

            Using cmdX As New SqlCommand
                conn.Open()
                cmdX.Connection = conn

                Select Case X
                    Case "supplier"
                        cmdX.CommandText = "SELECT TOP 1 id_supplier from supplier WHERE SUBSTRING(id_supplier,3,2) = '" & Format(Y, "yy") &
                                           "'AND SUBSTRING(id_supplier,5,2) = '" & Format(Y, "MM") & "' ORDER BY id_supplier DESC"
                End Select

                Using drX As SqlDataReader = cmdX.ExecuteReader
                    If drX.HasRows Then
                        While drX.Read
                            Last = CInt(Mid(drX.Item("id_supplier"), 7, 4))
                            Z = False
                        End While
                    End If
                    drX.Close()
                End Using
            End Using
        End Using

        Select Case X
            Case "supplier"
                If Z Then
                    Return "SP" & Format(Y, "yyMM") & "101"
                Else
                    Return "SP" & Format(Y, "yyMM") & (Last + 1).ToString
                End If
        End Select
        Return ""
    End Function
End Module
