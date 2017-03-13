namespace CustomerContactManager.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CustomerContactManager.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CustomerContactManager.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                List<Customer> customerList = new List<Customer>() {
                    new Customer() { Name = "Capitec", Latitude = "22°10\'20\"S", Longitude = "22°15\'55\"E", ContactList =new List<CustomerContact>() {
                    new CustomerContact() { Name="Doug Smith", ContactNumber = "0113615840", Email = "doug.smith@capitec.com"},
                    new CustomerContact() { Name="Riley Jones", ContactNumber = "0125677861", Email = "riley.jones@capitec.com"},
                    new CustomerContact() { Name="Andrew Taylor", ContactNumber = "0154815647", Email = "andrew.taylor@capitec.com"}} },
                    new Customer() { Name = "Absa", Latitude = "20°05\'55\"S", Longitude = "29°55\'05\"E", ContactList =new List<CustomerContact>() {
                    new CustomerContact() { Name="Rolando Brown", ContactNumber = "0185108444", Email = "rolando.brown@absa.com"},
                    new CustomerContact() { Name="Hal Davies", ContactNumber = "0164157157", Email = "hal.davies@absa.com"},
                    new CustomerContact() { Name="Genia Evans", ContactNumber = "0119438467", Email = "genia.evans@absa.com"}} },
                    new Customer() { Name = "First Rand", Latitude = "28°45\'20\"S", Longitude = "23°25\'50\"E", ContactList =new List<CustomerContact>() {
                    new CustomerContact() { Name="Clorinda Wilson", ContactNumber = "0152178005", Email = "clorinda.wilson@firstrand.com"},
                    new CustomerContact() { Name="Peg Thomas", ContactNumber = "0147472140", Email = "peg.thomas@firstrand.com"},
                    new CustomerContact() { Name="Diana Roberts", ContactNumber = "0128763321", Email = "diana.roberts@firstrand.com"}} }
                };
                
                customerList.ForEach(customer => dbContext.Customers.AddOrUpdate(c => c.Id, customer));
                dbContext.SaveChanges();
            }
        }
    }
}
