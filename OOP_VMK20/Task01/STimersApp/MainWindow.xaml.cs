using System.Windows;
using STimers;

namespace STimersApp;

public partial class MainWindow : Window
{
    STime t1 = new(10, 10, 10, 100); // Первое время.
    STime t2 = new(10, 10, 10, 100); // Второе время.

    public MainWindow()
    {
        InitializeComponent();
        UpdateInterface();

        // Кнопки упраления первым временем.
        btnAddHours1.Click += (s, e) => { t1.Hours += 1; UpdateInterface(); };
        btnSubHours1.Click += (s, e) => { t1.Hours -= 1; UpdateInterface(); };

        btnAddMinut1.Click += (s, e) => { t1.Minutes += 10; UpdateInterface(); };
        btnSubMinut1.Click += (s, e) => { t1.Minutes -= 10; UpdateInterface(); };

        btnAddSecon1.Click += (s, e) => { t1.Seconds += 10; UpdateInterface(); };
        btnSubSecon1.Click += (s, e) => { t1.Seconds -= 10; UpdateInterface(); };

        btnAddMilli1.Click += (s, e) => { t1.Milliseconds += 100; UpdateInterface(); };
        btnSubMilli1.Click += (s, e) => { t1.Milliseconds -= 100; UpdateInterface(); };

        // Кнопки упраления вторым временем.
        btnAddHours2.Click += (s, e) => { t2.Hours += 1; UpdateInterface(); };
        btnSubHours2.Click += (s, e) => { t2.Hours -= 1; UpdateInterface(); };

        btnAddMinut2.Click += (s, e) => { t2.Minutes += 10; UpdateInterface(); };
        btnSubMinut2.Click += (s, e) => { t2.Minutes -= 10; UpdateInterface(); };

        btnAddSecon2.Click += (s, e) => { t2.Seconds += 10; UpdateInterface(); };
        btnSubSecon2.Click += (s, e) => { t2.Seconds -= 10; UpdateInterface(); };

        btnAddMilli2.Click += (s, e) => { t2.Milliseconds += 100; UpdateInterface(); };
        btnSubMilli2.Click += (s, e) => { t2.Milliseconds -= 100; UpdateInterface(); };

        // Кнопки арифм. действий.
        btnAdd.Click += (s, e) => { t1 += t2; UpdateInterface(); };
        btnSub.Click += (s, e) => { t1 -= t2; UpdateInterface(); };
        btnMul.Click += (s, e) => { t1 *= 2; UpdateInterface(); };
        btnDiv.Click += (s, e) => { t1 /= 2; UpdateInterface(); };
    }

    private void UpdateInterface()
    {
        tbFirst.Text = t1.ToString();
        tbTwo.Text = t2.ToString();

        hCount.Content = t1.ToHours().ToString("#.#####");
        mCount.Content = t1.ToMinutes().ToString("#.#####");
        sCount.Content = t1.ToSeconds().ToString("#.#####");
        msCount.Content = t1.ToMilliseconds().ToString("#.#####");

        isEq.Content = t1 == t2;
        isNotEq.Content = t1 != t2;
        isMore.Content = t1 > t2;
        isLess.Content = t1 < t2;
        isMoreOrEqual.Content = t1 >= t2;
        isLessOrEquel.Content = t1 <= t2;
    }
}
