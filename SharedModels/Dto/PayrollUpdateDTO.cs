﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Dto
{
    public class PayrollUpdateDTO
    {
        [Required(ErrorMessage = "ID es requerido")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Id del empleado es obligatorio.")]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "La fecha de inicio es obligatoria.")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "La fecha de fin es obligatoria.")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "El salario neto es obligatorio.")]
        [Range(0, double.MaxValue, ErrorMessage = "El salario neto debe ser mayor o igual a cero.")]
        public decimal NetSalary { get; set; }
    }
}
