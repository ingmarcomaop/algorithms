# Birthday Chocolate

def birthday(s, d, m):

    pos_ini = 0
    pos_fin = m
    acum = 0
    #iterator = 0
    posibilities = 0


    for i in range(0, len(s)):
        
        if(pos_fin <= len(s)):
            
            for j in range(pos_ini, pos_fin):
                acum += s[j]

            #print(str(acum))
            if(acum == d):
                posibilities += 1
        
        pos_ini += 1
        pos_fin += 1
        acum = 0
        
    return posibilities


#a = birthday([1,2,1,3,2], 3, 2)
a = birthday([1,1,1,1,1,1], 3, 2)
print(str(a))
