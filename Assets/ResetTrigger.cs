using UnityEngine;

public class ResetTrigger : MonoBehaviour
{
    [SerializeField] Animator m_Animator;
    [SerializeField] string animatorTrigger;

    public void ResetAnimatorTrigger()
    {
        m_Animator.ResetTrigger(animatorTrigger);
    }
}
