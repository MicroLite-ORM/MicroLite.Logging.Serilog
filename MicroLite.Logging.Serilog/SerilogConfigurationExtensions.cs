// -----------------------------------------------------------------------
// <copyright file="SerilogConfigurationExtensions.cs" company="Project Contributors">
// Copyright Project Contributors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// </copyright>
// -----------------------------------------------------------------------
using System;
using MicroLite.Logging.Serilog;
using Serilog;

namespace MicroLite.Configuration
{
    /// <summary>
    /// Extensions for the MicroLite configuration.
    /// </summary>
    public static class SerilogConfigurationExtensions
    {
        /// <summary>
        /// Configures the MicroLite ORM Framework to use Serilog as the logging framework.
        /// </summary>
        /// <param name="configureExtensions">The interface to configure extensions.</param>
        /// <param name="loggerConfiguration">The Serilog Logger Configuration.</param>
        /// <returns>The configure extensions.</returns>
        public static IConfigureExtensions WithSerilog(this IConfigureExtensions configureExtensions, LoggerConfiguration loggerConfiguration)
        {
            if (configureExtensions is null)
            {
                throw new ArgumentNullException(nameof(configureExtensions));
            }

            System.Diagnostics.Trace.TraceInformation("MicroLite: loading Serilog extension.");

            configureExtensions.SetLogResolver((Type type) =>
            {
                ILogger logger = loggerConfiguration.CreateLogger().ForContext(type);

                return new LogAdapter(logger);
            });

            System.Diagnostics.Trace.TraceInformation("MicroLite: Serilog extension loaded.");

            return configureExtensions;
        }
    }
}
