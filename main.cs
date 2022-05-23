using Microsoft.AspNetCore.Builder;
using System;

public static class Program
{
  public static void Main(string[] args)
  {
    WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
    WebApplication app = builder.Build();

    app.MapGet("/", () => "Hello, world!");

    app.Run();
  }
}
