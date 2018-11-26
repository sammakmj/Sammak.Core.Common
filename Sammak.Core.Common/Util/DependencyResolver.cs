﻿using System;
using System.Configuration.Abstractions;
using StructureMap;

namespace Sammak.Core.Common.Util
{
    /// <summary>
    /// This class is used everywhere to get the correct IoC instances of types
    /// </summary>
    public class DependencyResolver
    {
        /// <summary>
        /// Gets or sets the container. It is not recommended to call the Set on this
        /// </summary>
        /// <value>
        /// The container.
        /// </value>
        public static IContainer Container { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GetInstance<T>()
        {
            return Container.GetInstance<T>();
        }

        /// <summary>
        /// Gets the configuration manager.
        /// </summary>
        /// <value>
        /// The configuration manager.
        /// </value>
        /// <exception cref="System.Exception">
        /// Container is null
        /// or
        /// No IConfigurationManager is registered
        /// </exception>
        public static IConfigurationManager ConfigurationManager
        {
            get
            {
                if (Container == null) throw new Exception("Container is null");
                var configManager = Container.GetInstance<IConfigurationManager>();
                if (configManager == null) throw new Exception("No IConfigurationManager is registered");
                return configManager;
            }
        }
    }
}
