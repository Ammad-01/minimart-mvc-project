﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace OOAD_PROJECT.DataBaseAccessLayer
{
    public class data
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ProjectContext"].ConnectionString);
        public DataSet ProductsIndex()
        public DataSet MenWearProducts()
        public DataSet FemaleWearProducts()
        public DataSet getvieworder()
        public DataSet getvieworder(int id)
    }
}