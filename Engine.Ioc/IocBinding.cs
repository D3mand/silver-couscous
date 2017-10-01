using Engine.Boundaries;
using Engine.Boundaries.Requests;
using Engine.Interactors;
using Engine.Validator;
using External.Jacks;
using External.Plugs;
using Ninject.Modules;
using System;

namespace Engine.Ioc
{
    public class IocBinding : NinjectModule
    {
        public override void Load()
        {
            Bind<GigRepository>().To<Neo4JGigRepository>();
            Bind<Validator<CreateGigRequestMessage>>().To<CreateGigValidator>();
            Bind<CreateGigBoundary>().To<CreateGig>();
        }
    }
}
