
import numpy as np
import math

def pudge(start, end, step):
    for x in np.arange(start, end+step, step):
        if x >= -4 and x <= -2:
            result = x + 3
            print(x, "\t", result) 
        elif x > -2 and x <= 4:
            result = -0.5 * x
            if result == 0:
                result = abs(result)
            print(x, "\t", result)
        elif x > 4 and x <= 6:
            result = -2
            print(x, "\t", result)
       
        elif x >= 6 and x <= 10:
            result = round((1 * (math.sqrt(4 - (pow(x - 8, 2)))) - 2) * 100) / 100
            print(x, "\t", result)


xstart = int(input("Введите начальный x: "))
xend = int(input("Введите конечный x: "))
step = float(input("Введите шаг: "))
print("X\tY")
pudge(xstart, xend, step)

