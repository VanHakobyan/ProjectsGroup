# Converter Armenian to English letter
<p align="center">
<img src="https://i.gyazo.com/381d953be3a7d02a5d5ea677d12edb38.png">
</p>

```c#
string arm = "ես տանն եմ";
string eng = "es tann em";
Console.WriteLine(eng.ConvertEng()); //es tann em
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine(arm.ConvertEng());//es tann em

//...
if (word[i] == 'է') arm[i] = '1';
if (word[i] == 'թ') arm[i] = '2';
if (word[i] == 'փ') arm[i] = '3';
if (word[i] == 'ձ') arm[i] = '4';
if (word[i] == 'ջ') arm[i] = '5';
//...
if (word[i] == 'w') arm[i] = 'ո';
if (word[i] == 'e') arm[i] = 'ե';
if (word[i] == 'r') arm[i] = 'ռ';
if (word[i] == 't') arm[i] = 'տ';
if (word[i] == 'y') arm[i] = 'ը';
//...
```
