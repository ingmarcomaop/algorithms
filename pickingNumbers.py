# Picking Numbers

def pickingNumbers(a):

    a = sorted(a)

    longs = [0]
    aux_longs = 0
    num_rept = []

    num = 0
    rep = 0

    
    
    evaluated_num = []
    contained = False

    

    for i in range(0, len(a)):

        rep = 0
        num = a[i]
        contained = isContained(num, evaluated_num)

        if contained:
            continue
        else:
            evaluated_num.append(num)
            rep = timesNumber(num, a)
            num_rept.append([num, rep])

    #print(num_rept)
    #print(len(num_rept))
    #print(num_rept[4][0])

    for i in range(0, len(num_rept)):
        longs.append(num_rept[i][1])
        

    if len(num_rept) == 1:
        return num_rept[0][1]
    
    else:

        for i in range(0, len(num_rept)):
            aux_longs = 0
            
            if i == 0:
                if (num_rept[i][0] + 1) == (num_rept[i + 1][0]):
                    aux_longs = num_rept[i][1] + num_rept[i + 1][1]
                    longs.append(aux_longs)
                else:
                    #print("i0")
                    continue
                
            elif i == len(num_rept) - 1:
                if (num_rept[i][0] - 1) == (num_rept[i - 1][0]):
                    aux_longs = num_rept[i][1] + num_rept[i - 1][1]
                    longs.append(aux_longs)
                else:
                    #print("len(i)")
                    continue

            elif ((num_rept[i][0] + 1) == (num_rept[i + 1][0])):

                aux_longs = num_rept[i][1] + num_rept[i + 1][1]
                longs.append(aux_longs)
                
            elif ((num_rept[i][0] - 1) == (num_rept[i - 1][0])):

                aux_longs = num_rept[i][1] + num_rept[i - 1][1]
                longs.append(aux_longs)
                    
            else:
                #print("Hello")
                continue 


    #print(longs)
    return max(longs)
            
            

    


    
                

            


def isContained(n, array):

    # Retorna True o False si el elemento n está o no en el array 

    isContained = False

    for i in range(0, len(array)):
        if n == array[i]:
            isContained = True
            break
        else:
            continue

    return isContained

def timesNumber(n, array):

    # Retorna el número de veces que se repite n en el array

    rep = 0

    for i in range(0, len(array)):
        if n == array[i]:
            rep += 1
        else:
            continue

    return rep





########################
#a = [1,1,2,2,4,4,5,5,5]
#a = [1,1,2,2,4,4,5,5,5,6,7,7]
#a = [4,6,5,3,3,1]
#a = [1,2,2,3,1,2]
#a = [1,2,3,4,5,6]
#a = [1,2]
#a = [1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1]
a = [4, 97, 5, 97, 97, 4, 97, 4, 97, 97, 97, 97, 4, 4, 5, 5, 97, 5, 97, 99, 4, 97, 5, 97, 97, 97, 5, 5, 97, 4, 5, 97, 97, 5, 97, 4, 97, 5, 4, 4, 97, 5, 5, 5, 4, 97, 97, 4, 97, 5, 4, 4, 97, 97, 97, 5, 5, 97, 4, 97, 97, 5, 4, 97, 97, 4, 97, 97, 97, 5, 4, 4, 97, 4, 4, 97, 5, 97, 97, 97, 97, 4, 97, 5, 97, 5, 4, 97, 4, 5, 97, 97, 5, 97, 5, 97, 5, 97, 97, 97]


test = pickingNumbers(a)
print(test)






########################






    
