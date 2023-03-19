import statistics

def BubbleSort(lst):
    for i in range(0,len(lst)):
        for j in range(0,len(lst)):
            if lst[i] < lst[j] :
                num = lst[j]
                lst[j] = lst[i]
                lst[i] = num

lst = []
while True:
    inp_str = input("Unesite neki broj: ")
    if inp_str == "Done":
        break
    else:
        try:
            val = float(inp_str)
            lst.append(val)
        except ValueError:
            print("Niste unijeli broj!")

print("Kolicina brojeva: ",len(lst))
print("Srednja vrijednost: ",statistics.mean(lst))
print("Minimalna vrijedost: ",min(lst))
print("Maximalna vrijednost: ",max(lst))

BubbleSort(lst)

print("Vrijednosti liste sortirano: ")
for number in lst:
    print(number)
