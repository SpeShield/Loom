using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TokenUI : MonoBehaviour
{  

    private GameObject[] players;
    private int numOfPlayers;
    private int toolBarInt;
    private int oldToolbarInt=0;
    private List<string> names = new List<string>();

    
    private string[] playerNames; //names stored as an array

    

    
    void Start(){
        players = GameObject.FindGameObjectsWithTag("Player");
        numOfPlayers = players.Length;

        foreach(GameObject player in players){
            names.Add(player.name.ToString());
        }
        playerNames = names.ToArray();


    }

    void OnGUI(){        
        // Make a background box
        GUI.Box(new Rect(10,10,100,25), "Players: "+numOfPlayers);
        toolBarInt = GUI.Toolbar (new Rect (0,Screen.height - 50,50*numOfPlayers,50),toolBarInt,playerNames);
        if(toolBarInt!=oldToolbarInt){
            BroadcastMessage("Change",players[toolBarInt],SendMessageOptions.DontRequireReceiver);//telling one to change
            oldToolbarInt=toolBarInt;   
        }

        if(GUI.Button (new Rect (Screen.width - 100,0,100,50), "Exit")){
            ExitGame();
        }
    }

    void ExitGame(){
        Application.Quit();
    }

    
    
      
    
        

    
    
}
