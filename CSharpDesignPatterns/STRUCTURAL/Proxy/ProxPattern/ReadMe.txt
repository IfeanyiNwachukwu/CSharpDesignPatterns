Proxy
The intent of this pattern is to provide a surrogate or placeholder for
another object to control access to it


Subject defines the common
interface between the
RealSubject and the Proxy


RealSubject defines the real
object that the proxy presents

Proxy provides an interface
identical to the Subject. It
maintains a reference to and
controls access to the
RealSubject.


Use Cases for Proxy Pattern Variations

Remote proxy
When you want to
provide a local
representative


Protection proxy
When objects
should have
different access
rules


Virtual proxy
When you only
want to create
expensive objects
on demand


Smart proxy
When you’re in
need of a caching
or locking scenario