namespace Models
{
  class Car
  {
    public string makeModel;
    public int price;
    public int miles;

    public Car(string makeModel, int price, int miles)
    {
      makeModel = makeModel;
      price = price;
      miles = miles;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (price < maxPrice);
    }
  }
}