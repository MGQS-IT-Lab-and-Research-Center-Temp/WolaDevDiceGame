// Build Dice Game App

// Three Cubic Dice

// ------ RULES ------\\

            // POINT \\
    // • If all the dice have the same value, the player get extra point of 6 point. \\
    // • If two dice have the same value and the last one has a different value, the player get just extra 2 point. \\
    // • If all the dice  have different value each, the player get no point. \\

            // EXTRA BONUS \\
    // • If player get a total score that is greater than or equal to 10 but less than or equal 13, the player get a Baloon. \\
    // • If player get a total score of greater than or equal to 14 but less than or equal to 16, the player get a Note Book. \\
    // • If player get a total score of 17, the player get a 5000mah Power Bank. \\
    // • If player get a total score of greater than or equal to 18 but less than or equal to 20, the player get a Ticket to Silverbird ... \\

// • Ask for Player's Input
Console.WriteLine("\n===== SIMPLE DICE GAME =====\nType 'Start' or 'S' to roll the die:");
string startGame = Console.ReadLine()!;


while(!(startGame.Equals("Start", StringComparison.OrdinalIgnoreCase) || startGame.Equals("S", StringComparison.OrdinalIgnoreCase)))
{
        Console.WriteLine("----------------");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Please enter a VALID response!!!");
        Console.ResetColor();
        Console.WriteLine("----------------");
        Console.Write("Type 'Start' or 's' to start the game: ");
        startGame = Console.ReadLine()!;

}
    // • If 'Start' or 'S' is typed in either lowercase or uppercase.
    if (startGame.Equals("Start", StringComparison.OrdinalIgnoreCase) || startGame.Equals("s", StringComparison.OrdinalIgnoreCase))
    {
    Random random = new();
    int diceOne = random.Next(1, 7);
    int diceTwo = random.Next(1, 7);
    int diceThree = random.Next(1, 7);
    int originalScore = diceOne + diceTwo + diceThree;
    const int DOUBLE_POINT = 2;
    const int TRIPPLE_POINT = 6;
    int totalPoint = originalScore;

    // • If all the dice have the same value, the player get extra point of 6 point.
    if (diceOne == diceTwo && diceTwo== diceThree)
    {
        totalPoint += TRIPPLE_POINT;
        Console.WriteLine("----------------");
        Console.WriteLine($"You rolled:\nDice One: {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}\nAnd you were given a bonus of {TRIPPLE_POINT}.\nYour Total Point is: {totalPoint}.");
    }
    // • If two dice have the same value and the last one has a different value, the player get just extra 2 point.
    else if (diceOne == diceTwo || diceTwo == diceThree || diceOne == diceThree)
    {
        totalPoint += DOUBLE_POINT;
        Console.WriteLine("----------------");
        Console.WriteLine($"You rolled:\nDice One: {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}\nAnd you were given a bonus of {DOUBLE_POINT}.\nYour Total Point is: {totalPoint}.");
    }
    // • If all the dice  have different value each, the player get no point.
    else
    {
        Console.WriteLine("----------------");
        Console.WriteLine($"You rolled:\nDice One: {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}\nYour Total Point is: {totalPoint}.");
    }

    if (totalPoint < 10)
    {
        Console.WriteLine("Sorry (╥_╥), you win no gift.");
        Console.WriteLine("----------------");
    }

    // • If player get a total score that is greater than or equal to 10 but less than or equal 13, the player get a Balloon. \\
    else if (totalPoint >= 10 && totalPoint <=13)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Congratulations!!! You got a Balloon.");
        Console.ResetColor();
        Console.WriteLine("----------------");
    }

    // • If player get a total score of greater than or equal to 14 but less than or equal to 16, the player get a Note Book. \\
    else if (totalPoint >= 14 && totalPoint <= 16)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Congratulations!!! You got a Note Book.");
        Console.ResetColor();
        Console.WriteLine("----------------");
    }
    
    // • If player get a total score of 17, the player get a 5000Mah Power Bank. \\
    else if (totalPoint == 17)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Congratulations!!! You got a 5000Mah Power Bank.");
        Console.ResetColor();
        Console.WriteLine("----------------");
    }

    // • If player get a total score of greater than or equal to 18 but less than or equal to 20, the player get a Ticket to Silverbird's Gallery \\
    else if (totalPoint >= 18 && totalPoint <= 20)
    {
        Console.WriteLine("Congratulations!!! You got a FREE ticket to Silverbird's Gallery.");
        Console.WriteLine("----------------");
    }
    else if (totalPoint >= 21)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"WOW!!!\nCongratulations ୧(☆‿☆)୨ !!!\nYou get all this prizes:\n• A Balloon\n• A Note Book\n• A Power Bank of 5000Mah; and\n• A FREE Ticket to Silverbird's Gallery.");
        Console.ResetColor();
        Console.WriteLine("----------------");
    }
    }

