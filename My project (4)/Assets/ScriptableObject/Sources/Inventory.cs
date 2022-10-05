using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] List<Item> StartItems = new List<Item>();
    List<Item> inventoryItems = new List<Item>();
    internal object InventoryItems;

    // Start is called before the first frame update
    void Start()
    {
        for (var i = 0; i < StartItems.Count; i++)
            AddItem(StartItems[i]);
    }

    void Update()
    {

    }

    public void AddItem(Item item)
    {
        inventoryItems.Add(item);
    }

    // Update is called once per frame
  
}
