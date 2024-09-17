using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aaaaaa : MonoBehaviour
{
    public GameObject Bullet;
    public GameObject Pink_Bullet;
    public float T_SwitchBullet = 5f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PBullet"))
        {
            StartCoroutine(Switch()); 
        }
    }

    IEnumerator Switch()
    {   
       // Bullet.SetActive(false); 
        Pink_Bullet.SetActive(true);
        yield return new WaitForSeconds(T_SwitchBullet);
        //Bullet.SetActive(true);
        Pink_Bullet.SetActive(false);
    }
}
