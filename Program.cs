using System.IO;

// Console.WriteLine("=== File.WriteAllText / ReadAllText ===");

// File.WriteAllText("notes.txt", "Привет, файл!");
// string content = File.ReadAllText("notes.txt");
// Console.WriteLine($"Содержимое файла: {content}");

// Console.WriteLine();
// Console.WriteLine("=== File.AppendAllText ===");

// File.AppendAllText("notes.txt", "\nВторая строка");
// File.AppendAllText("notes.txt", "\nТретья строка");

// string updatedContent = File.ReadAllText("notes.txt");
// Console.WriteLine(updatedContent);

// Console.WriteLine();
// Console.WriteLine("=== File.Exists ===");

// Console.WriteLine($"notes.txt существует: {File.Exists("notes.txt")}");
// Console.WriteLine($"unknown.txt существует: {File.Exists("unknown.txt")}");

// Console.WriteLine();
// Console.WriteLine("=== WriteAllLines / ReadAllLines ===");

// string[] students = { "Иванов", "Петрова", "Сидоров" };
// File.WriteAllLines("students.txt", students);

// string[] readStudents = File.ReadAllLines("students.txt");
// Console.WriteLine($"Прочитано строк: {readStudents.Length}");
// foreach (string student in readStudents)
// {
//     Console.WriteLine($"- {student}");
// }

// Console.WriteLine();
// Console.WriteLine("=== StreamWriter ===");

// using (StreamWriter writer = new StreamWriter("log.txt"))
// {
//     writer.WriteLine("Программа запущена");
//     writer.WriteLine($"Дата: {DateTime.Now:dd.MM.yyyy HH:mm}");
//     writer.WriteLine("Операция выполнена успешно");
// }

// Console.WriteLine("Файл log.txt записан");


// Console.WriteLine();
// Console.WriteLine("=== StreamReader ===");

// using (StreamReader reader = new StreamReader("log.txt"))
// {
//     string line;
//     int lineNumber = 1;
//     while ((line = reader.ReadLine()) != null)
//     {
//         Console.WriteLine($"Строка {lineNumber}: {line}");
//         lineNumber++;
//     }
// }


// Console.WriteLine();
// Console.WriteLine("=== Обработка ошибок ===");

// try
// {
//     string content = File.ReadAllText("несуществующий_файл.txt");
//     Console.WriteLine(content);
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Файл не найден: {ex.Message}");
// }

// Console.WriteLine();
// Console.WriteLine("=== Path.Combine ===");

// string folderPath = "data";
// Directory.CreateDirectory(folderPath);

// string filePath = Path.Combine(folderPath, "report.txt");
// File.WriteAllText(filePath, "Отчёт находится в подпапке data");

// Console.WriteLine($"Путь к файлу: {filePath}");
// Console.WriteLine(File.ReadAllText(filePath));


// string diaryPath = "diary.txt";
// string choice;

// do
// {
//     Console.WriteLine("\n--- Меню дневника ---");
//     Console.WriteLine("1 - Добавить запись");
//     Console.WriteLine("2 - Показать все записи");
//     Console.WriteLine("3 - Очистить дневник");
//     Console.WriteLine("0 - Выход");
//     Console.Write("Выберите пункт меню: ");

//     choice = Console.ReadLine();

//     switch (choice)
//     {
//         case "1":
//             Console.Write("Введите текст записи: ");
//             string text = Console.ReadLine();
            
//             try
//             {
//                 // Открываем StreamWriter в режиме дозаписи (append: true)
//                 using (StreamWriter writer = new StreamWriter(diaryPath, append: true))
//                 {
//                     string record = $"[{DateTime.Now:dd.MM.yyyy HH:mm}] {text}";
//                     writer.WriteLine(record);
//                 }
//                 Console.WriteLine("Запись успешно добавлена.");
//             }
//             catch (IOException ex)
//             {
//                 Console.WriteLine($"Произошла ошибка ввода-вывода: {ex.Message}");
//             }
//             break;

//         case "2":
//             try
//             {
//                 if (File.Exists(diaryPath))
//                 {
//                     Console.WriteLine("\n--- Все записи ---");
//                     string[] lines = File.ReadAllLines(diaryPath);
                    
//                     for (int i = 0; i < lines.Length; i++)
//                     {
//                         Console.WriteLine($"{i + 1}. {lines[i]}");
//                     }
//                 }
//                 else
//                 {
//                     Console.WriteLine("Дневник пуст.");
//                 }
//             }
//             catch (IOException ex)
//             {
//                 Console.WriteLine($"Произошла ошибка при чтении файла: {ex.Message}");
//             }
//             break;

