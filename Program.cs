using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;
using System.Text;

public class Program
{
    //Queue<Nutrition> nutritionQueue = new Queue<Nutrition>();
    public static void Main(string[] args)

    {
        
        prompt().Wait();

    }

    public static async Task prompt(){
        int numberOfSearches = 0;
        var mashapekey = "VcnksoTS3mmshx6wy6MuBnyy33Qap1W2tAUjsnJaUbEN0tYfzk";
        //Queue<Nutrition> nutritionQueue = new Queue<Nutrition>();
        if (numberOfSearches == 0){
            Console.WriteLine(@"
        Hello!
        

        --------

        Please enter a food or beverage to get caloric info:


            ");
        } else {
            Console.WriteLine("Would you like to perform another search? (y/n)");
            string answer = Console.ReadLine().ToLower();
            if(answer == "n" || answer == ""){
                Environment.Exit(0);
            }
        }
        string term = Console.ReadLine();
        Console.WriteLine("You searched the following term: {0}", term);

        IJSONAPI mashapi = new MashapeAPI();
        Nutrition n = await mashapi.GetData<Nutrition>(term, mashapekey);
        //string outputString = mashapi.ToJSON(n);
        n.PrintTable();
        if (numberOfSearches == 0){
            n.writeToCSV();
        } else {
            n.appendToCSV();
        }
        
        numberOfSearches++;
                
    }

}

