using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyCounter : MonoBehaviour
{
    public GameObject player;
    public PlayerController playerScript;

    public TextMeshProUGUI MoneyText;
    private float totalMoney=0;
    private bool isMoving = true;


    void Start()
    {
        player = GameObject.Find("Player");
        playerScript = player.GetComponent<PlayerController>();
        /*MoneyText.text = PlayerPrefs.GetInt("FinalMoney", 0).ToString();
        Debug.Log("SAVE EDILMIS PARAMIZ=" + PlayerPrefs.GetInt("FinalMoney", 0).ToString());*/
    }

    // Update is called once per frame
    void Update()
    {
        /*if (playerScript.speed != 0f)
        {
            totalMoney = PlayerPrefs.GetInt("FinalMoney", 0) + (int)playerScript.money;
        }

        if (playerScript.speed == 0f)
        {
            Debug.Log("Para gelmeyi biraktı şuana kadarki toplam para= " + totalMoney);
            PlayerPrefs.SetInt("FinalMoney", (int)totalMoney);
            isMoving = false;
        }
        MoneyText.text = totalMoney.ToString("0");*/
    }
}
