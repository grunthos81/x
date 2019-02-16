chains = {1:1, 2:2}
for i in range(3, 1000000):
    if i in chains:
        continue
    currNum = i
    found = False
    currChain = [i]
    while not found:
        if currNum % 2 == 0:
            currNum /= 2
        else:
            currNum = (3 * currNum) + 1
        currChain.append(currNum)
        if currNum in chains:
            found = True
    for j in range(0, len(currChain)):
        chains[currChain[j]] = (len(currChain) - j - 1) + chains[currNum]
        chains[currChain[j]*2] = chains[currChain[j]] + 1
    currChain.clear()

biggestVal = 0
biggestKey = 0
for k, v in chains.items():
    if k < 1000000 and v > biggestVal:
        biggestVal = v
        biggestKey = k
print(biggestKey)
            
