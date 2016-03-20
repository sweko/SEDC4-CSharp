using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Calculator
    {

        private static IReadOnlyDictionary<char, Func<int, int, int>> OPERATORS = 
            new ReadOnlyDictionary<char, Func<int, int, int>>
            (
               new Dictionary<char, Func<int, int, int>>
               {
                   { '*',  (a,b) => a * b },
                   { '/', (a,b) => a / b },
                   { '+', (a,b) => a + b },
                   { '-', (a,b) => a - b } 
               }
            );

        /// <summary>
        /// Calculates new output value, having the current output value and the last entered character.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <returns></returns>
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

            if (OPERATORS.ContainsKey(input))
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

        /// <summary>
        /// Calculates new output value, having the current output value and the last entered character.
        /// If last entered character is not in OPERANDS then output will be returned unchanged.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        private static string ProcessOperator(char input, string output)
        {
            var lastChar = output.Last();
            if (output != "0" && !OPERATORS.ContainsKey(lastChar))
            {
                return output + input;
            }

            if (output == "0" && input == '-')
            {
                return input.ToString();
            }
            if (OPERATORS.ContainsKey(lastChar) && output.Length > 1)
            {
                return output.Substring(0, output.Length - 1) + input;
            }
            return output;
        }


        //private static int CalculateResult(string expression)
        //{
        //    var result = 0;
        //    var equation = expression;
        //    var lastChar = equation.Last();
        //    if (OPERATORS.ContainsKey(lastChar))
        //    {
        //        equation = equation.Substring(0, equation.Length - 1);
        //    }
        //    if (equation.Length > 0)
        //    {
        //        result = int.Parse(ParseAndCalculate(equation));
        //    }
        //    return result;
        //}

        /// <summary>
        /// Calculates the result of a given expression comprised from operators splitted with OPERANDS.
        /// Priority is given to multiplication and division over addition and subtraction
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        private static int CalculateResult(string expression)
        {
            var lastChar = expression.Last();

            if (OPERATORS.ContainsKey(lastChar))
            {
                expression = expression.Substring(0, expression.Length - 1);
            }

            if (expression.Length == 0)
            {
                return 0;
            }

            #region expressionParseAndGettingTheResult
            var tokens = Regex.Split(expression, @"\b") // split the string into "tokens" (numbers or OPERATORS)
                        .Where(t => t.Length > 0)
                        .ToList();      

            for (var operatorsIndex = 0; operatorsIndex < OPERATORS.Count - 1; operatorsIndex += 2)
            {    
                // do this for every sign
                for (var tokensIndex = 0; tokensIndex < tokens.Count; tokensIndex++)
                {    // do this for every token

                    int leftOperand, rightOperand;
                    bool leftOperandParsed, rightOperandParsed;
                    int result;

                    if (tokensIndex == 0)
                    {
                        leftOperandParsed = false;
                        leftOperand = 0;
                    }
                    else
                    {
                        leftOperandParsed = int.TryParse(tokens[tokensIndex - 1], out leftOperand);
                    }

                    if (tokensIndex > tokens.Count - 2)
                    {
                        rightOperandParsed = false;
                        rightOperand = 0;
                    }
                    else
                    {
                        rightOperandParsed = int.TryParse(tokens[tokensIndex + 1], out rightOperand);
                    }
                    
                    if (tokens[tokensIndex] == OPERATORS.Keys.ElementAt(operatorsIndex).ToString())
                    {                         // a sign is found
                        result = OPERATORS[OPERATORS.Keys.ElementAt(operatorsIndex)](leftOperand, rightOperand);           // call the appropriate function
                        tokens[tokensIndex - 1] = result.ToString();      // store the result as a string
                        tokens.RemoveRange(tokensIndex, 2);  // delete obsolete tokens
                        tokensIndex--;  //and back up one place
                    }
                    else if (tokens[tokensIndex] == OPERATORS.Keys.ElementAt(operatorsIndex + 1).ToString())
                    {                         // a sign is found
                        if (tokens[tokensIndex] == "-" && !leftOperandParsed && rightOperandParsed)
                        {   //unary subtract
                            leftOperand = 0;
                            result = OPERATORS[OPERATORS.Keys.ElementAt(operatorsIndex + 1)](leftOperand, rightOperand);           // call the appropriate function
                            tokens[tokensIndex] = result.ToString();      // store the result as a string
                            tokens.RemoveRange(tokensIndex + 1, 1);
                        }
                        else
                        {
                            result = OPERATORS[OPERATORS.Keys.ElementAt(operatorsIndex + 1)](leftOperand, rightOperand);           // call the appropriate function
                            tokens[tokensIndex - 1] = result.ToString();      // store the result as a string
                            tokens.RemoveRange(tokensIndex, 2);  // delete obsolete tokens
                            tokensIndex--;  //and back up one place
                        }
                    }
                }
            }
            #endregion
            return int.Parse(tokens[0]);                  // at the end tokens[] has only one item: the result

        }

    }

}
