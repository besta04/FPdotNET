//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#if DEBUG
using NUnit.Framework;
using System;

namespace AssemblyCSharp
{
		[TestFixture()]
		public class ScoreTest
		{
			[Test()]
			public void Testgagal ()
			{
				Assert.AreEqual(1,2);
			}

			[Test()]
			public void Testberhasil()
			{
				Assert.AreEqual(2,2);
			}

			[Test()]
			public void TestScore()
			{
				Score score= new Score();
				score.addScore();
				score.addScore();
				Assert.Equals(2,score.getScore());
			}
		}
}

#endif