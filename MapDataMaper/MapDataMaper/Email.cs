﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapDataMaper
{
    class Email
    {
        class FormMaper
        {
            public DataTable getEmailAddList()
            {
                //sp_GetEmailPickList
                DataTable dt = new DataTable();
                SqlDataAdapter adapter;
                Connection dataConnecter = new Connection();

                return dt;
            }


        }
    }
}
