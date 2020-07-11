using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Rule.Engine
{
    internal class Membership : IBusinessRuleExecuter
    {

        private dynamic Data;
        public Membership(dynamic data)
        {
            this.Data = data;
        }
        public bool Execute()
        {
            Console.WriteLine(Data);
            return true;
        }
    }
}
