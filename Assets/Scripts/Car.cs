using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Car : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float speedGainPerSec = 0.2f;
    [SerializeField] private float turnSpeed = 200f;

    private int steerValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed +=speedGainPerSec * Time.deltaTime;

        transform.Rotate(0f, steerValue * turnSpeed * Time.deltaTime, 0f);
       
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Obstacle")){
            SceneManager.LoadScene("SceneMainMenu");
        }
    }

    public void steer(int Value){
        steerValue=Value;
    }
}
