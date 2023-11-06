Flyweight
The intent of this pattern is to use sharing to support large number of
fine-grained objects efficiently. It does that by sharing parts of the state
between these objects instead of keeping all that state in all of the
objects.



Considerations Before Choosing the Flyweight
Pattern
Does the application use a large number of objects?
Are storage costs high because of the large amount of objects?
Can most of the object state be made extrinsic?
If you remove extrinsic state, can a large group of objects be
replaced by relatively few shared objects?
Does the application require object identity?


Use Cases for the Flyweight Pattern
When the application use a large number of objects
When storage costs are high because of the large amount of objects
When most of the object state be made extrinsic
When, if you remove extrinsic state, a large group of objects be
replaced by relatively few shared objects
When the application does not require object identity