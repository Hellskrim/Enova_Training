using System;
using Autofac;
using Soneta.Examples.Example8.Extender;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EnovaGit.Core;
using EnovaGit.Core.Services;
using EnovaGit.Core.AutofacConfiguration;
using EnovaGit.Core.Mediator;
using MediatR;

namespace Soneta.ExamplesTests
{
    [TestClass]
    public class UnitTest1
    {
         
         [TestMethod]
        public void TestMethod2()
        {
            Notowania notowania = new Notowania();

            decimal count = notowania.GetCommitsAverageForUser("test1");   

            Assert.AreEqual(2, count);

        }


        [TestMethod]
        public void Map()
        {
            //List<Akcja> akcja = new List<Akcja>() {
            //        new Akcja() {
            //            Id = 1,
            //            Nazwa = "test1",
            //            Data = Soneta.Types.Date.Now,
            //            Commit = "2af3eeffadads",
            //            Branch = "a"
            //        },

            //        new Akcja() {
            //            Id = 2,
            //            Nazwa = "test1",
            //            Data = Soneta.Types.Date.Now,
            //            Commit = "1afeeffadads",
            //            Branch = "a"
            //        },

            //        new Akcja() {
            //            Id = 3,
            //            Nazwa = "test1",
            //            Data = Soneta.Types.Date.Now,
            //            Commit = "afeefdfadagds",
            //            Branch = "b"
            //        },
            //        new Akcja() {
            //            Id = 3,
            //            Nazwa = "test1",
            //            Data = Soneta.Types.Date.Now.AddDays(3),
            //            Commit = "afeef4fadadaas",
            //            Branch = "a"
            //        },

            //        new Akcja() {
            //            Id = 4,
            //            Nazwa = "test2",
            //           Data = Soneta.Types.Date.Now,
            //            Commit = "afeeff2asfsdads",
            //            Branch = "c"
            //        },

            //        new Akcja() {
            //            Id = 5,
            //            Nazwa = "test2",
            //            Data = Soneta.Types.Date.Now,
            //            Commit = "afeefdftadafdds",
            //            Branch = "c"
            //        },

            //        new Akcja() {
            //            Id = 1,
            //            Nazwa = "test3",
            //            Data = Soneta.Types.Date.Now,
            //            Commit = "afeeffffradads",
            //            Branch = "c"
            //        },

            //        new Akcja() {
            //            Id = 2,
            //            Nazwa = "test3",
            //            Data = Soneta.Types.Date.Today+1,
            //            Commit = "aaafeeffawdads",
            //            Branch = "d"
            //        },

            //        new Akcja() {
            //            Id = 3,
            //            Nazwa = "test1",
            //            Data = Soneta.Types.Date.Now.AddDays(1),
            //            Commit = "afeeadfdfadadss",
            //            Branch = "e"
            //        },
            //    };
            //DataMapper notowania = new DataMapper();

            //var mapping = notowania.ConvertcommitsListToCommitsViewModel(akcja);

            //var map2 = mapping;

            EnovaGit.Core.AutofacConfiguration.AutofacConfiguration.RegisterAndResolve();

            EnovaGit.Core.Mediator.IMediator enovaGitService ;
            var container = AutofacConfiguration.RegisterAndResolve();
            enovaGitService = container.Resolve<EnovaGit.Core.Mediator.Mediator>();

            enovaGitService.SendMessage();

            string test;

        }
    }
}
