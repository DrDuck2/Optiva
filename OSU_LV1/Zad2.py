try:
    inp = float(input("Broj od 0-1: "))
    if inp < 0 or inp > 1:
        print("Niste unijeli broj od 0-1!")
        exit()
except ValueError:
    print("Niste utipkali broj")
    exit()

if inp < 0.6: print("F")
elif 0.6 <= inp < 0.7: print("D")
elif 0.7 <= inp < 0.8: print("C")
elif 0.8 <= inp < 0.9: print("B")
elif 0.9 <= inp : print("A")

