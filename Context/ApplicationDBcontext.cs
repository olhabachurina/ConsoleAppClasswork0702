using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClasswork0702.Context;

public class ApplicationDBcontext
{
   
    
     private string connectionString = (@"Server=(localdb)\mssqllocaldb;Database=classwork0702;Trusted_Connection=True;");
    public IDbConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}


