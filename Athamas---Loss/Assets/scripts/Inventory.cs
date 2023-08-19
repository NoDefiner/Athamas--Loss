using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/*public class Inventory : MonoBehaviour
{
    private OrderManager theOrder;
    private InventorySlot[] slots;

    private List<items> inventoryItemList;


    public TMP_Text Description_Text;

    public Transform tf; //slot 부모객체

    public GameObject go;
    private int selectedItem; // 선택된 아이템

    private bool activated; // 인벤 활성화 true
    private bool itemActivated; //아이템 활성화 true 
    private bool stopKeyInput; //키입력 제한. 
    private bool preventExec; //중복실행 제한 . 

    private WaitForSeconds waitTime = new WaitForSeconds(0.01f);


    // Start is called before the first frame update
    void Start()
    {
        theOrder = FindObjectOfType<OrderManager>();
        inventoryItemList = new List<items>();
        slots = tf.GetComponentsInChildren<InventorySlot>();

    }

    public void ShowItem()
    {
        for (int i = 0; i < inventoryItemList.Count; i++)
        {
            slots[i].gameObject.SetActive(true);
            slots[i].Additem(inventoryItemList[i]);

            SelectedItem();
        }
    }
    public void SelectedItem()
    {
        if (inventoryItemList.Count > 0)
        {
            Description_Text.text = inventoryItemList[selectedItem].itemDescription;
        }
        else
        {
            Description_Text.text = "아이템을 소유하고 있지 않습니다."
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!stopKeyInput)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                activated = !activated;

                if (activated)
                {
                    theOrder.NotMove();
                    go.SetActive(true);
                    itemActivated = false;

                }
                else
                {

                }
            }
        }
    }
}*/
