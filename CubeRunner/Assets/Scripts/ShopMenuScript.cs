using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopMenuScript : MonoBehaviour
{

    
    public Material[] materials;
    //public bool[] solidColorNumbers = new bool[14];
   // public string[] 
    public TextMeshProUGUI moneyText;

    public GameObject player;

    public Renderer playerObject;

    private int selectedMaterial;

    public GameObject solidColor0BuyButton;
    public GameObject solidColor0ChooseButton;

    public GameObject solidColor1BuyButton;
    public GameObject solidColor1ChooseButton;

    public GameObject solidColor2BuyButton;
    public GameObject solidColor2ChooseButton;

    public GameObject solidColor3BuyButton;
    public GameObject solidColor3ChooseButton;

    public GameObject solidColor4BuyButton;
    public GameObject solidColor4ChooseButton;

    public GameObject solidColor5BuyButton;
    public GameObject solidColor5ChooseButton;

    public GameObject solidColor6BuyButton;
    public GameObject solidColor6ChooseButton;

    public GameObject solidColor7BuyButton;
    public GameObject solidColor7ChooseButton;

    public GameObject solidColor8BuyButton;
    public GameObject solidColor8ChooseButton;

    public GameObject solidColor9BuyButton;
    public GameObject solidColor9ChooseButton;

    public GameObject solidColor10BuyButton;
    public GameObject solidColor10ChooseButton;

    public GameObject solidColor11BuyButton;
    public GameObject solidColor11ChooseButton;

    public GameObject solidColor12BuyButton;
    public GameObject solidColor12ChooseButton;

    public GameObject solidColor13BuyButton;
    public GameObject solidColor13ChooseButton;

    public GameObject solidColor14BuyButton;
    public GameObject solidColor14ChooseButton;


    private float updateMoney;


    void Start()
    {
        moneyText.text = PlayerPrefs.GetInt("FinalMoney", 0).ToString();

        player = GameObject.Find("Player");

        selectedMaterial = PlayerPrefs.GetInt("SelectedMaterial",15);
        player.GetComponent<MeshRenderer>().material = materials[selectedMaterial];

    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = PlayerPrefs.GetInt("FinalMoney", 0).ToString();
    }
    

    public void solidColor0BuyFunc()
    {
        if(PlayerPrefs.GetInt("FinalMoney", 0) >= 1000f )
        {


            PlayerPrefs.SetInt("FinalMoney", (PlayerPrefs.GetInt("FinalMoney", 0) - 1000) );
            moneyText.text = PlayerPrefs.GetInt("FinalMoney", 0).ToString();
            solidColor0BuyButton.SetActive(false);//BUNU KONTROL ET YENİDEN BASLADIGINDA YINE SATIN ALMA CIKABILIR
            solidColor0ChooseButton.SetActive(true);

        }
    }

    public void solidColor0ChooseFunc()
    {
        PlayerPrefs.SetInt("SelectedMaterial", 0);
        player.GetComponent<MeshRenderer>().material = materials[0];
    }


    public void solidColor1BuyFunc()
    {
        if (PlayerPrefs.GetInt("FinalMoney", 0) >= 1000f)
        {


            PlayerPrefs.SetInt("FinalMoney", (PlayerPrefs.GetInt("FinalMoney", 0) - 1000));
            moneyText.text = PlayerPrefs.GetInt("FinalMoney", 0).ToString();
            solidColor1BuyButton.SetActive(false);//BUNU KONTROL ET YENİDEN BASLADIGINDA YINE SATIN ALMA CIKABILIR
            solidColor1ChooseButton.SetActive(true);

        }
    }

    public void solidColor1ChooseFunc()
    {
        PlayerPrefs.SetInt("SelectedMaterial", 1);
        player.GetComponent<MeshRenderer>().material = materials[1];
    }

    public void solidColor2BuyFunc()
    {
        if (PlayerPrefs.GetInt("FinalMoney", 0) >= 1000f)
        {

            updateMoney = (PlayerPrefs.GetInt("FinalMoney", 0) - 1000);
            Debug.Log("AZALMIS OLMASI GEREKEN PARA===== "+updateMoney);
            PlayerPrefs.SetInt("FinalMoney", (int)updateMoney);

            Debug.Log("money texte basilan para miktari==!'^=!'^=!"+ PlayerPrefs.GetInt("FinalMoney", 0).ToString());
            moneyText.text = PlayerPrefs.GetInt("FinalMoney", 0).ToString();
            solidColor2BuyButton.SetActive(false);//BUNU KONTROL ET YENİDEN BASLADIGINDA YINE SATIN ALMA CIKABILIR
            solidColor2ChooseButton.SetActive(true);

        }
    }

    public void solidColor2ChooseFunc()
    {
        PlayerPrefs.SetInt("SelectedMaterial", 2);
        player.GetComponent<MeshRenderer>().material = materials[2];
    }

    public void solidColor3BuyFunc()
    {
        if (PlayerPrefs.GetInt("FinalMoney", 0) >= 1000f)
        {


            PlayerPrefs.SetInt("FinalMoney", (PlayerPrefs.GetInt("FinalMoney", 0) - 1000));
            moneyText.text = PlayerPrefs.GetInt("FinalMoney", 0).ToString();
            solidColor3BuyButton.SetActive(false);//BUNU KONTROL ET YENİDEN BASLADIGINDA YINE SATIN ALMA CIKABILIR
            solidColor3ChooseButton.SetActive(true);

        }
    }

    public void solidColor3ChooseFunc()
    {
        PlayerPrefs.SetInt("SelectedMaterial", 3);
        player.GetComponent<MeshRenderer>().material = materials[3];
    }

    public void solidColor4BuyFunc()
    {
        if (PlayerPrefs.GetInt("FinalMoney", 0) >= 1000f)
        {


            PlayerPrefs.SetInt("FinalMoney", (PlayerPrefs.GetInt("FinalMoney", 0) - 1000));
            moneyText.text = PlayerPrefs.GetInt("FinalMoney", 0).ToString();
            solidColor4BuyButton.SetActive(false);//BUNU KONTROL ET YENİDEN BASLADIGINDA YINE SATIN ALMA CIKABILIR
            solidColor4ChooseButton.SetActive(true);

        }
    }

    public void solidColor4ChooseFunc()
    {
        PlayerPrefs.SetInt("SelectedMaterial", 4);
        player.GetComponent<MeshRenderer>().material = materials[4];
    }


    public void solidColor5BuyFunc()
    {
        if (PlayerPrefs.GetInt("FinalMoney", 0) >= 1000f)
        {


            PlayerPrefs.SetInt("FinalMoney", (PlayerPrefs.GetInt("FinalMoney", 0) - 1000));
            moneyText.text = PlayerPrefs.GetInt("FinalMoney", 0).ToString();
            solidColor5BuyButton.SetActive(false);//BUNU KONTROL ET YENİDEN BASLADIGINDA YINE SATIN ALMA CIKABILIR
            solidColor5ChooseButton.SetActive(true);

        }
    }

    public void solidColor5ChooseFunc()
    {
        PlayerPrefs.SetInt("SelectedMaterial", 5);
        player.GetComponent<MeshRenderer>().material = materials[5];
    }

    public void solidColor6BuyFunc()
    {
        if (PlayerPrefs.GetInt("FinalMoney", 0) >= 1000f)
        {


            PlayerPrefs.SetInt("FinalMoney", (PlayerPrefs.GetInt("FinalMoney", 0) - 1000));
            moneyText.text = PlayerPrefs.GetInt("FinalMoney", 0).ToString();
            solidColor6BuyButton.SetActive(false);//BUNU KONTROL ET YENİDEN BASLADIGINDA YINE SATIN ALMA CIKABILIR
            solidColor6ChooseButton.SetActive(true);

        }
    }

    public void solidColor6ChooseFunc()
    {
        PlayerPrefs.SetInt("SelectedMaterial", 6);
        player.GetComponent<MeshRenderer>().material = materials[6];
    }

    public void solidColor7BuyFunc()
    {
        if (PlayerPrefs.GetInt("FinalMoney", 0) >= 1000f)
        {


            PlayerPrefs.SetInt("FinalMoney", (PlayerPrefs.GetInt("FinalMoney", 0) - 1000));
            
            moneyText.text = PlayerPrefs.GetInt("FinalMoney", 0).ToString();
            solidColor7BuyButton.SetActive(false);//BUNU KONTROL ET YENİDEN BASLADIGINDA YINE SATIN ALMA CIKABILIR
            solidColor7ChooseButton.SetActive(true);

        }
    }
    public void solidColor7ChooseFunc()
    {
        PlayerPrefs.SetInt("SelectedMaterial", 7);
        player.GetComponent<MeshRenderer>().material = materials[7];
    }

    public void solidColor8BuyFunc()
    {
        if (PlayerPrefs.GetInt("FinalMoney", 0) >= 1000f)
        {


            PlayerPrefs.SetInt("FinalMoney", (PlayerPrefs.GetInt("FinalMoney", 0) - 1000));
            moneyText.text = PlayerPrefs.GetInt("FinalMoney", 0).ToString();
            solidColor8BuyButton.SetActive(false);//BUNU KONTROL ET YENİDEN BASLADIGINDA YINE SATIN ALMA CIKABILIR
            solidColor8ChooseButton.SetActive(true);

        }
    }

    public void solidColor8ChooseFunc()
    {
        PlayerPrefs.SetInt("SelectedMaterial", 8);
        player.GetComponent<MeshRenderer>().material = materials[8];
    }

    public void solidColor9BuyFunc()
    {
        if (PlayerPrefs.GetInt("FinalMoney", 0) >= 1000f)
        {


            PlayerPrefs.SetInt("FinalMoney", (PlayerPrefs.GetInt("FinalMoney", 0) - 1000));
            moneyText.text = PlayerPrefs.GetInt("FinalMoney", 0).ToString();
            solidColor9BuyButton.SetActive(false);//BUNU KONTROL ET YENİDEN BASLADIGINDA YINE SATIN ALMA CIKABILIR
            solidColor9ChooseButton.SetActive(true);

        }
    }

    public void solidColor9ChooseFunc()
    {
        PlayerPrefs.SetInt("SelectedMaterial", 9);
        player.GetComponent<MeshRenderer>().material = materials[9];
    }

    public void solidColor10BuyFunc()
    {
        if (PlayerPrefs.GetInt("FinalMoney", 0) >= 1000f)
        {


            PlayerPrefs.SetInt("FinalMoney", (PlayerPrefs.GetInt("FinalMoney", 0) - 1000));
            moneyText.text = PlayerPrefs.GetInt("FinalMoney", 0).ToString();
            solidColor10BuyButton.SetActive(false);//BUNU KONTROL ET YENİDEN BASLADIGINDA YINE SATIN ALMA CIKABILIR
            solidColor10ChooseButton.SetActive(true);

        }
    }
    public void solidColor10ChooseFunc()
    {
        PlayerPrefs.SetInt("SelectedMaterial", 10);
        player.GetComponent<MeshRenderer>().material = materials[10];
    }

    public void solidColor11BuyFunc()
    {
        if (PlayerPrefs.GetInt("FinalMoney", 0) >= 1000f)
        {


            PlayerPrefs.SetInt("FinalMoney", (PlayerPrefs.GetInt("FinalMoney", 0) - 1000));
            moneyText.text = PlayerPrefs.GetInt("FinalMoney", 0).ToString();
            solidColor11BuyButton.SetActive(false);//BUNU KONTROL ET YENİDEN BASLADIGINDA YINE SATIN ALMA CIKABILIR
            solidColor11ChooseButton.SetActive(true);

        }
    }

    public void solidColor11ChooseFunc()
    {
        PlayerPrefs.SetInt("SelectedMaterial", 11);
        player.GetComponent<MeshRenderer>().material = materials[11];
    }

    public void solidColor12BuyFunc()
    {
        if (PlayerPrefs.GetInt("FinalMoney", 0) >= 1000f)
        {


            PlayerPrefs.SetInt("FinalMoney", (PlayerPrefs.GetInt("FinalMoney", 0) - 1000));
            moneyText.text = PlayerPrefs.GetInt("FinalMoney", 0).ToString();
            solidColor12BuyButton.SetActive(false);//BUNU KONTROL ET YENİDEN BASLADIGINDA YINE SATIN ALMA CIKABILIR
            solidColor12ChooseButton.SetActive(true);

        }
    }

    public void solidColor12ChooseFunc()
    {
        PlayerPrefs.SetInt("SelectedMaterial", 12);
        player.GetComponent<MeshRenderer>().material = materials[12];
    }

    public void solidColor13BuyFunc()
    {
        if (PlayerPrefs.GetInt("FinalMoney", 0) >= 1000f)
        {


            PlayerPrefs.SetInt("FinalMoney", (PlayerPrefs.GetInt("FinalMoney", 0) - 1000));
            moneyText.text = PlayerPrefs.GetInt("FinalMoney", 0).ToString();
            solidColor13BuyButton.SetActive(false);//BUNU KONTROL ET YENİDEN BASLADIGINDA YINE SATIN ALMA CIKABILIR
            solidColor13ChooseButton.SetActive(true);

        }
    }

    public void solidColor13ChooseFunc()
    {
        PlayerPrefs.SetInt("SelectedMaterial", 13);
        player.GetComponent<MeshRenderer>().material = materials[13];
    }

    public void solidColor14BuyFunc()
    {
        if (PlayerPrefs.GetInt("FinalMoney", 0) >= 1000f)
        {


            PlayerPrefs.SetInt("FinalMoney", (PlayerPrefs.GetInt("FinalMoney", 0) - 1000));
            moneyText.text = PlayerPrefs.GetInt("FinalMoney", 0).ToString();
            solidColor14BuyButton.SetActive(false);//BUNU KONTROL ET YENİDEN BASLADIGINDA YINE SATIN ALMA CIKABILIR
            solidColor14ChooseButton.SetActive(true);

        }
    }

    public void solidColor14ChooseFunc()
    {
        PlayerPrefs.SetInt("SelectedMaterial", 14);
        player.GetComponent<MeshRenderer>().material = materials[14];
    }

}
