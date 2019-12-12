def MissingId(n, astronauts):

    if astronauts[0] == []:
        missingIdArray = []
    else:
        tmpIdArray = [];
        missingIdArray = [];

        # Se pasa array bidimensional a unidimensional
        # tmpIdArray contendía el vector con todos los ids de los astronautas
        for i in range(0, len(astronauts)):
            for j in range(0,2):

                tmpIdArray.append(astronauts[i][j]) 
                                            

        #print("Ids existentes: ")
        #print(tmpIdArray)
        #print("\n")

        i = 0
        j = 0
        isContained = False

        # Retorna los id que no tienen pareja, es decir, los ids
        # que no están en el vector astronauts."Los Ids faltantes".
        for i in range(0, n):
            for j in range(0, len(tmpIdArray)):

                if i == tmpIdArray[j]:
                    isContained = True
                    break
                else:
                    isContained = False

            if isContained == True:
                continue
            else:
                missingIdArray.append(i) 

        #print("Los Ids faltantes son: ")
        #print (missingIdArray)

    return missingIdArray



def SameNationality(ArrayAstronautas):

    if ArrayAstronautas[0] == []:
        sameNationality = []
    else:
    
        tmpPairId = ArrayAstronautas[0]
        #print("Init tmpPairId: " + str(tmpPairId))
        tmpArrayAstronautas = ArrayAstronautas
        tmpAuxiliar = []
        tmpArray = []
        indexArray = []
        tmpPairs =[[]]

        for i in range(0, len(ArrayAstronautas)):
            
            for j in range(0, len(tmpArrayAstronautas)):
                tmpAuxiliar = tmpArrayAstronautas[j]
                
                #print("j = " + str(j) + "\ntmpAuxiliar: " + str(tmpAuxiliar))
                
                if tmpArray == []:
                    tmpArray = tmpAuxiliar;
                    indexArray.append(j)
                    #print("\ntmpArray = " + str(tmpArray) + "\nindexArray: " + str(indexArray))
                    continue
                else:

                    tmp0 = tmpAuxiliar[0]
                    tmp1 = tmpAuxiliar[1]

                    if IsContained(tmp0, tmpArray):
                        if not IsContained(tmp1, tmpArray): #Esta condicion evita agregar elementos repetidos
                            tmpArray.append(tmp1)
                            indexArray.append(j)
                            #print("\n\n**tmpArray = " + str(tmpArray) + "\n**indexArray: " + str(indexArray))
                        else:
                            continue
                    elif IsContained(tmp1, tmpArray):
                        if not IsContained(tmp0, tmpArray): #Esta condicion evita agregar elementos repetidos
                            tmpArray.append(tmp0)
                            indexArray.append(j)
                        else:
                            continue
                    else:
                        continue


            if tmpArray != []: # Se pone esto porque si se acaban los ciclos en j agrega un elemento [] al array final
                tmpPairs.append(tmpArray)
                
            #print("\n\n\ntmpPairs: " + str(tmpPairs))
            tmpArray = []

            #print("\nindexArray: " + str(indexArray))
            #print("\ntmpArrayAstronautas: " + str(tmpArrayAstronautas))
            if len(indexArray) > 0:
                for k in sorted(indexArray, reverse=True):
                    #print("k: " + str(k))
                    del(tmpArrayAstronautas[k])


            #print("\ntmpArrayAstronautas: " + str(tmpArrayAstronautas))

            indexArray = []

            sameNationality = tmpPairs
                
        del(sameNationality[0])
    
    return sameNationality
     


def TotalPairs(missingIdArray, sameNationalityArray):

    if ((missingIdArray == []) & (sameNationalityArray == [])):
        totalPairs = 0
    else:

        #print(missingIdArray)
        #print("len(missingIdArray) = " + str(len(missingIdArray)))
        totalCombinationMissing = Combinations(len(missingIdArray))
        #print("totalCombinationMissing = " + str(totalCombinationMissing)) 
        totalSameNationality = 1
        tmp = 0
        totalElements = 0
        totalPairs = 0

        if ((len(sameNationalityArray) == 1) & (missingIdArray != [])):
            totalSameNationality = len(sameNationalityArray[0])

        elif len(sameNationalityArray) > 1:
            
            for i in range(0, len(sameNationalityArray)):
                    tmp = len(sameNationalityArray[i])
                    #print("tmp = " + str(tmp))
                    totalSameNationality = totalSameNationality * tmp
                    #print("totalSameNationality = " + str(totalSameNationality))
                    totalElements += tmp
                    #print("totalElements = " + str(totalElements))
        else:
            totalSameNationality = 0

        if missingIdArray != []:
            totalMissingSame = len(missingIdArray) * totalElements
        else:
            totalMissingSame = 0

        #print("len(sameNationalityArray) = " + str(len(sameNationalityArray)))

      

        

        #if len(sameNationalityArray) <= 1:
            

        totalPairs = totalCombinationMissing + totalMissingSame + totalSameNationality  

    return totalPairs






def IsContained(k, array):

    # Verifica si un elemento esta en un array

    isContained = False

    for i in range(0, len(array)):
        if k == array[i]:
            isContained = True
            break
        else:
            continue

    return isContained
        




def Factorial (k):

    factorial = 1

    for i in range(1, k + 1):

        factorial = factorial * i
             
    return factorial


def Combinations(n):

    k1 = 2
    
    if n <= 1:
        combinations = 0
    else:
        numerator = Factorial(n)
        #print("numerator = " + str(numerator))
        denominator = k1 * (Factorial(n - k1))
        #print("denominator = " + str(denominator))
        combinations = (numerator/denominator) 

    return int (combinations) 
        
    


#Tomar el k e irle restando de 1 en uno hasta 2 (contando a 2)

    
    # Thin methood makes the factorial product of a
    # constant 
                    
                    
# https://www.sangakoo.com/es/temas/combinaciones-sin-repeticion
        

##################

#n  # Total of astronauts wich every one has a representative id from 0 to n
# p # Total of austronuot pairs 
#a =[[2,3], [2,4], [5,6], [7,8]]; n = 9; # 27
#a = [[2,3], [3,4], [5,3], [7,8]]; n = 9; # 29
#a = [[1,2], [3,4], [1,5], [3,8]]; n = 9;  # 30
#a = [[1,2], [2,3]]; n = 4; # 6
#a = [[0,1], [2,3], [0,4]]; n = 5; # 6
#a = [[4,1], [0,2]]; n = 5; # 8
#a = [[0,1],[1,2],[1,3]]; n = 4  # 0
#a = [[]]; n = 0;
#a = [[0,1]]; n = 2
#a = [[0,1],[1,2],[2,4]]; n = 5
a = [[0,1],[1,2],[3,4],[4,5]]; n = 6
#sameNationality = SameNationality(a)
#print(sameNationality)

print("a = " + str(a))

missingId = MissingId(n, a)
print("\nMissingId = " + str(missingId))

sameNationality = SameNationality(a)
print("\nSameNationality = " + str(sameNationality))

totalPairs = TotalPairs(missingId, sameNationality)
print("\nTotalPairs = " + str(totalPairs))


    
    
