Public Class form_menu
    'Student Name: Jason Antao
    'Date: December 4, 2014
    'Teacher: Ms. Ste. Croix
    'TA: Mrs. Hayes (#53)
    '
    'Purpose: To have a user play a game of Jeopardy against the computer with a timer and sound effects.
    '
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.JeopardyTheme, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub cmd_start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_start.Click
        form_jeopardy.Show()
        Me.Hide()
        My.Computer.Audio.Stop()
    End Sub
    'Instructions for form1
    Private Sub cmd_instructions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_instructions.Click
        MsgBox("Welcome to Jason's Jeopardy Game. Here's how the game works. We'll start with the Jeopardy Round. Thirty clues under 6 different categories will be revealed. Each clue will have a value, ranging from $200 to $1,000. Select a clue, and the clue, along with 3 possible responses will appear. Select the one that you think correctly answers the clue. If you are correct, you win the dollar amount valued of that clue. Respond incorrectly, and you lose that money. You can choose to pass any clue if you decide not to answer. You'll only have 15 seconds to answer each clue, or you'll lose $500. However, if you run out of time, you can still choose to play that clue again. In the Jeopardy! Round, there is one Daily Double clue. For the Daily Double clue, you can wager in a certain amount before looking at the clue. After finishing the Jeopardy Round, you will play the Double Jeopardy Round. Rules are the same, and the values are doubled. Also, there are two Daily Doubles in that round. Afterwards you'll advance to Final Jeopardy! In Final Jeopardy!, you'll wager in a certain amount having looked at the category, but not the clue. You must then answer that clue, and see if you won or lost your wager. In a nutshell, that's it! Enjoy playing Jason's Jeopardy! Game!")
    End Sub

    Private Sub cmd_quitmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_quitmenu.Click
        Me.Close()
        form_jeopardy.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Special thanks to Scott Carpen Youtube.channel and Sony Images! Much of the developmental software ideas came from you. The questions and user interface code were modified for users by Jason Antao. Thank You!")
    End Sub
End Class

