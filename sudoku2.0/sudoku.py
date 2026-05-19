
import numpy as np

def vmatch(obj, row):
    m=0
    while(m < row):
        for x in range(0,9):
            if(obj[row][x] == obj[m][x]):
                return False
        m += 1
    return True

def wmatch(obj, row):
    l = row // 3
    mod = row % 3
    mod += 1
    a = np.zeros((3,9))
    for m in range(0,3):
        for x in range(0, 3):
            for y in range(0, 3):
                a[m][3*y+x] = obj[3*l+y][3*m+x]

    for m in range(0,3):
        for k in range(1, 3*mod):
            for n in range(0, k):
                if(a[m][n] == a[m][k]):
                    return False
    return True


def createallspos(obj):
    
    for x in range(0,9):
        for y in range(0,9):
            if obj[y][x] == 0:
                createspos(obj,x,y)

def createspos(obj, x, y):
    store = obj[y][x]
    for n in range(1,10):
        obj[y][x] = n
        if(check_h(obj, x,y) == True and check_v(obj, x,y) == True and check_w(obj, x,y) == True):
            sfield[n,y,x] = 1
    obj[y][x] = store

        
def check_h(obj, x,y):
    for m in range(0,9):
        if x == m:
            continue
        if obj[y][x] == obj[y][m]:
            return False

    return True

def check_v(obj, x,y):
    for m in range(0,9):
        if y == m:
            continue
        if obj[y][x] == obj[m][x]:
            return False

    return True

def check_w(obj, x,y):
    lx = x // 3
    ly = y // 3
    kx = x % 3
    ky = y % 3
    for m0 in range(0,3):
        for m1 in range(0,3):
            if kx == m0 and ky == m1:
                continue
            if obj[y][x] == obj[3*ly + m1][3*lx + m0]:
                return False

    return True


def findlowestfreq_row(row):

    a = np.zeros(10, dtype = np.int8)
    l = list()

    for n in range(1,10):
        for x in range(0,9):
            if(sfield[n,row,x] == 1):
                a[n] += 1
                
    for n in range(1,10):
        if a[n] == 1:
            for x in range(0,9):
                if sfield[n,row,x] == 1:
                    l.append([n,row,x])
                    return l
    for ls in range(2,10):
        for n in range(1,10):
            if a[n] == ls:
                for x in range(0,9):
                    if sfield[n,row,x] == 1:
                        l.append([n,row,x])
                return l

def findlowestfreq_col(col):

    a = np.zeros(10, dtype = np.int8)
    l = list()

    for n in range(1,10):
        for y in range(0,9):
            if(sfield[n,y,col] == 1):
                a[n] += 1
                
    for n in range(1,10):
        if a[n] == 1:
            for y in range(0,9):
                if sfield[n,y,col] == 1:
                    l.append([n,y,col])
                    return l
    for ls in range(2,10):
        for n in range(1,10):
            if a[n] == ls:
                for y in range(0,9):
                    if sfield[n,y,col] == 1:
                        l.append([n,y,col])
                return l
                
def findlowestfreq_win(win):
    xx = win % 3
    yy = win // 3
    a = np.zeros(10, dtype = np.int8)
    l = list()

    for n in range(1,10):
        for x in range(0,3):
            for y in range(0,3):
                if(sfield[n,3*yy+y,3*xx+x] == 1):
                    a[n] += 1

    for n in range(1,10):
        if a[n] == 1:
            for y in range(0,3):
                for x in range(0,3):
                    if sfield[n,3*yy+y,3*xx+x] == 1:
                        l.append([n,3*yy+y,3*xx+x])
                        return l
    
    for ls in range(2,10):
        for n in range(1,10):
            if a[n] == ls:
                for y in range(0,3):
                    for x in range(0,3):
                        if sfield[n,3*yy+y,3*xx+x] == 1:
                            l.append([n,3*yy+y,3*xx+x])
                return l

