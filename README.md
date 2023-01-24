# renyong0102-cs5097-Spring2023--Renyong-
To calculate intervening points you can simply calculate the translation vector and divide by 10 and add this to the initial start position and so on. But what if the loop iterates indefinitely and the input is a direction vector (a vector that simply shows the direction the object is moving)? How would you calculate the intermediate positions if you don't know the destination (or even how long the object will travel)?

Answer: The solution could be to use the direction vector to calculate a set of intermediate positions for a set period of time, and then update the positions as needed based on the current time and the direction vector.


You can use simple arrays to do this problem, but you can also use a vector math library (which was optional), why or why not did you use a library?

not using a library means that you have more control over the implementation of the algorithms and it can be useful if you have a high performance requirements or if you have specific requirements that are not covered by the library.
It depends on the requirements of the specific problem and the development environment.
