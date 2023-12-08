namespace Molly
{
    class Person
    {
        public string Name { get; set; } = "";
        public List<Meal> Meals { get; set; } = [];

        public int CountMealsWithSpinach()
        {
            string spinach = "spenat";
            int amountOfSpinach = 0;
            foreach (Meal meal in Meals)
            {
                foreach(Food foods in meal.Foods)
                {
                    if (foods.Name.ToLower().Equals(spinach))
                    {
                        amountOfSpinach++;
                    }
                }
            }
            
            return amountOfSpinach;
        }

        public int CountMealsWithoutSpinach()
        {
            string spinach = "spenat";
            int daysWithoutSpinach = 0;
            bool containsSpinach = false;
            foreach (Meal meal in Meals)
            {
                foreach(Food foods in meal.Foods)
                {
                    if (foods.Name.ToLower().Equals(spinach))
                    {
                        containsSpinach = true;
                    }
                }
                if (!containsSpinach)
                {
                    daysWithoutSpinach++;
                }
                containsSpinach = false;
            }
            
            return daysWithoutSpinach;
        }

        public int CountSpinachBonusDays()
        {
            string spinach = "spenat";
            int bonusDays = 0;
            bool bonus = false;
            foreach (Meal meal in Meals)
            {
                foreach (Food foods in meal.Foods)
                {
                    if (foods.Name.ToLower().Equals(spinach))
                    {
                        if (bonus)
                        {
                            bonusDays++;
                            break; // Ser till att inte kunna få multipla bonusar på en dag
                        }
                        else
                        {
                            bonus = true;
                        }
                    }
                }
                bonus = false;
            }

            return bonusDays;
        }
    }
}
