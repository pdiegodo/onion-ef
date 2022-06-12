﻿using Empresa.Projeto.Application.Dtos.Capitulo;
using Empresa.Projeto.Domain.Enums;
using System.Collections.Generic;

namespace Empresa.Projeto.Application.Dtos.Unidade
{
    public class PostUnidadeDto
    {
        public int NumeroUnidade { get; set; }

        public Status Status { get; set; }

        public List<ReferenciaCapituloDto> Capitulos { get; set; }
    }
}
