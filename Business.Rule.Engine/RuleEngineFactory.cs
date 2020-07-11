using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Rule.Engine
{
    public class RuleEngineFactory
    {
        public bool ExecuteRule(int choice)
        {
            bool result = default(bool);
            try
            {
                IBusinessRuleExecuter obj = GetRuleEngineObject(choice);
                result = obj.Execute();

            }
            catch (NotImplementedException ex)
            {
                throw new Exception("Invalid Choice");
            }
           
            return result;
        }

        private IBusinessRuleExecuter GetRuleEngineObject(int choice)
        {
            IBusinessRuleExecuter ob;
            switch (choice)
            {

                case 1:
                    ob = new PhysicalProduct("Generate a Packing slip for shipping.");
                    break;
                case 2:
                    ob = new Book("create a duplicae packing slip for the royanty department.");
                    break;
                case 3:
                    ob = new Membership("Activate that membership.");
                    break;
                case 4:
                    ob = new UpgradeMemership("Apply upgrade.");
                    break;
                case 5:
                    ob = new Membership_Upgrade("E-mail the owner and inform them of the activation/upgrade.");
                    break;
                case 6:
                    ob = new VideoLearningSki("Adda free First Aid video.");
                    break;
                case 7:
                    ob = new PhysicalProductBook("Generate a commission payment to agent");
                    break;
                default:
                    throw new NotImplementedException();


            }
            return ob;

        }
    }
}
