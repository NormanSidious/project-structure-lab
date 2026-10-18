// Calculator.Tests.cs
// Шаблон тестов для проверки логики калькулятора.
// В реальном проекте здесь использовался бы xUnit, NUnit или MSTest.
// Сейчас это заготовка: методы названы как тесты, но не подключены к фреймворку.

using System;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        // Тест: сложение двух положительных чисел
        public void TestAdd_ReturnsSum()
        {
            // Arrange
            int a = 2;
            int b = 3;
            int expected = 5;

            // Act (в реальном тесте здесь был бы вызов Calculator.Add)
            int actual = a + b; // заглушка вместо Calculator.Add(a, b)

            // Assert (упрощённая проверка)
            if (actual != expected)
                throw new Exception($"TestAdd failed: expected {expected}, got {actual}");

            Console.WriteLine("TestAdd_ReturnsSum passed.");
        }

        // Тест: вычитание
        public void TestSubtract_ReturnsDifference()
        {
            int a = 10;
            int b = 4;
            int expected = 6;
            int actual = a - b; // заглушка вместо Calculator.Subtract(a, b)

            if (actual != expected)
                throw new Exception($"TestSubtract failed: expected {expected}, got {actual}");

            Console.WriteLine("TestSubtract_ReturnsDifference passed.");
        }

        // Точка входа, чтобы файл можно было запустить отдельно (необязательно)
        public static void Main()
        {
            var tests = new CalculatorTests();
            tests.TestAdd_ReturnsSum();
            tests.TestSubtract_ReturnsDifference();
        }
    }
}