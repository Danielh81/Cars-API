namespace test.CarList.Repositories.CarsRepository;

using test.CarList.Data.CarsData;

public class CarsRepository {

  public Car GetCar(int index) {
      var car = CarsData.cars;

      return car.ToList()[index];
  }

  public IEnumerable<Car> GetallCars() {
      var allCars = CarsData.cars;

      return allCars;
  }

  public Car GetRandomCar() {
      Random random = new Random();
      var randomNumber = random.Next(0, 4);
      var randCar = CarsData.cars[randomNumber];
      
      return randCar;
  }

}