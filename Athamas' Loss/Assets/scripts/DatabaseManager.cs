using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseManager : MonoBehaviour
{
    static public DatabaseManager instance;

    // Start is called before the first frame update
    private void Awake()
    {
        if(instance == null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
            instance = this;
        }
    }

    public string[] var_name;
    public float[] var;

    public string[] switch_name;
    public bool[] switches;


    public List<items>itemList = new List<items>();

   void Start()
    {
        itemList.Add(new items(10001, "¼öÃ¸", "³»°¡ ¾²´ø ¼öÃ¸ÀÌ´Ù.", items.ItemType.Use));
    }
}
