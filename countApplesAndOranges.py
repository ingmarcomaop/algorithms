def countApplesAndOranges(s, t, a, b, apples, oranges):

    # house points s - t
    # tree points a - b
    # number of apples m
    # number of oranges n
    # apples: array with apples distances
    # oranges: array with oranges distances

    appleDistances = fruitsDistance(apples, a)
    orangeDistances = fruitsDistance(oranges, b)

    applesOnHouse = elementsInArray(appleDistances, s, t)
    orangesOnHouse = elementsInArray(orangeDistances, s, t)

    return [applesOnHouse, orangesOnHouse]

    
    

def elementsInArray(array, s, t):

    elements = 0
    
    for i in range(0, len(array)):
        if ((array[i] >= s) & (array[i] <= t)):
            elements += 1
            #print(str(elements))
        else:
            continue

    #print("\n")   

    return elements


def fruitsDistance(array, point):

    for i in range(0, len(array)):
        array[i] = array[i] + point
        #print(str(array[i]))

    #print("\n")

    return array

