namespace test.CarList.Services.CarService;

using System;
using test.CarList.Repositories.CarsRepository;

public class CarService {

    private readonly CarsRepository CarsRepository;

    public CarService(CarsRepository repository) {
        CarsRepository = repository;
    }

    public Car GetCar(int index) {
        var car = CarsRepository.GetCar(index);

        return car;
    }

    public Car GetRandomCar() {
        var randCar = CarsRepository.GetRandomCar();

        return randCar;
        
    }
    public IEnumerable<Car> allCars() {
        var allCars = CarsRepository.GetallCars();

        return allCars;
    }


}




