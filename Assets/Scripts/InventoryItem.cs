using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "New Item", menuName = "My Assets/Inventory/Item")]
public class InventoryItem : ScriptableObject
{
    [SerializeField] private string itemName;
    [SerializeField] private string itemDescription;
    [SerializeField] private Sprite itemImage;
    [SerializeField] private int numHeld;
    [SerializeField] private bool usable;
    [SerializeField] private bool unique;
    [SerializeField] private UnityEvent thisEvent;

    public Sprite ItemImage { get => itemImage; set => itemImage = value; }
    public int NumHeld { get => numHeld; set => numHeld = value; }
    public string ItemDescription { get => itemDescription; set => itemDescription = value; }
    public bool Usable { get => usable; set => usable = value; }

    public void Use()
    {
        Debug.Log("Using Item");
        thisEvent.Invoke();
    }
}