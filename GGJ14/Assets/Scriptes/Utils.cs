using UnityEngine;
using System.Collections;

public class Utils
{
	public static Quaternion lookAt(Vector3 from, Vector3 target, Vector3 forwardDirection)
	{
		return Quaternion.FromToRotation(forwardDirection, target - from);
	}
}