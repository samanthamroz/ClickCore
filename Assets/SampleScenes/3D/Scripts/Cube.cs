using UnityEngine;

public class Cube : MonoBehaviour
{
    public void Spin(int direction = 1) {
        GetComponent<Rigidbody>().AddTorque(Vector3.up * direction * 5f, ForceMode.Impulse);
    }

    public void Slide() {
        Vector3 randomVector = new(Random.Range(-10, 10), 0f, Random.Range(-10, 10));
        GetComponent<Rigidbody>().AddForce(randomVector, ForceMode.Impulse);
    }
}
