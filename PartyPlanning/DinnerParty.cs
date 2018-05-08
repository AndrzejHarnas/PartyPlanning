using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanning
{
    class DinnerParty
    {
        public int NumberOfPeople;
        public Decimal CostOfBeveragesPerPerson=25.0M;
        public Decimal CostOfDecorations=7.5M;

        public const int CostOfFoodPerPerson = 25;
        
        public void SetHealthyOption(Boolean HealtyOption)
        {

            if (HealtyOption)
            {

                CostOfBeveragesPerPerson = NumberOfPeople * 5.0M;

            }
            else
            {

                CostOfBeveragesPerPerson = NumberOfPeople * 20.0M;

            }




        }


        public void CalculateCostOfDecorations(Boolean DecorationCost)
        {

            if (DecorationCost)
            {
                CostOfDecorations = (NumberOfPeople * 15.0M) + 50.0M;

            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.5M) + 30.0M;
            }
        }

        public decimal CalculateCost(Boolean HealthyOption)
        {

            if (HealthyOption)
            {
                return (CostOfFoodPerPerson * NumberOfPeople + CostOfDecorations + CostOfBeveragesPerPerson)*0.95M;

            } else
            {

                return CostOfFoodPerPerson * NumberOfPeople + CostOfDecorations + CostOfBeveragesPerPerson;

            }

        }
    }
}
