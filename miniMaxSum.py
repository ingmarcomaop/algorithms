def miniMaxSum(arr):
    
    arr = sorted(arr)
    min_sum = 0
    max_sum = 0

    for i in range(len(arr)-1):
        min_sum += arr[i]

    for i in range(1,len(arr)):
        print("max_sum += "+"arr["+str(i)+"] = "+str(arr[i]))
        max_sum += arr[i]
        print(str(max_sum))

    print(str(min_sum))
    print(str(max_sum))

r = miniMaxSum([7, 69, 2, 221, 8974])
#print("Resultado = " + str(r))
