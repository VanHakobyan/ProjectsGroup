# Calculator

<p align="center">
<img src="http://img.freepik.com/free-icon/calculator-interface-symbol-of-four-buttons_318-66982.jpg?size=338&ext=jpg">
</p>
<br>

```c#


MyDelegate op = null;
switch (st)
{
  case "+":
      op = (x, y) => x + y;
      break;
  case "-":
      op = (x, y) => x - y;
      break;
  case "*":
      op = (x, y) => x * y;
      break;
  case "/":
      try
      {
          op = (x, y) => x / y;
      }
      catch (DivideByZeroException DBZE)
      {
          Console.WriteLine(DBZE.Message);
          Console.WriteLine("argument two = 0");
      }
      break;
}
```

            

