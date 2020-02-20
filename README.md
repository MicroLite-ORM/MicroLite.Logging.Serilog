# MicroLite.Logging.Serilog

## Status

|Service|Status|
|-------|------|
||[![NuGet version](https://badge.fury.io/nu/MicroLite.Logging.Serilog.svg)](http://badge.fury.io/nu/MicroLite.Logging.Serilog)|
|/develop|[![Build Status](https://dev.azure.com/trevorpilley/MicroLite-ORM/_apis/build/status/MicroLite-ORM.MicroLite.Logging.Serilog?branchName=develop)](https://dev.azure.com/trevorpilley/MicroLite-ORM/_build/latest?definitionId=35&branchName=develop)|
|/master|[![Build Status](https://dev.azure.com/trevorpilley/MicroLite-ORM/_apis/build/status/MicroLite-ORM.MicroLite.Logging.Serilog?branchName=master)](https://dev.azure.com/trevorpilley/MicroLite-ORM/_build/latest?definitionId=35&branchName=master)|

## Installation

Install the nuget package `Install-Package MicroLite.Extensions.Serilog`

## Summary

MicroLite.Logging.Serilog is a .NET 4.5 library which adds an extension for the MicroLite ORM Framework to use Serilog as the logging library.

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

## Supported .NET Versions

The NuGet Package contains binaries compiled against (dependencies indented):

* .NET Framework 4.5
  * MicroLite 7.0.0
  * Serilog 2.6.0
