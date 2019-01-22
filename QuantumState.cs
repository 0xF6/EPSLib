namespace EPS
{
    using System;

    public enum QBit
    {
        Negative = -1,
        Zero,
        Positive
    }
    public struct QuantumState
    {
        public QBit Value;
        
        public QuantumState(int value = 0)
        {
            switch (value)
            {
                case -1:
                    Value = QBit.Negative;
                    break;
                case 1:
                    Value = QBit.Positive;
                    break;
                case 0:
                    Value = QBit.Zero;
                    break;
                default:
                    throw new IndexOutOfRangeException($"QBit value can't set '{value}'");
            }
        }
    }
}