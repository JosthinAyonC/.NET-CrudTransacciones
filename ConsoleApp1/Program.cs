using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Collections.Generic;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        guardarEstudianteYdireccionTransaction();
    }


    public static void guardarEstudianteYdireccionTransaction()
    {
        Console.WriteLine("Metodo agregar Persona, cargo y empresa con transaccion");

        EmpresaContext context = new EmpresaContext();
        Persona person = new Persona();
        Cargo cargo = new Cargo();
        Empresa empresa = new Empresa();
        var dbContextTransaction = context.Database.BeginTransaction();
        
        cargo.CargoId = 1;
        cargo.CargoName = "Gerente";
        empresa.EmpresaId = 1;
        empresa.Name = "Empresa1";

        try
        {
            person.Name = "Karina";
            person.Cargo = cargo;
            person.Empresa = empresa;
            context.Personas.Add(person);
            context.SaveChanges();
            dbContextTransaction.Commit();
            Console.WriteLine("Datos guardados con exito");
        }
        catch (Exception e)
        {
            dbContextTransaction.Rollback();
            Console.WriteLine("Error "+ e.ToString());
        }
       

    }
}