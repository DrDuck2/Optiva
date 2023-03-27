import numpy as np
import matplotlib
import matplotlib.pyplot as plt

from sklearn.datasets import make_classification
from sklearn.model_selection import train_test_split
from sklearn.linear_model import LogisticRegression
from sklearn.metrics import confusion_matrix, ConfusionMatrixDisplay
from sklearn.metrics import classification_report
from sklearn.metrics import accuracy_score,precision_score,recall_score


X, y = make_classification(n_samples=200, n_features=2, n_redundant=0, n_informative=2,
                            random_state=213, n_clusters_per_class=1, class_sep=1)

# train test split
X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.2, random_state=5)

# a)
plt.scatter(X_train[:, 0], X_train[:, 1], c=y_train, cmap='plasma') #Train podaci prikazani u ravnini
plt.scatter(X_test[:, 0], X_test[:, 1], c=y_test, cmap='plasma', marker='x') #Test podaci prikazani sa 'X' markerom
#koristeni c i cmap za bojanje parametara i laksu preglednost grafa
plt.show()

# b)

LogRegression_model = LogisticRegression()
LogRegression_model.fit(X_train,y_train)

# c)

print("Koeficijenti reg. modela: ",LogRegression_model.coef_)
print("Pomak: ",LogRegression_model.intercept_)

#0o+01x1+02x2=0

theta0 = LogRegression_model.intercept_
theta1 = LogRegression_model.coef_[0][0]
theta2 = LogRegression_model.coef_[0][1]

x1 = np.linspace(-4,4,100) #jednako razmaknute vrijednosti u odredjenom  rasponu
#np.linspace(start,stop,num), vec znamo da su vrijednosti u rasponu od -4 do 4 po prijasnjem grafu
x2 = -theta0/theta2 - (theta1/theta2) * x1
#x2 odredjen po zadanoj funkciji za krivulju

plt.scatter(X_train[:,0],X_train[:,1], c=y_train,cmap='plasma')
#scatter za plotanje vrijednosti isto kao i prosli
plt.plot(x1,x2)
#plotamo x1,x2 kako bi dobili granicu odluke prikazanu na grafu
plt.show()

# d)

y_test_p = LogRegression_model.predict(X_test)
cm = confusion_matrix(y_test,y_test_p)
print("Matrica zabune: ", cm)
disp = ConfusionMatrixDisplay(cm)
disp.plot()
plt.show()

print("Class report: ",classification_report(y_test,y_test_p))
#Sve vrijednosti za tocnost, preciznost i odziv se nalaze unutar prikazane matrice classification_report

print("Accuracy: ",accuracy_score(y_test,y_test_p))
print("Precision: ",precision_score(y_test,y_test_p))
print("Odziv: ",recall_score(y_test,y_test_p))

# e)

plt.scatter(X_test[np.where(y_test_p == y_test),0],X_test[y_test_p == y_test,1],c='green',marker='o') #odabiremo samo one podatke koji su tocni ili jednaki y_test iz prvog i drugog stupca
plt.scatter(X_test[np.where(y_test_p != y_test),0],X_test[y_test_p != y_test,1],c='black',marker='x') #isto kao i prvi samo podatke koji nisu pogodjeni

plt.plot(x1,x2)
plt.show()


