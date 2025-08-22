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

        public void InsertPerson(string firstName, string lastName, string emailAddress, string phoneNumber)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("SampleDB")))
            {
                // INITIALIZATION VARIANT

                //Person newPerson = new Person();
                //newPerson.FirstName = firstName;

                Person newPerson = new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber};

                List<Person> people = new List<Person>();
                people.Add(newPerson);


                // SUPER EFFICIENT VARIANT

                //List<Person> people = new List<Person>();
                //people.Add(new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber });

                connection.Execute("dbo.People_Insert @FirstName, @LastName, @EmailAddress, @PhoneNumber", people)
            }
        }
    }
}
