using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Things to do: -make key items, -make sellable or not and prices

public class BaseItem
{
    //Information that all items will have. 
    public string Name { get; set; }
    public string Description { get; set; }
    public int ID { get; set; }

    //Default constructor.
    public BaseItem()
    {
        Name = "Not an Item";
        Description = "This item shouldn't exist.";
        ID = 0;
    }

    //Constructor.
    public BaseItem(string name, string description, int id)
    {
        Name = name;
        Description = description;
        ID = id;
    }
}
