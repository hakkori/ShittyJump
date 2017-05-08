using System.Collections;
using UnityEngine;

public class MathHelper {

	public static float degreeBetween2Points(Vector3 p1, Vector3 p2)
	{
		float xDiff = p2.x - p1.x;
		float yDiff = p2.y - p1.y;
		return (float)(Mathf.Atan2(yDiff, xDiff) * 180.0 / Mathf.PI);
	}

}
