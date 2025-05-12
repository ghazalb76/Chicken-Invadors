using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetector : MonoBehaviour
{
    public System.Action OnColliedField;
    public void Setup(System.Action OnColliedField)
    {
        this.OnColliedField = OnColliedField;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("NormalBullet")){
            if(OnColliedField != null){
            OnColliedField();
            }
        }
    }
}
