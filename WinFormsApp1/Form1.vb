﻿Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Public num1, num2 As Double
    Public operation As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles BTN8.Click
        TXTBOX_DS.Text = TXTBOX_DS.Text + BTN8.Text
    End Sub

    Private Sub BTN1_Click(sender As Object, e As EventArgs) Handles BTN1.Click
        TXTBOX_DS.Text = TXTBOX_DS.Text + BTN1.Text
    End Sub

    Private Sub BTN2_Click(sender As Object, e As EventArgs) Handles BTN2.Click
        TXTBOX_DS.Text = TXTBOX_DS.Text + BTN2.Text
    End Sub

    Private Sub BTN3_Click(sender As Object, e As EventArgs) Handles BTN3.Click
        TXTBOX_DS.Text = TXTBOX_DS.Text + BTN3.Text
    End Sub

    Private Sub BTN4_Click(sender As Object, e As EventArgs) Handles BTN4.Click
        TXTBOX_DS.Text = TXTBOX_DS.Text + BTN4.Text
    End Sub

    Private Sub BTN5_Click(sender As Object, e As EventArgs) Handles BTN5.Click
        TXTBOX_DS.Text = TXTBOX_DS.Text + BTN5.Text
    End Sub

    Private Sub BTN6_Click(sender As Object, e As EventArgs) Handles BTN6.Click
        TXTBOX_DS.Text = TXTBOX_DS.Text + BTN6.Text
    End Sub

    Private Sub BTN7_Click(sender As Object, e As EventArgs) Handles BTN7.Click
        TXTBOX_DS.Text = TXTBOX_DS.Text + BTN7.Text
    End Sub

    Private Sub BTN9_Click(sender As Object, e As EventArgs) Handles BTN9.Click
        TXTBOX_DS.Text = TXTBOX_DS.Text + BTN9.Text
    End Sub

    Private Sub BTN0_Click(sender As Object, e As EventArgs) Handles BTN0.Click
        TXTBOX_DS.Text = TXTBOX_DS.Text + BTN0.Text
    End Sub

    Private Sub BTN_DECIMAL_Click(sender As Object, e As EventArgs) Handles BTN_DECIMAL.Click
        TXTBOX_DS.Text = TXTBOX_DS.Text + BTN_DECIMAL.Text
    End Sub

    Private Sub BTN_EQUAL_Click(sender As Object, e As EventArgs) Handles BTN_EQUAL.Click

    End Sub

    Private Sub BTN_DEVIDE_Click(sender As Object, e As EventArgs) Handles BTN_DEVIDE.Click

    End Sub

    Private Sub BTN_MULTIPLY_Click(sender As Object, e As EventArgs) Handles BTN_MULTIPLY.Click

    End Sub

    Private Sub BTN_SUB_Click(sender As Object, e As EventArgs) Handles BTN_SUB.Click

    End Sub

    Private Sub BTN_ADD_Click(sender As Object, e As EventArgs) Handles BTN_ADD.Click
        operation = "+"
        num1 = TXTBOX_DS.Text
    End Sub
End Class
