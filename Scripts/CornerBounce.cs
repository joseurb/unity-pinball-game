using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CornerBounce : MonoBehaviour
{
	private float bounce = 0f;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Player") && this.tag == "BottomCorner")
		{
			bounce = Random.Range(3,5);
			collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounce, ForceMode2D.Impulse);
		}
		if (collision.gameObject.CompareTag("Player") && this.tag == "TopCorner")
		{
			bounce = Random.Range(5,10);
			collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.down * bounce, ForceMode2D.Impulse);
		}
   }
}