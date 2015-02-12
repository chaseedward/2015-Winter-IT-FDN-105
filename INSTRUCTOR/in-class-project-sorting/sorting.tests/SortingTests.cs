using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using in_class_project_sorting;

namespace sorting.tests
{
    [TestClass]
    public class SortingTests
    {
        [TestMethod]
        public void TestSortingTwoElements()
        {
            var sorter = new Sorter(10);

            sorter.AddElement(100);
            sorter.AddElement(99);
            sorter.AddElement(98);
            sorter.AddElement(97);
            sorter.AddElement(96);

            sorter.Sort();

            var array = sorter.GetArray();

            var element = array[0];

            for (int j = 0; j < sorter.Count; j++)
            {
                var item = array[j];

                Assert.IsTrue(element <= item,
                    string.Format("Items are out of order element={0}, item={1}", element, item));

                element = item;
            }
        }
    }
}
