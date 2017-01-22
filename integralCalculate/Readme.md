# Integral Calculator


<p align="center">
<img src="http://www.athens.kiev.ua/wordpress/wp-content/uploads/2011/11/20111113_682px_integral_as_region_under_curvesvg_.png">
</p>


<p>In <a href="https://en.wikipedia.org/wiki/Mathematics" title="Mathematics">mathematics</a>, an <b>integral</b> assigns numbers to functions in a way that can describe displacement, area, volume, and other concepts that arise by combining infinitesimal data. Integration is one of the two main operations of <a href="https://en.wikipedia.org/wiki/Calculus" title="Calculus">calculus</a>, with its inverse, <a href="https://en.wikipedia.org/wiki/Derivative" title="Derivative">differentiation</a>, being the other. Given a <a href="https://en.wikipedia.org/wiki/Function_(mathematics)" title="Function (mathematics)">function</a> <span class="texhtml mvar" style="font-style:italic;">f</span> of a <a href="https://en.wikipedia.org/wiki/Real_number" title="Real number">real</a> <a href="https://en.wikipedia.org/wiki/Variable_(mathematics)" title="Variable (mathematics)">variable</a> <span class="texhtml mvar" style="font-style:italic;">x</span> and an <a href="https://en.wikipedia.org/wiki/Interval_(mathematics)" title="Interval (mathematics)">interval</a> <span class="texhtml">[<i>a</i>, <i>b</i>]</span> of the <a href="https://en.wikipedia.org/wiki/Real_line" title="Real line">real line</a>, the <b>definite integral</b></p>
<dl>
<dd><span><span class="mwe-math-mathml-inline mwe-math-mathml-a11y mw-math-element" style="display: none;"><math xmlns="http://www.w3.org/1998/Math/MathML">
 
</math></span>
<p align="center">
<img src="https://wikimedia.org/api/rest_v1/media/math/render/svg/a4068c79e03c7e4adf85013ac6f11661389523c5" class="mwe-math-fallback-image-inline mw-math-element" aria-hidden="true" style="vertical-align: -2.338ex; width:10.833ex; height:6.343ex;" alt="\int _{a}^{b}\!f(x)\,dx">
</p></span></dd>
</dl>
<p>is defined informally as the signed <a href="https://en.wikipedia.org/wiki/Area_(geometry)" class="mw-redirect" title="Area (geometry)">area</a> of the region in the <span class="texhtml mvar" style="font-style:italic;">xy</span>-plane that is bounded by the <a href="https://en.wikipedia.org/wiki/Graph_of_a_function" title="Graph of a function">graph</a> of <span class="texhtml mvar" style="font-style:italic;">f</span>, the <span class="texhtml mvar" style="font-style:italic;">x</span>-axis and the vertical lines <span class="texhtml"><i>x</i> = <i>a</i></span> and <span class="texhtml"><i>x</i> = <i>b</i></span>. The area above the <span class="texhtml mvar" style="font-style:italic;">x</span>-axis adds to the total and that below the <span class="texhtml mvar" style="font-style:italic;">x</span>-axis subtracts from the total.</p>


```C#
 public static double integrate(double start, double end, int degreeFreedomT, int degreeFreedomE)
{
    int iterations = 100000;
    double x, dist, sum = 0, sumT = 0;
    dist = (end - start) / iterations;
    for (int i = 1; i <= iterations; i++)
    {
        x = start + i * dist;
        sumT += integralFunction(x - dist / 2, degreeFreedomT, degreeFreedomE);
        if (i < iterations)
        {
            sum += integralFunction(x, degreeFreedomT, degreeFreedomE);
        }
    }
    sum = (dist / 6) * (integralFunction(start, degreeFreedomT, degreeFreedomE) + 
    integralFunction(end, degreeFreedomT, degreeFreedomE) + 2 * sum + 4 * sumT);
    return sum;
}

```








<p>Roughly speaking, the operation of integration is the reverse of differentiation. For this reason, the term <i>integral</i> may also refer to the related notion of the <a href="https://en.wikipedia.org/wiki/Antiderivative" title="Antiderivative">antiderivative</a>, a function <span class="texhtml mvar" style="font-style:italic;">F</span> whose <a href="https://en.wikipedia.org/wiki/Derivative" title="Derivative">derivative</a> is the given function <span class="texhtml mvar" style="font-style:italic;">f</span>. In this case, it is called an <i><a href="https://en.wikipedia.org/wiki/Indefinite_integral" class="mw-redirect" title="Indefinite integral">indefinite integral</a></i> and is written:</p>
<dl>
<dd><span><span class="mwe-math-mathml-inline mwe-math-mathml-a11y mw-math-element" style="display: none;"><math xmlns="http://www.w3.org/1998/Math/MathML">
  
</math></span>
<p align="center">
<img src="https://wikimedia.org/api/rest_v1/media/math/render/svg/d18cda981a68bc3565b1a72eb15c618824f6a045" class="mwe-math-fallback-image-inline mw-math-element" aria-hidden="true" style="vertical-align: -2.338ex; width:18.692ex; height:5.843ex;" alt="F(x)=\int f(x)\,dx."></p></span></dd>
</dl>
<p>The integrals discussed in this article are those termed <i>definite integrals</i>. It is the <a href="https://en.wikipedia.org/wiki/Fundamental_theorem_of_calculus" title="Fundamental theorem of calculus">fundamental theorem of calculus</a> that connects differentiation with the definite integral: if <span class="texhtml mvar" style="font-style:italic;">f</span> is a continuous real-valued function defined on a <a href="https://en.wikipedia.org/wiki/Closed_interval" class="mw-redirect" title="Closed interval">closed interval</a> <span class="texhtml">[<i>a</i>, <i>b</i>]</span>, then, once an antiderivative <span class="texhtml mvar" style="font-style:italic;">F</span> of <span class="texhtml mvar" style="font-style:italic;">f</span> is known, the definite integral of <span class="texhtml mvar" style="font-style:italic;">f</span> over that interval is given by</p>
<dl>
<dd><span><span class="mwe-math-mathml-inline mwe-math-mathml-a11y mw-math-element" style="display: none;"><math xmlns="http://www.w3.org/1998/Math/MathML">
 
 
</math></span>
<p align="center">
<img src="https://wikimedia.org/api/rest_v1/media/math/render/svg/4adf00a8a26fd6b9d052e81607ea15c2af9d6122" class="mwe-math-fallback-image-inline mw-math-element" aria-hidden="true" style="vertical-align: -2.338ex; width:26.861ex; height:6.343ex;" alt="\int _{a}^{b}\!f(x)\,dx=F(b)-F(a)."></p></span></dd>
</dl>


### <a href="https://en.wikipedia.org/wiki/Integral">Learn more to integral in this</a>
