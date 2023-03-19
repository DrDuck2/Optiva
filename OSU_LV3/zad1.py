import pandas as pd
import matplotlib.pyplot as plt
import numpy as np

data = pd.read_csv('data_C02_emission.csv')

# a)  

print(data.info())
# po ispisu sadrzi 2212 mjerenja i 12 stupaca
# velicine su tipa object (5 vrijednosti), float64 (4 vrijednosti) i int64 (3 vrijednosti)

print(data.duplicated().sum())
print(data.isnull().sum())

# po ispisu nema dupliciranih vrijednosti i nema null vrijednosti

data.drop_duplicates()
data.dropna(axis = 0)
data.dropna(axis = 1)
data = data.reset_index(drop = True)
print(data.info())

#po ispisu vidimo da nakon brisanja dupliciranih vrijednosti i null vrijednosti
#po ispisu informacija o podacima i dalje imamo 2212 mjerenja i 12 stupaca

print(data.dtypes) #provjerimo koji su podaci tipa object i koje trebamo pretvoriti u kategoricki tip

object_podaci = data.select_dtypes(include =['object']).columns
for values in object_podaci:
    data[values] = data[values].astype('category')
print(data.dtypes)


# b) Make, Model, Fuel Consumption City (L/100km)

new_data = data[['Make','Model','Fuel Consumption City (L/100km)']].sort_values('Fuel Consumption City (L/100km)',ascending=False)
print("Najveca potrosnja: \n",new_data.head(3))
print("Najmanja potrosnja: \n ",new_data.tail(3))

# c) velicina motora izmedju 2.5 i 3.5L, prosjecnja C02 emisija za ova vozila?

new_data_motors = data[(data['Engine Size (L)'] > 2.5) & (data['Engine Size (L)'] < 3.5)]
print("Prosjecna CO2 emission: ",round(new_data_motors['CO2 Emissions (g/km)'].mean(),2))

# d)

print("Mjerenja na Audi: ",(new_data_motors['Make'] == 'Audi').sum())
#odg je 45 Audia

print("Prosjecna emisija Audia sa 4 cilindra: ", round((data['CO2 Emissions (g/km)'].where((data['Make'] == 'Audi') & (data['Cylinders'] == 4 ))).mean(),2))
# odredimo prosjecnu vrijednost CO2 emisije tamo gdje je Proizvodjac Audi i broj cylindra je 4 te zaokruzimo na 2 decimale

# e)

print("Broj vozila sa parnim brojem cilindara: ",len(data[data['Cylinders']%2 == 0]))

cylinderNumber = data['Cylinders'].max()

while cylinderNumber >= 4:
    average = round((data['CO2 Emissions (g/km)'].where(data['Cylinders'] == cylinderNumber)).mean(),2)
    if average > 0:
        print("Prosjecna emisija C02 s obzirom na broj cilindara(",cylinderNumber,"): ",average)
    cylinderNumber -= 2

# f) Fuel Consumption City (L/100km), Fuel Type, D- diesel , X - regularni benzin

print("Prosjecan fuel consumption za dizel: ",round((data['Fuel Consumption City (L/100km)'].where(data['Fuel Type'] == 'D')).mean(),2))
print("Prosjecan fuel consumption za regularni benzin: ",round((data['Fuel Consumption City (L/100km)'].where(data['Fuel Type'] == 'X')).mean(),2))

dieselMotors = data[data['Fuel Type'] == 'D']
gasolineMotors = data[data['Fuel Type'] == 'X']

dieselMotorsAmount = len(dieselMotors)
gasolineMotorsAmount = len(gasolineMotors)

dieselMotors = dieselMotors.sort_values('Fuel Consumption City (L/100km)',ascending=False)
gasolineMotors = gasolineMotors.sort_values('Fuel Consumption City (L/100km)',ascending=False)

if dieselMotorsAmount%2 == 0:
    print("Medijan za dizele: ",(dieselMotors['Fuel Consumption City (L/100km)'].iloc[int(dieselMotorsAmount/2)]+dieselMotors['Fuel Consumption City (L/100km)'].iloc[int(dieselMotorsAmount/2) + 1])/2)
else:
    print("Medijan za dizele: ",dieselMotors['Fuel Consumption City (L/100km)'].iloc[dieselMotorsAmount/2])

if gasolineMotorsAmount%2 == 0:
    print("Medijan za dizele: ",(gasolineMotors['Fuel Consumption City (L/100km)'].iloc[int(gasolineMotorsAmount/2)]+gasolineMotors['Fuel Consumption City (L/100km)'].iloc[int(gasolineMotorsAmount/2) + 1])/2)
else:
    print("Medijan za dizele: ",gasolineMotors['Fuel Consumption City (L/100km)'].iloc[gasolineMotorsAmount/2])

# g) 4 Cylinder, Fuel Type - D, Fuel Consumption City (L/100km) max

print("Dizel vozilo koje najvise trosi: \n", dieselMotors[dieselMotors['Cylinders']==4].head(1))

# h) Vozila sa rucnim mjenjacem

print("Vozila sa rucnim mjenjacem (M): ", len(data[data['Transmission'].str.contains('M')]))

# i) numericka korelacija

print("Numericka korelacija: ",data.corr(numeric_only=True))

#Komentiraj dobiveni rezultat
# Po dobivenim rezultatima vidljivo je da se na dijagonali matrice nalaze jedinice, ujedno
# ova matrica se zrcali preko glavne dijagonale tj M[i][j] = M[j][i] sto je logicno jer korelacija
# izmedju A i B je isto sto i korelacija izmedju B i A 
# sto je korelacija bliza 1 ili -1 to znaci da ukazuje na jaci linearni odnos izmedju dvije varijable
# data.corr nam izracunava korelaciju izmedju svake numericke vrijednosti i daje matricu vrijednosti




