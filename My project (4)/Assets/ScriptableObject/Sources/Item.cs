using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Tutorial/Item")]
public class Item : ScriptableObject
{
    public string Name = "Item";
    public Sprite Icon;
    public string status = "status";
}
