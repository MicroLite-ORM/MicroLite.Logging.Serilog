MicroLite.Logging.Serilog
=========================

[![NuGet version](https://badge.fury.io/nu/MicroLite.Logging.Serilog.svg)](http://badge.fury.io/nu/MicroLite.Logging.Serilog)

_MicroLite.Logging.Serilog_ is an extension to the MicroLite ORM Framework which allows MicroLite to write any log statements to [Serilog](http://serilog.net/).

In order to use the extension, you first need to install it via NuGet:

    Install-Package MicroLite.Logging.Serilog

You can then load the extension in your application start-up:

    // Configure Serilog first, MicroLite.Logging.Serilog assumes it has already been configured.
    var loggerConfiguration = new LoggerConfiguration();
    ...

    // Load the extensions for MicroLite
    Configure
       .Extensions()
       .WithSerilog(loggerConfiguration);

    // Create the session factory...
    Configure
       .Fluently()
       ...

For further information on configuring Serilog, see [github.com/serilog/serilog/wiki/Configuration-Basics](https://github.com/serilog/serilog/wiki/Configuration-Basics).

## Supported .NET Framework Versions

The NuGet Package contains binaries compiled against:

* .NET 4.5
* .NET 4.6

## Supported Serilog Versions

* (.NET 4.5 onwards) Serilog 2.3.0 onwards
