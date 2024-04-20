using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


abstract public class PlaceAvatarBase : MonoBehaviour
{

    [SerializeField] private PlaceAvatarType type = PlaceAvatarType.DUNGEON;

    [Header("Details for Avatar")]
    [SerializeField] protected TextMeshProUGUI hints;

    protected virtual void OnEnter()
    {
#if UNITY_EDITOR
        Debug.Log("enter " + this.GetType().ToString());
#endif
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.Return))
        {
            OnEnter();
        }
    }

}
