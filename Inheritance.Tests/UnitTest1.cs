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
    [Fact]
    public void Quarter_BasicFunctionality()
    {
        
        Assert.Equal(new Quarter(0.1), new Quarter(0.2)); 
        Assert.Equal(new Quarter(0.3), new Quarter(0.4)); 
        Assert.Equal(new Quarter(0.6), new Quarter(0.7)); 
        Assert.Equal(new Quarter(0.8), new Quarter(0.9)); 

        
        Assert.True(new Quarter(0.1) < new Quarter(0.3)); 
        Assert.True(new Quarter(0.5) < new Quarter(0.75));

    
        Assert.Throws<ArgumentOutOfRangeException>(() => new Quarter(-0.1)); 
        Assert.Throws<ArgumentOutOfRangeException>(() => new Quarter(1.1)); 
    }
}
