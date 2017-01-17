# Extension Polidrom string

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
### About palindrome
<p>A <b>palindrome</b> is a word, phrase, <a href="/wiki/Palindromic_number" title="Palindromic number">number</a>, or other sequence of <a href="/wiki/Character_(symbol)" title="Character (symbol)">characters</a> which reads the same backward or forward, such as <i>madam</i> or <i>kayak</i>. Sentence-length palindromes may be written when allowances are made for adjustments to capital letters, punctuation, and word dividers, such as "A man, a plan, a canal, Panama!", "Was it a car or a cat I saw?" or "No 'x' in Nixon".</p>

### About Extension methods

<p></p><p>Extension methods are defined as static methods but are called by using instance method syntax. Their first parameter specifies which type the method operates on, and the parameter is preceded by the <a href="https://msdn.microsoft.com/en-us/library/dk1507sz.aspx">this</a> modifier. Extension methods are only in scope when you explicitly import the namespace into your source code with a <code>using</code> directive.</p><p>The following example shows an extension method defined for the <a href="https://msdn.microsoft.com/en-us/library/system.string.aspx">System.String</a> class. Note that it is defined inside a non-nested, non-generic static class:</p><p>
</p><div id="code-snippet-2" class="codeSnippetContainer" xmlns="">
    <div class="codeSnippetContainerTabs">
        <div class="codeSnippetContainerTabSingle" dir="ltr"><a>C#</a></div>
    </div>
    <div class="codeSnippetContainerCodeContainer">
        <div class="codeSnippetToolBar">
            <div class="codeSnippetToolBarText">
                <a name="CodeSnippetCopyLink" style="display: none;" title="Copy to clipboard." href="javascript:if (window.epx.codeSnippet)window.epx.codeSnippet.copyCode('CodeSnippetContainerCode_e9517883-3f01-461b-9ff3-21b3227a3aa2');" ms.cmptyp="CodeSnippet">Copy</a>
            </div>
        </div>
        <div id="CodeSnippetContainerCode_e9517883-3f01-461b-9ff3-21b3227a3aa2" class="codeSnippetContainerCode" dir="ltr">
            <div style="color:Black;"><pre><span style="color:Blue;">namespace</span> ExtensionMethods
{
    <span style="color:Blue;">public</span> <span style="color:Blue;">static</span> <span style="color:Blue;">class</span> MyExtensions
    {
        <span style="color:Blue;">public</span> <span style="color:Blue;">static</span> <span style="color:Blue;">int</span> WordCount(<span style="color:Blue;">this</span> String str)
        {
            <span style="color:Blue;">return</span> str.Split(<span style="color:Blue;">new</span> <span style="color:Blue;">char</span>[] { <span style="color:#A31515;">' '</span>, <span style="color:#A31515;">'.'</span>, <span style="color:#A31515;">'?'</span> }, 
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }   
}
</pre></div>
            
        </div>
    </div>
</div>
<p></p><p>The <code>WordCount</code> extension method can be brought into scope with this <code>using</code> directive:</p>
<div id="code-snippet-3" class="codeSnippetContainer" xmlns="">
    <div class="codeSnippetContainerTabs">
        
    </div>
    <div class="codeSnippetContainerCodeContainer">
        <div class="codeSnippetToolBar">
            <div class="codeSnippetToolBarText">
                <a name="CodeSnippetCopyLink" style="display: none;" title="Copy to clipboard." href="javascript:if (window.epx.codeSnippet)window.epx.codeSnippet.copyCode('CodeSnippetContainerCode_78756d3f-508d-40a8-a312-fb01804823dd');" ms.cmptyp="CodeSnippet">Copy</a>
            </div>
        </div>
        <div id="CodeSnippetContainerCode_78756d3f-508d-40a8-a312-fb01804823dd" class="codeSnippetContainerCode" dir="ltr">
            <div style="color:Black;"><pre>using ExtensionMethods;  

</pre></div>
            
        </div>
    </div>
</div>
<p>And it can be called from an application by using this syntax:</p>
<div id="code-snippet-4" class="codeSnippetContainer" xmlns="">
    <div class="codeSnippetContainerTabs">
        
    </div>
    <div class="codeSnippetContainerCodeContainer">
        <div class="codeSnippetToolBar">
            <div class="codeSnippetToolBarText">
                <a name="CodeSnippetCopyLink" style="display: none;" title="Copy to clipboard." href="javascript:if (window.epx.codeSnippet)window.epx.codeSnippet.copyCode('CodeSnippetContainerCode_0e0bc305-1a79-4fc2-920a-73a076f412fc');" ms.cmptyp="CodeSnippet">Copy</a>
            </div>
        </div>
        <div id="CodeSnippetContainerCode_0e0bc305-1a79-4fc2-920a-73a076f412fc" class="codeSnippetContainerCode" dir="ltr">
            <div style="color:Black;"><pre>string s = "Hello Extension Methods";  
int i = s.WordCount();  

</pre></div>
            
        </div>
    </div>
</div>
<p>In your code you invoke the extension method with instance method syntax. However, the intermediate language (IL) generated by the compiler translates your code into a call on the static method. Therefore, the principle of encapsulation is not really being violated. In fact, extension methods cannot access private variables in the type they are extending.</p>
