using UnityEngine;

public class Capsule : Interactable, ILeftClick, ILeftClickAway
{
    private void Throw() {
        Vector3 randomVector = new(Random.Range(-5, 5), Random.Range(8, 10), Random.Range(-5, 5));
        GetComponent<Rigidbody>().AddForce(randomVector, ForceMode.Impulse);
    }

    private void Slam() {
        Vector3 randomVector = new(0, Random.Range(-8, -10), 0);
        GetComponent<Rigidbody>().AddForce(randomVector, ForceMode.Impulse);
    }

    public void DoLeftClick() {
        Throw();
    }

    public void DoLeftClickAway() {
        Slam();
    }
}
