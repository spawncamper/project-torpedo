using UnityEngine;

public class AnimatorPlay : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private string animator_state;
    [SerializeField] private int animator_layer;
    [SerializeField] private float normalized_time;

    public void AnimatorPlayMethod()
    {
        animator.Play(animator_state, animator_layer, normalized_time);
    }
}
