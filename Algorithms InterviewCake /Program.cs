using System;
using InterviewCake;
using System.Collections.Generic;
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
//StockPrice stocks = new StockPrice();
            //stocks.test();

            // ProductOfOtherNumbers product = new ProductOfOtherNumbers();
            // product.getProductsOfAllIntsExceptAtIndex(new int[]{ 1, 7, 3, 4 });
            //MergeMeetingTimes meetingTimes = new MergeMeetingTimes();
            //meetingTimes.Test();
       
            //Rectangle rect1 = new Rectangle(0, 0, 10, 10);
            //Rectangle rect2 = new Rectangle(1, 1, 2, 2);
            //Rectangle rectLove = rect1.InterSection(rect2);

            /*TempertureTracker temp = new TempertureTracker();           
            temp.insert(1);
            temp.insert(3);
            temp.insert(6);
            temp.insert(3);
            temp.insert(1);
            temp.insert(3);
            Console.WriteLine("max=" + temp.getMax());
            Console.WriteLine("min=" + temp.getMin());
            Console.WriteLine("mean=" + temp.getMean());
            Console.WriteLine("mode=" + temp.getMode());*/

            //SuperBalanced super = new SuperBalanced();
            //super.Tester();

            //ValidSearchTree valid = new ValidSearchTree();
            //valid.Tester();

            //SecondLargestItemInBST secondBST = new SecondLargestItemInBST();
            // secondBST.Tester();


            //SecondLargestItemInBST bst = new SecondLargestItemInBST();
            //bst.Tester();

            // FindRotationPoint rotPoint= new FindRotationPoint();
            // rotPoint.TestRotPoint();
            //InFlightEntertainment flight= new InFlightEntertainment();
            //int[] movieLengths={1,2,4,3};
            //flight.flightLength(4,movieLengths);

            //  Fibonacci fib= new Fibonacci();
            //  int f = fib.fib(8);


            /*QueueTwoStacks <int>qTwoStacks= new QueueTwoStacks<int>();
            qTwoStacks.Enqueue(1);
            qTwoStacks.Enqueue(2);
            qTwoStacks.Enqueue(3);
            qTwoStacks.Dequeue();
            qTwoStacks.Enqueue(4);
           Console.WriteLine(qTwoStacks.ToString());*/

            /*LargestStack largestStack= new LargestStack();
                    largestStack.Push(11);Console.WriteLine(largestStack.getMax());
                    largestStack.Push(2);Console.WriteLine(largestStack.getMax());
                    largestStack.Push(10);Console.WriteLine(largestStack.getMax());
                    largestStack.Push(5);Console.WriteLine(largestStack.getMax());
                    largestStack.Push(6);Console.WriteLine(largestStack.getMax());
                    largestStack.Pop();Console.WriteLine(largestStack.getMax());
                    */

            //StolenBreakfastDrone drone= new StolenBreakfastDrone();
            //Console.WriteLine(drone.FindUnique(new int[]{1,2,3,4,5,1,2,3,5}));

            // DeleteNode node=new DeleteNode();
            // node.Test();

            //new LinkedListCycle().Test();
            //new ReverseLinkedList().Test();

            //new kthToLastNode().Test();

            /* ReverseStringInPlace str = new ReverseStringInPlace();
             string reversed=str.ReverseString("abc");
             Console.WriteLine(reversed);*/
            //Console.WriteLine(new ReverseWords().reverseWords("find you will"));
            //ParenthesisMatching match = new ParenthesisMatching();
            // Console.WriteLine(match.getMatching("Sometimes (when I nest them (my parentheticals) too much (like this (and this))) they get confusing.", 10));

            //BracketValidator validator = new BracketValidator();
            //Console.WriteLine(validator.isWellFormedExpression("{ [ ] ( ) }"));

            // PermuationPalindrome perm = new PermuationPalindrome();
            // Console.WriteLine(perm.isPermPalindrome("civic"));

            //RecursiveStringPermutations perm = new RecursiveStringPermutations();
            //perm.findAnagrams("ABC");

            // TopScores scores = new TopScores();
            // scores.sortScores(new int[] {37, 89, 41, 65, 91, 53,41,65}, 100);

            //  WhichAppearsTwice twice = new WhichAppearsTwice();
            //  Console.WriteLine(twice.whichAppearsTwice(new int[]{1,2,4,5,6,7,8,9,5}));

            // new WorldCloudData().Test();

            // new InPlaceShuffle().Test();

            //new SingleRiffleShuffle().Test();

            //new Simulate7SidedDie().Test();

            //Console.WriteLine("duplicate="+new FindRepeatSpaceEdition().FindDuplicate(new[] { 4, 3, 2, 2, 5, 1 }));


            // new MergeSortedArrays().Test();

            /*Anagram anagram = new Anagram();
            List<string> anagrams = anagram.GetAnagrams("abc");
            foreach (var ana in anagrams)
            {
                Console.WriteLine(ana);
            }*/

            LRUCache cache = new LRUCache(4);
            cache.set(1, 1);
            cache.set(2, 2);
            cache.set(3, 3);
            cache.set(4, 4);
            cache.set(5, 5);
            cache.get(2);








        }
    }
}
