# Overview

The primary purpose of this repository is to explore and implement a variety of design patterns using C#. Through this project, I aim to deepen my understanding of these patterns and their practical applications in software development. I hope to illustrate their benefits, improve my programming skills, and provide a valuable resource for others interested in C# design patterns. 

## Singleton
"Singleton is a creational design pattern that lets you ensure that a class has only one instance" [1]
#### Important
"The pattern requires special treatment in a multithreaded environment so that multiple threads won’t create a singleton object several times" [1,2].

In a multi-threaded environment, multiple threads can execute code simultaneously. When implementing a Singleton, the goal is to ensure that only one instance of the class is created.  
#### Example:
Thread A and Thread B both check if the Singleton instance is null at the same time. Both threads find that the instance is null and proceed to create a new instance and therefore two instances are created, violating the Singleton principle.
#### So...

To prevent this, synchronization mechanisms like locks are used to ensure that only one thread can execute the critical section of code at a time.

### Resources used:
[1] [refactoring.guru](https://refactoring.guru/design-patterns/singleton)  
[2] [Inspiration and Guidance for the Code](https://www.youtube.com/watch?v=r6Y0SmbufmU)


## Builder
"Builder is a creational design pattern that lets you construct complex objects step by step." [1]
#### Director:
"The director (optional) class defines the order in which to execute the building steps, while the builder provides the implementation for those steps." [1]

### Resources used:
[1] [refactoring.guru](https://refactoring.guru/design-patterns/builder)  
[2] [Inspiration and Guidance for the Code](https://www.youtube.com/watch?v=MaY_MDdWkQw)


## Abstract Factory
"Abstract Factory is a creational design pattern that lets you produce families of related objects without specifying their concrete classes." [1]
#### Inspiration and Guidance for the Code [1]:  
![image](https://github.com/user-attachments/assets/216b009c-38e6-42c7-9d1b-1c1dfa6e19f1)

### Resources used:
[1] [refactoring.guru](https://refactoring.guru/design-patterns/abstract-factory)  

