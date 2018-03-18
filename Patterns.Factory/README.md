# Factory Method pattern

## Intent
Define an interface for creating an object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.

## Applicability
Use Factory Method pattern when
* a class can't anticipate the class of objects it must create
* a class wants the subclass to specify the objects it creates
* classes delegate the responsibility to one of several helper subclasses and you want to localize the knowledge of which helper subclass is the delegate.

## Collaborators
* `ISceneFactory`. This is the creator interface that declares a factory method which returns an object of type `Scene`.
* `SceneFactory`. This is the concrete implementation of the creator, which creates an object of `Scene`. Factory decides which object to create based on input from `SceneEnum`.
* `EndScene`, `WelcomeScene` derive from `Scene` abstract class and they represent the objects that are created by the factory method.