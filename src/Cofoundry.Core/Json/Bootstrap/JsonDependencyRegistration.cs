﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cofoundry.Core.DependencyInjection;
using Cofoundry.Core.Json.Internal;
using Newtonsoft.Json;

namespace Cofoundry.Core.Json.Registration
{
    public class JsonDependencyRegistration : IDependencyRegistration
    {
        public void Register(IContainerRegister container)
        {
            container.RegisterSingleton<IJsonSerializerSettingsFactory, JsonSerializerSettingsFactory>();
            container.RegisterFactory<JsonSerializerSettings, JsonSerializerSettingsInjectionFactory>(RegistrationOptions.SingletonScope());
        }
    }
}
