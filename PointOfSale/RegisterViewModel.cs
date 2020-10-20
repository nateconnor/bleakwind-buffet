using RoundRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PointOfSale
{
    public class RegisterViewModel : INotifyPropertyChanged
    {
        private double total;
        public RegisterViewModel(double t)
        {
            total = t;
            _amountDue = total;
        }

        private double _amountDue;
        public double AmountDue
        {
            get
            {
                double amount = getAmountDue();
                if (amount < 0)
                {
                    return 0;

                }
                else return amount;
            }
            set
            {
                _amountDue = value;
            }
        }

        private double getAmountDue()
        {
            double amount = total;
            return amount - ((.01 * uPennies) + (.05 * uNickels) + (.1 * uDimes) + (.25 * uQuarters) + (.5 * uHalfDollars) + (1 * uDollars)
                + (1 * uOnes) + (2 * uTwos) + (5 * uFives) + (10 * uTens) + (20 * uTwenties) + (50 * uFifties) + (100 * uHundreds));
            
        }

        private double _changeOwed;
        public double ChangeOwed
        {
            get
            {
                double amount = getAmountDue();
                if (amount < 0)
                    return amount * -1;
                else return 0;
            }
            set
            {
                _changeOwed = value;
            }
        }

        public int Pennies
        {
            get
            {
                return CashDrawer.Pennies;
            }
            set
            {
                CashDrawer.Pennies = value;

            }
        }

        public int Nickels
        {
            get
            {
                return CashDrawer.Nickels;
            }
            set
            {
                CashDrawer.Nickels = value;

            }
        }


        public int Dimes
        {
            get
            {
                return CashDrawer.Dimes;
            }
            set
            {
                CashDrawer.Dimes = value;

            }
        }
        public int Quarters
        {
            get
            {
                return CashDrawer.Quarters;
            }
            set
            {
                CashDrawer.Quarters = value;

            }
        }
        public int Dollars
        {
            get
            {
                return CashDrawer.Dollars;
            }
            set
            {
                CashDrawer.Dollars = value;

            }
        }
        public int HalfDollars
        {
            get
            {
                return CashDrawer.HalfDollars;
            }
            set
            {
                CashDrawer.HalfDollars = value;

            }
        }
        public int Twos
        {
            get
            {
                return CashDrawer.Twos;
            }
            set
            {
                CashDrawer.Twos = value;

            }
        }
        public int Ones
        {
            get
            {
                return CashDrawer.Ones;
            }
            set
            {
                CashDrawer.Ones = value;
                
            }
        }
        public int Fives
        {
            get
            {
                return CashDrawer.Fives;
            }
            set
            {
                CashDrawer.Fives = value;

            }
        }
        public int Tens
        {
            get
            {
                return CashDrawer.Tens;
            }
            set
            {
                CashDrawer.Tens = value;

            }
        }
        public int Twenties
        {
            get
            {
                return CashDrawer.Twenties;
            }
            set
            {
                CashDrawer.Twenties = value;

            }
        }
        public int Fifties
        {
            get
            {
                return CashDrawer.Fifties;
            }
            set
            {
                CashDrawer.Fifties = value;

            }
        }
        public int Hundreds
        {
            get
            {
                return CashDrawer.Hundreds;
            }
            set
            {
                CashDrawer.Hundreds = value;

            }
        }
        
        private int _uDimes=0;
        public int uDimes
        {
            get
            {
                return _uDimes;
            }
            set
            {
                _uDimes = value;

            }
        }
        private int _uPennies = 0;
        public int uPennies
        {
            get
            {
                return _uPennies;
            }
            set
            {
                _uPennies = value;

            }
        }

        private int _uNickels = 0;
        public int uNickels
        {
            get
            {
                return _uNickels;
            }
            set
            {
                _uNickels = value;

            }
        }

        private int _uQuarters = 0;
        public int uQuarters
        {
            get
            {
                return _uQuarters;
            }
            set
            {
                _uQuarters = value;

            }
        }

        private int _uHalfDollars = 0;
        public int uHalfDollars
        {
            get
            {
                return _uHalfDollars;
            }
            set
            {
                _uHalfDollars = value;

            }
        }

        private int _uDollars = 0;
        public int uDollars
        {
            get
            {
                return _uDollars;
            }
            set
            {
                _uDollars = value; 
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));


            }
        }

        private int _uOnes = 0;
        public int uOnes
        {
            get
            {
                return _uOnes;
            }
            set
            {
                _uOnes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("uOnes"));

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));


            }
        }

        private int _uTwos = 0;
        public int uTwos
        {
            get
            {
                return _uTwos;
            }
            set
            {
                _uTwos = value;

            }
        }

        private int _uFives = 0;
        public int uFives
        {
            get
            {
                return _uFives;
            }
            set
            {
                _uFives = value;

            }
        }

        private int _uTens = 0;
        public int uTens
        {
            get
            {
                return _uTens;
            }
            set
            {
                _uTens = value;

            }
        }

        private int _uTwenties = 0;
        public int uTwenties
        {
            get
            {
                return _uTwenties;
            }
            set
            {
                _uTwenties = value;

            }
        }

        private int _uFifties = 0;
        public int uFifties
        {
            get
            {
                return _uFifties;
            }
            set
            {
                _uFifties = value;

            }
        }

        private int _uHundreds = 0;
        public int uHundreds
        {
            get
            {
                return _uHundreds;
            }
            set
            {
                _uHundreds = value;

            }
        }


        private int _changeDimes = 0;
        public int changeDimes
        {
            get
            {
                return _changeDimes;
            }
            set
            {
                _changeDimes = value;

            }
        }
        private int _changePennies = 0;
        public int changePennies
        {
            get
            {
                return _changePennies;
            }
            set
            {
                _changePennies = value;

            }
        }

        private int _changeNickels = 0;
        public int changeNickels
        {
            get
            {
                return _changeNickels;
            }
            set
            {
                _changeNickels = value;

            }
        }

        private int _changeQuarters = 0;
        public int changeQuarters
        {
            get
            {
                return _changeQuarters;
            }
            set
            {
                _changeQuarters = value;

            }
        }

        private int _changeHalfDollars = 0;
        public int changeHalfDollars
        {
            get
            {
                return _changeHalfDollars;
            }
            set
            {
                _changeHalfDollars = value;

            }
        }

        private int _changeDollars = 0;
        public int changeDollars
        {
            get
            {
                return _changeDollars;
            }
            set
            {
                _changeDollars = value;

            }
        }

        private int _changeOnes = 0;
        public int changeOnes
        {
            get
            {
                return _changeOnes;
            }
            set
            {
                _changeOnes = value;

            }
        }

        private int _changeTwos = 0;
        public int changeTwos
        {
            get
            {
                return _changeTwos;
            }
            set
            {
                _changeTwos = value;

            }
        }

        private int _changeFives = 0;
        public int changeFives
        {
            get
            {
                return _changeFives;
            }
            set
            {
                _changeFives = value;

            }
        }

        private int _changeTens = 0;
        public int changeTens
        {
            get
            {
                return _changeTens;
            }
            set
            {
                _changeTens = value;

            }
        }

        private int _changeTwenties = 0;
        public int changeTwenties
        {
            get
            {
                return _changeTwenties;
            }
            set
            {
                _changeTwenties = value;

            }
        }

        private int _changeFifties = 0;
        public int changeFifties
        {
            get
            {
                return _changeFifties;
            }
            set
            {
                _changeFifties = value;

            }
        }

        private int _changeHundreds = 0;
        public int changeHundreds
        {
            get
            {
                return _changeHundreds;
            }
            set
            {
                _changeHundreds = value;

            }
        }

        public void MakeChange(double changeOwed)
        {
            while (changeOwed > 1)
            {
                if (changeOwed >100 && Hundreds>0)
                {
                    changeOwed -= 100;
                    Hundreds--;
                    changeHundreds++;
                }
                else
                    if (changeOwed > 50 && Fifties > 0)
                {
                    changeOwed -= 50;
                    Fifties--;
                    changeFifties++;

                }
                else
                    if (changeOwed > 20 && Twenties > 0)
                {
                    changeOwed -= 20;
                    Twenties--;
                    changeTwenties++;

                }
                else
                    if (changeOwed > 10 && Tens > 0)
                {
                    changeOwed -= 10;
                    Tens--;
                    changeTens++;

                }
                else
                    if (changeOwed > 5 && Fives > 0)
                {
                    changeOwed -= 5;
                    Fives--;
                    changeFives++;
                }
                else
                    if (changeOwed > 2 && Twos > 0)
                {
                    changeOwed -= 2;
                    Twos--;
                    changeTwos++;
                }
                else
                    if (changeOwed > 1 && Ones > 0)
                {
                    changeOwed -= 1;
                    Ones--;
                    changeOnes++;
                }
                else
                    if (changeOwed > 1 && Dollars > 0)
                {
                    changeOwed -= 1;
                    Dollars--;
                    changeDollars++;
                }
            }
            while (changeOwed != 0)
            {
                if (changeOwed > .5 && HalfDollars > 0)
                {
                    changeOwed -= .5;
                    HalfDollars--;
                    changeHalfDollars++;
                    
                }
                else
                    if (changeOwed > .25 && Quarters > 0)
                {
                    changeOwed -= .25;
                    Quarters--;
                    changeQuarters++;
                }
                else
                    if (changeOwed > .1 && Dimes > 0)
                {
                    changeOwed -= .1;
                    Dimes--;
                    changeDimes++;
                }
                else
                    if (changeOwed > .05 && Nickels > 0)
                {
                    changeOwed -= .05;
                    Nickels--;
                    changeNickels++;
                }
                else
                    if (changeOwed > .01 && Pennies > 0)
                {
                    changeOwed -= .01;
                    Pennies --;
                    changePennies++;
                }
            }

        }





        public event PropertyChangedEventHandler PropertyChanged;
    }
}
