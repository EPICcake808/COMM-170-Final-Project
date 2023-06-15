using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;


//Save and load GameDataObject playerData information when within a scene
//based on certain triggers

//save data each time a scene swaps
//load data to the player object upon return to the scene

//attach to XR Rig

public class Player : MonoBehaviour
{

    public GameObject rig;
    public PlayerData playerData;
    //[SerializeField] private Transform _returnCoord;     //hold position coordinates for the return location
    //public PlayerData _playerData;

    private void Start()
    {
        LoadData();
    }

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void SaveData(Transform newCoord)
    {
        //check current scene to determine the data to load

        //Vector3 LoadPosition = new Vector3(_playerData.returnCoord.position.x, _playerData.returnCoord.position.y, _playerData.returnCoord.position.z);
        playerData.returnCoord_pos = newCoord.position;
        playerData.returnCoord_rot = newCoord.rotation;
        Debug.Log("new " + playerData.returnCoord_pos);
    }

    public void LoadData()
    {
        //check current scene to determine the data to load

        //Vector3 LoadPosition = new Vector3(_playerData.returnCoord.position.x, _playerData.returnCoord.position.y, _playerData.returnCoord.position.z);
        //Debug.Log(playerData.returnCoord_pos);
        rig.transform.position = playerData.returnCoord_pos;
        rig.transform.rotation = playerData.returnCoord_rot;
    }

}
