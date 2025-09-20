using UnityEngine;

public class AnimatorPlayer : MonoBehaviour
{
    private readonly int Run = Animator.StringToHash(nameof(Run));
    private readonly int Jump = Animator.StringToHash(nameof(Jump));

    [SerializeField] private Animator _animator;

    public void SetJump(bool value)
    {
        _animator.SetBool(Jump, value);
    }

}
