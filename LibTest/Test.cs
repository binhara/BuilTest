using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using ClassLib;

namespace LibTest
{
   
  [TestFixture]
  public class Test
  {
    [Test]
    public void Soma()
    {
        Calculadora c = new Calculadora();
        c.X = 2;
        c.Y = 4;  
        	  
      Assert.AreEqual(6, c.Soma());

    }

    [Test]
    public void Multiplica()
    {
        Calculadora c = new Calculadora();
        c.X = 2;
        c.Y = 4;

        Assert.AreEqual(8, c.Multiplica());

    }
  }
}
