using System;

namespace SingletonTest
{
	class SingletonClass 
	{
		private static  SingletonClass singletonObject = new SingletonClass();
		private SingletonClass(){}
		public int a = 1;
		public static SingletonClass getInstance()
		{
			return singletonObject;
		}
	}
	//Clase estatica --- Cumple lo mismo que el singleton anterior
	class NonSingletonStaticClass
	{
		public static int a = 1;
	}

	class MainClass
	{
		//Modificamos la clase estatica
		static void modifyStatic()
		{
			NonSingletonStaticClass.a = 2;
		}
		//Modificamos  el objeto
		static void modifySingletonObject()
		{
			SingletonClass.getInstance().a = 2;
		}
		public static void Main (string[] args)
		{
			Console.WriteLine (NonSingletonStaticClass.a);
			Console.WriteLine (SingletonClass.getInstance().a);
			modifyStatic();
			modifySingletonObject();
			Console.WriteLine(NonSingletonStaticClass.a);
			Console.WriteLine(SingletonClass.getInstance().a);

			//OUTPUTS
			/*
				1
				1
				2
				2
			*/
		}
	}
}
