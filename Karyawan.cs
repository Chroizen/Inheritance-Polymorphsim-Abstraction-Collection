﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasLab8.ClassInduk
{
    public abstract class Karyawan
    {
        public string Name { get; set; }
        public string NIK { get; set; }
        public abstract double Gaji();
    }
}
