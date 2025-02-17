﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Computer
    {
        private string _name;
        private RAM _RAM;
        private string _sizeHDD;
        private string _oS;
        private bool _condition = false;

        public Computer(string name, int sizeRAM, string sizeHDD, string operSis)
        {
            _name = name;
            _RAM = new RAM("Nvidia",sizeRAM);
            _sizeHDD = sizeHDD;
            _oS = operSis;
        }

        public void TurnOn()
        {
            _condition = true;
            if (_oS == "")
            {
                Console.WriteLine("Что бы включить ПК сначало установите ОС");
            }
            else
            {
                Console.WriteLine("Компьютер включён");
            }
        }

        public string InstallOS(string OS)
        {
            _oS = OS;
            if (_condition == true)
            {
                Console.WriteLine($"Начата установка операционной системы {OS}");
            }
            else if (_condition == false)
            {
                Console.WriteLine("Невозможно установить ОС так как пк выключен");
            }
            return _oS;
        }

        public void TurnOff()
        {
            _condition = false;
            Console.WriteLine("Компьютер выключен");
        }

        public void GetInfo()
        {
            Console.WriteLine($"Имя компьютера - {_name}");
            _RAM.GetInfo();
            Console.WriteLine($"Количество памяти на жёстком диске - {_sizeHDD}");
            Console.WriteLine($"Тип Операционной системы - {_oS}");
        }

        public bool ChangeRAM(RAM myRAM)
        {
            if (_condition == true)
            {
                Console.WriteLine($"Невозможно заменить оперативную память при включённном пк");
                return false;
            }
            _RAM = myRAM;
            Console.WriteLine($"Оперативная память успешно заменена");
            return true;
        }
    }
}
