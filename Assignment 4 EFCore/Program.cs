using Microsoft.EntityFrameworkCore;

namespace Assignment_4_EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using AirLineDBContext airLineDBContext = new AirLineDBContext();
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
            #region Section B
            #region Q1
            //        var result =
            //from e in airLineDBContext.employees
            //join a in airLineDBContext.Airline on e.Id equals a.Id
            //select new
            //{
            //    EmployeeName = e.Name,
            //    AirlineName = a.Name
            //};

            #endregion
            #region Q2
            var result02 =
    from r in airLineDBContext.routes
    join ac in airLineDBContext.Aircraft on r.Id equals ac.Id
    join al in airLineDBContext.Airline on ac.Id equals al.Id
    select new
    {
        r.Origin,
        r.Destination,
        AircraftModel = ac.Model,
        AirlineName = al.Name
    };
            #endregion
            #region Q3
            //        var result03 =
            //from al in airLineDBContext.Airline
            //join ac in airLineDBContext.Aircraft on al.Id equals ac.Id
            //select new
            //{
            //    Airline = al.Name,
            //    AircraftModel = ac.Model
            //};
            #endregion
            #region Q4
    //        var result04 =
    //from t in airLineDBContext.transactions
    //join al in airLineDBContext.Airline on t.Id equals al.Id
    //where t.Amount > 20000
    //select new
    //{
    //    t.Id,
    //    t.Amount,
    //    t.Description,
    //    AirlineName = al.Name
    //};
            #endregion
            #endregion
        }
    }
}
