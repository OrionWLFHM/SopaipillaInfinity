using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CharacterSwitcher : MonoBehaviour
{
    public GameObject character1;
    public GameObject character2;
    public CinemachineVirtualCamera cameraCharacter1;
    public CinemachineVirtualCamera cameraCharacter2;

    private bool isCharacter1Active = true;
    private bool isCamera1Active = true;

    void Start()
    {
        character1.GetComponent<PlayerMove>().enabled = true;
        cameraCharacter1.enabled = true;
        character2.GetComponent<PlayerMove2>().enabled = false;
        cameraCharacter2.enabled = false;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            isCharacter1Active = !isCharacter1Active;
            isCamera1Active = !isCamera1Active;


            if (isCharacter1Active)
            {
                character1.GetComponent<PlayerMove>().enabled = true;
                cameraCharacter1.enabled = true;
                character2.GetComponent<PlayerMove2>().enabled = false;
                cameraCharacter2.enabled = false;
            }
            else
            {
                character1.GetComponent<PlayerMove>().enabled = false;
                cameraCharacter1.enabled = false;
                character2.GetComponent<PlayerMove2>().enabled = true;
                cameraCharacter2.enabled = true;
            }
        }
    }
}
