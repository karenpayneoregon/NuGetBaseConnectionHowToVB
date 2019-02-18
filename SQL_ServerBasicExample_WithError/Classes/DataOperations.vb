Imports System.Data.SqlClient
Imports BaseConnectionLibrary.ConnectionClasses

Namespace Classes

    Public Class DataOperations
        Inherits SqlServerConnection

        Public Sub New()
            DatabaseServer = "KARENS-PC"
            DefaultCatalog = "NorthWindAzure3"
        End Sub
        Public Function GetCustomersByStatus() As DataTable

            Dim dt As New DataTable

            mHasException = False

            '
            ' City is misspelled as Cities which throws an exception
            '
            Dim selectStatement As String =
                    <SQL>
                    SELECT C.CustomerIdentifier ,
                           C.CompanyName ,
                           Contact.FirstName + ' ' +  Contact.LastName AS FullName,
                           CT.ContactTitle ,
                           C.ContactIdentifier ,
                           C.ContactTypeIdentifier ,
                           C.Street ,
                           C.Cities ,
                           C.PostalCode ,
                           C.CountryIdentfier ,
                           Countries.CountryName ,
                           C.Phone
                    FROM   Customers AS C
                           INNER JOIN ContactType AS CT ON C.ContactTypeIdentifier = CT.ContactTypeIdentifier
                           INNER JOIN Countries ON C.CountryIdentfier = Countries.id
                           INNER JOIN Contact ON C.ContactIdentifier = Contact.ContactIdentifier;
                    </SQL>.Value


            Using cn = New SqlConnection With {.ConnectionString = ConnectionString}
                Using cmd = New SqlCommand With {.Connection = cn}

                    cmd.CommandText = selectStatement

                    Try

                        cn.Open()

                        dt.Load(cmd.ExecuteReader())

                    Catch ex As Exception

                        mHasException = True
                        mLastException = ex

                    End Try

                End Using
            End Using

            Return dt
        End Function
    End Class
End Namespace