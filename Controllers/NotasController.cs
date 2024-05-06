

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyect_API_Backend.Data;
using proyect_API_Backend.Models;



namespace proyect_API_Backend.Controllers{

    [Route("api/[controller]")]
    [ApiController]
    public class NotasController : ControllerBase
    {
        public readonly BaseContext _context;

        public NotasController(BaseContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Nota>>>GetUsers()
        {
            return await _context.Notas.ToListAsync();
        }

        // LIST ALL USERS
        

       [HttpGet("{Id}")]
          public async Task<ActionResult<Nota>> GetUser(int Id)
          {
            var Notas = await _context.Notas.FindAsync(Id);

            if (Notas == null)
            {
                return NotFound();
            }
            return Notas;
            }

        
        //DEFINIMOS CREAR
       [HttpPost]
        public async Task<ActionResult<Nota>> PostUser(Nota nota){   
    
            _context.Notas.Add(nota);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetUser", new { Id = nota.Id }, nota);    
        }


        //DEFINIMOS DELETE
        [HttpDelete("{Id}")]
        public async Task<ActionResult<Nota>> DeleteNota(int Id)
        {
            var Nota = await _context.Notas.FindAsync(Id);
            if (Nota == null)
            {
                return NotFound();
            }
            _context.Notas.Remove(Nota);
            await _context.SaveChangesAsync();
            return Nota;
        }

        
        //DEFINIMOS EDIT
        [HttpPut]
        public  IActionResult Edit(Nota N, int Id ){
            _context.Notas.Update(N);
            _context.SaveChanges();
            return RedirectToAction("GetUsers");
        }


        /*
        //DEFINIMOS BUSCAR
        [HttpGet("{Nombre}")]
          public ActionResult<IEnumerable<Nota>> Search(string Nombre)
        {
            
            var resultados = _context.Notas.Where(N => N.Nombre.Contains(Nombre)).ToList();

            if (resultados.Count == 0)
            {
                return NotFound(); 
            }

            return StatusCode(200, resultados); 
        }*/
        
  }
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

*/

        /*
        //DEFINIMOS DELETE
       public async Task<IActionResult> Delete(int? Id)
        {
            var Empleado = await _context.Empleados.FindAsync(Id);
            _context.Empleados.Remove(Empleado);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        } */

        //DEFINIMOS LA BUSQUEDA
        /*
         public IActionResult Search(string searchString, object J)
        {
            var Empleado = _context.Empleados.AsQueryable();
            if (!string.IsNullOrEmpty(searchString))
            {
             Empleado = Empleado.Where(E => E.Nombres.Contains(searchString) || E.Apellidos.Contains(searchString) || E.Correo.Contains(searchString)|| E.Genero.Contains(searchString)|| E.Estado_Civil.Contains(searchString)|| E.Idiomas.Contains(searchString));
            }
            return View("Index",Empleado.ToList());
        }  */    


        

         //DEFINIMOS LA BUSQUEDA_ 2


            /*   [HttpGet("{titulo}")]
          public ActionResult<IEnumerable<Note>> Get(string titulo)
        {
            
            var resultados = _context.Notes.Where(e => e.Title.Contains(titulo)).ToList();

            if (resultados.Count == 0)
            {
                return NotFound(); 
            }

            return StatusCode(200, resultados); 
        }*/
         