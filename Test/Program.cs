﻿using HMS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_DataBusinessLayer;
using System.Data;
using System.Data.SqlClient;
namespace Test
{
    internal class Program
    {
        static void Main( string[] args )
        {
            SqlParameter[] parameters = new SqlParameter[ 2 ];
            parameters[ 0 ] = new SqlParameter( "CountryID", 2 );
            parameters[ 1 ] = new SqlParameter( "CountryName", null );

            if ( clsCoutriesData.GetCountry( ref parameters ) )
            {
                Console.WriteLine( "User Updated succefully" );
            }
            else
                Console.WriteLine( "User Updated Failed" );

            //if (clsEmployeesData.Find(2))
            //{
            //    Console.WriteLine("User Deleted succefully");
            //}
            //else
            //    Console.WriteLine("User Deleted Failed");
            DataTable dt = clsPerson.GetAllPeople();
            foreach ( DataRow row in dt.Rows )
            {
                Console.WriteLine( row[ "FirstName" ] );
            }
            Console.ReadLine();
        }
    }
}
