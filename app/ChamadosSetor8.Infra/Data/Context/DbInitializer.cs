using ChamadosSetor8.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Infra.Data.Context
{
    public static class DbInitializer
    {
        public static void Initialize(Sector8CallsContext context)
        {
            try
            {
                //context.Database.EnsureCreated();

                //#################################################################
                // Grupo
                //#################################################################

                if (!context.Group.Any())
                {
                    var groups = new Group[]
                    {
                new Group("GRUPO - 1")
                    };

                    foreach (var group in groups)
                    {
                        context.Group.Add(group);
                    }

                    context.SaveChanges();
                }


                //#################################################################
                // Casa de oração
                //#################################################################

                if (!context.Church.Any())
                {
                    var churchs = new Church[]
                    {
                        new Church("Leonidas Moreira","",1),
                        new Church("Vila pazzine","",1)
                    };

                    foreach (var church in churchs)
                    {
                        context.Church.Add(church);
                    }

                    context.SaveChanges();
                }

                //#################################################################
                // Departamento
                //#################################################################

                if (!context.Department.Any())
                {
                    var departments = new Department[]
                    {
                new Department("Tecnologia","Departamento de tecnologia")

                    };

                    foreach (var department in departments)
                    {
                        context.Department.Add(department);
                    }

                    context.SaveChanges();
                }

                //#################################################################
                // PROFILE
                //#################################################################

                if (!context.Profile.Any())
                {
                    var profiles = new Profile[]
                    {
                new Profile("Administrador","Adm do sistema de chamados")

                    };

                    foreach (var profile in profiles)
                    {
                        context.Profile.Add(profile);
                    }

                    context.SaveChanges();
                }

                //#################################################################
                // USUÄRIO
                //#################################################################

                if (!context.User.Any())
                {

                    var churchs = context.Church.Where(x => (new List<int> { 1}).Contains(x.Id));

                    var users = new User[]
                    {
                        new User("Miriane","miriane@gmail.com",1,1).AddChurchs(churchs.ToList()),
                    //    new User("Jonathan","jonathan@gmail.com",1,1).AddChurchs(churchs.ToList()),
                    //    new User("Simon","simon@gmail.com",1,1).AddChurchs(churchs.ToList()),
                    };

                    foreach (var user in users)
                    {
                        context.User.Add(user);
                    }

                    context.SaveChanges();
                }





            }
            catch (Exception ex)
            {

            }
        }
    }
}