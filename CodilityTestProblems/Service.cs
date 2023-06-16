using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityTestProblems
{
    public class Service
    {
        public string ReturnMessage(string message, int numOfChars)
        {
            // Trim message input to remove spaces before and after
            string messageInput = message.Trim();

            var messageIsValid = isMessageValid(messageInput);
            var charactersAreValid = AreCharactersValid(numOfChars);

            // Create variable to hold final message
            string outputMessage;
            // If one or both message or numOfChars is invalid, error message will be returned
            if (!charactersAreValid || !messageIsValid)
            {
                outputMessage = GenerateErrorMessage(charactersAreValid, messageIsValid);
                return outputMessage;
            }

            outputMessage = GenerateOutputMessage(messageInput, numOfChars);
            
            return outputMessage.Trim();
        }

        private string GenerateOutputMessage(string message, int numOfChars)
        {
            // Create variable to hold final message
            string output = string.Empty;
            // variable to store total number of characters in message
            int numOfCharsInOutputMessage = 0;
            // separate message by spaces into a list
            List<string> separatedMessageWords = message.Split(" ").ToList();
            // Create list var to check if total number of chars is less than K provided
            List<string> separatedMessageCharacters = new List<string>();

            // Cycle through each individual word in message    
            for (int i = 0; i < separatedMessageWords.Count; i++)
            {
                // Trim each word to avoid excess spaces
                foreach (char character in separatedMessageWords[i].Trim().ToCharArray())
                {
                    separatedMessageCharacters.Add(character.ToString());
                }
                // Add a space after the word
                separatedMessageCharacters.Add(" ");

                // If the first word is over the limit K provided, return "..."
                if (separatedMessageCharacters.Count > numOfChars || separatedMessageCharacters.Count + 3 > numOfChars)
                {
                    output += "...";
                    break;
                }

                // if the number of characters so far has room for an ellipses, it'll be added to the output
                if (separatedMessageCharacters.Count <= numOfChars - 3)
                {
                    output += $"{separatedMessageWords[i]} ";
                    numOfCharsInOutputMessage += separatedMessageCharacters.Count;
                }
                else
                {
                    output = output + "...";
                    break;
                }
            }
            return output;
        }

        private string GenerateErrorMessage(bool charactersAreValid, bool messageIsValid)
        {
            string maxNumOfCharsError = "Number of characters provided must be 3-500";
            string messageError = "Number of characters in input message must be between 1-500";

            string errorMessage = string.Empty;
            // If both are invalid
            if (!messageIsValid && !charactersAreValid) errorMessage = $"{maxNumOfCharsError} & {messageError}";
            // If just the max number of chars provided is invalid
            else if (!charactersAreValid) errorMessage = maxNumOfCharsError;
            // If the message itself is invalid
            else if (!messageIsValid) errorMessage = messageError;

            return errorMessage;
        }

        private bool AreCharactersValid(int numOfChars)
        {
            if (numOfChars > 3 && numOfChars <= 500) return true;
            
            return false;
        }

        private bool isMessageValid(string messageInput)
        {
            if (messageInput.ToArray().Length > 0 && messageInput.ToArray().Length <= 500) return true;
            
            return false;
        }
    }
}

