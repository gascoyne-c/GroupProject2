using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //public static PlayerController Instance { get; private set; }

    public Rigidbody Rigid;
    public float MouseSensitivity;
    public float MoveSpeed;
    //public float JumpForce;

    void FixedUpdate()
    {
        Rigid.MoveRotation(Rigid.rotation * Quaternion.Euler(new Vector3(0, Input.GetAxis("Mouse X") * MouseSensitivity, 0)));
        Rigid.MovePosition(transform.position + (transform.forward * Input.GetAxis("Vertical") * MoveSpeed) + (transform.right * Input.GetAxis("Horizontal") * MoveSpeed));
        // if (Input.GetKeyDown("space"))
        //     Rigid.AddForce(transform.up * JumpForce);
    }

    private void Update()
    {

    }

    /*I've included the necessary "using UnityEngine.SceneManagement;" at the top of this, so when you go ahead and implement some scripting into the menu screen you can basically copy and paste this line using if statements.

    if (blahblahblah){
        SceneManager.LoadScene(sceneBuildIndex: x);
        }
    */

}