using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net.Http;

public class SimpleTests {

    // public void TestingAdd() => 
    //     Assert.Equal(10, Calculator.Add(5,5));

    // public void TestingAdd2() =>
    //     Assert.Equal(16, Calculator.Add(5,11));

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
        Assert.True(m.urlFormat("celery") != "");
    }

    // public void getDataTest(){
    //     IJSONAPI m = new MashapeAPI();
    //     Nutrition n = m.GetData<Nutrition>("celery", "VcnksoTS3mmshx6wy6MuBnyy33Qap1W2tAUjsnJaUbEN0tYfzk");
    //     Assert.True(n.total_hits != 0);
    // }

    // public void getJSONData(){

    // }
         
}