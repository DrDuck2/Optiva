import tensorflow as tf
import matplotlib.pyplot as plt
import numpy as np
import seaborn as sns

mnist = tf.keras.datasets.mnist 
(X_train, y_train),(X_test, y_test) = mnist.load_data()

X_train = tf.keras.utils.normalize(X_train, axis=1)
X_test = tf.keras.utils.normalize(X_test, axis=1)

y_train = tf.keras.utils.to_categorical(y_train)
y_test = tf.keras.utils.to_categorical(y_test)

model = tf.keras.models.load_model("myModel.h5")

predictions = model.predict([X_test])


y_true = np.argmax(y_test,axis=1)
y_pred_labels = np.argmax(predictions, axis=1)

errors = (y_pred_labels - y_true != 0)          # pozicije gdje predvišena klasa nije ista kao stvarna
y_pred_labels_errors = y_pred_labels[errors]    # sve vrijednosti na indeksima errors

y_true_errors = y_true[errors]
X_test_errors = X_test[errors]


fig, ax = plt.subplots(1,3)
fig.subplots_adjust(hspace=0.5, wspace=0.5)

ax[0].imshow(X_test_errors[0], cmap='gray')
ax[0].set_title(f"Predicted: {y_pred_labels_errors[0]},\n actual: {y_true_errors[0]}")

ax[1].imshow(X_test_errors[1], cmap='gray')
ax[1].set_title(f"Predicted: {y_pred_labels_errors[1]},\n actual: {y_true_errors[1]}")

ax[2].imshow(X_test_errors[2], cmap='gray')
ax[2].set_title(f"Predicted: {y_pred_labels_errors[2]},\n actual: {y_true_errors[2]}")

plt.show()