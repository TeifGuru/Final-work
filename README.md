# Описание программы
## Создание масиива
Так как в изначальных условиях не была указана длинна исходного массива необходимо чтобы пользователь ввел её самостоятельно.

После указания длинны массива пользоватеь поочередно вводит каждый элемент массива. Для этого используется метод **firstArray**. Так как тип элементов массива вводимых пользователем нам неизвестен, будет исползоваться тип **string**.

## Формирование нового массива по указанным парраметрам

Для формирования нового массива используется метод **finalArray**.

Для формирования необходимо знать длинну нового массива. Определяем длинну нового массива подсчитывая количество всех элементов исходного массива, удовлетворяющих условию.

Далее в новый массив добавляем необходимые элементы, поочередно проверяя каждый элемент исходного массива на соответствие условию.

## Вывод результата

В каждом методе прописан вывод промежуточных результатов, таких как:
*"Исходный массив"*, *"Количество элементов удовлетворяющих условию"*

В конце медода **finalArray** выводится готовый массив, с элементами удовлетворяющими условию.

