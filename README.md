## General
This is an open source library which was created by the ABBYY vantage team. While working on our new amazing project which will definitely change the world, we came to conclusion that we have to share with the community one of our internal library. It consists of interesting helper methods which will come in handy in the majority of day-to-day projects. 

### How to use
Firstly get the sources:

    git clone https://github.com/megahoneybadger/abbyy.git
    cd abbyy

Secondly build the sources server and client (you will need .net core v5):

    make rebuild
    
To run the unit tests:

    make test

To run the sandbox:

    make run
        

### Method Details
Unfortunately our team is very busy right now and we managed to implement only two methods:

 - reverse of a linked list
 - search of missing numbers in an interval

Here is how you can play around with those functions:

***Reverse a linked list***

Enter *reverse* command and numbers separated by space

    make run
    > reverse 1 2 3 4 5
		
![alt text](https://github.com/megahoneybadger/abbyy/blob/media/abbyy2.png)

***Find missing numbers***

Enter *missing* command and numbers separated by space

    make run
    > missing 1 2 3 5

![alt text](https://github.com/megahoneybadger/abbyy/blob/media/abbyy1.png)