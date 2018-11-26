using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web;
using HidrometroApi.Controllers;
using HidrometroApi.Models;
using HidrometroApi.Models.Interface;
using HidrometroApi.Models.Repositorio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HidrometroApi.Tests.Controllers
{
    [TestClass]
    public class PessoaControllerTest
    {
        Pessoa pessoa()
        {
            return new Pessoa
            {
                CPF_CNPJ = "123.456.789.00",
                DataNascimento = new DateTime(2018, 04, 25),
                Email = "pessoa1@listaPessoa.com",
                IdPessoa = 2,
                Nome = "Pessoa 1",
                PessoaAtiva = true,
                Senha = "Pessoa1",
                Endereco = new Endereco(),
                IdEndereco = 0,
                IdTelefone = 0,
                Perfil = new Perfil(),
                Telefone = new Telefone()
            };
        }

        [TestMethod]
        public void CadastrarPessoa()
        {
            var pessoaC = new PessoaController();
            pessoaC.Request = new HttpRequestMessage();
            pessoaC.Configuration = new System.Web.Http.HttpConfiguration();

            var resposta = pessoaC.Post(this.pessoa());
            
        }

        [TestMethod]
        public void CadastrarTelefone()
        {
            //var TelefoneC = new TelefoneController();
            //TelefoneC.Request = new HttpRequestMessage();
            //TelefoneC.Configuration = new System.Web.Http.HttpConfiguration();

            //var resposta = TelefoneC.Post(this.pessoa());

        }
    }
}