Console.Write("Enter 'y' to play again or 'n' to stop: ");
string startOrStop = Console.ReadLine()!;

switch (startOrStop)
{
    case "Yes":
    case "yes":
    case "Y":
    case "y":
        Console.Write("");
    break;

    case "N":
    case "No":
        Console.Write("=====\nThank you for playing our Dice Game.\nHappy to have you back soon.\n=====");
        // return;
    break;

    case "n":
    case "no":
        Console.Write("=====\nThank you for playing our Dice Game.\nHappy to have you back soon.\n=====");
        // return;
    break;

    default:

        if (startOrStop.Equals("Y", StringComparison.OrdinalIgnoreCase) || startOrStop.Equals("Yes", StringComparison.OrdinalIgnoreCase))
        {
            Console.Write("=====\nThank you for attempting, your input can't be read.\nTry Again!!!\n=====\nPlease Try Again, Enter 'y' or 'n' to start or stop the game: ");
            startOrStop = Console.ReadLine()!;
        } 
        else if (startOrStop.Equals("N", StringComparison.OrdinalIgnoreCase) || startOrStop.Equals("No", StringComparison.OrdinalIgnoreCase))
        {
            Console.Write("=====\nThank you for playing our Dice Game.\nHappy to have you back soon.\n=====");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Sorry, You inputed wrong value, start again and enjoy!!!");
            Console.ResetColor();
            // return;
            Console.Write("Enter 'y' or 'n' to start or stop the game: ");
            startOrStop = Console.ReadLine()!;

        }
    break;
}

// Console.Write("Enter 'y' to play again or 'n' to stop: ");
// startOrStop = Console.ReadLine()!;

while (startOrStop.Equals("y", StringComparison.OrdinalIgnoreCase))
{
    Console.Write("Type 'Start' or 's' to start the game or type 'No' or 'n' to stop: ");
    startGame = Console.ReadLine()!;

        // • If 'Start' or 'S' is typed in either lowercase or uppercase.
    if (startGame.Equals("Start", StringComparison.OrdinalIgnoreCase) || startGame.Equals("s", StringComparison.OrdinalIgnoreCase))
    {
        Random random = new();
        int diceOne = random.Next(1, 7);
        int diceTwo = random.Next(1, 7);
        int diceThree = random.Next(1, 7);
        int originalScore = diceOne + diceTwo + diceThree;
        const int DOUBLE_POINT = 2;
        const int TRIPPLE_POINT = 6;
        int totalPoint = originalScore;

        // • If all the dice have the same value, the player get extra point of 6 point.
        if (diceOne == diceTwo && diceTwo== diceThree)
        {
            totalPoint += TRIPPLE_POINT;
            Console.WriteLine("----------------");
            Console.WriteLine($"You rolled:\nDice One: {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}\nAnd you were given a bonus of {TRIPPLE_POINT}.\nYour Total Point is: {totalPoint}.");
        }
        // • If two dice have the same value and the last one has a different value, the player get just extra 2 point.
        else if (diceOne == diceTwo || diceTwo == diceThree || diceOne == diceThree)
        {
            totalPoint += DOUBLE_POINT;
            Console.WriteLine("----------------");
            Console.WriteLine($"You rolled:\nDice One: {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}\nAnd you were given a bonus of {DOUBLE_POINT}.\nYour Total Point is: {totalPoint}.");
        }
        // • If all the dice  have different value each, the player get no point.
        else
        {
            Console.WriteLine("----------------");
            Console.WriteLine($"You rolled:\nDice One: {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}\nYour Total Point is: {totalPoint}.");
        }

        if (totalPoint < 10)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Sorry (╥_╥), you win no gift.");
            Console.ResetColor();
            Console.WriteLine("----------------");
        }

        // • If player get a total score that is greater than or equal to 10 but less than or equal 13, the player get a Balloon. \\
        else if (totalPoint >= 10 && totalPoint <=13)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Congratulations!!! You got a Balloon.");
            Console.ResetColor();
            Console.WriteLine("----------------");
        }

        // • If player get a total score of greater than or equal to 14 but less than or equal to 16, the player get a Note Book. \\
        else if (totalPoint >= 14 && totalPoint <= 16)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Congratulations!!! You got a Note Book.");
            Console.ResetColor();
            Console.WriteLine("----------------");
        }
        
        // • If player get a total score of 17, the player get a 5000Mah Power Bank. \\
        else if (totalPoint == 17)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Congratulations!!! You got a 5000Mah Power Bank.");
            Console.ResetColor();
            Console.WriteLine("----------------");
        }

        // • If player get a total score of greater than or equal to 18 but less than or equal to 20, the player get a Ticket to Silverbird's Gallery \\
        else if (totalPoint >= 18 && totalPoint <= 20)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Congratulations!!! You got a FREE ticket to Silverbird's Gallery.");
            Console.ResetColor();
            Console.WriteLine("----------------");
        }
        else if (totalPoint >= 21)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"WOW!!!\nCongratulations ୧(☆‿☆)୨ !!!\nYou get all this prizes:\n• A Balloon\n• A Note Book\n• A Power Bank of 5000Mah; and\n• A FREE Ticket to Silverbird's Gallery.");
            Console.ResetColor();
            Console.WriteLine("----------------");
        }
    }
    else if (startGame.Equals("No", StringComparison.OrdinalIgnoreCase) || startGame.Equals("n", StringComparison.OrdinalIgnoreCase))
    {
            Console.Write("=====\nThank you for playing our Dice Game.\nHappy to have you back soon.\n=====");
            return;
    }

    while (startOrStop.Equals("No", StringComparison.OrdinalIgnoreCase) || startGame.Equals("n", StringComparison.OrdinalIgnoreCase))
    {
        Console.Write("=====\nThank you for playing our Dice Game.\nHappy to have you back soon.\n=====");
        return;
    }

}

