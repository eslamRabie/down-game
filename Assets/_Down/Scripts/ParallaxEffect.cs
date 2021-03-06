using UnityEngine;
namespace _DownGame
{
    public class ParallaxEffect : MonoBehaviour
    {
        [SerializeField]
        float speed;
        [SerializeField]
        float deltaPosition;
        [SerializeField]
        Vector2 startPosition;

        Vector2 newPosition;

        void Update()
        {
            newPosition.y = Mathf.Repeat(Time.time * speed, deltaPosition);
            transform.position = startPosition + Vector2.up * newPosition;
        }

    }
}