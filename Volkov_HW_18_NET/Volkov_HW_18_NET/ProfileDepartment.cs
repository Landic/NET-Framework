﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_18_NET
{
    internal class ProfileDepartment : IDepartment
    {
        string lesson;

        public ProfileDepartment()
        {
            lesson = string.Empty;
        }

        public ProfileDepartment(string lesson)
        {
            this.lesson = lesson;
        }

        public void Lesson()
        {
            Console.WriteLine("Enter profile department lesson which you spend");
            lesson = Console.ReadLine();
        }

        public Teacher Head { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
