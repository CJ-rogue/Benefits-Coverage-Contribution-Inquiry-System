Public Class Menu
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(200, Color.White)
    End Sub
    Public Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim Name As String = TextBox1.Text
        Dim Company As String = TextBox2.Text
        Dim MonthlySalary As Double
        Double.TryParse(TextBox3.Text, MonthlySalary)

        Dim pesoSign As Char = ChrW(&H20B1) ' Unicode for the Philippine Peso sign

        MessageBox.Show("                                 Employee Data                         " & vbCrLf & vbCrLf &
                "Name                     :" & Name & vbCrLf &
                "Company               :  " & Company & vbCrLf &
                "Monthly Salary     : " & pesoSign & MonthlySalary & vbCrLf & vbCrLf &
                "Income Tax          : " & pesoSign & IncomeTax(MonthlySalary) & vbCrLf &
                "Pag-Ibig               : " & pesoSign & PagIbig(MonthlySalary) & vbCrLf &
                "SSS                       : " & pesoSign & SSS(MonthlySalary) & vbCrLf &
                "PhilHealth           : " & pesoSign & PhilHealth(MonthlySalary), "BCCI System")

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Block the character input
            e.Handled = True
        End If
    End Sub

    Public Function IncomeTax(MonthlySalary As Double) As Double
        Dim AnnualSalary As Double = MonthlySalary * 12
        Dim tax As Double
        If AnnualSalary <= 250000 Then
            tax = 0

        ElseIf AnnualSalary > 250000 & AnnualSalary <= 400000 Then
            tax = (0.2 * (AnnualSalary - 250000)) / 12

        ElseIf AnnualSalary > 400000 & AnnualSalary <= 800000 Then
            tax = (30000 + (0.25 * (AnnualSalary - 400000))) / 12

        ElseIf AnnualSalary > 800000 & AnnualSalary <= 2000000 Then
            tax = (130000 + (0.3 * (AnnualSalary - 800000))) / 12

        ElseIf AnnualSalary > 2000000 & AnnualSalary <= 8000000 Then
            tax = (490000 + (0.32 * (AnnualSalary - 2000000))) / 12

        Else
            tax = (2410000 + (0.35 * (AnnualSalary - 8000000))) / 12
        End If
        Return tax.ToString("0.00")
    End Function

    Public Function PagIbig(MonthlySalary As Double) As Double
        Dim Ibig As Double
        If MonthlySalary <= 1500 Then
            Ibig = 0.01 * MonthlySalary
        Else
            Ibig = 0.02 * MonthlySalary
        End If

        Return Ibig.ToString("0.00")
    End Function

    Public Function SSS(MonthlySalary As Double) As Double
        Dim SS As Double = 0
        Dim first As Double = 2250
        Dim last As Double = 2749.99
        Dim max As Double = 19750
        Dim j As Integer = 80

        For i As Integer = 1 To 36
            If MonthlySalary < first Then
                SS = j
                Exit For
            ElseIf MonthlySalary > max Then
                SS = 800
                Exit For
            Else
                j += 20
                first += 500
            End If
        Next
        Return SS.ToString("0.00")
    End Function

    Public Function PhilHealth(MonthlySalary As Double) As Double
        Dim Health As Double = 0
        Dim first As Double = 9000
        Dim last As Double = 9999.99
        Dim max As Double = 35000
        Dim j As Double = 112.5

        For i As Integer = 1 To 27
            If MonthlySalary < first Then
                Health = 100
                Exit For

            ElseIf MonthlySalary > max Then
                Health = 437.5
                Exit For

            ElseIf MonthlySalary >= first & MonthlySalary <= last Then
                Health = j
                Exit For

            Else
                j += 12.5
                first += 1000
                last += 1000
            End If
        Next
        Return Health.ToString("0.00")
    End Function

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
