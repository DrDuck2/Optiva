import numpy as np
import pandas as pd
import matplotlib.pyplot as plt
from sklearn import datasets
from sklearn.model_selection import train_test_split
from sklearn.preprocessing import MinMaxScaler
from sklearn.preprocessing import OneHotEncoder
from sklearn.metrics import mean_absolute_error

X , y = datasets . load_diabetes ( return_X_y = True )
# podijeli skup na podatkovni skup za ucenje i poda tkovni skup za
#testiranje
X_train , X_test , y_train , y_test = train_test_split (X , y , test_size = 0.2 , random_state =1 )


print(X)
print(y)
print(X_train)
print(X_test)
print(y_train)
print(y_test)