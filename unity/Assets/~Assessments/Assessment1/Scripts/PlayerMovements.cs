using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovements : MonoBehaviour
{
    public float moveSpeed;
    private Vector3 spawn;
    public GameObject deathParticles;
    public int scene;

    // Use this for initialization
    void Start()
    {
        spawn = transform.position;

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);

    }
    public void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "Enemy")
        {
            print("You Died!");
            Instantiate(deathParticles, transform.position, Quaternion.identity);
            transform.position = spawn;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Goal")
        {
            SceneManager.LoadScene(scene);
        }
    }
}
