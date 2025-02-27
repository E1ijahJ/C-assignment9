namespace Inheritance.Tests;

public class UnitTest1
{
    [Fact]
    public void TestingExcept()
    {
        Except except = new Except();
        int x= 5;
        if(x==5){
            throw new Except("This is not right sir x needs to be a different number");
        }

    }
}
