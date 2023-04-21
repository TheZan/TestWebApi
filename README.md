# Инструкция по запуску проекта

![Guid GIF](https://s12.gifyu.com/images/01-41-09.gif)

## Шаг 1: Установка необходимых компонентов

Прежде чем начать, убедитесь, что у вас установлены необходимые компоненты:

- [.NET 7 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)

Если вы еще не установили .NET 7 SDK, перейдите по ссылке и загрузите соответствующую версию для вашей операционной системы.

## Шаг 2: Клонирование репозитория

Следующий шаг - клонирование репозитория на свой компьютер. Это можно сделать с помощью следующей команды:

```bash
git clone https://github.com/TheZan/TestWebApi.git
```

## Шаг 3: Установка зависимостей и запуск проекта

Откройте терминал (командную строку) и перейдите в директорию проекта:

```bash
cd your-project
```

Установите зависимости, необходимые для работы проекта, с помощью следующей команды:

```bash
dotnet restore
```

Затем скомпилируйте и запустите проект, используя команду:

```bash
dotnet run
```

После запуска проекта вы увидите сообщение, указывающее, что приложение запущено на адресе `https://localhost:5001`.

## Шаг 4: Запуск проекта

Чтобы запустить проект, используйте следующую команду:

```bash
dotnet run
```

Эта команда скомпилирует и запустит проект. Вы увидите сообщение, указывающее, что приложение запущено на адресе `https://localhost:5001`.

## Шаг 5: Проверка работоспособности

Откройте веб-браузер и перейдите по адресу `https://localhost:5001/api/products`. Если все настроено правильно, вы увидите список продуктов в формате JSON.

## Шаг 6: Использование API

API теперь готово к использованию. Документация по API доступна на странице `https://localhost:5001/swagger`. В документации вы найдете информацию о том, как использовать различные методы и параметры API.
