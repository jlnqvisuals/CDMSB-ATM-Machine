
'SOURCE CODE V.1.1 | CDMSB ATM SYSTEMS (C) 2023 | BSCPE 1A
'GROUP MEMBERS: | QUILINO | CABERTE | BUENAVENTURA | DAGATAN | TRERO | BUENDIA | CHAVEZ |
'ADMIN ACCESS ONLY:  12340 = SHUTDOWN,  2321 = UNDER MAINTENANCE, 143 = SHOW GROUP MEMBERS

Imports System.Media

'DATA ALGORITHM DECLARATION
Module Module1

    Dim UserAccount As ATMUserAccount() = {}
    Dim UserData As Integer = 0
    Dim UserIdentHold As Integer = -1
    Dim UserChoice As String

    'DECLARATION # OF POTENTIAL ATM USER/ CONSUMERS
    Sub ATMconsumers()
        UserAccount = New ATMUserAccount(100) {}
    End Sub

    'ATM SPLASH SCREEN (COMPLETED)
    Sub Main()

        Dim ATMBoot As New System.Media.SoundPlayer("C:\ATM Machine Assets\ATMBoot.wav")

        ATMBoot.Play()

        Console.BackgroundColor = ConsoleColor.Black
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.Clear()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("                                                                                          ")
        Console.WriteLine("                                                                                          ")
        Console.WriteLine("                  =========  C O L E G I O   D E   M O N T A L B A N  =========           ")
        Console.WriteLine("                   _______     ________     ____   ____    ________    ________           ")
        Console.WriteLine("                  /~~~~~~~\   |~~~~~~~~\   |~~~~\ /~~~~|  |~~~~~~~~|  |~~~~~~~~\          ")
        Console.WriteLine("                 |~~/```\~~\  |~~|``\~~~|  |~~~~~`~~~~~|  |~~|_____   |~~|__|~~|          ")
        Console.WriteLine("                 |~~|    ___  |~~|   |~~|  |~~|\~~~/|~~|  |~~~~~~~~|  |~~~~~~~<           ")
        Console.WriteLine("                 |~~\___/~~/  |~~|__/~~~|  |~~| ``` |~~|   _____|~~|  |~~|__|~~|          ")
        Console.WriteLine("                  \~~~~~~~/   |~~~~~~~~/   |~~|     |~~|  |~~~~~~~~|  |~~~~~~~~/          ")
        Console.WriteLine("                   ```````    `````````     ``       ``    ````````    ````````           ")
        Console.WriteLine("                            =====  S T U D E N T ' S   B A N K  =====                     ")
        Console.WriteLine("                               ____________________________________                       ")
        Console.WriteLine("                              (   A  T  M    M  A  C  H  I  N  E   )                      ")
        Console.WriteLine("                               ````````````````````````````````````                       ")
        Console.WriteLine("                                                                                          ")
        Console.WriteLine("                QUILINO | CABERTE | BUENAVENTURA                        CPEPROG 2         ")
        Console.WriteLine("                DAGATAN | TRERO | BUENDIA | CHAVEZ                          V 1.1         ")
        Console.WriteLine("                                                                                          ")
        Console.WriteLine("                         (C) COPYRIGHT 2023 | A.Y. 2022- 2023 | BSCPE 1A                  ")

        Threading.Thread.Sleep("1800")

        Console.Clear()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("              _______________________________________________________________________     ")
        Console.WriteLine("             | \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ |  _  |  X  |    ")
        Console.WriteLine("             |```````````````````````````````````````````````````````````````````````|    ")
        Console.WriteLine("             |    C D M   S T U D E N T ' S   B A N K  |    A T M   M A C H I N E    |    ")
        Console.WriteLine("             | __________________________  _________________________________________ |    ")
        Console.WriteLine("             |                                                                       |    ")
        Console.WriteLine("             |           ________        |                                           |    ")
        Console.WriteLine("             |       ___/=======/|__     |     _________________                     |    ")
        Console.WriteLine("             |      /__|-------|/__/|    |    | W E L C O M E ! |________            |    ")
        Console.WriteLine("             |     |  __________   ||    |     ``````| C D M I A N ' S ! |           |    ")
        Console.WriteLine("             |     | |``````````|O ||    |            ```````````````````            |    ")
        Console.WriteLine("             |     | |  A T M . |O ||    |      TO BEGIN USING ATM's                 |    ")
        Console.WriteLine("             |     | |__________|O ||    |      SERVICES, PRESS ANY KEY              |    ")
        Console.WriteLine("             |     | ````````````  |/|   |      TO PROCEED ATM USER DASHBOARD.       |    ")
        Console.WriteLine("             |    / ```````````````/ /   |                                           |    ")
        Console.WriteLine("             |    [TT_________TTTT] /    |      ___________                          |    ")
        Console.WriteLine("             |    [_______======__]/     |     | C D M S B |                         |    ")
        Console.WriteLine("             |                           |      ```````````                          |    ")
        Console.WriteLine("             |                           |                                           |    ")
        Console.WriteLine("             |_______________________________________________________________________|    ")
        Console.WriteLine("             | ////////// (C) COPYRIGHT 2023 | A.Y. 2022- 2023 | BSCPE 1A ////////// |    ")
        Console.WriteLine("              ```````````````````````````````````````````````````````````````````````     ")
        Console.WriteLine()
        Console.Write("                                                 ")
        Console.ReadKey()

        ATMconsumers()
        ATMloginDashboard()
    End Sub

    'ATM USER LOGIN DASHBOARD (COMPLETED)
    Sub ATMloginDashboard()

        Dim UInProceed As New SoundPlayer("C:\ATM Machine Assets\UInProceed.wav")
        UInProceed.Play()

        Console.Beep()
        Console.Beep()
        Console.Beep()

        Console.Clear()
        Console.Beep()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("              _______________________________________________________________________     ")
        Console.WriteLine("             | \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ |  _  |  X  |    ")
        Console.WriteLine("             |```````````````````````````````````````````````````````````````````````|    ")
        Console.WriteLine("             |    C D M   S T U D E N T ' S   B A N K  |    A T M   M A C H I N E    |    ")
        Console.WriteLine("             | ________________________   __________________________________________ |    ")
        Console.WriteLine("             |                          |                                            |    ")
        Console.WriteLine("             |          ______          |     _________________                      |    ")
        Console.WriteLine("             |         //````\\         |    | A T M   U S E R |________             |    ")
        Console.WriteLine("             |       _||______||_       |     ``````| D A S H B O A R D |            |    ")
        Console.WriteLine("             |      /||||||||||||\      |            ```````````````````             |    ")
        Console.WriteLine("             |      ||||||||||||||      |        ________________________            |    ")
        Console.WriteLine("             |      ||||||()||||||      |       | 1.) LOGIN              |           |    ")
        Console.WriteLine("             |      ||||||[]||||||      |        `````````````````````````           |    ")
        Console.WriteLine("             |      ||----------||      |        ________________________            |    ")
        Console.WriteLine("             |       ````````````       |       | 2.) REGISTER           |           |    ")
        Console.WriteLine("             |    S E C U R E D         |        `````````````````````````           |    ")
        Console.WriteLine("             |          B A N K I N G   |                                            |    ")
        Console.WriteLine("             |                          |                                            |    ")
        Console.WriteLine("             |_______________________________________________________________________|    ")
        Console.WriteLine("             | ////////// (C) COPYRIGHT 2023 | A.Y. 2022- 2023 | BSCPE 1A ////////// |    ")
        Console.WriteLine("              ```````````````````````````````````````````````````````````````````````     ")
        Console.WriteLine()
        Console.Write("                >>> PLEASE ENTER YOUR INPUT HERE: ")

        UserChoice = Console.ReadLine()
        Select Case UserChoice

            Case 2321
                Umaintenance()
            Case 143
                CRDS()
            Case 1
                UserLogin()
            Case 2
                UserRegister()
            Case 12340

                Dim ATMshutdown As New SoundPlayer("C:\ATM Machine Assets\ATMshutdown.wav")
                ATMshutdown.Play()

                Console.Beep()
                Console.Beep()

                Console.Clear()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine("                                                                                           ")
                Console.WriteLine("                                                                                           ")
                Console.WriteLine("                   =========  C O L E G I O   D E   M O N T A L B A N  =========           ")
                Console.WriteLine("                    _______     ________     ____   ____    ________    ________           ")
                Console.WriteLine("                   /~~~~~~~\   |~~~~~~~~\   |~~~~\ /~~~~|  |~~~~~~~~|  |~~~~~~~~\          ")
                Console.WriteLine("                  |~~/```\~~\  |~~|``\~~~|  |~~~~~`~~~~~|  |~~|_____   |~~|__|~~|          ")
                Console.WriteLine("                  |~~|    ___  |~~|   |~~|  |~~|\~~~/|~~|  |~~~~~~~~|  |~~~~~~~<           ")
                Console.WriteLine("                  |~~\___/~~/  |~~|__/~~~|  |~~| ``` |~~|   _____|~~|  |~~|__|~~|          ")
                Console.WriteLine("                   \~~~~~~~/   |~~~~~~~~/   |~~|     |~~|  |~~~~~~~~|  |~~~~~~~~/          ")
                Console.WriteLine("                    ```````    `````````     ``       ``    ````````    ````````           ")
                Console.WriteLine("                             =====  S T U D E N T ' S   B A N K  =====                     ")
                Console.WriteLine("                                ____________________________________                       ")
                Console.WriteLine("                               (   A  T  M    M  A  C  H  I  N  E   )                      ")
                Console.WriteLine("                                ````````````````````````````````````                       ")
                Console.WriteLine("              ----------------------------------------------------------------------       ")
                Console.WriteLine("                                                                                           ")
                Console.WriteLine("                                    S H U T T I N G   D O W N . . .                        ")
                Console.WriteLine("                                                                                           ")
                Console.WriteLine("                                                                                           ")
                Threading.Thread.Sleep("3500")

                Console.Clear()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine("                    _______     ________     ____   ____    ________    ________           ")
                Console.WriteLine("                   /~~~~~~~\   |~~~~~~~~\   |~~~~\ /~~~~|  |~~~~~~~~|  |~~~~~~~~\          ")
                Console.WriteLine("                  |~~/```\~~\  |~~|``\~~~|  |~~~~~`~~~~~|  |~~|_____   |~~|__|~~|          ")
                Console.WriteLine("                  |~~|    ___  |~~|   |~~|  |~~|\~~~/|~~|  |~~~~~~~~|  |~~~~~~~<           ")
                Console.WriteLine("                  |~~\___/~~/  |~~|__/~~~|  |~~| ``` |~~|   _____|~~|  |~~|__|~~|          ")
                Console.WriteLine("                   \~~~~~~~/   |~~~~~~~~/   |~~|     |~~|  |~~~~~~~~|  |~~~~~~~~/          ")
                Console.WriteLine("                    ```````    `````````     ``       ``    ````````    ````````           ")
                Console.WriteLine("                                                                                           ")
                Console.WriteLine("                 QUILINO | CABERTE | BUENAVENTURA                        CPEPROG 2         ")
                Console.WriteLine("                 DAGATAN | TRERO | BUENDIA | CHAVEZ                          V 1.1         ")
                Console.WriteLine("                                                                                           ")
                Console.WriteLine("                          (C) COPYRIGHT 2023 | A.Y. 2022- 2023 | BSCPE 1A                  ")
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine("                               you can now safely turn off your computer")
                Threading.Thread.Sleep("2800")

                End
            Case Else

                Dim UInError As New SoundPlayer("C:\ATM Machine Assets\UInError.wav")
                UInError.Play()

                Console.Clear()
                Console.Clear()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine("              _______________________________________________________________________     ")
                Console.WriteLine("             | \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ |  _  |  X  |    ")
                Console.WriteLine("             |```````````````````````````````````````````````````````````````````````|    ")
                Console.WriteLine("             |    C D M   S T U D E N T ' S   B A N K  |    A T M   M A C H I N E    |    ")
                Console.WriteLine("             | _____________________________________________________________________ |    ")
                Console.WriteLine("             |                           ________                                    |    ")
                Console.WriteLine("             |                       ___/=======/|__                                 |    ")
                Console.WriteLine("             |                      /__|-------|/__/|                                |    ")
                Console.WriteLine("             |                     |  __________   ||                                |    ")
                Console.WriteLine("             |              1101011| |``````````|O ||  1 100101/`\                   |    ")
                Console.WriteLine("             |              ```1101| |  X __ X  |O ||  ````011/   \????              |    ")
                Console.WriteLine("             |                 `110| |__________|O ||       0/  |  \??????? ?        |    ")
                Console.WriteLine("             |                  ```| ````````````  |/|      /   |   \??``````        |    ")
                Console.WriteLine("             |                    / ```````````````/ /     /    .    \               |    ")
                Console.WriteLine("             |                    [TT_________TTTT] /      ```````````               |    ")
                Console.WriteLine("             |                    [_______======__]/                                 |    ")
                Console.WriteLine("             |            ________________________________________________           |    ")
                Console.WriteLine("             |           |       USER INPUT ERROR! PLEASE TRY AGAIN!      |          |    ")
                Console.WriteLine("             |            ````````````````````````````````````````````````           |    ")
                Console.WriteLine("             |_______________________________________________________________________|    ")
                Console.WriteLine("             | ////////// (C) COPYRIGHT 2023 | A.Y. 2022- 2023 | BSCPE 1A ////////// |    ")
                Console.WriteLine("              ```````````````````````````````````````````````````````````````````````     ")
                Threading.Thread.Sleep("2880")

                ATMloginDashboard()
        End Select
    End Sub

    'ATM UNDER MAINTENANCE (COMPLETED)
    Sub Umaintenance()

        Dim UMaintenancePrompt As New SoundPlayer("C:\ATM Machine Assets\UMaintenancePrompt.wav")
        UMaintenancePrompt.Play()
        Dim UmaintenanceKEY As String

        Console.Beep()
        Console.Beep()

        Console.Clear()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("              _______________________________________________________________________     ")
        Console.WriteLine("             | \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ |  _  |  X  |    ")
        Console.WriteLine("             |```````````````````````````````````````````````````````````````````````|    ")
        Console.WriteLine("             |    C D M   S T U D E N T ' S   B A N K  |    A T M   M A C H I N E    |    ")
        Console.WriteLine("             | _____________________________________________________________________ |    ")
        Console.WriteLine("             |                                                                       |    ")
        Console.WriteLine("             |         ________                   _____________________________      |    ")
        Console.WriteLine("             |     ___/=======/|__               | C D M S B   A D V I S O R Y |     |    ")
        Console.WriteLine("             |    /__|-------|/__/|  _ _          `````````````````````````````      |    ")
        Console.WriteLine("             |   |  __________   || (( )) /0\    WE ARE CURRENTLY CONDUCTING         |    ")
        Console.WriteLine("             |   | |``````````|O ||  \Y/  )|(    SYSTEM MAINTENANCE DURING THIS      |    ")
        Console.WriteLine("             |   | | SORRY :/ |O ||  |!|  (|)    TIME. ATM CARDHOLDERS WILL NOT      |    ")
        Console.WriteLine("             |   | |__________|O ||  |!| // \\   BE ABLE TO WITHDRAW, DEPOSIT,       |    ")
        Console.WriteLine("             |   | ````````````  |/| |!| !! !!   AND CHECK BALANCE THROUGH ATM's.    |    ")
        Console.WriteLine("             |  / ```````````````/ / (o) \\ //   WE WILL SEND UPDATES AS SOON AS     |    ")
        Console.WriteLine("             |  [TT_________TTTT] /              SERVICES HAVE BEEN RESTORED.        |    ")
        Console.WriteLine("             |  [_______======__]/                                                   |    ")
        Console.WriteLine("             |                                   WE APOLOGIZE FOR THE INCONVENIENCE  |    ")
        Console.WriteLine("             |                                                                       |    ")
        Console.WriteLine("             |_______________________________________________________________________|    ")
        Console.WriteLine("             | ////////// (C) COPYRIGHT 2023 | A.Y. 2022- 2023 | BSCPE 1A ////////// |    ")
        Console.WriteLine("              ```````````````````````````````````````````````````````````````````````     ")
        Console.WriteLine()
        Console.Write("                                                 ")

        UmaintenanceKEY = Console.ReadLine()

        If UmaintenanceKEY = 2321 Then
            ATMloginDashboard()
        Else
            Umaintenance()
        End If
    End Sub
    Sub CRDS()
        Dim A As New SoundPlayer("C:\ATM Machine Assets\A.wav")
        A.Play()
        Console.WriteLine("            CDMSB MEMBERS:  QUILINO | CABERTE | BUENAVENTURA")
        Console.WriteLine("                            DAGATAN | TRERO | BUENDIA | CHAVEZ")
        Threading.Thread.Sleep("3200")
        ATMloginDashboard()
    End Sub


    'ATM USER REGISTRATION (COMPLETED)
    Sub UserRegister()
        Dim UserPin As String 'TN: did not convert to double to prevent user input error
        Dim UserName As String

        Dim ATMreg As New SoundPlayer("C:\ATM Machine Assets\ATMreg.wav")
        ATMreg.Play()

        Console.Beep()
        Console.Beep()

        Console.Clear()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("              _______________________________________________________________________     ")
        Console.WriteLine("             | \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ |  _  |  X  |    ")
        Console.WriteLine("             |```````````````````````````````````````````````````````````````````````|    ")
        Console.WriteLine("             |                                                                       |    ")
        Console.WriteLine("             |               - C O L E G I O   D E   M O N T A L B A N -             |    ")
        Console.WriteLine("             |                     - S T U D E N T ' S   B A N K -                   |    ")
        Console.WriteLine("             |     _____    _____   _____   _   ____   _______   _____    _____      |    ")
        Console.WriteLine("             |    |  _  \  |  ___| |  ___| |_| |  __| |__   __| |  ___|  |  _  \     |    ")
        Console.WriteLine("             |    | |_|  | | |___  | | __   _  | |__     | |    | |___   | |_|  |    |    ")
        Console.WriteLine("             |    |  _  /  |  ___| | ||  | | | |__  |    | |    |  ___|  |  _  /     |    ")
        Console.WriteLine("             |    | | \ \  | |___  | |_| | | |  __| |    | |    | |___   | | \ \     |    ")
        Console.WriteLine("             |    | |  | | |     | |     | | | |    |    | |    |     |  | |  | |    |    ")
        Console.WriteLine("             |     `    `   ``````  `````   `   `````     `      `````    `    `     |    ")
        Console.WriteLine("             |            ______________________________________________             |    ")
        Console.WriteLine("             |           [   A T M   U S E R   C R E D E N T I A L S    ]            |    ")
        Console.WriteLine("             |            ``````````````````````````````````````````````             |    ")
        Console.WriteLine("             |_______________________________________________________________________|    ")
        Console.WriteLine("             | ////////// (C) COPYRIGHT 2023 | A.Y. 2022- 2023 | BSCPE 1A ////////// |    ")
        Console.WriteLine("              ```````````````````````````````````````````````````````````````````````     ")
        Console.WriteLine()

        Console.Write("                >>> PLEASE ENTER DESIRED USERNAME: ")
        UserName = Console.ReadLine()

        Console.Write("                >>> PLEASE ENTER DESIRED PIN CODE: ")
        UserPin = TXTtoPIN()

        UIloading()
        UserAccount(UserData) = New ATMUserAccount(UserPin, UserName)
        UserData += 1

        'ACCOUNT SUCCESSFULY REGISTERED
        Dim Success As New SoundPlayer("C:\ATM Machine Assets\Success.wav")
        Success.Play()

        Console.Clear()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("              _______________________________________________________________________        ")
        Console.WriteLine("             | \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ |  _  |  X  |       ")
        Console.WriteLine("             |```````````````````````````````````````````````````````````````````````|       ")
        Console.WriteLine("             |    C D M   S T U D E N T ' S   B A N K  |    A T M   M A C H I N E    |       ")
        Console.WriteLine("             | ________________________   __________________________________________ |       ")
        Console.WriteLine("             |                          |                                            |       ")
        Console.WriteLine("             |                          |    _________________                       |       ")
        Console.WriteLine("             |    ___________________   |   | A T M   U S E R |_________             |       ")
        Console.WriteLine("             |     |______________|     |    `| R E G I S T R A T I O N |            |       ")
        Console.WriteLine("             |      | | ~~~~~~~ |       |      `````````````````````````             |       ")
        Console.WriteLine("             |      | | ~~~~~~~ |       |                                            |       ")
        Console.WriteLine("             |      | | ~~~~~~~ |       |    _____________________________           |       ")
        Console.WriteLine("             |      | | ~~~~~~~ |       |   | *ACCOUNT REGISTRATION       |          |       ")
        Console.WriteLine("             |      | | ~~~~~.  |       |   | CREATED SUCCESSFULLY!     __|    _     |       ")
        Console.WriteLine("             |      | |         |       |    `````````````````````````\| ____ //     |       ")
        Console.WriteLine("             |       ````````````       |                               | _  //|     |       ")
        Console.WriteLine("             |                          |                               | \\// |     |       ")
        Console.WriteLine("             |                          |                               |  \/  |     |       ")
        Console.WriteLine("             |                          |                                ``````      |       ")
        Console.WriteLine("             |_______________________________________________________________________|       ")
        Console.WriteLine("             | ////////// (C) COPYRIGHT 2023 | A.Y. 2022- 2023 | BSCPE 1A ////////// |       ")
        Console.WriteLine("              ```````````````````````````````````````````````````````````````````````        ")
        Threading.Thread.Sleep("1200")

        ATMloginDashboard()
    End Sub

    'ATM USER LOGIN (COMPLETED)
    Sub UserLogin()
        Dim UserPin As String


        Dim ATMlogin As New SoundPlayer("C:\ATM Machine Assets\ATMlogin.wav")
        ATMlogin.Play()

        Console.Beep()
        Console.Beep()

        Console.Clear()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("              _______________________________________________________________________     ")
        Console.WriteLine("             | \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ |  _  |  X  |    ")
        Console.WriteLine("             |```````````````````````````````````````````````````````````````````````|    ")
        Console.WriteLine("             |               - C O L E G I O   D E   M O N T A L B A N -             |    ")
        Console.WriteLine("             |                     - S T U D E N T ' S   B A N K -                   |    ")
        Console.WriteLine("             |                 _       _____   _____     _   __    _                 |    ")
        Console.WriteLine("             |                | |     |  _  | |  ___|   | | |  \  | |                |    ")
        Console.WriteLine("             |                | |     | | | | | | __    | | |   \ | |                |    ")
        Console.WriteLine("             |                | |___  | | | | | ||  |   | | | |\ \| |                |    ")
        Console.WriteLine("             |                |     | |  `` | | ``` |   | | | | \   |                |    ")
        Console.WriteLine("             |                 ``````  `````   `````     `   `   ````                |    ")
        Console.WriteLine("             |            ______________________________________________             |    ")
        Console.WriteLine("             |           [   A T M   U S E R   C R E D E N T I A L S    ]            |    ")
        Console.WriteLine("             |            ``````````````````````````````````````````````             |    ")
        Console.WriteLine("             |_______________________________________________________________________|    ")
        Console.WriteLine("             | ////////// (C) COPYRIGHT 2023 | A.Y. 2022- 2023 | BSCPE 1A ////////// |    ")
        Console.WriteLine("              ```````````````````````````````````````````````````````````````````````     ")

        Console.Write("                >>> PLEASE ENTER PIN CODE: ")
        UserPin = TXTtoPIN()

        UIloading()

        For i As Integer = 0 To UserData - 1
            If UserAccount(i).UserPINchecker(UserPin) Then
                UserIdentHold = i
                Exit For
            End If
        Next
        If UserIdentHold = -1 Then

            Dim UInError As New SoundPlayer("C:\ATM Machine Assets\UInError.wav")
            UInError.Play()

            Console.Clear()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine("              _______________________________________________________________________     ")
            Console.WriteLine("             | \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ |  _  |  X  |    ")
            Console.WriteLine("             |```````````````````````````````````````````````````````````````````````|    ")
            Console.WriteLine("             |    C D M   S T U D E N T ' S   B A N K  |    A T M   M A C H I N E    |    ")
            Console.WriteLine("             | ________________________   __________________________________________ |    ")
            Console.WriteLine("             |                          |    _________________                       |    ")
            Console.WriteLine("             |         _________        |   | A T M   U S E R |_____                 |    ")
            Console.WriteLine("             |        |O|`````\_|       |    ```````````| L O G I N |                |    ")
            Console.WriteLine("             |      __|O| _____ |       |                ````````````                |    ")
            Console.WriteLine("             |     |  |O||     ||       |   __________________________               |    ")
            Console.WriteLine("             |     | ~|O| ````` |       |  | *ACCOUNT DOES NOT EXIST  |              |    ")
            Console.WriteLine("             |     | ~|O|       |       |  | OR WRONG PIN CODE!       _\    _        |    ")
            Console.WriteLine("             |     | ~|O|_______|       |   ``````````````````````````     / \       |    ")
            Console.WriteLine("             |     | ~~~~~~~~ |         |                                 / | \      |    ")
            Console.WriteLine("             |     | ~~~~~.   |         |                                /  .  \     |    ")
            Console.WriteLine("             |      ```````````         |                                ```````     |    ")
            Console.WriteLine("             |_______________________________________________________________________|    ")
            Console.WriteLine("             | ////////// (C) COPYRIGHT 2023 | A.Y. 2022- 2023 | BSCPE 1A ////////// |    ")
            Console.WriteLine("              ```````````````````````````````````````````````````````````````````````     ")
            Threading.Thread.Sleep("3000")

            ATMloginDashboard()

        Else

            Dim ATMlogS As New SoundPlayer("C:\ATM Machine Assets\ATMlogS.wav")
            ATMlogS.Play()

            Console.Clear()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine("              _______________________________________________________________________     ")
            Console.WriteLine("             | \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ |  _  |  X  |    ")
            Console.WriteLine("             |```````````````````````````````````````````````````````````````````````|    ")
            Console.WriteLine("             |                                                                       |    ")
            Console.WriteLine("             |               - C O L E G I O   D E   M O N T A L B A N -             |    ")
            Console.WriteLine("             |                     - S T U D E N T ' S   B A N K -                   |    ")
            Console.WriteLine("             |      ___________________________________________________________      |    ")
            Console.WriteLine("             |     |             L O G I N   S U C C E S S F U L L Y           |     |    ")
            Console.WriteLine("             |      ```````````````````````````````````````````````````````````      |    ")
            Console.WriteLine("             |_______________________________________________________________________|    ")
            Console.WriteLine("             | ////////// (C) COPYRIGHT 2023 | A.Y. 2022- 2023 | BSCPE 1A ////////// |    ")
            Console.WriteLine("              ```````````````````````````````````````````````````````````````````````     ")
            Threading.Thread.Sleep("2200")

            ATMMainDashboard()

        End If
    End Sub

    'ATM MAIN DASHBOARD (COMPLETED)
    Sub ATMMainDashboard()

        Dim WSound As New SoundPlayer("C:\ATM Machine Assets\WSound.wav")
        WSound.Play()

        Console.Clear()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("              _______________________________________________________________________     ")
        Console.WriteLine("             | \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ |  _  |  X  |    ")
        Console.WriteLine("             |```````````````````````````````````````````````````````````````````````|    ")
        Console.WriteLine("             |    C D M   S T U D E N T ' S   B A N K  |    A T M   M A C H I N E    |    ")
        Console.WriteLine("             | _____________________________________________________________________ |    ")
        Console.WriteLine("             |                          |   _________________                        |    ")
        Console.WriteLine("             |          _________       |  | W E L C O M E ! |_______________        |    ")
        Console.WriteLine("             |      ___/========/__     |   ``| Please select a Transaction  |       |    ")
        Console.WriteLine("             |     /__/--------/__/|    |      ``````````````````````````````        |    ")
        Console.WriteLine("             |    |  __________   ||    |      ________________________              |    ")
        Console.WriteLine("             |    | |``````````|O ||    |     |  1.) CHECK BALANCE     |             |    ")
        Console.WriteLine("             |    | |   H I !  |O ||    |      `````````````````````````             |    ")
        Console.WriteLine("             |    | |__________|O ||    |      ________________________              |    ")
        Console.WriteLine("             |    | ````````````  |/|   |     |  2.) DEPOSIT           |             |    ")
        Console.WriteLine("             |   / ```````````````/ /   |      `````````````````````````             |    ")
        Console.WriteLine("             |   [TTT_________TTT] /    |      ________________________              |    ")
        Console.WriteLine("             |   [_______======__]/     |     |  3.) WITHDRAW          |             |    ")
        Console.WriteLine("             |                          |      `````````````````````````             |    ")
        Console.WriteLine("             |                          |                     Enter '0' to Logout    |    ")
        Console.WriteLine("             |_______________________________________________________________________|    ")
        Console.WriteLine("             | ////////// (C) COPYRIGHT 2023 | A.Y. 2022- 2023 | BSCPE 1A ////////// |    ")
        Console.WriteLine("              ```````````````````````````````````````````````````````````````````````     ")
        Console.WriteLine()
        Console.Write("                >>> HI, " + UserAccount(UserIdentHold).UserName + "! PLEASE ENTER YOUR INPUT HERE: ")
        UserChoice = Console.ReadLine()

        UserAccount(UserIdentHold).UserChoice1 = UserChoice

        Select Case UserChoice

            Case 1
                UserAccount(UserIdentHold).UserCheckBalance()
            Case 2
                UserAccount(UserIdentHold).UserDeposit()
            Case 3
                UserAccount(UserIdentHold).UserWithdraw()
            Case 0
                UserIdentHold = -1

                Dim ATMLoutSound As New SoundPlayer("C:\ATM Machine Assets\ATMLoutSound.wav")
                ATMLoutSound.Play()

                'ATM USER EXIT PROMPT

                Console.Clear()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine("              _______________________________________________________________________     ")
                Console.WriteLine("             | \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ |  _  |  X  |    ")
                Console.WriteLine("             |```````````````````````````````````````````````````````````````````````|    ")
                Console.WriteLine("             |                                                                       |    ")
                Console.WriteLine("             |               - C O L E G I O   D E   M O N T A L B A N -             |    ")
                Console.WriteLine("             |                     - S T U D E N T ' S   B A N K -                   |    ")
                Console.WriteLine("             |      ___________________________________________________________      |    ")
                Console.WriteLine("             |     |    THANK YOU FOR TRANSACTING WITH US. HAVE A GREAT DAY!   |     |    ")
                Console.WriteLine("             |      ```````````````````````````````````````````````````````````      |    ")
                Console.WriteLine("             |_______________________________________________________________________|    ")
                Console.WriteLine("             | ////////// (C) COPYRIGHT 2023 | A.Y. 2022- 2023 | BSCPE 1A ////////// |    ")
                Console.WriteLine("              ```````````````````````````````````````````````````````````````````````     ")
                Threading.Thread.Sleep("3800")
                ATMloginDashboard()

            Case Else
                Dim UInError As New SoundPlayer("C:\ATM Machine Assets\UInError.wav")
                UInError.Play()

                Console.Clear()
                Console.Clear()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine("              _______________________________________________________________________     ")
                Console.WriteLine("             | \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ |  _  |  X  |    ")
                Console.WriteLine("             |```````````````````````````````````````````````````````````````````````|    ")
                Console.WriteLine("             |    C D M   S T U D E N T ' S   B A N K  |    A T M   M A C H I N E    |    ")
                Console.WriteLine("             | _____________________________________________________________________ |    ")
                Console.WriteLine("             |                           ________                                    |    ")
                Console.WriteLine("             |                       ___/=======/|__                                 |    ")
                Console.WriteLine("             |                      /__|-------|/__/|                                |    ")
                Console.WriteLine("             |                     |  __________   ||                                |    ")
                Console.WriteLine("             |              1101011| |``````````|O ||  1 100101/`\                   |    ")
                Console.WriteLine("             |              ```1101| |  X __ X  |O ||  ````011/   \????              |    ")
                Console.WriteLine("             |                 `110| |__________|O ||       0/  |  \??????? ?        |    ")
                Console.WriteLine("             |                  ```| ````````````  |/|      /   |   \??``````        |    ")
                Console.WriteLine("             |                    / ```````````````/ /     /    .    \               |    ")
                Console.WriteLine("             |                    [TT_________TTTT] /      ```````````               |    ")
                Console.WriteLine("             |                    [_______======__]/                                 |    ")
                Console.WriteLine("             |            ________________________________________________           |    ")
                Console.WriteLine("             |           |       USER INPUT ERROR! PLEASE TRY AGAIN!      |          |    ")
                Console.WriteLine("             |            ````````````````````````````````````````````````           |    ")
                Console.WriteLine("             |_______________________________________________________________________|    ")
                Console.WriteLine("             | ////////// (C) COPYRIGHT 2023 | A.Y. 2022- 2023 | BSCPE 1A ////////// |    ")
                Console.WriteLine("              ```````````````````````````````````````````````````````````````````````     ")
                Threading.Thread.Sleep("2880")

                ATMMainDashboard()

        End Select
    End Sub

    'ATM USER PIN CODE CONVERSION - "DECLARE TEXT BASED INPUT TO ASTERISK" (COMPLETED)
    Function TXTtoPIN()
        Dim UserPin As String = ""


        While True

            Dim UPassinput As ConsoleKeyInfo = Console.ReadKey(True)

            If UPassinput.Key = ConsoleKey.Enter Then
                Exit While
            End If

            If UPassinput.Key = ConsoleKey.Backspace And UserPin.Length > 0 Then
                UserPin = UserPin.Substring(0, UserPin.Length - 1)
                Console.Write(vbBack & " " & vbBack)

            Else
                UserPin &= UPassinput.KeyChar
                Console.Write("■")

            End If
        End While
        Return UserPin
    End Function

    'ATM LOADING SCREEN (COMPLETED)
    Public Sub UIloading()
        Console.Clear()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("              _______________________________________________________________________      ")
        Console.WriteLine("             | \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ |  _  |  X  |     ")
        Console.WriteLine("             |```````````````````````````````````````````````````````````````````````|     ")
        Console.WriteLine("             |     =========  C O L E G I O   D E   M O N T A L B A N  =========     |     ")
        Console.WriteLine("             |      _______     ________     ____   ____    ________    ________     |     ")
        Console.WriteLine("             |     /~~~~~~~\   |~~~~~~~~\   |~~~~\ /~~~~|  |~~~~~~~~|  |~~~~~~~~\    |     ")
        Console.WriteLine("             |    |~~/```\~~\  |~~|``\~~~|  |~~~~~`~~~~~|  |~~|_____   |~~|__|~~|    |     ")
        Console.WriteLine("             |    |~~|    ___  |~~|   |~~|  |~~|\~~~/|~~|  |~~~~~~~~|  |~~~~~~~<     |     ")
        Console.WriteLine("             |    |~~\___/~~/  |~~|__/~~~|  |~~| ``` |~~|   _____|~~|  |~~|__|~~|    |     ")
        Console.WriteLine("             |     \~~~~~~~/   |~~~~~~~~/   |~~|     |~~|  |~~~~~~~~|  |~~~~~~~~/    |     ")
        Console.WriteLine("             |      ```````    `````````     ``       ``    ````````    ````````     |     ")
        Console.WriteLine("             |               =====  S T U D E N T ' S   B A N K  =====               |     ")
        Console.WriteLine("             |                                                                       |     ")
        Console.WriteLine("             |  -------------------------------------------------------------------  |     ")
        Console.WriteLine("             |                  ____________________________________                 |     ")
        Console.WriteLine("             |                 (   A  T  M    M  A  C  H  I  N  E   )                |     ")
        Console.WriteLine("             |                  ````````````````````````````````````                 |     ")
        Console.WriteLine("             |                 [███                                 ]                |     ")
        Console.WriteLine("             |                             L O A D I N G                             |     ")
        Console.WriteLine("             |                                                                       |     ")
        Console.WriteLine("             |   QUILINO | CABERTE | BUENAVENTURA                        CPEPROG 2   |     ")
        Console.WriteLine("             |   DAGATAN | TRERO | BUENDIA | CHAVEZ                          V 1.1   |     ")
        Console.WriteLine("             |_______________________________________________________________________|     ")
        Console.WriteLine("             | ////////// (C) COPYRIGHT 2023 | A.Y. 2022- 2023 | BSCPE 1A ////////// |     ")
        Console.WriteLine("              ```````````````````````````````````````````````````````````````````````      ")
        Threading.Thread.Sleep("150")

        Console.Clear()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("              _______________________________________________________________________      ")
        Console.WriteLine("             | \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ |  _  |  X  |     ")
        Console.WriteLine("             |```````````````````````````````````````````````````````````````````````|     ")
        Console.WriteLine("             |     =========  C O L E G I O   D E   M O N T A L B A N  =========     |     ")
        Console.WriteLine("             |      _______     ________     ____   ____    ________    ________     |     ")
        Console.WriteLine("             |     /~~~~~~~\   |~~~~~~~~\   |~~~~\ /~~~~|  |~~~~~~~~|  |~~~~~~~~\    |     ")
        Console.WriteLine("             |    |~~/```\~~\  |~~|``\~~~|  |~~~~~`~~~~~|  |~~|_____   |~~|__|~~|    |     ")
        Console.WriteLine("             |    |~~|    ___  |~~|   |~~|  |~~|\~~~/|~~|  |~~~~~~~~|  |~~~~~~~<     |     ")
        Console.WriteLine("             |    |~~\___/~~/  |~~|__/~~~|  |~~| ``` |~~|   _____|~~|  |~~|__|~~|    |     ")
        Console.WriteLine("             |     \~~~~~~~/   |~~~~~~~~/   |~~|     |~~|  |~~~~~~~~|  |~~~~~~~~/    |     ")
        Console.WriteLine("             |      ```````    `````````     ``       ``    ````````    ````````     |     ")
        Console.WriteLine("             |               =====  S T U D E N T ' S   B A N K  =====               |     ")
        Console.WriteLine("             |                                                                       |     ")
        Console.WriteLine("             |  -------------------------------------------------------------------  |     ")
        Console.WriteLine("             |                  ____________________________________                 |     ")
        Console.WriteLine("             |                 (   A  T  M    M  A  C  H  I  N  E   )                |     ")
        Console.WriteLine("             |                  ````````````````````````````````````                 |     ")
        Console.WriteLine("             |                 [███████                             ]                |     ")
        Console.WriteLine("             |                             L O A D I N G                             |     ")
        Console.WriteLine("             |                                                                       |     ")
        Console.WriteLine("             |   QUILINO | CABERTE | BUENAVENTURA                        CPEPROG 2   |     ")
        Console.WriteLine("             |   DAGATAN | TRERO | BUENDIA | CHAVEZ                          V 1.1   |     ")
        Console.WriteLine("             |_______________________________________________________________________|     ")
        Console.WriteLine("             | ////////// (C) COPYRIGHT 2023 | A.Y. 2022- 2023 | BSCPE 1A ////////// |     ")
        Console.WriteLine("              ```````````````````````````````````````````````````````````````````````      ")
        Threading.Thread.Sleep("150")

        Console.Clear()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("              _______________________________________________________________________      ")
        Console.WriteLine("             | \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ |  _  |  X  |     ")
        Console.WriteLine("             |```````````````````````````````````````````````````````````````````````|     ")
        Console.WriteLine("             |     =========  C O L E G I O   D E   M O N T A L B A N  =========     |     ")
        Console.WriteLine("             |      _______     ________     ____   ____    ________    ________     |     ")
        Console.WriteLine("             |     /~~~~~~~\   |~~~~~~~~\   |~~~~\ /~~~~|  |~~~~~~~~|  |~~~~~~~~\    |     ")
        Console.WriteLine("             |    |~~/```\~~\  |~~|``\~~~|  |~~~~~`~~~~~|  |~~|_____   |~~|__|~~|    |     ")
        Console.WriteLine("             |    |~~|    ___  |~~|   |~~|  |~~|\~~~/|~~|  |~~~~~~~~|  |~~~~~~~<     |     ")
        Console.WriteLine("             |    |~~\___/~~/  |~~|__/~~~|  |~~| ``` |~~|   _____|~~|  |~~|__|~~|    |     ")
        Console.WriteLine("             |     \~~~~~~~/   |~~~~~~~~/   |~~|     |~~|  |~~~~~~~~|  |~~~~~~~~/    |     ")
        Console.WriteLine("             |      ```````    `````````     ``       ``    ````````    ````````     |     ")
        Console.WriteLine("             |               =====  S T U D E N T ' S   B A N K  =====               |     ")
        Console.WriteLine("             |                                                                       |     ")
        Console.WriteLine("             |  -------------------------------------------------------------------  |     ")
        Console.WriteLine("             |                  ____________________________________                 |     ")
        Console.WriteLine("             |                 (   A  T  M    M  A  C  H  I  N  E   )                |     ")
        Console.WriteLine("             |                  ````````````````````````````````````                 |     ")
        Console.WriteLine("             |                 [█████████████████                   ]                |     ")
        Console.WriteLine("             |                             L O A D I N G                             |     ")
        Console.WriteLine("             |                                                                       |     ")
        Console.WriteLine("             |   QUILINO | CABERTE | BUENAVENTURA                        CPEPROG 2   |     ")
        Console.WriteLine("             |   DAGATAN | TRERO | BUENDIA | CHAVEZ                          V 1.1   |     ")
        Console.WriteLine("             |_______________________________________________________________________|     ")
        Console.WriteLine("             | ////////// (C) COPYRIGHT 2023 | A.Y. 2022- 2023 | BSCPE 1A ////////// |     ")
        Console.WriteLine("              ```````````````````````````````````````````````````````````````````````      ")
        Threading.Thread.Sleep("170")

        Console.Clear()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("              _______________________________________________________________________      ")
        Console.WriteLine("             | \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ |  _  |  X  |     ")
        Console.WriteLine("             |```````````````````````````````````````````````````````````````````````|     ")
        Console.WriteLine("             |     =========  C O L E G I O   D E   M O N T A L B A N  =========     |     ")
        Console.WriteLine("             |      _______     ________     ____   ____    ________    ________     |     ")
        Console.WriteLine("             |     /~~~~~~~\   |~~~~~~~~\   |~~~~\ /~~~~|  |~~~~~~~~|  |~~~~~~~~\    |     ")
        Console.WriteLine("             |    |~~/```\~~\  |~~|``\~~~|  |~~~~~`~~~~~|  |~~|_____   |~~|__|~~|    |     ")
        Console.WriteLine("             |    |~~|    ___  |~~|   |~~|  |~~|\~~~/|~~|  |~~~~~~~~|  |~~~~~~~<     |     ")
        Console.WriteLine("             |    |~~\___/~~/  |~~|__/~~~|  |~~| ``` |~~|   _____|~~|  |~~|__|~~|    |     ")
        Console.WriteLine("             |     \~~~~~~~/   |~~~~~~~~/   |~~|     |~~|  |~~~~~~~~|  |~~~~~~~~/    |     ")
        Console.WriteLine("             |      ```````    `````````     ``       ``    ````````    ````````     |     ")
        Console.WriteLine("             |               =====  S T U D E N T ' S   B A N K  =====               |     ")
        Console.WriteLine("             |                                                                       |     ")
        Console.WriteLine("             |  -------------------------------------------------------------------  |     ")
        Console.WriteLine("             |                  ____________________________________                 |     ")
        Console.WriteLine("             |                 (   A  T  M    M  A  C  H  I  N  E   )                |     ")
        Console.WriteLine("             |                  ````````````````````````````````````                 |     ")
        Console.WriteLine("             |                 [███████████████████████████         ]                |     ")
        Console.WriteLine("             |                             L O A D I N G                             |     ")
        Console.WriteLine("             |                                                                       |     ")
        Console.WriteLine("             |   QUILINO | CABERTE | BUENAVENTURA                        CPEPROG 2   |     ")
        Console.WriteLine("             |   DAGATAN | TRERO | BUENDIA | CHAVEZ                          V 1.1   |     ")
        Console.WriteLine("             |_______________________________________________________________________|     ")
        Console.WriteLine("             | ////////// (C) COPYRIGHT 2023 | A.Y. 2022- 2023 | BSCPE 1A ////////// |     ")
        Console.WriteLine("              ```````````````````````````````````````````````````````````````````````      ")
        Threading.Thread.Sleep("150")

        Console.Clear()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("              _______________________________________________________________________      ")
        Console.WriteLine("             | \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ |  _  |  X  |     ")
        Console.WriteLine("             |```````````````````````````````````````````````````````````````````````|     ")
        Console.WriteLine("             |     =========  C O L E G I O   D E   M O N T A L B A N  =========     |     ")
        Console.WriteLine("             |      _______     ________     ____   ____    ________    ________     |     ")
        Console.WriteLine("             |     /~~~~~~~\   |~~~~~~~~\   |~~~~\ /~~~~|  |~~~~~~~~|  |~~~~~~~~\    |     ")
        Console.WriteLine("             |    |~~/```\~~\  |~~|``\~~~|  |~~~~~`~~~~~|  |~~|_____   |~~|__|~~|    |     ")
        Console.WriteLine("             |    |~~|    ___  |~~|   |~~|  |~~|\~~~/|~~|  |~~~~~~~~|  |~~~~~~~<     |     ")
        Console.WriteLine("             |    |~~\___/~~/  |~~|__/~~~|  |~~| ``` |~~|   _____|~~|  |~~|__|~~|    |     ")
        Console.WriteLine("             |     \~~~~~~~/   |~~~~~~~~/   |~~|     |~~|  |~~~~~~~~|  |~~~~~~~~/    |     ")
        Console.WriteLine("             |      ```````    `````````     ``       ``    ````````    ````````     |     ")
        Console.WriteLine("             |               =====  S T U D E N T ' S   B A N K  =====               |     ")
        Console.WriteLine("             |                                                                       |     ")
        Console.WriteLine("             |  -------------------------------------------------------------------  |     ")
        Console.WriteLine("             |                  ____________________________________                 |     ")
        Console.WriteLine("             |                 (   A  T  M    M  A  C  H  I  N  E   )                |     ")
        Console.WriteLine("             |                  ````````````````````````````````````                 |     ")
        Console.WriteLine("             |                 [█████████████████████████████████   ]                |     ")
        Console.WriteLine("             |                             L O A D I N G                             |     ")
        Console.WriteLine("             |                                                                       |     ")
        Console.WriteLine("             |   QUILINO | CABERTE | BUENAVENTURA                        CPEPROG 2   |     ")
        Console.WriteLine("             |   DAGATAN | TRERO | BUENDIA | CHAVEZ                          V 1.1   |     ")
        Console.WriteLine("             |_______________________________________________________________________|     ")
        Console.WriteLine("             | ////////// (C) COPYRIGHT 2023 | A.Y. 2022- 2023 | BSCPE 1A ////////// |     ")
        Console.WriteLine("              ```````````````````````````````````````````````````````````````````````      ")
        Threading.Thread.Sleep("150")

        Console.Clear()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("              _______________________________________________________________________      ")
        Console.WriteLine("             | \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ |  _  |  X  |     ")
        Console.WriteLine("             |```````````````````````````````````````````````````````````````````````|     ")
        Console.WriteLine("             |     =========  C O L E G I O   D E   M O N T A L B A N  =========     |     ")
        Console.WriteLine("             |      _______     ________     ____   ____    ________    ________     |     ")
        Console.WriteLine("             |     /~~~~~~~\   |~~~~~~~~\   |~~~~\ /~~~~|  |~~~~~~~~|  |~~~~~~~~\    |     ")
        Console.WriteLine("             |    |~~/```\~~\  |~~|``\~~~|  |~~~~~`~~~~~|  |~~|_____   |~~|__|~~|    |     ")
        Console.WriteLine("             |    |~~|    ___  |~~|   |~~|  |~~|\~~~/|~~|  |~~~~~~~~|  |~~~~~~~<     |     ")
        Console.WriteLine("             |    |~~\___/~~/  |~~|__/~~~|  |~~| ``` |~~|   _____|~~|  |~~|__|~~|    |     ")
        Console.WriteLine("             |     \~~~~~~~/   |~~~~~~~~/   |~~|     |~~|  |~~~~~~~~|  |~~~~~~~~/    |     ")
        Console.WriteLine("             |      ```````    `````````     ``       ``    ````````    ````````     |     ")
        Console.WriteLine("             |               =====  S T U D E N T ' S   B A N K  =====               |     ")
        Console.WriteLine("             |                                                                       |     ")
        Console.WriteLine("             |  -------------------------------------------------------------------  |     ")
        Console.WriteLine("             |                  ____________________________________                 |     ")
        Console.WriteLine("             |                 (   A  T  M    M  A  C  H  I  N  E   )                |     ")
        Console.WriteLine("             |                  ````````````````````````````````````                 |     ")
        Console.WriteLine("             |                 [████████████████████████████████████]                |     ")
        Console.WriteLine("             |                             L O A D I N G                             |     ")
        Console.WriteLine("             |                                                                       |     ")
        Console.WriteLine("             |   QUILINO | CABERTE | BUENAVENTURA                        CPEPROG 2   |     ")
        Console.WriteLine("             |   DAGATAN | TRERO | BUENDIA | CHAVEZ                          V 1.1   |     ")
        Console.WriteLine("             |_______________________________________________________________________|     ")
        Console.WriteLine("             | ////////// (C) COPYRIGHT 2023 | A.Y. 2022- 2023 | BSCPE 1A ////////// |     ")
        Console.WriteLine("              ```````````````````````````````````````````````````````````````````````      ")
        Threading.Thread.Sleep("100")

        Console.Clear()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("              _______________________________________________________________________      ")
        Console.WriteLine("             | \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ |  _  |  X  |     ")
        Console.WriteLine("             |```````````````````````````````````````````````````````````````````````|     ")
        Console.WriteLine("             |     =========  C O L E G I O   D E   M O N T A L B A N  =========     |     ")
        Console.WriteLine("             |      _______     ________     ____   ____    ________    ________     |     ")
        Console.WriteLine("             |     /~~~~~~~\   |~~~~~~~~\   |~~~~\ /~~~~|  |~~~~~~~~|  |~~~~~~~~\    |     ")
        Console.WriteLine("             |    |~~/```\~~\  |~~|``\~~~|  |~~~~~`~~~~~|  |~~|_____   |~~|__|~~|    |     ")
        Console.WriteLine("             |    |~~|    ___  |~~|   |~~|  |~~|\~~~/|~~|  |~~~~~~~~|  |~~~~~~~<     |     ")
        Console.WriteLine("             |    |~~\___/~~/  |~~|__/~~~|  |~~| ``` |~~|   _____|~~|  |~~|__|~~|    |     ")
        Console.WriteLine("             |     \~~~~~~~/   |~~~~~~~~/   |~~|     |~~|  |~~~~~~~~|  |~~~~~~~~/    |     ")
        Console.WriteLine("             |      ```````    `````````     ``       ``    ````````    ````````     |     ")
        Console.WriteLine("             |               =====  S T U D E N T ' S   B A N K  =====               |     ")
        Console.WriteLine("             |                                                                       |     ")
        Console.WriteLine("             |  -------------------------------------------------------------------  |     ")
        Console.WriteLine("             |                  ____________________________________                 |     ")
        Console.WriteLine("             |                 (   A  T  M    M  A  C  H  I  N  E   )                |     ")
        Console.WriteLine("             |                  ````````````````````````````````````                 |     ")
        Console.WriteLine("             |                 [████████████████████████████████████]                |     ")
        Console.WriteLine("             |                    L O A D I N G   C O M P L E T E                    |     ")
        Console.WriteLine("             |                                                                       |     ")
        Console.WriteLine("             |   QUILINO | CABERTE | BUENAVENTURA                        CPEPROG 2   |     ")
        Console.WriteLine("             |   DAGATAN | TRERO | BUENDIA | CHAVEZ                          V 1.1   |     ")
        Console.WriteLine("             |_______________________________________________________________________|     ")
        Console.WriteLine("             | ////////// (C) COPYRIGHT 2023 | A.Y. 2022- 2023 | BSCPE 1A ////////// |     ")
        Console.WriteLine("              ```````````````````````````````````````````````````````````````````````      ")
        Threading.Thread.Sleep("150")
    End Sub

