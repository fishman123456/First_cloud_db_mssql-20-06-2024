﻿// See https://aka.ms/new-console-template for more information
using CloudSqlServer_App;

Console.WriteLine("Hello, World!");

// протестируем работу БД

using (ApplicationDbContext db = new ApplicationDbContext())
{
    // добавим сущность
    Entity entity = new Entity() { Description = $"New entity at {DateTime.UtcNow}" };
    db.Entities.Add(entity);
    db.SaveChanges();
    //  и выведем все сущности
    foreach (Entity e in db.Entities)
    {
        Console.WriteLine(e);
    }
}
