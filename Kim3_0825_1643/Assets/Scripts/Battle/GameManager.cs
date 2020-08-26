using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool monsterAttack = false;
    bool PlayerAttack = false;

    [HideInInspector]
    public bool playerTurn = true;
    [HideInInspector]
    public bool monsterTurn = true;

    [SerializeField]
    GameObject hitEffect;

    [SerializeField]
    GameObject dragon;

    [SerializeField]
    GameObject player;

    [SerializeField]
    GameObject turnText;
       

    public void Start()
    {
        //turnText = Text.GetComponent<TextMesh>();
        StartCoroutine(ChangeTurn());
    }
    public void Update()
    {
        if (Match3.ComboCount > 0 && !PlayerAttack)
        {
            PlayerAttack = true;
            StartCoroutine(HitEffect());
        }

        if (Match3.ComboCount == 0)
        {
            PlayerAttack = false;
        }
    }

    IEnumerator HitEffect()
    {
        if(playerTurn)
        {
            GameObject hitEffecttemp = Instantiate(hitEffect);
            hitEffecttemp.transform.position = dragon.transform.position;
            hitEffecttemp.SetActive(true);
            yield return new WaitForSeconds(1);
            Destroy(hitEffecttemp);
        }

        else if(monsterTurn)
        {
            yield return new WaitForSeconds(2);
            GameObject hitEffecttemp = Instantiate(hitEffect);
            hitEffecttemp.transform.position = player.transform.position;
            hitEffecttemp.SetActive(true);
            yield return new WaitForSeconds(1);
            Destroy(hitEffecttemp);
        }
       
    }

    IEnumerator ChangeTurn()
    {
        if (playerTurn)
        {
            yield return new WaitForSeconds(5);
            playerTurn = false;
            monsterTurn = true;
            StartCoroutine(TurnTextRender());
            StartCoroutine(ChangeTurn());
            StartCoroutine(HitEffect());
        }

        else if (monsterTurn)
        {
            yield return new WaitForSeconds(5);
            playerTurn = true;
            monsterTurn = false;
            StartCoroutine(TurnTextRender());
            StartCoroutine(ChangeTurn());
        }
    }

    IEnumerator TurnTextRender()
    {
        if(monsterTurn)
        {
            turnText.GetComponent<TextMesh>().text = "Monster Turn";
            turnText.GetComponent<TextMesh>().color = Color.red;
            turnText.GetComponent<TextMesh>().fontSize = 50;
            turnText.SetActive(true);
            yield return new WaitForSeconds(1);
            turnText.SetActive(false);
        }

        else
        {
            turnText.GetComponent<TextMesh>().text = "Player Turn";
            turnText.GetComponent<TextMesh>().color = Color.blue;
            turnText.GetComponent<TextMesh>().fontSize = 60;
            turnText.SetActive(true);
            yield return new WaitForSeconds(1);
            turnText.SetActive(false);
        }
        
    }
}