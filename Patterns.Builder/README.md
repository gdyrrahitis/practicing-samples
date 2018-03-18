# Builder pattern

## Intent
Separate the construction of a complex object from its representation, so that the same construction process can create different representations.

## Applicability
Use the Builder pattern when
* the algorithm for creating a complex object should be independent of the parts that make up the object and how they are assembled.
* The construction process must allow different representations for the object that is constructed.

## Collaborators
* `Skynet`. This is the director object, it constructs a `Cyborg` based on its representation
* `CyborgBuilder`. This is the builder object that constructs and assembles part of a `Cyborg` object by implementing the `ICyborgBuilder` interface. It defines and keeps track of the representation it creates and it provides an interface which returns the constructed object.
* `Part`. It defines an abstract representation of the part that make the object in question, which is the `Cyborg` object. A `Cyborg` consists of multiple parts. These are to name a few, `ArmoredPart`, `ArmoredTorso`, `FlameThrower`, `Arms`, `Head`, `Legs`, `Torso`. `WeaponPart` is a special type of `Part` that defines weapons as part of the `Cyborg` object.
* `Cyborg` is an abstract class that defines a cyborg.
* `FriendlyCyborg`, `TerminatorCyborg` represent the complex object under construction.