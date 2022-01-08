'Program:               (Final Project) String Military Alphabhet & Morse Convertor
'Programmer:            David Clark-Duffy
'Date:                  8.10.2015
'Description:           This application will take any string and convert 
'                       it to the military alphabet or morse code.

Public Class ConvertorForm

    Private Sub Form_load()

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'exit the program
        Me.Close()

    End Sub

    Private Sub ConvertButton_Click(sender As Object, e As EventArgs) Handles NatoButton.Click
        Dim dic As New Dictionary(Of Char, String) 'create dictionary for military alphabet

        dic.Add(CChar("a"), "Alfa")
        dic.Add(CChar("b"), "Bravo")
        dic.Add(CChar("c"), "Charlie")
        dic.Add(CChar("d"), "Delta")
        dic.Add(CChar("e"), "Echo")
        dic.Add(CChar("f"), "Foxtrot")
        dic.Add(CChar("g"), "Golf")
        dic.Add(CChar("h"), "Hotel")
        dic.Add(CChar("i"), "India")
        dic.Add(CChar("j"), "Juliett")
        dic.Add(CChar("k"), "Kilo")
        dic.Add(CChar("l"), "Lima")
        dic.Add(CChar("m"), "Mike")
        dic.Add(CChar("n"), "November")
        dic.Add(CChar("o"), "Oscar")
        dic.Add(CChar("p"), "Papa")
        dic.Add(CChar("q"), "Quebec")
        dic.Add(CChar("r"), "Romeo")
        dic.Add(CChar("s"), "Sierra")
        dic.Add(CChar("t"), "Tango")
        dic.Add(CChar("u"), "Uniform")
        dic.Add(CChar("v"), "Victor")
        dic.Add(CChar("w"), "Whiskey")
        dic.Add(CChar("x"), "Xray")
        dic.Add(CChar("y"), "Yankee")
        dic.Add(CChar("z"), "Zulu")
        dic.Add(CChar("0"), "Zero")
        dic.Add(CChar("1"), "One")
        dic.Add(CChar("2"), "Two")
        dic.Add(CChar("3"), "Three")
        dic.Add(CChar("4"), "Four")
        dic.Add(CChar("5"), "Five")
        dic.Add(CChar("6"), "Six")
        dic.Add(CChar("7"), "Seven")
        dic.Add(CChar("8"), "Eight")
        dic.Add(CChar("9"), "Nine")
        dic.Add(CChar("~"), "Tilde")
        dic.Add(CChar("@"), "At")
        dic.Add(CChar("#"), "Pound")
        dic.Add(CChar("$"), "Dollar")
        dic.Add(CChar("%"), "Percent")
        dic.Add(CChar("^"), "Caret")
        dic.Add(CChar("&"), "Ampersand")
        dic.Add(CChar("*"), "Asterisk")
        dic.Add(CChar("("), "LeftParenthesis")
        dic.Add(CChar(")"), "RightParenthesis")
        dic.Add(CChar("-"), "Dash")
        dic.Add(CChar("_"), "Underscore")
        dic.Add(CChar("+"), "Plus")
        dic.Add(CChar("?"), "QuestionMark")
        dic.Add(CChar("!"), "ExclaimationMark")
        dic.Add(CChar(">"), "GreaterThan")
        dic.Add(CChar("<"), "LessThan")
        dic.Add(CChar("."), "Period")
        dic.Add(CChar(","), "Comma")
        dic.Add(CChar(":"), "Colon")
        dic.Add(CChar(";"), "SemiColon")
        dic.Add(CChar("["), "LeftSquareBracket")
        dic.Add(CChar("]"), "RightSquareBracket")
        dic.Add(CChar("{"), "LeftCurlyBracket")
        dic.Add(CChar("}"), "RightCurlyBracket")
        dic.Add(CChar("/"), "ForwardSlash")
        dic.Add(CChar("\"), "BackSlash")
        dic.Add(CChar("|"), "Pipe")
        dic.Add(CChar("'"), "SingleQuote")
        dic.Add(CChar(""""), "DoubleQuote")
        dic.Add(CChar("`"), "BackTick")
        dic.Add(CChar(" "), "Space")

        If StringTextBox.Text <> "" Then 'if textbox is not blank then continue
            Try
                Dim input As String 'create string to hold user data
                input = StringTextBox.Text 'assign textbox value to string variable
                input = input.ToLower() 'turn all characters to lower case

                Dim outputBuilder As New System.Text.StringBuilder 'create a string builder


                For Each c As Char In input 'for each character in the string
                    outputBuilder.Append(dic(c).ToString & "-") 'add dictionary look up plus a dash
                Next

                'remove last character of string to clear extra dash
                Dim msgboxString As String
                msgboxString = outputBuilder.ToString

                msgboxString = msgboxString.Substring(0, msgboxString.Length - 1) 'start at first position and go to end minus one character
                MessageBox.Show(msgboxString, "Nato Conversion", MessageBoxButtons.OK, MessageBoxIcon.Information) 'use substring to populate msg box

            Catch invalidchars As Exception 'check for special characters and any other exception
                MessageBox.Show("Please remove any special alt characters.", "Special characters detected!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        Else 'if textbox is blank then prompt with an error
            MessageBox.Show("Please enter a string to be converted.", "Blank Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'close the program
        Me.Close()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'show the about form
        AboutBoxForm.ShowDialog()

    End Sub

    Private Sub StringToNatoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StringToNatoToolStripMenuItem.Click
        Dim dic As New Dictionary(Of Char, String) 'create dictionary for military alphabet

        dic.Add(CChar("a"), "Alfa")
        dic.Add(CChar("b"), "Bravo")
        dic.Add(CChar("c"), "Charlie")
        dic.Add(CChar("d"), "Delta")
        dic.Add(CChar("e"), "Echo")
        dic.Add(CChar("f"), "Foxtrot")
        dic.Add(CChar("g"), "Golf")
        dic.Add(CChar("h"), "Hotel")
        dic.Add(CChar("i"), "India")
        dic.Add(CChar("j"), "Juliett")
        dic.Add(CChar("k"), "Kilo")
        dic.Add(CChar("l"), "Lima")
        dic.Add(CChar("m"), "Mike")
        dic.Add(CChar("n"), "November")
        dic.Add(CChar("o"), "Oscar")
        dic.Add(CChar("p"), "Papa")
        dic.Add(CChar("q"), "Quebec")
        dic.Add(CChar("r"), "Romeo")
        dic.Add(CChar("s"), "Sierra")
        dic.Add(CChar("t"), "Tango")
        dic.Add(CChar("u"), "Uniform")
        dic.Add(CChar("v"), "Victor")
        dic.Add(CChar("w"), "Whiskey")
        dic.Add(CChar("x"), "Xray")
        dic.Add(CChar("y"), "Yankee")
        dic.Add(CChar("z"), "Zulu")
        dic.Add(CChar("0"), "Zero")
        dic.Add(CChar("1"), "One")
        dic.Add(CChar("2"), "Two")
        dic.Add(CChar("3"), "Three")
        dic.Add(CChar("4"), "Four")
        dic.Add(CChar("5"), "Five")
        dic.Add(CChar("6"), "Six")
        dic.Add(CChar("7"), "Seven")
        dic.Add(CChar("8"), "Eight")
        dic.Add(CChar("9"), "Nine")
        dic.Add(CChar("~"), "Tilde")
        dic.Add(CChar("@"), "At")
        dic.Add(CChar("#"), "Pound")
        dic.Add(CChar("$"), "Dollar")
        dic.Add(CChar("%"), "Percent")
        dic.Add(CChar("^"), "Caret")
        dic.Add(CChar("&"), "Ampersand")
        dic.Add(CChar("*"), "Asterisk")
        dic.Add(CChar("("), "LeftParenthesis")
        dic.Add(CChar(")"), "RightParenthesis")
        dic.Add(CChar("-"), "Dash")
        dic.Add(CChar("_"), "Underscore")
        dic.Add(CChar("+"), "Plus")
        dic.Add(CChar("?"), "QuestionMark")
        dic.Add(CChar("!"), "ExclaimationMark")
        dic.Add(CChar(">"), "GreaterThan")
        dic.Add(CChar("<"), "LessThan")
        dic.Add(CChar("."), "Period")
        dic.Add(CChar(","), "Comma")
        dic.Add(CChar(":"), "Colon")
        dic.Add(CChar(";"), "SemiColon")
        dic.Add(CChar("["), "LeftSquareBracket")
        dic.Add(CChar("]"), "RightSquareBracket")
        dic.Add(CChar("{"), "LeftCurlyBracket")
        dic.Add(CChar("}"), "RightCurlyBracket")
        dic.Add(CChar("/"), "ForwardSlash")
        dic.Add(CChar("\"), "BackSlash")
        dic.Add(CChar("|"), "Pipe")
        dic.Add(CChar("'"), "SingleQuote")
        dic.Add(CChar(""""), "DoubleQuote")
        dic.Add(CChar("`"), "BackTick")
        dic.Add(CChar(" "), "Space")

        If StringTextBox.Text <> "" Then 'if textbox is not blank then continue
            Try
                Dim input As String 'create string to hold user data
                input = StringTextBox.Text 'assign textbox value to string variable
                input = input.ToLower() 'turn all characters to lower case

                Dim outputBuilder As New System.Text.StringBuilder 'create a string builder


                For Each c As Char In input 'for each character in the string
                    outputBuilder.Append(dic(c).ToString & "-") 'add dictionary look up plus a dash
                Next

                'remove last character of string to clear extra dash
                Dim msgboxString As String
                msgboxString = outputBuilder.ToString

                msgboxString = msgboxString.Substring(0, msgboxString.Length - 1) 'start at first position and go to end minus one character
                MessageBox.Show(msgboxString, "Nato Conversion", MessageBoxButtons.OK, MessageBoxIcon.Information) 'use substring to populate msg box

            Catch invalidchars As Exception 'check for special characters and any other exception
                MessageBox.Show("Please remove any special alt characters.", "Special characters detected!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        Else 'if textbox is blank then prompt with an error
            MessageBox.Show("Please enter a string to be converted.", "Blank Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'close the program
        Me.Close()

    End Sub

    Private Sub AboutToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'show the about form
        AboutBoxForm.ShowDialog()


    End Sub

    Private Sub MorseButton_Click(sender As Object, e As EventArgs) Handles MorseButton.Click
        Dim strtomorse As New Dictionary(Of Char, String) 'create dictionary for morse code

        strtomorse.Add(CChar("a"), ".-")
        strtomorse.Add(CChar("b"), "-...")
        strtomorse.Add(CChar("c"), "-.-.")
        strtomorse.Add(CChar("d"), "-..")
        strtomorse.Add(CChar("e"), ".")
        strtomorse.Add(CChar("f"), "..-.")
        strtomorse.Add(CChar("g"), "--.")
        strtomorse.Add(CChar("h"), "....")
        strtomorse.Add(CChar("i"), "..")
        strtomorse.Add(CChar("j"), ".---")
        strtomorse.Add(CChar("k"), "-.-")
        strtomorse.Add(CChar("l"), ".-..")
        strtomorse.Add(CChar("m"), "--")
        strtomorse.Add(CChar("n"), "-.")
        strtomorse.Add(CChar("o"), "---")
        strtomorse.Add(CChar("p"), ".--.")
        strtomorse.Add(CChar("q"), "--.-")
        strtomorse.Add(CChar("r"), ".-.")
        strtomorse.Add(CChar("s"), "...")
        strtomorse.Add(CChar("t"), "-")
        strtomorse.Add(CChar("u"), "..-")
        strtomorse.Add(CChar("v"), "...-")
        strtomorse.Add(CChar("w"), ".--")
        strtomorse.Add(CChar("x"), "-..-")
        strtomorse.Add(CChar("y"), "-.--")
        strtomorse.Add(CChar("z"), "--..")
        strtomorse.Add(CChar("0"), "-----")
        strtomorse.Add(CChar("1"), ".----")
        strtomorse.Add(CChar("2"), "..---")
        strtomorse.Add(CChar("3"), "...--")
        strtomorse.Add(CChar("4"), "....-")
        strtomorse.Add(CChar("5"), ".....")
        strtomorse.Add(CChar("6"), "-....")
        strtomorse.Add(CChar("7"), "--...")
        strtomorse.Add(CChar("8"), "---..")
        strtomorse.Add(CChar("9"), "----.")
        strtomorse.Add(CChar("."), ".-.-.-")
        strtomorse.Add(CChar(","), "--..--")
        strtomorse.Add(CChar(":"), "---...")
        strtomorse.Add(CChar("?"), "..--..")
        strtomorse.Add(CChar("-"), "-....-")
        strtomorse.Add(CChar(" "), "       ") 'seven spaces

        If StringTextBox.Text <> "" Then
            Try
                Dim input As String 'create string to hold user data
                input = StringTextBox.Text 'assign textbox value to string variable
                input = input.ToLower() 'turn all characters to lower case

                Dim outputBuilder As New System.Text.StringBuilder 'create a string builder

                For Each c As Char In input 'for each character in the string

                    outputBuilder.Append(strtomorse(c).ToString) 'add dictionary look up value
                Next

                MessageBox.Show(outputBuilder.ToString, "Morse Conversion", MessageBoxButtons.OK, MessageBoxIcon.Information) 'prompt user with msgbox results

            Catch Ex As Exception 'catch any and all errors, especially special characters that we don't support
                MessageBox.Show("Please remove any special characters.", "Failed morse conversion!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try

        Else
            MessageBox.Show("Please enter a string to be converted.", "Blank Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning) 'warn user about blank entry
        End If

    End Sub

    Private Sub StringToMorseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StringToMorseToolStripMenuItem.Click
        Dim strtomorse As New Dictionary(Of Char, String) 'create dictionary for morse code

        strtomorse.Add(CChar("a"), ".-")
        strtomorse.Add(CChar("b"), "-...")
        strtomorse.Add(CChar("c"), "-.-.")
        strtomorse.Add(CChar("d"), "-..")
        strtomorse.Add(CChar("e"), ".")
        strtomorse.Add(CChar("f"), "..-.")
        strtomorse.Add(CChar("g"), "--.")
        strtomorse.Add(CChar("h"), "....")
        strtomorse.Add(CChar("i"), "..")
        strtomorse.Add(CChar("j"), ".---")
        strtomorse.Add(CChar("k"), "-.-")
        strtomorse.Add(CChar("l"), ".-..")
        strtomorse.Add(CChar("m"), "--")
        strtomorse.Add(CChar("n"), "-.")
        strtomorse.Add(CChar("o"), "---")
        strtomorse.Add(CChar("p"), ".--.")
        strtomorse.Add(CChar("q"), "--.-")
        strtomorse.Add(CChar("r"), ".-.")
        strtomorse.Add(CChar("s"), "...")
        strtomorse.Add(CChar("t"), "-")
        strtomorse.Add(CChar("u"), "..-")
        strtomorse.Add(CChar("v"), "...-")
        strtomorse.Add(CChar("w"), ".--")
        strtomorse.Add(CChar("x"), "-..-")
        strtomorse.Add(CChar("y"), "-.--")
        strtomorse.Add(CChar("z"), "--..")
        strtomorse.Add(CChar("0"), "-----")
        strtomorse.Add(CChar("1"), ".----")
        strtomorse.Add(CChar("2"), "..---")
        strtomorse.Add(CChar("3"), "...--")
        strtomorse.Add(CChar("4"), "....-")
        strtomorse.Add(CChar("5"), ".....")
        strtomorse.Add(CChar("6"), "-....")
        strtomorse.Add(CChar("7"), "--...")
        strtomorse.Add(CChar("8"), "---..")
        strtomorse.Add(CChar("9"), "----.")
        strtomorse.Add(CChar("."), ".-.-.-")
        strtomorse.Add(CChar(","), "--..--")
        strtomorse.Add(CChar(":"), "---...")
        strtomorse.Add(CChar("?"), "..--..")
        strtomorse.Add(CChar("-"), "-....-")
        strtomorse.Add(CChar(" "), "       ") 'seven spaces

        If StringTextBox.Text <> "" Then
            Try
                Dim input As String 'create string to hold user data
                input = StringTextBox.Text 'assign textbox value to string variable
                input = input.ToLower() 'turn all characters to lower case

                Dim outputBuilder As New System.Text.StringBuilder 'create a string builder

                For Each c As Char In input 'for each character in the string

                    outputBuilder.Append(strtomorse(c).ToString) 'add dictionary look up value
                Next

                MessageBox.Show(outputBuilder.ToString, "Morse Conversion", MessageBoxButtons.OK, MessageBoxIcon.Information) 'prompt user with msgbox results

            Catch Ex As Exception 'catch any and all errors, especially special characters that we don't support
                MessageBox.Show("Please remove any special characters.", "Failed morse conversion!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try

        Else
            MessageBox.Show("Please enter a string to be converted.", "Blank Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning) 'warn user about blank entry
        End If
    End Sub

    Private Sub ConvertorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
