using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisplayData : MonoBehaviour
{
    private GameObject player;
    [SerializeField] private Slider speedSlider;
    [SerializeField] private TextMeshProUGUI sizeText;
    [SerializeField] private TextMeshProUGUI speedText;

    void Start()
    {
        player = this.gameObject;
        player.GetComponent<Renderer>().material.color = PlayerData.playerColor;
        player.transform.localScale = new Vector3(PlayerData.playerSize, PlayerData.playerSize, PlayerData.playerSize);
        speedSlider.value = PlayerData.playerSpeed;
        sizeText.text = "Size " + PlayerData.playerSize;
        speedText.text = "Speed " + speedSlider.value.ToString();
    }

    private void Update()
    {
        speedSlider.value = PlayerData.playerSpeed;
        sizeText.text = "Size " + PlayerData.playerSize;
        speedText.text = "Speed " + speedSlider.value.ToString();
    }
}
