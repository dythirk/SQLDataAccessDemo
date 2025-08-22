using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace FormUI
{
    public class DataAccess
    {
        public List<Person> GetPeople(string lastName)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("SampleDB")))
            {

                // ORIGINAL, NOT SECURE, OPEN TO INJECTIONS
                // var output = connection.Query<Person>($"select * from People where LastName = '{ lastName }'").ToList();

                var output = connection.Query<Person>("dbo.People_GetByLastName" @LastName, new { LastName = lastName }).ToList();


                return output;

            }

        }
    }
}
