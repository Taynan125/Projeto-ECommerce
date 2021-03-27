using ECommerceTaynan.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ECommerceTaynan.Classes
{
    public class ComboHelper : IDisposable
    {
        private static ECommerceContext db = new ECommerceContext();

        public static List<Departaments> GetDepartaments() { 

        var dep = db.Departaments.ToList();
        dep.Add(new Departaments
        {
                DepartamentsId = 0,
                Name = "[Selecione um Departamento]"
            });

            return dep = dep.OrderBy(d => d.Name).ToList();
        }

        public static List<City> GetCities()
        {

            var dep = db.Cities.ToList();
            dep.Add(new City
            {
                CityId = 0,
                Name = "[Selecione uma Cidade]"
            });

            return dep = dep.OrderBy(d => d.Name).ToList();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    
    }
}