// -----------------------------------------------------------------------
// <copyright file="LogAdapter.cs" company="Project Contributors">
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
using System.Globalization;

namespace MicroLite.Logging.Serilog
{
    internal sealed class LogAdapter : ILog
    {
        private readonly global::Serilog.ILogger _logger;

        internal LogAdapter(global::Serilog.ILogger logger) => _logger = logger;

        public bool IsDebug => _logger.IsEnabled(global::Serilog.Events.LogEventLevel.Debug);

        public bool IsError => _logger.IsEnabled(global::Serilog.Events.LogEventLevel.Error);

        public bool IsFatal => _logger.IsEnabled(global::Serilog.Events.LogEventLevel.Fatal);

        public bool IsInfo => _logger.IsEnabled(global::Serilog.Events.LogEventLevel.Information);

        public bool IsWarn => _logger.IsEnabled(global::Serilog.Events.LogEventLevel.Warning);

        public void Debug(string message) => _logger.Debug(message);

        public void Debug(string message, params string[] formatArgs)
        {
            if (IsDebug)
            {
                _logger.Debug(string.Format(CultureInfo.InvariantCulture, message, formatArgs));
            }
        }

        public void Error(string message) => _logger.Error(message);

        public void Error(string message, params string[] formatArgs)
        {
            if (IsError)
            {
                _logger.Error(string.Format(CultureInfo.InvariantCulture, message, formatArgs));
            }
        }

        public void Error(string message, Exception exception) => _logger.Error(message, exception);

        public void Fatal(string message) => _logger.Fatal(message);

        public void Fatal(string message, params string[] formatArgs)
        {
            if (IsFatal)
            {
                _logger.Fatal(string.Format(CultureInfo.InvariantCulture, message, formatArgs));
            }
        }

        public void Fatal(string message, Exception exception) => _logger.Fatal(message, exception);

        public void Info(string message) => _logger.Information(message);

        public void Info(string message, params string[] formatArgs)
        {
            if (IsInfo)
            {
                _logger.Information(string.Format(CultureInfo.InvariantCulture, message, formatArgs));
            }
        }

        public void Warn(string message) => _logger.Warning(message);

        public void Warn(string message, params string[] formatArgs)
        {
            if (IsWarn)
            {
                _logger.Warning(string.Format(CultureInfo.InvariantCulture, message, formatArgs));
            }
        }
    }
}
