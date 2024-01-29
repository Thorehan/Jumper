using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int apples = 0;

    [SerializeField] private Text applesText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Apples"))
        {
            Destroy(collision.gameObject);
            apples++;
            Debug.Log("Apples: " + apples);
            applesText.text = "Apples: " + apples;
        }
        
    }
}
