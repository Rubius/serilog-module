# ![Rubius logo](./.docs/media/logo_48x48.png) Rubius.Logging.Serilog

Logging configuration simplifier, enabling by a couple lines of code

## How to use

* Add base configuration calling the extension method `AddSerilogLoggingModule(this ILoggingBuilder builder)`

```csharp
private static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        ...
        .ConfigureLogging(builder => builder.AddSerilogLoggingModule())
        ...;
```

* Use HTTP request logging calling the extension method `UseSerilogHttpRequestLoggingModule(this IApplicationBuilder app)`

```csharp
public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    ...
    
    app.UseSerilogRequestLoggingModule();

    ...
}
```
