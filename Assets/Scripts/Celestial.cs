using UnityEngine;

public class Celestial : MonoBehaviour {
    public float radius;
    public Vector3 initVelocity;


    const float timeStep = 0.01f;
    const float G = 0.001f;

    private Rigidbody rb;


    public Vector3 velocity { get; private set; }
    public float mass { get; private set; }

    public void Awake() {
        velocity = initVelocity;
        rb = GetComponent<Rigidbody>();
        mass = rb.mass;
    }
    
    public void UpdateVel(Celestial[] celestials) {     // for accelerating mass
        foreach(var other in celestials) {
            if(other != this) {
                Vector3 forceDir = (other.rb.position - this.rb.position).normalized;
                float rSquared = (other.rb.position - this.rb.position).sqrMagnitude;

                Vector3 force = (G * forceDir * this.mass * other.mass) / rSquared ;
                Vector3 acceleration = force / this.mass;

                velocity += acceleration * timeStep; 
            }
        }
    }

    
    public void UpdatePos() {
        rb.MovePosition(rb.position + velocity * timeStep);
    }


}
