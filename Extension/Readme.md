# Example Extension

<p align="center">
<img src="https://media.giphy.com/media/ZBDh3VeZjBMfS/giphy.gif">
</p>
<br>
```c#
public static bool isSymmetrical(this string word)
{
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                return false;
            }
            return true;
}
 
//Testing

string st1 = "Anna";
string st2 = "AramarA";
string st3 = "aNNa";
string st4 = "ՀայաՀ";
string st5 = Console.ReadLine();
Console.WriteLine(st1.isSymmetrical());//false
Console.WriteLine(st2.isSymmetrical());//true
Console.WriteLine(st3.isSymmetrical());//true
Console.WriteLine(st4.isSymmetrical());//true
Console.WriteLine(st5.isSymmetrical());
```
