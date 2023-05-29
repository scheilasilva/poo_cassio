﻿using Aula12_TestandoORM.Data.Context;
using Aula12_TestandoORM.Data.Repositories;
using Aula12_TestandoORM.Domain.Entities;
using Aula12_TestandoORM.Domain.Interfaces;

var db = new MeuContexto();
ICarroRepository _carroRepository = new CarroRepository(db);
IEstacionamentoRepository _estacionamentoRepository = new EstacionamentoRepository(db);

Console.WriteLine("Adicionar novo carro:");
var carro = new Carro()
{
    Id = 1,
    Marca = "VW",
    Modelo = "Golf",
    Estacionamento = new Estacionamento()
    {
        Id = 1
    }
};
_carroRepository.Save(carro);
GetAllCarros();

Console.WriteLine();
/*
 Console.WriteLine("Update na vaga");
 var c = _estacionamentoRepository.GetById(2);

 var carro1 = new Carro() 
 {
     Id = 1, 
     Marca = "VW novo", 
     Modelo = "Golf novo",
     Estacionamento = e
 }; 

 _carroRepository.Save(carro);
 GetAllCarros();
 */

Console.WriteLine();

 Console.WriteLine("Listar carro pelo ID:");
 var vaga = _estacionamentoRepository.GetById(1);
 var carro2 = _carroRepository.GetById(1);
 Console.WriteLine($"Id: {carro.Id} - Marca: {carro.Marca} - Modelo {carro.Modelo} - Vaga: {carro.Estacionamento.Id}");



Console.WriteLine();

 Console.WriteLine("Listar os carros estacionados:");
 var c = _carroRepository.GetAll();
 GetAllCarros();

Console.WriteLine();

 Console.WriteLine("Deletar um carro:");
 _carroRepository.Delete(1);
 GetAllCarros();

Console.WriteLine();

 Console.WriteLine("Deletar um estacionamento:");
 _estacionamentoRepository.Delete(1);
 GetAllCarros();

Console.WriteLine();

 Console.WriteLine("Atualizar o carro");
 var carro1 = _carroRepository.GetById(2);
 carro.Marca = "VW novo";
 carro.Modelo = "Jetta novo";
 _carroRepository.Update(carro);

Console.WriteLine();

void GetAllCarros()
{
    var c = _carroRepository.GetAll();
    foreach (var item in c)
    {
        Console.WriteLine("Nova lista: ");
        var vaga = _estacionamentoRepository.GetAll();
        var carro = _carroRepository.GetAll();
        Console.WriteLine($"Id: {item.Id} - Marca: {item.Marca} - Modelo: {item.Modelo} - Vaga: {item.Estacionamento.Id}");
    }
}