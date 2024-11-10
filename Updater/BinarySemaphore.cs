namespace Updater;

public class BinarySemaphore
{
    private SemaphoreSlim _semaphore;

    // Constructor to initialize the semaphore with an initial count of 1 (binary state)
    public BinarySemaphore()
    {
        _semaphore = new SemaphoreSlim(1, 1);  // Initial count of 1, maximum count of 1
    }

    // Wait method that blocks until the semaphore is available
    public void Wait()
    {
        _semaphore.Wait();  // Blocks the current thread until it can enter
    }

    // Signal method that releases the semaphore, allowing a waiting thread to proceed
    public void Signal()
    {
        _semaphore.Release();  // Releases the semaphore, allowing one thread to enter
    }
    // Method to check the current status of the semaphore
    public string PrintStatus()
    {
        // Check the CurrentCount of the underlying SemaphoreSlim instance
        return _semaphore.CurrentCount == 0 ? "Semaphore is currently held" : "Semaphore is available";
    }
}
