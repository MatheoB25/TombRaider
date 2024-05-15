using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GameScript : MonoBehaviour
{
    [SerializeField] private Transform BotTransform;
    private Vector2 Direction;
    [SerializeField] private float MoveSpeed = 1f;
    [SerializeField] private float _rotateSpeed = 100f;
    [SerializeField] private CharacterController CharacterController;
    [SerializeField] private Animator _animator;
    private Vector3 _velocity;
    [SerializeField] private float _gravity = 9.81f;
    [SerializeField] private LayerCollision _scriptCollision;
    [SerializeField] private bool _jumpPressed = false;
    [SerializeField] private float _jumpImpulse = 2f;
    [SerializeField] private bool _leverTouch = false;
    [SerializeField] private bool _doorOpen = false;
    [SerializeField] private GameObject Door;
    [SerializeField] private Vector3 _doorPosition;
    [SerializeField] private GameObject _leverBlock;
    [SerializeField] private bool _leverActivated = false;
    [SerializeField] GameObject _pistol;
    
    [SerializeField] private bool _shootPressed = false;
    


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
        //Gravity
        if (_scriptCollision.GetColliding() == true && _velocity.y < 0)
        {
            _velocity.y = -0f;
        }
        else if (_scriptCollision.GetColliding() == false)
        {
            _velocity.y = _velocity.y - _gravity * Time.deltaTime;
        }
        Vector3 movement = CharacterController.transform.forward * Direction.y * MoveSpeed * Time.deltaTime;
        movement.y = _velocity.y;
        CharacterController.Move(movement);
        CharacterController.transform.Rotate(Vector3.up * Direction.x * _rotateSpeed * Time.deltaTime);
        if (Direction.magnitude > 0.1 && _animator.GetCurrentAnimatorStateInfo(0).IsName("Jump") == false)
        {
            //BotTransform.position = new Vector3((BotTransform.position.x + Direction.x) * MoveSpeed, BotTransform.position.y, (BotTransform.position.z + Direction.y) * MoveSpeed);
            //CharacterController.Move(new Vector3(Direction.x, 0, Direction.y) * MoveSpeed * Time.deltaTime);

            _animator.SetBool("IsRunning", true);


            //Quaternion targetRotation = Quaternion.LookRotation(new Vector3(Direction.x, 0, Direction.y));
            //CharacterController.transform.rotation = targetRotation;

        }
        else
        {
            _animator.SetBool("IsRunning", false);

        }


        //CharacterController.Move(_velocity); 

        if (_jumpPressed == true)
        {


        }

        if (_doorOpen == true)
        {
            Door.transform.Translate(new Vector3(0f, 0f, 0.1f)); 

            if (Door.transform.position.y > _doorPosition.y + 2.5f)
            {
                _doorOpen = false;
            }
        }
        
        
    }
    
    

    IEnumerator StopJumping()
    {
        yield return new WaitForSeconds(0.1f);
        _animator.SetBool("IsJumping", false);
    }
    public void Move(InputAction.CallbackContext Context)
    {
        Direction = Context.ReadValue<Vector2>();
    }

    public void Jump(InputAction.CallbackContext Context)
    {
        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetColliding() == true)
        {
            _jumpPressed = true;
            _animator.SetBool("IsJumping", true);

            _velocity.y = _velocity.y + _jumpImpulse;
            StartCoroutine(StopJumping());
            //coroutine 

        }
        else if (Context.phase == InputActionPhase.Canceled)
        {
            _jumpPressed = false;
        }
        // _jumpPressed = !_jumpPressed;



    }
    public void Lever(InputAction.CallbackContext Context)
    {

        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverColliding() == true && _leverActivated == false)
        {
            _doorPosition = Door.transform.position;
            _doorOpen = true;
            _leverTouch = true;
            _leverActivated = true;
        }

        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverTouch = false;

        }
 
    }
    public void Shoot(InputAction.CallbackContext Context)
    {
        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetColliding() == true)
        {
            



            _shootPressed = true;
            _animator.SetBool("IsShooting", true);

            
            StartCoroutine(StopShooting());
            //coroutine 

        }
        else if (Context.phase == InputActionPhase.Canceled)
        {
            _shootPressed = false;
        }
       



    }
    IEnumerator StopShooting()
    {
        yield return new WaitForSeconds(0.1f);
        _animator.SetBool("IsShooting", false);
    }
   
}
    


      /*
      public void ForwardPressed()
      {
          //BotTransform.Translate(0f, 0f, 0.5f); 
          BotTransform.position = new Vector3(BotTransform.position.x, BotTransform.position.y, BotTransform.position.z + 0.5f);
      }
      public void BackwardPressed()
      {
          //BotTransform.Translate(0f, 0f, -0.5f);
          BotTransform.position = new Vector3(BotTransform.position.x, BotTransform.position.y, BotTransform.position.z - 0.5f);

      }
      public void LeftPressed()
      {
          //BotTransform.Translate(-0.5f, 0f, 0f);
          BotTransform.position = new Vector3(BotTransform.position.x - 0.5f, BotTransform.position.y, BotTransform.position.z);
      }
      public void RightPressed()
      {
          //BotTransform.Translate(0.5f, 0f, 0f);
          BotTransform.position = new Vector3(BotTransform.position.x + 0.5f, BotTransform.position.y, BotTransform.position.z);
      }

      public void JumpPressed()
      {
          //BotTransform.Translate(0f, 0.5f, 0f);

      }
      */



