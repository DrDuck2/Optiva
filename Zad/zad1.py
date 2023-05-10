import matplotlib.pyplot as plt
import numpy as np
from sklearn.model_selection import train_test_split
from sklearn.linear_model import LogisticRegression
from sklearn.metrics import confusion_matrix, ConfusionMatrixDisplay
from sklearn.metrics import accuracy_score,precision_score,recall_score
from tensorflow import keras
from tensorflow.keras import layers
from matplotlib import pyplot as plt

filename = "pima-indians-diabetes.csv"
data = np.loadtxt(filename,delimiter=',',skiprows=1)

print("Količina osoba: ",len(data)) #Veličina bilo kojeg stupca nam daje broj ljudi nad kojima se vršilo mjerenje

bmi_age = data[:, [5, 7]]
jedinstveni_redovi, indeksi = np.unique(bmi_age, axis=0, return_index=True) #U jedinstveni redovi se spremaju jedinstveni redovi dok u indeksima indeksi svakog jedinstvenog reda bmi_age
niz_bez_ponavljanja = data[indeksi] #Iz data uz pomoć indeksa se izdvajaju redovi koji se ne ponavljaju
niz_bez_null_vrijednosti = niz_bez_ponavljanja[~np.isnan(niz_bez_ponavljanja).any(axis=1)] #Izdvajanje redova bez null vrijednosti

print("Količina osoba nakon izbacivanja:",len(niz_bez_null_vrijednosti))

extracted_bmi = data[:,5]
extracted_age = data[:,7]
plt.scatter(extracted_bmi,extracted_age,marker='.')
plt.title("Odnos dobi i BMI")
plt.xlabel("Body mass index (weight in kg/(height in m)^2)")
plt.ylabel("Age (years)")
plt.show()

print("Minimalan BMI: ",extracted_bmi.min())
print("Maksimalan BMI: ",extracted_bmi.max())
print("Srednji BMI: ",round(extracted_bmi.mean(),2))

diabetic_bmi = data[data[:, 8] == 1, 5]
nondiabetic_bmi = data[data[:, 8] == 0, 5]

print("Minimalan BMI (Diabetic): ",diabetic_bmi.min())
print("Maksimalan BMI (Diabetic): ",diabetic_bmi.max())
print("Srednji BMI (Diabetic): ",round(diabetic_bmi.mean(),2))

print("Minimalan BMI (non-Diabetic): ",nondiabetic_bmi.min())
print("Maksimalan BMI (non-Diabetic): ",nondiabetic_bmi.max())
print("Srednji BMI: (non-Diabetic)",round(nondiabetic_bmi.mean(),2))

print("Ljudima kojima je dijagnosticiran dijabetes: ",len(diabetic_bmi))

X = data[:,:-1] 
y = data[:,-1] 

X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.2, random_state=5)

LogRegression_model = LogisticRegression()
LogRegression_model.fit(X_train,y_train)

y_test_p = LogRegression_model.predict(X_test)

cm = confusion_matrix(y_test,y_test_p)
print("Matrica zabune: ", cm)
disp = ConfusionMatrixDisplay(cm)
disp.plot()
plt.show()

print("Accuracy: ",accuracy_score(y_test,y_test_p))
print("Precision: ",precision_score(y_test,y_test_p))
print("Odziv: ",recall_score(y_test,y_test_p))

model = keras.Sequential()
model.add(layers.Input(shape=(8,)))
model.add(layers.Dense(12, activation='relu'))
model.add(layers.Dense(8, activation='relu'))
model.add(layers.Dense(1, activation='sigmoid'))
model.summary()

model.compile(optimizer='adam',loss='categorical_crossentropy',metrics=['accuracy'])

model.fit(X_train,y_train,epochs = 150,batch_size = 10,validation_split = 0.1)

model.save ("model.h5")

model = keras.models.load_model("model.h5")

score = model.evaluate(X_test, y_test, verbose=0)

y_test_p = model.predict(X_test)

cm = confusion_matrix(y_test,y_test_p)
print("Matrica zabune: ", cm)
disp = ConfusionMatrixDisplay(cm)
disp.plot()
plt.show()