# Virtual override

<p align="center">
<img src="https://i.gyazo.com/4e1fe4ee9d4862c5c2f06e93353d1ed0.png">
</p>

```c#
            BaseClass Base = new BaseClass();
            BaseClass BaseDir = new DeravedClass();
            DeravedClass Der = new DeravedClass();
            
```
1.[BaseClass](https://github.com/VanHakobyan/ProjectsGroup/blob/master/virtual%20override/virtual%20override/BaseClass.cs)<br>
2.[DeravedClass](https://github.com/VanHakobyan/ProjectsGroup/blob/master/virtual%20override/virtual%20override/DiravedClass.cs)<br>
```c#
            Base.method1();
            Base.method2();
            Base.method3();
            Base.method4();
            Base.method5();
```
![image](https://i.gyazo.com/36a8045d8d28f1826e3bbbc12a75731c.png)

```c#
            BaseDir.method1();
            BaseDir.method2();
            BaseDir.method3();
            BaseDir.method4();
            BaseDir.method5();
```
![image](https://i.gyazo.com/5fdf570e33fe5c35a98ace90fc836cd5.png)
```c#
            Der.method1();
            Der.method2();
            Der.method3();
            Der.method4();
            Der.method5();
```
![image](https://i.gyazo.com/d2414668c4b619c03b4db5b22edf7f6f.png)


