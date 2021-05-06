using UnityEngine;



//Handels Game Needed Rules
public class GameManager {
    //int diceFace: Number of faces on the dice that should be rolled
    //return: Returns a number between and including 1 <= return => diceFace 
    public int diceRoll(int diceFace){
        return Random.Range(1,diceFace+1);
    }

    //returns an int cut in half rounded up
    public int halfUp(int number){
        return Mathf.CeilToInt(number/2);
    }
    //returns and int cut in half rounded down
    public int halfDown(int number){
        return Mathf.FloorToInt(number/2);
    }


}