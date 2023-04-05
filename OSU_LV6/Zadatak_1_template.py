import pandas as pd
import numpy as np
import matplotlib.pyplot as plt
from matplotlib.colors import ListedColormap

from sklearn.linear_model import LogisticRegression
from sklearn.neighbors import KNeighborsClassifier
from sklearn import svm

from sklearn.metrics import accuracy_score
from sklearn.model_selection import train_test_split
from sklearn.preprocessing import StandardScaler
from sklearn.pipeline import Pipeline
from sklearn.pipeline import make_pipeline
from sklearn.model_selection import GridSearchCV

def plot_decision_regions(X, y, classifier, resolution=0.02):
    plt.figure()
    # setup marker generator and color map
    markers = ('s', 'x', 'o', '^', 'v')
    colors = ('red', 'blue', 'lightgreen', 'gray', 'cyan')
    cmap = ListedColormap(colors[:len(np.unique(y))])
    
    # plot the decision surface
    x1_min, x1_max = X[:, 0].min() - 1, X[:, 0].max() + 1
    x2_min, x2_max = X[:, 1].min() - 1, X[:, 1].max() + 1
    xx1, xx2 = np.meshgrid(np.arange(x1_min, x1_max, resolution),
    np.arange(x2_min, x2_max, resolution))
    Z = classifier.predict(np.array([xx1.ravel(), xx2.ravel()]).T)
    Z = Z.reshape(xx1.shape)
    plt.contourf(xx1, xx2, Z, alpha=0.3, cmap=cmap)
    plt.xlim(xx1.min(), xx1.max())
    plt.ylim(xx2.min(), xx2.max())
    
    # plot class examples
    for idx, cl in enumerate(np.unique(y)):
        plt.scatter(x=X[y == cl, 0],
                    y=X[y == cl, 1],
                    alpha=0.8,
                    c=colors[idx],
                    marker=markers[idx],
                    label=cl)


# ucitaj podatke
data = pd.read_csv("Social_Network_Ads.csv")
print(data.info())

data.hist()
plt.show()

# dataframe u numpy
X = data[["Age","EstimatedSalary"]].to_numpy()
y = data["Purchased"].to_numpy()

# podijeli podatke u omjeru 80-20%
X_train, X_test, y_train, y_test = train_test_split(X, y, test_size = 0.2, stratify=y, random_state = 10)

# skaliraj ulazne velicine
sc = StandardScaler()
X_train_n = sc.fit_transform(X_train)
X_test_n = sc.transform((X_test))

# Model logisticke regresije
LogReg_model = LogisticRegression(penalty=None) 
LogReg_model.fit(X_train_n, y_train)

# Evaluacija modela logisticke regresije
y_train_p = LogReg_model.predict(X_train_n)
y_test_p = LogReg_model.predict(X_test_n)

print("Logisticka regresija: ")
print("Tocnost train: " + "{:0.3f}".format((accuracy_score(y_train, y_train_p))))
print("Tocnost test: " + "{:0.3f}".format((accuracy_score(y_test, y_test_p))))

# granica odluke pomocu logisticke regresije
plot_decision_regions(X_train_n, y_train, classifier=LogReg_model)
plt.xlabel('x_1')
plt.ylabel('x_2')
plt.legend(loc='upper left')
plt.title("Tocnost: " + "{:0.3f}".format((accuracy_score(y_train, y_train_p))))
plt.tight_layout()
plt.show()

#zad 1
KNN_model = KNeighborsClassifier(n_neighbors=5)
KNN_model.fit(X_train,y_train)

y_train_p_KNN = KNN_model.predict(X_train)
y_test_p_KNN = KNN_model.predict(X_test)
train_accuracy = accuracy_score(y_train,y_train_p_KNN)
test_accuracy = accuracy_score(y_test,y_test_p_KNN)
print("Tocnost na skupu za ucenje: {:.2f}".format(train_accuracy))
print("Tocnost na skupu za testiranje: {:.2f}".format(test_accuracy))

#Usporedjivanjem s parametrima logisticke regresije uocljivo je kako je tocnost train skupa veca nego kod logisticke regresije
# ali je tocnost na skupu za testiranje za 10% manja nego kod logisticke regresije

#zad1-2
#Kada je K=1 Tocnost na skupu za ucenje je 0.99 ili 99% dok je tocnost na skupu za testiranje 84% sto je vece nego kada je K = 5
# Za K = 100, tocnost na skupu za ucenje je 75% sto je isto i za skup za testiranje

#zad2

param_range = range(1,101) #range od K(1-100)
param_grid = {'n_neighbors':param_range}

knn = KNeighborsClassifier() #model bez K vrijednosti

grid_search = GridSearchCV(estimator = knn, param_grid = param_grid, cv = 5,scoring='accuracy')
grid_search.fit(X_train, y_train)

print("Optimalna vrijednost K: ", grid_search.best_params_['n_neighbors']) #Dobije se optimalna vrijednost 31
print("Tocnost vrijednosti: ",grid_search.best_score_) #Tocnost vrijednosti je oko 80%

#Zad3

SVM_model = svm.SVC(kernel='rbf',gamma = 1, C=0.1)
SVM_model.fit(X_train_n,y_train)
plot_decision_regions(X_train_n,y_train,classifier=SVM_model)
plt.xlabel('x_1')
plt.ylabel('x_2')
plt.legend(loc='upper left')
plt.tight_layout()
plt.show()

kernel_range = ['rbf','poly','sigmoid']
gamma_range = [0.1,0.5,1]
C_range = [0.1,1,0.3]

for i in range(3):
    new_SVM_model = svm.SVC(kernel=kernel_range[i],gamma = gamma_range[i],C=C_range[i])
    new_SVM_model.fit(X_train_n,y_train)
    plot_decision_regions(X_train_n,y_train,classifier=new_SVM_model)
plt.show()

# mijenjanjem parametara C i gamma i gamma mijenja se izgled granice odluke, mijenjanjem kernela se mijenja oblik
# granice odluke, a mijenjanjem C i gamma se mijenja pogreška granice odluke ili accuracy

#Zad 4

param_grid = {'C':[10,100,100], 'gamma':[10,1,0.1,0.01]}
model_svm = svm.SVC(kernel='rbf')
svm_gscv = GridSearchCV(estimator = model_svm,param_grid=param_grid,cv=5,scoring='accuracy')
svm_gscv.fit(X_train, y_train)
print("Najbolji parametri: ",svm_gscv.best_params_)