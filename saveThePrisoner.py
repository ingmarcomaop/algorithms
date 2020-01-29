#Save the Prisoner!


#array seats va desde s hasta n (incluido n)
#se le pega al final del array lo que va de 1 hasta n (excluido n)

#si m <= n  retorna array[m - 1]
# de lo contrario retorna array [(index = m%n) - 1]

def saveThePrisoner(n, m, s):


    r = m%n

    if ((r + s - 1) % n) == 0:
        return n
    else:
        return (r + s - 1) % n
    
        

    
   






    

#n = 5; m = 5; s = 3;
n = 5; m = 2; s = 3;
#n = 5; m = 4; s = 5;


#n = 7; m = 19; s = 2;
#n = 7; m = 19; s = 3;
#n = 3; m = 7; s = 3;

#n = 5; m = 5; s = 5;
#n = 4; m = 2; s = 1;
#n = 4; m = 2; s = 4;
#n=559033664; m=822024089; s = 131746755;



test = saveThePrisoner(n, m, s)
print(test)
        
