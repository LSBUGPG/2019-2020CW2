using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GlidingControl : MonoBehaviour
{


    private float speed = 100;
    public float boost = 200;
    public float normal = 100;
    public float drag = 6;

    public Rigidbody rb;

    private Vector3 rot;

    public Vector3 m_NewForce;
    public float percentage;

    public WaveSpawn ws;
    public ScoreWin scoreW;

    void Start()
    {
        speed = normal;
        rb = GetComponent<Rigidbody>();
        rot = transform.eulerAngles;
        m_NewForce = new Vector3(-5.0f, 1.0f, 0.0f);

    }
    // Update is called once per frame
    void Update()
    {
        //Rotate X
        rot.x += 50 * Input.GetAxis("Vertical") * Time.deltaTime;

        //Rotate Y
        rot.y += 50 * Input.GetAxis("Horizontal") * Time.deltaTime;

        //Rotate Z
        rot.z += -5 * Input.GetAxis("Horizontal");
        rot.z = Mathf.Clamp(rot.z, -5, 5);

        transform.rotation = Quaternion.Euler(rot);

        percentage = rot.x / 65;

        float mod_drag = (percentage * -2) + drag;
        float mod_speed = percentage * (13.8f - 12.5f) + speed;

        rb.drag = mod_drag;
        Vector3 localV = transform.InverseTransformDirection(rb.velocity);
        localV.z = mod_speed;
        rb.velocity = transform.TransformDirection(localV);
    }

    IEnumerator SpeedBoost()
    {
        speed = boost;
        yield return new WaitForSeconds(3f);
        speed = normal;

        yield break;
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Kiwi")
        {
            ws.remKiwi -= 1;
            ws.kiwiCheck();
            scoreW.AddScore();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Portal")
        {
            StartCoroutine(SpeedBoost());

            Destroy(collision.gameObject);
        }

    }
}
