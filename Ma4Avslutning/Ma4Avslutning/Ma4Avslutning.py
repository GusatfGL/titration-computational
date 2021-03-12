## Numerisk integral på olika sätt

import numpy as np
import matplotlib.pyplot as plt
import math



def f(inp):    
    counter = 1
    list = [1, 2]
    returnvalue = 0
    for x in range(3, 2004):
        if x % 7 == 0 or x % 11 == 0:
            print(counter)
            list.append(counter)
            counter+=1
        else:
            print(x)
            list.append(counter)

    return list.index(inp)

x=np.linspace (1,200,1) #Skapa lista med x-värden
plt.plot(x,f(x))        #Plotta grafen
plt.grid()
plt.show()