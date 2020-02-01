using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public Player player;
    public GameObject camera;
        
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddBuff(float val)
    {
        player.isaac.speed = player.isaac.speed * val;
        // giveMap
    }
    public void AddDeBuff(float val)
    {
        player.isaac.speed = player.isaac.speed * val;
    }

    public void StartGame()
    {

    }
    public void PauseGame()
    {

    }

    public void Win()
    {

    }
    public void Died()
    {

    }
    
    void ChangeYcCamera()
    {

    }
    void ChangeICamera()
    {

    }

    void AddMap(int type)
    {

    }

}
