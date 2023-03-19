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

import sklearn.linear_model as lm
# a)

data = pd.read_csv('data_C02_emission.csv')

#numericke vrijednosti u tom datasetu
numeric_data =  data[['Engine Size (L)','Cylinders','Fuel Consumption City (L/100km)','Fuel Consumption Hwy (L/100km)','Fuel Consumption Comb (L/100km)','Fuel Consumption Comb (mpg)','CO2 Emissions (g/km)']]

X = numeric_data.iloc[:,:-1] # svi osim CO2 emissions
y = numeric_data.iloc[:,-1] # samo CO2 emissions

#dijeljenje na 80-20
X_train, X_test,y_train,y_test= train_test_split(X,y,test_size= 0.2,random_state=1)


# b)

plt.scatter(X_train['Engine Size (L)'],y_train, color='blue',label='Training data')
plt.scatter(X_test['Engine Size (L)'],y_test,color='red',label='Testing data')
plt.xlabel('Engine Size (L)')
plt.ylabel('CO2 Emissions (g/km)')
plt.show()

# c)

cs= MinMaxScaler()
X_train_n = cs.fit_transform(X_train)

X_train_n_df = pd.DataFrame(X_train_n,columns = X_train.columns)
fig, (ax1, ax2) = plt.subplots(ncols=2, figsize=(10,5))
X_train['Engine Size (L)'].plot(kind='hist', ax=ax1)
ax1.set_xlabel('Engine Size (L)')
ax1.set_ylabel('Amount')
X_train_n_df['Engine Size (L)'].plot(kind='hist', ax=ax2)
ax2.set_xlabel('Engine Size (L) scaled')
ax2.set_ylabel('Amount')
plt.show()

# kako je vidljivo po grafovima min-max scaler postavlja sve vrijednosti unutar (0-1) rangea

X_test_n = cs.transform(X_test)


# d)

linearModel = lm.LinearRegression()
linearModel.fit(X_train_n, y_train)

print(linearModel.intercept_) #float-point broj koji označava gdje regresijska linija presjeca Y-os, kada je X vrijednost = 0
print(linearModel.coef_) # vraca listu vrijednosti koji oznacavaju koeficijente za svaku neovisnu varijabju u modelu

# s obzirom na funkciju (4.6) 0^1 predstavlja intercept_ ili 182.23 a 0^1,0^2 itd. predstavljaju vrijednosti iz
# coef_, dok su x1,x2,x3 vrijednosti iz modela za treniranje kao 'Engine Size (L) i ostali.
# ta jednadzba ce nam dati predvidjenu vrijednost s obzirom na dane vrijednosti(x1,x2,x3...), a ta predvidjena vrijednost ce biti, u nasem slucaju, vrijednost za CO2 emissions

# e)

y_test_predict = linearModel.predict(X_test_n)

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

# g)

# Evaluacijske metrike na testnom skupu mogu se promijeniti kada mijenjamo broj ulaznih varijabli. Dodavanjem vise ulaznih
# varijabli moze poboljsati izvedbu modela, ali mogu postojati neke varijable koje su stetne za izvedbu modela, sve ovisi
# o dodanim informacijama