import numpy as np
import pandas as pd
import matplotlib.pyplot as plt
from sklearn import datasets
from sklearn.model_selection import train_test_split
from sklearn.preprocessing import MinMaxScaler
from sklearn.preprocessing import OneHotEncoder
from sklearn.metrics import mean_absolute_error
from sklearn.metrics import mean_squared_error
from sklearn.metrics import mean_absolute_percentage_error
from sklearn.metrics import max_error
import sklearn.linear_model as lm

data = pd.read_csv('data_C02_emission.csv')

ohe = OneHotEncoder()
X_encoded = ohe.fit_transform(data[['Fuel Type']])  # kodiranje vrijednosti Fuel Type u 0 i 1
encoded_feature_names = ohe.get_feature_names_out(['Fuel Type']) #
X_encoded_df = pd.DataFrame(X_encoded.toarray(), columns=encoded_feature_names) #pretvaranje X_encoded u dataframe iz Pandas

numeric_data = data[['Engine Size (L)', 'Cylinders', 'Fuel Consumption City (L/100km)', 'Fuel Consumption Hwy (L/100km)', 'Fuel Consumption Comb (L/100km)', 'Fuel Consumption Comb (mpg)', 'CO2 Emissions (g/km)']]

numeric_encoded_data = pd.concat([X_encoded_df, numeric_data], axis=1) #povezivanje kodiranih vrijednosti i numerickih vrijednosti iz Pandas
X = numeric_encoded_data.iloc[:, :-1]  # all columns except last one (CO2 Emissions)
y = numeric_encoded_data.iloc[:, -1]   # last column (CO2 Emissions)

#Sve ostalo je isto ko i zad1 osim sto ne skaliramo vrijednosti na (0-1)
X_train, X_test,y_train,y_test= train_test_split(X,y,test_size= 0.2,random_state=1)

linearModel = lm.LinearRegression()
linearModel.fit(X_train, y_train)

print(linearModel.intercept_) #float-point broj koji označava gdje regresijska linija presjeca Y-os, kada je X vrijednost = 0
print(linearModel.coef_) # vraca listu vrijednosti koji oznacavaju koeficijente za svaku neovisnu varijabju u modelu

y_test_predict = linearModel.predict(X_test)

plt.scatter(y_test,y_test_predict)
plt.xlabel('Real CO2 Emissions')
plt.ylabel('Predicted values')
plt.show()


# f)

#Mean squared error
MSE = mean_squared_error(y_test,y_test_predict)
#Mean absolute error
MAE = mean_absolute_error(y_test,y_test_predict)
#Mean absolute percentage error
MAPE = mean_absolute_percentage_error(y_test,y_test_predict)

print('Mean squared error: ',MSE)
print('Mean absolute error: ',MAE)
print('Mean absolute percentage error: ',MAPE)

#Po grafu je vidljivo kako su testne izlazne velicine dosta slicne prediktivnim vrijednostima te kako je Srednja kvadratna pogreska dosta manja nego iz prvog zadatka
#Kolika je maksimalna pogreška u procjeni emisije C02 plinova u g/km? O kojem se modelu vozila radi?

#Pogreske su: MSE = 8.12, MAE = 1.41, MAPE = 0.005

max_err = max_error(y_test,y_test_predict)
print('Maksimalna pogreska: ',max_err)
# Iako koristimo 'Fuel Type' kao ulaznu varijablu ona sama po sebi nije dovoljna za odredjivanje tocnog modela auta, da
# bismo odredili tocan model vozila morali bismo imati i druge informacije