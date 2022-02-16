using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollect : MonoBehaviour
{
    public GameObject item;
    private void OnTriggerEnter(Collider other)
    {
        item.gameObject.SetActive(false);
        ScoreManager.instance.AddPoint();
    }
}
