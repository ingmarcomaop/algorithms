# Migratory Birds

def migratoryBirds(arr):

    number = 0
    num_arr = [0, 0, 0, 0, 0]

    for i in range(0, len(arr)):

        if arr[i] == 1:
            num_arr[0] += 1
        elif arr[i] == 2:
            num_arr[1] += 1
        elif arr[i] == 3:
            num_arr[2] += 1
        elif arr[i] == 4:
            num_arr[3] += 1
        else:
            num_arr[4] += 1

    #print(num_arr)
    max_ = max(num_arr)

    for i in range(0, len(num_arr)):
        if max_ == num_arr[i]:
            number = i + 1
            break
        else:
            continue

    return number


        
arr = [1,1,2,2,3]
#arr = [1, 4, 4, 4, 5, 3]
#arr = [1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4]
a = migratoryBirds(arr)
print(a)
