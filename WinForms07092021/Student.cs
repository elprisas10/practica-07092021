﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WinForms07092021
{
    class Student
    {
        public int idStudent { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public int age { get; set; }

        public static List<Student> GetStudents()
        {
            List<Student> Students = new List<Student>

        {
            new Student {idStudent=1001, firstName="Jose", lastName= "Gonzales", age=20},
            new Student {idStudent=1002, firstName="Jonathan", lastName= "Gamez", age=19},
            new Student {idStudent=1003, firstName="Emiliano", lastName= "Ramirez", age=17},
            new Student {idStudent=1004, firstName="Maria", lastName= "Alejandra", age=25},
            new Student {idStudent=1005, firstName="Alexander", lastName= "Hernandez", age=24},
        };

            return Students;
        }

    }
}

