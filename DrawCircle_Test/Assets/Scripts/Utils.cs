using UnityEngine;
public static class Utils
{
    public static float Lerp(float a, float b, float t)
    {
        t = Mathf.Clamp(t, 0, 1);
        return a + t * (b - a);
    }
}
