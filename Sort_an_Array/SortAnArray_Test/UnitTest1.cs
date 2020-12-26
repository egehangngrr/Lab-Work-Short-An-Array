using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace SortAnArray_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Sort_an_Array.Form1 frmForm1 = new Sort_an_Array.Form1();

            int[] inputArray = new int[] { 10, 5, 5, 4, 3, 2, 1, 0, 0 };
            int[] outputArray = frmForm1.orderToArrayMethod(inputArray);

            int[] testArray = new int[] { 0, 0, 1, 2, 3, 4, 5, 5, 10 };

            CollectionAssert.AreEqual(testArray, outputArray);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Sort_an_Array.Form1 frmForm1 = new Sort_an_Array.Form1();

            int[] inputArray = new int[] { -5,0 ,0 ,1 ,3 ,5 ,7 ,9 ,2  };
            int[] outputArray = frmForm1.orderToArrayMethod(inputArray);

            int[] testArray = new int[] { -5, 0, 0, 1, 2, 3, 5, 7, 9 };

            CollectionAssert.AreEqual(testArray, outputArray);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Sort_an_Array.Form1 frmForm1 = new Sort_an_Array.Form1();

            int[] inputArray = new int[] { 1, 1, 1, 2, 2, 3, 3, 0, 0 };
            int[] outputArray = frmForm1.orderToArrayMethod(inputArray);

            int[] testArray = new int[] { 0, 0, 1, 1, 1, 2, 2, 3,3  };

            CollectionAssert.AreEqual(testArray, outputArray);
        }
    }
}
