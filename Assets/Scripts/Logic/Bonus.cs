using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    private GameObject gameManager;  // У нас так пока что

    void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            gameManager.GetComponent<JewelSpawn>().AddCoins();
        }
        if (col.gameObject.CompareTag("Collider"))
        {
            Destroy(gameObject);
        }
    }
}
