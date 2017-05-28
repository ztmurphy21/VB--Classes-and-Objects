' Name:         Sunnyside Project
' Purpose:      Displays the number of square feet of material and the cost
' Programmer:   Zach Murphy 5-24-2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' displays square feet and deck cost

        ' instantiate a Rectangle object
        Dim deck As New Rectangle

        ' declare variables
        Dim dblPriceSqFt As Double
        Dim intSqFt As Integer
        Dim dblCost As Double

        ' assign values to the object's Public properties
        Integer.TryParse(lstLength.SelectedItem.ToString, deck.Length)
        Integer.TryParse(lstWidth.SelectedItem.ToString, deck.Width)
        Double.TryParse(lstPrice.SelectedItem.ToString, dblPriceSqFt)
        ' calculate the square feet
        intSqFt = deck.GetArea

        ' calculate the deck cost
        dblCost = intSqFt * dblPriceSqFt

        ' display output
        lblSquareFeet.Text = intSqFt.ToString
        lblCost.Text = dblCost.ToString("c2")
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) Handles lstLength.SelectedValueChanged, lstWidth.SelectedValueChanged, lstPrice.SelectedValueChanged
        lblSquareFeet.Text = String.Empty
        lblCost.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the list boxes with data and then selects a default item

        For intNums As Integer = 12 To 36 Step 2
            lstLength.Items.Add(intNums.ToString)
            lstWidth.Items.Add(intNums.ToString)
        Next intNums

        For dblPrices As Double = 5 To 25 Step 0.5
            lstPrice.Items.Add(dblPrices.ToString("N2"))
        Next dblPrices

        lstLength.SelectedIndex = 0
        lstWidth.SelectedIndex = 0
        lstPrice.SelectedItem = "10.00"
    End Sub
End Class
