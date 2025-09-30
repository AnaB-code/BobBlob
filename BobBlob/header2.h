#ifndef header2_H
#define header2_H

#include <iostream>

class Matrix
{
    public:
    int myArray[0][0];
    int rows;
    int columns;
    Matrix(int rows, int columns);
    void ToString();
    Matrix operator*(Matrix b);
    bool operator==(Matrix x);
};

#endif