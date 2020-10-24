/*
 * Author: Nathan Connor
 * Class: RegisterViewModel.cs
 * Purpose: Act as an inbetween class to pass logic into the register UI
 */
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
        /// <summary>
        /// Constructor for RegisterviewModel
        /// </summary>
        /// <param name="t"></param>
        public RegisterViewModel(double t)
        {
            total = t;
            _amountDue = total;
        }

        private double _amountDue;
        /// <summary>
        /// The amount the user still has to pay
        /// </summary>
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

        /// <summary>
        /// gets the amount the user has given subtracted from the total that they owe
        /// </summary>
        /// <returns></returns>
        private double getAmountDue()
        {
            double amount = total;
            return amount - ((.01 * uPennies) + (.05 * uNickels) + (.1 * uDimes) + (.25 * uQuarters) + (.5 * uHalfDollars) + (1 * uDollars)
                + (1 * uOnes) + (2 * uTwos) + (5 * uFives) + (10 * uTens) + (20 * uTwenties) + (50 * uFifties) + (100 * uHundreds));
            
        }

        private double _changeOwed;

        /// <summary>
        /// The change that the cash register owes the user
        /// </summary>
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

        /// <summary>
        /// The pennies currently in the register
        /// </summary>
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

        /// <summary>
        /// The nickels currently in the register
        /// </summary>
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

        /// <summary>
        /// The dimes currently in the register
        /// </summary>
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
        /// <summary>
        /// The quarters currently in the register
        /// </summary>
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

        /// <summary>
        /// The dollar coins currently in the register
        /// </summary>
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

        /// <summary>
        /// The half dollars currently in the register
        /// </summary>
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

        /// <summary>
        /// The two dollar bills currently in the register
        /// </summary>
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

        /// <summary>
        /// The ones currently in the register
        /// </summary>
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

        /// <summary>
        /// The fives currently in the register
        /// </summary>
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

        /// <summary>
        /// The tens currently in the register
        /// </summary>
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

        /// <summary>
        /// The twenties currently in the register
        /// </summary>
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

        /// <summary>
        /// The fifties currently in the register
        /// </summary>
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

        /// <summary>
        /// The hundreds currently in the register
        /// </summary>
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

        /// <summary>
        /// The dimes that the user has given
        /// </summary>
        public int uDimes
        {
            get
            {
                return _uDimes;
            }
            set
            {
                _uDimes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("uDimes"));

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                MakeChange();

            }
        }
        private int _uPennies = 0;

        /// <summary>
        /// The pennies that the user has given
        /// </summary>
        public int uPennies
        {
            get
            {
                return _uPennies;
            }
            set
            {
                _uPennies = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("uPennies"));

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                MakeChange();

            }
        }

        private int _uNickels = 0;

        /// <summary>
        /// The nickels that the user has given
        /// </summary>
        public int uNickels
        {
            get
            {
                return _uNickels;
            }
            set
            {
                _uNickels = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("uNickels"));

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                MakeChange();


            }
        }

        private int _uQuarters = 0;

        /// <summary>
        /// The quarters that the user has given
        /// </summary>
        public int uQuarters
        {
            get
            {
                return _uQuarters;
            }
            set
            {
                _uQuarters = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("uQuarters"));

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                MakeChange();


            }
        }

        private int _uHalfDollars = 0;

        /// <summary>
        /// The half dollars that the user has given
        /// </summary>
        public int uHalfDollars
        {
            get
            {
                return _uHalfDollars;
            }
            set
            {
                _uHalfDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("uHalfDollars"));

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                MakeChange();


            }
        }

        private int _uDollars = 0;

        /// <summary>
        /// The dollars that the user has given
        /// </summary>
        public int uDollars
        {
            get
            {
                return _uDollars;
            }
            set
            {
                _uDollars = value; 
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("uDollars"));

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                MakeChange();



            }
        }

        private int _uOnes = 0;

        /// <summary>
        /// The ones that the user has given
        /// </summary>
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

                MakeChange();

            }
        }

        private int _uTwos = 0;

        /// <summary>
        /// The twos that the user has given
        /// </summary>
        public int uTwos
        {
            get
            {
                return _uTwos;
            }
            set
            {
                _uTwos = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("uTwos"));

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                MakeChange();


            }
        }

        private int _uFives = 0;

        /// <summary>
        /// The fives that the user has given
        /// </summary>
        public int uFives
        {
            get
            {
                return _uFives;
            }
            set
            {
                _uFives = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("uFives"));

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                MakeChange();


            }
        }

        private int _uTens = 0;

        /// <summary>
        /// The tens that the user has given
        /// </summary>
        public int uTens
        {
            get
            {
                return _uTens;
            }
            set
            {
                _uTens = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("uTens"));

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                MakeChange();


            }
        }

        private int _uTwenties = 0;

        /// <summary>
        /// The twenties that the user has given
        /// </summary>
        public int uTwenties
        {
            get
            {
                return _uTwenties;
            }
            set
            {
                _uTwenties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("uTwenties"));

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                MakeChange();


            }
        }

        private int _uFifties = 0;

        /// <summary>
        /// The fifties that the user has given
        /// </summary>
        public int uFifties
        {
            get
            {
                return _uFifties;
            }
            set
            {
                _uFifties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("uFifties"));

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                MakeChange();


            }
        }

        private int _uHundreds = 0;

        /// <summary>
        /// The hundreds that the user has given
        /// </summary>
        public int uHundreds
        {
            get
            {
                return _uHundreds;
            }
            set
            {
                _uHundreds = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("uHundreds"));

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                MakeChange();


            }
        }


        private int _changeDimes = 0;

        /// <summary>
        /// The dimes that the user is owed
        /// </summary>
        public int changeDimes
        {
            get
            {
                return _changeDimes;
            }
            set
            {
                _changeDimes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("changeDimes"));


            }
        }
        private int _changePennies = 0;

        /// <summary>
        /// The pennies that the user is owed
        /// </summary>
        public int changePennies
        {
            get
            {
                return _changePennies;
            }
            set
            {
                _changePennies = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("changePennies"));

            }
        }

        private int _changeNickels = 0;

        /// <summary>
        /// The nickels that the user is owed
        /// </summary>
        public int changeNickels
        {
            get
            {
                return _changeNickels;
            }
            set
            {
                _changeNickels = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("changeNickels"));


            }
        }

        private int _changeQuarters = 0;

        /// <summary>
        /// The quarters that the user is owed
        /// </summary>
        public int changeQuarters
        {
            get
            {
                return _changeQuarters;
            }
            set
            {
                _changeQuarters = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("changeQuarters"));


            }
        }

        private int _changeHalfDollars = 0;

        /// <summary>
        /// The half dollars that the user is owed
        /// </summary>
        public int changeHalfDollars
        {
            get
            {
                return _changeHalfDollars;
            }
            set
            {
                _changeHalfDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("changeHalfDollars"));


            }
        }

        private int _changeDollars = 0;

        /// <summary>
        /// The dollars that the user is owed
        /// </summary>
        public int changeDollars
        {
            get
            {
                return _changeDollars;
            }
            set
            {
                _changeDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("changeDollars"));


            }
        }

        private int _changeOnes = 0;

        /// <summary>
        /// The ones that the user is owed
        /// </summary>
        public int changeOnes
        {
            get
            {
                return _changeOnes;
            }
            set
            {
                _changeOnes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("changeOnes"));


            }
        }

        private int _changeTwos = 0;

        /// <summary>
        /// The twos that the user is owed
        /// </summary>
        public int changeTwos
        {
            get
            {
                return _changeTwos;
            }
            set
            {
                _changeTwos = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("changeTwos"));


            }
        }

        private int _changeFives = 0;

        /// <summary>
        /// The fives that the user is owed
        /// </summary>
        public int changeFives
        {
            get
            {
                return _changeFives;
            }
            set
            {
                _changeFives = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("changeFives"));


            }
        }

        private int _changeTens = 0;

        /// <summary>
        /// The tens that the user is owed
        /// </summary>
        public int changeTens
        {
            get
            {
                return _changeTens;
            }
            set
            {
                _changeTens = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("changeTens"));


            }
        }

        private int _changeTwenties = 0;

        /// <summary>
        /// The twenties that the user is owed
        /// </summary>
        public int changeTwenties
        {
            get
            {
                return _changeTwenties;
            }
            set
            {
                _changeTwenties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("changeTwenties"));


            }
        }

        private int _changeFifties = 0;

        /// <summary>
        /// The fifties that the user is owed
        /// </summary>
        public int changeFifties
        {
            get
            {
                return _changeFifties;
            }
            set
            {
                _changeFifties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("changeFifties"));


            }
        }

        private int _changeHundreds = 0;

        /// <summary>
        /// The hundreds that the user is owed
        /// </summary>
        public int changeHundreds
        {
            get
            {
                return _changeHundreds;
            }
            set
            {
                _changeHundreds = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("changeHundreds"));


            }
        }

        /// <summary>
        /// Calculates how much of each change the user is owed
        /// </summary>
        public void MakeChange()
        {
            double changeOwed = ChangeOwed;
            ResetChangeToZero();
            //when user dollar changes
            //notify amount due
            while (changeOwed > 1)
            {
                if (changeOwed >=100 && Hundreds>0)
                {
                    changeOwed -= 100;
                    changeHundreds++;

                }
                else
                    if (changeOwed >= 50 && Fifties > 0)
                {
                    changeOwed -= 50;
                    changeFifties++;

                }
                else
                    if (changeOwed >= 20 && Twenties > 0)
                {
                    changeOwed -= 20;
                    changeTwenties++;


                }
                else
                    if (changeOwed >= 10 && Tens > 0)
                {
                    changeOwed -= 10;
                    changeTens++;

                }
                else
                    if (changeOwed >= 5 && Fives > 0)
                {
                    changeOwed -= 5;
                    changeFives++;

                }
                else
                    if (changeOwed >= 2 && Twos > 0)
                {
                    changeOwed -= 2;
                    changeTwos++;

                }
                else
                    if (changeOwed >= 1 && Ones > 0)
                {
                    changeOwed -= 1;
                    changeOnes++;

                }
                else
                    if (changeOwed >= 1 && Dollars > 0)
                {
                    changeOwed -= 1;
                    changeDollars++;

                }
            }


            while (changeOwed >= .01)
            {
                if (changeOwed >= .5 && HalfDollars > 0)
                {
                    changeOwed -= .5;
                    changeHalfDollars++;


                }
                else
                    if (changeOwed >= .25 && Quarters > 0)
                {
                    changeOwed -= .25;
                    changeQuarters++;

                }
                else
                    if (changeOwed >= .1 && Dimes > 0)
                {
                    changeOwed -= .1;
                    changeDimes++;

                }
                else
                    if (changeOwed >= .05 && Nickels > 0)
                {
                    changeOwed -= .05;
                    changeNickels++;

                }
                else
                    if (changeOwed >= .01 && Pennies > 0)
                {
                    changeOwed -= .01;
                    changePennies++;

                }
            }
            
        }

        /// <summary>
        /// Resets the change the user is owed to zero
        /// </summary>
        private void ResetChangeToZero()
        {
            changePennies = 0;
            changeNickels = 0;
            changeDimes = 0;
            changeQuarters = 0;
            changeHalfDollars = 0;
            changeDollars = 0;

            changeOnes = 0;
            changeTwos = 0;
            changeFives = 0;
            changeTens = 0;
            changeTwenties = 0;
            changeFifties = 0;
            changeHundreds = 0;


        }

        /// <summary>
        /// Finalizes the sale and takes user money and gives user change
        /// </summary>
        public void FinalizeSale()
        {
            CashDrawer.OpenDrawer();
            Pennies += uPennies;
            Nickels += uNickels;
            Dimes += uDimes;
            Quarters += uQuarters;
            HalfDollars += uHalfDollars;
            Dollars += uDollars;

            Ones += uOnes;
            Twos += uTwos;
            Fives += uFives;
            Tens += uTens;
            Twenties += uTwenties;
            Fifties += uFifties;
            Hundreds += uHundreds;

            Pennies -= changePennies;
            Nickels -= changeNickels;
            Dimes -= changeDimes;
            Quarters -= changeQuarters;
            HalfDollars -= changeHalfDollars;
            Dollars -= changeDollars;

            Ones -= changeOnes;
            Twos -= changeTwos;
            Fives -= changeFives;
            Tens -= changeTens;
            Twenties -= changeTwenties;
            Fifties -= changeFifties;
            Hundreds -= changeHundreds;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
