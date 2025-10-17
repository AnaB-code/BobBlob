#include "header2.h"
#include <iostream>
using namespace std;

Matrix::Matrix(int r, int cl)
{
    rows = r;
    columns = cl;
    //cout<<"rows: "<<rows<<", columns: "<<columns<<endl;
    myArray[r][cl];

    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < cl; j++)
        {
            myArray[i][j] = rand()%10;
            //cout<<"entered value "<<myArray[i][j]<<" at "<<i<<","<<j<<endl;
        }
    }
}

void Matrix::ToString()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            cout<<myArray[i][j]<<"  ";
        }
        cout<<endl;
    }
    cout<<endl;
}

Matrix Matrix::operator*(Matrix b)
{
    Matrix temp(this->rows, b.columns);

    for (int i = 0; i < this->rows; i++)
    {
        for (int j = 0; j < b.columns; j++)
        {
            temp.myArray[i][j] = 0;

            for (int k = 0; k < b.rows; k++)
            {
                temp.myArray[i][j] += this->myArray[i][k] + b.myArray[k][j];
            }
        }
    }

    return temp;
}

bool Matrix::operator==(Matrix x)
{
    if (this->rows == x.rows & this->columns == x.columns)
    {
        for (int i = 0; i < rows+1; i++)
        {
            for (int j = 0; j < columns+1; j++)
            {
                if (this->myArray[i][j] != x.myArray[i][j])
                {
                    return false;
                }
            }
        }
        return true;
    }
    else
    {
        return false;
    }
}