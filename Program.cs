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
	//Clase con solo atributos estaticos --- Cumple lo mismo que el singleton anterior
	class NonSingletonStaticClass
	{
		//privado para no crear instancias
		private NonSingletonStaticClass(){}

		public static int a = 1;
	}

	class MainClass
	{
		//Modificamos la clase con solo atributos estaticos
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
			Console.WriteLine(NonSingletonStaticClass.a);
			Console.WriteLine(SingletonClass.getInstance().a);

			//Modificamos el singleton y la clase con atributos estaticos
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
