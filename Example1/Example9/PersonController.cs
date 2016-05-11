﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Example9
{
    class PersonContext : DbContext
    {
        public DbSet<PersonModel> allPersons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions
                .Remove<PluralizingTableNameConvention>();

            //the id value is generated by the database on a new entry
            modelBuilder.Entity<PersonModel>()
        .Property(c => c.Id)
        .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }


    class PersonController
    {

        List<PersonModel> personsList;

        public PersonController()
        {

            syncData();
        }

        public void syncData()
        {
            using (var db = new PersonContext())
            {

                
                var people = (from person in db.allPersons
                              orderby person.Id
                              select person);

                personsList = people.ToList<PersonModel>();

            }
        }

        public List<PersonModel> getPersons()
        {
            syncData();
            return personsList;
        }

        public PersonModel addPerson(PersonModel personToAdd)
        {

            using (var db = new PersonContext())
            {

                db.allPersons.Add(personToAdd);
                db.SaveChanges();
            }

            syncData();
            return personToAdd;
        }

        public void updatePerson(PersonModel personToUpdate)
        {
           
            using (var db = new PersonContext())
            {
                var p = (from person in db.allPersons
                              where person.Id == personToUpdate.Id
                              select person);
                
                foreach (var pr in p)
                {
                   

                    pr.FirstName = personToUpdate.FirstName;
                    pr.SecondName = personToUpdate.SecondName;
                    pr.Age = personToUpdate.Age;
                    pr.TelNumber = personToUpdate.TelNumber;
                }

                db.SaveChanges();
            }


        }

        public void deletePerson(PersonModel personToDelete)
        {
          

            using (var db = new PersonContext())
            {
                db.allPersons.Attach(personToDelete);
                db.allPersons.Remove(personToDelete);
                db.SaveChanges();
            }
                
        }

               

        public void findPerson(PersonModel personToFind)
        {

            syncData();
            PersonModel currentPerson = personsList.Find(person => person.TelNumber == personToFind.TelNumber);
           
        }

        public void sortPersons()
        {
            personsList.Sort();
        }

    }
} 
