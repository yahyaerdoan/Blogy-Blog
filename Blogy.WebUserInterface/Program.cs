using Blogy.BussinessLayer.Abstract;
using Blogy.BussinessLayer.Concrete;
using Blogy.DataAccessLayer.Abstract;
using Blogy.DataAccessLayer.Context;
using Blogy.DataAccessLayer.EntityFramework;
using Blogy.EntityLayer.Concrete;
using Blogy.WebUserInterface.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#region Dependency enjection

builder.Services.AddDbContext<BlogyContext>();

builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();

builder.Services.AddScoped<IArticleDal, EfArticleDal>();
builder.Services.AddScoped<IArticleService, AricleManager>();

builder.Services.AddScoped<ICommentDal, EfCommentDal>();
builder.Services.AddScoped<ICommentService, CommentManager>();

builder.Services.AddScoped<ITagDal, EfTagDal>();
builder.Services.AddScoped<ITagService, TagManager>();

builder.Services.AddScoped<IWriterDal, EfWriterDal>();
builder.Services.AddScoped<IWriterService, WriterManager>();

builder.Services.AddIdentity<AppUser, AppRole>()
    .AddEntityFrameworkStores<BlogyContext>()
    .AddErrorDescriber<CustomIdentityValidator>();

#endregion
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.Run();
