using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;





public class LobbyButtonMgr : MonoBehaviour
{
    
    public GameObject shopUI;
    public GameObject content;

    // Start is called before the first frame update
    void Start()
    {
        //shopUI = GameObject.FindGameObjectWithTag("SHOP");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //캐릭터 변경 
    public void CharLeftButtonClick()
    {

    }
    public void CharRightButtonClick()
    {
        //SceneManager.LoadScene("Lobby Scene");
    }



    //샵 버튼 함수
    public void ShopButtonClick()
    {
        if (shopUI.activeSelf == false)
        {
            shopUI.SetActive(true);
            
        }
        content.transform.position = new Vector3(70f, content.transform.position.y, content.transform.position.z);

    }
    public void ShopCloseButtonClick()
    {
        shopUI.SetActive(false);
    }
    public void ShopBuyButtonClick()
    {
        //SceneManager.LoadScene("Lobby Scene");
    }
    public void WarnningCloseButtonClick()
    {
        //SceneManager.LoadScene("Lobby Scene");
    }




    public void SoloButtonClick()
    {
        //SceneManager.LoadScene("Lobby Scene");
    }
    public void MultyButtonClick()
    {
        //SceneManager.LoadScene("Lobby Scene");
    }

   


}
