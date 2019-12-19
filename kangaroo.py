def kangaroo(x1, v1, x2, v2):

    zeros_a = []
    zeros_b = []

    for k in range(0, 10000):
        zeros_a.insert(k,0)
        zeros_b.insert(k,0)
    
    zeros_a[0] = x1
    zeros_b[0] = x2

    #for h in range(0, 20):
        #print(str(zeros_a[h]) + " - " + str(zeros_b[h]))

    result = "NO"

    for i in range(1,10000):
        
        zeros_a[i] = zeros_a[i - 1] + v1
        #tmp1 += v1  
        
        zeros_b[i] = zeros_b[i - 1] + v2
        #tmp2 += v2

    #for h in range(0, 20):
        #print(str(zeros_a[h]) + " - " + str(zeros_b[h]))
        

    for j in range (0, 10000):
        if zeros_a[j] == zeros_b[j]:
            result = "YES"
            break
        else:
            continue

    print(result)
