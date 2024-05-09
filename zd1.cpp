#include <iostream>
#include <math.h>
using namespace std;

void pudge(float start, float end, float step) { //

    for (float x = start; x <= end; x += step) {

        float result;
         //1
        if (x >= -4 && x <=-2) {
            result = x + 3;
            cout << x << "\t" << result << endl;
        }
        //2
        if (x > -2 && x <= 4) {
           result = -0.5 * x;
           if (result == 0) result = abs(result);
           cout << x << "\t" << result << endl;
        }
        //3
        if (x > 4 && x <= 6) {
            result = -2;
            cout << x << "\t" << result << endl;
        }

        if (x >= 6 && x <= 10) {
            result = round((1 * (sqrt(4 - (pow(x - 8, 2)))) - 2) * 100) / 100;
            cout << x << "\t" << result << endl;
        }
    }

}

int main() {
    setlocale(LC_ALL, "Rus");

    float xstart, xend, step;
    cout << "Введите начальный x: ";
    cin >> xstart;
    cout << "Введите конечный x: ";
    cin >> xend;
    cout << "Введите шаг: ";
    cin >> step;

    cout << "X\t" << "Y\n";
    pudge(xstart, xend, step);

    return 0;
}
