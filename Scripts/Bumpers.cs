using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumpers : MonoBehaviour
{
	private float forceMultiplier = 0;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Player") && this.tag == "LowerBumper")
			forceMultiplier = 5;
		if (collision.gameObject.CompareTag("Player") && this.tag == "UpperBumper")
			forceMultiplier = 10;
		if (collision.gameObject.CompareTag("Player") && this.tag == "SmallBumper")
			forceMultiplier = 6;
		if (collision.gameObject.CompareTag("Player") && this.tag == "Wall")
			forceMultiplier = 3;

		collision.rigidbody.AddForce(-collision.contacts[0].normal * forceMultiplier, ForceMode2D.Impulse);
   }
}
