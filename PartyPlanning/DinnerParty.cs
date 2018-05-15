using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanning
{
    class DinnerParty
    {
        public int NumberOfPeople { get; set; }
        public bool FancyDecoration { get; set; }
        public bool HealtyOption { get; set; }
        public const int CostOfFoodPerPerson = 25;




        public DinnerParty(int NumberOfPeople, bool FancyDecoration, bool HealtyOption)
    {
            this.NumberOfPeople = NumberOfPeople;
            this.FancyDecoration = FancyDecoration;
            this.HealtyOption = HealtyOption;
    }

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal costOfBeveragesPerPerson;
            if (HealtyOption)
            {
                costOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                costOfBeveragesPerPerson = 20.00M;
            }
            return costOfBeveragesPerPerson;
        }


        private decimal CalculateCostOfDecorations()
        {
            decimal CostOfDecorations;
            if (FancyDecoration)
            {
                CostOfDecorations = (NumberOfPeople * 15.0M) + 50.0M;

            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.5M) + 30.0M;
            }
            return CostOfDecorations;
        }

        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += ((CalculateCostOfBeveragesPerPerson()
                + CostOfFoodPerPerson) * NumberOfPeople);
                if (HealtyOption)
                {
                    totalCost *= .95M;
                }
                return totalCost;
            }
        }
    }
}
