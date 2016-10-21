using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net.Http;

public class Program
{
    public static void Main(string[] args)
    {
        prompt().Wait();
    }

    public static async Task prompt(){
        Console.WriteLine(@"
        Hello!
        

        --------

        Please enter a food or beverage to get caloric info:


        ");
        
        string term = Console.ReadLine();

        IJSONAPI mashapi = new MashAPI();
        Nutrition n = await mashapi.GetData<Nutrition>("cheddar cheese", "APIKEY");
        Console.WriteLine(mashapi.ToJSON(n));

        IJSONAPI googAPI = new GoogleAPI();
        Google g = await googAPI.GetData<Google>("tacos", "APIKEY");
        Console.WriteLine(googAPI.ToJSON(g));
    }
}

