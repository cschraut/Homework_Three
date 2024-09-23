using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveAmount = (moveSpeed * Time.deltaTime);
        float xValue = Input.GetAxis("Horizontal") * moveAmount;
        float zValue = Input.GetAxis("Vertical") * moveAmount;
        transform.Translate(xValue, 0, zValue);
    }

}
