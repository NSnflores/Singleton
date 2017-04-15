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
	class NonSingletonModifiedClass
	{
		public static int a = 1;
	}
	class MainClass
	{
		static void modifyNonSingleton()
		{
			NonSingletonModifiedClass.a = 2;
		}
		static void modifySingletonObject()
		{
			SingletonClass.getInstance ().a = 2;
		}
		public static void Main (string[] args)
		{
			Console.WriteLine (NonSingletonModifiedClass.a);
			Console.WriteLine (SingletonClass.getInstance().a);
			modifyNonSingleton();
			modifySingletonObject();
			Console.WriteLine (NonSingletonModifiedClass.a);
			Console.WriteLine (SingletonClass.getInstance().a);
		}
	}
}
