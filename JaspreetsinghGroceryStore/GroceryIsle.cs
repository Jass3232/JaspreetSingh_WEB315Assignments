using System.Collections.Generic;


public class GroceryIsle
{
    public List<FoodItem> foodlist;
    public string IsleName { get; set; }
    public decimal IsleNumber { get; set; } 

    public GroceryIsle (string IsleName, decimal IsleNumber, List<FoodItem> foodlist)
    {
        this.IsleName = IsleName;
        this.IsleNumber = IsleNumber;
        this.foodlist = foodlist;
    }
}