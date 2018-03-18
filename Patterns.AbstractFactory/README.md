# Abstract Factory

## Intent
Provide an interface for creating families of related or dependent objects without specifying their concrete classes.

## Applicability
Use the **Abstract Factory** pattern when
* a system should be independent of how its objects are created, represented and composed
* a system should be configured with one or multiple families of objects
* a family of related objects is designed to be used together and you need to enforce this constraint
* you wish to provide a class library of objects and you want to reveal only their interfaces and not concrete classes/implementations.

## Collaborators
* `ISmith`. This is the abstract factory. It defines the family of related factories by its interface.
* `Metal`. The abstract product. This is an abstract class that all the products created by `ISmith` factories.
* `ArrowHead`, `Coin`, `Sword`. They are the concrete implementations of `Metal` abstract product.
* `ArrowHead`, `CoinSmith`, `SwordSmith`. They are the concrete factory implementations of `ISmith`. They contain operations to create a `Metal` product.