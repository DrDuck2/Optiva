import numpy as np
import pandas as pd
import matplotlib.pyplot as plt

s1 = pd.Series(['crvenkapisa','baka','majka','lovac','vuk'])
print(s1)

s2 = pd.Series(5., index=['a','b','c','d','e'], name = 'ime_objekta')
print(s2)
print(s2['b'])

s3 = pd.Series(np.random.randn(5))
print(s3)
print(s3[3])



data = {'country': ['Italy','Spain','Greece','France','Portugal'],'population': [59,47,11,68,10],'code':[39,34,30,33,351]}
countries = pd.DataFrame(data, columns=['country','population','code'])
print(countries)


data2 = pd.read_csv('data_C02_emission.csv')
print(len(data2))
print(data2)
print(data2.head(5))
print(data2.tail())
print(data2.info())
print(data2.describe())
print(data2.max())
print(data2.min())


print(data2['Cylinders'])
print(data2.Cylinders)

print(data2[['Model','Cylinders']])

print(data2.iloc[2:6, 2:7])

print(data2.iloc[:, 2:5])

print(data2.iloc[:, [0,4,7]])

print(data2.Cylinders > 6)
print(data2[data2.Cylinders > 6])

new_data = data2.groupby('Cylinders')
print(new_data.count())
print(new_data.size())
print(new_data.sum())
print(new_data.mean())


print(data2.isnull().sum())
data2.dropna(axis = 0)
data2.dropna(axis = 1)
data2.drop_duplicates()
data2 = data2.reset_index(drop=True)

plt.figure()
data2['Fuel Consumption City (L/100km)'].plot(kind='hist',bins = 20)
plt.figure()
data2['Fuel Consumption City (L/100km)'].plot(kind ='box')
plt.show()


grouped = data2.groupby('Cylinders')
grouped.boxplot(column = ['CO2 Emissions (g/km)'])

data2.boxplot(column=['CO2 Emissions (g/km)'], by = 'Cylinders')
plt.show()


data2.plot.scatter(x = 'Fuel Consumption City (L/100km)',y = 'Fuel Consumption Hwy (L/100km)',c = 'Engine Size (L)', cmap = "hot",s=50)
plt.show()

print(data2.corr(numeric_only=True))