while (!(startOrStop.Equals("Yes", StringComparison.OrdinalIgnoreCase) || startOrStop.Equals("Y", StringComparison.OrdinalIgnoreCase)))
{
    Console.Write("Type Y (Yes) to Start or N (No) to Stop Playing: ");
    startOrStop = Console.ReadLine()!;

    if (startOrStop.Equals("Y", StringComparison.OrdinalIgnoreCase) || startOrStop.Equals("Yes", StringComparison.OrdinalIgnoreCase))
    {
        // Start the game
    }
    else if(startOrStop.Equals("N", StringComparison.OrdinalIgnoreCase) || startOrStop.Equals("No", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("=====\nThank you for playing our Dice Game.\nHappy to have you back soon.\n=====");
        return;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("=====\nSORRY!!! YOU INPUTED A WRONG COMMAND.\n=====");
        Console.ResetColor();
    }

}


// • If input value different 'Start' or 'S'.
// else if (!(startGame.Equals("Start", StringComparison.OrdinalIgnoreCase) || startGame.Equals("S", StringComparison.OrdinalIgnoreCase)))
// {
//     Console.WriteLine("----------------");
//     // Console.BackgroundColor = ConsoleColor.Cyan;
//     Console.ForegroundColor = ConsoleColor.Red;
//     Console.WriteLine("Please enter a valid response!!!\nType 'Start' or 's' to start the game.");
//     Console.ResetColor();
//     Console.WriteLine("----------------");
// }

// ------ RULES ------\\

        // POINT \\
// • If all the dice have the same value, the player get extra point of 6 point. \\
// • If two dice have the same value and the last one has a different value, the player get just extra 2 point. \\
// • If all the dice  have different value each, the player get no point. \\

        // EXTRA BONUS \\
// • If player get a total score that is greater than or equal to 10 but less than or equal 13, the player get a Balloon. \\
// • If player get a total score of greater than or equal to 14 but less than or equal to 16, the player get a Note Book. \\
// • If player get a total score of 17, the player get a 5000mah Power Bank. \\
// • If player get a total score of greater than or equal to 18 but less than or equal to 20, the player get a FREE Ticket to Silverbird ... \\
// • If player get a total score of greater than or equal to 21, the player get all of the above (Balloon, Note Book, 5000Mah Power Bank and a FREE Ticket to Silverbird's Gallery).