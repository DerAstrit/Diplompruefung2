﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spicker
{
    abstract class Person
    {   
        public int Id { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public int Jahrgang { get; set; }
        public abstract void Anzeigen();
    }
}
