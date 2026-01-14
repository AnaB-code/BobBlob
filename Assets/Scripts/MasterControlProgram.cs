using UnityEngine;

public class MasterControlProgram : MonoBehaviour {
    public int lives;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        lives = 3;
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void LifeManager(int lv) {
        lives += lv;
    }
}