End Module

'USER ACCOUNT DATA ALGORITHM
Public Class ATMUserAccount
    Public UserChoice1 As String
    Public UserName As String
    Dim UserPin As String
    Dim UserMoneyBalance As Double = 0
    Dim UserMoneyAmount As Double

    'ADD ATM USER (algo)
    Sub New(SetUserPin As String, SetUserName As String)
        UserPin = SetUserPin
        UserName = SetUserName
    End Sub

    'ATM USER PIN CHECKER (algo)
    Public Function UserPINchecker(PINcheck As String)
        Return PINcheck = UserPin
    End Function

    'USER INPUT CHOICE PROMPT (COMPLETED) 
    Private Sub UserChoicePrompt(UserChoice As String)

        Dim UserChoice1 As String

        Dim PROMPT As New SoundPlayer("C:\ATM Machine Assets\PROMPT.wav")

        PROMPT.Play()
        Console.Clear()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("              _______________________________________________________________________     ")
        Console.WriteLine("             | \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ |  _  |  X  |    ")
        Console.WriteLine("             |```````````````````````````````````````````````````````````````````````|    ")
        Console.WriteLine("             |    C D M   S T U D E N T ' S   B A N K  |    A T M   M A C H I N E    |    ")
        Console.WriteLine("             | _____________________________________________________________________ |    ")
        Console.WriteLine("             |                          |                                            |    ")
        Console.WriteLine("             |          _________       |    _______________________                 |    ")
        Console.WriteLine("             |      ___/========/__     |   | T R A N S A C T I O N |_____           |    ")
        Console.WriteLine("             |     /__/--------/__/|    |    ```````````````| P R O M P T |          |    ")
        Console.WriteLine("             |    |  __________   ||    |                    `````````````           |    ")
        Console.WriteLine("             |    | |``````````|O ||    |                                            |    ")
        Console.WriteLine("             |    | |  A T M . |O ||    |    DO YOU WANT TO HAVE ANOTHER             |    ")
        Console.WriteLine("             |    | |__________|O ||    |    TRANSACTION?                            |    ")
        Console.WriteLine("             |    | ````````````  |/|   |                                            |    ")
        Console.WriteLine("             |   / ```````````````/ /   |    >> PLEASE ENTER '1' IF YES,             |    ")
        Console.WriteLine("             |   [TTT_________TTT] /    |       OTHERWISE PRESS 'ENTER' IF NO...     |    ")
        Console.WriteLine("             |   [_______======__]/     |                                            |    ")
        Console.WriteLine("             |                          |                    #SECURED ATM BANKING    |    ")
        Console.WriteLine("             |_______________________________________________________________________|    ")
        Console.WriteLine("             | ////////// (C) COPYRIGHT 2023 | A.Y. 2022- 2023 | BSCPE 1A ////////// |    ")
        Console.WriteLine("              ```````````````````````````````````````````````````````````````````````     ")
        Console.WriteLine()
        Console.Write("                >>> PLEASE ENTER YOUR INPUT HERE: ")
        UserChoice1 = Console.ReadLine()

        Select Case UserChoice1
            Case 1
                If UserChoice = "1" Then
                    UserCheckBalance()
                ElseIf UserChoice = "2" Then
                    UserDeposit()
                ElseIf UserChoice = "3" Then
                    UserWithdraw()
                Else
                    ATMMainDashboard()
                End If

            Case Else
                ATMMainDashboard()
        End Select
    End Sub


    '  ------------  TRANSACTION DASHBOARD  ------------  

    'ATM USER CHECK BALANCE (COMPLETED)
    Public Sub UserCheckBalance()

        Console.Beep()
        Console.Beep()
        Console.Beep()

        Console.Clear()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("              _______________________________________________________________________     ")
        Console.WriteLine("             | \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ |  _  |  X  |    ")
        Console.WriteLine("             |```````````````````````````````````````````````````````````````````````|    ")
        Console.WriteLine("             |    C D M   S T U D E N T ' S   B A N K  |    A T M   M A C H I N E    |    ")
        Console.WriteLine("             | _____________________________________________________________________ |    ")
        Console.WriteLine("             |    ___________________                                                |    ")
        Console.WriteLine("             |   |                   |   ___________________________________         |    ")
        Console.WriteLine("             |   | CDMSB ATM         |  | A T M   B A L A N C E   C H E C K |        |    ")
        Console.WriteLine("             |   | 00- XXXXXXXX      |   ```````````````````````````````````         |    ")
        Console.WriteLine("             |   |___________________|                                  _________    |    ")
        Console.WriteLine("             |   |                   |                                 |C|D|M|S|B|   |    ")
        Console.WriteLine("             |    ````````````````````                                  `````````    |    ")
        Console.WriteLine("             |_______________________________________________________________________|    ")
        Console.WriteLine("             | ////////// (C) COPYRIGHT 2023 | A.Y. 2022- 2023 | BSCPE 1A ////////// |    ")
        Console.WriteLine("              ```````````````````````````````````````````````````````````````````````     ")
        Console.WriteLine()
        Console.WriteLine("                >>> ACCOUNT NAME: " + UserName)
        Console.WriteLine("                >>> BALANCE : PHP. " & UserMoneyBalance)


        Console.WriteLine()
        Threading.Thread.Sleep("3000")

        UserChoicePrompt(UserChoice1)


    End Sub

    'ATM USER DEPOSIT (COMPLETED)
    Public Sub UserDeposit()

        Console.Beep()
        Console.Beep()
        Console.Beep()

        Console.Clear()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("              _______________________________________________________________________     ")
        Console.WriteLine("             | \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ |  _  |  X  |    ")
        Console.WriteLine("             |```````````````````````````````````````````````````````````````````````|    ")
        Console.WriteLine("             |    C D M   S T U D E N T ' S   B A N K  |    A T M   M A C H I N E    |    ")
        Console.WriteLine("             | _____________________________________________________________________ |    ")
        Console.WriteLine("             |    ___________________                                                |    ")
        Console.WriteLine("             |   |                   |   ___________________                         |    ")
        Console.WriteLine("             |   | CDMSB ATM         |  |  A T M   B A N K  |_________               |    ")
        Console.WriteLine("             |   | 00- XXXXXXXX      |   ```````````|  D E P O S I T  |              |    ")
        Console.WriteLine("             |   |___________________|               `````````````````  _________    |    ")
        Console.WriteLine("             |   |                   |                                 |C|D|M|S|B|   |    ")
        Console.WriteLine("             |    ````````````````````                                  `````````    |    ")
        Console.WriteLine("             |_______________________________________________________________________|    ")
        Console.WriteLine("             | ////////// (C) COPYRIGHT 2023 | A.Y. 2022- 2023 | BSCPE 1A ////////// |    ")
        Console.WriteLine("              ```````````````````````````````````````````````````````````````````````     ")

        Console.WriteLine("                >>> ACCOUNT NAME: " + UserName)
        Console.WriteLine("                >>> TOTAL ACCT. BALANCE: PHP. " & UserMoneyBalance)
        Console.Write("                >>> ENTER THE AMOUNT YOU WANT TO DEPOSIT: PHP. ")

        UserMoneyAmount = Console.ReadLine()
        UserMoneyBalance += UserMoneyAmount

        Console.Beep()
        Console.Beep()
        Console.Beep()

        Console.Clear()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("              _______________________________________________________________________     ")
        Console.WriteLine("             | \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ |  _  |  X  |    ")
        Console.WriteLine("             |```````````````````````````````````````````````````````````````````````|    ")
        Console.WriteLine("             |    C D M   S T U D E N T ' S   B A N K  |    A T M   M A C H I N E    |    ")
        Console.WriteLine("             | _____________________________________________________________________ |    ")
        Console.WriteLine("             |          _________       |                                            |    ")
        Console.WriteLine("             |      ___/========/__     |    _______________________                 |    ")
        Console.WriteLine("             |     /__/--------/__/|    |   | T R A N S A C T I O N |________        |    ")
        Console.WriteLine("             |    |  __________   ||    |    ````````````| C O M P L E T E D |       |    ")
        Console.WriteLine("             |    | |``````````|O ||    |                 ```````````````````        |    ")
        Console.WriteLine("             |    | |  A T M . |O ||    |    CONGRATULATIONS!                        |    ")
        Console.WriteLine("             |    | |__________|O ||    |        YOU HAVE SUCCESSFULLY DEPOSIT!      |    ")
        Console.WriteLine("             |    | ````````````  |/|   |                                            |    ")
        Console.WriteLine("             |   / ```````````````/ /   |             SECURED ATM BANKING WITH :     |    ")
        Console.WriteLine("             |   [TTT_________TTT] /    |                             _________      |    ")
        Console.WriteLine("             |   [_______======__]/     |                            |C|D|M|S|B|     |    ")
        Console.WriteLine("             |                          |                             `````````      |    ")
        Console.WriteLine("             |_______________________________________________________________________|    ")
        Console.WriteLine("             | ////////// (C) COPYRIGHT 2023 | A.Y. 2022- 2023 | BSCPE 1A ////////// |    ")
        Console.WriteLine("              ```````````````````````````````````````````````````````````````````````     ")
        Console.WriteLine("                >>> ACCOUNT NAME: " + UserName)
        Console.WriteLine("                >>> DEPOSITED AMMOUNT: PHP. " & UserMoneyAmount)
        Console.WriteLine("                >>> TOTAL ACCT. BALANCE: PHP. " & UserMoneyBalance)
        Threading.Thread.Sleep("2000")

        UserChoicePrompt(UserChoice1)
    End Sub

    'ATM USER WITHDRAW (COMPLETED)
    Public Sub UserWithdraw()

        Console.Beep()
        Console.Beep()
        Console.Beep()

        Console.Clear()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("              _______________________________________________________________________     ")
        Console.WriteLine("             | \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ |  _  |  X  |    ")
        Console.WriteLine("             |```````````````````````````````````````````````````````````````````````|    ")
        Console.WriteLine("             |    C D M   S T U D E N T ' S   B A N K  |    A T M   M A C H I N E    |    ")
        Console.WriteLine("             | _____________________________________________________________________ |    ")
        Console.WriteLine("             |    ___________________                                                |    ")
        Console.WriteLine("             |   |                   |   ___________________                         |    ")
        Console.WriteLine("             |   | CDMSB ATM         |  |  A T M   B A N K  |___________             |    ")
        Console.WriteLine("             |   | 00- XXXXXXXX      |   ```````````|  W I T H D R A W  |            |    ")
        Console.WriteLine("             |   |___________________|               ```````````````````_________    |    ")
        Console.WriteLine("             |   |                   |                                 |C|D|M|S|B|   |    ")
        Console.WriteLine("             |    ````````````````````                                  `````````    |    ")
        Console.WriteLine("             |_______________________________________________________________________|    ")
        Console.WriteLine("             | ////////// (C) COPYRIGHT 2023 | A.Y. 2022- 2023 | BSCPE 1A ////////// |    ")
        Console.WriteLine("              ```````````````````````````````````````````````````````````````````````     ")
        Console.WriteLine("                >>> ACCOUNT NAME: " + UserName)
        Console.WriteLine("                >>> TOTAL ACCT. BALANCE: PHP. " & UserMoneyBalance)
        Console.Write("                >>> ENTER THE AMOUNT YOU WANT TO WITHDRAW: PHP. ")
        UserMoneyAmount = Console.ReadLine()

        If (UserMoneyBalance >= UserMoneyAmount) Then
            UserMoneyBalance = UserMoneyBalance - UserMoneyAmount

            Console.Beep()
            Console.Beep()
            Console.Beep()

            Console.Clear()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine("              _______________________________________________________________________     ")
            Console.WriteLine("             | \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ |  _  |  X  |    ")
            Console.WriteLine("             |```````````````````````````````````````````````````````````````````````|    ")
            Console.WriteLine("             |    C D M   S T U D E N T ' S   B A N K  |    A T M   M A C H I N E    |    ")
            Console.WriteLine("             | _____________________________________________________________________ |    ")
            Console.WriteLine("             |          _________       |                                            |    ")
            Console.WriteLine("             |      ___/========/__     |    _______________________                 |    ")
            Console.WriteLine("             |     /__/--------/__/|    |   | T R A N S A C T I O N |________        |    ")
            Console.WriteLine("             |    |  __________   ||    |    ````````````| C O M P L E T E D |       |    ")
            Console.WriteLine("             |    | |``````````|O ||    |                 ```````````````````        |    ")
            Console.WriteLine("             |    | |  A T M . |O ||    |    CONGRATULATIONS!                        |    ")
            Console.WriteLine("             |    | |__________|O ||    |        YOU HAVE SUCCESSFULLY WITHDRAW!     |    ")
            Console.WriteLine("             |    | ````````````  |/|   |                                            |    ")
            Console.WriteLine("             |   / ```````````````/ /   |             SECURED ATM BANKING WITH :     |    ")
            Console.WriteLine("             |   [TTT_________TTT] /    |                             _________      |    ")
            Console.WriteLine("             |   [_______======__]/     |                            |C|D|M|S|B|     |    ")
            Console.WriteLine("             |                          |                             `````````      |    ")
            Console.WriteLine("             |_______________________________________________________________________|    ")
            Console.WriteLine("             | ////////// (C) COPYRIGHT 2023 | A.Y. 2022- 2023 | BSCPE 1A ////////// |    ")
            Console.WriteLine("              ```````````````````````````````````````````````````````````````````````     ")
            Console.WriteLine("                >>> ACCOUNT NAME: " + UserName)
            Console.WriteLine("                >>> WITHDRAWED AMMOUNT: PHP. " & UserMoneyAmount)
            Console.WriteLine("                >>> TOTAL ACCT. BALANCE: PHP. " & UserMoneyBalance)

            Threading.Thread.Sleep("2000")

            UserChoicePrompt(UserChoice1)

        Else
            Console.Clear()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine("              _______________________________________________________________________     ")
            Console.WriteLine("             | \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ |  _  |  X  |    ")
            Console.WriteLine("             |```````````````````````````````````````````````````````````````````````|    ")
            Console.WriteLine("             |    C D M   S T U D E N T ' S   B A N K  |    A T M   M A C H I N E    |    ")
            Console.WriteLine("             | _____________________________________________________________________ |    ")
            Console.WriteLine("             |          _________       |                                            |    ")
            Console.WriteLine("             |      ___/========/__     |    _______________________                 |    ")
            Console.WriteLine("             |     /__/--------/__/|    |   | T R A N S A C T I O N |_____           |    ")
            Console.WriteLine("             |    |  __________   ||    |    ```````````````| F A I L E D |          |    ")
            Console.WriteLine("             |    | |``````````|O ||    |                    ``````````````          |    ")
            Console.WriteLine("             |    | |  A T M . |O ||    |   SORRY, YOUR BALANCE IS                   |    ")
            Console.WriteLine("             |    | |__________|O ||    |      NOT ENOUGH TO WITHDRAW.               |    ")
            Console.WriteLine("             |    | ````````````  |/|   |                                            |    ")
            Console.WriteLine("             |   / ```````````````/ /   |             SECURED ATM BANKING WITH :     |    ")
            Console.WriteLine("             |   [TTT_________TTT] /    |                             _________      |    ")
            Console.WriteLine("             |   [_______======__]/     |                            |C|D|M|S|B|     |    ")
            Console.WriteLine("             |                          |                             `````````      |    ")
            Console.WriteLine("             |_______________________________________________________________________|    ")
            Console.WriteLine("             | ////////// (C) COPYRIGHT 2023 | A.Y. 2022- 2023 | BSCPE 1A ////////// |    ")
            Console.WriteLine("              ```````````````````````````````````````````````````````````````````````     ")
            Threading.Thread.Sleep("2000")

            UserChoicePrompt(UserChoice1)

        End If

    End Sub



End Class

'(V1.0) FINISHED 03/29/2023 - 6:20 AM - 22-01691
'(V1.1) REVISED 04/04/2023 - 11:15 AM - 22-01691



