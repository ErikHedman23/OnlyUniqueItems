

using OnlyUniqueElements;

namespace OnlyUniqueElementsTests
{
    public class UnitTest1
    {
        [Fact]
        public void ReturnsSortedStringArray_ToLower()
        {
            var inputArray = new string[] { "c", "a", "t", "a", "p", "u", "l", "t" };
            var expected = new string[] { "c", "a", "t", "p", "u", "l" };

            var result = UniqueItems.OnlyReturnUniqueItems(inputArray);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ReturnsSortedStrungArray_UpperAndLower()
        {
            var inputedArray = new string[] { "C", "a", "T", "A", "p", "u", "l", "t" };
            var expected = new string[] { "C", "a", "T", "A", "p", "u", "l", "t" };

            var result = UniqueItems.OnlyReturnUniqueItems(inputedArray);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ReturnsSortedArray_Integers()
        {
            var inputedArray = new int[] { 1, 2, 3, 4, 5, 6, 66, 11, 25, 25, 235, 99, 99, 1, 3, 2, 1, 0 };
            var expected = new int[] { 1, 2, 3, 4, 5, 6, 66, 11, 25, 235, 99, 0 };

            var result = UniqueItems.OnlyReturnUniqueItems(inputedArray);
            Assert.Equal(expected, result);
        }

    }
}