'Page 2 - Form2
Public Class form_jeopardy
    'Student Name: Jason Antao
    'Date: December 4, 2014
    'Teacher: Ms. Ste. Croix
    'TA: Mrs. Hayes (#53)
    '
    'Purpose: To have a user play a game of Jeopardy against the computer with a timer and sound effects.
    '
    Dim MyDailyWager As Integer
    Dim MyDailyDoubleWager As Integer
    Dim MyDailyDoubleSecondWager As Integer
    Dim myfinalwager As Integer
    Dim ResponseTimer As Integer = 15
    Dim FinalTimer As Integer = 30
    Private Sub form_jeopardyround_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim MyName
        MyName = InputBox("Enter Your Name")
        lbl_name.Text = MyName
        img_finaljeopardy.Hide()
        cmd_r1c1c1.Hide()
        cmd_r1c1c2.Hide()
        cmd_r1c1c3.Hide()
        cmd_r1c1c4.Hide()
        cmd_r1c1c5.Hide()
        cmd_r1c2c1.Hide()
        cmd_r1c2c2.Hide()
        cmd_r1c2c3.Hide()
        cmd_r1c2c4.Hide()
        cmd_r1c2c5.Hide()
        cmd_r1c3c1.Hide()
        cmd_r1c3c2.Hide()
        cmd_r1c3c3.Hide()
        cmd_r1c3c4.Hide()
        cmd_r1c3c5.Hide()
        cmd_r1c4c1.Hide()
        cmd_r1c4c2.Hide()
        cmd_r1c4c3.Hide()
        cmd_r1c4c4.Hide()
        cmd_r1c4c5.Hide()
        cmd_r1c5c1.Hide()
        cmd_r1c5c2.Hide()
        cmd_r1c5c3.Hide()
        cmd_r1c5c4.Hide()
        cmd_r1c5c5.Hide()
        cmd_r1c6c1.Hide()
        cmd_r1c6c2.Hide()
        cmd_r1c6c3.Hide()
        cmd_r1c6c4.Hide()
        cmd_r1c6c5.Hide()
        lbl_r1c1.Hide()
        lbl_r1c2.Hide()
        lbl_r1c3.Hide()
        lbl_r1c4.Hide()
        lbl_r1c5.Hide()
        lbl_r1c6.Hide()
        txt_answer.Hide()
        cmd_response1.Hide()
        cmd_response2.Hide()
        cmd_response3.Hide()
        cmd_pass.Hide()
        cmd_begindouble.Hide()
        cmd_beginfinal.Hide()
        cmd_finaljeopardyclue.Hide()
    End Sub

    Private Sub tmr_r1appear_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_r1appear1.Tick
        cmd_r1c2c1.Show()
        cmd_r1c5c2.Show()
        cmd_r1c1c3.Show()
        cmd_r1c3c4.Show()
        cmd_r1c6c5.Show()
        tmr_r1appear2.Enabled = True
    End Sub

    Private Sub tmr_r1appear2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_r1appear2.Tick
        cmd_r1c4c1.Show()
        cmd_r1c6c2.Show()
        cmd_r1c4c3.Show()
        cmd_r1c2c4.Show()
        cmd_r1c1c5.Show()
        tmr_r1appear3.Enabled = True
    End Sub

    Private Sub tmr_r1appear3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_r1appear3.Tick
        cmd_r1c1c1.Show()
        cmd_r1c3c2.Show()
        cmd_r1c2c3.Show()
        cmd_r1c5c4.Show()
        cmd_r1c4c5.Show()
        tmr_r1appear4.Enabled = True
    End Sub

    Private Sub tmr_r1appear4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_r1appear4.Tick
        cmd_r1c6c1.Show()
        cmd_r1c2c2.Show()
        cmd_r1c5c3.Show()
        cmd_r1c1c4.Show()
        cmd_r1c3c5.Show()
        tmr_r1appear5.Enabled = True
    End Sub

    Private Sub tmr_r1appear5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_r1appear5.Tick
        cmd_r1c3c1.Show()
        cmd_r1c4c2.Show()
        cmd_r1c3c3.Show()
        cmd_r1c6c4.Show()
        cmd_r1c5c5.Show()
        tmr_r1appear6.Enabled = True
    End Sub

    Private Sub tmr_r1appear6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_r1appear6.Tick
        cmd_r1c5c1.Show()
        cmd_r1c1c2.Show()
        cmd_r1c6c3.Show()
        cmd_r1c4c4.Show()
        cmd_r1c2c5.Show()
        cmd_begin.Hide()
        cmd_begindouble.Hide()
        tmr_r1cappear.Enabled = True
    End Sub

    Private Sub cmd_begin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_begin.Click
        My.Computer.Audio.Play(My.Resources.Jeopardyboardfill, AudioPlayMode.Background)
        tmr_r1appear1.Enabled = True
    End Sub

    Private Sub tmr_r1cappear_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_r1cappear.Tick
        lbl_r1c1.Show()
        lbl_r1c2.Show()
        lbl_r1c3.Show()
        lbl_r1c4.Show()
        lbl_r1c5.Show()
        lbl_r1c6.Show()
        tmr_r1appear1.Enabled = False
        tmr_r1appear2.Enabled = False
        tmr_r1appear3.Enabled = False
        tmr_r1appear4.Enabled = False
        tmr_r1appear5.Enabled = False
        tmr_r1appear6.Enabled = False
        tmr_r1cappear.Enabled = False
    End Sub
    Private Sub cmd_pass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_pass.Click
        If txt_answer.Text = "This Apple device was first introduced in 2007 and the first to run iOS." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("The answer is the iPhone!")
            cmd_r1c1c1.Hide()
        End If
        If txt_answer.Text = "This Internet browser is the most used worldwide as of March 2012, with Google Chrome and Firefox in a close 2nd and 3rd." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("The answer is the widely used Internet Explorer.")
            cmd_r1c1c2.Hide()
        End If
        If txt_answer.Text = "This social network recently bought the popular Instagram photography application for 1 billion dollars." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("The answer is Facebook.")
            cmd_r1c1c3.Hide()
        End If
        If txt_answer.Text = "This IBM computer goes by this name as he competed on Jeopardy's competition in February 2011." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("His name is Watson.")
            cmd_r1c1c4.Hide()
        End If
        If txt_answer.Text = "This website jokingly displays the phrase 'Whoops! You broke the Internet!' when a user comes across HTTP 404 error." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("That was a tricky one. It's CNET.")
            cmd_r1c1c5.Hide()
        End If
        If txt_answer.Text = "The Continental and the Town Car are two types of this 'presidential' car brand." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("The answer is Lincoln.")
            cmd_r1c2c1.Hide()
        End If
        If txt_answer.Text = "Use this around your house for a 'presidential' vaccuum cleaning." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("The answer is Hoover, the hoover.")
            cmd_r1c2c2.Hide()
        End If
        If txt_answer.Text = "This 'presidential' word means to stab." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("The answer is Pierce.")
            cmd_r1c2c3.Hide()
        End If
        If txt_answer.Text = "This is the 'presidential' name for a twenty-dollar bill." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("The answer is Jackson.")
            cmd_r1c2c4.Hide()
        End If
        If txt_answer.Text = "This 'presidential' line dance was popular in the late 50s and 60s." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("That dance was the Madison.")
            cmd_r1c2c5.Hide()
        End If
        If txt_answer.Text = "A single-handled jug with a spout for pouring." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("The pitch is the answer.")
            cmd_r1c3c1.Hide()
        End If
        If txt_answer.Text = "A mixture of flour and water to make pancakes." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Actually, it's batter.")
            cmd_r1c3c2.Hide()
        End If
        If txt_answer.Text = "An intentional stoppage by workers." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("A strike is the answer.")
            cmd_r1c3c3.Hide()
        End If
        If txt_answer.Text = "This device lets a trombonist change pitch." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("The answer is a slide.")
            cmd_r1c3c4.Hide()
        End If
        If txt_answer.Text = "An unraveling in your nylon stocking." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("That was a tough one, it's called a run.")
            cmd_r1c3c5.Hide()
        End If
        If txt_answer.Text = "'I would like to buy a vowel' is a common term heard on this game show." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Wheel of Fortune, a good show indeed!")
            cmd_r1c4c1.Hide()
        End If
        If txt_answer.Text = "To lock in an answer on 'Who Wants to Be a Millionaire,' the contestant would say this." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("That's my final answer... is THE final answer!")
            cmd_r1c4c2.Hide()
        End If
        If txt_answer.Text = "A remake of this popular game show, called 'Whammy!' began its short term run in 2002." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("It's Press Your Luck. The full name is 'Whammy! The All New Press Your Luck'")
            cmd_r1c4c3.Hide()
        End If
        If txt_answer.Text = "This man was the first to host Jeopardy! from 1964 to 1975, and again from 1978 to 1979." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("That was tough, it's Art Fleming.")
            cmd_r1c4c4.Hide()
        End If
        If txt_answer.Text = "This many pricing games are played during the hour long Price is Right." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("It's 6... 3 in the first half hour, the Showcase Showdown, 3 more, the 2nd Showcase Showdown, and the Showcase to end the show.")
            cmd_r1c4c5.Hide()
        End If
        If txt_answer.Text = "Pennsylvania." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Harrisburg is the right answer.")
            cmd_r1c5c1.Hide()
        End If
        If txt_answer.Text = "Massachusetts." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Boston is the right answer.")
            cmd_r1c5c2.Hide()
        End If
        If txt_answer.Text = "The name of this Alaskan capital brought about the phrase, 'Do you know?'" Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Do you know.... Juneau?.")
            cmd_r1c5c3.Hide()
        End If
        If txt_answer.Text = "The World of Coca-Cola resides in this state capital." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("You should go visit, it's great... in Atlanta!")
            cmd_r1c5c4.Hide()
        End If
        If txt_answer.Text = "This state capital is the home of NHRA Drag Racing's most prestigious event, the U.S. Nationals and NASCAR's Brickyard 400, among others." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Indianapolis is the right answer.")
            cmd_r1c5c5.Hide()
        End If
        If txt_answer.Text = "A pan, a filter, and a couple of quarts is all you need to do this common maintainance task." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("It's simply an oil change.")
            cmd_r1c6c1.Hide()
        End If
        If txt_answer.Text = "Harvey Firestone started a company selling a brand of these used on every automobile today." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Not too obvious? Well, it's tires.")
            cmd_r1c6c2.Hide()
        End If
        If txt_answer.Text = "Hamsters have recently made their appearance in several commercials for this car company." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Oh they're great, the Kia commercials, that is!")
            cmd_r1c6c3.Hide()
        End If
        If txt_answer.Text = "Which brand of oil using the tagline 'It's not just oil, it's liquid engineering'." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("I know, that was tough. It's Castrol GTX.")
            cmd_r1c6c4.Hide()
        End If
        If txt_answer.Text = "This type of fuel, used in Top Fuel Dragsters, has the chemical symbol CH3NO2." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Good ol' Nitromethane is the answer! It has quite the fumes.")
            cmd_r1c6c5.Hide()
        End If
        If txt_answer.Text = "Take a trip down the yellow brick road with this famous Cairn Terrier." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Toto is the right answer.")
            cmd_r1c1c1.Hide()
        End If
        If txt_answer.Text = "Look around with this playful TV pup, and Steve, to find 3 pawprints." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("It's Blue!")
            cmd_r1c1c2.Hide()
        End If
        If txt_answer.Text = "'Come Home' is a famous line directed towards this collie in the 1943 MGM film starring Roddy McDowall." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("We're looking for Lassie.")
            cmd_r1c1c3.Hide()
        End If
        If txt_answer.Text = "A favorite in the 'Men in Black' films, this pug was voiced by Tim Blaney." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("It's Frank, Frank.")
            cmd_r1c1c4.Hide()
        End If
        If txt_answer.Text = "Bill Sikes' dog in Oliver Twist." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("It's Bulls-Eye.")
            cmd_r1c1c5.Hide()
        End If
        If txt_answer.Text = "Made of rubber like materials makes this tape resistive, rather than conductive." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("It's electrical tape.")
            cmd_r1c2c1.Hide()
        End If
        If txt_answer.Text = "This all-around use, silver colored tape is known as 'The Handyman's Secret Weapon' on the Canadian TV series, The Red Green Show." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Ah, the very famed Duct Tape is correct.")
            cmd_r1c2c2.Hide()
        End If
        If txt_answer.Text = "Since the 1930s, 3M has manufactured a type of pressure sensitive tapes with this name." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("They call it Scotch Tape.")
            cmd_r1c2c3.Hide()
        End If
        If txt_answer.Text = "An ideal adhesive for holding down cables in theaters or stages." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("This one was Gaffer's Tape.")
            cmd_r1c2c4.Hide()
        End If
        If txt_answer.Text = "Heat shrink tape, or tubing, has this make of plastic tube." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("A tricky one, Polyolefin is the right answer.")
            cmd_r1c2c5.Hide()
        End If
        If txt_answer.Text = "Want to fly? Have one of these, it gives you wings." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("It's Red Bull.")
            cmd_r1c3c1.Hide()
        End If
        If txt_answer.Text = "Drink one and you'll 'Unleash the beast in you'." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("That one is Monster.")
            cmd_r1c3c2.Hide()
        End If
        If txt_answer.Text = "This energy shot has been recently advertised with the tagline 'Every Day'." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("5-Hour Energy is correct. That's seems ironic, doesn't it?")
            cmd_r1c3c3.Hide()
        End If
        If txt_answer.Text = "Made by Coca-Cola and Fuze Beverages, this energy drink was reformulated in 2009 so it was 'easy drinking' with 'no bull'." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("This one's my favorite, Full Throttle is correct.")
            cmd_r1c3c4.Hide()
        End If
        If txt_answer.Text = "PepsiCo released this drink in 1995 and is known as the first energy drink marketed by a major U.S. beverage company." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("It was Josta, discontinued in 1999 four years later.")
            cmd_r1c3c5.Hide()
        End If
        If txt_answer.Text = "It's 'Made Every Day'." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("History is made every day.")
            cmd_r1c4c1.Hide()
        End If
        If txt_answer.Text = "This channel has aired a variety of game shows from archives since 1994." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("GSN, the Game Show Network.")
            cmd_r1c4c2.Hide()
        End If
        If txt_answer.Text = "The home of Saturday Night Live." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Good ol' NBC.")
            cmd_r1c4c3.Hide()
        End If
        If txt_answer.Text = "Adam and Jamie confirm or bust myths on this TV channel." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("That would be Discovery.")
            cmd_r1c4c4.Hide()
        End If
        If txt_answer.Text = "Rock and Roll Jeopardy! was short lived, airing from 1998 to 2001 on this TV channel." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("It was a good show, on VH1.")
            cmd_r1c4c5.Hide()
        End If
        If txt_answer.Text = "The game console is sold by Microsoft and has the 'Kinect' accessory." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("It's the famed Xbox 360.")
            cmd_r1c5c1.Hide()
        End If
        If txt_answer.Text = "3D features have been recently added to this portable game console." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("It's the Nintendo DS, now called the 3DS.")
            cmd_r1c5c2.Hide()
        End If
        If txt_answer.Text = "This 'Super Entertainment System' was a popular 2nd generation console made by this company in the early 1990s" Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("The SNES, the Super Nintendo Entertainment System.")
            cmd_r1c5c3.Hide()
        End If
        If txt_answer.Text = "This was Sega's first console with a built in CD-Rom reader/player." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("They're all from Sega, but Saturn was the first.")
            cmd_r1c5c4.Hide()
        End If
        If txt_answer.Text = "This pocket console was released in 1998 by SNK." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Yeah, that was hard. It's the Neo Geo.")
            cmd_r1c5c5.Hide()
        End If
        If txt_answer.Text = "Finger lickin' good!" Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("That's KFC!")
            cmd_r1c6c1.Hide()
        End If
        If txt_answer.Text = "America's Game." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("WHEEL.... OF.... FORTUNE!!!.")
            cmd_r1c6c2.Hide()
        End If
        If txt_answer.Text = "Reach out and touch someone." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Reach out and touch someone is AT&T.")
            cmd_r1c6c3.Hide()
        End If
        If txt_answer.Text = "From 1958, 'Look ma! No cavities!'." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("That's pretty old, it's Crest.")
            cmd_r1c6c4.Hide()
        End If
        If txt_answer.Text = "Built for the road ahead." Then
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Built for the road ahead is Ford.")
            cmd_r1c6c5.Hide()
        End If
    End Sub
    Private Sub cmd_r1c1c1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_r1c1c1.Click
        If cmd_r1c1c1.Text = "$200" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "This Apple device was first introduced in 2007 and the first to run iOS."
            cmd_response1.Text = "What is the iPod?"
            cmd_response2.Text = "What is the iPhone?"
            cmd_response3.Text = "What is the Mac Pro?"
            tmr_timer.Enabled = True
        End If
        If cmd_r1c1c1.Text = "$400" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "Take a trip down the yellow brick road with this famous Cairn Terrier."
            cmd_response1.Text = "Who is Spot?"
            cmd_response2.Text = "Who is Tock?"
            cmd_response3.Text = "Who is Toto?"
            tmr_timer.Enabled = True
        End If
    End Sub
    Private Sub cmd_response2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_response2.Click
        If cmd_response2.Text = "What is the iPhone?" Then
            lbl_score.Text = lbl_score.Text + 200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("It is the iPhone! You've won $200")
            cmd_r1c1c1.Hide()
        End If
        If cmd_response2.Text = "What is Safari?" Then
            lbl_score.Text = lbl_score.Text - 400
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Nope, it's Internet Explorer. You've lost $400")
            cmd_r1c1c2.Hide()
        End If
        If cmd_response2.Text = "What is Twitter?" Then
            lbl_score.Text = lbl_score.Text - MyDailyWager
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Sorry, the answer's Facebook. Select Again.")
            cmd_r1c1c3.Hide()
        End If
        If cmd_response2.Text = "Who is Warren?" Then
            lbl_score.Text = lbl_score.Text - 800
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Nope, his name was Watson, You've lost $800")
            cmd_r1c1c4.Hide()
        End If
        If cmd_response2.Text = "What is Lockergnome?" Then
            lbl_score.Text = lbl_score.Text - 1000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("A good website, but no. The answer's CNET. You've lost $1,000")
            cmd_r1c1c5.Hide()
        End If
        If cmd_response2.Text = "What is Tyler?" Then
            lbl_score.Text = lbl_score.Text - 200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, it's Lincoln. You've lost $200")
            cmd_r1c2c1.Hide()
        End If
        If cmd_response2.Text = "What is Hoover?" Then
            lbl_score.Text = lbl_score.Text + 400
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Like the sweeper. You've won $400")
            cmd_r1c2c2.Hide()
        End If
        If cmd_response2.Text = "What is Pierce?" Then
            lbl_score.Text = lbl_score.Text + 600
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("A sharp shooter you are! You've won $600")
            cmd_r1c2c3.Hide()
        End If
        If cmd_response2.Text = "What is Eisenhower?" Then
            lbl_score.Text = lbl_score.Text - 800
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Nope, it's Andrew Jackson on the $20 Bill! You've lost $800")
            cmd_r1c2c4.Hide()
        End If
        If cmd_response2.Text = "What is Roosevelt?" Then
            lbl_score.Text = lbl_score.Text - 1000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("They call it the Madison, actually. You've lost $1,000")
            cmd_r1c2c5.Hide()
        End If
        If cmd_response2.Text = "What is a Pitcher?" Then
            lbl_score.Text = lbl_score.Text + 200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Yeah, the pitcher. You've won $200")
            cmd_r1c3c1.Hide()
        End If
        If cmd_response2.Text = "What is a Strike?" Then
            lbl_score.Text = lbl_score.Text - 400
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Nope, it's the batter used in mixtures pancakes. You've lost $400")
            cmd_r1c3c2.Hide()
        End If
        If cmd_response2.Text = "What is a Double?" Then
            lbl_score.Text = lbl_score.Text - 600
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, they call it a strike. You've lost $600")
            cmd_r1c3c3.Hide()
        End If
        If cmd_response2.Text = "What is a homer?" Then
            lbl_score.Text = lbl_score.Text - 800
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, it's actually a slide. You've lost $800.")
            cmd_r1c3c4.Hide()
        End If
        If cmd_response2.Text = "What is a run?" Then
            lbl_score.Text = lbl_score.Text + 1000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Good Job! You've got another $1,000!")
            cmd_r1c3c5.Hide()
        End If
        If cmd_response2.Text = "What is Let's Make a Deal?" Then
            lbl_score.Text = lbl_score.Text - 200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, it's Wheel of Fortune. You've lost $200.")
            cmd_r1c4c1.Hide()
        End If
        If cmd_response2.Text = "What is 'We'll go with that'?" Then
            lbl_score.Text = lbl_score.Text - 400
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, it's the FINAL answer. You've lost $400.")
            cmd_r1c4c2.Hide()
        End If
        If cmd_response2.Text = "What is Press Your Luck?" Then
            lbl_score.Text = lbl_score.Text + 600
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Yep. It was called 'Whammy! The All New Press Your Luck'.")
            cmd_r1c4c3.Hide()
        End If
        If cmd_response2.Text = "Who is Monty Hall?" Then
            lbl_score.Text = lbl_score.Text - 800
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("That was tough, no, it's Art Fleming You've lost $800.")
            cmd_r1c4c4.Hide()
        End If
        If cmd_response2.Text = "What is 8?" Then
            lbl_score.Text = lbl_score.Text - 1000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, 6 is the right answer. You've lost $1,000.")
            cmd_r1c4c5.Hide()
        End If
        If cmd_response2.Text = "What is Harrisburg?" Then
            lbl_score.Text = lbl_score.Text + 200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Good for $200.")
            cmd_r1c5c1.Hide()
        End If
        If cmd_response2.Text = "What is Santa Fe?" Then
            lbl_score.Text = lbl_score.Text - 400
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("That cost you $400, it's Boston.")
            cmd_r1c5c2.Hide()
        End If
        If cmd_response2.Text = "What is Helena?" Then
            lbl_score.Text = lbl_score.Text - 600
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, it's Juneau. You've lost $600.")
            cmd_r1c5c3.Hide()
        End If
        If cmd_response2.Text = "What is Atlanta?" Then
            lbl_score.Text = lbl_score.Text + 800
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("'Enjoy!' another $800!")
            cmd_r1c5c4.Hide()
        End If
        If cmd_response2.Text = "What is Little Rock?" Then
            lbl_score.Text = lbl_score.Text - 1000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("It's the race city of the nation, Indianapolis. You've lost $1,000.")
            cmd_r1c5c5.Hide()
        End If
        If cmd_response2.Text = "What is changing your oil?" Then
            lbl_score.Text = lbl_score.Text + 200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Right for $200.")
            cmd_r1c6c1.Hide()
        End If
        If cmd_response2.Text = "What is Spark Plugs?" Then
            lbl_score.Text = lbl_score.Text - 400
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Nope, it's tires.")
            cmd_r1c6c2.Hide()
        End If
        If cmd_response2.Text = "What is Subaru?" Then
            lbl_score.Text = lbl_score.Text - 600
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("The right answer is the Kia commercials.")
            cmd_r1c6c3.Hide()
        End If
        If cmd_response2.Text = "What is Pennzoil?" Then
            lbl_score.Text = lbl_score.Text - 800
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, it's Castrol GTX.")
            cmd_r1c6c4.Hide()
        End If
        If cmd_response2.Text = "What is Nitromethane?" Then
            lbl_score.Text = lbl_score.Text + 1000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("My favorite mixture! You've won $1,000 well done.")
            cmd_r1c6c5.Hide()
        End If
        If cmd_response2.Text = "Who is Tock?" Then
            lbl_score.Text = lbl_score.Text - 400
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Nope, it's Toto. You've lost $400")
            cmd_r1c1c1.Hide()
        End If
        If cmd_response2.Text = "Who is Magenta?" Then
            lbl_score.Text = lbl_score.Text - 800
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, it's Blue. Magenta's a good friend on the show.")
            cmd_r1c1c2.Hide()
        End If
        If cmd_response2.Text = "Who is Lad?" Then
            lbl_score.Text = lbl_score.Text - 1200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Sorry, the answer's Lassie You've lost $1,200.")
            cmd_r1c1c3.Hide()
        End If
        If cmd_response2.Text = "Who is Arnold?" Then
            lbl_score.Text = lbl_score.Text - 1600
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, it's Frank. You've lost $1,600")
            cmd_r1c1c4.Hide()
        End If
        If cmd_response2.Text = "Who is Bulls-Eye?" Then
            lbl_score.Text = lbl_score.Text + 2000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Ah, good! for another $2,000")
            cmd_r1c1c5.Hide()
        End If
        If cmd_response2.Text = "What is Electrical Tape?" Then
            lbl_score.Text = lbl_score.Text + 400
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Got it! $400 more.")
            cmd_r1c2c1.Hide()
        End If
        If cmd_response2.Text = "What is Painter's Tape?" Then
            lbl_score.Text = lbl_score.Text - 800
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, it's Duct Tape.")
            cmd_r1c2c2.Hide()
        End If
        If cmd_response2.Text = "What is Lotch?" Then
            lbl_score.Text = lbl_score.Text - 1200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Just a few letters off... it's Scotch Tape.")
            cmd_r1c2c3.Hide()
        End If
        If cmd_response2.Text = "What is Cable Path Tape?" Then
            lbl_score.Text = lbl_score.Text - 1600
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Sorry, it's Gaffer's Tape. You've lost $1600")
            cmd_r1c2c4.Hide()
        End If
        If cmd_response2.Text = "What is Polyolefin?" Then
            lbl_score.Text = lbl_score.Text + 2000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Right! Very good.")
            cmd_r1c2c5.Hide()
        End If
        If cmd_response2.Text = "What is Red Bull?" Then
            lbl_score.Text = lbl_score.Text + MyDailyDoubleWager
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Yeah, Red Bull. You've added your wager to your total!")
            cmd_r1c3c1.Hide()
        End If
        If cmd_response2.Text = "What is NOS?" Then
            lbl_score.Text = lbl_score.Text - 800
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, sorry, it's Monster.")
            cmd_r1c3c2.Hide()
        End If
        If cmd_response2.Text = "What is WorX?" Then
            lbl_score.Text = lbl_score.Text - 1200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Oh no, it's 5 Hour Energy. You've lost $1,200")
            cmd_r1c3c3.Hide()
        End If
        If cmd_response2.Text = "What is Full Throttle?" Then
            lbl_score.Text = lbl_score.Text + 1600
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Right, my favorite. You got another $1,600.")
            cmd_r1c3c4.Hide()
        End If
        If cmd_response2.Text = "What is a Gatorade?" Then
            lbl_score.Text = lbl_score.Text - 2000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Josta is the right answer, You've lost $2,000.")
            cmd_r1c3c5.Hide()
        End If
        If cmd_response2.Text = "What is History?" Then
            lbl_score.Text = lbl_score.Text + 400
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Of course!")
            cmd_r1c4c1.Hide()
        End If
        If cmd_response2.Text = "What is CBS?" Then
            lbl_score.Text = lbl_score.Text - 800
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, it's GSN, the Game Show Network. $800.")
            cmd_r1c4c2.Hide()
        End If
        If cmd_response2.Text = "What is the CBS?" Then
            lbl_score.Text = lbl_score.Text - 1200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, it's NBC.")
            cmd_r1c4c3.Hide()
        End If
        If cmd_response2.Text = "What is Discovery?" Then
            lbl_score.Text = lbl_score.Text + 1600
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Yes, for $1,600!")
            cmd_r1c4c4.Hide()
        End If
        If cmd_response2.Text = "What is Spike." Then
            lbl_score.Text = lbl_score.Text - 2000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("That was tough, no, it's VH1.")
            cmd_r1c4c5.Hide()
        End If
        If cmd_response2.Text = "What is the PS3?" Then
            lbl_score.Text = lbl_score.Text - 400
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Nope, it's the Xbox 360, you've lost $400.")
            cmd_r1c5c1.Hide()
        End If
        If cmd_response2.Text = "What is Nintendo DS?" Then
            lbl_score.Text = lbl_score.Text + 800
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            cmd_r1c5c2.Hide()
            MsgBox("Right, the now 3DS.")
        End If
        If cmd_response2.Text = "What is Atari?" Then
            lbl_score.Text = lbl_score.Text - 1200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, it's Nintendo. You've lost $1,200.")
            cmd_r1c5c3.Hide()
        End If
        If cmd_response2.Text = "What is Genesis?" Then
            lbl_score.Text = lbl_score.Text - 1600
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, it's the Saturn believe it or not.")
            cmd_r1c5c4.Hide()
        End If
        If cmd_response2.Text = "What is Amiga?" Then
            lbl_score.Text = lbl_score.Text - 2000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Good guess, but no, it's the Neo Geo.")
            cmd_r1c5c5.Hide()
        End If
        If cmd_response2.Text = "What is Burger King?" Then
            lbl_score.Text = lbl_score.Text - 400
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, that's KFC.")
            cmd_r1c6c1.Hide()
        End If
        If cmd_response2.Text = "What is Wheel of Fortune?" Then
            lbl_score.Text = lbl_score.Text + MyDailyDoubleSecondWager
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Yeah, America's Game is Wheel of Fortune.")
            cmd_r1c6c2.Hide()
        End If
        If cmd_response2.Text = "What is AT&T?" Then
            lbl_score.Text = lbl_score.Text + 1200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Correct!")
            cmd_r1c6c3.Hide()
        End If
        If cmd_response2.Text = "What is Aquafresh?" Then
            lbl_score.Text = lbl_score.Text - 1600
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, that's Crest.")
            cmd_r1c6c4.Hide()
        End If
        If cmd_response2.Text = "What is Mopar?" Then
            lbl_score.Text = lbl_score.Text - 2000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("It could've been any of them, but it's Ford, sorry.")
            cmd_r1c6c5.Hide()
        End If
        If cmd_response2.Text = "Who is David Yates?" Then
            lbl_score.Text = lbl_score.Text - myfinalwager
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            FinalTimer = 0
            MsgBox("No, it's not David Yates. The correct response is James Cameron.")
            MsgBox("That'll do it! Thanks for playing Jason Antao’s Jeopardy!")
            Me.Close()
            form_menu.Close()
        End If
    End Sub
    Private Sub cmd_response1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_response1.Click
        If cmd_response1.Text = "What is the iPod?" Then
            lbl_score.Text = lbl_score.Text - 200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Nope, it's actually the iPhone. You've lost $200")
            cmd_r1c1c1.Hide()
        End If
        If cmd_response1.Text = "What is Internet Explorer?" Then
            lbl_score.Text = lbl_score.Text + 400
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("You got it! You've won $400!")
            cmd_r1c1c2.Hide()
        End If
        If cmd_response1.Text = "What is Google Plus?" Then
            lbl_score.Text = lbl_score.Text - MyDailyWager
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("That's not right, sorry. The answer's Facebook.")
            cmd_r1c1c3.Hide()
        End If
        If cmd_response1.Text = "Who is Willie?" Then
            lbl_score.Text = lbl_score.Text - 800
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Oh no!, Sorry, it's Watson. You've lost $800")
            cmd_r1c1c4.Hide()
        End If
        If cmd_response1.Text = "What is CNET?" Then
            lbl_score.Text = lbl_score.Text + 1000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("You're right! It's CNET! You've won another $1,000!")
            cmd_r1c1c5.Hide()
        End If
        If cmd_response1.Text = "What is Harrison?" Then
            lbl_score.Text = lbl_score.Text - 200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, it's Lincoln. You've lost $200")
            cmd_r1c2c1.Hide()
        End If
        If cmd_response1.Text = "What is Van Buren?" Then
            lbl_score.Text = lbl_score.Text - 400
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Oh no, it's the Hoover. You've lost $400")
            cmd_r1c2c2.Hide()
        End If
        If cmd_response1.Text = "What is Polk?" Then
            lbl_score.Text = lbl_score.Text - 600
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("We were looking for Pierce. You've lost $600")
            cmd_r1c2c3.Hide()
        End If
        If cmd_response1.Text = "What is Bush?" Then
            lbl_score.Text = lbl_score.Text - 800
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, it's Jackson on the $20 Bill. You've lost $800")
            cmd_r1c2c4.Hide()
        End If
        If cmd_response1.Text = "What is Madison?" Then
            lbl_score.Text = lbl_score.Text + 1000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Good! It's Madison. You've won $1,000")
            cmd_r1c2c5.Hide()
        End If
        If cmd_response1.Text = "What is a Home Run?" Then
            lbl_score.Text = lbl_score.Text - 200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Oh sorry, it's the pitcher. You've lost $200")
            cmd_r1c3c1.Hide()
        End If
        If cmd_response1.Text = "What is a Shortstop?" Then
            lbl_score.Text = lbl_score.Text - 400
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, it's the batter. You've lost $400")
            cmd_r1c3c2.Hide()
        End If
        If cmd_response1.Text = "What is a Run?" Then
            lbl_score.Text = lbl_score.Text - 600
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Nope, the strike. You've lost $600.")
            cmd_r1c3c3.Hide()
        End If
        If cmd_response1.Text = "What is a slide?" Then
            lbl_score.Text = lbl_score.Text + 800
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Yep! A slide is right! You've won $800!")
            cmd_r1c3c4.Hide()
        End If
        If cmd_response1.Text = "What is an error?" Then
            lbl_score.Text = lbl_score.Text - 1000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Close, but no. It's called a run. You've lost $1,000.")
            cmd_r1c3c5.Hide()
        End If
        If cmd_response1.Text = "What is Match Game?" Then
            lbl_score.Text = lbl_score.Text - 200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, Wheel of Fortune is correct. You've lost $200.")
            cmd_r1c4c1.Hide()
        End If
        If cmd_response1.Text = "What is 'I'll submit this answer'?" Then
            lbl_score.Text = lbl_score.Text - 400
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, they actually say, 'That's my final answer!' You've lost $400.")
            cmd_r1c4c2.Hide()
        End If
        If cmd_response1.Text = "What is Family Feud?" Then
            lbl_score.Text = lbl_score.Text - 600
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Sorry, it's Press Your Luck.' You've lost $600.")
            cmd_r1c4c3.Hide()
        End If
        If cmd_response1.Text = "Who is Chuck Woolery?" Then
            lbl_score.Text = lbl_score.Text - 800
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Good guess, but no. It's Art Fleming. You've lost $800.")
            cmd_r1c4c4.Hide()
        End If
        If cmd_response1.Text = "What is 6?" Then
            lbl_score.Text = lbl_score.Text + 1000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("You're right! It's 6. You've won $1,000.")
            cmd_r1c4c5.Hide()
        End If
        If cmd_response1.Text = "What is Columbus?" Then
            lbl_score.Text = lbl_score.Text - 200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Sorry, that's Ohio. Harrisburg is Pennsylvania's state capital. You've lost $200.")
            cmd_r1c5c1.Hide()
        End If
        If cmd_response1.Text = "What is Tallahassee?" Then
            lbl_score.Text = lbl_score.Text - 400
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Florida's is Tallahassee. We're looking for Boston. You've lost $400.")
            cmd_r1c5c2.Hide()
        End If
        If cmd_response1.Text = "What is Juneau?" Then
            lbl_score.Text = lbl_score.Text + 600
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Yep! You've got $600!")
            cmd_r1c5c3.Hide()
        End If
        If cmd_response1.Text = "What is Baton Rouge?" Then
            lbl_score.Text = lbl_score.Text - 800
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, it's in Georgia, therefore it's Atlanta. Sorry, you've lost $800")
            cmd_r1c5c4.Hide()
        End If
        If cmd_response1.Text = "What is Indianapolis?" Then
            lbl_score.Text = lbl_score.Text + 1000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("It's the racing capital of the world! So they say... you've won $1,000!")
            cmd_r1c5c5.Hide()
        End If
        If cmd_response1.Text = "What is rotating your tires?" Then
            lbl_score.Text = lbl_score.Text - 200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Uh no, it's changing your oil. You've lost $200.")
            cmd_r1c6c1.Hide()
        End If
        If cmd_response1.Text = "What is Tires?" Then
            lbl_score.Text = lbl_score.Text + 400
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("As in Firestone tires. You're right for another $400!")
            cmd_r1c6c2.Hide()
        End If
        If cmd_response1.Text = "What is Mazda?" Then
            lbl_score.Text = lbl_score.Text - 600
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("You should see some of those commercials, they're cool! It's Kia, you've lost $600.")
            cmd_r1c6c3.Hide()
        End If
        If cmd_response1.Text = "What is Valvoline NextGen?" Then
            lbl_score.Text = lbl_score.Text - 800
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, it's Castrol GTX. You've lost $800.")
            cmd_r1c6c4.Hide()
        End If
        If cmd_response1.Text = "What is Methanol?" Then
            lbl_score.Text = lbl_score.Text - 1000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, it's the powerful Nitromethane we were looking for. You've lost $1,000.")
            cmd_r1c6c5.Hide()
        End If
        If cmd_response1.Text = "Who is Spot?" Then
            lbl_score.Text = lbl_score.Text - 400
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Oh no, it's Toto.")
            cmd_r1c1c1.Hide()
        End If
        If cmd_response1.Text = "Who is Blue?" Then
            lbl_score.Text = lbl_score.Text + 800
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Yeah, Blue!")
            cmd_r1c1c2.Hide()
        End If
        If cmd_response1.Text = "Who is Lassie?" Then
            lbl_score.Text = lbl_score.Text + 1200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Yes! Lassie!.")
            cmd_r1c1c3.Hide()
        End If
        If cmd_response1.Text = "Who is Jim?" Then
            lbl_score.Text = lbl_score.Text - 1600
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No it's Frank, Frank.")
            cmd_r1c1c4.Hide()
        End If
        If cmd_response1.Text = "Who is Clifford?" Then
            lbl_score.Text = lbl_score.Text - 2000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Sorry, it's Bulls-Eye... you've lost $2,000")
            cmd_r1c1c5.Hide()
        End If
        If cmd_response1.Text = "What is Cable Path Tape?" Then
            lbl_score.Text = lbl_score.Text - 400
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, it's Electrical Tape.")
            cmd_r1c2c1.Hide()
        End If
        If cmd_response1.Text = "What is Duct Tape?" Then
            lbl_score.Text = lbl_score.Text + 800
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Yes, it's Duct Tape!")
            cmd_r1c2c2.Hide()
        End If
        If cmd_response1.Text = "What is Botch?" Then
            lbl_score.Text = lbl_score.Text - 1200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, you're a few letters off, it's Scotch.")
            cmd_r1c2c3.Hide()
        End If
        If cmd_response1.Text = "What is Gaffer's Tape?" Then
            lbl_score.Text = lbl_score.Text + 1600
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("You're a star! It's Gaffer's Tape.")
            cmd_r1c2c4.Hide()
        End If
        If cmd_response1.Text = "What is Fiberglass?" Then
            lbl_score.Text = lbl_score.Text - 2000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Nope, it's Polyolefin")
            cmd_r1c2c5.Hide()
        End If
        If cmd_response1.Text = "What is Volt?" Then
            lbl_score.Text = lbl_score.Text - MyDailyDoubleWager
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, it's Red Bull.")
            cmd_r1c3c1.Hide()
        End If
        If cmd_response1.Text = "What is Monster?" Then
            lbl_score.Text = lbl_score.Text + 800
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Right!")
            cmd_r1c3c2.Hide()
        End If
        If cmd_response1.Text = "What is AMP?" Then
            lbl_score.Text = lbl_score.Text - 1200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Nope, it's 5 Hour Energy.")
            cmd_r1c3c3.Hide()
        End If
        If cmd_response1.Text = "What is NOS?" Then
            lbl_score.Text = lbl_score.Text - 1600
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, it's Full Throttle It'll cost you $1,600.")
            cmd_r1c3c4.Hide()
        End If
        If cmd_response1.Text = "What is an Josta?" Then
            lbl_score.Text = lbl_score.Text + 2000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Very good, that was tough. You've got another $2,000.")
            cmd_r1c3c5.Hide()
        End If
        If cmd_response1.Text = "What is Discovery?" Then
            lbl_score.Text = lbl_score.Text - 400
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, it's History.")
            cmd_r1c4c1.Hide()
        End If
        If cmd_response1.Text = "What is NBC?" Then
            lbl_score.Text = lbl_score.Text - 800
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, it's GSN, the Game Show Network.")
            cmd_r1c4c2.Hide()
        End If
        If cmd_response1.Text = "What is GSN?" Then
            lbl_score.Text = lbl_score.Text - 1200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, it's NBC.")
            cmd_r1c4c3.Hide()
        End If
        If cmd_response1.Text = "What is PBS?" Then
            lbl_score.Text = lbl_score.Text - 1600
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Ah shoot, it's Discovery. You've lost $1,600.")
            cmd_r1c4c4.Hide()
        End If
        If cmd_response1.Text = "What is VH1?" Then
            lbl_score.Text = lbl_score.Text + 2000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Good for $2,000.")
            cmd_r1c4c5.Hide()
        End If
        If cmd_response1.Text = "What is the Xbox?" Then
            lbl_score.Text = lbl_score.Text + 400
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Yes, you've got it!")
            cmd_r1c5c1.Hide()
        End If
        If cmd_response1.Text = "What is PS Vita?" Then
            lbl_score.Text = lbl_score.Text - 800
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No it's the DS, now called the 3DS.")
            cmd_r1c5c2.Hide()
        End If
        If cmd_response1.Text = "What is Sony?" Then
            lbl_score.Text = lbl_score.Text - 1200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Nope, sorry, it's Nintendo, the Super Nintendo Entertainment System.")
            cmd_r1c5c3.Hide()
        End If
        If cmd_response1.Text = "What is Dreamcast?" Then
            lbl_score.Text = lbl_score.Text - 1600
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("A tough one, it's Saturn.")
            cmd_r1c5c4.Hide()
        End If
        If cmd_response1.Text = "What is Neo Geo?" Then
            lbl_score.Text = lbl_score.Text + 2000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("You've got another $2,000!")
            cmd_r1c5c5.Hide()
        End If
        If cmd_response1.Text = "What is KFC?" Then
            lbl_score.Text = lbl_score.Text + 400
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Indeed.")
            cmd_r1c6c1.Hide()
        End If
        If cmd_response1.Text = "What is The Newlywed Game?" Then
            lbl_score.Text = lbl_score.Text - MyDailyDoubleSecondWager
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("America's Game is Wheel of Fortune.")
            cmd_r1c6c2.Hide()
        End If
        If cmd_response1.Text = "What is Sprint?" Then
            lbl_score.Text = lbl_score.Text - 1200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, it's AT&T.")
            cmd_r1c6c3.Hide()
        End If
        If cmd_response1.Text = "What is Crest?" Then
            lbl_score.Text = lbl_score.Text + 1600
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Right!")
            cmd_r1c6c4.Hide()
        End If
        If cmd_response1.Text = "What is Volkswagen?" Then
            lbl_score.Text = lbl_score.Text - 2000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, it's Ford. Das Auto is Volkswagen.")
            cmd_r1c6c5.Hide()
        End If
        If cmd_response1.Text = "Who is Michael Bay?" Then
            lbl_score.Text = lbl_score.Text - myfinalwager
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            FinalTimer = 0
            MsgBox("No, it's not Michael Bay. The correct response is James Cameron.")
            MsgBox("That'll do it! Thanks for playing Jason Antao’s Jeopardy!")
            Me.Close()
            form_menu.Close()
        End If
    End Sub
    Private Sub cmd_response3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_response3.Click
        If cmd_response3.Text = "What is the Mac Pro?" Then
            lbl_score.Text = lbl_score.Text - 200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Nope, Sorry, it's the iPhone. You've lost $200")
            cmd_r1c1c1.Hide()
        End If
        If cmd_response3.Text = "What is Opera?" Then
            lbl_score.Text = lbl_score.Text - 400
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Sorry, it's Internet Explorer. You've lost $400")
            cmd_r1c1c2.Hide()
        End If
        If cmd_response3.Text = "What is Facebook?" Then
            lbl_score.Text = lbl_score.Text + MyDailyWager
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("It is Facebook! You've won the Daily Double!")
            cmd_r1c1c3.Hide()
        End If
        If cmd_response3.Text = "Who is Watson?" Then
            lbl_score.Text = lbl_score.Text + 800
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("That's what they call him! You've won $800")
            cmd_r1c1c4.Hide()
        End If
        If cmd_response3.Text = "What is Yahoo!?" Then
            lbl_score.Text = lbl_score.Text - 1000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Nope, Sorry, it's CNET. You've lost $1,000")
            cmd_r1c1c5.Hide()
        End If
        If cmd_response3.Text = "What is Lincoln?" Then
            lbl_score.Text = lbl_score.Text + 200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Of course!. You've won $200")
            cmd_r1c2c1.Hide()
        End If
        If cmd_response3.Text = "What is Hayes?" Then
            lbl_score.Text = lbl_score.Text - 400
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, it's Hoover, like the sweeper. You've lost $400.")
            cmd_r1c2c2.Hide()
        End If
        If cmd_response3.Text = "What is Nixon?" Then
            lbl_score.Text = lbl_score.Text - 600
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, it's Pierce. You've lost $600.")
            cmd_r1c2c3.Hide()
        End If
        If cmd_response3.Text = "What is Jackson?" Then
            lbl_score.Text = lbl_score.Text + 800
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Yeah! You've probably seen him more than once. You've won $800.")
            cmd_r1c2c4.Hide()
        End If
        If cmd_response3.Text = "What is Taft?" Then
            lbl_score.Text = lbl_score.Text - 1000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("We were looking for Madison. You've lost $1,000.")
            cmd_r1c2c5.Hide()
        End If
        If cmd_response3.Text = "What is a Catcher?" Then
            lbl_score.Text = lbl_score.Text - 200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, it's the pitcher. You've lost $200.")
            cmd_r1c3c1.Hide()
        End If
        If cmd_response3.Text = "What is Batter?" Then
            lbl_score.Text = lbl_score.Text + 400
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Uh huh, batter is correct. You've won $400.")
            cmd_r1c3c2.Hide()
        End If
        If cmd_response3.Text = "What is a Strike?" Then
            lbl_score.Text = lbl_score.Text + 600
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("It is a strike and you've won $600.")
            cmd_r1c3c3.Hide()
        End If
        If cmd_response3.Text = "What is a shutout?" Then
            lbl_score.Text = lbl_score.Text - 800
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("It's a slide, on the trombone. You've lost $800.")
            cmd_r1c3c4.Hide()
        End If
        If cmd_response3.Text = "What is a pitch?" Then
            lbl_score.Text = lbl_score.Text - 1000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, that's called a run. You've lost $1,000.")
            cmd_r1c3c5.Hide()
        End If
        If cmd_response3.Text = "What is Wheel of Fortune?" Then
            lbl_score.Text = lbl_score.Text + 200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("You got it!")
            cmd_r1c4c1.Hide()
        End If
        If cmd_response3.Text = "What is 'That's my final answer'?" Then
            lbl_score.Text = lbl_score.Text + 400
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Glad that was your final answer! You've won $400.")
            cmd_r1c4c2.Hide()
        End If
        If cmd_response3.Text = "What is The Price is Right?" Then
            lbl_score.Text = lbl_score.Text - 600
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Nope, it's called 'Whammy! The All New Press Your Luck' Sorry, you've lost $600.")
            cmd_r1c4c3.Hide()
        End If
        If cmd_response3.Text = "Who is Art Fleming?" Then
            lbl_score.Text = lbl_score.Text + 800
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Very good! You've got another $800.")
            cmd_r1c4c4.Hide()
        End If
        If cmd_response3.Text = "What is 4?" Then
            lbl_score.Text = lbl_score.Text - 1000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Good guess, but no, it's 6.")
            cmd_r1c4c5.Hide()
        End If
        If cmd_response3.Text = "What is Lansing?" Then
            lbl_score.Text = lbl_score.Text - 200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, that's Michigan, it's Harrisburg.")
            cmd_r1c5c1.Hide()
        End If
        If cmd_response3.Text = "What is Boston?" Then
            lbl_score.Text = lbl_score.Text + 400
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Right for $400!")
            cmd_r1c5c2.Hide()
        End If
        If cmd_response3.Text = "What is Salem?" Then
            lbl_score.Text = lbl_score.Text - 600
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, it's Juneau.")
            cmd_r1c5c3.Hide()
        End If
        If cmd_response3.Text = "What is Austin?" Then
            lbl_score.Text = lbl_score.Text - 800
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Sorry, it's Atlanta.")
            cmd_r1c5c4.Hide()
        End If
        If cmd_response3.Text = "What is St. Louis?" Then
            lbl_score.Text = lbl_score.Text - 1000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, we're talking about the racing city of the world, Indianapolis.")
            cmd_r1c5c5.Hide()
        End If
        If cmd_response3.Text = "What is washing your car?" Then
            lbl_score.Text = lbl_score.Text - 200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("It's changing your oil.")
            cmd_r1c6c1.Hide()
        End If
        If cmd_response3.Text = "What is Air Filters?" Then
            lbl_score.Text = lbl_score.Text - 400
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Nope, it's Tires.")
            cmd_r1c6c2.Hide()
        End If
        If cmd_response3.Text = "What is Kia?" Then
            lbl_score.Text = lbl_score.Text + 600
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Good commercials aren't they? Good for $600.")
            cmd_r1c6c3.Hide()
        End If
        If cmd_response3.Text = "What is Castrol GTX?" Then
            lbl_score.Text = lbl_score.Text + 800
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Yes! for $800.")
            cmd_r1c6c4.Hide()
        End If
        If cmd_response3.Text = "What is Alcohol?" Then
            lbl_score.Text = lbl_score.Text - 1000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Only Alcohol Dragsters run on Alcohol, Top Fuelers run on Nitromethane. You've lost $1,000.")
            cmd_r1c6c5.Hide()
        End If
        If cmd_response3.Text = "Who is Toto?" Then
            lbl_score.Text = lbl_score.Text + 400
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Yes! For $400")
            cmd_r1c1c1.Hide()
        End If
        If cmd_response3.Text = "Who is Lavender?" Then
            lbl_score.Text = lbl_score.Text - 800
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, it's Blue.")
            cmd_r1c1c2.Hide()
        End If
        If cmd_response3.Text = "Who is Jip?" Then
            lbl_score.Text = lbl_score.Text - 1200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Sorry, it's Lassie.")
            cmd_r1c1c3.Hide()
        End If
        If cmd_response3.Text = "Who is Frank?" Then
            lbl_score.Text = lbl_score.Text + 1600
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Right, Frank!")
            cmd_r1c1c4.Hide()
        End If
        If cmd_response3.Text = "Who is Frankenstein?" Then
            lbl_score.Text = lbl_score.Text - 2000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c1c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Oh shoot, it's Bulls-Eye. You've lost $2,000")
            cmd_r1c1c5.Hide()
        End If
        If cmd_response3.Text = "What is Masking Tape?" Then
            lbl_score.Text = lbl_score.Text - 400
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("That one is electrical tape.")
            cmd_r1c2c1.Hide()
        End If
        If cmd_response3.Text = "What is Fiberglass Tape?" Then
            lbl_score.Text = lbl_score.Text - 800
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Ooh that's wrong, it's Duct Tape.")
            cmd_r1c2c2.Hide()
        End If
        If cmd_response3.Text = "What is Scotch?" Then
            lbl_score.Text = lbl_score.Text + 1200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Right, Scotch.")
            cmd_r1c2c3.Hide()
        End If
        If cmd_response3.Text = "What is Fire Tape?" Then
            lbl_score.Text = lbl_score.Text - 1600
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, sorry, it's Gaffer's Tape.")
            cmd_r1c2c4.Hide()
        End If
        If cmd_response3.Text = "What is Filiment?" Then
            lbl_score.Text = lbl_score.Text - 2000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c2c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Boy that was hard. It's Polyolefin.")
            cmd_r1c2c5.Hide()
        End If
        If cmd_response3.Text = "What is a Crunk?" Then
            lbl_score.Text = lbl_score.Text - MyDailyDoubleWager
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Oh, that'll cost you your wager, it's Red Bull.")
            cmd_r1c3c1.Hide()
        End If
        If cmd_response3.Text = "What is Rockstar?" Then
            lbl_score.Text = lbl_score.Text - 800
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Nope, Monster.")
            cmd_r1c3c2.Hide()
        End If
        If cmd_response3.Text = "What is 5 Hour Energy?" Then
            lbl_score.Text = lbl_score.Text + 1200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Got it!")
            cmd_r1c3c3.Hide()
        End If
        If cmd_response3.Text = "What is WorX?" Then
            lbl_score.Text = lbl_score.Text - 1600
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Wrong Coca-Cola product, it's Full Throttle.")
            cmd_r1c3c4.Hide()
        End If
        If cmd_response3.Text = "What is a AMP?" Then
            lbl_score.Text = lbl_score.Text - 2000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c3c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Wrong Pepsi product, it's Josta.")
            cmd_r1c3c5.Hide()
        End If
        If cmd_response3.Text = "What is TNN?" Then
            lbl_score.Text = lbl_score.Text - 400
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("It's History... Made every day.")
            cmd_r1c4c1.Hide()
        End If
        If cmd_response3.Text = "What is GSN?" Then
            lbl_score.Text = lbl_score.Text + 800
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Yep, the Game Show Network.")
            cmd_r1c4c2.Hide()
        End If
        If cmd_response3.Text = "What is NBC?" Then
            lbl_score.Text = lbl_score.Text + 1200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Yep, NBC!")
            cmd_r1c4c3.Hide()
        End If
        If cmd_response3.Text = "What is Hallmark?" Then
            lbl_score.Text = lbl_score.Text - 1600
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, that one's Discovery.")
            cmd_r1c4c4.Hide()
        End If
        If cmd_response3.Text = "What is AMC?" Then
            lbl_score.Text = lbl_score.Text - 2000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c4c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Nope, VH1 is correct.")
            cmd_r1c4c5.Hide()
        End If
        If cmd_response3.Text = "What is the Wii?" Then
            lbl_score.Text = lbl_score.Text - 400
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, it's the Xbox 360 from Microsoft.")
            cmd_r1c5c1.Hide()
        End If
        If cmd_response3.Text = "What is Dingoo?" Then
            lbl_score.Text = lbl_score.Text - 800
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("No, it's Nintendo DS, now the 3DS.")
            cmd_r1c5c2.Hide()
        End If
        If cmd_response3.Text = "What is Nintendo?" Then
            lbl_score.Text = lbl_score.Text + 1200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Yeah, it's the Super Nintendo Entertainment System, or the SNES.")
            cmd_r1c5c3.Hide()
        End If
        If cmd_response3.Text = "What is Saturn?" Then
            lbl_score.Text = lbl_score.Text + 1600
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Ooh that was tough, but you got it!")
            cmd_r1c5c4.Hide()
        End If
        If cmd_response3.Text = "What is Wonderswan?" Then
            lbl_score.Text = lbl_score.Text - 2000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c5c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Ah another tough one, it's Neo Geo.")
            cmd_r1c5c5.Hide()
        End If
        If cmd_response3.Text = "What is Taco Bell?" Then
            lbl_score.Text = lbl_score.Text - 400
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c1.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Nope, it's KFC.")
            cmd_r1c6c1.Hide()
        End If
        If cmd_response3.Text = "What is Millionaire?" Then
            lbl_score.Text = lbl_score.Text - MyDailyDoubleSecondWager
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c2.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Sorry, America's Game is Wheel of Fortune.")
            cmd_r1c6c2.Hide()
        End If
        If cmd_response3.Text = "What is Verizon?" Then
            lbl_score.Text = lbl_score.Text - 1200
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c3.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Oh no, it's AT&T.")
            cmd_r1c6c3.Hide()
        End If
        If cmd_response3.Text = "What is Colgate?" Then
            lbl_score.Text = lbl_score.Text - 1600
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c4.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Good guess, but no. It's Crest.")
            cmd_r1c6c4.Hide()
        End If
        If cmd_response3.Text = "What is Ford?" Then
            lbl_score.Text = lbl_score.Text + 2000
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_r1c6c5.Enabled = False
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Yeah, you've got that one, another $2,000 for you.")
            cmd_r1c6c5.Hide()
        End If
        If cmd_response3.Text = "Who is James Cameron?" Then
            lbl_score.Text = lbl_score.Text + myfinalwager
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            FinalTimer = 0
            MsgBox("Yes! You've won Final Jeopardy! and added your wager to your score.")
            MsgBox("That'll do it! Thanks for playing Jason Antao’s Jeopardy!")
            Me.Close()
            form_menu.Close()
        End If
    End Sub
    Private Sub cmd_r1c1c2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_r1c1c2.Click
        If cmd_r1c1c2.Text = "$400" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "This Internet browser is the most used worldwide as of March 2012, with Google Chrome and Firefox in a close 2nd and 3rd."
            cmd_response1.Text = "What is Internet Explorer?"
            cmd_response2.Text = "What is Safari?"
            cmd_response3.Text = "What is Opera?"
            tmr_timer.Enabled = True
        End If
        If cmd_r1c1c2.Text = "$800" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "Look around with this playful TV pup, and Steve, to find 3 pawprints."
            cmd_response1.Text = "Who is Blue?"
            cmd_response2.Text = "Who is Magenta?"
            cmd_response3.Text = "Who is Lavender?"
            tmr_timer.Enabled = True
        End If
    End Sub
    Private Sub cmd_r1c1c3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_r1c1c3.Click
        If cmd_r1c1c3.Text = "$600" Then
            My.Computer.Audio.Play(My.Resources.JeopardyDailyDouble, AudioPlayMode.Background)
            MyDailyWager = InputBox("You've selected the Daily Double! What would you like to wager? (Postive numbers only, no dollar signs or commas.")
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "This social network recently bought the popular Instagram photography application for 1 billion dollars."
            cmd_response1.Text = "What is Google Plus?"
            cmd_response2.Text = "What is Twitter?"
            cmd_response3.Text = "What is Facebook?"
            tmr_timer.Enabled = True
        End If
        If cmd_r1c1c3.Text = "$1,200" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "'Come Home' is a famous line directed towards this collie in the 1943 MGM film starring Roddy McDowall."
            cmd_response1.Text = "Who is Lassie?"
            cmd_response2.Text = "Who is Lad?"
            cmd_response3.Text = "Who is Jip?"
            tmr_timer.Enabled = True
        End If
    End Sub
    Private Sub cmd_r1c1c4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_r1c1c4.Click
        If cmd_r1c1c4.Text = "$800" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "This IBM computer goes by this name as he competed on Jeopardy's competition in February 2011."
            cmd_response1.Text = "Who is Willie?"
            cmd_response2.Text = "Who is Warren?"
            cmd_response3.Text = "Who is Watson?"
            tmr_timer.Enabled = True
        End If
        If cmd_r1c1c4.Text = "$1,600" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "A favorite in the 'Men in Black' films, this pug was voiced by Tim Blaney."
            cmd_response1.Text = "Who is Jim?"
            cmd_response2.Text = "Who is Arnold?"
            cmd_response3.Text = "Who is Frank?"
            tmr_timer.Enabled = True
        End If
    End Sub
    Private Sub cmd_r1c1c5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_r1c1c5.Click
        If cmd_r1c1c5.Text = "$1,000" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "This website jokingly displays the phrase 'Whoops! You broke the Internet!' when a user comes across HTTP 404 error."
            cmd_response1.Text = "What is CNET?"
            cmd_response2.Text = "What is Lockergnome?"
            cmd_response3.Text = "What is Yahoo!?"
            tmr_timer.Enabled = True
        End If
        If cmd_r1c1c5.Text = "$2,000" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "Bill Sikes' dog in Oliver Twist."
            cmd_response1.Text = "Who is Clifford?"
            cmd_response2.Text = "Who is Bulls-Eye?"
            cmd_response3.Text = "Who is Frankenstein?"
            tmr_timer.Enabled = True
        End If
    End Sub
    Private Sub cmd_r1c2c1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_r1c2c1.Click
        If cmd_r1c2c1.Text = "$200" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "The Continental and the Town Car are two types of this 'presidential' car brand."
            cmd_response1.Text = "What is Harrison?"
            cmd_response2.Text = "What is Tyler?"
            cmd_response3.Text = "What is Lincoln?"
            tmr_timer.Enabled = True
        End If
        If cmd_r1c2c1.Text = "$400" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "Made of rubber like materials makes this tape resistive, rather than conductive."
            cmd_response1.Text = "What is Cable Path Tape?"
            cmd_response2.Text = "What is Electrical Tape?"
            cmd_response3.Text = "What is Masking Tape?"
            tmr_timer.Enabled = True
        End If
    End Sub
    Private Sub cmd_r1c2c2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_r1c2c2.Click
        If cmd_r1c2c2.Text = "$400" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "Use this around your house for a 'presidential' vaccuum cleaning."
            cmd_response1.Text = "What is Van Buren?"
            cmd_response2.Text = "What is Hoover?"
            cmd_response3.Text = "What is Hayes?"
            tmr_timer.Enabled = True
        End If
        If cmd_r1c2c2.Text = "$800" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "This all-around use, silver colored tape is known as 'The Handyman's Secret Weapon' on the Canadian TV series, The Red Green Show."
            cmd_response1.Text = "What is Duct Tape?"
            cmd_response2.Text = "What is Painter's Tape?"
            cmd_response3.Text = "What is Fiberglass Tape?"
            tmr_timer.Enabled = True
        End If
    End Sub
    Private Sub cmd_r1c2c3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_r1c2c3.Click
        If cmd_r1c2c3.Text = "$600" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "This 'presidential' word means to stab."
            cmd_response1.Text = "What is Polk?"
            cmd_response2.Text = "What is Pierce?"
            cmd_response3.Text = "What is Nixon?"
            tmr_timer.Enabled = True
        End If
        If cmd_r1c2c3.Text = "$1,200" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "Since the 1930s, 3M has manufactured a type of pressure sensitive tapes with this name."
            cmd_response1.Text = "What is Botch?"
            cmd_response2.Text = "What is Lotch?"
            cmd_response3.Text = "What is Scotch?"
            tmr_timer.Enabled = True
        End If
    End Sub
    Private Sub cmd_r1c2c4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_r1c2c4.Click
        If cmd_r1c2c4.Text = "$800" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "This is the 'presidential' name for a twenty-dollar bill."
            cmd_response1.Text = "What is Bush?"
            cmd_response2.Text = "What is Eisenhower?"
            cmd_response3.Text = "What is Jackson?"
            tmr_timer.Enabled = True
        End If
        If cmd_r1c2c4.Text = "$1,600" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "An ideal adhesive for holding down cables in theaters or stages."
            cmd_response1.Text = "What is Gaffer's Tape?"
            cmd_response2.Text = "What is Cable Path Tape?"
            cmd_response3.Text = "What is Fire Tape?"
            tmr_timer.Enabled = True
        End If
    End Sub
    Private Sub cmd_r1c2c5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_r1c2c5.Click
        If cmd_r1c2c5.Text = "$1,000" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "This 'presidential' line dance was popular in the late 50s and 60s."
            cmd_response1.Text = "What is Madison?"
            cmd_response2.Text = "What is Roosevelt?"
            cmd_response3.Text = "What is Taft?"
            tmr_timer.Enabled = True
        End If
        If cmd_r1c2c5.Text = "$2,000" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "Heat shrink tape, or tubing, has this make of plastic tube."
            cmd_response1.Text = "What is Fiberglass?"
            cmd_response2.Text = "What is Polyolefin?"
            cmd_response3.Text = "What is Filiment?"
            tmr_timer.Enabled = True
        End If
    End Sub
    Private Sub cmd_r1c3c1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_r1c3c1.Click
        If cmd_r1c3c1.Text = "$200" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "A single-handled jug with a spout for pouring."
            cmd_response1.Text = "What is a Home Run?"
            cmd_response2.Text = "What is a Pitcher?"
            cmd_response3.Text = "What is a Catcher?"
            tmr_timer.Enabled = True
        End If
        If cmd_r1c3c1.Text = "$400" Then
            My.Computer.Audio.Play(My.Resources.JeopardyDailyDouble, AudioPlayMode.Background)
            MyDailyDoubleWager = InputBox("You've selected a Daily Double! What would you like to wager? (Postive numbers only, no dollar signs or commas.")
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "Want to fly? Have one of these, it gives you wings."
            cmd_response1.Text = "What is Volt?"
            cmd_response2.Text = "What is Red Bull?"
            cmd_response3.Text = "What is a Crunk?"
            tmr_timer.Enabled = True
        End If
    End Sub
    Private Sub cmd_r1c3c2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_r1c3c2.Click
        If cmd_r1c3c2.Text = "$400" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "A mixture of flour and water to make pancakes."
            cmd_response1.Text = "What is a Shortstop?"
            cmd_response2.Text = "What is a Strike?"
            cmd_response3.Text = "What is Batter?"
            tmr_timer.Enabled = True
        End If
        If cmd_r1c3c2.Text = "$800" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "Drink one and you'll 'Unleash the beast in you'."
            cmd_response1.Text = "What is Monster?"
            cmd_response2.Text = "What is NOS?"
            cmd_response3.Text = "What is Rockstar?"
            tmr_timer.Enabled = True
        End If
    End Sub
    Private Sub cmd_r1c3c3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_r1c3c3.Click
        If cmd_r1c3c3.Text = "$600" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "An intentional stoppage by workers."
            cmd_response1.Text = "What is a Run?"
            cmd_response2.Text = "What is a Double?"
            cmd_response3.Text = "What is a Strike?"
            tmr_timer.Enabled = True
        End If
        If cmd_r1c3c3.Text = "$1,200" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "This energy shot has been recently advertised with the tagline 'Every Day'."
            cmd_response1.Text = "What is AMP?"
            cmd_response2.Text = "What is WorX?"
            cmd_response3.Text = "What is 5 Hour Energy?"
            tmr_timer.Enabled = True
        End If
    End Sub
    Private Sub cmd_r1c3c4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_r1c3c4.Click
        If cmd_r1c3c4.Text = "$800" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "This device lets a trombonist change pitch."
            cmd_response1.Text = "What is a slide?"
            cmd_response2.Text = "What is a homer?"
            cmd_response3.Text = "What is a shutout?"
            tmr_timer.Enabled = True
        End If
        If cmd_r1c3c4.Text = "$1,600" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "Made by Coca-Cola and Fuze Beverages, this energy drink was reformulated in 2009 so it was 'easy drinking' with 'no bull'."
            cmd_response1.Text = "What is NOS?"
            cmd_response2.Text = "What is Full Throttle?"
            cmd_response3.Text = "What is WorX?"
            tmr_timer.Enabled = True
        End If
    End Sub
    Private Sub cmd_r1c3c5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_r1c3c5.Click
        If cmd_r1c3c5.Text = "$1,000" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "An unraveling in your nylon stocking."
            cmd_response1.Text = "What is an error?"
            cmd_response2.Text = "What is a run?"
            cmd_response3.Text = "What is a pitch?"
            tmr_timer.Enabled = True
        End If
        If cmd_r1c3c5.Text = "$2,000" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "PepsiCo released this drink in 1995 and is known as the first energy drink marketed by a major U.S. beverage company."
            cmd_response1.Text = "What is an Josta?"
            cmd_response2.Text = "What is a Gatorade?"
            cmd_response3.Text = "What is a AMP?"
            tmr_timer.Enabled = True
        End If
    End Sub
    Private Sub cmd_r1c4c1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_r1c4c1.Click
        If cmd_r1c4c1.Text = "$200" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "'I would like to buy a vowel' is a common term heard on this game show."
            cmd_response1.Text = "What is Match Game?"
            cmd_response2.Text = "What is Let's Make a Deal?"
            cmd_response3.Text = "What is Wheel of Fortune?"
            tmr_timer.Enabled = True
        End If
        If cmd_r1c4c1.Text = "$400" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "It's 'Made Every Day'."
            cmd_response1.Text = "What is Discovery?"
            cmd_response2.Text = "What is History?"
            cmd_response3.Text = "What is TNN?"
            tmr_timer.Enabled = True
        End If
    End Sub
    Private Sub cmd_r1c4c2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_r1c4c2.Click
        If cmd_r1c4c2.Text = "$400" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "To lock in an answer on 'Who Wants to Be a Millionaire,' the contestant would say this."
            cmd_response1.Text = "What is 'I'll submit this answer'?"
            cmd_response2.Text = "What is 'We'll go with that'?"
            cmd_response3.Text = "What is 'That's my final answer'?"
            tmr_timer.Enabled = True
        End If
        If cmd_r1c4c2.Text = "$800" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "This channel has aired a variety of game shows from archives since 1994."
            cmd_response1.Text = "What is NBC?"
            cmd_response2.Text = "What is CBS?"
            cmd_response3.Text = "What is GSN?"
            tmr_timer.Enabled = True
        End If
    End Sub
    Private Sub cmd_r1c4c3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_r1c4c3.Click
        If cmd_r1c4c3.Text = "$600" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "A remake of this popular game show, called 'Whammy!' began its short term run in 2002."
            cmd_response1.Text = "What is Family Feud?"
            cmd_response2.Text = "What is Press Your Luck?"
            cmd_response3.Text = "What is The Price is Right?"
            tmr_timer.Enabled = True
        End If
        If cmd_r1c4c3.Text = "$1,200" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "The home of Saturday Night Live."
            cmd_response1.Text = "What is GSN?"
            cmd_response2.Text = "What is the CBS?"
            cmd_response3.Text = "What is NBC?"
            tmr_timer.Enabled = True
        End If
    End Sub
    Private Sub cmd_r1c4c4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_r1c4c4.Click
        If cmd_r1c4c4.Text = "$800" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "This man was the first to host Jeopardy! from 1964 to 1975, and again from 1978 to 1979."
            cmd_response1.Text = "Who is Chuck Woolery?"
            cmd_response2.Text = "Who is Monty Hall?"
            cmd_response3.Text = "Who is Art Fleming?"
            tmr_timer.Enabled = True
        End If
        If cmd_r1c4c4.Text = "$1,600" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "Adam and Jamie confirm or bust myths on this TV channel."
            cmd_response1.Text = "What is PBS?"
            cmd_response2.Text = "What is Discovery?"
            cmd_response3.Text = "What is Hallmark?"
            tmr_timer.Enabled = True
        End If
    End Sub
    Private Sub cmd_r1c4c5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_r1c4c5.Click
        If cmd_r1c4c5.Text = "$1,000" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "This many pricing games are played during the hour long Price is Right."
            cmd_response1.Text = "What is 6?"
            cmd_response2.Text = "What is 8?"
            cmd_response3.Text = "What is 4?"
            tmr_timer.Enabled = True
        End If
        If cmd_r1c4c5.Text = "$2,000" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "Rock and Roll Jeopardy! was short lived, airing from 1998 to 2001 on this TV channel."
            cmd_response1.Text = "What is VH1?"
            cmd_response2.Text = "What is Spike."
            cmd_response3.Text = "What is AMC?"
            tmr_timer.Enabled = True
        End If
    End Sub
    Private Sub cmd_r1c5c1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_r1c5c1.Click
        If cmd_r1c5c1.Text = "$200" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "Pennsylvania."
            cmd_response1.Text = "What is Columbus?"
            cmd_response2.Text = "What is Harrisburg?"
            cmd_response3.Text = "What is Lansing?"
            tmr_timer.Enabled = True
        End If
        If cmd_r1c5c1.Text = "$400" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "The game console is sold by Microsoft and has the 'Kinect' accessory."
            cmd_response1.Text = "What is the Xbox?"
            cmd_response2.Text = "What is the PS3?"
            cmd_response3.Text = "What is the Wii?"
            tmr_timer.Enabled = True
        End If
    End Sub
    Private Sub cmd_r1c5c2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_r1c5c2.Click
        If cmd_r1c5c2.Text = "$400" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "Massachusetts."
            cmd_response1.Text = "What is Tallahassee?"
            cmd_response2.Text = "What is Santa Fe?"
            cmd_response3.Text = "What is Boston?"
            tmr_timer.Enabled = True
        End If
        If cmd_r1c5c2.Text = "$800" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "3D features have been recently added to this portable game console."
            cmd_response1.Text = "What is PS Vita?"
            cmd_response2.Text = "What is Nintendo DS?"
            cmd_response3.Text = "What is Dingoo?"
            tmr_timer.Enabled = True
        End If
    End Sub
    Private Sub cmd_r1c5c3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_r1c5c3.Click
        If cmd_r1c5c3.Text = "$600" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "The name of this Alaskan capital brought about the phrase, 'Do you know?'"
            cmd_response1.Text = "What is Juneau?"
            cmd_response2.Text = "What is Helena?"
            cmd_response3.Text = "What is Salem?"
            tmr_timer.Enabled = True
        End If
        If cmd_r1c5c3.Text = "$1,200" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "This 'Super Entertainment System' was a popular 2nd generation console made by this company in the early 1990s"
            cmd_response1.Text = "What is Sony?"
            cmd_response2.Text = "What is Atari?"
            cmd_response3.Text = "What is Nintendo?"
            tmr_timer.Enabled = True
        End If
    End Sub
    Private Sub cmd_r1c5c4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_r1c5c4.Click
        If cmd_r1c5c4.Text = "$800" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "The World of Coca-Cola resides in this state capital."
            cmd_response1.Text = "What is Baton Rouge?"
            cmd_response2.Text = "What is Atlanta?"
            cmd_response3.Text = "What is Austin?"
            tmr_timer.Enabled = True
        End If
        If cmd_r1c5c4.Text = "$1,600" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "This was Sega's first console with a built in CD-Rom reader/player."
            cmd_response1.Text = "What is Dreamcast?"
            cmd_response2.Text = "What is Genesis?"
            cmd_response3.Text = "What is Saturn?"
            tmr_timer.Enabled = True
        End If
    End Sub
    Private Sub cmd_r1c5c5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_r1c5c5.Click
        If cmd_r1c5c5.Text = "$1,000" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "This state capital is the home of NHRA Drag Racing's most prestigious event, the U.S. Nationals and NASCAR's Brickyard 400, among others."
            cmd_response1.Text = "What is Indianapolis?"
            cmd_response2.Text = "What is Little Rock?"
            cmd_response3.Text = "What is St. Louis?"
            tmr_timer.Enabled = True
        End If
        If cmd_r1c5c5.Text = "$2,000" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "This pocket console was released in 1998 by SNK."
            cmd_response1.Text = "What is Neo Geo?"
            cmd_response2.Text = "What is Amiga?"
            cmd_response3.Text = "What is Wonderswan?"
            tmr_timer.Enabled = True
        End If
    End Sub
    Private Sub cmd_r1c6c1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_r1c6c1.Click
        If cmd_r1c6c1.Text = "$200" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "A pan, a filter, and a couple of quarts is all you need to do this common maintainance task."
            cmd_response1.Text = "What is rotating your tires?"
            cmd_response2.Text = "What is changing your oil?"
            cmd_response3.Text = "What is washing your car?"
            tmr_timer.Enabled = True
        End If
        If cmd_r1c6c1.Text = "$400" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "Finger lickin' good!"
            cmd_response1.Text = "What is KFC?"
            cmd_response2.Text = "What is Burger King?"
            cmd_response3.Text = "What is Taco Bell?"
            tmr_timer.Enabled = True
        End If
    End Sub
    Private Sub cmd_r1c6c2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_r1c6c2.Click
        If cmd_r1c6c2.Text = "$400" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "Harvey Firestone started a company selling a brand of these used on every automobile today."
            cmd_response1.Text = "What is Tires?"
            cmd_response2.Text = "What is Spark Plugs?"
            cmd_response3.Text = "What is Air Filters?"
            tmr_timer.Enabled = True
        End If
        If cmd_r1c6c2.Text = "$800" Then
            My.Computer.Audio.Play(My.Resources.JeopardyDailyDouble, AudioPlayMode.Background)
            MyDailyDoubleSecondWager = InputBox("You've selected a Daily Double! What would you like to wager? (Postive numbers only, no dollar signs or commas.")
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "America's Game."
            cmd_response1.Text = "What is The Newlywed Game?"
            cmd_response2.Text = "What is Wheel of Fortune?"
            cmd_response3.Text = "What is Millionaire?"
            tmr_timer.Enabled = True
        End If
    End Sub
    Private Sub cmd_r1c6c3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_r1c6c3.Click
        If cmd_r1c6c3.Text = "$600" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "Hamsters have recently made their appearance in several commercials for this car company."
            cmd_response1.Text = "What is Mazda?"
            cmd_response2.Text = "What is Subaru?"
            cmd_response3.Text = "What is Kia?"
            tmr_timer.Enabled = True
        End If
        If cmd_r1c6c3.Text = "$1,200" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "Reach out and touch someone."
            cmd_response1.Text = "What is Sprint?"
            cmd_response2.Text = "What is AT&T?"
            cmd_response3.Text = "What is Verizon?"
            tmr_timer.Enabled = True
        End If
    End Sub
    Private Sub cmd_r1c6c4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_r1c6c4.Click
        If cmd_r1c6c4.Text = "$800" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "Which brand of oil using the tagline 'It's not just oil, it's liquid engineering'."
            cmd_response1.Text = "What is Valvoline NextGen?"
            cmd_response2.Text = "What is Pennzoil?"
            cmd_response3.Text = "What is Castrol GTX?"
            tmr_timer.Enabled = True
        End If
        If cmd_r1c6c4.Text = "$1,600" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "From 1958, 'Look ma! No cavities!'."
            cmd_response1.Text = "What is Crest?"
            cmd_response2.Text = "What is Aquafresh?"
            cmd_response3.Text = "What is Colgate?"
            tmr_timer.Enabled = True
        End If
    End Sub
    Private Sub cmd_r1c6c5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_r1c6c5.Click
        If cmd_r1c6c5.Text = "$1,000" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "This type of fuel, used in Top Fuel Dragsters, has the chemical symbol CH3NO2."
            cmd_response1.Text = "What is Methanol?"
            cmd_response2.Text = "What is Nitromethane?"
            cmd_response3.Text = "What is Alcohol?"
            tmr_timer.Enabled = True
        End If
        If cmd_r1c6c5.Text = "$2,000" Then
            txt_answer.Show()
            cmd_response1.Show()
            cmd_response2.Show()
            cmd_response3.Show()
            cmd_pass.Show()
            txt_answer.Text = "Built for the road ahead."
            cmd_response1.Text = "What is Volkswagen?"
            cmd_response2.Text = "What is Mopar?"
            cmd_response3.Text = "What is Ford?"
            tmr_timer.Enabled = True
        End If
    End Sub

    Private Sub tmr_timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_timer.Tick
        lbl_time.Text = ResponseTimer.ToString
        If ResponseTimer = 0 Then
            tmr_timer.Enabled = False
            lbl_time.Text = "0"
            ResponseTimer = 15
            MsgBox("Sorry, out of time! You've lost $500. You can try the clue again!")
            lbl_score.Text = lbl_score.Text - 500
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
        Else
            ResponseTimer -= 1
        End If
    End Sub

    Private Sub cmd_finishr1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_finish.Click
        If lbl_r1c1.Text = "Technology" Then
            cmd_r1c1c1.Hide()
            cmd_r1c1c2.Hide()
            cmd_r1c1c3.Hide()
            cmd_r1c1c4.Hide()
            cmd_r1c1c5.Hide()
            cmd_r1c2c1.Hide()
            cmd_r1c2c2.Hide()
            cmd_r1c2c3.Hide()
            cmd_r1c2c4.Hide()
            cmd_r1c2c5.Hide()
            cmd_r1c3c1.Hide()
            cmd_r1c3c2.Hide()
            cmd_r1c3c3.Hide()
            cmd_r1c3c4.Hide()
            cmd_r1c3c5.Hide()
            cmd_r1c4c1.Hide()
            cmd_r1c4c2.Hide()
            cmd_r1c4c3.Hide()
            cmd_r1c4c4.Hide()
            cmd_r1c4c5.Hide()
            cmd_r1c5c1.Hide()
            cmd_r1c5c2.Hide()
            cmd_r1c5c3.Hide()
            cmd_r1c5c4.Hide()
            cmd_r1c5c5.Hide()
            cmd_r1c6c1.Hide()
            cmd_r1c6c2.Hide()
            cmd_r1c6c3.Hide()
            cmd_r1c6c4.Hide()
            cmd_r1c6c5.Hide()
            lbl_r1c1.Hide()
            lbl_r1c2.Hide()
            lbl_r1c3.Hide()
            lbl_r1c4.Hide()
            lbl_r1c5.Hide()
            lbl_r1c6.Hide()
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            cmd_begindouble.Show()
            MsgBox("Let's start the Double Jeopardy! Round! Click the 'Begin Double Jeopardy!' button to begin.")
        End If
        If lbl_r1c1.Text = "Fame Dogs" Then
            cmd_r1c1c1.Hide()
            cmd_r1c1c2.Hide()
            cmd_r1c1c3.Hide()
            cmd_r1c1c4.Hide()
            cmd_r1c1c5.Hide()
            cmd_r1c2c1.Hide()
            cmd_r1c2c2.Hide()
            cmd_r1c2c3.Hide()
            cmd_r1c2c4.Hide()
            cmd_r1c2c5.Hide()
            cmd_r1c3c1.Hide()
            cmd_r1c3c2.Hide()
            cmd_r1c3c3.Hide()
            cmd_r1c3c4.Hide()
            cmd_r1c3c5.Hide()
            cmd_r1c4c1.Hide()
            cmd_r1c4c2.Hide()
            cmd_r1c4c3.Hide()
            cmd_r1c4c4.Hide()
            cmd_r1c4c5.Hide()
            cmd_r1c5c1.Hide()
            cmd_r1c5c2.Hide()
            cmd_r1c5c3.Hide()
            cmd_r1c5c4.Hide()
            cmd_r1c5c5.Hide()
            cmd_r1c6c1.Hide()
            cmd_r1c6c2.Hide()
            cmd_r1c6c3.Hide()
            cmd_r1c6c4.Hide()
            cmd_r1c6c5.Hide()
            lbl_r1c1.Hide()
            lbl_r1c2.Hide()
            lbl_r1c3.Hide()
            lbl_r1c4.Hide()
            lbl_r1c5.Hide()
            lbl_r1c6.Hide()
            txt_answer.Hide()
            cmd_response1.Hide()
            cmd_response2.Hide()
            cmd_response3.Hide()
            cmd_pass.Hide()
            MsgBox("Alright, let's start the Final Jeopardy! Round! Click the 'Begin Final Jeopardy!' button to begin")
            cmd_beginfinal.Show()
        End If
    End Sub

    Private Sub cmd_begindouble_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_begindouble.Click
        cmd_r1c1c1.Text = "$400"
        cmd_r1c2c1.Text = "$400"
        cmd_r1c3c1.Text = "$400"
        cmd_r1c4c1.Text = "$400"
        cmd_r1c5c1.Text = "$400"
        cmd_r1c6c1.Text = "$400"
        cmd_r1c1c2.Text = "$800"
        cmd_r1c2c2.Text = "$800"
        cmd_r1c3c2.Text = "$800"
        cmd_r1c4c2.Text = "$800"
        cmd_r1c5c2.Text = "$800"
        cmd_r1c6c2.Text = "$800"
        cmd_r1c1c3.Text = "$1,200"
        cmd_r1c2c3.Text = "$1,200"
        cmd_r1c3c3.Text = "$1,200"
        cmd_r1c4c3.Text = "$1,200"
        cmd_r1c5c3.Text = "$1,200"
        cmd_r1c6c3.Text = "$1,200"
        cmd_r1c1c4.Text = "$1,600"
        cmd_r1c2c4.Text = "$1,600"
        cmd_r1c3c4.Text = "$1,600"
        cmd_r1c4c4.Text = "$1,600"
        cmd_r1c5c4.Text = "$1,600"
        cmd_r1c6c4.Text = "$1,600"
        cmd_r1c1c5.Text = "$2,000"
        cmd_r1c2c5.Text = "$2,000"
        cmd_r1c3c5.Text = "$2,000"
        cmd_r1c4c5.Text = "$2,000"
        cmd_r1c5c5.Text = "$2,000"
        cmd_r1c6c5.Text = "$2,000"
        lbl_r1c1.Text = "Fame Dogs"
        lbl_r1c2.Text = "You're Taped"
        lbl_r1c3.Text = "Energy Drinks"
        lbl_r1c4.Text = "Got Channels?"
        lbl_r1c5.Text = "Classic Consoles"
        lbl_r1c6.Text = "Slogans"
        Me.Text = "Double Jeopardy! Round"
        My.Computer.Audio.Play(My.Resources.Jeopardyboardfill, AudioPlayMode.Background)
        tmr_r1appear1.Enabled = True
        cmd_r1c1c1.Enabled = True
        cmd_r1c1c2.Enabled = True
        cmd_r1c1c3.Enabled = True
        cmd_r1c1c4.Enabled = True
        cmd_r1c1c5.Enabled = True
        cmd_r1c2c1.Enabled = True
        cmd_r1c2c2.Enabled = True
        cmd_r1c2c3.Enabled = True
        cmd_r1c2c4.Enabled = True
        cmd_r1c2c5.Enabled = True
        cmd_r1c3c1.Enabled = True
        cmd_r1c3c2.Enabled = True
        cmd_r1c3c3.Enabled = True
        cmd_r1c3c4.Enabled = True
        cmd_r1c3c5.Enabled = True
        cmd_r1c4c1.Enabled = True
        cmd_r1c4c2.Enabled = True
        cmd_r1c4c3.Enabled = True
        cmd_r1c4c4.Enabled = True
        cmd_r1c4c5.Enabled = True
        cmd_r1c5c1.Enabled = True
        cmd_r1c5c2.Enabled = True
        cmd_r1c5c3.Enabled = True
        cmd_r1c5c4.Enabled = True
        cmd_r1c5c5.Enabled = True
        cmd_r1c6c1.Enabled = True
        cmd_r1c6c2.Enabled = True
        cmd_r1c6c3.Enabled = True
        cmd_r1c6c4.Enabled = True
        cmd_r1c6c5.Enabled = True
    End Sub

    Private Sub cmd_beginfinal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_beginfinal.Click
        cmd_r1c1c1.Hide()
        cmd_r1c1c2.Hide()
        cmd_r1c1c3.Hide()
        cmd_r1c1c4.Hide()
        cmd_r1c1c5.Hide()
        cmd_r1c2c1.Hide()
        cmd_r1c2c2.Hide()
        cmd_r1c2c3.Hide()
        cmd_r1c2c4.Hide()
        cmd_r1c2c5.Hide()
        cmd_r1c3c1.Hide()
        cmd_r1c3c2.Hide()
        cmd_r1c3c3.Hide()
        cmd_r1c3c4.Hide()
        cmd_r1c3c5.Hide()
        cmd_r1c4c1.Hide()
        cmd_r1c4c2.Hide()
        cmd_r1c4c3.Hide()
        cmd_r1c4c4.Hide()
        cmd_r1c4c5.Hide()
        cmd_r1c5c1.Hide()
        cmd_r1c5c2.Hide()
        cmd_r1c5c3.Hide()
        cmd_r1c5c4.Hide()
        cmd_r1c5c5.Hide()
        cmd_r1c6c1.Hide()
        cmd_r1c6c2.Hide()
        cmd_r1c6c3.Hide()
        cmd_r1c6c4.Hide()
        cmd_r1c6c5.Hide()
        lbl_r1c1.Hide()
        lbl_r1c2.Hide()
        lbl_r1c3.Hide()
        lbl_r1c4.Hide()
        lbl_r1c5.Hide()
        lbl_r1c6.Hide()
        txt_answer.Hide()
        cmd_response1.Hide()
        cmd_response2.Hide()
        cmd_response3.Hide()
        cmd_pass.Hide()
        cmd_begindouble.Hide()
        cmd_beginfinal.Hide()
        Me.Text = "Final Jeopardy!"
        img_finaljeopardy.Show()
        MsgBox("It's Time for Final Jeopardy! The category is... Movie Directors.")
        myfinalwager = InputBox("Select your Final Jeopardy! Wager. Numbers only, no commas or punctuation. Remember the category is Directors of Movies.")
        MsgBox("Select, 'Final Jeopardy Clue' to begin. You have 30 seconds to think it out, then you'll make your response. Good Luck!")
        cmd_finaljeopardyclue.Show()
    End Sub

    Private Sub cmd_finaljeopardyclue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_finaljeopardyclue.Click
        Dim mythinkmusic As String
        mythinkmusic = MsgBox("Would you like to hear the Classic think music, or the Rock version? Select 'Yes' for Classic, 'No' for Rock.", vbYesNo)
        txt_answer.Show()
        txt_answer.Text = "This 57 year old Canadian film director had the top grossing movie of 2009, almost $350 million up from 2nd. Think hard...Lights! Camera! Action!"
        cmd_response1.Text = "Who is Michael Bay?"
        cmd_response2.Text = "Who is David Yates?"
        cmd_response3.Text = "Who is James Cameron?"
        cmd_response1.Show()
        cmd_response2.Show()
        cmd_response3.Show()
        cmd_response1.Enabled = False
        cmd_response2.Enabled = False
        cmd_response3.Enabled = False
        cmd_response1.Enabled = False
        If mythinkmusic = vbYes Then
            My.Computer.Audio.Play(My.Resources.Jeopardythinkmusic, AudioPlayMode.Background)
        End If
        If mythinkmusic = vbNo Then
            My.Computer.Audio.Play(My.Resources.Jeopardythinkmusicrock, AudioPlayMode.Background)
        End If
        tmr_final.Enabled = True
        cmd_finaljeopardyclue.Hide()
    End Sub

    Private Sub tmr_final_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_final.Tick
        lbl_time.Text = FinalTimer.ToString
        If FinalTimer = 0 Then
            tmr_final.Enabled = False
            lbl_time.Text = "0"
            MsgBox("Your time is up! Select an answer now...")
            cmd_response1.Enabled = True
            cmd_response2.Enabled = True
            cmd_response3.Enabled = True
        Else
            FinalTimer -= 1
        End If
    End Sub

    Private Sub cmd_quit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_quit.Click
        Dim quitresponse
        quitresponse = MsgBox("Are you sure you want to quit?", Buttons:=vbYesNo)
        If quitresponse = vbYes Then
            form_menu.Close()
            Me.Close()
            MsgBox("Thank you for playing Jason's Jeopardy! Have an awesome day!")
        End If
        If quitresponse = vbNo Then
            MsgBox("OK, then let's return to the game!")
        End If
    End Sub
End Class
