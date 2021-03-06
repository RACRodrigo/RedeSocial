﻿using Negocio.Dominio;
using System.Collections.Generic;

namespace Negocio.Repositorio
{
    public interface IPerfilRepository
    {
        List<Perfil> ObterPerfis(int qtd);
        void CriarPerfil(Perfil perfil);
        Perfil ObterPerfilUnico(int id);
        void EditarPerfil(Perfil id);
        void ApagarPerfil(Perfil perfil);
        void dispose();
        Perfil ObterPerfilUsuario(string UserID);
        void executaExclusao(string UserId, int PerfilId);
        List<Perfil> BuscaDePerfis(string TermosBusca);
    }
}
