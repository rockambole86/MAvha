Imports Mavha.DAL

Public Module DataManager
    Private ReadOnly DB As DB = DB.Instance()

    Public Function PersonList() As List(Of Person)
        Try
            DB.Connect
            Dim table = DB.ExecuteDataTable("PersonList", Nothing)

            Dim RetVal = New List(Of Person)

            If (table Is Nothing OrElse table.Rows.Count = 0)
                Return RetVal
            End If

            For Each dr As DataRow In table.Rows
                Dim person As new Person()

                With person
                    .Id = dr.Field (Of Integer)("PersonId")
                    .Fullname = dr.Field (Of String)("Fullname")
                    .DOB = dr.Field (Of DateTime)("DOB")
                    .Age = dr.Field (Of Integer)("Age")
                    .Gender = dr.Field (Of Gender)("Gender")
                    .IsActive = dr.Field (Of Boolean)("IsActive")
                End With

                RetVal.Add(person)
            Next

            Return RetVal
        Finally
            DB.Disconnect
        End Try
    End Function

    Public Sub PersonSave(person As Person)
        Try
            DB.Connect

            Dim parameters = New Hashtable From {
                    {"PersonId", person.Id},
                    {"Fullname", person.Fullname},
                    {"DOB", person.DOB},
                    {"Age", person.Age},
                    {"Gender", person.Gender}
                    }

            DB.ExecuteNonQuery("PersonSave", parameters)
        Finally
            DB.Disconnect
        End Try
    End Sub

    Public Sub PersonDelete(id As Integer)
        Try
            DB.Connect
            Dim parameters = New Hashtable From {
                    {"PersonId", id}
                    }

            DB.ExecuteNonQuery("PersonDelete", parameters)
        Finally
            DB.Disconnect
        End Try
    End Sub
End Module