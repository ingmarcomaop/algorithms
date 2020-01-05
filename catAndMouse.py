# Cats and a Mouse

def catAndMouse(x, y, z):

    a = abs(x - z)
    b = abs(y - z)

    if a == b:
        return "Mouse C"
    elif a < b:
        return "Cat A"
    else:
        return "Cat B"


#x = 1; y = 2; z = 3;
x = 1; y = 3; z = 2;

test = catAndMouse(x, y, z)
print(test)



        


    

    
    
