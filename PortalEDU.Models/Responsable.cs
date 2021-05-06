﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace PortalEDU.Models
{
    public class Responsable
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Profesion { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Direccion { get; set; }
        
        public string Foto { get; set; }
        public string TelefonoTrabajo { get; set; }
        //public int IdAlumno { get; set; }
        [Required]
        public DateTime update { get; set; }

        [NotMapped]
        public string NombreCompleto => $"{Nombre} {Apellido}";

        [Display(Name = "Alumnos a Cargo")]
     
        public virtual ICollection<Alumno> AlumnoLista { get; set; }

        //public virtual Alumno IdAlumnoNavigation { get; set; }
    }
}
