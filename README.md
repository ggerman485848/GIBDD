# Как установить

1. Скачайте и установите Open Server последней версии
2. Включите MySQL
3. Через phpMyAdmin создайте базу данных `bd`
4. Импортируйте в базу данных `gibdd.sql` файл из репозитория
5. Настройте подключение к своей бд, изменив строчку с переменной connStr в файле `src/Form1.cs`
  (Укажите свои данные для подключения)
6. Скомпилировать приложение
