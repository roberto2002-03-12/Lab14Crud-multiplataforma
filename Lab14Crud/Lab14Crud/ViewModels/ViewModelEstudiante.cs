using System;
using System.Collections.Generic;
using System.Text;
using Lab14Crud.Models;
using Xamarin.Forms;

namespace Lab14Crud.ViewModels
{
    public class ViewModelEstudiante : BaseViewModel
    {
        public int estudianteId { get; set; }

        public ViewModelEstudiante () { }
        #region Constructor
        public ViewModelEstudiante(Estudiante estudiante)
        {
            estudianteId = estudiante.EstudianteId;
            _nombre = estudiante.Nombre;
            _apellido = estudiante.Apellido;
            _edad = estudiante.Edad;
            _nacimiento = estudiante.Nacimiento;
            _aprobado = estudiante.Aprobado;
        }
        #endregion

        #region Atributos

        private string _nombre;
        public string Nombre
        {
            get { return this._nombre; }
            set { SetValue(ref this._nombre, value); }
        }

        private string _apellido;
        public string Apellido
        {
            get { return this._apellido; }
            set { SetValue(ref this._apellido, value); }
        }

        private int _edad;
        public int Edad
        {
            get { return this._edad; }
            set { SetValue(ref this._edad, value); }
        }

        private DateTime _nacimiento;
        public DateTime Nacimiento
        {
            get { return this._nacimiento; }
            set { SetValue(ref this._nacimiento, value); }
        }

        private Boolean _aprobado;
        public Boolean Aprobado
        {
            get { return this._aprobado; }
            set { SetValue(ref this._aprobado, value); }
        }

        #endregion
    }
}
