#Between Two Sets

def getTotalX(a, b):
    last_a = a[len(a) - 1]
    first_b = b[0]

    array = [x for x in range(last_a, first_b + 1)]
    #print(str(array))

    numbers = 0
    aux = 0

    for i in range(0, len(array)):

        aux = 1

        for j in range(0, len(a)):
            #print(str(array[i]) + " % " + str(a[j]))
            if array[i] % a[j] != 0:
                aux = 0
            else:
                continue

        for j in range(0, len(b)):
            
            if b[j] % array[i] != 0:
                aux = 0
            else:
                continue

        if aux == 1:
            
            numbers += 1
        else:
            continue

    return numbers

    
            
        
                

    print(str(numbers))
    #print(str(array_b))




a = [2, 6]
b = [24, 36]
test = getTotalX(a, b)
print(test)
