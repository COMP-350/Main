using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject playerGO;

    private void onEnable(){
        playerHealth.playerDeath += enableMenu;
    }

    private void onDisable(){
        playerHealth.playerDeath -= enableMenu;
    }
    public void enableMenu(){
        playerGO.SetActive(true);
    }
}
