import math

def gradingStudents(grades):

    for i in range(0, len(grades)):
        if (grades[i] >= 38):
            if (abs((grades[i] - math.ceil(grades[i]/5) * 5)) < 3):
                grades[i] = math.ceil(grades[i]/5) * 5
            else:
                continue
        else:
            continue
            
    return grades

    
print(gradingStudents([73, 67, 38, 33]))
