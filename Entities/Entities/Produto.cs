﻿using Entities.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [Table("Product")]
    public class Produto:Notifies
    {
        [Column("PRD_ID")]
        [Display(Name = "Codigo")]
        public int Id { get; set; }

        [Column("PRD_NOME")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("PRD_VALO")]
        [Display(Name = "Valor")]
        public decimal Valor { get; set; }

        [Column("PRD_ESTADO")]
        [Display(Name = "Valor")]
        public bool Estado { get; set; }
    }
}
