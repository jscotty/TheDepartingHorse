using UnityEngine;
using System.Collections;

public class FlyingPickUp : PickUp {
	override protected void PickThePickUp()
	{
		base.PickThePickUp();
		print ("Switch Fly-Scene");
	}
}
