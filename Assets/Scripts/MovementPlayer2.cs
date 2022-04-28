using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer2 : MonoBehaviour
{
    private Transform Player;
    public SwipeControls Controls;

    private bool Lane1 = false;
    private bool Lane2 = true;
    private bool Lane3 = false;

    private void Start()
    {
        Player = GetComponent<Transform>();
    }

    private void Update()
    {
        if (Lane3 == true && Player.position.z < 1.1f)
        {
            Player.position += new Vector3(0, 0, 10.5f * Time.deltaTime);
        }
        else if (Lane1 == true && Player.position.z > -1.1f)
        {
            Player.position += new Vector3(0, 0, -10.5f * Time.deltaTime);
        }
        else if (Lane2 == true && Player.position.z <= -0.1f)
        {
            Player.position += new Vector3(0, 0, 10.5f * Time.deltaTime);
        }
        else if (Lane2 == true && Player.position.z >= 0.1f)
        {
            Player.position += new Vector3(0, 0, -10.5f * Time.deltaTime);
        }



        #region ChangeBools
        if (Input.GetKeyDown(KeyCode.D) == true && Lane3 == false && Lane1 == true)
        {
            Lane2 = true;
            Lane1 = false;
            Lane3 = false;
        }
        else if ((Input.GetKeyDown(KeyCode.A) == true && Lane2 == true && Player.position.z <= 0.2f))
        {
            Lane1 = true;
            Lane2 = false;
            Lane3 = false;
        }
        else if ((Input.GetKeyDown(KeyCode.D) == true && Lane2 == true && Player.position.z >= -0.2f))
        {
            Lane3 = true;
            Lane1 = false;
            Lane2 = false;
        }
        else if ((Input.GetKeyDown(KeyCode.A) == true && Lane1 == false && Lane3 == true))
        {
            Lane2 = true;
            Lane1 = false;
            Lane3 = false;
        }
        #endregion
    }
}
