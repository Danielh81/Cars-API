namespace test.CarList.Controllers.CarController;

using System;
using Microsoft.AspNetCore.Mvc;
using test.CarList.Services.CarService;


[Route("")]
[ApiController]
public class CarController : ControllerBase
{
    private readonly ILogger<CarController> Logger;
    private readonly CarService Service;

    public CarController(ILogger<CarController> logger, CarService service)
    {
        Logger = logger;
        Service = service;
    }

    [HttpGet("/car")]
    public Car GetCar(int index)
    {
      var car = Service.GetCar(index);
      return car;
    }
    
    [HttpGet("/carlist")]
    public IEnumerable<Car> GetAllCars()
    {
      var allCars = Service.allCars();
      return allCars;
    }

    [HttpGet("/randomcar")]
    public Car GetRandomCar() 
    {
      var randCar = Service.GetRandomCar();
      return randCar;
    }
}
