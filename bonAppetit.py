# Bon Appétit - Bon Appetit

def bonAppetit(bill, k, b):

    b_actual = 0

    for i in range(0, len(bill)):
        if i != k:
            b_actual += bill[i]
        else:
            continue

    b_actual = b_actual/2

    if (b - b_actual) == 0:
        print("Bon Appetit")
    else:
        print(str(int(b - b_actual)))



    
bill = [2,4,6] ; k = 2; b = 6
#bill = [3,10,2,9] ; k = 1; b = 12
#bill = [3,10,2,9] ; k = 1; b = 7

test = bonAppetit(bill, k, b)

