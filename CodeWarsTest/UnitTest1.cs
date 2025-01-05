using NUnit.Framework;
using System.Collections.Generic;
using CodeWars4kyu;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace CodeWarsTest
{
	public class Tests
	{
		[TestFixture]
		public class KataTest
		{

			[Test]
			public void ConnectFourTest()
			{
				var result = ConnectFourTask.WhoIsWinner(new List<string>()
			{
				"A_Red",
				"B_Yellow",
				"A_Red",
				"B_Yellow",
				"A_Red",
				"B_Yellow",
				"G_Red",
				"B_Yellow"
			});

                Assert.AreEqual("Yellow", result);
			}


		}
	}
}