__Написание программы по созданию массива строк, содержащего только элементы, чья длина 3 и менее символа, из другого массива строк__

1. _**Создание методов программы**_

* Создаем метод по заполнению первоначального массива с клавиатуры пользователем.

* Создаем метод по созданию нового массива из элементов, длина которых меньше либо равна 3 символам.

    _Принцип работы данного метода заключается в создании нового массива с длиной, ранее установленной пользователем через нахождение количества всех элементов первоначального массива, имеющих 3 и менее символа (будет включено в основную программу)_

* Создаем метод по выведению любого массива на экран.

2. _**Основная программа**_

* Создаем новый массив и предлагаем пользователю заполнить его с клавиатуры.

* Перебираем элементы созданного массива и устанавливаем количество тех, чья длина не превышает 3 символа (включительно).

* Создаем ветвление в виде двух условий - если данное количество больше нуля и равно нулю.

    _**Если количество больше нуля**_

* Создаем новый массив с длиной, равной вышеуказанному количеству.

* Создаем условие if, при котором сравниваем по порядку элемент нового массива со всеми элементами старого через цикл for, и в том случае, если длина элемента старого массива менее или равна 3 символам, присваеиваем элементу нового массива данное значение, после чего увеличиваем счетчик элементов нового массива на 1.

* Выводим на экран оба массива

    _**Если количество равно нулю**_

* Выводим на экран старый массив