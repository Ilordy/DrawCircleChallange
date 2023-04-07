using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    #region Variables
    /// <summary>
    /// Reference for the play button in scene.
    /// </summary>
    [SerializeField] Button m_playButton;
    /// <summary>
    /// CubeController component in scene for changing it's material and logging it's transform values.
    /// </summary>
    [SerializeField] CubeController m_cube;
    /// <summary>
    /// Screen GUI for displaying the cube's transform values.
    /// </summary>
    [SerializeField] TextMeshProUGUI m_cubePositionGUI, m_cubeRotationGUI;
    /// <summary>
    /// Array to use when spawning a random primitive type.
    /// </summary>
    [SerializeField] GameObject[] m_primitiveTypes;
    #endregion

    #region Life Cycle
    void Start()
    {
        //adding an onClick listenter event to the play button do it's job.
        m_playButton.onClick.AddListener(() =>
        {
            Debug.LogWarning("This is a warning!");
            m_cube.ChangeColor();
            //instantiating a a random pritimive type inside the array and placing it on an arbitrary position.
            Instantiate(m_primitiveTypes[Random.Range(0, m_primitiveTypes.Length)], new Vector3(4, 0, 5), Quaternion.identity);
        });
    }

    void Update()
    {
        //displaying the cube's position and rotation using text mesh pro GUI.
        m_cubePositionGUI.SetText("Cube Position: " + m_cube.transform.position.ToString());
        m_cubeRotationGUI.SetText("Cube Rotation: " + m_cube.transform.eulerAngles.ToString());
    }
    #endregion
}
