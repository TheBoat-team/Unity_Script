using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Pause_Menu : MonoBehaviour
{
    
    public GameObject pauseMenu;
    private Shoot_Bullet_Rocket bullet;
    private CoolDownRocket coolDown;
    private CountTime time;
    

    private float CoolDown;
    private void Start()
    {
        bullet = GameObject.FindAnyObjectByType<Shoot_Bullet_Rocket>().GetComponent<Shoot_Bullet_Rocket>();
        

       coolDown = GameObject.FindAnyObjectByType<CoolDownRocket>().GetComponent<CoolDownRocket>();
        time = GameObject.FindAnyObjectByType<CountTime>().GetComponent<CountTime>();
    }

   
    public void PauseMenu()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }


    public void Main_Menu()
    {       
        SceneManager.LoadScene("Main_Menu");        
        Time.timeScale = 1;
        HeartSystem.Health = 4;
    }


    public void Continue()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    
    public void Setting()
    {
        // Do What ??!
    }

    public void Quit()
    {
        Application.Quit();
    }


    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
        HeartSystem.Health = 4;
    }


    public void Shoot_Bullet()
    {
        bullet.shoot();
    }
  

    public void Shoot_Rocket()
    {

        if (CoolDown <= 0)
        {
            bullet.shootRocket();
            coolDown.Usespell();
            CoolDown = 8f;
        }

    }

    private void Update()
    {
        //time.CurrentCoolDown -= Time.deltaTime;
        CoolDown -= Time.deltaTime;
    }

}
