using BinarySearchTreeAssigment;

namespace BinarySearchTreeAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*****Welcome to the Hash Table and Bst problem*****");
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
            binarySearch.Add(30);
            binarySearch.Add(70);
            binarySearch.Display();

        }
    }
}