using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class OperationManager : MonoBehaviour
{
    public enum Mode
    {
        Addition = 0,
        Subtraction = 1,
        Multiplication = 2,
        Division = 3
    }

    public class Operation
    {
        public string Text; // Text representation of the operation
        public int Answer; // Correct answer to the operation
    }

    public class Question
    {
        public Operation Operation; // The operation
        public List<int> Answers; // List of answers
    }

    public static Question GetNewOperation(int _difficulty, params Mode[] _modes)
    {
        Question question = new ();
        Operation operation = new();
        List<int> answers = new();
        Mode operationMode = _modes[Random.Range(0, _modes.Length)]; // Select a game mode

        int num1, num2;

        int operandA = GetRandomOperand(_difficulty); // Generate the first operand
        int operandB = GetRandomOperand(_difficulty); // Generate the second operand

        switch (operationMode)
        {
            case Mode.Addition:
                num1 = operandA;
                num2 = operandB;

                operation.Text = string.Format("{0} + {1} = ?", num1, num2);
                operation.Answer = num1 + num2; // Calculate the correct answer
                break;

            case Mode.Subtraction:
                num1 = operandA;
                num2 = operandB;

                if (num1 >= num2)
                {
                    operation.Answer = num1 - num2; // Calculate the correct answer
                    operation.Text = string.Format("{0} - {1} = ?", num1, num2);
                }
                else
                {
                    operation.Answer = num2 - num1; // Calculate the correct answer
                    operation.Text = string.Format("{0} - {1} = ?", num2, num1);
                }
                break;

            case Mode.Multiplication:
                num1 = operandA;
                num2 = operandB;

                operation.Text = string.Format("{0} x {1} = ?", num1, num2);
                operation.Answer = num1 * num2; // Calculate the correct answer
                break;

            case Mode.Division:
                int randomOperand1 = (int)Random.Range(1, _difficulty);
                int randomOperand2 = (int)Random.Range(1, _difficulty);
                int result = randomOperand1 * randomOperand2;
                num1 = result;
                num2 = (Random.Range(0, 2) == 1) ? randomOperand1 : randomOperand2;

                operation.Text = string.Format("{0} ÷ {1} = ?", num1, num2);
                operation.Answer = (num1 / num2); // Calculate the correct answer
                break;
        }

        answers.Add(operation.Answer); // Add the correct answer to the answers list
        //Calculate incorrect answers
        while (answers.Count < 4)
        {
            int randomRatio = Random.Range(0, 2);
            int incorrectAnswer;
            if (operation.Answer <= 4)
                incorrectAnswer = Random.Range(0, 12);
            else
                incorrectAnswer = Random.Range(0, randomRatio == 1 ? operation.Answer * 2 : operation.Answer);

            if (!answers.Contains(incorrectAnswer))
            {
                answers.Add(incorrectAnswer); // Add incorrect answers to the answers list
            }
        }

        question.Operation = operation;
        question.Answers = answers;

        return question;
    }

    // Helper method to get a random operand within the specified difficulty range
    private static int GetRandomOperand(int _difficulty)
    {
        int operand = Mathf.FloorToInt(Random.value * _difficulty);
        while (operand <= 0)//Protection against 0 when difficulty value is in small range.
        {
            operand = Mathf.FloorToInt(Random.value * _difficulty);
        }
        return operand;
    }
}
