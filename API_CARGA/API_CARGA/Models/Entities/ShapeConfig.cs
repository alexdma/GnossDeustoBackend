﻿using System;
using System.ComponentModel.DataAnnotations;

namespace API_CARGA.Models.Entities
{
    /// <summary>
    /// Datos de configuración de una validación SHACL
    /// </summary>
    public class ShapeConfig
    {
        /// <summary>
        /// Identificador de la validación
        /// </summary>
        [Key]
        public Guid ShapeConfigID { get; set; }
        /// <summary>
        /// Nombre de la validación
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Nombre de la clase que se validará
        /// </summary>
        public string EntityClass { get; set; }
        /// <summary>
        /// Definición del shape SHACL
        /// </summary>
        public string Shape { get; set; }
    }
}