using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{
    GameObject sphere;
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }


    private void OnCollisionEnter(Collision collision)
    {
        Destroy(sphere);
    }
    // Use this for initialization
    void Start ()
    {
        this.sphere = GameObject.Find("SpherePrefab");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
