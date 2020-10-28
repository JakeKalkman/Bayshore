using System.Collections.Generic;

namespace Challenges.Domain.Interfaces
{
    public interface IExerciseManager
    {
        bool IsNumberPalidrome(string number);
        string SpiralMatrixToNumber(int number);
    }
}