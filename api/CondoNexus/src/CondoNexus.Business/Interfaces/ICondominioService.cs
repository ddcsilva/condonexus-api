﻿using CondoNexus.Business.Models;

namespace CondoNexus.Business.Interfaces;

public interface ICondominioService : IDisposable
{
    Task Adicionar(Condominio condominio);
    Task Atualizar(Condominio condominio);
    Task Remover(Guid id);

    Task AtualizarEndereco(Endereco endereco);
}