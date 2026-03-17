using UnityEngine;
public class VaseBreak : MonoBehaviour
{
    public GameObject vase;
    Vector3 lastvelocity;
    private void Update()
    {
        //This part adds the current velocity to lastvelocity variable which is then used later on
        if(GetComponent<Rigidbody>().linearVelocity != new Vector3(0, 0, 0)){lastvelocity = GetComponent<Rigidbody>().linearVelocity;}
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Breaker")
        {
            vase = Instantiate(vase, transform.position, transform.rotation); //Adds the broken vase in the same position as the original vase

            foreach (Rigidbody t in vase.transform.GetComponentsInChildren<Rigidbody>()) //For every rigidbody child of the broken vase
            {
                t.AddForce(lastvelocity * GetComponent<Rigidbody>().mass * 10); //Adds the original velocity to the broken pieces
            }
            Destroy(gameObject); //Destroys the original vase
        }
    }
}

