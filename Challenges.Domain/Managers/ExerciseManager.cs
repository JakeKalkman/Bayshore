using Challenges.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Challenges.Domain.Managers
{
    public class ExerciseManager : IExerciseManager
    {
        // Exercise Six
        public bool IsNumberPalidrome(string number)
        {
            var result = string.Join(string.Empty, number.Reverse()) == number;
            return result;
        }

        //Exercise Three
        public string SpiralMatrixToNumber(int number)
        {
            var resultString = "";
            int matrixSize = (int)Math.Ceiling(Math.Sqrt(number));

            if (matrixSize % 2 == 0 || matrixSize * matrixSize == number)
            {
                matrixSize++;
            }

            int[,] matrix = new int[matrixSize, matrixSize];

            var direction = 1;
            var rotationCount = 0;
            var stepAmount = 1;
            var movementChain = 0;
            var currentX = (int)(Math.Floor((double)matrixSize * matrixSize / 2) % matrixSize);
            var currentY = (int)Math.Floor((double)matrixSize / 2);

            

            void ManageMovement()
            {
                movementChain++;
                if (movementChain == stepAmount)
                {
                    movementChain = 0;
                    if (direction == 0)
                    {
                        direction = 3;
                    }
                    else
                    {
                        direction--;
                    }

                    if (rotationCount == 1)
                    {
                        stepAmount++;
                        rotationCount = 0;
                    }
                    else
                    {
                        rotationCount++;
                    }
                }
            }

            for (int i = 1; i <= number; i++)
            {
                switch (direction)
                {
                    case 0:
                        currentX++;
                        matrix[currentY, currentX] = i;
                        ManageMovement();
                        break;
                    case 1:
                        currentY++;
                        matrix[currentY, currentX] = i;
                        ManageMovement();
                        break;
                    case 2:
                        currentX--;
                        matrix[currentY, currentX] = i;
                        ManageMovement();
                        break;
                    case 3:
                        currentY--;
                        matrix[currentY, currentX] = i;
                        ManageMovement();
                        break;
                    default:
                        break;
                }
            }

            for (int i = 0; i < matrixSize; i++)
            {
                for (int y = 0; y < matrixSize; y++)
                {
                    resultString += matrix[y, i] + " ";
                }

                resultString += "<br>";
            }

            return resultString;
        }       
    }
}
