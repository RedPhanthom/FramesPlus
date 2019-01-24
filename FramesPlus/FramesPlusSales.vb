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
    'Check If the Appropriate checkbox is checked, if so enable the textbox to allow Quanity Input.
    Private Sub cb3x5_CheckedChanged(sender As Object, e As EventArgs) Handles cb3x5.CheckedChanged
        If cb3x5.Checked = True Then
            tb3x5.Enabled = True
        Else
            tb3x5.Enabled = False
        End If
    End Sub

    Private Sub cb4x6_CheckedChanged(sender As Object, e As EventArgs) Handles cb4x6.CheckedChanged
        If cb4x6.Checked = True Then
            tb4x6.Enabled = True
        Else
            tb4x6.Enabled = False
        End If
    End Sub

    Private Sub cb5x6_CheckedChanged(sender As Object, e As EventArgs) Handles cb5x6.CheckedChanged
        If cb5x6.Checked = True Then
            tb5x6.Enabled = True
        Else
            tb5x6.Enabled = False
        End If
    End Sub

    Private Sub cb5x7_CheckedChanged(sender As Object, e As EventArgs) Handles cb5x7.CheckedChanged
        If cb5x7.Checked = True Then
            tb5x7.Enabled = True
        Else
            tb5x7.Enabled = False
        End If
    End Sub

    Private Sub cb8x10_CheckedChanged(sender As Object, e As EventArgs) Handles cb8x10.CheckedChanged
        If cb8x10.Checked = True Then
            tb8x10.Enabled = True
        Else
            tb8x10.Enabled = False
        End If
    End Sub
End Class
