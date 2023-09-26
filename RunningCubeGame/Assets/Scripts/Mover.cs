using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 7f;
    
    // Start is called before the first frame update
    void Start()
    {
        PringInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PringInstructions()
    {
        Debug.Log("Welcome to the game.\n" +
                  "Press W A S D keys to move cube. " +
                  "Don't bump into the obstacles.");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, 0, zValue);
    }
}
