# Singleton pattern

## Intent
Ensure a class only has one instance and provide a global point of access to it.

## Applicability
Use the Singleton pattern when
* there must be exactly one instance of a class and it must be accessible to clients from a well-known access point.
* when the sole instance should be extensible by subclassing and the clients should be able to use an extended instance without modifying their code.

## Collaborators
* `Singleton`. It provides an instance of itself from the `Instance` access point. This instance will be created once and will be the same for subsequent calls to this class.