def findlowestfreq():

    a = list()
    sh_a = list([0,0,0,0,0,0,0,0,0,0])

    for m in range(0,9):
        a = findlowestfreq_row(m)
        if a != None:
            if len(a) < len(sh_a):
                sh_a = a
        a = findlowestfreq_col(m)
        if a != None:
            if len(a) < len(sh_a):
                sh_a = a
        a = findlowestfreq_win(m)
        if a != None:
            if len(a) < len(sh_a):
                sh_a = a

        if len(sh_a) == 1:
            return sh_a

    return sh_a


def existallnumbers(obj, ):

    for m in range(0,9):
        if not existallnum_row(obj, m):
            return False
        if not existallnum_col(obj, m):
            return False
        if not existallnum_win(obj, m):
            return False


    return True

def existallnum_row(obj, row):

    exist = 1

    for m in range(0,9):
        exist |= 2**obj[row][m]

    for m in range(0,9):
        for n in range(1,10):
            if sfield[n][row][m] != 0:
                exist |= 2**n

    if exist == 1023:
        return True
    return False

def existallnum_col(obj, col):
    
    exist = 1

    for m in range(0,9):
        exist |= 2**obj[m][col]

    for m in range(0,9):
        for n in range(1,10):
            if sfield[n][m][col] != 0:
                exist |= 2**n

    if exist == 1023:
        return True
    return False

def existallnum_win(obj, win):
    
    exist = 1
    xx = win % 3
    yy = win // 3
    
    for x in range(0,3):
        for y in range(0,3):
            exist |= 2**obj[3*yy+y][3*xx+x]
            
    for x in range(0,3):
        for y in range(0,3):
            for n in range(1,10):
                if sfield[n][3*yy+y][3*xx+x] != 0:
                    exist |= 2**n

    if exist == 1023:
        return True
    return False

        
def finalallnum_row(obj, row):

    exist = 0

    for m in range(0,9):
        exist |= 2**obj[row][m]
        
    if exist == 1022:
        return True
    return False

def finalallnum_col(obj, col):
    
    exist = 0

    for m in range(0,9):
        exist |= 2**obj[m][col]
        
    if exist == 1022:
        return True
    return False

def finalallnum_win(obj, win):
    
    exist = 0
    xx = win % 3
    yy = win // 3
    
    for x in range(0,3):
        for y in range(0,3):
            exist |= 2**obj[3*yy+y][3*xx+x]
            
    if exist == 1022:
        return True
    return False

def finalallnumbers(obj):

    for m in range(0,9):
        if not finalallnum_row(obj, m):
            return False
        if not finalallnum_col(obj, m):
            return False
        if not finalallnum_win(obj, m):
            return False


    return True


def assumpt_do(obj, assumpted, triplet, index):
    triplet_x = triplet[index]
    num, y, x = triplet_x
    obj[y][x] = num
    assumpted.append([num,y,x])
    
def assumpt_undo(obj, sol, assumpted, branch, movecounter):
    while True:
        branch[movecounter[0]] = [0,0]
        movecounter[0] -= 1
        if movecounter[0] < 0:
            return False
        branch[movecounter[0]][0] += 1
        _,y,x = assumpted[-1]
        assumpted.pop()
        obj[y][x] = 0
        if branch[movecounter[0]][0] != branch[movecounter[0]][1]:
            return True
        sol.pop()

    
def solveit(obj):
    global sfield
    branch = np.zeros((65,2), dtype = np.uint8)
    movecounter = list([0])
    sol = list()
    assumpted = list()

    while True:
    
        sfield = np.zeros((10,9,9),dtype = np.uint8)
        createallspos(obj)

        if not existallnumbers(obj):
            assumpt_undo(obj, sol, assumpted, branch, movecounter)
            move = sol[movecounter[0]]
        else:
            move = findlowestfreq()
            sol.append(move)
            branch[movecounter[0]][1] = len(move)

        assumpt_do(obj, assumpted, move, branch[movecounter[0]][0])
        movecounter[0] += 1

        if finalallnumbers(obj):
            return

        
