using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Info", menuName = "Device/New Info")]
public class Info : ScriptableObject
{
    [SerializeField] private string _id;
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Sprite _QRIcon;
    public string id =>this._id;
    public GameObject prefab =>this._prefab;
    public Sprite QRIcon => this._QRIcon;
}
