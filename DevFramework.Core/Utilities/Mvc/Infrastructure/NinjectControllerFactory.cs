using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using Ninject.Modules;

namespace DevFramework.Core.Utilities.Mvc.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private readonly IKernel _kernal;
        public NinjectControllerFactory(params INinjectModule[] module)
        {
            _kernal = new StandardKernel(module);
        }
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)_kernal.Get(controllerType);
        }
    }
}
