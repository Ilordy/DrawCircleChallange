using UnityEngine;
public class DrawCircle : MonoBehaviour
{
    /// <summary>
    /// The type of game object to use when drawing the circle.
    /// </summary>
    [SerializeField] GameObject m_markerPrefab;
    [SerializeField, Tooltip("World space position of where the circle will be drawn.")] 
    Vector3 m_circlePosition = new Vector3();
    [SerializeField, Tooltip("The radius of the circle.")] float m_circleRadius = 3.0f;

    private void Start()
    {
        DrawCircleAtPosition(m_circlePosition, m_circleRadius);
    }

    /// <summary>
    /// Draws a circle made out of the markerPrefab assigned to via the inspector given a position and radius.
    /// </summary>
    /// <param name="position">The world position of where to draw the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    private void DrawCircleAtPosition(Vector3 position, float radius)
    {
        float circumfrence = 2 * Mathf.PI * radius; //circumfrence of the circle with radius r.
        for (float angleTheta = 0; angleTheta <= circumfrence; angleTheta += Mathf.PI / 180.0f)
        {
            //We use a for loop to spawn a markerPrefab every 1 degree till we reach 360.
            //We place each circle at position x and z using a bit of trig with the angle theta.
            Vector3 pointOnCircle = new Vector3(position.x + (radius * Mathf.Cos(angleTheta)),
            position.y,
            position.z + (radius * Mathf.Sin(angleTheta)));
            GameObject pointObject = Instantiate(m_markerPrefab);
            pointObject.transform.position = pointOnCircle;
        }
    }
}
