using System;
using Xunit;

namespace TetrisBot.Tests
{

	public class MyTest
	{

		[Fact]
		public void TestCase1()
		{
        	//Console.WriteLine("[TestCase1]");
			int a = 2;
			int b = 4;

			var result = a * b;

			// Assert
			Assert.Equal(8, result);
		}

		[Fact]
		public void TestCase2()
		{
			Assert.Equal("FOOBAR", "FOO" + "BAR");
		}

	}
}