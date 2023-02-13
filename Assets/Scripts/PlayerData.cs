using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerData : MonoBehaviour
{
    public static Color playerColor = Color.cyan;
    public static int playerSize = 1;
    public static int playerSpeed = 10;


    [SerializeField] private GameObject player;
    [SerializeField] private TMP_Dropdown colorDropdown;
    //[SerializeField] private Button sizeButton;
    [SerializeField] private Slider speedSlider;
    //[SerializeField] private TextMeshProUGUI sizeText;
    //[SerializeField] private TextMeshProUGUI speedText;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
    public void SetColor()
    {
        switch (colorDropdown.value)
        {
            case 0:
                player.GetComponent<Renderer>().material.color = Color.cyan;
                playerColor = Color.cyan;
                break;
            case 1:
                player.GetComponent<Renderer>().material.color = Color.red;
                playerColor = Color.red;
                break;
            case 2:
                player.GetComponent<Renderer>().material.color = Color.blue;
                playerColor = Color.blue;
                break;
            case 3:
                player.GetComponent<Renderer>().material.color = Color.yellow;
                playerColor = Color.yellow;
                break;
            case 4:
                player.GetComponent<Renderer>().material.color = Color.black;
                playerColor = Color.black;
                break;
            case 5:
                player.GetComponent<Renderer>().material.color = Color.white;
                playerColor = Color.white;
                break;
        }
    }
    public void SetSize()
    {
        //player.transform.localScale = new Vector3(sizeSlider.value, sizeSlider.value, sizeSlider.value);
        //sizeText.text = "Size " + sizeSlider.value.ToString();
        //playerSize = (int)sizeSlider.value;
        playerSize++;
        if (playerSize > 5)
        {
            playerSize = 1;
        }
        player.transform.localScale = new Vector3(playerSize, playerSize, playerSize);
        //sizeText.text = "Size " + playerSize;
    }
    public void SetSpeed()
    {
        playerSpeed = (int)speedSlider.value;
        //speedText.text = "Speed " + speedSlider.value.ToString();
        //playerSpeed = ;
    }
}
