using System;

namespace ClassMethods
{
    public class MondayClass
    {
        private int _value;
        public int MorningClass(int value = 10)
        {
            _value = value;
            return _value;
        }
    }
}