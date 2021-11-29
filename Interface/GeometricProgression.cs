using System;

namespace Interface
{
    class GeometricProgression : IIndexableSeries
    {
        //Создание исключения в том случае, если свойства не реализованы
        int IIndexable.index => throw new NotImplementedException();
        double IIndexable.val_index => throw new NotImplementedException();
        double IIndexable.start => throw new NotImplementedException();
        double IIndexable.val1_index => throw new NotImplementedException();
        //Конструктор для передачи значений свойств переменным
        public GeometricProgression(double val_index, double start, double val1_index, int index)
        {
            _index = index;
            _start = start;
            _val = val_index;
            _val1 = val1_index;
        }
        int _index;
        double _start, _val, _val1;

        double ISeries.GetCurrent()//Текущий элемент
        {
            _val = _val * _val1;
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

