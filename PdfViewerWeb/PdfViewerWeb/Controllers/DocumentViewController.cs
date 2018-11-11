using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PdfViewerWeb.Controllers
{
    public class DocumentViewController : Controller
    {
        // GET: DocumentView
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult PdfDocument()
        {
            string fileName = string.Empty;
            var fileStream = new FileStream(
                "~/Documentos/"+fileName,FileMode.Open,
                FileAccess.Read);
            var resultado = new FileStreamResult(fileStream,"application/pdf");
            return resultado;
        }

    }
}