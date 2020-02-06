# Circular Array Rotation

def circularArrayRotation(a, k, queries):
    point = k % len(a)
    array = []
    array_result = []


    for i in range(len(a) - point, len(a)):
        array.append(a[i])
 

    for i in range(0, len(a) - point):
        array.append(a[i])

    for i in queries:
        array_result.append(array[i])

    return array_result


a = [1,2,3,4,5,6,7,8]; k = 5; queries = [0,1,2]

test = circularArrayRotation(a, k, queries)
for i in test:
    print(str(i))
