using UnityEngine;

public class Celestial : MonoBehaviour {
    public float mass;
    public float radius;
    public Vector3 initVelocity;

    Vector3 currVelocity;

    void Awake() {
        currVelocity = initVelocity;
    }
    
    void UpdateVel(Celestial[] celestials, float timeStep) {    //could just get rid of time step and G from Universe
        foreach(var other in celestials) {
            if(other != this) {
                
            }
        }
    }
    
    void UpdatePos() {

    }
}
