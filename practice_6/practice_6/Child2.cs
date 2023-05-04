using System;
namespace practice_6
{
	public class Child2 : IParent
	{
		int speed;
		int costOfProduction;
		int roadTax;

		public Child2(int speed,int costOfProduction,int roadTax)
		{
			this.speed = speed;
			this.costOfProduction = costOfProduction;
			this.roadTax = roadTax;
		}
        public string info()
        {
            return $"Морской. Скорость= {speed}, Себестоимость= {costOfProduction},дорожный сбор= {roadTax}, Стоимость= {cost()}";
        }
        public double cost()
        {
            return (costOfProduction / speed) + roadTax;
        }
    }
}

