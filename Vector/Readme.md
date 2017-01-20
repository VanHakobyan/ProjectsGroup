# Vector +,-,* overloading

<p align="center">
<img src="http://mathinsight.org/media/image/image/vector_parallelogram_law.png">
</p>
<br>

<p>A <b>vector space</b> (also called a <b>linear space</b>) is a collection of objects called <b>vectors</b>, which may be 
<a href="/wiki/Vector_addition" class="mw-redirect" title="Vector addition">added</a> together and 
<a href="/wiki/Scalar_multiplication" title="Scalar multiplication">multiplied</a> ("scaled") by numbers, called <i>
<a href="/wiki/Scalar_(mathematics)" title="Scalar (mathematics)">scalars</a></i> in this context. Scalars are often taken to be 
<a href="/wiki/Real_number" title="Real number">real numbers</a>, but there are also vector spaces with scalar multiplication by 
<a href="/wiki/Complex_number" title="Complex number">complex numbers</a>, 
<a href="/wiki/Rational_number" title="Rational number">rational numbers</a>, or generally any 
<a href="/wiki/Field_(mathematics)" title="Field (mathematics)">field</a>. The operations of vector addition and scalar multiplication must satisfy certain requirements, called <i>
<a href="/wiki/Axiom" title="Axiom">axioms</a></i>, listed <a href="#Definition">below</a>.</p>
<p><a href="/wiki/Euclidean_vector" title="Euclidean vector">Euclidean vectors</a> are an example of a vector space. They represent <a href="/wiki/Physics" title="Physics">physical</a> quantities such as <a href="/wiki/Force" title="Force">forces</a>: any two forces (of the same type) can be added to yield a third, and the multiplication of a <a href="/wiki/Force_vector" class="mw-redirect" title="Force vector">force vector</a> by a real multiplier is another force vector. In the same vein, but in a more <a href="/wiki/Geometry" title="Geometry">geometric</a> sense, vectors representing displacements in the plane or in <a href="/wiki/Three-dimensional_space" title="Three-dimensional space">three-dimensional space</a> also form vector spaces. Vectors in vector spaces do not necessarily have to be arrow-like objects as they appear in the mentioned examples: vectors are regarded as abstract mathematical objects with particular properties, which in some cases can be visualized as arrows.</p>

```c#
public vector(vector v1,vector v2)
{
    this.v1.p1 = v1.p1;
    this.v1.p2 = v1.p2;
    this.v2.p1 = v2.p1;
    this.v2.p2 = v2.p2;


}

public vector(int v, int v3)
{
    this.v = v;
    this.v3 = v3;
}

public static vector operator +(vector vector1, vector vector2)
{
        return new vector(vector1.v1, vector2.v2);
}
        ```

#### <a href="https://en.wikipedia.org/wiki/Vector" title="Axiom">For more in vectors </a>
