using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    //private TextMeshProUGUI itemText;

    public GameObject pauseMenu;
    public GameObject winscreen;
    public GameObject losescreen;
    public GameObject settings;
    
    public GameObject ingameUI;
    
    public TextMeshProUGUI itemText;





    // Start is called before the first frame update
    void Start()
    {
       // itemText = GetComponent<TextMeshProUGUI>();
       
    }

    void Update()
    {
        if (check())
        {
            ingameUI.SetActive(false);
        }
    }

    public void UpdateItemText(PlayerInventory playerInventory)
    {
        itemText.text = "Games gefunden: " + playerInventory.NumberOfGames.ToString() + "/" + playerInventory.maxGames.ToString();
    }

    private bool check()
    {
        
        if( winscreen.activeSelf | losescreen.activeSelf | settings.activeSelf)
        {
            return true;
        }
        else
        {
            return false;
        }
       
       
    }
 
}