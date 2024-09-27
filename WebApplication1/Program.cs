using System.Diagnostics;
using System;
using WebApplication1;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

//public class PersonalComputer
//{
//    string Processor;
//    int Count_Of_Ram;
//    int Volume_Of_Disk;
//    string Operating_System;
//    string Graphic_Card;

//}

PersonalComputer OptiPlex = new PersonalComputer("Intel", 8, 512, "Windows", "GTX650");



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
