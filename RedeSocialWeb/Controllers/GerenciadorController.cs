﻿using Dados;
using RedeSocialWeb.Models;
using Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedeSocialWeb.Controllers
{
    // Controller responsável por montar e interagir com a tela principal
    public class GerenciadorController : Controller
    {
        private PerfilServico servicoPerfil;
        private PostagemServico servicoPostagem;

        public GerenciadorController()
        {
            servicoPerfil = new PerfilServico(new PerfisEntity());
            servicoPostagem = new PostagemServico(new PostagensEntity());
        }

        // GET: Gerenciador
        public ActionResult Index()
        {
            DashBoardModel dashBorad = new DashBoardModel();
            dashBorad.postagens = servicoPostagem.RetornaPostagens();

            var UserId = Session["UserId"].ToString();
            var perfil = servicoPerfil.RetornaPerfilUsuario(UserId);

            dashBorad.nomePerfil = perfil.NomeExibicao;
            dashBorad.fotoPerfil = perfil.FotoPerfil;

            return View(dashBorad);
        }
    }
}