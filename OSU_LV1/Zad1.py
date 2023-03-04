radniH_str = input("Radni sati: ")
counter = 0
for character in radniH_str:
    if ord(character) > 47 and ord(character) < 58:
        counter = counter + 1
    elif character == '.':
        counter = counter + 1
radniH = float(radniH_str[0:counter])
euraH = float(input("eura/h: "))
print("Ukupno",radniH*euraH, "eura")

# input1 string, converted to float (after taking numerical part)
# input2 string, coverted to float (instantly)
# output input1*input2