def solveunique(obj):
    global sfield
    countsolutions = 0
    branch = np.zeros((65,2), dtype = np.uint8)
    movecounter = list([0])
    sol = list()
    assumpted = list()
    

    while True:
    
        sfield = np.zeros((10,9,9),dtype = np.uint8)
        createallspos(obj)

        if not existallnumbers(obj):
            if not assumpt_undo(obj, sol, assumpted, branch, movecounter):
                if countsolutions == 1:
                    return True
                else:
                    return False
            move = sol[movecounter[0]]
        else:
            move = findlowestfreq()
            sol.append(move)
            branch[movecounter[0]][1] = len(move)

        assumpt_do(obj, assumpted, move, branch[movecounter[0]][0])
        movecounter[0] += 1

        if finalallnumbers(obj):
            if countsolutions == 1:
                return False
            countsolutions += 1
            if not assumpt_undo(obj, sol, assumpted, branch, movecounter):
                return True
            move = sol[movecounter[0]]
            assumpt_do(obj, assumpted, move, branch[movecounter[0]][0])
            movecounter[0] += 1

        pass


def setlastrow():
    a = list([0,0,0,0,0,0,0,0,0])

    for x in range(0,9):
        for y in range(0,8):
            z = field[y,x]
            a[x] |= 2**z
        a[x] ^= 1022
        field[8,x] = np.log2(a[x])



#-------------------------------------------------- INITIALIZE VARIABLES -----------------------------------------------------


serie = np.array(range(9))
serie = serie + 1

field = np.zeros((9,9),dtype=np.int8)
sfield = np.zeros((10,9,9),dtype=np.int8)


#----------------------------------------------------- GENERATE DIGITS -----------------------------------------------------

print('Generating digits...')

np.random.shuffle(serie)
field[0] = serie
c0 = 1
c1 = 0
while(c0 < 8):
    np.random.shuffle(serie)
    field[c0] = serie

    if(c0 <= 2):
        if wmatch(field, c0):
            c0+=1
    elif(c0 == 3 or c0 == 6):
        if vmatch(field, c0):
            c0+=1
    else:
        if wmatch(field, c0) and vmatch(field, c0):
            c0+=1
    c1 += 1
    if c1 > 0x30000:
        c1 = 0
        c0 = 3
            
setlastrow()

print('Digits generated:')
print(field)
print('\n')

    
#----------------------------------------------------- REMOVE DIGITS -----------------------------------------------------
#'''

print('Removing digits...')

removed = list()
cluenum = 81

while cluenum > 71:
    x = int(9 * np.random.rand())
    y = int(9 * np.random.rand())
    if field[y][x] == 0:
        continue
    
    cluenum -= 1
    n = field[y][x]
    field[y][x] = 0
    removed.append([n,y,x])
  

tef = np.copy(field)
mincluenum = 0
comple = 0

while True:
    while True:
    
        x = int(9 * np.random.rand())
        y = int(9 * np.random.rand())
        while field[y][x] == 0:
            x = int(9 * np.random.rand())
            y = int(9 * np.random.rand())
    
        cluenum -= 1
        n = field[y][x]
        field[y][x] = 0
        removed.append([n,y,x])
        
        tef = np.copy(field)
        if solveunique(tef) == False:
            break

    n, y, x = removed.pop()
    field[y][x] = n
    tef = np.copy(field)
    cluenum += 1
    if cluenum == mincluenum:
        comple += 1
    else:
        mincluenum = cluenum
        comple = 0
    if comple == 8:
        break
    
print('Digits removed:')
print(field)
print('\n')

#----------------------------------------------------- SOLVE PUZZLE -----------------------------------------------------

print('Solving puzzle...')

import time
starttime = time.time()
print(time.time()-starttime)

solveit(field)

print('Puzzle solved:')
print(field)
print('\n')

print(f'Time solved: {time.time() - starttime}')


