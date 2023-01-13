# Задача
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

### Решение.
Для написании программы мы будем использовать 3 метода.
* Метод ArrayCheck - нужен для того, чтобы посчетать количество строк, длина которых не превышает 3 символа
* Метод FillResultArray - нужен для формирования массива, в котором длина строк удовлетворяет условию задачи.
* Метод PrintArray - выводим результат на экран.

В первом методе записываем переменную count = 0. Это количество строк, длина которых 3 символа и меньше. В цикле For будем сверять длину строки. Если условие соблюдается, то count увеличиваем на единицу.

Во втором методе, тоже в цикле for будем сверять длину строки и если условие удовлетворяет, то в текущий массив записываем данную строку, уменьшая count на единицу. Уменьшение переменной count необходимо для правильного заполнения массива.