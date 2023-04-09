import numpy as np
import matplotlib.pyplot as plt
import matplotlib.image as Image
from sklearn.cluster import KMeans

# ucitaj sliku
img = Image.imread("imgs\\test_1.jpg")

# prikazi originalnu sliku
plt.figure()
plt.title("Originalna slika")
plt.imshow(img)
plt.tight_layout()
plt.show()

# pretvori vrijednosti elemenata slike u raspon 0 do 1
img = img.astype(np.float64) / 255

# transfromiraj sliku u 2D numpy polje (jedan red su RGB komponente elementa slike)
w,h,d = img.shape
img_array = np.reshape(img, (w*h, d))

# rezultatna slika
img_array_aprox = img_array.copy()

#Zad 1
unique_colors = len(np.unique(img_array, axis = 0))
print("Number of unique colors: ",unique_colors)

#Zad 2,3,4

#Primjena algoritma K srednjih vrijednosti, gdje grupira u 3 grupe R,G,B
km = KMeans(n_clusters=3, init = 'random',n_init=5,random_state=0) 
km.fit(img_array)
labels = km.predict(img_array) #odredjivanje centara

img_array_aprox = km.cluster_centers_[labels]
rez_img = np.reshape(img_array_aprox,(w,h,d))

#prikaz slike
plt.figure()
plt.title("Rezultantna slika")
plt.imshow(rez_img)
plt.tight_layout()
plt.show()

# promjenom vrijednosti K mijenja se i izgled rezultantne slike, ako postavimo da je K = 5
# dobijemo malo izostreniju sliku, tj vise ne izgleda kao da je naslikana sa samo nekoliko boja
# povecanjem K na 7 pocinjemo dobijati dijelove koji su zasivljeni, tj sive pixele na mjestima na kojima nebi
# trebale biti

#Zad 5 se nalazi na kraju!
#Zad 6

inertias = [] #varijabla u koju spremamo vrijednosti inertia
K_range = range(1,11) # od 1 do 10 vrijednosti za K
for K in K_range: #petlja u kojoj mijenjamo vrijednost K za KMeans
    km = KMeans(n_clusters=K, init = 'random',n_init=5,random_state=0) 
    km.fit(img_array)
    inertias.append(km.inertia_) #appendamo vrijednost km.inertia_ u inertia

plt.plot(K_range,inertias) #prikazemo ovisnost od K i inertia
plt.xlabel('Number of clusters')
plt.ylabel('Inertia')
plt.title('Inertia vs Number of clusters')
plt.show()

# po grafu je vidljivo kako je najbolji K = 4 jer je tamo nagli pad vrijednosti

#Zad 7 potrebno je prikazati elemente jedne grupe kao zasebnu binarnu sliku

labels_0 = labels == 0 # indexi elemenata koji su grupirani u grupu 0
labels_1 = labels == 1
labels_2 = labels == 2

binary_img_0 = np.zeros((w,h), dtype=np.uint8) # matrica ispunjena nulama velicine (w,h) isto kao i originalna slika
binary_img_1 = np.zeros((w,h), dtype=np.uint8) 
binary_img_2 = np.zeros((w,h), dtype=np.uint8) 

binary_img_0[labels_0.reshape(w,h)] = 1 # na odredjenim indexima vrijednost se postavlja na 1 (labels_0 se pretvara u 2D numpy polje)
binary_img_1[labels_1.reshape(w,h)] = 1 
binary_img_2[labels_2.reshape(w,h)] = 1 

# prikazujemo tri binarne slike
plt.figure(figsize=(8, 3))
plt.subplot(131)
plt.title("Grupa 1")
plt.imshow(binary_img_0, cmap='gray')
plt.subplot(132)
plt.title("Grupa 2")
plt.imshow(binary_img_1, cmap='gray')
plt.subplot(133)
plt.title("Grupa 3")
plt.imshow(binary_img_2, cmap='gray')
plt.tight_layout()
plt.show()

#Po slikama mozemo primjetiti kako su elementi grupirani po bojama, tj. svaki elementi koji pripada istoj grupi je obojan crnom bojom, dok su ostali elementi bijele boje
# i tako za sve 3 slike


#ZAD 5

def KMeansImage(imagename,K):
    img = Image.imread(imagename)
    plt.figure()
    plt.title("Originalna slika")
    plt.imshow(img)
    plt.tight_layout()
    plt.show()
    img = img.astype(np.float64) / 255
    w,h,d = img.shape
    img_array = np.reshape(img, (w*h, d))
    img_array_aprox = img_array.copy()
    unique_colors = len(np.unique(img_array, axis = 0))
    print("Number of unique colors: ",unique_colors)
    km = KMeans(n_clusters=K, init = 'random',n_init=5,random_state=0) 
    km.fit(img_array)
    labels = km.predict(img_array)
    img_array_aprox = km.cluster_centers_[labels]
    rez_img = np.reshape(img_array_aprox,(w,h,d))
    plt.figure()
    plt.title("Rezultantna slika")
    plt.imshow(rez_img)
    plt.tight_layout()
    plt.show()
        
KMeansImage("imgs\\test_2.jpg",3)
KMeansImage("imgs\\test_3.jpg",3)
KMeansImage("imgs\\test_4.jpg",3)
KMeansImage("imgs\\test_5.jpg",3)
KMeansImage("imgs\\test_6.jpg",3)

