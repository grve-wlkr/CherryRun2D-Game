using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ItemCollector : MonoBehaviour
{
    
    [SerializeField] private TextMeshProUGUI cherriesText;
    private int cherries = 0;
    [SerializeField] private AudioSource collectionSoundEffect;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);

            cherries++;
            UpdateItemCountText();
        }
    }

    private void UpdateItemCountText()
    {
        cherriesText.text = "Cherries: " + cherries;
    }
}
