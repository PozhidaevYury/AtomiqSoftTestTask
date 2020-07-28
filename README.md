# AtomiqSoftTestTask 
Сортировку можно было реализовать с использованием интерфейса IComarable или с методом OrderBy, но как я понял их использовать нельзя, поэтому реализовал вот это.

Порядок цветов задается с использованием списка. 0 элемент - высший приоритет. 1 элемент - средний приоритет. 2 элемент - низкий приоритет.

Тесты проверяют, что:
  - Метод работает корректно с валидными данными.
  - Метод работает корректно с пустым списком объектов.
  - Метод работает корректно (Кидает исключение) с невалидными цветами объектов.
  - Метод работает корректно (Кидает исключение) с неавлидными цветами в правиле. Так как по условию задано 3 цвета, то все остальные цвета считаются неккоретными.
  - Метод работает корректно, если объекты принимают 2 цвета из 3.
  - Метод работает корректно, если объекты принимают 1 цвет из 3.
