//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using TMPro;
//using UnityEngine.UI;

//public class InventorySlot : MonoBehaviour
//{
//    [SerializeField] private TextMeshProUGUI itemNumberText;
//    [SerializeField] private Image itemImage;
//    [SerializeField] private InventoryItem item;
//    [SerializeField] private InventoryManager manager;
//    [SerializeField] private Image selectedSprite;
//    [SerializeField] private bool isSelected;

//    public Image SelectedSprite { get => selectedSprite; set => selectedSprite = value; }
//    public bool IsSelected { get => isSelected; set => isSelected = value; }
//    public InventoryItem Item { get => item; set => item = value; }

//    public void Setup(InventoryItem item, InventoryManager manager)
//    {
//        this.item = item;
//        this.manager = manager;

//        if(item != null)
//        {
//            itemImage.sprite = item.ItemImage;

//            if (item.NumHeld > 1)
//                itemNumberText.text = item.NumHeld.ToString();
//            else
//                itemNumberText.text = "";
//        }
//    }

//    public void ClickedOn()
//    {
//        if (item != null)
//            manager.ChangeSelectedItem(this);
//    }
//}