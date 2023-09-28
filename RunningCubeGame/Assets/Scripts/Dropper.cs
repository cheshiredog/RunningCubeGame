using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer m_Renderer;
    Rigidbody m_Rigidbody;
    
    [SerializeField] float timeToWait = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        m_Renderer = GetComponent<MeshRenderer>();
        m_Rigidbody = GetComponent<Rigidbody>();
        
        m_Renderer.enabled = false;
        m_Rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            m_Renderer.enabled = true;
            m_Rigidbody.useGravity = true;
        }
    }
}
