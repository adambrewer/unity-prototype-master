using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BreakIt : MonoBehaviour
{

	public GameObject asteroidLarge;
	public GameObject asteroid2;
	public GameObject asteroid3;

	public Transform asteroidLargePos;
	public Transform asteroid2Pos;

	GameObject scorecount;

	void Start ()
	{
//	scorecount = GameObject.Find("ScoreCounter");
	}



    void OnTriggerEnter(Collider other)
{	
	if (other.tag == "asteroidLarge")
	{
//	scoreCount.addScoreOne();
	GameObject asteroid2Clone1 = Instantiate (asteroid2, asteroidLargePos.position, asteroidLargePos.rotation);
	GameObject asteroid2Clone2 = Instantiate (asteroid2, asteroidLargePos.position, asteroidLargePos.rotation);
        	Destroy(other.gameObject);
        	Destroy(gameObject);
	}
	if (other.tag == "asteroid2")
	{
//	ScoreCounter.addScoreTwo();
	GameObject asteroid3Clone1 = Instantiate (asteroid3, asteroid2Pos.position, asteroid2Pos.rotation);
	GameObject asteroid3Clone2 = Instantiate (asteroid3, asteroid2Pos.position, asteroid2Pos.rotation);
        	Destroy(other.gameObject);
        	Destroy(gameObject);
	}
	if (other.tag == "asteroid3")
	{
//	ScoreCounter.addScoreThree();
        	Destroy(other.gameObject);
        	Destroy(gameObject);
	}
	if (other.tag == "player")
	{		
	}

    }

}