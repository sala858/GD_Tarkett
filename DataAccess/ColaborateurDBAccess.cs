using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ColaborateurDBAccess
    {
        private Sqli_GD_Tarkett_Model db=new Sqli_GD_Tarkett_Model();
        public void AddColaborateur(Colaborateur colaborateur)
        {
            db.Colaborateur.Add(colaborateur);
            db.SaveChanges();
        }
        public DbSet<Colaborateur> showColborateurs()
        {
            return db.Colaborateur;
        }
    }
}
