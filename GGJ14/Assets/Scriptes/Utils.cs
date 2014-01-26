using UnityEngine;
using System.Collections;

public class Utils
{
    public static double PI = 3.14159265359;
	public static Quaternion lookAt(Vector3 from, Vector3 target, Vector3 forwardDirection)
	{
		return Quaternion.FromToRotation(forwardDirection, target - from);
	}

    public static double scalar(Vector2 pos, Vector2 v)
    {
            return pos.x*v.x + pos.y*v.y;
    }

    public static double norme(Vector2 pos)
    {
            return Mathf.Sqrt(Mathf.Pow(pos.x, 2) + Mathf.Pow(pos.y, 2));
    }

    public static Vector3 vectoriel(Vector3 pos, Vector3 v)
    {
            return new Vector3((pos.y*v.z - pos.z*v.y), (pos.z*v.x - pos.x*v.z), (pos.x*v.y - pos.y*v.x));
    }

    public static double angle(Vector3 pos, Vector3 v)
    {
            double cosinus = scalar(pos, v)/(norme(v) * norme(pos));
            double sinus = norme(vectoriel(pos, v)) / (norme(v) * norme(pos));

            if(sinus < 0)
                    return Mathf.Acos((float) ((-PI/2) * cosinus));
            return Mathf.Acos((float) cosinus);
    }
}