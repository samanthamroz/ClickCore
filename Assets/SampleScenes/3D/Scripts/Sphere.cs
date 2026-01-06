using UnityEngine;

public class Sphere : Interactable, IRightClick, IRightRelease, IRightClickAway, ILeftClick
{
    bool isGrowing = false;
    bool isShrinking = false;

    void Update() {
        if (isGrowing) Grow();
        if (isShrinking) Shrink();
    }

    

    public void DoRightClick() {
        isShrinking = false;
        isGrowing = true;
    }

    public void DoRightRelease() {
        isGrowing = false;
        isShrinking = true;
    }

    public void DoRightClickAway() {
        isShrinking = false;
        isGrowing = false;
    }

    public void DoLeftClick() {
        Throw();
    }

    private void Grow() {
        if (transform.localScale.magnitude <= new Vector3(4f, 4f, 4f).magnitude) {
            Vector3 scaleIncrease = new(.005f, .005f, .005f);
            transform.localScale += scaleIncrease;
            transform.position += new Vector3(0, scaleIncrease.y / 2f, 0);
        }
    }

    private void Shrink() {
        if (transform.localScale.magnitude >= new Vector3(.5f, .5f, .5f).magnitude) {
            transform.localScale -= new Vector3(.001f, .001f, .001f);
        }
    }
    
    private void Throw() {
        Vector3 randomVector = new(Random.Range(-5, 5), Random.Range(5, 10), Random.Range(-5, 5));
        GetComponent<Rigidbody>().AddForce(randomVector, ForceMode.Impulse);
    }
}
