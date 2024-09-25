using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListTests
{
    public class RotateLinkedListTests
    {
        [Fact]
        public void RotateByKIfZero()
        {
            //Arrange
            LinkedList.LinkedList list = new LinkedList.LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                //Act
                list.RotateByK(0);
                list.Print();

                var standardOutput = new StreamWriter(Console.OpenStandardOutput());
                standardOutput.AutoFlush = true;
                Console.SetOut(standardOutput);

                //Assert
                var expected = "1 2 3 4 5 \r\n";
                Assert.Equal(expected, sw.ToString());
            }

        }
        [Fact]
        public void RotateBykIfGreaterThanLength()
        {
            //Arrange
            LinkedList.LinkedList list = new LinkedList.LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                //Act
                list.RotateByK(6);
                list.Print();

                var standardOutput = new StreamWriter(Console.OpenStandardOutput());
                standardOutput.AutoFlush = true;
                Console.SetOut(standardOutput);

                //Assert
                var expected = "1 2 3 4 5 \r\n";
                Assert.Equal(expected, sw.ToString());
            }

        }
    }
}
