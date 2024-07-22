using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListTests
{
    public class MergeSortedLinkedLists
    {
        [Fact]
        public void OneListEmptyList()
        {
            //Act
            LinkedList.LinkedList list = new LinkedList.LinkedList();
            LinkedList.LinkedList list2 = new LinkedList.LinkedList();

            list2.Add(1);
            list2.Add(2);
            list2.Add(3);

            //Arrange
            LinkedList.LinkedList mergedList = LinkedList.LinkedList.MergeSortedLists(list, list2);

            //Assert
            Assert.Equal(3, mergedList.Count());
        }
        [Fact]
        public void BothListsEmpty()
        {
            //Act
            LinkedList.LinkedList list = new LinkedList.LinkedList();
            LinkedList.LinkedList list2 = new LinkedList.LinkedList();

            //Arrange
            LinkedList.LinkedList mergedList = LinkedList.LinkedList.MergeSortedLists(list, list2);

            //Assert
            Assert.Equal(0, mergedList.Count());
        }
        [Fact]
        public void MergeListTest()
        {
            LinkedList.LinkedList list = new LinkedList.LinkedList();
            list.Add(5);
            list.Add(10);
            list.Add(15);

            LinkedList.LinkedList list2 = new LinkedList.LinkedList();
            list2.Add(2);
            list2.Add(3);
            list2.Add(20);

            LinkedList.LinkedList mergedList = LinkedList.LinkedList.MergeSortedLists(list, list2);

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                mergedList.Print();

                var standardOutput = new StreamWriter(Console.OpenStandardOutput());
                standardOutput.AutoFlush = true;
                Console.SetOut(standardOutput);

                // Assert
                var expected = "2 3 5 10 15 20 \r\n";
                Assert.Equal(expected, sw.ToString());
            }
        }
    }
}
