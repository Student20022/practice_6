using System;
namespace practice_6
{
    public class Child1 : IParent
	{
		int speed;
		int costOfProduction;

		public Child1(int speed, int costOfProduction)
		{
			this.speed = speed;
			this.costOfProduction = costOfProduction;
		}
		public string info()
		{
			return $"Наземный. Скорость= {speed}, Себестоимость= {costOfProduction}, Стоимость= {cost()}";
		}
		public double cost()
		{
			return costOfProduction / speed;
		}
	}
}

