using Microsoft.EntityFrameworkCore;

namespace Assignment_4_EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AirLineDBContext airLineDBContext = new AirLineDBContext();
            #region Section A
            #region Q1
            //var result = airLineDBContext.Airline.Where(a => a.Name == "EgyptAir") .Include(a => a.aircraft).ThenInclude(ac => ac.aircraft_Routes).FirstOrDefault();
            #endregion
            #region Q2
            //var result02 = airLineDBContext.Airline.Include(a => a.employee).ThenInclude(e => e.emp_Qualifications);
            #endregion
            #region Q3
            //var result03 = airLineDBContext.Airline.Include(a => a.transaction.Where(t => t.Amount > 10000));
            #endregion
            #region Q4
            //        var result04 = airLineDBContext.routes
            //.Select(r => new
            //{
            //    r.Origin,
            //    r.Destination,
            //    AircraftModel = r.aircraft_Routes
            //});
            #endregion
            #region Q5
            //    var result05 = airLineDBContext.Aircraft
            //.Include(ac => ac.airline)
            //.ThenInclude(al => al.airline_Phones);
            #endregion
            #endregion
        }
    }
}
