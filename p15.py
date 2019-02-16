pascal = [[1]]
for i in range (0, 41):
    newList = []
    for j in range(0, i+1):
        if j == 0 or j == i: newList.append(1)
        else:
            newList.append(pascal[i][j-1] + pascal[i][j])
    pascal.append(newList)

print(pascal[41][20])
