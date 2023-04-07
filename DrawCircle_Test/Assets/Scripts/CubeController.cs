using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    #region Variables
    [SerializeField, Tooltip("Amount of degrees to rotate by each second on the y axis.")]
    int m_yDegreesPerSecond; //Value assigned via inspector
    [SerializeField, Tooltip("The max distance that the cube will travel when oscillating")]
    int m_amplitude = 5;
    /// <summary>
    /// The renderer are of the cube.
    /// </summary>
    [SerializeField] Renderer m_renderer;
    #endregion

    #region Life Cycle
    void Update()
    {
        transform.Rotate(new Vector3(0, m_yDegreesPerSecond, 0) * Time.deltaTime); //rotating the cube by x degrees per second on the y axis.
        transform.position = new Vector3(transform.position.x, Mathf.Sin(Time.time) * m_amplitude, transform.position.z); // updating the cube's y position with the sin of Time.time.
    }
    #endregion

    #region Methods
    /// <summary>
    /// Changes the cube's color to green.
    /// </summary>
    public void ChangeColor()
    {
        m_renderer.material.color = Color.green;
    }
    #endregion
}
