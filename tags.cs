using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tags : MonoBehaviour
{
    int count = 0;
    int playerCount = 0;
    int TreeCount = 0;
    int CarCount = 0;
    int SphereCount = 0;
    int OldCarCount = 0;
    int Tree2Count = 0;
    int TerrainCount = 0;
    int iluCount = 0;
    int mainIluCount = 0;

    void show() {
      int playerID = 1;
      int TreeID = 2;
      int CarID = 3;
      int SphereID = 4;
      int OldCarID = 5;
      int Tree2ID = 6;
      int TerrainID = 7;
      int iluID = 8;
      int mainIluID = 9;
      GameObject player = GameObject.FindGameObjectWithTag("Player");
      GameObject sphere = GameObject.FindGameObjectWithTag("sphere");
      GameObject tree = GameObject.FindGameObjectWithTag("Grass");
      GameObject car = GameObject.FindGameObjectWithTag("Car");
      GameObject terrain = GameObject.FindGameObjectWithTag("Stone");
      GameObject oldCar = GameObject.FindGameObjectWithTag("oldCar");
      GameObject tree2 = GameObject.FindGameObjectWithTag("Tree2");
      GameObject ilu = GameObject.FindGameObjectWithTag("Ilu");
      GameObject mainIlu = GameObject.FindGameObjectWithTag("MainIlu");
      Debug.Log(player);
      Debug.Log("Ethan ID = " + playerID);
      Debug.Log(tree);
      Debug.Log("Tree ID = " + TreeID);
      Debug.Log(car);
      Debug.Log("Car ID = " + CarID);
      Debug.Log(sphere);
      Debug.Log("Sphere ID = " + SphereID);
      Debug.Log(oldCar);
      Debug.Log("Old car ID = " + OldCarID);
      Debug.Log(tree2);
      Debug.Log("Tree2 ID = " + Tree2ID);
      Debug.Log(terrain);
      Debug.Log("Terrain ID = " + TerrainID);
      Debug.Log(ilu);
      Debug.Log("Ilu ID = " + iluID);
      Debug.Log(mainIlu);
      Debug.Log("Main Ilu ID = " + mainIluID);
    }
    // Start is called before the first frame update
    void Start()
    {
      show();
    }

    // Update is called once per frame
    void Update()
    { 
      Debug.Log("Ethan iter = " + playerCount);
      Debug.Log("Tree iter = " + TreeCount);
      Debug.Log("Car iter = " + CarCount);
      Debug.Log("Sphere iter = " + SphereCount);
      Debug.Log("Old car iter = " + OldCarCount);
      Debug.Log("Tree2 iter = " + Tree2Count);
      Debug.Log("Terrain iter = " + TerrainCount);
      Debug.Log("Ilu iter = " + iluCount);
      Debug.Log("Main Ilu iter = " + mainIluCount);
      playerCount++;
      TreeCount++;
      CarCount++;
      SphereCount++;
      OldCarCount++;
      Tree2Count++;
      TerrainCount++;
      iluCount++;
      mainIluCount++;
    }
}
