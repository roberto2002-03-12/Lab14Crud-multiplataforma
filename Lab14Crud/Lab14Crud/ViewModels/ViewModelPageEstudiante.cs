using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;
using System;
using Lab14Crud.Services;
using Lab14Crud.Models;
using System.Threading.Tasks;

namespace Lab14Crud.ViewModels
{
    public class ViewModelPageEstudiante : BaseViewModel
    {
        #region ViewModel

        ViewModelEstudiante viewModel = new ViewModelEstudiante();

        #endregion

        #region Servicios

        private readonly EstudianteService service = new EstudianteService();

        #endregion

        #region

        public ICommand CreateCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        #endregion

        #region Funciones

        public ViewModelPageEstudiante()
        {
            CreateCommand = new Command(() =>
            {
                var estudiante = new Estudiante()
                {
                    EstudianteId = this.viewModel.estudianteId,
                    Nombre = this.viewModel.Nombre,
                    Apellido = this.viewModel.Apellido,
                    Edad = this.viewModel.Edad,
                    Nacimiento = this.viewModel.Nacimiento,
                    Aprobado = this.viewModel.Aprobado
                };

                if (estudiante != null)
                {
                    //va crear
                    this.service.Create(estudiante);
                }
            });

            UpdateCommand = new Command(() =>
            {
                var estudiante = new Estudiante()
                {
                    EstudianteId = this.viewModel.estudianteId,
                    Nombre = this.viewModel.Nombre,
                    Apellido = this.viewModel.Apellido,
                    Edad = this.viewModel.Edad,
                    Nacimiento = this.viewModel.Nacimiento,
                    Aprobado = this.viewModel.Aprobado
                };

                //va leer el id del modelo y de este actualizar al encontrado
                this.service.Update(estudiante);
            });

            DeleteCommand = new Command(() => 
            {
                var estudiante = new Estudiante()
                {
                    EstudianteId = this.viewModel.estudianteId,
                    Nombre = this.viewModel.Nombre,
                    Apellido = this.viewModel.Apellido,
                    Edad = this.viewModel.Edad,
                    Nacimiento = this.viewModel.Nacimiento,
                    Aprobado = this.viewModel.Aprobado
                };

                //no necesita pasar el id, al pasar la identidad va reconocer el primary key borrando así la identidad
                this.service.Delete(estudiante);
            });
        }

        #endregion
    }
}
