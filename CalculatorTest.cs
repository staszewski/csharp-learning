using NUnit.Framework;

[TestFixture]
public class CalculatorTest
{
   [Test]
   public void EmptyString()
   {
       string toAdd = String.Empty;
       int expected = 0;
       
       Assert.AreEqual(Calculator.Add(toAdd), expected); 
   }

   [Test]
   public void OneNumber()
   {
       string toAdd = "1";
       int expected = 1;
       Assert.AreEqual(Calculator.Add(toAdd), expected); 
   }

   [Test]
   public void MultipleNumbers()
   {
       string toAdd = "1,2";
       int expected = 3;
       Assert.AreEqual(Calculator.Add(toAdd), expected); 
   }

   [Test]
   public void AllowNewLinesBetweenNumbers()
   {
       string toAdd = "1\n2,3";
       int expected = 6;
       
       Assert.AreEqual(Calculator.Add(toAdd), expected); 
   }

   [Test]
   public void DontAllowNewLinesAtTheEnd()
   {
       string toAdd = "1,\n";
       int expected = 0;
       
       Assert.AreEqual(Calculator.Add(toAdd), expected); 
   }

   [Test]
   public void DifferentDelimeters()
   {
       string toAdd = "1;2;3";
       int expected = 6;
       
       Assert.AreEqual(Calculator.Add(toAdd), expected); 
   }
}