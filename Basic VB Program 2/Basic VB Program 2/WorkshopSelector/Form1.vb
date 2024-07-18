Option Explicit On
Public Class Form1
    'Made by Keeghan Johnson
    Private Sub btnAddWorkshop_Click(sender As Object, e As EventArgs) Handles btnAddWorkshop.Click

        'Stores the number of days in array
        Dim numberOfDays As Integer() = {3, 3, 3, 5, 1}
        'Stores the registration fees in array
        Dim registrationFee As Double() = {595, 695, 995, 1295, 395}
        'Stores the lodging fees in array

        Dim lodgingFee As Double() = {95, 125, 110, 100, 92, 90}
        Dim rFee, lFee, total As Double
        Dim days As Integer

        days = numberOfDays(lstWorkshop.SelectedIndex)
        rFee = registrationFee(lstWorkshop.SelectedIndex)
        lFee = lodgingFee(lstLocation.SelectedIndex)
        'Calculates the total fee
        total = rFee + (days * lFee)
        'Adds the fees to the box
        lstCosts.Items.Add(total.ToString("0.00"))
    End Sub

    Private Sub btnCalculateTotal_Click(sender As Object, e As EventArgs) Handles btnCalculateTotal.Click
        Dim total As Double = 0.0
        For Each Item In lstCosts.Items
            'Adds cost to the total
            total = total + Convert.ToDouble(Item)
        Next
        'Displays the total cost
        lblTotalCost.Text = total.ToString("0.00")
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Reset all control
        lstWorkshop.SelectedIndex = -1
        lstLocation.SelectedIndex = -1
        lstCosts.Items.Clear()
        lblTotalCost.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the app
        Me.Close()
    End Sub

    Private Sub lstCosts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCosts.SelectedIndexChanged

    End Sub
End Class
