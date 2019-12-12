def diagonalDifference(n,arr):
   
    diagonalP=0;
    diagonalS=0;

    #n=3;

    for i in range(0, n):
        for j in range(0, n):
            if (i == j):
                #print("i,j = " + str(i) + "," + str(j))
                diagonalP += arr[i][j];
                #print("diagonalP = " + str(diagonalP))
            else:
                continue

    #print(diagonalP)

    aux = n -1;
    tmp = aux;

    while(aux != -1):

        diagonalS += arr[aux][tmp - aux]
        print("arr["+str(aux)+"]["+str(tmp)+" - "+str(aux)+"] = " + str(arr[aux][tmp - aux]))
        aux -= 1
    
    
    result = abs(diagonalP - diagonalS);

    return result;


#arr=[[11,2,4],[4,5,6],[10,8,-12]]
#arr=[[1,2],[3,4]]
arr=[[1,2,3],[4,5,6],[9,8,9]];

n = 3; 

c = diagonalDifference(n, arr)
print("Output = " + str(c))

