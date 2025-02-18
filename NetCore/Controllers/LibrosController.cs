using CrudNetCore.Data;
using CrudNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudNetCore.Controllers
{
    public class LibrosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LibrosController(ApplicationDbContext context)
        {
            _context = context;
        }

        //Http Get Index
        public IActionResult Index()
        {
            IEnumerable<Libro> listaLibros = _context.Libro;
            return View(listaLibros);
        }

        //Http Get Create
       public IActionResult Create()
        {
            return View();
        }

        //Http Post Crear Libro
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Libro libro)
        {
            if(ModelState.IsValid)
            {
                _context.Libro.Add(libro);
                _context.SaveChanges();


                //Crear un mensaje para indicar al usuario que fue con exito
                TempData["mensaje"] = "Registro Almacenado Exitosamente";

                //Redireccionar hacia la pagina principal de libros
                return RedirectToAction("Index");
            }

            return View();
        }

        //Http Get Edit
        public IActionResult Edit(int? id)
        {
            if(id==null || id ==0)
            {
                return NotFound();
            }

            //Obtener el libro
            var libro = _context.Libro.Find(id);
            if(libro==null)
            {
                return NotFound();
            }    
            return View(libro);
        }


        //Http Post Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Libro libro)
        {
            if (ModelState.IsValid)
            {
                _context.Libro.Update(libro);
                _context.SaveChanges();


                //Crear un mensaje para indicar al usuario que fue con exito
                TempData["mensaje"] = "Registro Editado Exitosamente";

                //Redireccionar hacia la pagina principal de libros
                return RedirectToAction("Index");
            }

            return View();
        }

        //Http Delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            //Obtener el libro
            var libro = _context.Libro.Find(id);
            if (libro == null)
            {
                return NotFound();
            }
            return View(libro);
        }

        //Http Post Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteLibro(int? id)
        {
            //Obtengo el libro por id
            var libro = _context.Libro.Find(id);
            if(libro==null)
            {
                return NotFound();
            }

            _context.Libro.Remove(libro);
            _context.SaveChanges();


            //Crear un mensaje para indicar al usuario que fue con exito
            TempData["mensaje"] = "Registro Eliminado Exitosamente";

            //Redireccionar hacia la pagina principal de libros
            return RedirectToAction("Index");
        }
    }
}
