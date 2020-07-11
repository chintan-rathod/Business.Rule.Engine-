using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Rule.Engine
{
    internal class Book : IBusinessRuleExecuter
    {

        private dynamic Data;
        public Book(dynamic data)
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
