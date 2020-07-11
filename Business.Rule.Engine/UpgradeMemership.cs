using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Rule.Engine
{
    internal class UpgradeMemership:IBusinessRuleExecuter
    {
        private dynamic Data;
        public UpgradeMemership(dynamic data)
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
