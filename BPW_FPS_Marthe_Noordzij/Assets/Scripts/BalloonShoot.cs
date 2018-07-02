using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonShoot : MonoBehaviour
{

    public bool furnaceIgnite = false;
    public float speedY = 3f;
    public float speedX = 6f;

    public GameObject balloonFlamePrefab;
    public Transform balloonFlameSpawn;
    public bool balloonShot = false;

    private Vector3 start;
    private Vector3 des;
    public Transform des2;
    private float fraction = 0;

    public RotorSpin spinning;

    void Start()
    {
        start = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        des = new Vector3(transform.position.x, 47f, transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Flames")
        {
            if (!balloonShot)
            {
                BalloonLight();
            }
        }     
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Flames")
            {
               
            }
        
        else if (balloonShot)
        {
            if (other.gameObject.name == "FPSController")
            {
                if (fraction < 1)// && fraction >= 0.5f) 
                {
                    transform.position = Vector3.MoveTowards(transform.position, des, Time.smoothDeltaTime * speedY);

                    if (Vector3.Distance(transform.position, des) <= 0.01f)
                    {
                        fraction = 1;
                    }

                }
                else
                if (spinning.spinning) //&& fraction >=1)
                {
                    transform.position = Vector3.MoveTowards(transform.position, des2.position, Time.smoothDeltaTime * speedX);

                    if (Vector3.Distance(transform.position, des2.position) <= 0.01f)
                    {
                        fraction = 2;
                    }
                }

                /*Vector3 playerPos = other.transform.position;
                playerPos.y = transform.position.y + 1;
                other.transform.position = playerPos;*/

            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "FPSController")
        {
            //other.transform.SetParent(null);

            if (fraction < 2)//&& fraction >= 0.5f)
            {
                transform.position = start;
                fraction = 0;
            }


        }
    }

    void BalloonLight()
    {
        if (!balloonShot)
        {
            Instantiate(balloonFlamePrefab, balloonFlameSpawn.position, balloonFlameSpawn.rotation);
            balloonShot = true;
        }
    }

    void Update()
    {

    }
}
