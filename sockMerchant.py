# Sock Merchant

def sockMerchant(n, ar):

    element = 0
    arr_aux = []
    added = False
    tmp = 0
    pairs = 0

    if n == 0:
            return pairs

    else:

        for i in range(0, n):
            element = ar[i]
            tmp = 0
            added = IsContained(element, arr_aux)

            if added:
                continue
            else:
                arr_aux.append(element)

                for j in range(0, n):
                    if element == ar[j]:
                        tmp += 1
                        if tmp % 2 == 0:
                            pairs += 1
                        else:
                            continue
                    else:
                        continue

    return pairs



def IsContained(k, array):

    # Verifica si un elemento esta en un array

    isContained = False

    for i in range(0, len(array)):
        if k == array[i]:
            isContained = True
            break
        else:
            continue

    return isContained



ar = [10,20,20,10,10,30,50,10,20]; n = 9

test =sockMerchant(n, ar)
print(test)
    
