// -----------------------------------------------------------------------
// <copyright file="LogAdapter.cs" company="MicroLite">
// Copyright 2012 - 2015 Project Contributors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// </copyright>
// -----------------------------------------------------------------------
namespace MicroLite.Logging.Serilog
{
    using System;
    using System.Globalization;

    internal sealed class LogAdapter : ILog
    {
        private readonly global::Serilog.ILogger logger;

        internal LogAdapter(global::Serilog.ILogger logger)
        {
            this.logger = logger;
        }

        public bool IsDebug
        {
            get
            {
                return this.logger.IsEnabled(global::Serilog.Events.LogEventLevel.Debug);
            }
        }

        public bool IsError
        {
            get
            {
                return this.logger.IsEnabled(global::Serilog.Events.LogEventLevel.Error);
            }
        }

        public bool IsFatal
        {
            get
            {
                return this.logger.IsEnabled(global::Serilog.Events.LogEventLevel.Fatal);
            }
        }

        public bool IsInfo
        {
            get
            {
                return this.logger.IsEnabled(global::Serilog.Events.LogEventLevel.Information);
            }
        }

        public bool IsWarn
        {
            get
            {
                return this.logger.IsEnabled(global::Serilog.Events.LogEventLevel.Warning);
            }
        }

        public void Debug(string message)
        {
            this.logger.Debug(message);
        }

        public void Debug(string message, params string[] formatArgs)
        {
            if (this.IsDebug)
            {
                this.logger.Debug(string.Format(CultureInfo.InvariantCulture, message, formatArgs));
            }
        }

        public void Error(string message)
        {
            this.logger.Error(message);
        }

        public void Error(string message, params string[] formatArgs)
        {
            if (this.IsError)
            {
                this.logger.Error(string.Format(CultureInfo.InvariantCulture, message, formatArgs));
            }
        }

        public void Error(string message, Exception exception)
        {
            this.logger.Error(message, exception);
        }

        public void Fatal(string message)
        {
            this.logger.Fatal(message);
        }

        public void Fatal(string message, params string[] formatArgs)
        {
            if (this.IsFatal)
            {
                this.logger.Fatal(string.Format(CultureInfo.InvariantCulture, message, formatArgs));
            }
        }

        public void Fatal(string message, Exception exception)
        {
            this.logger.Fatal(message, exception);
        }

        public void Info(string message)
        {
            this.logger.Information(message);
        }

        public void Info(string message, params string[] formatArgs)
        {
            if (this.IsInfo)
            {
                this.logger.Information(string.Format(CultureInfo.InvariantCulture, message, formatArgs));
            }
        }

        public void Warn(string message)
        {
            this.logger.Warning(message);
        }

        public void Warn(string message, params string[] formatArgs)
        {
            if (this.IsWarn)
            {
                this.logger.Warning(string.Format(CultureInfo.InvariantCulture, message, formatArgs));
            }
        }
    }
}