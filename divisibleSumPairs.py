# Divisible Sum Pairs

def divisibleSumPairs(n, k, ar):

    tmp = 0
    pairs = 0
    #i = 1
    #j = i

    

    for i in range(0, len(ar)):

        tmp = ar[i]
        #print('\n')
        #print('i = ' + str(i))
        print('tmp = ' + str(tmp))

        for g in range(i+1, len(ar)):

            
            #print('g = ' + str(g))
            print('ar[g] = ' + str(ar[g]))

            #if (i+1 == len(ar)):
             #   return pairs
            if (tmp + ar[g]) % k == 0:
                pairs += 1
                #break
            else:
                continue

        
       

    return pairs

a = divisibleSumPairs(6, 5, [1,2,3,4,5,6])
#a = divisibleSumPairs(6, 3, [1,3,2,6,1,2])
print(str(a))
            

    

        
