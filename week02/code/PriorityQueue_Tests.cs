using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add elements with different priorities
    // Expected Result: The element with highest priority should be removed first
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Tim", 2);
        priorityQueue.Enqueue("Sue", 6);
        priorityQueue.Enqueue("Bob", 3);

        var result = priorityQueue.Dequeue();

        //Verify that Sue is first
        Assert.AreEqual("Sue", result);
        //Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: Add items with same priority 
    // Expected Result: The item closest to the front of the queue will be removed and its value returned.
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Tim", 6);
        priorityQueue.Enqueue("Sue", 6);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("Tim", result);
        //Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: Try to Dequeue from an empty queue
    // Expected Result: InvalidOperationException should be thrown.
    // Defect(s) Found: 
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();
        
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Excpetion should have ben trown");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
                

    }
}