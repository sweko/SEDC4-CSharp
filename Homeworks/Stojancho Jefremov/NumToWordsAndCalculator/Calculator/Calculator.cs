using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Calculator
    {

        private static ReadOnlyCollection<char> OPERATORS = new ReadOnlyCollection<char>
            (
               new List<char> { '*', '/', '+', '-' }
            );

        public static string ProcessInput(char input, string output)
        {
            
            if (input == 'C')
            {
                return "0";
            }

            if (input == '=')
            {
                return CalculateResult(output).ToString();
            }

            if (OPERATORS.IndexOf(input) > -1)
            {
                return ProcessOperator(input, output);
            }

            if (output == "0")
            {
                return input.ToString();
            }

            if ((output == "-") && (input == '0'))
            {
                return input.ToString();
            }

            var lastChar = output[output.Length - 1];
            if (!((lastChar == '/') && (input == '0')))
            {
                return output + input;
            }
            return output;           
        }

        private static string ProcessOperator(char input, string output)
        {
            var lastChar = output[output.length - 1];
            if (output != '0' && !isContained(lastChar, OPERATORS))
            {
                output += input;
            }
            else if (output == '0' && input == '-')
            {
                output = input;
            }
            else if (isContained(lastChar, OPERATORS) && output.length > 1)
            {
                output = output.replace(/.$/, input);
            }
            return output;
        }

        private static double CalculateResult(string expression)
        {
            var result = 0;
            var equation = expression;
            var lastChar = equation[equation.length - 1];
            if (isContained(lastChar, OPERATORS))
            {
                equation = equation.substring(0, equation.length - 1);
            }
            if (equation)
            {
                result = parseInt(parseAndCalculate(equation, OPERATORS));
            }
            return result;

            function parseAndCalculate(expression, OPERATORS) {
                var funcs = [multiply, divide, add, subtract];                 // the functions associated with the OPERATORS
                var tokens = expression.split(/\b /);      // split the string into "tokens" (numbers or OPERATORS)
                for (var operatorsIndex = 0; operatorsIndex < OPERATORS.length - 1; operatorsIndex += 2)
                {          // do this for every sign
                    for (var tokensIndex = 0; tokensIndex < tokens.length; tokensIndex++)
                    {    // do this for every token
                        var leftOperand = parseInt(tokens[tokensIndex - 1]);    // convert previous token to number
                        var rightOperand = parseInt(tokens[tokensIndex + 1]);   //convert next token to number
                        if (tokens[tokensIndex] == OPERATORS[operatorsIndex])
                        {                         // a sign is found
                            var result = funcs[operatorsIndex](leftOperand, rightOperand);           // call the appropriate function
                            tokens[tokensIndex - 1] = result.toString();      // store the result as a string
                            tokens.splice(tokensIndex, 2);  // delete obsolete tokens
                            tokensIndex--;  //and back up one place
                        }
                        else if (tokens[tokensIndex] == OPERATORS[operatorsIndex + 1])
                        {                         // a sign is found
                            if (tokens[tokensIndex] == '-' && isNaN(leftOperand) && !isNaN(rightOperand))
                            {   //unary subtract
                                leftOperand = 0;
                                result = funcs[operatorsIndex + 1](leftOperand, rightOperand);           // call the appropriate function
                                tokens[tokensIndex] = result.toString();      // store the result as a string
                                tokens.splice(tokensIndex + 1, 1);
                            }
                            else
                            {
                                result = funcs[operatorsIndex + 1](leftOperand, rightOperand);           // call the appropriate function
                                tokens[tokensIndex - 1] = result.toString();      // store the result as a string
                                tokens.splice(tokensIndex, 2);  // delete obsolete tokens
                                tokensIndex--;  //and back up one place
                            }
                        }
                    }
                }
                return tokens[0];                  // at the end tokens[] has only one item: the result

                
            }

        function multiply(x, y) {                   // the functions which actually do the math
                return x * y;
            }

            function divide(x, y) {                        // the functions which actually do the math
                return x / y;
            }

            function add(x, y) {                   // the functions which actually do the math
                return x + y;
            }

            function subtract(x, y) {                        // the functions which actually do the math
                return x - y;
            }

    }
}
