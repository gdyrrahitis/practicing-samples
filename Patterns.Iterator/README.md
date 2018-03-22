# Iterator pattern

This pattern belongs to Structural design patterns family.

**Definition**
Provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation.

### Sample
In this sample you will find two implementations of this particular pattern.
In `V1` there is an old fashioned way implementation, where you build your own iterator, having an abstract **aggregate** for the object to iterate and an abstract custom **iterator**.
Their concrete implementations make use of the abstract classes to build the `PersonIterator` class, which iterates through the `Person` object properties.

On the other side, in `V2`, the `IEnumerable` interface is implemented in the `PersonIterator` class to allow creating a custom iterator.
