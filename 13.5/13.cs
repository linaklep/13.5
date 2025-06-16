using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13._5
{
    internal class _13
    {
        public interface IStringOperations
        {
            void Clear();
            int GetLength();
            string GetValue();
        }

        // Базовий клас Стрічка
        public class Strichka : IStringOperations, IComparable<Strichka>, ICloneable
        {
            protected string symbols; // Поле для зберігання символів стрічки
            protected byte lengthInBytes; // Довжина стрічки в байтах

            // Конструктор без параметрів
            public Strichka()
            {
                symbols = "";
                lengthInBytes = 0;
            }

            // Конструктор, який приймає стрічку
            public Strichka(string str)
            {
                symbols = str ?? "";
                lengthInBytes = (byte)Math.Min(255, Encoding.UTF8.GetByteCount(symbols));
            }

            // Конструктор, який приймає символ
            public Strichka(char ch)
            {
                symbols = ch.ToString();
                lengthInBytes = (byte)Encoding.UTF8.GetByteCount(symbols);
            }

            // Метод для отримання довжини стрічки
            public virtual int GetLength()
            {
                return symbols.Length;
            }

            // Метод для очистки стрічки
            public virtual void Clear()
            {
                symbols = "";
                lengthInBytes = 0;
            }

            // Метод для отримання значення
            public virtual string GetValue()
            {
                return symbols;
            }

            // Метод для отримання довжини в байтах
            public virtual int GetLengthInBytes()
            {
                return lengthInBytes;
            }

            // Реалізація IComparable
            public int CompareTo(Strichka other)
            {
                if (other == null) return 1;
                return string.Compare(symbols, other.symbols, StringComparison.Ordinal);
            }

            // Реалізація ICloneable
            public virtual object Clone()
            {
                return new Strichka(symbols);
            }

            public override string ToString()
            {
                return symbols;
            }

            public override bool Equals(object obj)
            {
                if (obj is Strichka other)
                    return symbols == other.symbols;
                return false;
            }

            public override int GetHashCode()
            {
                return symbols?.GetHashCode() ?? 0;
            }
        }

        // Похідний клас Бітовастрічка
        public class BitovaStrichka : Strichka
        {
            // Конструктор без параметрів
            public BitovaStrichka() : base()
            {
            }

            // Конструктор, що приймає стрічку
            public BitovaStrichka(string str) : base()
            {
                if (IsValidBinaryString(str))
                {
                    symbols = str;
                    lengthInBytes = (byte)Math.Min(255, Encoding.UTF8.GetByteCount(symbols));
                }
                else
                {
                    symbols = "";
                    lengthInBytes = 0;
                }
            }

            // Перевірка на валідність бінарної стрічки
            private bool IsValidBinaryString(string str)
            {
                if (string.IsNullOrEmpty(str)) return false;
                return str.All(c => c == '0' || c == '1');
            }

            // Зміна знаку на протилежний (доповняльний код)
            public BitovaStrichka ChangeSign()
            {
                if (string.IsNullOrEmpty(symbols))
                    return new BitovaStrichka("");

                // Інвертуємо всі біти
                StringBuilder inverted = new StringBuilder();
                foreach (char c in symbols)
                {
                    inverted.Append(c == '0' ? '1' : '0');
                }

                // Додаємо 1
                string result = AddBinary(inverted.ToString(), "1");
                return new BitovaStrichka(result);
            }

            // Додавання двох бінарних стрічок
            private string AddBinary(string a, string b)
            {
                StringBuilder result = new StringBuilder();
                int carry = 0;
                int i = a.Length - 1;
                int j = b.Length - 1;

                while (i >= 0 || j >= 0 || carry > 0)
                {
                    int sum = carry;
                    if (i >= 0)
                    {
                        sum += a[i] - '0';
                        i--;
                    }
                    if (j >= 0)
                    {
                        sum += b[j] - '0';
                        j--;
                    }

                    result.Insert(0, (sum % 2).ToString());
                    carry = sum / 2;
                }

                return result.ToString();
            }

            // Обрахунок арифметичної суми стрічок
            public BitovaStrichka Add(BitovaStrichka other)
            {
                if (other == null || string.IsNullOrEmpty(other.symbols) || string.IsNullOrEmpty(symbols))
                    return new BitovaStrichka("");

                // Вирівнюємо довжину стрічок
                string a = symbols;
                string b = other.symbols;
                int maxLength = Math.Max(a.Length, b.Length);

                // Розширюємо знаковим розрядом
                a = a.PadLeft(maxLength, a.Length > 0 ? a[0] : '0');
                b = b.PadLeft(maxLength, b.Length > 0 ? b[0] : '0');

                string result = AddBinary(a, b);
                return new BitovaStrichka(result);
            }

            // Перевірка на рівність
            public bool IsEqual(BitovaStrichka other)
            {
                if (other == null) return false;

                // Вирівнюємо довжину для порівняння (розширення знаковим розрядом)
                string a = symbols;
                string b = other.symbols;
                int maxLength = Math.Max(a.Length, b.Length);

                a = a.PadLeft(maxLength, a.Length > 0 ? a[0] : '0');
                b = b.PadLeft(maxLength, b.Length > 0 ? b[0] : '0');

                return a == b;
            }

            public override object Clone()
            {
                return new BitovaStrichka(symbols);
            }
        }

        // Клас для колекції з використанням Hashtable та SortedList
        public class BStringCollection
        {
            private Hashtable hashtable;
            private SortedList<string, BitovaStrichka> sortedList;

            public BStringCollection()
            {
                hashtable = new Hashtable();
                sortedList = new SortedList<string, BitovaStrichka>();
            }

            // Додавання елемента
            public void Add(string key, BitovaStrichka value)
            {
                try
                {
                    if (key == null || value == null)
                        throw new ArgumentNullException("Ключ або значення не можуть бути null");

                    hashtable[key] = value;
                    sortedList[key] = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка при додаванні: {ex.Message}");
                    throw;
                }
            }

            // Отримання елемента
            public BitovaStrichka Get(string key)
            {
                try
                {
                    if (key == null)
                        throw new ArgumentNullException(nameof(key));

                    return hashtable[key] as BitovaStrichka;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка при отриманні: {ex.Message}");
                    return null;
                }
            }

            // Видалення елемента
            public void Remove(string key)
            {
                try
                {
                    if (key == null)
                        throw new ArgumentNullException(nameof(key));

                    hashtable.Remove(key);
                    sortedList.Remove(key);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка при видаленні: {ex.Message}");
                }
            }

            // Перебір елементів Hashtable
            public void DisplayHashtable()
            {
                Console.WriteLine("Елементи Hashtable:");
                try
                {
                    foreach (DictionaryEntry item in hashtable)
                    {
                        Console.WriteLine($"Ключ: {item.Key}, Значення: {item.Value}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка при відображенні Hashtable: {ex.Message}");
                }
            }

            // Перебір елементів SortedList
            public void DisplaySortedList()
            {
                Console.WriteLine("Елементи SortedList (відсортовані):");
                try
                {
                    foreach (var item in sortedList)
                    {
                        Console.WriteLine($"Ключ: {item.Key}, Значення: {item.Value}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка при відображенні SortedList: {ex.Message}");
                }
            }

            // Отримання інформації про елемент
            public void DisplayElementInfo(string key)
            {
                try
                {
                    var element = Get(key);
                    if (element != null)
                    {
                        Console.WriteLine($"Інформація про елемент '{key}':");
                        Console.WriteLine($"Значення: {element.GetValue()}");
                        Console.WriteLine($"Довжина: {element.GetLength()}");
                        Console.WriteLine($"Довжина в байтах: {element.GetLengthInBytes()}");
                    }
                    else
                    {
                        Console.WriteLine($"Елемент з ключем '{key}' не знайдено.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка при отриманні інформації: {ex.Message}");
                }
            }

            public int Count => hashtable.Count;

            // Перевірка наявності ключа
            public bool ContainsKey(string key)
            {
                return hashtable.ContainsKey(key);
            }

            // Очистка колекції
            public void Clear()
            {
                hashtable.Clear();
                sortedList.Clear();
            }

            // Метод для отримання всіх ключів (для WinForms)
            public string[] GetAllKeys()
            {
                return sortedList.Keys.ToArray();
            }

            // Метод для отримання елементів Hashtable (для WinForms)
            public Dictionary<string, BitovaStrichka> GetHashtableItems()
            {
                var result = new Dictionary<string, BitovaStrichka>();
                foreach (DictionaryEntry item in hashtable)
                {
                    if (item.Key is string key && item.Value is BitovaStrichka value)
                    {
                        result[key] = value;
                    }
                }
                return result;
            }

            // Метод для отримання елементів SortedList (для WinForms)
            public Dictionary<string, BitovaStrichka> GetSortedListItems()
            {
                return new Dictionary<string, BitovaStrichka>(sortedList);
            }
        }

        // Клас для консольної демонстрації (без Main методу)
        public class ConsoleDemo
        {
            public static void RunDemo()
            {
                Console.OutputEncoding = Encoding.UTF8;

                try
                {
                    // Демонстрація роботи з масивом об'єктів
                    DemonstrateArrayOperations();

                    // Демонстрація роботи з колекціями
                    DemonstrateCollections();

                    // Меню користувача
                    ShowMenu();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Загальна помилка програми: {ex.Message}");
                }
            }

            static void DemonstrateArrayOperations()
            {
                Console.WriteLine("=== Демонстрація роботи з масивом об'єктів ===");

                try
                {
                    // Створюємо масив об'єктів
                    BitovaStrichka[] array = new BitovaStrichka[6];

                    // Заповнюємо першу половину
                    array[0] = new BitovaStrichka("101");
                    array[1] = new BitovaStrichka("110");
                    array[2] = new BitovaStrichka("001");

                    // Друга половина - клони першої
                    for (int i = 3; i < 6; i++)
                    {
                        array[i] = (BitovaStrichka)array[i - 3].Clone();
                    }

                    Console.WriteLine("Масив до сортування:");
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine($"[{i}]: {array[i]}");
                    }

                    // Сортування масиву
                    Array.Sort(array);

                    Console.WriteLine("\nМасив після сортування:");
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine($"[{i}]: {array[i]}");
                    }

                    // Демонстрація клонування
                    Console.WriteLine("\nПеревірка клонування:");
                    Console.WriteLine($"Перший елемент: {array[0]}");
                    var clone = (BitovaStrichka)array[0].Clone();
                    Console.WriteLine($"Клон: {clone}");
                    Console.WriteLine($"Рівність: {array[0].IsEqual(clone)}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка при роботі з масивом: {ex.Message}");
                }

                Console.WriteLine();
            }

            static void DemonstrateCollections()
            {
                Console.WriteLine("=== Демонстрація роботи з колекціями ===");

                try
                {
                    BStringCollection collection = new BStringCollection();

                    // Додаємо елементи
                    collection.Add("binary1", new BitovaStrichka("101"));
                    collection.Add("binary2", new BitovaStrichka("110"));
                    collection.Add("binary3", new BitovaStrichka("001"));
                    collection.Add("binary4", new BitovaStrichka("1010"));

                    Console.WriteLine($"Кількість елементів у колекції: {collection.Count}");
                    Console.WriteLine();

                    // Відображаємо колекції
                    collection.DisplayHashtable();
                    Console.WriteLine();
                    collection.DisplaySortedList();
                    Console.WriteLine();

                    // Інформація про елемент
                    collection.DisplayElementInfo("binary1");
                    Console.WriteLine();

                    // Демонстрація операцій з бітовими стрічками
                    var bs1 = collection.Get("binary1");
                    var bs2 = collection.Get("binary2");

                    if (bs1 != null && bs2 != null)
                    {
                        Console.WriteLine("Операції з бітовими стрічками:");
                        Console.WriteLine($"Стрічка 1: {bs1}");
                        Console.WriteLine($"Стрічка 2: {bs2}");

                        var sum = bs1.Add(bs2);
                        Console.WriteLine($"Сума: {sum}");

                        var negated = bs1.ChangeSign();
                        Console.WriteLine($"Зміна знаку першої стрічки: {negated}");

                        Console.WriteLine($"Рівність стрічок: {bs1.IsEqual(bs2)}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка при роботі з колекціями: {ex.Message}");
                }

                Console.WriteLine();
            }

            static void ShowMenu()
            {
                BStringCollection collection = new BStringCollection();

                while (true)
                {
                    try
                    {
                        Console.WriteLine("=== МЕНЮ ===");
                        Console.WriteLine("1. Створити бітову стрічку");
                        Console.WriteLine("2. Додати до колекції");
                        Console.WriteLine("3. Показати колекції");
                        Console.WriteLine("4. Операції з бітовими стрічками");
                        Console.WriteLine("5. Інформація про елемент");
                        Console.WriteLine("6. Видалити елемент");
                        Console.WriteLine("7. Очистити колекцію");
                        Console.WriteLine("0. Вихід");
                        Console.Write("Оберіть опцію: ");

                        string choice = Console.ReadLine();

                        switch (choice)
                        {
                            case "1":
                                CreateBitString();
                                break;
                            case "2":
                                AddToCollection(collection);
                                break;
                            case "3":
                                ShowCollections(collection);
                                break;
                            case "4":
                                BitstringOperations();
                                break;
                            case "5":
                                ShowElementInfo(collection);
                                break;
                            case "6":
                                RemoveFromCollection(collection);
                                break;
                            case "7":
                                collection.Clear();
                                Console.WriteLine("Колекцію очищено!");
                                break;
                            case "0":
                                return;
                            default:
                                Console.WriteLine("Невірний вибір!");
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Помилка в меню: {ex.Message}");
                    }

                    Console.WriteLine("Натисніть Enter для продовження...");
                    Console.ReadLine();
                }
            }

            static void CreateBitString()
            {
                try
                {
                    Console.Write("Введіть бінарну стрічку (тільки 0 та 1): ");
                    string input = Console.ReadLine();

                    BitovaStrichka bitString = new BitovaStrichka(input);

                    if (string.IsNullOrEmpty(bitString.GetValue()))
                    {
                        Console.WriteLine("Помилка: стрічка містить недопустимі символи!");
                    }
                    else
                    {
                        Console.WriteLine($"Створено бітову стрічку: {bitString}");
                        Console.WriteLine($"Довжина: {bitString.GetLength()}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка при створенні бітової стрічки: {ex.Message}");
                }
            }

            static void AddToCollection(BStringCollection collection)
            {
                try
                {
                    Console.Write("Введіть ключ: ");
                    string key = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(key))
                    {
                        Console.WriteLine("Помилка: ключ не може бути порожнім!");
                        return;
                    }

                    if (collection.ContainsKey(key))
                    {
                        Console.WriteLine("Помилка: елемент з таким ключем вже існує!");
                        return;
                    }

                    Console.Write("Введіть бінарну стрічку: ");
                    string value = Console.ReadLine();

                    BitovaStrichka bitString = new BitovaStrichka(value);

                    if (string.IsNullOrEmpty(bitString.GetValue()))
                    {
                        Console.WriteLine("Помилка: стрічка містить недопустимі символи!");
                    }
                    else
                    {
                        collection.Add(key, bitString);
                        Console.WriteLine("Елемент додано до колекції!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка при додаванні до колекції: {ex.Message}");
                }
            }

            static void RemoveFromCollection(BStringCollection collection)
            {
                try
                {
                    Console.Write("Введіть ключ елемента для видалення: ");
                    string key = Console.ReadLine();

                    if (collection.ContainsKey(key))
                    {
                        collection.Remove(key);
                        Console.WriteLine("Елемент видалено!");
                    }
                    else
                    {
                        Console.WriteLine("Елемент з таким ключем не знайдено!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка при видаленні: {ex.Message}");
                }
            }

            static void ShowCollections(BStringCollection collection)
            {
                try
                {
                    Console.WriteLine($"Кількість елементів: {collection.Count}");
                    Console.WriteLine();
                    collection.DisplayHashtable();
                    Console.WriteLine();
                    collection.DisplaySortedList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка при відображенні колекцій: {ex.Message}");
                }
            }

            static void BitstringOperations()
            {
                try
                {
                    Console.Write("Введіть першу бінарну стрічку: ");
                    string str1 = Console.ReadLine();

                    Console.Write("Введіть другу бінарну стрічку: ");
                    string str2 = Console.ReadLine();

                    BitovaStrichka bs1 = new BitovaStrichka(str1);
                    BitovaStrichka bs2 = new BitovaStrichka(str2);

                    if (string.IsNullOrEmpty(bs1.GetValue()) || string.IsNullOrEmpty(bs2.GetValue()))
                    {
                        Console.WriteLine("Помилка: одна з стрічок містить недопустимі символи!");
                        return;
                    }

                    Console.WriteLine($"Перша стрічка: {bs1}");
                    Console.WriteLine($"Друга стрічка: {bs2}");

                    // Додавання
                    BitovaStrichka sum = bs1.Add(bs2);
                    Console.WriteLine($"Сума: {sum}");

                    // Зміна знаку
                    BitovaStrichka negated1 = bs1.ChangeSign();
                    BitovaStrichka negated2 = bs2.ChangeSign();
                    Console.WriteLine($"Зміна знаку першої стрічки: {negated1}");
                    Console.WriteLine($"Зміна знаку другої стрічки: {negated2}");

                    // Перевірка на рівність
                    bool isEqual = bs1.IsEqual(bs2);
                    Console.WriteLine($"Стрічки рівні: {isEqual}");

                    // Клонування
                    BitovaStrichka clone1 = (BitovaStrichka)bs1.Clone();
                    Console.WriteLine($"Клон першої стрічки: {clone1}");
                    Console.WriteLine($"Клон дорівнює оригіналу: {bs1.IsEqual(clone1)}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка при операціях з бітовими стрічками: {ex.Message}");
                }
            }

            static void ShowElementInfo(BStringCollection collection)
            {
                try
                {
                    Console.Write("Введіть ключ елемента: ");
                    string key = Console.ReadLine();

                    collection.DisplayElementInfo(key);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка при отриманні інформації про елемент: {ex.Message}");
                }
            }
        }
    }
}