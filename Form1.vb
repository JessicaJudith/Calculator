Public Class Form1
    Private Sub Add_Btn_Click(sender As Object, e As EventArgs) Handles Add_Btn.Click
        Result.Text = Val(X_Value.Text) + Val(Y_Value.Text)
    End Sub

    Private Sub Sub_Btn_Click(sender As Object, e As EventArgs) Handles Sub_Btn.Click
        Result.Text = Val(X_Value.Text) - Val(Y_Value.Text)
    End Sub

    Private Sub Multipy_Btn_Click(sender As Object, e As EventArgs) Handles Multipy_Btn.Click
        Result.Text = Val(X_Value.Text) * Val(Y_Value.Text)
    End Sub

    Private Sub Div_Btn_Click(sender As Object, e As EventArgs) Handles Div_Btn.Click
        Result.Text = Val(X_Value.Text) / Val(Y_Value.Text)
    End Sub

    Private Sub Mod_Btn_Click(sender As Object, e As EventArgs) Handles Mod_Btn.Click
        Result.Text = Val(X_Value.Text) Mod Val(Y_Value.Text)

    End Sub

    Private Sub Square_Btn_Click(sender As Object, e As EventArgs) Handles Square_Btn.Click
        Result.Text = Val(X_Value.Text) * Val(X_Value.Text)
    End Sub

    Private Sub Cube_Btn_Click(sender As Object, e As EventArgs) Handles Cube_Btn.Click
        Result.Text = Val(X_Value.Text) * Val(X_Value.Text) * Val(X_Value.Text)
    End Sub

    Private Sub Fact_Btn_Click(sender As Object, e As EventArgs) Handles Fact_Btn.Click
        Dim Fact_counter
        Dim i As Integer
        Dim n
        n = Val(X_Value.Text)
        Fact_counter = 1
        For i = n To 2 Step -1
            Fact_counter *= i
        Next
        Result.Text = Fact_counter
    End Sub

    Private Sub Inverse_Btn_Click(sender As Object, e As EventArgs) Handles Inverse_Btn.Click
        Result.Text = 1 / Val(X_Value.Text)
    End Sub

    Private Sub Exponential_Btn_Click(sender As Object, e As EventArgs) Handles Exponential_Btn.Click
        Result.Text = Val(X_Value.Text) ^ Val(Y_Value.Text)
    End Sub

    Private Sub SquarRoot_Btn_Click(sender As Object, e As EventArgs) Handles SquarRoot_Btn.Click
        Dim sqrt_n
        Dim ans_n
        sqrt_n = Val(X_Value.Text)
        ans_n = Math.Sqrt(sqrt_n)
        Result.Text = ans_n
    End Sub

    Private Sub Log_Btn_Click(sender As Object, e As EventArgs) Handles Log_Btn.Click
        Result.Text = Math.Log(Val(X_Value.Text))
    End Sub
End Class
