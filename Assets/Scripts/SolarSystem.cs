using UnityEngine;

public class SolarSystem : MonoBehaviour {
    Celestial[] celestials;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake() {
        celestials = Object.FindObjectsByType<Celestial>(FindObjectsSortMode.None);
    }


    // Update is called once per frame
    void FixedUpdate() {
        for (int i = 0; i < celestials.Length;  ++i) {
            celestials[i].UpdateVel(celestials);
        }

        for (int i = 0; i < celestials.Length; ++i) {
            celestials[i].UpdatePos();
        }
    }
}
