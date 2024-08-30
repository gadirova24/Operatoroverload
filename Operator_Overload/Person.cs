using System;
namespace Operator_Overload
{

    //record PersonRecord
    //{
    //    public string Name { get; init; }
    //    public string Surname { get; init; }
    //}
    internal class Person
	{
		public readonly string Test;
		public const string A = "aassa";
		public int Id { get; init; } = 1;
		public string Name { get; set; }
        public string Surname { get; set; }
        public int  Age { get; set; }


	public Person()
	{
		//Test="azha aza zah";
	}
	public Person(int id)
	{
		Id = id;
	}

	public override string ToString()
	{
		return $"{Id}{Name}{Surname}";
	}

	//public static bool operator == (Person p1, Person p2)
	//{
	//		return p1.Name == p2.Name && p1.Surname == p2.Surname && p1.Age == p2.Age;

 //   }

 //       public static bool operator !=(Person p1, Person p2)
 //       {
	//		return !(p1 == p2);

 //       }

 //       public static bool operator >(Person p1, Person p2)
 //       {
 //           return p1.Age>p2.Age;

 //       }
 //       public static bool operator <(Person p1, Person p2)
 //       {
 //           return p1.Age < p2.Age;

 //       }

 //       public static int  operator +(Person p1, Person p2)
 //       {
 //           return p1.Age + p2.Age;

 //       }
 //       public static Person operator ++(Person p)
 //       {
 //           p.Age++;
 //           return p;

 //       }
    }


}

