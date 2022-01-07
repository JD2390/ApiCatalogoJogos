﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.InputModel
{
    public class JogoInputModel
    {
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome do jogo tem que ser entre 3 e 100 caracteres.")]
        public string Nome { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome da produtora tem que ser entre 3 e 100 caracteres.")]
        public string Produtora { get; set; }

        [Required]
        [Range(1,1000, ErrorMessage = "O preço do jogo deve ser entre R$ 1,00 e R$ 1.000,00 .")]
        public double Preco { get; set; }
    }
}
