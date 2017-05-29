' Name:         Grade Project
' Purpose:      Displays a grade based on two test scores
' Programmer:   Zach Murphy on 5-29-2017

Option Explicit On
Option Strict On
Option Infer On

Public Class frmMain

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' calculates and displays a letter grade

        Dim studentGrade As New CourseGrade
        ' assign test scores to object's properties
        Integer.TryParse(lstTest1.SelectedItem.ToString, studentGrade.Score1)
        Integer.TryParse(lstTest2.SelectedItem.ToString, studentGrade.Score2)

        ' calculate the grade using the 
        ' object's DetermineGrade method
        Call studentGrade.DetermineGrade()

        ' display the grade stored in the 
        ' object's ReadOnly property
        lblGrade.Text = studentGrade.Grade
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the list boxes with values

        For intScore As Integer = 0 To 100
            lstTest1.Items.Add(intScore.ToString)
            lstTest2.Items.Add(intScore.ToString)
        Next intScore

        lstTest1.SelectedItem = "75"
        lstTest2.SelectedItem = "75"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles lstTest1.SelectedValueChanged, lstTest2.SelectedValueChanged
        lblGrade.Text = String.Empty
    End Sub
End Class
