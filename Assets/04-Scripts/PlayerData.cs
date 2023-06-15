using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//hold the player data saved by the Player.cs script
//will exist in the assets as object, place inside the Player.cs script

[System.Serializable]
[CreateAssetMenu(fileName = "PlayerData", menuName = "Location")]
public class PlayerData : ScriptableObject
{
  //  public int flowerCount;         //which coordinates to move to
    public Vector3 returnCoord_pos;     //hold position coordinates for the return location
    public Quaternion returnCoord_rot;      //hold direction coordinates for where the player should look on return to location
}
