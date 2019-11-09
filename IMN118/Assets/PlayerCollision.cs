using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameManager2 gameManager;

    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag=="Alien")
        {
            FindObjectOfType<GameManager2>().CompleteLevel();
        }

        if (collisionInfo.collider.tag == "Meteor")
        {
            FindObjectOfType<GameManager2>().EndGame();
           
        }
    }

}
