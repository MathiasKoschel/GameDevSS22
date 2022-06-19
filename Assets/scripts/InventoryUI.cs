using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    

    public GameObject pauseMenu;
    public GameObject winscreen;
    public GameObject losescreen;
    public GameObject settings;
    
    public GameObject ingameUI;
    
    public TextMeshProUGUI itemText;
    public TextMeshProUGUI anweisungText;

    private string anweisung = "Search the missing CDs";


    void Awake()
    {
        anweisungText.text = anweisung;
    }


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
        itemText.text = "Games found: " + playerInventory.NumberOfGames.ToString() + "/" + playerInventory.maxGames.ToString();

        if (playerInventory.NumberOfGames < playerInventory.maxGames)
        {
            anweisungText.text = "Search the missing CDs";
        }else if (playerInventory.NumberOfGames >= playerInventory.maxGames)
        {
            anweisungText.text = "Get out and escape!";
        }
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