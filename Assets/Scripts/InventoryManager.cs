//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using TMPro;

//public class InventoryManager : MonoBehaviour
//{
//    [SerializeField] private PlayerInventory playerInventory;
//    [SerializeField] private GameObject inventorySlotPrefab;
//    [SerializeField] private GameObject scrollViewContent;
//    [SerializeField] private TextMeshProUGUI description;
//    [SerializeField] private GameObject useButton;

//    private InventoryItem selectedItem;
//    private List<InventorySlot> slots = new List<InventorySlot>();
//    private int selectedIndex = 0;

//    public void SetTextAndButton(string description, bool buttonActive)
//    {
//        this.description.text = description;
//        useButton.SetActive(buttonActive);
//    }

//    private void MakeInventorySlots()
//    {
//        if(playerInventory != null)
//        {
//            foreach(InventoryItem item in playerInventory.Inventory)
//            {
//                InventorySlot slot = Instantiate(inventorySlotPrefab).GetComponent<InventorySlot>();
//                slot.transform.SetParent(scrollViewContent.transform);
//                slot.Setup(item, this);

//                slots.Add(slot);
//            }
//        }
//    }

//    void Start()
//    {
//        MakeInventorySlots();
//        SetTextAndButton("", false);
//    }
   
//    void Update()
//    {
//        if (Input.GetKeyDown(KeyCode.RightArrow))
//        {
//            if (selectedIndex < slots.Count - 1)
//            {
//                selectedIndex++;
//                ChangeSelectedItem(slots[selectedIndex]);
//            }
//        }
//        else if (Input.GetKeyDown(KeyCode.LeftArrow))
//        {
//            if (selectedIndex > 0)
//            {
//                selectedIndex--;
//                ChangeSelectedItem(slots[selectedIndex]);
//            }
//        }                
//    }

//    public void ChangeSelectedItem(InventorySlot slot)
//    {
//        for (int i = 0; i < slots.Count; i++)
//        {
//            if (slots[i] != slot)
//            {
//                slots[i].IsSelected = false;
//                slots[i].SelectedSprite.enabled = false;
//            }
//            else
//            {
//                selectedIndex = i;
//                slots[i].IsSelected = true;
//                slots[i].SelectedSprite.enabled = true;
//            }
//        }

//        SetupDescription(slot.Item);
//    }

//    private void SetupDescription(InventoryItem item)
//    {
//        selectedItem = item;
//        this.description.text = item.ItemDescription;
//        useButton.SetActive(item.Usable);
//    }

//    public void Use()
//    {
//        if(selectedItem != null)
//        {
//            selectedItem.Use();
//        }
//    }
//}