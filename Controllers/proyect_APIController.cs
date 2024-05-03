

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyect_API_Backend.Data;
using proyect_API_Backend.Models;



namespace proyect_API_Backend.Controllers{

    [Route("api/[controller]")]
    [ApiController]
    public class proyect_APIController : ControllerBase
    {
        public readonly BaseContext _context;

        public proyect_APIController(BaseContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<proyect_API>>>GetUsers()
        {
            return await _context.proyect_API.ToListAsync();
        }

        // LIST ALL USERS
        

       [HttpGet("{Id}")]
          public async Task<ActionResult<proyect_API>> GetUser(int Id)
          {
            var User = await _context.proyect_API.FindAsync(Id);

            if (User == null)
            {
                return NotFound();
            }
            return User;

        }



       

        /* DEFINIMOS DETALLES
          public async Task<IActionResult> Details(int? id){
            return View(await _context.Users.FirstOrDefaultAsync(m=>m.Id == id));
            
        }

        //DEFINIMOS CREATE
         public IActionResult Create(){
            return View();
        }
        [HttpPost]
           public async Task<IActionResult> Create(User U){
          _context.Users.Add(U);
          _context.SaveChanges();
          return RedirectToAction("Index");
        }


        //DEFINIMOS EDIT
        public async  Task<IActionResult> Edit(int id){
            return View(await _context.Users.FirstOrDefaultAsync(m=>m.Id == id));
        }
        [HttpPost]
        public  IActionResult Edit(Empleado E, int Id ){
            _context.Empleados.Update(E);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        
        //DEFINIMOS DELETE
       public async Task<IActionResult> Delete(int? Id)
        {
            var Empleado = await _context.Empleados.FindAsync(Id);
            _context.Empleados.Remove(Empleado);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        } 

        /DEFINIMOS LA BUSQUEDA
         public IActionResult Search(string searchString, object J)
        {
            var Empleado = _context.Empleados.AsQueryable();
            if (!string.IsNullOrEmpty(searchString))
            {
             Empleado = Empleado.Where(E => E.Nombres.Contains(searchString) || E.Apellidos.Contains(searchString) || E.Correo.Contains(searchString)|| E.Genero.Contains(searchString)|| E.Estado_Civil.Contains(searchString)|| E.Idiomas.Contains(searchString));
            }
            return View("Index",Empleado.ToList());
        }  */      
        
    }
}