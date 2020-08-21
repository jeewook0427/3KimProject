using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopScript : MonoBehaviour
{
    public GameObject prefab;
    public GameObject panel;
    private GameObject shopUI;

    private string[] textAmounts = { "HP UP!", "Crush Block", "Shuffle!", "Sorry", "Sorry", "Sorry" };

    private string[] textProducts = { "HP 20% UP!", "Crushing 1block!", "Shuffle Blocks!", "Wait for Update", "Wait for Update", "Wait for Update" };
    private string[] textCosts = { "200", "300", "500", "---", "---", "---" };
    private string[] panelInfoIcon = { "UI_Graphic_Resource_Food", "UI_Graphic_Resource_Tools", "UI_Graphic_Resource_Gems", "UI_Graphic_Resource_Wood", "UI_Graphic_Resource_Wood", "UI_Graphic_Resource_Wood" };
    

    // Start is called before the first frame update

    void Start()
    {
        shopUI = GameObject.FindGameObjectWithTag("SHOP");
        shopUI.SetActive(true);
        for (int i = 0; i < textAmounts.Length; i++)
        {
            panel = Instantiate(prefab, new Vector2(i * 400, 11.3f), transform.rotation, gameObject.transform);
            // panel.

            panel.GetComponent<PanelScript>().TextAmount.text = textAmounts[i];
            panel.GetComponent<PanelScript>().TextProduct.text = textProducts[i];
            panel.GetComponent<PanelScript>().TextCost.text = textCosts[i];
            panel.GetComponent<PanelScript>().ImgItem.sprite = Resources.Load<Sprite>(panelInfoIcon[i]);

        }

        

    }

    // Update is called once per frame
    void Update()
    {
        if (shopUI.activeSelf == false)
            Debug.Log("꺼짐");
          //  transform.position = new Vector3(-49.99f, transform.position.y, transform.position.z);
    }









}
