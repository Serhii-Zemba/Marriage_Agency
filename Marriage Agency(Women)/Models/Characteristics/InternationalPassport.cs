﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marriage_Agency_Women_.Models.Characteristics
{
    public class InternationalPassport : PersonalData
    {
        public InternationalPassport() : base()
        {

        }
        public InternationalPassport(int position, string russian, string english, string japanese) : base(position, russian, english, japanese)
        {
        }
    }
}