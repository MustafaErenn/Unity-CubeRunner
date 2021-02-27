using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public int playSceneIndex = 1;
    public Rigidbody rb;
    public float speed = 20f;
    private float jumpHeight = 8f;
    public GameObject player;
    private bool isLittle = false;

    public Swipe swipeController;

    public bool isGrounded = false;

    private bool canMove ;

    public GameObject canvasNextLevel;

    public GameObject nextLevelPanel;
    public GameObject finishText;
    public GameObject nextLevelButtonu;


    public GameObject restartPanel;
    public GameObject restartText;
    public GameObject restartButton;
    public GameObject ShopButton;

    public GameObject shopMenuCanvas;

    public TextMeshProUGUI MoneyText;

    public GameObject levelFailedPanel;
    public GameObject levelCompletePanel;
    public GameObject rewardedAdPanel;

    public float money=0;

    public float doubleMoneyForAd=0;

    public TextMeshProUGUI EarnedMoney;
    public TextMeshProUGUI DoubleEarnedMoney;

    bool isLevelCompletedBool = false;

    private int gecisReklamiSayisiArtirici=1;

    public ReklamManager reklamManagerScript;

    Animator animator;




    void Start()
    {
        PlayerPrefs.GetInt("numberForGecisReklami", 0).ToString();
        animator = GetComponent<Animator>();

        rb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        canMove = true;

        reklamManagerScript = gameObject.GetComponent<ReklamManager>();

        //reklamManagerScript.Start();
        reklamManagerScript.hello();

        reklamManagerScript.BannerReklam();

        reklamManagerScript.GecisReklam();


        //MoneyText.text=PlayerPrefs.GetInt("FinalMoney", 0).ToString();

    }
    IEnumerator timer()
    {
       // isLittle = true;
        yield return new WaitForSeconds(1);
        player.transform.localScale = new Vector3(player.transform.localScale.x, 1f, player.transform.localScale.z);
        player.transform.position = new Vector3(player.transform.position.x, 1f, player.transform.position.z);
       // isLittle = false;
        Debug.Log("isLittle= " + isLittle);
    }
    // Update is called once per frame
    void Update()
    {
        //MoneyText.text=PlayerPrefs.GetInt("FinalMoney", 0).ToString();

        isLittle = false;
        //Debug.Log("canMove = " + canMove);

        Vector3 rightLine = new Vector3(4f, transform.position.y, transform.position.z);
        Vector3 leftLine = new Vector3(-4f, transform.position.y, transform.position.z);
        rb.transform.Translate(Vector3.forward * speed * Time.deltaTime);



        if (swipeController.SwipeRight && canMove)
        {
            //transform.position = Vector3.Lerp(transform.position, rightLine, 80 * Time.deltaTime);
            /*if (transform.position.x > (-0.5f) && transform.position.x < (0.5f))
            {
                Debug.Log("ORTADAN SAGA GITMEK");
                animator.Play("0danSagaGitme");

            }
            else if (transform.position.x < (-3.5f))
            {
                Debug.Log("SOLDAN SAGA GIDIYORUZ");
                animator.Play("soldanSagaGitme");
            }*/
            transform.position = Vector3.Lerp(transform.position, (transform.position + new Vector3(4f, 0, 0)), Time.deltaTime * 160);
            

            
                

        }

        if (swipeController.SwipeLeft && canMove)
        {
            //transform.position = Vector3.Lerp(transform.position, leftLine, 80 * Time.deltaTime);
            /*if ((transform.position.x > (-0.5f)) && (transform.position.x < (0.5f)))
            {
                Debug.Log("ORTADAN SOLA GITMEK");
                animator.Play("0danSolaGitme");

            }
            else if (transform.position.x > (3.5f))
            {
                Debug.Log("SAGDAN SOLA GIDIYORUZ");
                animator.Play("sagdanSolaGitme");
            }*/
            transform.position = Vector3.Lerp(transform.position, (transform.position + new Vector3(-4f, 0, 0)), Time.deltaTime * 160);
            
            
            

        }
        if (swipeController.SwipeUp && isGrounded == true & canMove)
        {
            rb.AddForce(0, jumpHeight, 0, ForceMode.Impulse);
        }
        if (swipeController.SwipeDown && isLittle == false && canMove)
        {

            if (isLittle == false)
            {
                player.transform.localScale = new Vector3(player.transform.localScale.x, 0.5f, player.transform.localScale.z);
                player.transform.position = new Vector3(player.transform.position.x, 0.5f, player.transform.position.z);

            }
            StartCoroutine(timer());
            Debug.Log("Timer doldu");
            /*if(isLittle==true)
            {
                Debug.Log("büyü artık");
                player.transform.localScale = new Vector3(player.transform.localScale.x, 1f, player.transform.localScale.z);
                player.transform.position = new Vector3(player.transform.position.x, 1f, player.transform.position.z);
            }*/
        }

        if (gameObject.transform.position.z >= 500)
        {
            canMove = false;
            speed = 0f;
            //canvasNextLevel.SetActive(true);
            EarnedMoney.text = money.ToString() + " $";
            DoubleEarnedMoney.text = (money * 2).ToString() + " $";

            nextLevelPanel.SetActive(true);
            finishText.SetActive(true);
            nextLevelButtonu.SetActive(true);
            if(isLevelCompletedBool==false)
            {
                isLevelCompletedBool = true;
                levelCompletePanel.SetActive(true);
                rewardedAdPanel.SetActive(true);
            }
            

        }

        if(PlayerPrefs.GetInt("numberForGecisReklami", 0)==3)
        {
            Debug.Log("NUMBER FOR GECİS REKLAMİ===="+ PlayerPrefs.GetInt("numberForGecisReklami", 0));


            reklamManagerScript.GecisReklamGoster();
            PlayerPrefs.SetInt("numberForGecisReklami", 0);
            reklamManagerScript.GecisReklam();
        }
        
    

}
    private void isLevelCompleted()
    {

    }
    
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Obstacle1")
        {
            Debug.Log("obstacle'a vurduk moruq");
            canMove = false;
            speed = 0f;

            EarnedMoney.text = money.ToString()+" $";
            DoubleEarnedMoney.text = (money * 2).ToString() + " $";


            restartPanel.SetActive(true);
            restartText.SetActive(true);
            restartButton.SetActive(true);
            ShopButton.SetActive(true);
            levelFailedPanel.SetActive(true);
            rewardedAdPanel.SetActive(true);


            //Time.timeScale = 0f;
            //canvasNextLevel.SetActive(true);           
        }

        if (collision.gameObject.tag == "Gold" && speed != 0f)
        {
            SoundManager.PlaySound("pickupCoin");
            Destroy(collision.gameObject);
            Debug.Log("golda carptik");
            money += 10f;

            
            Debug.Log("OUR MONEY= "+ money);
            Debug.Log("REKLAMDAN SONRAKİ YENİ 2X PARA = "+ money);

        }

    }
    public void nextLevelButtonForGecisAd()
    {
        reklamManagerScript.GecisReklamGoster();
    }
    public void nextLevelButton()
    {
        PlayerPrefs.SetInt("FinalMoney", (PlayerPrefs.GetInt("FinalMoney", 0) + (int)money));
        PlayerPrefs.SetInt("SceneIndex", (PlayerPrefs.GetInt("SceneIndex", 1) + playSceneIndex));

        if (PlayerPrefs.GetInt("numberForGecisReklami", 0) == 3)
        {
            PlayerPrefs.SetInt("numberForGecisReklami", 0);
            
        }


        PlayerPrefs.SetInt("numberForGecisReklami", PlayerPrefs.GetInt("numberForGecisReklami", 0) + gecisReklamiSayisiArtirici);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        money = 0;
    }
    public void restartLevelButtonForGecisAds()
    {
        reklamManagerScript.GecisReklamGoster();
    }
    public void restartLevelButton()
    {
        Debug.Log("NUMBER FOR GECIS REKLAMI= "+ PlayerPrefs.GetInt("numberForGecisReklami", 0).ToString());
        //reklamManagerScript.GecisReklamGoster();
        /*if (PlayerPrefs.GetInt("numberForGecisReklami", 0) == 3)
        {
            PlayerPrefs.SetInt("numberForGecisReklami", 0);
            
        }*/



        PlayerPrefs.SetInt("numberForGecisReklami", PlayerPrefs.GetInt("numberForGecisReklami", 0) + gecisReklamiSayisiArtirici);
        Debug.Log("Sahneye RESTART ATILDI");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        PlayerPrefs.SetInt("FinalMoney", (PlayerPrefs.GetInt("FinalMoney", 0) + (int)money));
        money = 0;
    }
    public void shopButtonFunc()
    {
        PlayerPrefs.SetInt("FinalMoney", (PlayerPrefs.GetInt("FinalMoney", 0) + (int)money));
        shopMenuCanvas.SetActive(true);
        money = 0;
    }
    public void ShopMenuBackButton()
    {
        shopMenuCanvas.SetActive(false);
    }
    public void rewardedAdCloseButton()
    {
        /*levelCompletePanel.SetActive(false);
        levelFailedPanel.SetActive(false);
        rewardedAdPanel.SetActive(false);*/
        
        Debug.Log("button click!");

        if(levelFailedPanel.activeInHierarchy==true)
        {
            
            levelFailedPanel.SetActive(false);
            Debug.Log("level failed active'di hemen kapanması lazım");
        }
        if(rewardedAdPanel.activeInHierarchy==true)
        {
            
            rewardedAdPanel.SetActive(false);
            Debug.Log("rewardedAdPanel active'di hemen kapanması lazım");

        }
        if (levelCompletePanel.activeInHierarchy==true)
        {
            
            levelCompletePanel.SetActive(false);
            Debug.Log("level complete active'di hemen kapanması lazım");
        }
    }



    /*private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Obstacle1")
        {
            canMove = true;


        }
    }*/


}
