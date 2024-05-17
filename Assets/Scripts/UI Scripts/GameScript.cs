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
     private bool _jumpPressed = false;
    [SerializeField] private float _jumpImpulse = 2f;
    private bool _bigOpen = false;
    [SerializeField] private GameObject _tourniquet;
    





    private bool _leverTouch = false;
    private bool _leverTouch2 = false;
    private bool _leverTouch3 = false;
    private bool _leverTouch4 = false;
    private bool _leverTouch5 = false;
    private bool _leverTouch6 = false;
    private bool _leverTouch7 = false;
    private bool _leverTouch8 = false;
    private bool _leverTouch9 = false;
    private bool _leverTouch10 = false;
    private bool _leverTouch11 = false;
    private bool _leverTouch12 = false;
    private bool _leverTouch13 = false;
    private bool _leverTouch14 = false;

    private bool _doorOpen = false;
    private bool _doorOpen2 = false;
    private bool _doorOpen3 = false;
    private bool _doorOpen4 = false;
    private bool _doorOpen5 = false;
    private bool _doorOpen6 = false;
    private bool _doorOpen7 = false;
    private bool _doorOpen8 = false;
    private bool _doorOpen9 = false;
    private bool _doorOpen10 = false;
    private bool _doorOpen11 = false;
    private bool _doorOpen12 = false;
    private bool _doorOpen13 = false;
    private bool _doorOpen14 = false;

    [SerializeField] private GameObject Door;
    [SerializeField] private GameObject Door2;
    [SerializeField] private GameObject Door3;
    [SerializeField] private GameObject Door4;
    [SerializeField] private GameObject Door5;
    [SerializeField] private GameObject Door6;
    [SerializeField] private GameObject Door7;
    [SerializeField] private GameObject Door8;
    [SerializeField] private GameObject Door9;
    [SerializeField] private GameObject Door10;
    [SerializeField] private GameObject Door11;
    [SerializeField] private GameObject Door12;
    [SerializeField] private GameObject Door13;

    private Vector3 _doorPosition;
    private Vector3 _doorPosition2;
    private Vector3 _doorPosition3;
    private Vector3 _doorPosition4;
    private Vector3 _doorPosition5;
    private Vector3 _doorPosition6;
    private Vector3 _doorPosition7;
    private Vector3 _doorPosition8;
    private Vector3 _doorPosition9;
    private Vector3 _doorPosition10;
    private Vector3 _doorPosition11;
    private Vector3 _doorPosition12;
    private Vector3 _doorPosition13;


    [SerializeField] private GameObject _leverBlock;
    [SerializeField] private GameObject _leverBlock2;
    [SerializeField] private GameObject _leverBlock3;
    [SerializeField] private GameObject _leverBlock4;
    [SerializeField] private GameObject _leverBlock5;
    [SerializeField] private GameObject _leverBlock6;
    [SerializeField] private GameObject _leverBlock7;
    [SerializeField] private GameObject _leverBlock8;
    [SerializeField] private GameObject _leverBlock9;
    [SerializeField] private GameObject _leverBlock10;
    [SerializeField] private GameObject _leverBlock11;
    [SerializeField] private GameObject _leverBlock12;
    [SerializeField] private GameObject _leverBlock13;
    [SerializeField] private GameObject _leverBlock14;

    private bool _leverActivated = false;
    private bool _leverActivated2 = false;
    private bool _leverActivated3 = false;
    private bool _leverActivated4 = false;
    private bool _leverActivated5 = false;
    private bool _leverActivated6 = false;
    private bool _leverActivated7 = false;
    private bool _leverActivated8 = false;
    private bool _leverActivated9 = false;
    private bool _leverActivated10 = false;
    private bool _leverActivated11 = false;
    private bool _leverActivated12 = false;
    private bool _leverActivated13 = false;
    private bool _leverActivated14 = false;

    private bool _leverElevatorTouch = false;
    private bool _elevatorOpen = false;
    [SerializeField] private GameObject _elevator;
    private Vector3 _elevatorPosition;
    [SerializeField] private GameObject _leverElevatorBlock;
    private bool _leverElevatorActivated = false;

    [SerializeField] private float _endElevator = 1f;
    private bool _upElevator = false;
    private bool _downElevator = true;
    [SerializeField] private float _timerElevator = 0f;
    [SerializeField] private float _speedElevator = 0f;

    [SerializeField] GameObject _pistol;
     private bool _shootPressed = false;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        _tourniquet.transform.Rotate(new Vector3(0, 1f, 0));

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

        if (_elevatorOpen == true)
        {
                _elevator.transform.position += transform.up * -2f * Time.deltaTime;
            }          

            if (_elevator.transform.position.y < _elevatorPosition.y + -8f)
            {
           


                _elevator.transform.position += transform.up * 6f * Time.deltaTime;
               
            }
          
            
  

        if (_doorOpen == true)
        {
            Door.transform.Translate(new Vector3(0f, 0f, 0.1f)); 

            if (Door.transform.position.y > _doorPosition.y + 2.5f)
            {
                _doorOpen = false;
            }
        }

        if (_doorOpen2 == true)
        {
            Door2.transform.Translate(new Vector3(0f, 0f, 0.1f));

            if (Door2.transform.position.y > _doorPosition2.y + 2.5f)
            {
                _doorOpen2 = false;
            }
        }

        if (_doorOpen3 == true)
        {
            Door3.transform.Translate(new Vector3(0f, 0f, 0.1f));

            if (Door3.transform.position.y > _doorPosition3.y + 2.5f)
            {
                _doorOpen3 = false;
            }
        }
        if (_doorOpen4 == true)
        {
            Door4.transform.Translate(new Vector3(0f, 0f, 0.1f));

            if (Door4.transform.position.y > _doorPosition4.y + 2.5f)
            {
                _doorOpen4 = false;
            }
        }

        if (_doorOpen5 == true)
        {
            Door5.transform.Translate(new Vector3(0f, 0f, 0.1f));

            if (Door5.transform.position.y > _doorPosition5.y + 2.5f)
            {
                _doorOpen5 = false;
            }
        }

        if (_doorOpen6 == true)
        {
            Door6.transform.Translate(new Vector3(0f, 0f, 0.1f));

            if (Door6.transform.position.y > _doorPosition6.y + 2.5f)
            {
                _doorOpen6 = false;
            }
        }

        if (_doorOpen7 == true)
        {
            Door7.transform.Translate(new Vector3(0f, 0f, 0.1f));

            if (Door7.transform.position.y > _doorPosition7.y + 2.5f)
            {
                _doorOpen7 = false;
            }
        }

        if (_doorOpen8 == true)
        {
            Door8.transform.Translate(new Vector3(0f, 0f, 0.1f));

            if (Door8.transform.position.y > _doorPosition8.y + 2.5f)
            {
                _doorOpen8 = false;
            }
        }

        if (_doorOpen9 == true)
        {
            Door9.transform.Translate(new Vector3(0f, 0f, 0.1f));

            if (Door9.transform.position.y > _doorPosition9.y + 2.5f)
            {
                _doorOpen9 = false;
            }
        }

        if (_doorOpen10 == true)
        {
            Door10.transform.Translate(new Vector3(0f, 0f, 0.1f));

            if (Door10.transform.position.y > _doorPosition10.y + 2.5f)
            {
                _doorOpen10 = false;
            }
        }

        if (_doorOpen11 == true)
        {
            Door11.transform.Translate(new Vector3(0f, 0f, 0.1f));

            if (Door11.transform.position.y > _doorPosition11.y + 2.5f)
            {
                _doorOpen11 = false;
            }
        }

        if (_doorOpen12 == true)
        {
            Door12.transform.Translate(new Vector3(0f, 0f, 0.1f));

            if (Door12.transform.position.y > _doorPosition12.y + 2.5f)
            {
                _doorOpen12 = false;
            }
        }

       
      

        if (_leverActivated13 == true && _leverActivated14 == true)
        {
            _bigOpen = true;
        }

        if (_bigOpen == true)
        {
            Door13.transform.Translate(new Vector3(0f, 0f, 0.1f));

            if (Door13.transform.position.y > _doorPosition13.y + 2.5f)
            {
                _doorOpen13 = false;
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






        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverColliding2() == true && _leverActivated2 == false)
        {
            _doorPosition2 = Door2.transform.position;
            _doorOpen2 = true;
            _leverTouch2 = true;
            _leverActivated2 = true;
        }

        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverTouch2 = false;

        }

        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverColliding3() == true && _leverActivated3 == false)
        {
            _doorPosition3 = Door3.transform.position;
            _doorOpen3 = true;
            _leverTouch3 = true;
            _leverActivated3 = true;
        }

        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverTouch3 = false;
        }

        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverColliding4() == true && _leverActivated4 == false)
        {
            _doorPosition4 = Door4.transform.position;
            _doorOpen4 = true;
            _leverTouch4 = true;
            _leverActivated4 = true;
        }

        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverTouch4 = false;
        }

        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverColliding5() == true && _leverActivated5 == false)
        {
            _doorPosition5 = Door5.transform.position;
            _doorOpen5 = true;
            _leverTouch5 = true;
            _leverActivated5 = true;
        }

        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverTouch5 = false;
        }

        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverColliding6() == true && _leverActivated6 == false)
        {
            _doorPosition6 = Door6.transform.position;
            _doorOpen6 = true;
            _leverTouch6 = true;
            _leverActivated6 = true;
        }

        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverTouch6 = false;
        }

        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverColliding7() == true && _leverActivated7 == false)
        {
            _doorPosition7 = Door7.transform.position;
            _doorOpen7 = true;
            _leverTouch7 = true;
            _leverActivated7 = true;
        }

        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverTouch7 = false;
        }

        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverColliding8() == true && _leverActivated8 == false)
        {
            _doorPosition8 = Door8.transform.position;
            _doorOpen8 = true;
            _leverTouch8 = true;
            _leverActivated8 = true;
        }

        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverTouch8 = false;
        }

        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverColliding9() == true && _leverActivated9 == false)
        {
            _doorPosition9 = Door9.transform.position;
            _doorOpen9 = true;
            _leverTouch9 = true;
            _leverActivated9 = true;
        }

        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverTouch9 = false;
        }

        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverColliding10() == true && _leverActivated10 == false)
        {
            _doorPosition10 = Door10.transform.position;
            _doorOpen10 = true;
            _leverTouch10 = true;
            _leverActivated10 = true;
        }

        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverTouch10 = false;
        }

        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverColliding11() == true && _leverActivated11 == false)
        {
            _doorPosition11 = Door11.transform.position;
            _doorOpen11 = true;
            _leverTouch11 = true;
            _leverActivated11 = true;
        }

        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverTouch11 = false;
        }

        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverColliding12() == true && _leverActivated12 == false)
        {
            _doorPosition12 = Door12.transform.position;
            _doorOpen12 = true;
            _leverTouch12 = true;
            _leverActivated12 = true;
        }

        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverTouch12 = false;
        }

        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverColliding13() == true && _leverActivated13 == false)
        {
            
            _leverTouch13 = true;
            _leverActivated13 = true;
        }

        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverTouch13 = false;
        }

        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverColliding14() == true && _leverActivated14 == false)
        {
            
            _leverTouch14 = true;
            _leverActivated14 = true;
        }

        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverTouch14 = false;
        }

        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverElevatorColliding() == true && _leverElevatorActivated == false)
        {
            _elevatorPosition = _elevator.transform.position;
            _elevatorOpen = true;
            _leverElevatorTouch = true;
            _leverElevatorActivated = true;
        }
        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverElevatorTouch = false;
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



