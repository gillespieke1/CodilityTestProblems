using CodilityTestProblems;

namespace CodilityTests
{
    public class MessageTests
    {
        Service service = new Service();

        [Fact]
        public void PhraseTest1()
        {
            string inputMessage = "And now here is my secret";
            int numberOfChars = 5;

            string output = service.ReturnMessage(inputMessage, numberOfChars);

            Assert.True(output.ToArray().Length == 3);
        }

        [Fact]
        public void PhraseTest2()
        {
            string inputMessage = "There is an animal with four legs";
            int numberOfChars = 15;

            string output = service.ReturnMessage(inputMessage,numberOfChars);

            Assert.True(output.ToArray().Length == 15);
        }

        [Fact]
        public void PhraseTest3() 
        {
            string inputMessage = "super dog"; 
            int numberOfChars = 4;

            string output = service.ReturnMessage(inputMessage, numberOfChars);

            Assert.True(output.ToArray().Length == 3);
        }

        [Fact]
        public void PhraseLessThanNumOfCharsTest()
        {
            string input = "how are you"; 
            int numberOfChars = 20;

            string output = service.ReturnMessage(input, numberOfChars);

            Assert.True(output.ToArray().Length == 11);
        }

        [Fact]
        public void OneAndTwoLetterWordsTest()
        {
            string inputMessage = "a bb cc dd e ff";
            int numberOfChars = 9;

            string output = service.ReturnMessage(inputMessage, numberOfChars);

            Assert.True(output.ToArray().Length == 8);
        }

        [Fact]
        public void MessageIsTooLong()
        {
            string inputMessage = "aaaaaaaaaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbbbbbbb" +
                "cccccccccccccccccccccccccccccdddddddddddddddddddddddddeeeeeeeeeeeeeeeeeeeeeeeeeee" +
                "fffffffffffffffffffffffffffffffgggggggggggggggggggggggghhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh " +
                "lllllllllllllllllllllllllllllllllllllllllmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm" +
                "nnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnoooooooooooooooooo " +
                "pppppppppppppppppppppppppppqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqrrrrrrrrrrrrrrrrrrrrrrrr" +
                "ssssssssssssssssssssssssssssssssssstttttttttttttttttttttttttttuuuuuuuuu";
            int numberOfChars = 10;

            string output = service.ReturnMessage(inputMessage, numberOfChars);

            // Assert that the message return has 59 characters of the error message
            Assert.True(output.ToArray().Length == 59);
        }

        [Fact]
        public void MessageIsEmpty()
        {
            string inputMessage = " ";
            int numberOfChars = 10;

            string output = service.ReturnMessage(inputMessage, numberOfChars);

            // Assert that the message return has 59 characters of the error message
            Assert.True(output.ToArray().Length == 59);
        }

        [Fact]
        public void NumOfCharsIsOver500()
        {
            string inputMessage = "aa bb cc dd ee ff gg h";
            int numberOfChars = 501;

            string output = service.ReturnMessage(inputMessage, numberOfChars);

            // Assert that the message return has 59 characters of the error message
            Assert.True(output.ToArray().Length == 43);
        }

        [Fact]
        public void NumOfCharsIsLessThan0()
        {
            string inputMessage = "aa bb cc dd ee ff gg h";
            int numberOfChars = -1;

            string output = service.ReturnMessage(inputMessage, numberOfChars);

            // Assert that the message return has 59 characters of the error message
            Assert.True(output.ToArray().Length == 43);
        }

        [Fact]
        public void MessageAndNumOfCharsInvalid()
        {
            string inputMessage = "aaaaaaaaaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbbbbbbb" +
                "cccccccccccccccccccccccccccccdddddddddddddddddddddddddeeeeeeeeeeeeeeeeeeeeeeeeeee" +
                "fffffffffffffffffffffffffffffffgggggggggggggggggggggggghhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh " +
                "lllllllllllllllllllllllllllllllllllllllllmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm" +
                "nnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnoooooooooooooooooo " +
                "pppppppppppppppppppppppppppqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqrrrrrrrrrrrrrrrrrrrrrrrr" +
                "ssssssssssssssssssssssssssssssssssstttttttttttttttttttttttttttuuuuuuuuu";
            int numberOfChars = 501;

            string output = service.ReturnMessage(inputMessage, numberOfChars);

            // Assert that the message return has 59 characters of the error message
            Assert.True(output.ToArray().Length == 105);
        }
    }
}