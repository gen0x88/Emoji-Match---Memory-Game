Imports Memgame.UserControl1

Public Class StartForm

    Private Sub Quitbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Quitbtn.Click
        'closes the form
        Close()

    End Sub

    Private Sub Resetbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Resetbtn.Click

        'case statement explaining reseting the user scores

        Select Case MessageBox.Show("Are you sure you want to reset everything?", "Reset", MessageBoxButtons.OKCancel)

            'when the user presses the ok button

            Case Windows.Forms.DialogResult.OK

                'settings would reset back to zero
                My.Settings.BestTIme = 0
                My.Settings.BestTimeMed = 0
                My.Settings.BestTimeHard = 0

                'when the user presses cancel
            Case Windows.Forms.DialogResult.Cancel

                'nothing happens

        End Select


    End Sub


    Private Sub Startbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Startbtn.Click
        'checks if the easy radio button is checked
        If Easyrbtn.Checked Then

            'hides the form and shows the easy memory game form
            Hide()
            MainFormEasy.Show()

            'checks if the meduim radio button is checked
        ElseIf Meduimrbtn.Checked Then

            'hides the form and shows the meduim memory game form
            Hide()
            MainFormMedium.Show()

            'checks if the hard radio button is checked
        ElseIf hardrbtn.Checked Then

            'hides the form and shows the hard memory game form
            Hide()
            MainFormHard.Show()

            'if none are selected
        Else

            'shows message box that tells the user to pick a difficulty
            MessageBox.Show("Please pick a difficulty")

        End If

    End Sub

    Private Sub Settingspic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Settingspic.Click

        'shows the user control
        Setting.Show()

    End Sub
End Class