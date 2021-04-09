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

        public static List<Company> GetCompanys()
        {

            var comp = db.Companies.ToList();
            comp.Add(new Company
            {
                CompanyId = 0,
                Name = "[Selecione uma Compania]"
            });

            return comp = comp.OrderBy(d => d.Name).ToList();
        }

        public static List<Category> GetCategories(int companyId)
        {

            var cat = db.Categories.Where(c => c.CompanyId == companyId).ToList();
            cat.Add(new Category
            {
                CategoryId = 0,
                Description = "[Selecione uma Categoria]"
            });

            return cat = cat.OrderBy(d => d.Description).ToList();
        }

        public static List<Tax> GetTaxes(int companyId)
        {

            var tax = db.Taxes.Where(c => c.CompanyId == companyId).ToList();
            tax.Add(new Tax
            {
                TaxId = 0,
                Description = "[Selecione uma Taxa]"
            });

            return tax = tax.OrderBy(d => d.Description).ToList();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    
    }
}