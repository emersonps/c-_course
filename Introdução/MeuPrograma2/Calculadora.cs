using System;

namespace MeuPrograma2
{
    class Calculadora
    {        
        int _number1, _number2;

        public void SetNumber1(int number1){
            _number1 = number1;
        }
        public void SetNumber2(int number2){
            _number2 = number2;
        }

        public int GetNumber1(){
            return _number1;
        }

        public int GetNumber2(){
            return _number2;
        }
    }
}
