using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private GameObject player;
    private Rigidbody playerRB;
    private float speed;
    private int score;

    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject winTextObject;

    // Start is called before the first frame update
    void Start()
    {
        player = this.gameObject;
        player.GetComponent<Renderer>().material.color = PlayerData.playerColor;
        player.transform.localScale = new Vector3(PlayerData.playerSize, PlayerData.playerSize, PlayerData.playerSize);
        speed = PlayerData.playerSpeed;
        playerRB = GetComponent<Rigidbody>();
        score = 0;
        DisplayScore();
    }

    void FixedUpdate()
    {
        //playerRB.AddForce(0, 0, Speed * Time.deltaTime);
        if (Input.GetKey("w"))
        {
            playerRB.AddForce(0, 0, speed * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            playerRB.AddForce(0, 0, -speed * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            playerRB.AddForce(speed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            playerRB.AddForce(-speed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }

    void DisplayScore()
    {
        scoreText.text = "Score " + score.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            score++;
            DisplayScore();
            if (score == 8)
            {
                winTextObject.SetActive(true);
                FindObjectOfType<GameManager>().NextLevel();
            }
        }
    }
}