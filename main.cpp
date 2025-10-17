#include <iostream>
#include "header2.h"
using namespace std;

int main()
{
    Matrix m1 = Matrix(3,3);
    Matrix m2 = Matrix(3,3);

    m1.ToString();
    //cout<<"printed m1"<<endl;
    m2.ToString();
    //cout<<"printed m2"<<endl;

    Matrix product = m1 * m2;
    //cout<<"did math"<<endl;

    cout<<"The matrices are equal: "<<(m1==m2)<<endl;
    cout<<"The product of the two matrices are: "<<endl;
    product.ToString();
    //cout<<"printed product"<<endl;
}