using System;

namespace Interface
{
    class ArithmeticProgression : IIndexableSeries
    {
        //Создание исключения в том случае, если свойства не реализованы
        int IIndexable.index => throw new NotImplementedException();
        double IIndexable.val_index => throw new NotImplementedException();
        double IIndexable.start => throw new NotImplementedException();
        double IIndexable.val1_index => throw new NotImplementedException();
        //Конструктор для передачи значений свойств переменным
        public ArithmeticProgression(double val_index, double start, int index)
        {
            _index = index;
            _val = val_index;
            _start = start;
        }
        int _index;
        double _start, _val;

        double ISeries.GetCurrent()//Текущий элемент
        {
            _val += _val;
            return _val;
        }

        bool ISeries.MoveNext()//Перейти к следующему
        {
            return true;
        }

        void ISeries.Reset()//Начать заново
        {
            _val = _start;
        }

    }
}
