import matplotlib.pyplot as plt
import numpy as np
from scipy.cluster.hierarchy import dendrogram
from sklearn.datasets import make_blobs, make_circles, make_moons
from sklearn.cluster import KMeans, AgglomerativeClustering


def generate_data(n_samples, flagc):
    # 3 grupe
    if flagc == 1:
        random_state = 365
        X,y = make_blobs(n_samples=n_samples, random_state=random_state)
    
    # 3 grupe
    elif flagc == 2:
        random_state = 148
        X,y = make_blobs(n_samples=n_samples, random_state=random_state)
        transformation = [[0.60834549, -0.63667341], [-0.40887718, 0.85253229]]
        X = np.dot(X, transformation)

    # 4 grupe 
    elif flagc == 3:
        random_state = 148
        X, y = make_blobs(n_samples=n_samples,
                        centers = 4,
                        cluster_std=np.array([1.0, 2.5, 0.5, 3.0]),
                        random_state=random_state)
    # 2 grupe
    elif flagc == 4:
        X, y = make_circles(n_samples=n_samples, factor=.5, noise=.05)
    
    # 2 grupe  
    elif flagc == 5:
        X, y = make_moons(n_samples=n_samples, noise=.05)
    
    else:
        X = []
        
    return X

# generiranje podatkovnih primjera
X = generate_data(500, 1)

# prikazi primjere u obliku dijagrama rasprsenja
plt.figure()
plt.scatter(X[:,0],X[:,1])
plt.xlabel('$x_1$')
plt.ylabel('$x_2$')
plt.title('podatkovni primjeri')
plt.show()

#Zad1.1
#U generiranim podacima može se prepoznati 3 grupe podataka ili 3 clustera

X = generate_data(500,2)
plt.figure()
plt.scatter(X[:,0],X[:,1])
plt.xlabel('$x_1$')
plt.ylabel('$x_2$')
plt.title('podatkovni primjeri')
plt.show()

X = generate_data(300,4)
plt.figure()
plt.scatter(X[:,0],X[:,1])
plt.xlabel('$x_1$')
plt.ylabel('$x_2$')
plt.title('podatkovni primjeri')
plt.show()

#Promjenom vrijednosti broja sampleova i flaga moze se primjetiti kako se broj podataka smanjuje i kako koleriraju medjusobno, odnosno kako su drugacije poslagani, u krugove ili u linije, a ne kao u
#prvom primjeru gdje su vise kao krugovi ili grupice

#Zad1.2

X = generate_data(500,1)

km = KMeans(n_clusters=3, init = 'random',n_init=5,random_state=0)

km.fit(X)

labels = km.predict(X)

colors = ['r','g','b']
centers = km.cluster_centers_
label_colors = [colors[label] for label in labels]
plt.figure()
plt.scatter(X[:,0],X[:,1], c=label_colors)
plt.scatter(centers[:,0],centers[:,1],marker='X',c='black')
plt.xlabel('$x_1$')
plt.ylabel('$x_2$')
plt.title('podatkovni primjeri')
plt.show()

km = KMeans(n_clusters=2, init = 'random', n_init=5,random_state=0)
km.fit(X)
labels = km.predict(X)

colors = ['r','g','b']
centers = km.cluster_centers_
label_colors = [colors[label] for label in labels]
plt.figure()
plt.scatter(X[:,0],X[:,1], c=label_colors)
plt.scatter(centers[:,0],centers[:,1],marker='X',c='black')
plt.xlabel('$x_1$')
plt.ylabel('$x_2$')
plt.title('podatkovni primjeri')
plt.show()

#Promjenom K vrijednosti mijenja se broj centara kod podataka, tj. podaci se razvrstaju u broj
# grupa koji je jednak broju K, ako je K onda imamo 2 centra i 2 grupe oko ta 2 centra

#Zad1.3

X = generate_data(500,2)

km = KMeans(n_clusters=3, init = 'random',n_init=5,random_state=0)

km.fit(X)

labels = km.predict(X)

colors = ['r','g','b']
centers = km.cluster_centers_
label_colors = [colors[label] for label in labels]
plt.figure()
plt.scatter(X[:,0],X[:,1], c=label_colors)
plt.scatter(centers[:,0],centers[:,1],marker='X',c='black')
plt.xlabel('$x_1$')
plt.ylabel('$x_2$')
plt.title('podatkovni primjeri')
plt.show()

X = generate_data(500,4)

km = KMeans(n_clusters=3, init = 'random',n_init=5,random_state=0)

km.fit(X)

labels = km.predict(X)

colors = ['r','g','b']
centers = km.cluster_centers_
label_colors = [colors[label] for label in labels]
plt.figure()
plt.scatter(X[:,0],X[:,1], c=label_colors)
plt.scatter(centers[:,0],centers[:,1],marker='X',c='black')
plt.xlabel('$x_1$')
plt.ylabel('$x_2$')
plt.title('podatkovni primjeri')
plt.show()

#Na grupiranim skupovima mozemo primjetiti kako podaci "blobs" su po nekoj logici
# dobro grupirani, dok podaci "circles" su krivo grupirani tj. svaki "krug" podataka 
# nije jedna skupina




