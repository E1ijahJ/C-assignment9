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

    [Fact]
    public void TestingEnum()
    {
        Except except = new Except();
        IEnum ienum = new IEnum();
        try{
            foreach(var amount in ienum){
                Console.WriteLine(amount);
            }
        }catch(Except ex){
            Console.WriteLine($"Exception found: {ex.Message}");
        }

    }
}
