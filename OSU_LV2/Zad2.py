import numpy as np
import matplotlib . pyplot as plt

filename = "data.csv"
data = np.loadtxt(filename,delimiter=',',skiprows=1)

# a)
print("Kolicina ljudi: ",data.shape[0]) #Prvi broj je kolicina redaka, drugi broj je kolicina stupaca

# b)

extracted_height = data[:,[1]]
extracted_weight = data[:,[2]]
plt.scatter(extracted_height,extracted_weight,marker='.',)
plt.xlabel("height")
plt.ylabel("weight")
plt.show()

# c)

extracted_height50 = data[::50,[1]]
extracted_weight50 = data[::50,[2]]
plt.scatter(extracted_height50,extracted_weight50,marker='.',)
plt.xlabel("height")
plt.ylabel("weight")
plt.show()

# d)

print("Minimalna visina: ",extracted_height.min())
print("Maksimalna visina: ",extracted_height.max())
print("Srednja visina: ",round(extracted_height.mean(),2))

# e)



