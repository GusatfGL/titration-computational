
#Variables needed

width = 10
height = 10
data = [[int for i in range(width)] for j in range(10)]


# Functions needed

def PrintBoard():
    for y in range(height):
        for x in range(width):
            if data[x][y] ==1:
                print("1", end='')
            if data[x][y] == 0:
                print("0", end='')
        print("")

def InitBoard():
    for y in range(height):
        for x in range(width):
            data[x][y] = 0;
            
def GetNeighbours(x, y):
    for i in range(1, 4):

# Main
InitBoard()
PrintBoard()

