using System;

// Абстрактный класс ReportGenerator
public abstract class ReportGenerator
{
    // Шаблонный метод для генерации отчета
    public void GenerateReport()
    {
        Console.WriteLine("Начало генерации отчета");

        // Сбор данных
        GatherData();

        // Обработка данных
        ProcessData();

        // Форматирование отчета
        FormatReport();

        // Экспорт отчета
        ExportReport();

        Console.WriteLine("Отчет сгенерирован");
    }

    // Абстрактные методы для сбора, обработки и форматирования данных
    protected abstract void GatherData();
    protected abstract void ProcessData();
    protected abstract void FormatReport();
    protected abstract void ExportReport();
}

// Конкретный класс для отчета по студентам
public class StudentReportGenerator : ReportGenerator
{
    // Реализация метода для сбора данных о студентах
    protected override void GatherData()
    {
        Console.WriteLine("Собраны данные о студентах");
    }

    // Реализация метода для обработки данных о студентах
    protected override void ProcessData()
    {
        Console.WriteLine("Проведены действия с данными о студентах");
    }

    // Реализация метода для форматирования отчета по студентам
    protected override void FormatReport()
    {
        Console.WriteLine("Отчет по студентам сформирован");
    }

    // Реализация метода для экспорта отчета по студентам
    protected override void ExportReport()
    {
        Console.WriteLine("Отчет по студентам экспортирован в файл");
    }
}

// Конкретный класс для отчета по курсам
public class CourseReportGenerator : ReportGenerator
{
    // Реализация метода для сбора данных о курсах
    protected override void GatherData()
    {
        Console.WriteLine("Собраны данные о курсах");
    }

    // Реализация метода для обработки данных о курсах
    protected override void ProcessData()
    {
        Console.WriteLine("Проведены действия с данными о курсах");
    }

    // Реализация метода для форматирования отчета по курсам
    protected override void FormatReport()
    {
        Console.WriteLine("Отчет по курсам сформирован");
    }

    // Реализация метода для экспорта отчета по курсам
    protected override void ExportReport()
    {
        Console.WriteLine("Отчет по курсам экспортирован в файл");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание экземпляров классов для генерации отчетов
        StudentReportGenerator studentReportGenerator = new StudentReportGenerator();
        CourseReportGenerator courseReportGenerator = new CourseReportGenerator();

        // Генерация отчетов
        studentReportGenerator.GenerateReport();
        Console.WriteLine();
        courseReportGenerator.GenerateReport();
    }
}
