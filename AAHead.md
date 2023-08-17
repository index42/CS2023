# head

## Microsoft

C# 程序在 .NET 上运行，而 .NET 是名为公共语言运行时 (CLR) 的虚执行系统和一组类库。 CLR 是 Microsoft 对公共语言基础结构 (CLI) 国际标准的实现。 CLI 是创建执行和开发环境的基础，语言和库可以在其中无缝地协同工作

赋值运算符、null 合并 ?? 和 ??= 运算符和条件运算符 ?: 为右结合运算符，即从右向左执行运算。 例如，x = y = z 将计算为 x = (y = z)。

C# 没有全局变量或方法，这一点其他某些语言不同。 即使是编程的入口点（Main 方法），也必须在类或结构中声明（使用顶级语句时，隐式声明）。

## Async

## Delegate

## Attribute

## Record

C# 9.0

在下列情况下，请考虑使用记录而不是类或结构：

- 你想要定义依赖值相等性的数据模型。
- 你想要定义对象不可变的类型。

声明和实例化类或结构时使用的语法与操作记录时的相同。 只是将 class 关键字替换为 record，或者使用 record struct 而不是 struct。 同样地，记录类支持相同的表示继承关系的语法。

## Interface

在 8.0 以前的 C# 版本中，接口类似于只有抽象成员的抽象基类。 实现接口的类或结构必须实现其所有成员。
从 C# 8.0 开始，接口可以定义其部分或全部成员的默认实现。 实现接口的类或结构不一定要实现具有默认实现的成员。

## Virtual

字段不能是虚拟的，只有方法、属性、事件和索引器才可以是虚拟的。 当派生类重写某个虚拟成员时，即使该派生类的实例被当作基类的实例访问，也会调用该成员。

```c#
public class A
{
    public virtual void DoWork() { }
}
public class B : A
{
    public override void DoWork() { }
}
public class C : B
{
    public sealed override void DoWork() { }
}
public class D : C
{
    public new void DoWork() { }
}
```

如果在 D 中使用类型为 D 的变量调用 DoWork，被调用的将是新的 DoWork。 如果使用类型为 C、B 或 A 的变量访问 D 的实例，对 DoWork 的调用将遵循虚拟继承的规则，即把这些调用传送到类 C 的 DoWork 实现。

## Pattern matching
