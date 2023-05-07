import tensorflow as tf
import matplotlib.pyplot as plt
import numpy as np
import seaborn as sns

from sklearn.metrics import confusion_matrix, ConfusionMatrixDisplay

mnist = tf.keras.datasets.mnist 
(X_train, y_train),(X_test, y_test) = mnist.load_data()

X_train = tf.keras.utils.normalize(X_train, axis=1)
X_test = tf.keras.utils.normalize(X_test, axis=1)

# TODO: prikazi nekoliko slika iz train skupa
fig, ax = plt.subplots(1,3)
fig.subplots_adjust(hspace=0.5, wspace=0.5)

for i in range(3):
    ax[i].imshow(X_train[i], cmap='gray')
    ax[i].set_title(f'Broj {y_train[i]}')

plt.show()

y_train = tf.keras.utils.to_categorical(y_train)
y_test = tf.keras.utils.to_categorical(y_test)


model = tf.keras.models.Sequential()
model.add(tf.keras.layers.Flatten())  # umjesto 28x28 matrice kao ulaz, stavljamo array od 784 bita
model.add(tf.keras.layers.Dense(100, activation=tf.nn.relu))    # 100 neurona i relu funkcija
model.add(tf.keras.layers.Dense(50, activation=tf.nn.relu))     # 50 neurona i relu funkcija
model.add(tf.keras.layers.Dense(10, activation=tf.nn.softmax))  # 10 neurona zbog 10 mogucih brojeva i softmax

model.compile(optimizer='adam',
              loss='categorical_crossentropy',
              metrics=['accuracy'])


model.fit(X_train, y_train, epochs=5)

val_loss, val_acc = model.evaluate(X_test, y_test)
print(f"val_loss: {val_loss}")
print(f"val_acc: {val_acc}")

predictions = model.predict([X_test])

predicted_number = np.argmax(predictions[0])
plt.imshow(X_test[0], cmap='gray')
plt.title(f'Prepoznat broj: {predicted_number}')

y_true = np.argmax(y_test,axis=1)
y_pred_labels = np.argmax(predictions, axis=1)

cm = confusion_matrix(y_true, y_pred_labels)

fig, ax = plt.subplots(figsize=(15,10))
sns.heatmap(cm, annot=True, fmt='d', ax=ax, cmap='Blues')
ax.set_xlabel('Predicted label')
ax.set_ylabel('Actual label')
ax.set_title('Confusion Matrix')

plt.show()

model.save("myModel.h5")