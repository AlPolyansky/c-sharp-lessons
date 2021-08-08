using System;

namespace LessonApp
{
    [Serializable]
    class CustomExceptions : Exception
    {
        public enum ErrorCodes
        {
            MyArrayDataException,
            MyArraySizeException
        }

        public ErrorCodes Code { get; }

        public CustomExceptions(ErrorCodes code)
        {
            Code = code;
        }
    }
}
