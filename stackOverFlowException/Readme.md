# Stack OverFlow Exception 
## Does not work finlly
<p align="center">
<img src="https://scontent.cdninstagram.com/t51.2885-15/s320x320/e35/15099581_374427109566894_4076436954797834240_n.jpg?ig_cache_key=MTM4NDgwNTMzNTc1OTQ4NDc5NQ%3D%3D.2">
</p>
<br>

### For Exemple

```C#
class Program
{
    public static void method()
    {
        int[] array = new int[100];
        Console.WriteLine(array);
        method(); //recursion
    }

    static void Main()
    {
        try
        {
            method();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {   
            //finally does not work
            Console.WriteLine("i am finally");
        }
    }
}

```
#### Remarks
<div class="section"><p><span class="selflink">StackOverflowException</span> is thrown for execution stack overflow errors, typically in case of a very deep or unbounded recursion. </p><p><span class="selflink">StackOverflowException</span> uses the HRESULT COR_E_STACKOVERFLOW, which has the value 0x800703E9. The <a href="https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.localloc(v=vs.110).aspx">Localloc</a> intermediate language (IL) instruction throws <span class="selflink">StackOverflowException</span>. For a list of initial property values for a <span class="selflink">StackOverflowException</span> object, see the <a href="https://msdn.microsoft.com/en-us/library/fc1a482t(v=vs.110).aspx">StackOverflowException</a> constructors.</p></div>

#### Version Considerations

<p>In the .NET Framework 1.0 and 1.1, you could catch a <span class="selflink">StackOverflowException</span> object (for example, to recover from unbounded recursion). Starting with the .NET Framework 2.0, you can’t catch a <span class="selflink">StackOverflowException</span> object with a <strong>try</strong>/<strong>catch</strong> block, and the corresponding process is terminated by default. Consequently, you should write your code to detect and prevent a stack overflow. For example, if your app depends on recursion, use a counter or a state condition to terminate the recursive loop. The following example uses a counter to ensure that the number of recursive calls to the <span class="code">Execute</span> method do not exceed a maximum defined by the MAX_RECURSIVE_CALLS constant. </p>


 <a href="https://msdn.microsoft.com/en-us/library/system.stackoverflowexception(v=vs.110).aspx">For more click here</a>
