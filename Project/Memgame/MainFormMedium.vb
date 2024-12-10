Imports Memgame.UserControl1
Public Class MainFormMedium


    'introducing some varaibles 
    Private intPairSelection2 As Integer    'The integer value of the pair
    Private arrPairPicked2(2) As Integer    'The two cards that were picked'
    Private arrMoveBehind2(36) As Integer   'Moves cover card to the back'
    Private intGuesses2 As Integer          'How many Guesses you took'
    Private intMatch2 As Integer            'Score'

    Private imgSelection(17) As PictureBox 'Selected images'
    Private imgCardBack(35) As PictureBox  'background of cards'

    Dim timercount As Integer = 0 'Makes the ingame timer 0 
    Dim timercount2 As Integer = 0 'Makes the time that is displayed  0 

    Private Sub MainFormMedium_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Initialise images for the emoji pictures
        imgSelection(0) = imgSelection1
        imgSelection(1) = imgSelection2
        imgSelection(2) = imgSelection3
        imgSelection(3) = imgSelection4
        imgSelection(4) = imgSelection5
        imgSelection(5) = imgSelection6
        imgSelection(6) = imgSelection7
        imgSelection(7) = imgSelection8
        imgSelection(8) = imgSelection9
        imgSelection(9) = imgSelection10
        imgSelection(10) = imgSelection11
        imgSelection(11) = imgSelection12
        imgSelection(12) = imgSelection13
        imgSelection(13) = imgSelection14
        imgSelection(14) = imgSelection15
        imgSelection(15) = imgSelection16
        imgSelection(16) = imgSelection17
        imgSelection(17) = imgSelection18

        'Initialise images for the 36 cards
        imgCardBack(0) = Picbox1
        imgCardBack(1) = Picbox2
        imgCardBack(2) = Picbox3
        imgCardBack(3) = Picbox4
        imgCardBack(4) = Picbox5
        imgCardBack(5) = Picbox6
        imgCardBack(6) = Picbox7
        imgCardBack(7) = Picbox8
        imgCardBack(8) = Picbox9
        imgCardBack(9) = Picbox10
        imgCardBack(10) = Picbox11
        imgCardBack(11) = Picbox12
        imgCardBack(12) = Picbox13
        imgCardBack(13) = Picbox14
        imgCardBack(14) = Picbox15
        imgCardBack(15) = Picbox16
        imgCardBack(16) = Picbox17
        imgCardBack(17) = Picbox18
        imgCardBack(18) = Picbox19
        imgCardBack(19) = Picbox20
        imgCardBack(20) = Picbox21
        imgCardBack(21) = Picbox22
        imgCardBack(22) = Picbox23
        imgCardBack(23) = Picbox24
        imgCardBack(24) = Picbox25
        imgCardBack(25) = Picbox26
        imgCardBack(26) = Picbox27
        imgCardBack(27) = Picbox28
        imgCardBack(28) = Picbox29
        imgCardBack(29) = Picbox30
        imgCardBack(30) = Picbox31
        imgCardBack(31) = Picbox32
        imgCardBack(32) = Picbox33
        imgCardBack(33) = Picbox34
        imgCardBack(34) = Picbox35
        imgCardBack(35) = Picbox36

        'displays the text for the highscore if there is a highscore
        hiscorelb.Text = My.Settings.BestTimeMed

        'Enables the Start sub and starts the timer
        Start()
        Timer2.Enabled = True

        'starts the music in a loop
        My.Computer.Audio.Play(My.Resources.ReMus, AudioPlayMode.BackgroundLoop)
    End Sub




    Private Sub Start()   'Starts the game


        Randomize()   'Generates a random number'
        ShuffleCards(36, arrMoveBehind2)   'Shuffles the cards

        'Creates a new variable called i
        Dim i As Integer

        For i = 1 To 36
            'If statement when cards exeed 10, then start again
            If arrMoveBehind2(i) > 18 Then

                arrMoveBehind2(i) = arrMoveBehind2(i) - 18

            End If

            'Moves the cards backwards
            arrMoveBehind2(i) = arrMoveBehind2(i) - 1
            arrMoveBehind2(i - 1) = arrMoveBehind2(i)

        Next i

        'Resets the board
        intMatch2 = 0
        intGuesses2 = 0
        intPairSelection2 = 1
        btnStart.Enabled = False

        'sets up the score and the amount of guesses displayed
        Scorelb.Text = intMatch2.ToString()
        Guesslb.Text = intGuesses2.ToString()

    End Sub

    Private Sub ShuffleCards(ByVal intItems As Integer, ByVal intNumbers() As Integer)

        'Creates more vraibles to use

        Dim intCounter As Integer '
        Dim intPicked As Integer
        Dim intRemaining As Integer 'Remaining integers
        Dim intTemp As Integer

        'Populate items'
        For intCounter = 1 To intItems

            intNumbers(intCounter) = intCounter

        Next intCounter

        'randomly pick item and swap out images'
        For intRemaining = intItems To 2 Step -1

            intPicked = Int(Rnd() * intRemaining) + 1

            intTemp = intNumbers(intRemaining)

            intNumbers(intRemaining) = intNumbers(intPicked)

            intNumbers(intPicked) = intTemp

        Next intRemaining

    End Sub

    'When any of the 36 cards are clicked
    Private Sub Picbox1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Picbox1.Click,
         Picbox2.Click, Picbox3.Click, Picbox4.Click, Picbox5.Click, Picbox6.Click,
         Picbox7.Click, Picbox8.Click, Picbox9.Click, Picbox10.Click, Picbox11.Click,
         Picbox12.Click, Picbox13.Click, Picbox14.Click, Picbox15.Click, Picbox16.Click,
         Picbox17.Click, Picbox18.Click, Picbox19.Click, Picbox20.Click, Picbox21.Click,
         Picbox22.Click, Picbox23.Click, Picbox24.Click, Picbox25.Click, Picbox26.Click,
         Picbox27.Click, Picbox28.Click, Picbox29.Click, Picbox30.Click, Picbox31.Click,
         Picbox32.Click, Picbox33.Click, Picbox34.Click, Picbox35.Click, Picbox36.Click

        'Display the image hidden behind
        Play(Int32.Parse(sender.tag))


    End Sub

    Private Sub Play(ByVal intIndex As Integer)

        'Same box, or already selected box'
        If (intPairSelection2 = 2 And intIndex = arrPairPicked2(1)) _
           Or arrMoveBehind2(intIndex) = -1 Or btnStart.Enabled Then

            Exit Sub

        End If

        'Display selected Image'
        imgCardBack(intIndex).Image = imgSelection(arrMoveBehind2(intIndex)).Image

        imgCardBack(intIndex).Refresh()

        If intPairSelection2 = 1 Then

            arrPairPicked2(1) = intIndex

            intPairSelection2 = 2

            Exit Sub

        End If

        arrPairPicked2(2) = intIndex

        'Match'
        If arrMoveBehind2(arrPairPicked2(1)) = arrMoveBehind2(arrPairPicked2(2)) Then

            arrMoveBehind2(arrPairPicked2(1)) = -1
            arrMoveBehind2(arrPairPicked2(2)) = -1

            intMatch2 = intMatch2 + 1
            Scorelb.Text = intMatch2

        Else

            'No Match, restore cardbacks'
            intGuesses2 = intGuesses2 + 1

            Guesslb.Text = Format(intGuesses2, "0")

            Timer1.Enabled = True


        End If

        intPairSelection2 = 1

        'if matches = 18 (finshed matching everything)
        If intMatch2 = 18 Then

            'hide pause button
            Pausepic.Hide()

            'if no best time
            If My.Settings.BestTimeMed() = 0 Then

                'stop timer
                Timer2.Enabled = False

                'show message box with text and hi score
                MessageBox.Show("Congrats, you matched them all! Your time was " & Timerlb.Text.ToString & "  " &
                                "You have no best time yet", "Congrats", MessageBoxButtons.OK)

                'store the highscore as the best time  
                My.Settings.BestTimeMed = Timerlb.Text

            Else

                'stop timer
                Timer2.Enabled = False

                If My.Settings.BestTimeMed > Timerlb.Text Then

                    'then store this value
                    My.Settings.BestTimeMed = Timerlb.Text

                    'display messagebox with text and hi score
                    MessageBox.Show("Congrats, you matched them all! Your time was" & " " & Timerlb.Text.ToString & "  " &
                               "You beat your high score!", "Congrats", MessageBoxButtons.OK)

                    'else when best time less than timer
                ElseIf My.Settings.BestTimeMed < Timerlb.Text Then

                    'display messagebox with text and variables
                    MessageBox.Show("Congrats, you matched them all! Your time was" & " " & Timerlb.Text.ToString & "  " &
                               "Aww, you did't beat your high score. Better luck next time!" & "  And btw, your high score was " & My.Settings.BestTimeMed, "Congrats", MessageBoxButtons.OK)

                    'when best time somehow equals to the time taken
                ElseIf My.Settings.BestTimeMed = Timerlb.Text Then

                    'display messagebox with text and hi score
                    MessageBox.Show("Congrats, you matched them all!" & "What are the chances of this?" &
                                    " And btw, your score was " & My.Settings.BestTimeMed, "Congrats", MessageBoxButtons.OK)

                End If

            End If

        End If

        'displays the text for the highscore if there is a highscore
        hiscorelb.Text = My.Settings.BestTimeMed

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        'Check if cards are the same
        ProgressBar1.Value += 20

        For x As Integer = 0 To imgCardBack.Length - 1

            imgCardBack(x).Enabled = False

        Next

        'Resets the front of the card so the image is hidden using a hidden progress bar
        If ProgressBar1.Value = ProgressBar1.Maximum Then

            ProgressBar1.Value = ProgressBar1.Minimum

            'stops timer
            Timer1.Enabled = False


            imgCardBack(arrPairPicked2(1)).Image = picback.Image
            imgCardBack(arrPairPicked2(2)).Image = picback.Image

            'return back of card if wrong
            For x As Integer = 0 To imgCardBack.Length - 1

                imgCardBack(x).Enabled = True

            Next

        End If

        'adds time to the timer every second when enabled
        timercount += 1


    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        'makes the timer display a value when enabled
        Timerlb.Text = timercount2.ToString

        'when timer is active, adds 1 second every second
        timercount2 += 1

        'if there is no best time
        If My.Settings.BestTimeMed = 0 Then


            'else
        Else

            'if best time is less than timer
            If My.Settings.BestTimeMed < Timerlb.Text Then

                'make the label text colour red
                Timerlb.ForeColor = Color.Red

            End If

        End If

    End Sub

    Private Sub Homepic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Homepic.Click

        'if finished game, timer does not continue
        If intMatch2 = 18 Then

            Select Case MessageBox.Show("Are you sure you want to go home? All progress would be lost", "Restart", MessageBoxButtons.OKCancel)

                'when press ok button
                Case Windows.Forms.DialogResult.OK

                    'close the form
                    Close()

                    'stop audio
                    My.Computer.Audio.Stop()

                    'show the starting form
                    StartForm.Show()

                Case Windows.Forms.DialogResult.Cancel




            End Select

            'when pause button pressed, does not resume timer as well
        ElseIf paused = True Then

            Select Case MessageBox.Show("Are you sure you want to go home?", "Home", MessageBoxButtons.OKCancel)

                'when press ok button
                Case Windows.Forms.DialogResult.OK

                    'close the form
                    Close()

                    'stop audio
                    My.Computer.Audio.Stop()

                    'show the starting form
                    StartForm.Show()

                    'when press cancel
                Case Windows.Forms.DialogResult.Cancel



            End Select

            'else when game is active
        Else

            'pause timer
            Timer2.Enabled = False

            'case statement 
            Select Case MessageBox.Show("Are you sure you want to go home? All progress would be lost", "Home", MessageBoxButtons.OKCancel)

                'when press ok button
                Case Windows.Forms.DialogResult.OK

                    'close the form
                    Close()

                    'stop audio
                    My.Computer.Audio.Stop()

                    'show the starting form
                    StartForm.Show()

                    'when press cancel
                Case Windows.Forms.DialogResult.Cancel

                    'timer starts again
                    Timer2.Enabled = True

            End Select

        End If

    End Sub

    Private paused As Boolean = False

    Private Sub Pausepic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pausepic.Click

        If paused = True Then

            paused = False
            Pausepic.BackgroundImage = My.Resources.pause

            'starts the timer again
            Timer2.Enabled = True


            'hide the textbox, picturebox and button
            pausedlb.Visible = False
            Pausedpicbox.Visible = False

        ElseIf paused = False Then

            paused = True
            Pausepic.BackgroundImage = My.Resources.play_button

            'timer stops
            Timer2.Enabled = False

            'show the textbox, picturebox and button
            pausedlb.Visible = True
            Pausedpicbox.Visible = True

        End If

    End Sub

    Private Sub Settingspic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Settingspic.Click

        'shows the user control
        Settings2.Show()

    End Sub

    Private Sub Quitpicbox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Quitpicbox.Click

        'stops the timer
        Timer2.Enabled = False

        'case statement if want to quit
        Select Case MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.OKCancel)

            Case Windows.Forms.DialogResult.OK

                'Exits the application when pressed
                Application.Exit()
                StartForm.Close()

            Case Windows.Forms.DialogResult.Cancel
                'starts timer again when not pressed
                If paused = True Then

                ElseIf intMatch2 = 18 Then

                Else

                    Timer2.Enabled = True

                End If

        End Select

        'sets a value for best time or else would result in error
        My.Settings.BestTimeMed = My.Settings.BestTimeMed

    End Sub

    'variables for moving the form around
    Private isMouseDown As Boolean = False
    Private mouseOffset As Point

    'Left mouse button pressed
    Private Sub lbmove_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lbmove.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Left Then

            'Get the new position
            mouseOffset = New Point(-e.X, -e.Y)

            'Set that left button is pressed
            isMouseDown = True

        End If

    End Sub

    'MouseMove used to check if mouse cursor is moving
    Private Sub lbmove_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lbmove.MouseMove

        If isMouseDown Then

            Dim mousePos As Point = Control.MousePosition

            ' Get the new form position
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos

        End If

    End Sub

    ' Left mouse button released, form should stop moving
    Private Sub lbmove_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lbmove.MouseUp

        If e.Button = Windows.Forms.MouseButtons.Left Then

            isMouseDown = False

        End If

    End Sub

End Class
