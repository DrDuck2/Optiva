filename = "song.txt"
rjecnik = {}

def PrintNonRepeated():
    count = 0
    for value in rjecnik:
        if rjecnik[value] == 1:
            count += 1
            print(value)
    print("Broj rijeci koji se ne ponavljaju: ",count)

with open(filename,'r') as file:
    for line in file:
        for word in line.split():
            if word not in rjecnik:
                rjecnik[word] = 1
            else:
                rjecnik[word] += 1
file.close
PrintNonRepeated()


