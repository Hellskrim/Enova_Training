using System.Reflection;
using Autofac;
using EnovaGit.Core.Services;
using EnovaGit.Core.Utils;
using EnovaGit.Infrastructure.Repositories;
using MediatR;
using IMediator = EnovaGit.Core.Mediator.IMediator;

namespace EnovaGit.Core.AutofacConfiguration
{
    public static class AutofacConfiguration
    {
        //Register -> Resolve. Sorry. Enova mnie ogranicza dość mocno ;). 
        //Domyslam sie, ze moze to byc unane za antypattern, kiedy taki serwis od konfiguracji 
        //wrzucam sobie do tej warstwy, ale projekt enova sprytnie mi wyeliminował inne możliwosci
        //a chciałabym jednak pewne zaleznosci wstrzyknąć bo planuję dorzucenie mediatora. btw tego tez 
        //nie moge zainstalowac i musze napisac z palca o ile starcyz mic czasu. 
        //Bo jak nie to sobie daruje

        public static IContainer RegisterAndResolve() //TODO zuniwersalizowac kontener

        { 
            var builder = new Autofac.ContainerBuilder();
            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(executingAssembly)
                .AsSelf()
                .AsImplementedInterfaces();

           builder.RegisterAssemblyTypes(typeof(MediatR.IMediator).Assembly).AsImplementedInterfaces();
             builder.RegisterType<MediatR.Mediator>().As<MediatR.IMediator>().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(typeof(MediatR.IMediator).Assembly)
                .AsClosedTypesOf(typeof(IRequestHandler<,>))
                .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(typeof(MediatR.IMediator).Assembly)
                .AsClosedTypesOf(typeof(IAsyncRequestHandler<,>))
                .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(typeof(MediatR.IMediator).Assembly)
                .AsClosedTypesOf(typeof(INotificationHandler<>))
                .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(typeof(MediatR.IMediator).Assembly)
                .AsClosedTypesOf(typeof(IAsyncNotificationHandler<>))
                .AsImplementedInterfaces();
            builder.RegisterType<Mediator.Mediator>().As<IMediator>().InstancePerLifetimeScope();

            builder.RegisterType<EnovaGitRepository>().As<IEnovaGitRepository>().InstancePerLifetimeScope();
            builder.RegisterType<EnovaGitService>().As<IEnovaGitService>().InstancePerLifetimeScope();
            builder.RegisterType<NumericHelper>().As<INumericHelper>().InstancePerLifetimeScope();

            var container = builder.Build();

            return container;
             
        }
    }
}