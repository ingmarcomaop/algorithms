# Electronics Shop

def getMoneySpent(keyboards, drives, b):

    combinations = []
    tmp = 0

    for i in range(0, len(keyboards)):
        for j in range(0, len(drives)):
            tmp = keyboards[i] + drives[j]

            if tmp > b:
                continue
            else:
                combinations.append(tmp)

    if len(combinations) == 0:
        return -1
    else:
        return max(combinations)


#keyboards = [3,1]; drives = [5,2,8]; b = 10
keyboards = [4]; drives = [5]; b = 5


test = getMoneySpent(keyboards, drives, b)
print(test)


    

    
    
