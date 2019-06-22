using System;
using DataAccess;
using Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessComponents
{
    public class Colab
    {
        ColaborateurDBAccess colab = new ColaborateurDBAccess();
        public void ajouterColab(Colaborateur colaborateur)
        {
            colab.AddColaborateur(colaborateur);
        }
        public List<Colaborateur> afficherColab()
        {
            return colab.showColborateurs().ToList();
        }
    }
}
