﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DO
{
    public class Line
    {
        public int Id { get; set; }//bus id
        public int Code { get; set; }//bus line number
        public Areas Area { get; set; }
        public int FirstStation { get; set; }
        public int LastStation { get; set; }

    }
}

