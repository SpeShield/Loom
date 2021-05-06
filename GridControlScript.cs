using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridControlScript : MonoBehaviour
{
    //Base Grid Information
    public int gridSizeX;
    public int gridSizeY;
    public Tile gridTile;
    public Tilemap gridMapTileMap;//Targeting the grid Map

    //Helper Classes
    GameManager rule = new GameManager();

    // Start is called before the first frame update
    void Start()
    {
        buildTileMap(gridSizeX,gridSizeY,gridMapTileMap,gridTile); 
    }

    //Builds the inital Grid for the game
    void buildTileMap(int sizeX, int sizeY,Tilemap targetGrid, Tile tile){
        
        sizeX = rule.halfUp(sizeX);
        sizeY = rule.halfUp(sizeY);
        for(int x = -sizeX ; x <= sizeX; x++){
            for(int y = -sizeY ; y <= sizeY; y++){
                targetGrid.SetTile(new Vector3Int(x,y,0),tile);
            }
        }    
    } 
}
