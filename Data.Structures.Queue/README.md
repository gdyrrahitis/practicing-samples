# Data Structures - Queue

## Description
A queue resembles a stack data structure, but in queues the first item that is pushed in, is the one that is removed. This data structure is commonly referred as First-In-First-Out or FIFO.

A queue works like a real life queue, where people are waiting in line, like the queue of people waiting in the cinema to buy a ticket, the first person that enters the queue is the first that will buy the ticket. More people will enter the queue, waiting to be serviced, the person in front will be serviced first, then the next is the person behind and so on and so forth.

## Applicability
Queues are a programming tool like stacks. They are used in describing real life situations like the queue of people waiting to get board on a plan or network packets that are waiting in a queue to get processed and ultimately transmitted over the internet.

Another example would be a printer's queue in which print jobs are waiting for the printer to process them.

## Collaborators
### Queue
This is the queue data structure. For demo purposes, this is a queue that works with integers only.

It contains methods to insert a new item in the queue, like the `Push(int value)` method. It also has other methods like `Pop()` which removes and returns an item from the queue and `Empty()` which empties the queue.

It also contains some helper properties like `Size`, which returns the current size of the queue and `IsEmpty` which returns a `boolean` indicating that the queue is empty or not.

### QueueEnumerator
The `QueueEnumerator` is a class that implements the `IEnumerator` interface, which is used to define an `IEnumerable` instance. This provides the interface that is needed for a loop construct like `foreach` to loop through the data structure items.
The interface has methods like:
* `MoveNext()`. This indicates if the enumerator can move to the next item, or has reached the end of items.
* `Reset()`. This methods resets the enumerator back to the starting point.
And properties like
* `Current`. This returns the current item in the enumeration.