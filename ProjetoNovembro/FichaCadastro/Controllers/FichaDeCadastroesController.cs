using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FichaCadastro.Context;
using FichaCadastro.Models;

namespace FichaCadastro.Controllers
{
    public class FichaDeCadastroesController : Controller
    {
        private FichaCadastroContext db = new FichaCadastroContext();
        public ActionResult Index()
        {
            return View(db.FichaDeCadastros.ToList());
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FichaDeCadastro fichaDeCadastro = db.FichaDeCadastros.Find(id);
            if (fichaDeCadastro == null)
            {
                return HttpNotFound();
            }
            return View(fichaDeCadastro);
        }

        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NomeRh,Data,Cargo,PretencaoSalarial,FonteRecrutamento,TimeDisponibilidade,Nome,Sexo,Endereco,NumeroCasa,Complemento,Cep,Bairro,Cidade,Regiao,Estado,DataNascimento,LocalNascimento,EstadoCivil,Raca,Email,NumTelefoneRes,NumCelular,Rg,RgDataExpe,RgOrgaoEmissor,Cpf,NomeMae,NomePai,Pis,Dependentes,TrabalhouResource,Idioma")] FichaDeCadastro fichaDeCadastro)
        {
            if (ModelState.IsValid)
            {
                db.FichaDeCadastros.Add(fichaDeCadastro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fichaDeCadastro);
        }

        // GET: FichaDeCadastroes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FichaDeCadastro fichaDeCadastro = db.FichaDeCadastros.Find(id);
            if (fichaDeCadastro == null)
            {
                return HttpNotFound();
            }
            return View(fichaDeCadastro);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NomeRh,Data,Cargo,PretencaoSalarial,FonteRecrutamento,TimeDisponibilidade,Nome,Sexo,Endereco,NumeroCasa,Complemento,Cep,Bairro,Cidade,Regiao,Estado,DataNascimento,LocalNascimento,EstadoCivil,Raca,Email,NumTelefoneRes,NumCelular,Rg,RgDataExpe,RgOrgaoEmissor,Cpf,NomeMae,NomePai,Pis,Dependentes,TrabalhouResource,Idioma")] FichaDeCadastro fichaDeCadastro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fichaDeCadastro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fichaDeCadastro);
        }
        
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FichaDeCadastro fichaDeCadastro = db.FichaDeCadastros.Find(id);
            if (fichaDeCadastro == null)
            {
                return HttpNotFound();
            }
            return View(fichaDeCadastro);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FichaDeCadastro fichaDeCadastro = db.FichaDeCadastros.Find(id);
            db.FichaDeCadastros.Remove(fichaDeCadastro);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}