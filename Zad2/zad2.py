import pandas as pd
import numpy as np
import matplotlib.pyplot as plt
from matplotlib.colors import ListedColormap
from sklearn.linear_model import LogisticRegression
from sklearn.neighbors import KNeighborsClassifier
from sklearn import svm
from sklearn.compose import ColumnTransformer
from sklearn.metrics import accuracy_score
from sklearn.model_selection import train_test_split
from sklearn.preprocessing import StandardScaler, MinMaxScaler
from sklearn.pipeline import Pipeline
from sklearn.pipeline import make_pipeline
from sklearn.model_selection import GridSearchCV
from sklearn.metrics import confusion_matrix, ConfusionMatrixDisplay
from tensorflow import keras
from tensorflow.keras import layers
from tensorflow.keras.datasets import cifar10
from tensorflow.keras.utils import to_categorical

data = pd.read_csv('titanic.csv')
print(data.info()) #Dobijemo informacije o datasetu
print("Količina osoba:",data.shape[0]) #Ili samo pogledamo koliko redaka imamo i na toliko ljudi
print("Količina preživjelih:",len(data[data['Survived'] == 1]))

survived_gender = data.groupby(['Survived','Sex']).size().unstack()
total_survived = survived_gender.sum()

percent_survived = survived_gender.div(total_survived,axis=1) * 100
ax = percent_survived.plot(kind='bar', stacked=False, figsize=(8, 6))

ax.set_xlabel('Preživjeli')
ax.set_ylabel('Postotak')
ax.set_title('Postotak preživjelih muškaraca i žena na Titanicu')

plt.show()
print("Prosjecna dob preživjelih žena: ",round((data['Age'].where((data['Survived'] == 1) & (data['Sex']=='female'))).mean(),2))
print("Prosjecna dob preživjelih muškaraca: ",round((data['Age'].where((data['Survived'] == 1) & (data['Sex']=='male'))).mean(),2))

survived = data[data['Survived']==1]
youngest_male = survived[survived['Sex'] == 'male'].groupby('Pclass')['Age'].min()
print("Najmlađi preživjeli muškarci po klasama:",youngest_male)

X = data[['Pclass', 'Sex', 'Fare', 'Embarked']].copy()
y = data['Survived'].copy()

X.dropna(inplace=True)
y = y[X.index]

X = pd.get_dummies(X, columns=['Sex', 'Embarked'])

X_train, X_test, y_train, y_test = train_test_split(X, y, test_size = 0.4, stratify=y, random_state = 10)

sc = StandardScaler()
X_train_n = sc.fit_transform(X_train)
X_test_n = sc.transform((X_test))

knn = KNeighborsClassifier(n_neighbors=5)
knn.fit(X_train_n, y_train)

y_train_p = knn.predict(X_train_n)
y_test_p = knn.predict(X_test_n)

print("Tocnost train: " + "{:0.3f}".format((accuracy_score(y_train, y_train_p))))
print("Tocnost test: " + "{:0.3f}".format((accuracy_score(y_test, y_test_p))))

param_range = range(1,101) #range od K(1-100)
param_grid = {'n_neighbors':param_range}

knn = KNeighborsClassifier() #model bez K vrijednosti

grid_search = GridSearchCV(estimator = knn, param_grid = param_grid, cv = 5,scoring='accuracy')
grid_search.fit(X_train, y_train)

print("Optimalna vrijednost K: ", grid_search.best_params_['n_neighbors'])

print("Tocnost vrijednosti: ",grid_search.best_score_)


model = keras.Sequential()
model.add(layers.Input(shape=(4,)))
model.add(layers.Dense(16, activation='relu'))
model.add(layers.Dense(8, activation='relu'))
model.add(layers.Dense(4, activation='relu'))
model.add(layers.Dense(1, activation='sigmoid'))
model.summary()


model.compile(optimizer='adam',
              loss='binary_crossentropy',
              metrics=['accuracy'])

model.fit(X_train_n,
            y_train,
            epochs = 100,
            batch_size = 5,
            validation_split = 0.1)
model.save("model.h5")
model = keras.models.load_model('model.h5')
score = model.evaluate(X_test_n, y_test, verbose=0)
y_test_p = model.predict(X_test_n)
cm = confusion_matrix(y_test,y_test_p)
print("Matrica zabune: ", cm)
disp = ConfusionMatrixDisplay(cm)
disp.plot()
plt.show()