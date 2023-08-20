// using System.Collections;
// using System.Collections.Generic;
// using TMPro;
// using UnityEngine;
// using UnityEngine.UI;

// /*public class Inventory : MonoBehaviour
// {
//     private OrderManager theOrder;
//     private InventorySlot[] slots;

//     private List<items> inventoryItemList;


//     public TMP_Text Description_Text;

//     public Transform tf; //slot �θ�ü

//     public GameObject go;
//     private int selectedItem; // ���õ� ������

//     private bool activated; // �κ� Ȱ��ȭ true
//     private bool itemActivated; //������ Ȱ��ȭ true 
//     private bool stopKeyInput; //Ű�Է� ����. 
//     private bool preventExec; //�ߺ����� ���� . 

//     private WaitForSeconds waitTime = new WaitForSeconds(0.01f);


//     // Start is called before the first frame update
//     void Start()
//     {
//         theOrder = FindObjectOfType<OrderManager>();
//         inventoryItemList = new List<items>();
//         slots = tf.GetComponentsInChildren<InventorySlot>();

//     }

//     public void ShowItem()
//     {
//         for (int i = 0; i < inventoryItemList.Count; i++)
//         {
//             slots[i].gameObject.SetActive(true);
//             slots[i].Additem(inventoryItemList[i]);

//             SelectedItem();
//         }
//     }
//     public void SelectedItem()
//     {
//         if (inventoryItemList.Count > 0)
//         {
//             Description_Text.text = inventoryItemList[selectedItem].itemDescription;
//         }
//         else
//         {
//             Description_Text.text = "�������� �����ϰ� ���� �ʽ��ϴ�."
//         }
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         if (!stopKeyInput)
//         {
//             if (Input.GetKeyDown(KeyCode.E))
//             {
//                 activated = !activated;

//                 if (activated)
//                 {
//                     theOrder.NotMove();
//                     go.SetActive(true);
//                     itemActivated = false;

//                 }
//                 else
//                 {

//                 }
//             }
//         }
//     }
// }*/
