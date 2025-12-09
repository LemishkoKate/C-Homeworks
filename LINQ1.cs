using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<MongoRepository.Firm> firms = new List<MongoRepository.Firm>
        {
            new MongoRepository.Firm { Name="GoodFood Ltd", FoundationDate=DateTime.Now.AddYears(-3), BusinessProfile="Food",
                DirectorFullName="John White", EmployeesCount=120, Address="London" },

            new MongoRepository.Firm { Name="IT-Global", FoundationDate=DateTime.Now.AddYears(-1), BusinessProfile="IT",
                DirectorFullName="Mark Black", EmployeesCount=250, Address="Berlin" },

            new MongoRepository.Firm { Name="MarketingPro", FoundationDate=DateTime.Now.AddYears(-5), BusinessProfile="Marketing",
                DirectorFullName="Adam White", EmployeesCount=80, Address="London" },

            new MongoRepository.Firm { Name="White & Black Food", FoundationDate=DateTime.Now.AddYears(-4), BusinessProfile="Marketing",
                DirectorFullName="Bob Black", EmployeesCount=310, Address="Paris" }
        };


        var q1 = from f in firms select f;

        var q2 = from f in firms
                 where f.Name.Contains("Food")
                 select f;

        var q3 = from f in firms
                 where f.BusinessProfile == "Marketing"
                 select f;

        var q4 = from f in firms
                 where f.BusinessProfile == "Marketing" || f.BusinessProfile == "IT"
                 select f;

        var q5 = from f in firms
                 where f.EmployeesCount > 100
                 select f;

        var q6 = from f in firms
                 where f.EmployeesCount >= 100 && f.EmployeesCount <= 300
                 select f;

        var q7 = from f in firms
                 where f.Address == "London"
                 select f;

        var q8 = from f in firms
                 where f.DirectorFullName.Split(' ').Last() == "White"
                 select f;

        var q9 = from f in firms
                 where (DateTime.Now - f.FoundationDate).TotalDays > 365 * 2
                 select f;

        var q10 = from f in firms
                  where (DateTime.Now - f.FoundationDate).TotalDays >= 123
                  select f;

        var q11 = from f in firms
                  where f.DirectorFullName.Contains("Black") && f.Name.Contains("White")
                  select f;
    }
}
