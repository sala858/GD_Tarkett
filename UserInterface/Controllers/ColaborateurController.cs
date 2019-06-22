using System;
using BusinessComponents;
using Entities;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserInterface.Controllers
{

    public class ColaborateurController : Controller
    {
        Colab colabo = new Colab();

        // GET: Colaborateur
        public ActionResult Index()
        {
            return View(colabo.afficherColab());
        }
        public ActionResult Create()
        {
            return View();
        }

        // POST: Colaborateurs/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nom,Prenom,Cin,Email,Poste,Equipe,NombreDeplacement,Anciennete,DateValiditeVisa,DateFinVisa,Sexe,Login,Password")] Colaborateur colaborateur)
        {
            if (ModelState.IsValid)
            {
                colabo.ajouterColab(colaborateur);
                return RedirectToAction("Index");
            }
            return View(colaborateur);

        }
    }
}