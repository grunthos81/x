

def in_column(currNum, currCol, grid):
    for i in range(0, 9):
        if grid[i][currCol] == currNum:
            return True
    return False

def in_row(currNum, currRow, grid):
    return currNum in grid[currRow]

def in_box(cN, cR, cC, grid):
    col = cC - (cC % 3)
    row = cR - (cR % 3)
    for i in range(0,3):
        for j in range(0,3):
            if grid[i+row][j+col] == cN:
                return True
    return False

def is_safe(i, col, row, grid):
    return not in_column(i, col, grid) and not in_row(i, row, grid) and not in_box(i, row, col, grid)

def find_unassigned(grid):
    for i in range(0, 9):
        for j in range(0, 9):
            if grid[i][j] == 0:
                return [i,j]
    return False

def print_grid(grid):
    for row in grid:
        print(row)

def solve(grid):
    currPos = [0,0]
    if not find_unassigned(grid):
        return True
    else:
        currPos = find_unassigned(grid)

    for i in range(1, 10):
        if is_safe(i, currPos[1], currPos[0], grid):
            grid[currPos[0]][currPos[1]] = i
            if solve(grid): return True
            else: grid[currPos[0]][currPos[1]] = 0

    return False

total = 0
grids = []
with open ('p096.txt', 'rt') as myfile:
    for myline in myfile:
        for char in myline:
            if char in "0123456789":
               grids.append(int(char))
    
curr = 0
currGrid = []
while curr < 9*9*50:

    for i in range(0, 9):
       currGrid.append(grids[curr:curr+9])
       curr += 9
    solve(currGrid)
    total += int(str(currGrid[0][0]) + str(currGrid[0][1]) + str(currGrid[0][2]))
    currGrid = []
    
print(total)


    

    


    
