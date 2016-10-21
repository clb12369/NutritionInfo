using Xunit;

public class SimpleTests {

    public void TestingAdd() => 
        Assert.Equal(10, Calculator.Add(5,5));

    public void TestingAdd2() =>
        Assert.Equal(16, Calculator.Add(5,11));

    /*
        other Assert methods:
            Equal(a,b)
            True(a)
            False(a)
    */

    public void CreateNutrition(){
        Nutrition n = new Nutrition();
        Assert.Equal(n.total_hits, 0);
    }

    public void getAPIUrl(){
        MashapeAPI m = new MashapeAPI();
        Assert.True(m.urlFormat("TACOS") != "");
    }
         
}