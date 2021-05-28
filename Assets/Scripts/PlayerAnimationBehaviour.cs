using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationBehaviour : MonoBehaviour
{
    private PlayerMovementBehaviour _movementBehaviour;
    [SerializeField]
    private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        //Initializes the move component reference
        _movementBehaviour = GetComponent<PlayerMovementBehaviour>();
    }

    public void ActivateWinTrigger()
    {
        _animator.SetTrigger("WinGame");
    }

    // Update is called once per frame
    void Update()
    {
        _animator.SetFloat("Speed", _movementBehaviour.Velocity.magnitude);
        _animator.SetBool("InAir", !_movementBehaviour.IsGrounded);
    }
}
