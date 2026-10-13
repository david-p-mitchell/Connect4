Public Class frmmain
    
    Dim increment As Integer = 150
    Dim halfincrement As Integer = 60
    Dim message As String = ""


    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Get_table()


    End Sub
    Public Sub Get_table()
        Dim Connect_data As New DataTable
        Connect_data.Columns.Add("0")
        Connect_data.Columns.Add("1")
        Connect_data.Columns.Add("2")
        Connect_data.Columns.Add("3")
        Connect_data.Columns.Add("4")
        Connect_data.Columns.Add("5")
        Connect_data.Columns.Add("6")


        Connect_data.Rows.Add("", "", "", "", "", "", "")
        Connect_data.Rows.Add("", "", "", "", "", "", "")
        Connect_data.Rows.Add("", "", "", "", "", "", "")
        Connect_data.Rows.Add("", "", "", "", "", "", "")
        Connect_data.Rows.Add("", "", "", "", "", "", "")
        Connect_data.Rows.Add("", "", "", "", "", "", "")
        Connect_data.Rows.Add("", "", "", "", "", "", "")

        dgvconnect.DataSource = Connect_data

        dgvconnect.Columns("0").Width = 65
        dgvconnect.Columns("1").Width = 65
        dgvconnect.Columns("2").Width = 65
        dgvconnect.Columns("3").Width = 65
        dgvconnect.Columns("4").Width = 65
        dgvconnect.Columns("5").Width = 65
        dgvconnect.Columns("6").Width = 65

        dgvconnect.Rows("0").Height = 50
        dgvconnect.Rows("1").Height = 50
        dgvconnect.Rows("2").Height = 50
        dgvconnect.Rows("3").Height = 50
        dgvconnect.Rows("4").Height = 50
        dgvconnect.Rows("5").Height = 50
        dgvconnect.Rows("6").Height = 50

        dgvconnect.ClearSelection()


    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        End
    End Sub
    Private Sub tablecolouring()
        For i = 0 To 6
            For j = 0 To 6
                If connectarray(i, j) = 1 Then
                    dgvconnect.Item((i), (j)).Style.BackColor = Color.Red
                ElseIf connectarray(i, j) = 2 Then

                    dgvconnect.Item((i), (j)).Style.BackColor = Color.Blue
                Else
                    dgvconnect.Item((i), (j)).Style.BackColor = Color.White


                End If
            Next
        Next
    End Sub
    Private Sub btncolumn1_Click(sender As Object, e As EventArgs) Handles btncolumn1.Click
        For i = 0 To 6
            If connectarray(0, (6 - i)) = 0 Then
                connectarray(0, (6 - i)) = 1
                i = 6
            End If
        Next
        tablecolouring()
        If connectarray(0, 0) = 1 Then
            btncolumn1.Enabled = False
        End If
        If connectarray(0, 0) = 2 Then
            btncolumn1.Enabled = False
        End If

        Try
            Userai()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try



    End Sub

    Private Sub btncolumn2_Click(sender As Object, e As EventArgs) Handles btncolumn2.Click
        For i = 0 To 6
            If connectarray(1, (6 - i)) = 0 Then
                connectarray(1, (6 - i)) = 1
                i = 6
            End If
        Next
        tablecolouring()
        If connectarray(1, 0) = 1 Then
            btncolumn2.Enabled = False
        End If
        If connectarray(1, 0) = 2 Then
            btncolumn2.Enabled = False
        End If
        Try
            Userai()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btncolumn3_Click(sender As Object, e As EventArgs) Handles btncolumn3.Click
        For i = 0 To 6
            If connectarray(2, (6 - i)) = 0 Then
                connectarray(2, (6 - i)) = 1
                i = 6
            End If
        Next
        tablecolouring()
        If connectarray(2, 0) = 1 Then
            btncolumn3.Enabled = False
        End If
        If connectarray(2, 0) = 2 Then
            btncolumn2.Enabled = False
        End If
        Try
            Userai()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btncolumn4_Click(sender As Object, e As EventArgs) Handles btncolumn4.Click
        For i = 0 To 6
            If connectarray(3, (6 - i)) = 0 Then
                connectarray(3, (6 - i)) = 1
                i = 6
            End If
        Next
        tablecolouring()
        If connectarray(3, 0) = 1 Then
            btncolumn4.Enabled = False
        End If
        If connectarray(3, 0) = 2 Then
            btncolumn4.Enabled = False
        End If
        Try
            Userai()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btncolumn5_Click(sender As Object, e As EventArgs) Handles btncolumn5.Click
        For i = 0 To 6
            If connectarray(4, (6 - i)) = 0 Then
                connectarray(4, (6 - i)) = 1
                i = 6
            End If
        Next
        tablecolouring()
        If connectarray(4, 0) = 1 Then
            btncolumn5.Enabled = False
        End If
        If connectarray(4, 0) = 2 Then
            btncolumn5.Enabled = False
        End If
        Try
            Userai()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btncolumn6_Click(sender As Object, e As EventArgs) Handles btncolumn6.Click
        For i = 0 To 6
            If connectarray(5, (6 - i)) = 0 Then
                connectarray(5, (6 - i)) = 1
                i = 6
            End If
        Next
        tablecolouring()
        If connectarray(5, 0) = 1 Then
            btncolumn6.Enabled = False
        End If
        If connectarray(5, 0) = 2 Then
            btncolumn6.Enabled = False
        End If
        Try
            Userai()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btncolumn7_Click(sender As Object, e As EventArgs) Handles btncolumn7.Click
        For i = 0 To 6
            If connectarray(6, (6 - i)) = 0 Then
                connectarray(6, (6 - i)) = 1
                i = 6
            End If
        Next
        tablecolouring()
        If connectarray(6, 0) = 1 Then
            btncolumn7.Enabled = False
        End If
        If connectarray(6, 0) = 2 Then
            btncolumn7.Enabled = False
        End If
        Try
            Userai()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Userai()
        
        For i = 0 To 6
            For j = 0 To 6
                cellref(i, j, 0) = 0
            Next
        Next

        For i = 0 To 6
            For j = 0 To 6
                If connectarray(i, j) = 1 Then
                    If -1 = scan(i, j) Then
                        MessageBox.Show("You have won" + message)
                        i = 6
                        j = 6
                        reset()
                        resetboo = True
                    End If

                End If
            Next
        Next

        If resetboo = True Then
        Else
            For i = 0 To 6
                For j = 0 To 6
                    If connectarray(j, i) = 1 Then
                        scan(j, i)


                    End If
                Next
            Next

            int = 0
            nint = 0
            For i = 0 To 49
                rand(i, 0) = -1
                rand(i, 1) = -2
                medarray(i) = -1
            Next
            For i = 49 To medarray.Length - 1
                medarray(i) = -1
            Next
            For i = 0 To 6
                For j = 0 To 6
                    'how likely it should be that cell
                    int += cellref(i, j, 0)
                    If cellref(i, j, 0) > 0 Then
                        ' how many for each column
                        rand(nint, 0) = i
                        rand(nint, 1) = cellref(i, j, 0)
                        nint += 1
                    End If
                Next
            Next
            ' knowing where to disect
            For i = 0 To smallarray.Length - 1
                smallarray(i) = -1
            Next
            'putting in the right number of real column values into a different array.
            count = 0
            For i = 0 To nint - 1
                For j = 0 To rand(i, 1) - 1

                    medarray(count) = rand(i, 0)
                    count += 1
                Next
            Next
            ' finding the numbers in the previous array.
            For j = 0 To medarray.Length - 1
                For i = 0 To 6
                    'if they're the same then move to the next
                    If smallarray(i) = medarray(j) Then
                        i = 6
                    Else
                        'else go through the previous to check then put in
                        If smallarray(i) = -1 Then
                            check = False
                            For k = 0 To 6
                                If smallarray(k) = medarray(j) Then
                                    check = True
                                End If
                            Next
                            If check = False Then
                                smallarray(i) = medarray(j)
                            End If
                        End If
                    End If
                Next
            Next
            'putting the numbers not in the previous array in an array 
            For i = 0 To sortarray.Length - 1
                sortarray(i) = -1
            Next
            num2 = 0
            For i = 0 To 6
                If connectarray(i, 0) <> 0 Then
                    num2 += 1
                End If
            Next
            int = 0
            nint = 0
            For j = 0 To 6
                For i = 0 To medarray.Length - 1
                    If j = medarray(i) Then
                        If medarray(i) <> -1 Then
                            nint = 1
                            i = medarray.Length - 1
                        End If

                    End If
                Next
                If nint <> 1 Then
                    sortarray(int) = j
                    int += 1
                End If
                nint = 0
            Next


            Dim Random_alloc(((count + int - num2) - 1)) As Integer

            For i = 0 To count - 1
                If connectarray(medarray(i), 0) <> 0 Then
                Else
                    Random_alloc(i) = medarray(i)

                End If

            Next
            nint = 0
            If num2 > 0 Then
                For i = count To Random_alloc.Length
                    If connectarray(i - count, 0) <> 0 Then
                        nint -= 1
                    Else

                        Random_alloc(i + nint) = sortarray(i - count)

                    End If
                Next
            Else
                For i = count To Random_alloc.Length - 1
                    If connectarray(i - count, 0) <> 0 Then

                    Else

                        Random_alloc(i + nint) = sortarray(i - count)

                    End If
                Next
            End If




            Dim num As Integer = GetRandom(0, Random_alloc.Length - 1)
            Dim rowselect As Integer

            rowselect = Random_alloc(num)

            For i = 0 To 6

                If connectarray(rowselect, (6 - i)) = 0 Then
                    connectarray(rowselect, (6 - i)) = 2
                    i = 6
                End If
            Next
            tablecolouring()
            If connectarray(0, 0) = 2 Then
                btncolumn1.Enabled = False
            End If
            If connectarray(1, 0) = 2 Then
                btncolumn2.Enabled = False
            End If
            If connectarray(2, 0) = 2 Then
                btncolumn3.Enabled = False
            End If
            If connectarray(3, 0) = 2 Then
                btncolumn4.Enabled = False
            End If
            If connectarray(4, 0) = 2 Then
                btncolumn5.Enabled = False
            End If
            If connectarray(5, 0) = 2 Then
                btncolumn6.Enabled = False
            End If
            If connectarray(6, 0) = 2 Then
                btncolumn7.Enabled = False
            End If
            End If

    End Sub
    Public Function scan(r As Integer, c As Integer)


        For j = 0 To 3
            scancheck(j) = 0
        Next
        

        If r >= 0 Then
            If c >= 0 Then



                'for up left diag
                If -1 = scan_u_l(r, c) Then
                    message += "ul"
                    Return -1
                End If
                

            End If
            If c < 7 Then
                'for up right diag
                If -1 = scan_u_r(r, c) Then
                    message += "ur"
                    Return -1
                End If


                'for right diag
                If -1 = scan_r(r, c) Then
                    message += "r"
                    Return -1
                End If
            End If
            If c > -1 Then
                If -1 = scan_l(r, c) Then

                    message += "l"
                    Return -1
                End If
            End If

        End If

        ' for the up the column
        For v = 1 To 3
            'checking how many up link for same
            If (c - v) >= 0 Then
                If connectarray(r, c - v) = 1 Then
                    scancheck(1) += 1
                ElseIf connectarray(r, c - v) = 0 Then
                    v = 3
                End If
            End If
        Next

        If scancheck(1) = 1 Then
            If r >= 0 Then
                If c - 2 >= 0 Then
                    If connectarray(r, c - 2) = 0 Then
                        If connectarray(r, c - 1) = 0 Then
                        Else
                            cellref(r, c - 2, 0) += halfincrement
                        End If
                    End If
                End If
            End If

        ElseIf scancheck(1) = 2 Then
            If (c - 3) >= 0 Then


                If connectarray(r, c - 3) = 0 Then
                    If connectarray(r, c - 2) = 0 Then
                    Else
                        cellref(r, c - 3, 0) += increment
                    End If
                End If
            End If
        ElseIf scancheck(1) = 3 Then
            Return -1
        End If

        Return -2
    End Function
    Public Function scan_u_l(r As Integer, c As Integer)
        For v = 1 To 3
            'checking how many up right diag link for same
            If (r - v) >= 0 Then
                If (c - v) >= 0 Then
                    If connectarray(r - v, c - v) = 1 Then
                        scancheck(0) += 1
                    ElseIf connectarray(r - v, c - v) = 0 Then
                        v = 3
                    End If
                End If
            End If
        Next
        If scancheck(0) = 1 Then
            If r - 2 >= 0 Then
                If c - 2 >= 0 Then


                    If connectarray(r - 2, c - 2) = 0 Then

                        If connectarray(r - 2, c - 1) = 0 Then
                        Else
                            cellref(r - 2, c - 2, 0) += halfincrement
                        End If
                    End If
                End If
            End If
            If r - 3 >= 0 Then
                If c - 3 >= 0 Then
                    If connectarray(r - 3, c - 3) = 1 Then
                        If connectarray(r - 3, c - 2) = 0 Then
                        Else
                            cellref(r - 2, c - 2, 0) += increment
                        End If
                    End If
                End If
            End If
        ElseIf scancheck(0) = 2 Then
            If r - 3 >= 0 Then
                If c - 3 >= 0 Then
                    If connectarray(r - 3, c - 3) = 0 Then
                        If connectarray(r - 3, c - 2) = 0 Then
                        Else
                            cellref(r - 3, c - 3, 0) += increment
                        End If
                    End If
                End If
            End If
        ElseIf scancheck(0) = 3 Then
            Return -1
        End If
        Return -2
    End Function
    Public Function scan_u_r(r As Integer, c As Integer)
        For v = 1 To 3
            'checking how many up right diag link for same
            If (r - v) >= 0 Then
                If (c + v) >= 0 Then
                    If connectarray(r - v, c + v) = 1 Then
                        scancheck(0) += 1
                    ElseIf connectarray(r - v, c + v) = 0 Then
                        v = 3
                    End If
                End If
            End If
        Next
        If scancheck(0) = 1 Then
            If r - 2 >= 0 Then
                If c + 2 < 7 Then


                    If connectarray(r - 2, c + 2) = 0 Then

                        If connectarray(r - 2, c + 1) = 0 Then
                        Else
                            cellref(r - 2, c + 2, 0) += halfincrement
                        End If
                    End If
                End If
            End If
            If r - 3 >= 0 Then
                If c + 3 < 7 Then
                    If connectarray(r - 3, c + 3) = 1 Then
                        If connectarray(r - 3, c + 2) = 0 Then
                        Else
                            cellref(r - 2, c + 2, 0) += increment
                        End If
                    End If
                End If
            End If
        ElseIf scancheck(0) = 2 Then
            If r - 3 >= 0 Then
                If c + 3 < 7 Then
                    If connectarray(r - 3, c + 3) = 0 Then
                        If connectarray(r - 3, c + 2) = 0 Then
                        Else
                            cellref(r - 3, c + 3, 0) += increment
                        End If
                    End If
                End If
            End If
        ElseIf scancheck(0) = 3 Then
            Return -1
        End If
        Return -2
    End Function
    Public Function scan_r(r As Integer, c As Integer)
        For v = 1 To 3
            'checking how many up right diag link for same
            If (r + v) >= 0 Then
                If (c + v) >= 0 Then
                    If connectarray(r + v, c) = 1 Then
                        scancheck(0) += 1
                    ElseIf connectarray(r + v, c) = 0 Then
                        v = 3
                    End If
                End If
            End If
        Next
        If scancheck(0) = 1 Then
            If r + 2 >= 0 Then



                If connectarray(r + 2, c) = 0 Then

                    If connectarray(r + 2, c) = 0 Then
                    Else
                        cellref(r + 2, c, 0) += halfincrement
                    End If
                End If

            End If
            If r + 3 >= 0 Then

                If connectarray(r + 3, c) = 1 Then
                    If connectarray(r + 3, c) = 0 Then
                    Else
                        cellref(r + 2, c, 0) += increment
                    End If
                End If

            End If
        ElseIf scancheck(0) = 2 Then
            If r + 3 >= 0 Then

                If connectarray(r + 3, c) = 0 Then
                    If connectarray(r + 3, c) = 0 Then
                    Else
                        cellref(r + 3, c, 0) += increment
                    End If

                End If
        End If
        ElseIf scancheck(0) = 3 Then
            message += "  " + c.ToString + ",  " + r.ToString + "  "
            Return -1
        End If
        Return -2
    End Function
    Public Function scan_l(r As Integer, c As Integer)
        For v = 1 To 3
            'checking how many up left diag link for same
            If (r - v) >= 0 Then
                If (c + v) >= 0 Then
                    If connectarray(r - v, c) = 1 Then
                        scancheck(0) += 1
                    ElseIf connectarray(r - v, c) = 0 Then
                        v = 3
                    End If
                End If
            End If
        Next
        If scancheck(0) = 1 Then
            If r - 2 >= 0 Then



                If connectarray(r - 2, c) = 0 Then

                    If connectarray(r - 2, c) = 0 Then
                    Else
                        cellref(r - 2, c, 0) += halfincrement
                    End If
                End If

            End If
            If r - 3 >= 0 Then

                If connectarray(r - 3, c) = 1 Then
                    If connectarray(r - 3, c) = 0 Then
                    Else
                        cellref(r - 2, c, 0) += increment
                    End If
                End If

            End If
        ElseIf scancheck(0) = 2 Then
            If r - 3 >= 0 Then
                If c - 3 > 0 Then
                    If connectarray(r - 3, c) = 0 Then
                        If connectarray(r - 3, c) = 0 Then
                        Else
                            cellref(r - 3, c, 0) += increment
                        End If
                    End If
                End If
            End If
        ElseIf scancheck(0) = 3 Then
            message += "  " + c.ToString + ",  " + r.ToString + "  "
            Return -1
        End If
        Return -2
    End Function
    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function
    Private Sub reset()
        For i = 0 To 6
            For j = 0 To 6
                smallarray(j) = -1
                sortarray(j) = -1
                cellref(i, j, 0) = -1
                cellref(i, j, 1) = -1
                connectarray(i, j) = 0
            Next
        Next
        tablecolouring()


    End Sub
End Class
