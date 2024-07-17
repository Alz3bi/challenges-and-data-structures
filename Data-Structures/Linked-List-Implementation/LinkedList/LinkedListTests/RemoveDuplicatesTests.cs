using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListTests
{
    public class RemoveDuplicatesTests
    {
        [Fact]
        public void NoDuplicates()
        {
            // Arrange
            LinkedList.LinkedList list = new LinkedList.LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            // Act
            list.RemoveDuplicates();
            // Assert
            Assert.Equal(5, list.Count());
        }
        [Fact]
        public void DuplicatesRemoved()
        {
            // Arrange
            LinkedList.LinkedList list = new LinkedList.LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            // Act
            list.RemoveDuplicates();
            // Assert
            Assert.Equal(5, list.Count());
            Assert.True(list.Includes(1));
            Assert.True(list.Includes(2));
            Assert.True(list.Includes(3));
            Assert.True(list.Includes(4));
            Assert.True(list.Includes(5));
        }
        [Fact]
        public void SingleNode()
        {
            // Arrange
            LinkedList.LinkedList list = new LinkedList.LinkedList();
            list.Add(1);
            list.Add(1);
            list.Add(1);
            // Act
            list.RemoveDuplicates();
            // Assert
            Assert.Equal(1, list.Count());
            Assert.True(list.Includes(1));
        }
    }
}
