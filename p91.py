#for each co-ordinate point (x,y) there are exactly GCD(x,y) + 3 right
#triangles that can be made.
#The exception to this rule is where x and y are prime, x == y and x < 50/2
#In this case it's GCD(x,y) + 4

def gcd(a,b,c):
    if a%b == 0:
        return b
    return gcd(b,a%b, a%b)

total = 9

for x in range(1, 51):
    for y in range(1, 51):
        total += gcd(x,y,x%y) + 3
print(total)
