// Задача: 
// Написать программу сложения и вычитания двух многочленов
// f(x) = 4*x^3 + 3*x^2 + x + 11
// g(x) = 10*x^3 + x + 10
// f(x) + g(x) =  14*x^3 + 3*x^2 + 2*x^1 + 21
// f(x) - g(x) =  -6*x^3 + 3*x^2 + 1
//          0  1  2  3  4  5          
int[] x = { 1, 2, 0, 4, 5, 16 };
int[] y = { 0, 1, 2, 5, 0, 0, 11, 23 };



// f(x) =  1*x^0 + 2*x^1 + 0*x^2 + 4*x^3 + 5*x^4+ 16*x^5
// g(x) =  10*x^0 + 11*x^1 + 4*x^2 

int[] Sum(int[] f, int[] g)
{
  int powF = f.Length;
  int powG = g.Length;

  int resultMax = powF;
  int resultMin = powG;

  if (powG > resultMax)
  {
    resultMax = powG;
    resultMin = powF;
  }

  int[] result = new int[resultMax];

  for (int i = 0; i < resultMin; i++)
  {
    result[i] = f[i] + g[i];
  }

  for (int i = resultMin; i < resultMax; i++)
  {
    if (resultMax == powG) result[i] = g[i];
    else result[i] = f[i];
  }

  return result;
}

int[] s = Sum(x, y);
for (int i = 0; i < s.Length; i++) Console.Write($"{s[i]} ");

System.Console.WriteLine();