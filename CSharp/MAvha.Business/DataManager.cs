using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using MAvha.DAL;

namespace MAvha.Business
{
    public static class DataManager
    {
        private static readonly DB DB = DB.Instance();

        /// <summary>
        /// Returns the list of active persons.
        /// </summary>
        public static List<Person> PersonList()
        {
            try
            {
                DB.Connect();

                var table = DB.ExecuteDataTable(@"PersonList", null);

                return table.AsEnumerable().Select(r => new Person
                {
                    Id = r.Field<int>("PersonId"),
                    Fullname = r.Field<string>("Fullname"),
                    DOB = r.Field<DateTime>("DOB"),
                    Age = r.Field<int>("Age"),
                    Gender = r.Field<Gender>("Gender"),
                    IsActive = r.Field<bool>("IsActive")
                }).ToList();
            }
            finally
            {
                DB.Disconnect();
            }
        }

        /// <summary>
        /// Saves the info of a person in database.
        /// </summary>
        public static void PersonSave(Person person)
        {
            try
            {
                DB.Connect();

                var parameters = new Hashtable
                {
                    { "PersonId", person.Id },
                    { "Fullname", person.Fullname },
                    { "DOB", person.DOB },
                    { "Age", person.Age },
                    { "Gender", person.Gender }
                };

                DB.ExecuteNonQuery(@"PersonSave", parameters);
            }
            finally
            {
                DB.Disconnect();
            }
        }

        /// <summary>
        /// Performs a logic deletion of a person from database.
        /// </summary>
        public static void PersonDelete(int id)
        {
            try
            {
                DB.Connect();

                var parameters = new Hashtable
                {
                    { "PersonId", id }
                };

                DB.ExecuteNonQuery(@"PersonDelete", parameters);
            }
            finally
            {
                DB.Disconnect();
            }
        }
    }
}
