using Microsoft.AspNetCore.Components;

namespace BlazordemoApp1.Data
{
    public interface IFlightPlanService
    {
        void AddFlightPlan(FlightPlan flightPlan);
        List<FlightPlan> GetAllFlightPlans();
    }
    public class FlightPlanService : IFlightPlanService
    {
        private List<FlightPlan> flightPlans;

        public FlightPlanService()
        {
            flightPlans = new List<FlightPlan>();
        }

        public void AddFlightPlan(FlightPlan flightPlan)
        {
            flightPlans.Add(flightPlan);
        }

        public List<FlightPlan> GetAllFlightPlans()
        {
            return flightPlans;
        }
    }
}
