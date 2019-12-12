def staircase(n):
    hashtag = "#";
    tmp = ""
    array1 = []
    array2 = []
    array3 = []
    #aux = n-1

    
    for i in range(n-1):
        tmp += " "
        #print(tmp)
        array1.insert(i,tmp)

    #array1.insert(i+1,"")

    #print(str(i))

    tmp = "";

    for k in range(n):
        tmp += hashtag;
        array2.insert(k,tmp)
        #print(str(array[k]))

    aux=n-2
    tmp = "";

    print(array1)
    print(array2)
    
    for h in range(0, n-1):
        #print(str(h)+", "+str(aux))
        tmp += array1[aux] + array2[h]
        #print(tmp)
        array3.insert(h,tmp)
        tmp = ""
        aux -= 1

    array3.insert(n-1,array2[n-1]) 
    
    
    #print(array3)

    #array3.insert(n-1,array2[n-1])

    for t in range(n):
        print(array3[t])


   


a = staircase(6);
