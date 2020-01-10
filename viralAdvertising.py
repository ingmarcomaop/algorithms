# Viral Advertising

def viralAdvertising(n):

    shared_x = [5]
    liked_x = []
    cumulative = 0

    for i in range(n):
        shared_x.append(3*int(shared_x[i]/2))
        liked_x.append(int(shared_x[i]/2))
        cumulative += liked_x[i] 

    return cumulative
  
    

#n = 5
n = 3

test = viralAdvertising(n)
print(test)
