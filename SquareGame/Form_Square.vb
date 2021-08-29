Public Class Form_Square
    Private Sub Button_Reset_Click(sender As Object, e As EventArgs) Handles Button_Reset.Click

        'Scoring
        Randomize()
        PV(0) = Rnd()
        PV(1) = Rnd()
        PV(2) = Rnd()
        PV(3) = Rnd()
        PV(4) = Rnd()
        PV(5) = Rnd()
        PV(6) = Rnd()
        PV(7) = Rnd()
        PV(8) = Rnd()

        'reset all panel colours
        For Each pnl As Label In Me.GroupBox1.Controls
            pnl.BackColor = Color.FromArgb(224, 224, 224)
            pnl.Text = ""
        Next

        'reset points
        Label_Points.Text = 0

    End Sub

    Private Sub Form_Square_Load(sender As Object, e As EventArgs) Handles Me.Load
        Button_Reset.PerformClick()
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If PV.Max = 0 Then Exit Sub
        If PV(0) = PV.Max Then
            sender.backcolor = Color.FromArgb(100, 120, 121)
            Label_Points.Text = Label_Points.Text + 1
            PV(0) = 0

            'clear other labels
            For Each lbl As Label In GroupBox1.Controls
                lbl.Text = ""
            Next

            Dim lLable As Label = sender
            'numbers for distance
            If PV.Max = PV(1) Then lLable.Text = 1
            If PV.Max = PV(2) Then lLable.Text = 2
            If PV.Max = PV(3) Then lLable.Text = 1
            If PV.Max = PV(4) Then lLable.Text = 1
            If PV.Max = PV(5) Then lLable.Text = 2
            If PV.Max = PV(6) Then lLable.Text = 2
            If PV.Max = PV(7) Then lLable.Text = 2
            If PV.Max = PV(8) Then lLable.Text = 2

            'is end? 
            If PV.Max = 0 Then sender.text = ""

        Else
            Label_Points.Text = Label_Points.Text - 1
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As EventArgs) Handles Label2.Click
        If PV.Max = 0 Then Exit Sub
        If PV(1) = PV.Max Then
            sender.backcolor = Color.FromArgb(100, 120, 121)
            Label_Points.Text = Label_Points.Text + 1
            PV(1) = 0

            'clear other labels
            For Each lbl As Label In GroupBox1.Controls
                lbl.Text = ""
            Next

            Dim lLable As Label = sender
            'numbers for distance
            If PV.Max = PV(0) Then lLable.Text = 1
            If PV.Max = PV(2) Then lLable.Text = 1
            If PV.Max = PV(3) Then lLable.Text = 1
            If PV.Max = PV(4) Then lLable.Text = 1
            If PV.Max = PV(5) Then lLable.Text = 1
            If PV.Max = PV(6) Then lLable.Text = 2
            If PV.Max = PV(7) Then lLable.Text = 2
            If PV.Max = PV(8) Then lLable.Text = 2

            'is end? 
            If PV.Max = 0 Then sender.text = ""

        Else
            Label_Points.Text = Label_Points.Text - 1
        End If
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As EventArgs) Handles Label3.Click
        If PV.Max = 0 Then Exit Sub
        If PV(2) = PV.Max Then
            sender.backcolor = Color.FromArgb(100, 120, 121)
            Label_Points.Text = Label_Points.Text + 1
            PV(2) = 0

            'clear other labels
            For Each lbl As Label In GroupBox1.Controls
                lbl.Text = ""
            Next

            Dim lLable As Label = sender
            'numbers for distance
            If PV.Max = PV(0) Then lLable.Text = 2
            If PV.Max = PV(1) Then lLable.Text = 1
            If PV.Max = PV(3) Then lLable.Text = 2
            If PV.Max = PV(4) Then lLable.Text = 1
            If PV.Max = PV(5) Then lLable.Text = 1
            If PV.Max = PV(6) Then lLable.Text = 2
            If PV.Max = PV(7) Then lLable.Text = 2
            If PV.Max = PV(8) Then lLable.Text = 2

            'is end? 
            If PV.Max = 0 Then sender.text = ""

        Else
            Label_Points.Text = Label_Points.Text - 1
        End If
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As EventArgs) Handles Label4.Click
        If PV.Max = 0 Then Exit Sub
        If PV(3) = PV.Max Then
            sender.backcolor = Color.FromArgb(100, 120, 121)
            Label_Points.Text = Label_Points.Text + 1
            PV(3) = 0

            'clear other labels
            For Each lbl As Label In GroupBox1.Controls
                lbl.Text = ""
            Next

            Dim lLable As Label = sender
            'numbers for distance
            If PV.Max = PV(0) Then lLable.Text = 1
            If PV.Max = PV(1) Then lLable.Text = 1
            If PV.Max = PV(2) Then lLable.Text = 2
            If PV.Max = PV(4) Then lLable.Text = 1
            If PV.Max = PV(5) Then lLable.Text = 2
            If PV.Max = PV(6) Then lLable.Text = 1
            If PV.Max = PV(7) Then lLable.Text = 1
            If PV.Max = PV(8) Then lLable.Text = 2

            'is end? 
            If PV.Max = 0 Then sender.text = ""
        Else
            Label_Points.Text = Label_Points.Text - 1
        End If
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As EventArgs) Handles Label5.Click
        If PV.Max = 0 Then Exit Sub
        If PV(4) = PV.Max Then
            sender.backcolor = Color.FromArgb(100, 120, 121)
            Label_Points.Text = Label_Points.Text + 1
            PV(4) = 0

            'clear other labels
            For Each lbl As Label In GroupBox1.Controls
                lbl.Text = ""
            Next

            Dim lLable As Label = sender
            'numbers for distance
            If PV.Max = PV(0) Then lLable.Text = 1
            If PV.Max = PV(1) Then lLable.Text = 1
            If PV.Max = PV(2) Then lLable.Text = 1
            If PV.Max = PV(3) Then lLable.Text = 1
            If PV.Max = PV(5) Then lLable.Text = 1
            If PV.Max = PV(6) Then lLable.Text = 1
            If PV.Max = PV(7) Then lLable.Text = 1
            If PV.Max = PV(8) Then lLable.Text = 1

            'is end? 
            If PV.Max = 0 Then sender.text = ""
        Else
            Label_Points.Text = Label_Points.Text - 1
        End If
    End Sub

    Private Sub Panel6_Paint(sender As Object, e As EventArgs) Handles Label6.Click
        If PV.Max = 0 Then Exit Sub
        If PV(5) = PV.Max Then
            sender.backcolor = Color.FromArgb(100, 120, 121)
            Label_Points.Text = Label_Points.Text + 1
            PV(5) = 0

            'clear other labels
            For Each lbl As Label In GroupBox1.Controls
                lbl.Text = ""
            Next

            Dim lLable As Label = sender
            'numbers for distance
            If PV.Max = PV(0) Then lLable.Text = 2
            If PV.Max = PV(1) Then lLable.Text = 1
            If PV.Max = PV(2) Then lLable.Text = 1
            If PV.Max = PV(3) Then lLable.Text = 2
            If PV.Max = PV(4) Then lLable.Text = 1
            If PV.Max = PV(6) Then lLable.Text = 2
            If PV.Max = PV(7) Then lLable.Text = 1
            If PV.Max = PV(8) Then lLable.Text = 1

            'is end? 
            If PV.Max = 0 Then sender.text = ""
        Else
            Label_Points.Text = Label_Points.Text - 1
        End If
    End Sub

    Private Sub Panel7_Paint(sender As Object, e As EventArgs) Handles Label7.Click
        If PV.Max = 0 Then Exit Sub
        If PV(6) = PV.Max Then
            sender.backcolor = Color.FromArgb(100, 120, 121)
            Label_Points.Text = Label_Points.Text + 1
            PV(6) = 0

            'clear other labels
            For Each lbl As Label In GroupBox1.Controls
                lbl.Text = ""
            Next

            Dim lLable As Label = sender
            'numbers for distance
            If PV.Max = PV(0) Then lLable.Text = 2
            If PV.Max = PV(1) Then lLable.Text = 2
            If PV.Max = PV(2) Then lLable.Text = 2
            If PV.Max = PV(3) Then lLable.Text = 1
            If PV.Max = PV(4) Then lLable.Text = 1
            If PV.Max = PV(5) Then lLable.Text = 2
            If PV.Max = PV(7) Then lLable.Text = 1
            If PV.Max = PV(8) Then lLable.Text = 2

            'is end? 
            If PV.Max = 0 Then sender.text = ""
        Else
            Label_Points.Text = Label_Points.Text - 1
        End If
    End Sub

    Private Sub Panel8_Paint(sender As Object, e As EventArgs) Handles Label8.Click
        If PV.Max = 0 Then Exit Sub
        If PV(7) = PV.Max Then
            sender.backcolor = Color.FromArgb(100, 120, 121)
            Label_Points.Text = Label_Points.Text + 1
            PV(7) = 0

            'clear other labels
            For Each lbl As Label In GroupBox1.Controls
                lbl.Text = ""
            Next

            Dim lLable As Label = sender
            'numbers for distance
            If PV.Max = PV(0) Then lLable.Text = 2
            If PV.Max = PV(1) Then lLable.Text = 2
            If PV.Max = PV(2) Then lLable.Text = 2
            If PV.Max = PV(3) Then lLable.Text = 1
            If PV.Max = PV(4) Then lLable.Text = 1
            If PV.Max = PV(5) Then lLable.Text = 1
            If PV.Max = PV(6) Then lLable.Text = 1
            If PV.Max = PV(8) Then lLable.Text = 1

            'is end? 
            If PV.Max = 0 Then sender.text = ""
        Else
            Label_Points.Text = Label_Points.Text - 1
        End If
    End Sub

    Private Sub Panel9_Paint(sender As Object, e As EventArgs) Handles Label9.Click
        If PV.Max = 0 Then Exit Sub
        If PV(8) = PV.Max Then
            sender.backcolor = Color.FromArgb(100, 120, 121)
            Label_Points.Text = Label_Points.Text + 1
            PV(8) = 0

            'clear other labels
            For Each lbl As Label In GroupBox1.Controls
                If lbl.BackColor = Color.FromArgb(100, 120, 121) Then lbl.Text = ""
            Next

            Dim lLable As Label = sender
            'numbers for distance
            If PV.Max = PV(0) Then lLable.Text = 2
            If PV.Max = PV(1) Then lLable.Text = 2
            If PV.Max = PV(2) Then lLable.Text = 2
            If PV.Max = PV(3) Then lLable.Text = 2
            If PV.Max = PV(4) Then lLable.Text = 1
            If PV.Max = PV(5) Then lLable.Text = 1
            If PV.Max = PV(6) Then lLable.Text = 2
            If PV.Max = PV(7) Then lLable.Text = 1



            'is end? 
            If PV.Max = 0 Then sender.text = ""
        Else
            Label_Points.Text = Label_Points.Text - 1
        End If
    End Sub
End Class