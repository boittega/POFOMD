using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using POFOMD.Models;

namespace POFOMD.Controllers
{
    public class CommentController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CommentViewModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CommentViewModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "CommentID,Name,Email,Commentary")] CommentViewModel commentViewModel)
        {
            if (ModelState.IsValid)
            {
                db.CommentViewModels.Add(commentViewModel);
                db.SaveChanges();
                return Content("<div class=\"alert alert-success alert-dismissible\" role=\"alert\">" +
                    "<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>" +
                    "Olá <strong>" + commentViewModel.Name + "</strong>, obrigado pelo comentário." +
                    "</div>"
                    , "text/html");
            }

            return Content("<div class=\"alert alert-danger alert-dismissible\" role=\"alert\">" +
                    "<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>" +
                    "<strong>Erro ao salvar comentário</strong>, por favor verifique os dados informados." +
                    "</div>"
                    , "text/html");
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
