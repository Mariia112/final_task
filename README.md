# Задача
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

# Решение
Пользователь вводит элементы массива. 
Программа считывает введенные данные и создает массив stringArray1.
Далее создает новыймассив stringArray2.
Метод findStringWithAtMostThree проверяет элементы массива, и если длина элемента меньше или равна 3, то записывает этот элемент в массив stringArray2.
Метод PrintArray выводит  массив stringArray2.