﻿using Boolean.CSharp.Main.Accounts.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main.Accounts
{
    public class NormalAcc : Account
    {
        public NormalAcc(Branches branch) : base(branch)
        {
            _Type = AccountType.Current;
        }
    }
}