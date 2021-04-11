using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class DailyTasksFacade
    {
        private readonly TaskWater _waterOperation;
        private readonly TaskWetFood _wetFoodOperation;
        private readonly TaskLitter _litterOperation;

        public DailyTasksFacade()
        {
            _waterOperation = new TaskWater();
            _wetFoodOperation = new TaskWetFood();
            _litterOperation = new TaskLitter();
        }

        public void CompleteDailyTasks()
        {
            _waterOperation.RefreshDrinkingWater();
            _wetFoodOperation.GiveWetFood();
            _litterOperation.CleanLitter();
        }

    }
}
