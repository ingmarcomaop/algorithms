# Counting Valleys

def countingValleys(n, s):

    nivel = 0
    arr_levels = [nivel]
    valleys = 0
        
    for i in range(0, n):
        
        if s[i] == "U":
            nivel += 1
            arr_levels.append(nivel)
        else:
            nivel -= 1
            arr_levels.append(nivel)

    for j in range(1, len(arr_levels)):

        if (arr_levels[j] == 0 and arr_levels[j-1] < 0):
            valleys += 1
        else:
            continue

    return valleys


n = 8; s = ['U','D','D','D','U','D','U','U']

test = countingValleys(n, s)
print(test)
