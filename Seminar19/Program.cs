// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// ¬ - отрицание, не; ⋁ - или, +; ⋀ - и, *.

    bool[] x = {true, false};
    bool[] y = {true, false};
    for (int i = 0; i < x.Length; i++)
    {
        
        for (int n = 0; n < y.Length; n++)
        {
            Console.Write("Для x: ");
            Console.WriteLine (x[i]);
            Console.Write("Для y: ");
            Console.WriteLine (y[n]);

            if (!(x[i] || y[n]) == (!x[i] && !y[n]))
            {
              Console.WriteLine("Выражение истинно");
            }
            else
            {
              Console.WriteLine("Выражение ложно");
            }
        }
    }
