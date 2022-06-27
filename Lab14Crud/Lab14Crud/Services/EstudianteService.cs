using System;
using System.Collections.Generic;
using System.Text;
using Lab14Crud.DataContext;
using Lab14Crud.Models;
using System.Linq;

namespace Lab14Crud.Services
{
    public class EstudianteService
    {
        private readonly AppDbContext _context;

        public EstudianteService() => _context = App.GetContext();
        //crear
        public bool Create(Estudiante estudiante)
        {
            bool created;

            try {
                _context.Estudiante.Add(estudiante);
                _context.SaveChanges();

                created = true;
            } 
            catch (Exception ex) {
                Console.WriteLine(ex);
                created = false;
            }

            return created;
        }
        /*
        public bool CreateRange(List<Estudiante> estudiante)
        {
            try
            {
                _context.Estudiante.AddRange(estudiante);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
        */
        //conseguir todo
        public List<Estudiante> Get()
        {
            return _context.Estudiante.ToList();
        }

        //seleccionar
        public Estudiante GetByClick(int EstudianteId)
        {
            return _context.Estudiante.Find(EstudianteId);
        }

        //hacer update
        public bool Update(Estudiante estudiante)
        {
            try {
                _context.Estudiante.Update(estudiante);
                _context.SaveChanges();

                return true;
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                return false;
            }
        }
        //eliminar
        public bool Delete(Estudiante estudiante)
        {
            try {
                _context.Estudiante.Remove(estudiante);
                _context.SaveChanges();

                return true;
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                return false;
            }
        }
    }
}
