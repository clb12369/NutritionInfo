using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;
using System.Text;

internal static class Extensions {
    public static void PrintTable(this Nutrition n){
        Console.WriteLine("Here are the first 10 of {0} total hits", n.total_hits);
        for(int i = 0; i < 10; i++){
            Console.WriteLine(@"
        Brand name  {0}
        Item name   {1}
        Serving     {2} {3}
        Calories    {4} calories
        Total fat   {5} grams
            ", n.hits[i].fields.brand_name, 
            n.hits[i].fields.item_name, 
            n.hits[i].fields.nf_serving_size_qty, 
            n.hits[0].fields.nf_serving_size_unit, 
            n.hits[0].fields.nf_calories,
            n.hits[i].fields.nf_total_fat);
            }        
        Console.WriteLine("------------------------------------------------");
    }

    public static void writeToCSV(this Nutrition n){
        var csvPath = "./nutrition.csv";
        StringBuilder sb = new StringBuilder();
        foreach (var hit in n.hits){
            sb.AppendLine($"{hit._id}, {hit.fields.item_name}, {hit.fields.brand_name}, {hit.fields.nf_serving_size_unit}, {hit.fields.nf_serving_size_qty}, {hit.fields.nf_calories}, {hit.fields.nf_total_fat}"); 
        }
        string outString = sb.ToString();
        //return outString;
        
        File.WriteAllText(csvPath, outString);
    }

        public static void appendToCSV(this Nutrition n){
        var csvPath = "./nutrition.csv";
        StringBuilder sb = new StringBuilder();
        foreach (var hit in n.hits){
            sb.AppendLine($"{hit._id}, {hit.fields.item_name}, {hit.fields.brand_name}, {hit.fields.nf_serving_size_unit}, {hit.fields.nf_serving_size_qty}, {hit.fields.nf_calories}, {hit.fields.nf_total_fat}"); 
        }
        string outString = sb.ToString();
        //return outString;
        
        File.AppendAllText(csvPath, outString);
    }


}