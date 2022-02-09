﻿using Empresa.Projeto.Domain.Core.Interfaces.Repositorys;
using Empresa.Projeto.Domain.Entitys;

namespace Empresa.Projeto.Infrastructure.Data.Repositorys
{
    public class RepositoryEspecialidade : RepositoryBase<Especialidade>, IRepositoryEspecialidade
    {
        private readonly AppDbContext appDbContext;

        public RepositoryEspecialidade(AppDbContext appContext) : base(appContext)
        {
            this.appDbContext = appContext;
        }
    }
}
