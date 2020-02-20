using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator
{
    struct demo
{
    int no;
    int n1;


};

public void showdata()
{
    Console.WriteLine("{0}\t{1}", n0, n1);
}
public static Demo operator +(demo x, demo y)
{
    demo t = new demo();
    t.no = x.no - y.no;
    t.no1 = x.no1 - y.n01;
    return t;
}
public static Demo operator -(demo x,demo y)
{
    demo t = new demo();
    t.no = x.no - y.no;
    t.no1 = x.no1 - y.n01;
    return t;
}
public static Demo operator *(demo x, demo y)
{
    demo t = new demo();
    t.no = x.no * y.no;
    t.no1 = x.no1 * y.n01;
    return t;
}
public static Demo operator /(demo x, demo y)
{
    demo t = new demo();
    t.no = x.no / y.no;
    t.no1 = x.no1 / y.n01;
    return t;
}

}



