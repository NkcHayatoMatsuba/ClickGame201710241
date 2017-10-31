using UnityEngine;
using System.Collections;

public class BallGenerator : MonoBehaviour
{
    public GameObject BallPrefab;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject ball = Instantiate(BallPrefab) as GameObject;
            //ball.GetComponent<BallController>().Shoot(new Vector3(0, 200, 2000));

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            ball.GetComponent<BallController>().Shoot(worldDir.normalized * 2000);
        }
	}
}
