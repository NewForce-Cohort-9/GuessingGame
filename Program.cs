// Phase 1
// Display a message to the user asking them to guess the secret number.
// Display a prompt for the user's guess.
// Take the user's guess as input and save it as a variable.
// Display the user's guess back to the screen.

// //Phase 2
// Create a variable to contain the secret number. This number should be hard-coded for now. 42 is a nice number.
// No longer display the user's guess. They know what they guessed, right?
// Compare the user's guess with the secret number. Display a success message if the guess is correct, otherwise display a failure message.

//Phase 3
// Give the user four chances to guess the number.
// Continue to display the success or failure messages as in phase 2


//Phase 4
// Display the number of the user's current guess in the prompt. For example, if the user has already guessed one time, the prommpt should say something like Your guess (2)>.
// End the loop early if the user guesses the correct number.

//Phase 5
// Use a random number between 1 and 100 instead of a hard-coded number.
// The prompt should display the number of guesses the user has left.

//Phase 6
// Inform the user if their guess was too high or too low, when they guess incorrectly.

// Phase 7
// Prompt the user for a difficulty level before they are prompted to guess the number.
// The difficulty level should determine how many guesses the user gets. The difficulty levels should be:
// Easy - this gives the user eight guesses.
// Medium - this gives the user six guesses.
// Hard - this gives the user four guesses.

// Phase 8
// Add a difficulty level of "Cheater" which will cause the program to continue prompting the user until they get the answer correct.

 void GuessingGame() {

    
    Console.WriteLine("Wanna play a game?");
    Console.WriteLine("Choose your difficulty level:");
    Console.WriteLine("Press 1: Easy Peasy Lemon Squeezy");
    Console.WriteLine("Press 2: Mid - No Cap, Bruh");
    Console.WriteLine("Press 3: Difficult Difficult Lemon Difficult");
    Console.WriteLine("Press 4: So you've chosen death");
    string level = Console.ReadLine();

//it's like an if/else - it is checking for a specific variable - if a particular case is chosen then do this
    switch(level) {
        case "1":
        GamePlay(8);
        break;
        case "2":
        GamePlay(6);
        break;
        case "3":
        GamePlay(4);
        break;
        case "4":
        Console.WriteLine("Cheater Cheater Pumpkin Eater");
        GamePlay(int.MaxValue);
        break;
    }
 }

 void GamePlay(int attempts){
    int SecretNumber = new Random().Next(0, 100);
    // int attempts = 0;
    int i = 0;      
    while(i < attempts){
    Console.WriteLine("Guess a secret number");
    string input = Console.ReadLine();
    // Console.WriteLine($"You guessed {input}");
    int ParsedInput = int.Parse(input);
    
    //int SecretNumber = 42;
    // Console.WriteLine(SecretNumber);

        Console.WriteLine($"You have this many guesses left ({attempts - i - 1})");
    if(ParsedInput == SecretNumber) {
        Console.WriteLine("Great success");
        break;
    }
    else {
        string guess = ParsedInput > SecretNumber ? "The rent is too damn high" : "Too low. This is a van by the river";
        Console.WriteLine($"WRONG-O! Try again {guess}");
    }
    i++;

    }

}

GuessingGame();