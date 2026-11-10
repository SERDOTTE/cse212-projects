using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue items with different priorities: A (1), B (3), C (2) and dequeue until the queue is empty.
    // Expected Result: B, C, A (highest priority first). Each dequeued item is removed from the queue.
    // Defect(s) Found: The dequeued item was never removed from the queue (missing RemoveAt),
    // so Dequeue kept returning the same value forever.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 3);
        priorityQueue.Enqueue("C", 2);

        Assert.AreEqual("B", priorityQueue.Dequeue());
        Assert.AreEqual("C", priorityQueue.Dequeue());
        Assert.AreEqual("A", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue items where more than one has the highest priority: A (2), B (5), C (5), D (1).
    // Expected Result: B first (closest to the front, per FIFO), then C, then A, then D.
    // Defect(s) Found: The comparison used '>=', which selected the LAST item with the highest
    // priority instead of the FIRST one. Changed to '>' to preserve FIFO order on ties.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 2);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 5);
        priorityQueue.Enqueue("D", 1);

        Assert.AreEqual("B", priorityQueue.Dequeue());
        Assert.AreEqual("C", priorityQueue.Dequeue());
        Assert.AreEqual("A", priorityQueue.Dequeue());
        Assert.AreEqual("D", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.


    [TestMethod]
    // Scenario: The item with the highest priority is the last one in the queue: A (1), B (2), C (10).
    // Expected Result: C is dequeued first even though it is at the back of the queue.
    // Defect(s) Found: The loop condition 'index < _queue.Count - 1' never checked the last item,
    // so a highest priority item at the back was ignored. Changed to 'index < _queue.Count'.
    public void TestPriorityQueue_HighestPriorityAtBack()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 10);

        Assert.AreEqual("C", priorityQueue.Dequeue());
        Assert.AreEqual("B", priorityQueue.Dequeue());
        Assert.AreEqual("A", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Try to dequeue from an empty queue.
    // Expected Result: InvalidOperationException with the message "The queue is empty."
    // Defect(s) Found: None (this requirement was already implemented correctly).
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }
    }
}