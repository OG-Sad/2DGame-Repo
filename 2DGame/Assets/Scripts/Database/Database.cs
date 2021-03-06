﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Database
{
    //if the data is reset, the PlayerPrefs default the values at 0
    //public static int currentLevel = PlayerPrefs.GetInt("currentLevel");
    //the highest level the player has achieved; starts at 0
    //public static int highestCurrentLevel = PlayerPrefs.GetInt("highestCurrentLevel");
    public static bool currentLevelEnded;

    //false if the game is in progress; true when the player loses and displays the end screen
    public static bool gameEnd = false;
    
    public static bool isOrbiting = false;
    public static Vector2 orbitPlanetPos;

    //dictionary of all power ups; itemList gets set back to this when data is reset
    public static Dictionary<string, ShopItem> itemList = new Dictionary<string, ShopItem>() {
        {"Invincibility", new ShopItem(){ name = "Invincibility", cost = 30, upgradeLevel = 1}},
        {"Boost", new ShopItem(){ name = "Boost", cost = 30, upgradeLevel = 1}},
        {"Time", new ShopItem(){ name = "Time", cost = 30, upgradeLevel = 1}},
        {"Star", new ShopItem(){ name = "Star", cost = 30, upgradeLevel = 1}}
    };

}
