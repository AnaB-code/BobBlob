assignment1: main.o impelmentation.o
	g++ main.o impelmentation.o -o assignment1

main.o:
	g++ -c main.cpp

impelmentation.o:
	g++ -c impelmentation.cpp
