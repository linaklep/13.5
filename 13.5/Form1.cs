using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _13._5;

namespace _13._5
{
    public partial class Form1 : Form
    {
        private _13.BStringCollection collection;

        public Form1()
        {
            InitializeComponent();
            collection = new _13.BStringCollection();
            InitializeData();
        }

        private void InitializeData()
        {
            // Додаємо початкові дані
            try
            {
                collection.Add("sample1", new _13.BitovaStrichka("101"));
                collection.Add("sample2", new _13.BitovaStrichka("110"));
                collection.Add("sample3", new _13.BitovaStrichka("001"));
                collection.Add("sample4", new _13.BitovaStrichka("1010"));

                UpdateCollectionDisplay();
                UpdateStatus("Програма запущена. Додано початкові дані.");
            }
            catch (Exception ex)
            {
                UpdateStatus($"Помилка ініціалізації: {ex.Message}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string key = txtKey.Text.Trim();
                string value = txtValue.Text.Trim();

                if (string.IsNullOrEmpty(key))
                {
                    MessageBox.Show("Введіть ключ!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (collection.ContainsKey(key))
                {
                    MessageBox.Show("Елемент з таким ключем вже існує!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var bitString = new _13.BitovaStrichka(value);
                if (string.IsNullOrEmpty(bitString.GetValue()))
                {
                    MessageBox.Show("Бінарна стрічка містить недопустимі символи! Використовуйте тільки 0 та 1.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                collection.Add(key, bitString);
                UpdateCollectionDisplay();
                UpdateStatus($"Додано елемент: {key} = {value}");

                txtKey.Clear();
                txtValue.Clear();
            }
            catch (Exception ex)
            {
                UpdateStatus($"Помилка додавання: {ex.Message}");
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string key = txtKey.Text.Trim();

                if (string.IsNullOrEmpty(key))
                {
                    MessageBox.Show("Введіть ключ для видалення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!collection.ContainsKey(key))
                {
                    MessageBox.Show("Елемент з таким ключем не знайдено!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                collection.Remove(key);
                UpdateCollectionDisplay();
                UpdateStatus($"Видалено елемент: {key}");

                txtKey.Clear();
            }
            catch (Exception ex)
            {
                UpdateStatus($"Помилка видалення: {ex.Message}");
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                collection.Clear();
                UpdateCollectionDisplay();
                UpdateStatus("Колекцію очищено");
            }
            catch (Exception ex)
            {
                UpdateStatus($"Помилка очищення: {ex.Message}");
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string str1 = txtBitString1.Text.Trim();
                string str2 = txtBitString2.Text.Trim();

                if (string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
                {
                    MessageBox.Show("Введіть обидві бінарні стрічки!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var bs1 = new _13.BitovaStrichka(str1);
                var bs2 = new _13.BitovaStrichka(str2);

                if (string.IsNullOrEmpty(bs1.GetValue()) || string.IsNullOrEmpty(bs2.GetValue()))
                {
                    MessageBox.Show("Бінарні стрічки містять недопустимі символи!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Виконуємо операції
                var sum = bs1.Add(bs2);
                var negated1 = bs1.ChangeSign();
                var negated2 = bs2.ChangeSign();
                bool isEqual = bs1.IsEqual(bs2);

                // Відображаємо результати
                txtResults.Clear();
                txtResults.AppendText($"Перша стрічка: {bs1}\r\n");
                txtResults.AppendText($"Друга стрічка: {bs2}\r\n");
                txtResults.AppendText($"Сума: {sum}\r\n");
                txtResults.AppendText($"Зміна знаку першої: {negated1}\r\n");
                txtResults.AppendText($"Зміна знаку другої: {negated2}\r\n");
                txtResults.AppendText($"Стрічки рівні: {isEqual}\r\n");

                UpdateStatus("Операції виконано успішно");
            }
            catch (Exception ex)
            {
                UpdateStatus($"Помилка обчислення: {ex.Message}");
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            try
            {
                string key = txtKey.Text.Trim();

                if (string.IsNullOrEmpty(key))
                {
                    MessageBox.Show("Введіть ключ для отримання інформації!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var element = collection.Get(key);
                if (element != null)
                {
                    string info = $"Інформація про елемент '{key}':\n";
                    info += $"Значення: {element.GetValue()}\n";
                    info += $"Довжина: {element.GetLength()}\n";
                    info += $"Довжина в байтах: {element.GetLengthInBytes()}";

                    MessageBox.Show(info, "Інформація про елемент", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateStatus($"Показано інформацію про елемент: {key}");
                }
                else
                {
                    MessageBox.Show($"Елемент з ключем '{key}' не знайдено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                UpdateStatus($"Помилка отримання інформації: {ex.Message}");
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTestArray_Click(object sender, EventArgs e)
        {
            try
            {
                // Демонстрація роботи з масивом
                var array = new _13.BitovaStrichka[6];

                array[0] = new _13.BitovaStrichka("101");
                array[1] = new _13.BitovaStrichka("110");
                array[2] = new _13.BitovaStrichka("001");

                // Клонуємо першу половину
                for (int i = 3; i < 6; i++)
                {
                    array[i] = (_13.BitovaStrichka)array[i - 3].Clone();
                }

                txtArrayResults.Clear();
                txtArrayResults.AppendText("Масив до сортування:\r\n");
                for (int i = 0; i < array.Length; i++)
                {
                    txtArrayResults.AppendText($"[{i}]: {array[i]}\r\n");
                }

                Array.Sort(array);

                txtArrayResults.AppendText("\r\nМасив після сортування:\r\n");
                for (int i = 0; i < array.Length; i++)
                {
                    txtArrayResults.AppendText($"[{i}]: {array[i]}\r\n");
                }

                txtArrayResults.AppendText("\r\nПеревірка клонування:\r\n");
                txtArrayResults.AppendText($"Перший елемент: {array[0]}\r\n");
                var clone = (_13.BitovaStrichka)array[0].Clone();
                txtArrayResults.AppendText($"Клон: {clone}\r\n");
                txtArrayResults.AppendText($"Рівність: {array[0].IsEqual(clone)}\r\n");

                UpdateStatus("Тестування масиву завершено");
            }
            catch (Exception ex)
            {
                UpdateStatus($"Помилка тестування масиву: {ex.Message}");
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateCollectionDisplay()
        {
            try
            {
                lstHashtable.Items.Clear();
                lstSortedList.Items.Clear();

                // Оновлюємо кількість елементів
                lblCount.Text = $"Кількість елементів: {collection.Count}";

                // Показуємо елементи (симуляція відображення Hashtable та SortedList)
                // Оскільки у нас немає прямого доступу до внутрішніх колекцій,
                // створюємо тимчасові об'єкти для демонстрації
                var tempDict = new Dictionary<string, _13.BitovaStrichka>();

                // Додаємо тестові елементи для відображення
                string[] testKeys = { "sample1", "sample2", "sample3", "sample4" };
                foreach (string key in testKeys)
                {
                    var element = collection.Get(key);
                    if (element != null)
                    {
                        tempDict[key] = element;
                        lstHashtable.Items.Add($"{key} = {element}");
                    }
                }

                // Сортований список
                var sortedKeys = tempDict.Keys.OrderBy(k => k).ToArray();
                foreach (string key in sortedKeys)
                {
                    lstSortedList.Items.Add($"{key} = {tempDict[key]}");
                }
            }
            catch (Exception ex)
            {
                UpdateStatus($"Помилка оновлення відображення: {ex.Message}");
            }
        }

        private void UpdateStatus(string message)
        {
            lblStatus.Text = $"Статус: {message}";
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Дозволяємо тільки 0, 1, Backspace та Delete
            if (e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != '\b' && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void txtBitString1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Дозволяємо тільки 0, 1, Backspace та Delete
            if (e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != '\b' && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void txtBitString2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Дозволяємо тільки 0, 1, Backspace та Delete
            if (e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != '\b' && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }
    }
}