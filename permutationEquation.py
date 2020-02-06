# Sequence Equation

def permutationEquation(p):

    sortedArray = []
    pArray = []
    y = []
    
    
    for i in range(0, len(p)):
        sortedArray.append(i + 1)

    for i in range(0, len(sortedArray)):
        for j in range(0, len(p)):
            if sortedArray[i] == p[j]:
                pArray.append(j + 1);
            else:
                continue

    for i in range(0, len(pArray)):
        for j in range(0, len(p)):
            if pArray[i] == p[j]:
                y.append(j + 1);
            else:
                continue

    return y


#p = [4,3,5,1,2]
#p = [2,3,1]
p = [5,2,1,3,4]
test  = permutationEquation(p);
print(test)
        

    
