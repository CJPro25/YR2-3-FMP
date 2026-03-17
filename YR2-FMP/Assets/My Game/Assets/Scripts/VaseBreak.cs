using UnityEngine;
public class VaseBreak : MonoBehaviour
{
    public GameObject vase;
    Vector3 lastvelocity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Update()
    {
        if(GetComponent<Rigidbody>().linearVelocity != new Vector3(0, 0, 0))
        {
            lastvelocity = GetComponent<Rigidbody>().linearVelocity;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Breaker")
        {
            vase = Instantiate(vase, transform.position, transform.rotation);
            Debug.Log(vase);
            foreach (Rigidbody t in vase.transform.GetComponentsInChildren<Rigidbody>())
            {
                t.AddForce(lastvelocity * GetComponent<Rigidbody>().mass * 10);
                Debug.Log(t.linearVelocity);
            }
            Destroy(gameObject);
        }
    }
}

