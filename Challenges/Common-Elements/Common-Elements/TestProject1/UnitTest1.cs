using Common_Elements;
namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            int[] array1 = { 1, 2, 3, 0 };
            int[] array2 = { 2, 3, 4, 9 };

            // Act
            int[] commonElements = Program.CommonElements(array1, array2);

            // Assert
            Assert.Equal(new int[] { 2, 3 }, commonElements);
        }
        [Fact]
        public void Test2() 
        {
            // Arrange
            int[] array1 = { 79, 8, 15 };
            int[] array2 = { 23, 79, 8 };

            // Act
            int[] commonElements = Program.CommonElements(array1, array2);

            // Assert
            Assert.Equal(new int[] { 79, 8 }, commonElements);
        }
    }
}