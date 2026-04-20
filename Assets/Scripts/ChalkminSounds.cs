using UnityEngine;
public class ChalkminSounds : MonoBehaviour {
    public AudioSource audioSource;
    
    
    
    public AudioClip walkSfx;
    
    
    
    // Update is called once per frame
    void Update() {
       /* if (pmRef.isGrounded && Input.GetKeyDown(KeyCode.Space)) {
            audioSource.PlayOneShot(jumpSfx);
        } */

        if (Input.GetAxis("Horizontal") != 0 && !audioSource.isPlaying) {
            audioSource.clip = walkSfx;
            audioSource.Play();
        }

       // if (Input.GetMouseButtonDown(0)) {
           // audioSource.PlayOneShot(splatSfx);
        //} 
    }

    /*public void DieSound() {
        audioSource.PlayOneShot(deathSfx);
    }*/
}
