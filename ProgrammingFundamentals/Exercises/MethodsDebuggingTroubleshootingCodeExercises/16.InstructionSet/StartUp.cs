using System;

class InstructionSet_broken
{
    static void Main()
    {
        string instruction = Console.ReadLine();

        while (instruction != "END")
        {
            string[] splitWords = instruction.Split(' ');

            long result = 0;
            switch (splitWords[0])
            {
                case "INC":
                    {
                        long operandOne = long.Parse(splitWords[1]);
                        result = ++operandOne;// the operator must be as a prefix
                        break;
                    }
                case "DEC":
                    {
                        long operandOne = long.Parse(splitWords[1]);
                        result = --operandOne;// the operator must be as a prefix
                        break;
                    }
                case "ADD":
                    {
                        long operandOne = long.Parse(splitWords[1]);
                        long operandTwo = long.Parse(splitWords[2]);
                        result = operandOne + operandTwo;
                        break;
                    }
                case "MLA":
                    {
                        long operandOne = long.Parse(splitWords[1]);// data type must be long
                        long operandTwo = long.Parse(splitWords[2]);
                        result = operandOne * operandTwo;
                        break;
                    }
            }

            Console.WriteLine(result);
            instruction = Console.ReadLine();// read the instruction again till "END"
        }
    }
}