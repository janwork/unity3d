using System.Collections;
using UnityEngine;

public class Magic : MonoBehaviour {

    public float track = 5f;

    public float lifeTimer = 7.0f;

	// Use this for initialization
	void Start () {
        StartCoroutine(destoryByTime(lifeTimer));
	}
	
	// Update is called once per frame
	void Update () {
        //lifeTimer -= Time.deltaTime;
        //if (lifeTimer <= 0)
        //{
        //    Destroy(this.gameObject);
        //}
	}


    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "Enemy")
        {
            other.GetComponent<Troll>().hp -= track * Time.deltaTime;

            if (other.GetComponent<Troll>().hp  <= 0)
            {
                other.GetComponent<Troll>().die();
            }
        }
    }

    IEnumerator destoryByTime(float timer)
    {
        yield return new WaitForSeconds(7);
        Destroy(this.gameObject);
    }
}
