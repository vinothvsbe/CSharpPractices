using System;
using System.Collections;
using System.Collections.Generic;
namespace Factory
{
    public abstract class Dosa{
        public ArrayList toppingList = new ArrayList();
        public string DosaBatter { get; set; }
        public void PourBatter(){
            Console.WriteLine($"Pour {DosaBatter}  Batter and expand it");
        }
        public void AddToppings(){
            foreach(var topping in toppingList){
                Console.WriteLine($"Add {topping}");
            }
        } 
        public void Bake(){
            Console.WriteLine("Bake for 2 min each side");
        }
        public void Hold(){
            Console.WriteLine("Hold dosa in normal Form");
        } 
    }

    public class KAStyleMasalaDosa: Dosa{
        public KAStyleMasalaDosa()
        {
            DosaBatter = "Rice";
            toppingList.Add(" Aalu Masala");

        }
        public void Hold(){
            Console.WriteLine("Hold dosa in Cone Form");
        }
    }
    public class KAStylePodiDosa: Dosa{
        public KAStylePodiDosa()
        {
            DosaBatter = "Rice";
            toppingList.Add("Podi");
        }
    }

    public class KAStyleMasalaPodiDosa: Dosa{
        public KAStyleMasalaPodiDosa()
        {
            DosaBatter = "Rice";
            toppingList.Add("Aalu Masala");
            toppingList.Add("Podi");
        }
    }

    public class TNStyleGheeMasalaDosa: Dosa{
        public TNStyleGheeMasalaDosa()
        {
            DosaBatter = "Rice";
            toppingList.Add(" Aalu Masala");
            toppingList.Add("Ghee");

        }
        public void Hold(){
            Console.WriteLine("Hold dosa in Cone Form");
        }
    }

    public class TNStyleGheePodiDosa: Dosa{
        public TNStyleGheePodiDosa()
        {
            DosaBatter = "Rice";
            toppingList.Add("Podi");
            toppingList.Add("Ghee");
        }
        public void Hold(){
            Console.WriteLine("Hold dosa in Cone Form");
        }

    }

    public class KAStore{
        // public Dosa MakeDosa(string dosaStyle){
        //     return new Dosa();
        // }
        public void MakeDosa(string dosaStyle){
        }
    }
    public class DosaFactory
    {
        
    }
}