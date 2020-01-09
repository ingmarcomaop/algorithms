# Beautiful Days at the Movies

def beautifulDays(i, j, k):
      
    #days_str = ""
    array_days_str = ""
    days_inv_str = ""
    beautiful = 0
    #days_inv_str_fin = []
    num_inv_str = ""
    aux = 0
    

    for m in range(i, j + 1):
        array_days_str = str(m)

        #print(array_days_str)

        days_inv_str = inverted_str(array_days_str)
            
        #print(days_inv_str)
        #print("len " + str(len(days_inv_str)))

        aux = delet_zeros(days_inv_str)
        #print(aux)

        num_inv_str = ready_numbers(aux, days_inv_str)
    
        #print(num_inv_str)

        num_inv_int = int(num_inv_str)
        #print(num_inv_int)
        #print(m)
        #print(str(m) + " - " + str(num_inv_int) + " = " + str(abs(m - num_inv_int)))
        
        if abs((m - num_inv_int)) % k == 0:
            beautiful += 1
        else:
            continue
    
        #days_str = ""
        #array_days_str = ""
        #days_inv_str = ""
        #num_inv_str = ""

        

    return beautiful


def inverted_str(array):
    aux = len(array)
    days_inv_str=""
    while(aux > 0):
        days_inv_str += array[aux - 1]
        #print(days_inv_str)
        aux -= 1

    return days_inv_str

def delet_zeros(array):

    aux = 0
    for i in range(len(array)):
        if array[i] == '0':
            #print(array[i])
            continue
        else:
            aux = i
            break

    return aux

def ready_numbers(pos_ini, array):

    num_inv_str = ""
    for j in range(pos_ini, len(array)):
        #days_inv_str_fin.append(days_inv_str[j])
        num_inv_str += array[j]

    return num_inv_str


#i = 20; j = 23; k = 6;
i = 13; j = 45; k = 3;
#i = 200; j = 250; k = 5;
test = beautifulDays(i, j, k)
print(test)
        

    
