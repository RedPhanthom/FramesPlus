Public Class FramesPlus

    'Constants To Declare
    Const ThreeByFive_Decimal As Decimal = 3.95D
    Const FourBySix_Decimal As Decimal = 5.95D
    Const FiveBySix_Decimal As Decimal = 6.15D
    Const FiveBySeven_Decimal As Decimal = 6.55D
    Const EightByTen_Decimal As Decimal = 8.95D
    Const PostCost_Decimal As Decimal = 1.4D
    Const FivePercentCoupon_Decimal As Decimal = 0.05D
    Const TenPercentCoupon_Decimal As Decimal = 0.1D

    'Variables To Declare
    Private boolValidation As Boolean = True

    Private Sub FramesPlus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Display Current System date on Date Label
        Dim currentDate As Date = Format(Now(), "short date")
        lblCurrentDate.Text = currentDate

        'Determine if a CheckBox Option has been picked to Allow Quanity Input
        If cb3x5.Checked Then
            tb3x5.Enabled = True
        End If


    End Sub

    Private Sub tsmiExit_Click(sender As Object, e As EventArgs) Handles tsmiExit.Click
        'Kill Program & Confirmation Of Programing Closing
        Dim exitMsgString As String = "Would you like to Exit?"
        If MessageBox.Show(exitMsgString, "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            boolValidation = False
            Close()
        End If
    End Sub

    Private Sub tsmiSummary_Click(sender As Object, e As EventArgs) Handles tsmiSummary.Click
        'Calculate Total Order Details & Display
    End Sub

    Private Sub tsmiClear_Click(sender As Object, e As EventArgs) Handles tsmiClear.Click
        'Clear Controls that need to be cleared
    End Sub

    Private Sub tsmiNew_Click(sender As Object, e As EventArgs) Handles tsmiNew.Click

    End Sub
End Class
