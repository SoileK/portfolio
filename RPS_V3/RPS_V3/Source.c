#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <time.h>
#include <ctype.h>

//define the functions
int askRounds();
int askChoice();
int generate();
int checkWin(int userChoiceAsInt, int ComputersChoice);
void keepScore(int result, int* wins, int* ComputerWins);
void printResult(int ComputerWins, int rounds, int wins);

int main()
{
	//define the variables
	int wins = 0;
	int ComputerWins = 0;
	int ComputersChoice = 0;
	int rounds = 0;
	int userChoiceAsInt = 0;
	char userChoiceAsChar = ' ';
	int result = 0;

	//print welcome message
	printf("Welcome to rock-paper-scissors game!\n\n");

	//Call for a function to ask the rounds and chek the input
	rounds = askRounds();		

	//For-loop to run the game the number of times the player wanted
	for (int i = 0; i < rounds; i++)
	{
		//Call for function to ask for players choice
		userChoiceAsInt = askChoice();
		
		//Call for function to generate computers choice
		ComputersChoice = generate();
		
		//Call for function to check who won
		result = checkWin(userChoiceAsInt, ComputersChoice);
		
		//Call for a function to update the score using pointers
		keepScore(result, &wins, &ComputerWins);
	}

	//Call for function to print final result
	printResult(ComputerWins, rounds, wins);

	return 0;
}

int askRounds()
{
	char input[5];
	int length = 0;
	char test = ' ';
	int rounds = 0;

	//do-while loop to give the player a chance to give correct input as a single character which is a number
	//there is probably easier way to do this, but this is the only way I came up with
	do
	{
		//ask for number of rounds
		printf("How many rounds (1-9) do you wish to play? ");
		//read the input into char pointer
		char *p_input = gets_s(&input, 5);
		//get the lenght of the input
		length = strlen(input);
		printf("\n");

		//if the input is one character long
		if (length == 1)
		{
			test = *p_input; //read the value of the pointer to a new variable

			//test if the single character is a number
			if (isdigit(test))
			{
				rounds = test - '0';	//read the char to int
			}
			else
			{
				printf("Invalid input, please give rounds as a number\n\n");	//tell the player about invalid input
			}
		}
		else
		{
			printf("Invalid input, please give rounds as a number between 1-9\n\n");	//tell the player about invalid input
		}
	} while (isdigit(test) == 0);	//Do as long as player input fails the test

	return rounds;
}

int askChoice()
{
	char userChoiceAsChar = ' ';
	int userChoiceAsInt = 0;
	char input[5];
	int length = 0;

	//Do-While loop to inform about invalid inputs and not to count them as inputs
	do
	{
		//ask for players choice
		printf("Give your choice (R)ock, (P)aper, (S)cissors: ");
		//read the input to char pointer
		char *p_input = gets_s(&input, 5);
		//get the lenght of the input
		length = strlen(input);

		//if player entered only one charachter
		if (length == 1)
		{
			//change the char choice to numerical value
			switch (*p_input)
			{
			case'r':
			case'R':
				userChoiceAsInt = 1;		//rock to corresponding numerical value
				break;
			case'p':
			case'P':
				userChoiceAsInt = 2;		//paper to corresponding numerical value
				break;
			case's':
			case'S':
				userChoiceAsInt = 3;		//scissors to corresponding numerical value
				break;
			default:
				printf("Invalid input, try again\n\n");		//tell the player about invalid input
				break;
			}
		}
		else
		{
			printf("Invalid input, try again\n\n");		//tell the player about invalid input
		}
	} while (userChoiceAsInt != 1 && userChoiceAsInt != 2 && userChoiceAsInt != 3);		//Do as long as the input is invalid

	return userChoiceAsInt; 
}

int generate()
{
	//initialize the randon number generator
	srand(time(0));

	//Generate computers choice between 1-3
	int ComputersChoice = rand() % 3 + 1;
	return ComputersChoice;
}

int checkWin(int userChoiceAsInt, int ComputersChoice)
{
	int result = 0;
	
	//check who won
	if (userChoiceAsInt == ComputersChoice)		//if both are same
	{
		result = 0;
		printf("Tie!\n\n");
	}
	else if (userChoiceAsInt == 1 && ComputersChoice == 3)	//if player rock, computer scissors
	{
		result = 1;
		printf("You win! Computer chose: scissors\n\n");
	}
	else if (userChoiceAsInt == 2 && ComputersChoice == 1)	//if player paper, computer rock
	{
		result = 1;
		printf("You win! Computer chose: rock\n\n");
	}
	else if (userChoiceAsInt == 3 && ComputersChoice == 2)	//if player scissors, computer paper
	{
		result = 1;
		printf("You win! Computer chose: paper\n\n");
	}
	else if (userChoiceAsInt == 3 && ComputersChoice == 1)	//if player scissors, computer rock
	{
		result = -1;
		printf("Computer wins. Computer chose: rock\n\n");
	}
	else if (userChoiceAsInt == 1 && ComputersChoice == 2)	//if player rock, computer paper
	{
		result = -1;
		printf("Computer wins. Computer chose: paper\n\n");
	}
	else if (userChoiceAsInt == 2 && ComputersChoice == 3)	//if player paper, computer scissors
	{
		result = -1;
		printf("Computer wins. Computer chose: scissors\n\n");
	}

	return result;
}

void keepScore(int result, int* wins, int* ComputerWins)
{
	if (result == 1)
	{
		*wins = *wins + 1;		//players score is added by one using a pointer
	}
	else if (result == -1)
	{
		*ComputerWins = *ComputerWins + 1;		//computers score is added by one using a pointer
	}
}

void printResult(int ComputerWins, int rounds, int wins)
{
	//print the final result
	printf("...The game ends...\n");
	printf("You won %i/%i times\n", wins, rounds);
	printf("Computer won %i/%i times\n", ComputerWins, rounds);
	printf("Number of ties %i\n", rounds - wins - ComputerWins);
}