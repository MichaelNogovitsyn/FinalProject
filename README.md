**Задача**: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

**Решение**
1. Написать Метод который будет считать из Из изначального массива количество строк менее или равено 3. символов. Так мы определим длину нового массива.
2. Каждую строку первоночального массива, длина которой меньше или равна 3 занести а новый массив.
3. Вывести результат.