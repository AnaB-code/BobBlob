using UnityEngine;

public class PlayerSounds : MonoBehaviour {
    public AudioSource audioSource;
    public PlayerMove pmRef;
    
    public AudioClip jumpSfx;
    public AudioClip walkSfx;
    public AudioClip splatSfx;
    public AudioClip deathSfx;
    
    // Update is called once per frame
    void Update() {
        if (pmRef.isGrounded && Input.GetKeyDown(KeyCode.Space)) {
            audioSource.PlayOneShot(jumpSfx);
        }

        if (pmRef.isGrounded && Input.GetAxis("Horizontal") != 0 && !audioSource.isPlaying) {
            audioSource.clip = walkSfx;
            audioSource.Play();
        }

        if (Input.GetMouseButtonDown(0)) {
            audioSource.PlayOneShot(splatSfx);
        }
    }

    public void DieSound() {
        audioSource.PlayOneShot(deathSfx);
    }
}
