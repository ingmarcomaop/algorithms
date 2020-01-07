# Designer PDF Viewer

def designerPdfViewer(h, word):

    map_word = []

    letters = ['a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z']

    for i in range(0, len(h)):
        map_word.append([letters[i], h[i]])

    #print(map_word)

    tmp = ""
    aux = []
    for i in range(0, len(word)):
        tmp = word[i]
        for j in range(0, len(map_word)):
            if tmp == map_word[j] [0]:
                aux.append(map_word[j][1])
            else:
                continue
    max_aux = max(aux)

    return (max_aux * len(word))


h = [1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7]; word = "zaba";

test = designerPdfViewer(h, word)
print(test)