//         case "3":
//             try
//             {
//                 if (File.Exists(diaryPath))
//                 {
//                     File.Delete(diaryPath);
//                     Console.WriteLine("Дневник успешно очищен.");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Дневник и так пуст (файл не существует).");
//                 }
//             }
//             catch (IOException ex)
//             {
//                 Console.WriteLine($"Произошла ошибка при удалении файла: {ex.Message}");
//             }
//             break;

//         case "0":
//             Console.WriteLine("Выход из программы. До свидания!");
//             break;

//         default:
//             Console.WriteLine("Неверный выбор. Пожалуйста, выберите пункт от 0 до 3.");
//             break;
//     }

// } while (choice != "0");


// string filePath = "notes.txt";

// try
// {

//     if (!File.Exists(filePath))
//     {

//         File.WriteAllLines(filePath, new string[] 
//         { 
//             "щщщщ", 
//             "оооооо", 
//             "еееееееее" 
//         });
//         Console.WriteLine($"Файл '{filePath}' не был найден");
//     }

//     string[] lines = File.ReadAllLines(filePath);
    
//     int totalLines = lines.Length;
//     int totalWords = 0;

//     foreach (string line in lines)
//     {

//         string[] words = line.Split(new char[] { ' ' });
//         totalWords += words.Length;
//     }

//     Console.WriteLine($"Всего строк в файле: {totalLines}");
//     Console.WriteLine($"Всего слов в файле: {totalWords}");
// }
// catch (IOException ex)
// {
//     Console.WriteLine($"Ошибка: {ex.Message}");
// }




// string sourcePath = "source.txt";
// string destinationPath = "destination.txt";

// File.WriteAllText(sourcePath, "Первая строка\nВторая строка");

// CopyFileManually(sourcePath, destinationPath);

// Console.WriteLine("=== Исходный файл ===");
// Console.WriteLine(File.ReadAllText(sourcePath));

// Console.WriteLine("\n=== Целевой файл ===");
// Console.WriteLine(File.ReadAllText(destinationPath));

// void CopyFileManually(string source, string destination)
// {
//     using StreamReader reader = new StreamReader(source);
//     using StreamWriter writer = new StreamWriter(destination);

//     string? line;
//     while ((line = reader.ReadLine()) != null)
//     {
//         writer.WriteLine(line);
//     }
// }





const string fileName = "attendance.csv";

while (true)
{
    Console.WriteLine("\n--- Учёт посещаемости ---");
    Console.WriteLine("1. Отметить студента");
    Console.WriteLine("2. Показать статистику по студенту");
    Console.WriteLine("3. Выход");
    Console.Write("Выберите пункт: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            MarkAttendance();
            break;
        case "2":
            ShowStudentStatistics();
            break;
        case "3":
            return;
        default:
            Console.WriteLine("Неверный ввод.");
            break;
    }
}

void MarkAttendance()
{
    Console.Write("Введите ФИО студента: ");
    string fullName = Console.ReadLine().Trim();

    if (string.IsNullOrEmpty(fullName))
    {
        Console.WriteLine("ФИО не может быть пустым.");
        return;
    }

    Console.Write("Присутствовал? (Да/Нет): ");
    string? status = Console.ReadLine()?.Trim();

    if (status != "Да" && status != "Нет" && status != "да" && status != "нет")
    {
        Console.WriteLine("Введите 'Да' или 'Нет'.");
        return;
    }

    string date = DateTime.Now.ToString("dd.MM.yyyy");
    File.AppendAllText(fileName, $"{fullName},{date},{status}\n");
    Console.WriteLine("Запись добавлена.");
}

void ShowStudentStatistics()
{
    Console.Write("Введите ФИО студента: ");
    string searchName = Console.ReadLine().Trim();

    if (string.IsNullOrEmpty(searchName))
    {
        Console.WriteLine("Имя не введено.");
        return;
    }

    try
    {
        string[] lines = File.ReadAllLines(fileName);
        int present = 0;
        int absent = 0;

        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;

            string[] parts = line.Split(',');
            if (parts.Length >= 3)
            {
                string nameInFile = parts[0].Trim();
                string statusInFile = parts[2].Trim();

                if (nameInFile.ToLower() == searchName.ToLower())
                {
                    if (statusInFile.ToLower() == "да")
                    {
                        present++;
                    }
                    else if (statusInFile.ToLower() == "нет")
                    {
                        absent++;
                    }
                }
            }
        }

        Console.WriteLine($"Статистика для {searchName}: присутствовал — {present}, отсутствовал — {absent}");
    }
    catch (FileNotFoundException)
    {
        Console.WriteLine("Записей ещё нет");
    }
}