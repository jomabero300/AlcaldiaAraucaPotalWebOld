﻿using System;
using System.ComponentModel.DataAnnotations;

namespace AlcaldiaAraucaPortalWeb.Models.ModelsViewGene
{
    public class RoleUserModelView
    {
        public string UserId { get; set; }

        [MaxLength(100, ErrorMessage = "El máximo tamaño del campo {0} es {1} caractéres")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Usuario")]
        public string FullName { get; set; }

        [Display(Name = "Rol")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string RoleId { get; set; }
    }
}
