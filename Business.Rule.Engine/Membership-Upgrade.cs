using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Rule.Engine
{
    internal class Membership_Upgrade:IBusinessRuleExecuter
    {

        private dynamic Data;
        public Membership_Upgrade(dynamic data)
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
