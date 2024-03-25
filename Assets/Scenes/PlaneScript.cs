using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.UIElements;

public class PlaneSript : MonoBehaviour
{
    public int moveSpeed = 250;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Rotate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Rotate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Rotate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Rotate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        RotateLim();
        Quaternion qtrn = transform.rotation;
        qtrn.eulerAngles = new Vector3(qtrn.eulerAngles.x, 0, qtrn.eulerAngles.z);
        transform.rotation = qtrn;
        /*transform.localRotation = Quaternion.Euler(transform.rotation.x,
                                    Mathf.Clamp(transform.rotation.y, -150, +150),
                                    transform.rotation.z);*/
        Vector3 vecpos = transform.position * Time.deltaTime;
        vecpos.x = Mathf.Clamp(vecpos.x, -30, +30);
        transform.position = vecpos;

    }
    private void RotateLim()
    {
        if (transform.rotation.x >= 30 || transform.eulerAngles.x >= -30)
        { }
        if (transform.rotation.z > 180 && transform.localEulerAngles.z >= -30)
        { transform.Rotate(0, 0, 0); }
    }
}
