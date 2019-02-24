import math

def getm(a,b,k,n):
    x = b - (a%b)
    hiT = math.ceil((abs(k)-x)/abs(k))
    loT = math.floor((abs(k)-x)/abs(k))
    hiM = (abs(k)*hiT)+x
    loM = (abs(k)*loT)+x
    print(hiM, loM)
    if abs(hiM**2 - n) <= abs(loM**2 - n):
        return loM
    else:
        return hiM

def chak(a, b, n):
    #set k
    k = int(a**2) -(n*b)
    while k != -1 or k != 1:
        print(a,b,k)
        m = getm(a,b,k,n)
        newa = abs(((a*m)+(n*b))/k)
        newb = abs((a+(b*m))/k)
        newk = (int(m**2)-n)/k
        a = newa
        b = newb
        k = newk
    if k == 1: return a
    else:
        return ((a**2 + n*(b**2))/k)**2

biggestN = 0
biggesta = 0

for i in range(53,54):
    if isinstance(math.sqrt(i), int): continue
    a = math.floor(math.sqrt(i))
    b = 1
    current = chak(a,b,i)
    print(a,b,i,current)
    if current > biggesta:
        biggesta = current
        biggestN = i

print(biggestN)
