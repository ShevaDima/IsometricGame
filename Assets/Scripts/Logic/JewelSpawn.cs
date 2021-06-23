using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JewelSpawn : MonoBehaviour
{
    public GameObject jewel;
    public int jewelCount = 0;
    public Text jewelText;
    public PlayerData PlayerData;  

    void Awake()
    {
        jewelCount = PlayerData.Coins;
    }

    void Start()
    {
        StartCoroutine("spawn");
    }


    void Update()
    {
        jewelText.text = jewelCount.ToString();
    }

    IEnumerator spawn()
    {
        while(true)
        {
            Vector2 botLeft = Camera.main.ViewportToWorldPoint(new Vector2(0,0));
            Vector2 topRight = Camera.main.ViewportToWorldPoint(new Vector2(1,1));

            float x = Random.Range(botLeft.x, topRight.x);
            float y = Random.Range(botLeft.y, topRight.y);

            Instantiate(jewel, new Vector3(x, y, 0), Quaternion.identity);
            yield return new WaitForSeconds(10f);
        }
    }

    public void AddCoins()
    {
        PlayerData.Coins++;
        jewelCount = PlayerData.Coins;
    }

    public void SubtractCoins(int coins)
    {
        PlayerData.Coins -= coins;
        jewelCount = PlayerData.Coins;
    }
}
