using _3_project.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_project.adapter
{
    internal class BaseAdapter
    {
        DaoOra ora;
        public BaseAdapter() 
        {
            ora = new DaoOra();
        }

        internal DaoOra Ora { get => ora; set => ora = value; }
    }
}
