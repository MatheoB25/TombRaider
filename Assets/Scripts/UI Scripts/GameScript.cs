using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
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
    [SerializeField] private EnemyCollision _enemyCollision;
    private bool _jumpPressed = false;
    [SerializeField] private float _jumpImpulse = 2f;
    private bool _bigOpen = false;

    [SerializeField] private GameObject _tourniquet;
    [SerializeField] private GameObject _tourniquet2;
    [SerializeField] private GameObject _tourniquet3;
    [SerializeField] private GameObject _tourniquet4;
    [SerializeField] private GameObject _tourniquet5;

    [SerializeField] private GameObject _murpic;


    [SerializeField] private Transform _enemyTransform;
    private Vector3 _velocityEnemy;
    [SerializeField] private float _gravityEnemy = 9.81f;

    private bool _platformOpen = false;
    [SerializeField] private GameObject Platform1;
    private Vector3 _platformPosition1;


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
    private bool _leverElevatorTouch2 = false;
    private bool _leverElevatorTouch3 = false;
    private bool _leverElevatorTouch4 = false;
    private bool _leverElevatorTouch5 = false;
    private bool _leverElevatorTouch6 = false;
    private bool _leverElevatorTouch7 = false;
    private bool _leverElevatorTouch8 = false;
    private bool _leverElevatorTouch9 = false;
    private bool _leverElevatorTouch10 = false;
    private bool _leverElevatorTouch11 = false;
    private bool _leverElevatorTouch12 = false;
    private bool _leverElevatorTouch13 = false;
    private bool _leverElevatorTouch14 = false;
    private bool _leverElevatorTouch15 = false;
    private bool _leverElevatorTouch16 = false;
    private bool _leverElevatorTouch17 = false;
    private bool _leverElevatorTouch18 = false;
    private bool _leverElevatorTouch19 = false;
    private bool _leverElevatorTouch20 = false;
    private bool _leverElevatorTouch21 = false;
    


    private bool _elevatorOpen = false;
    private bool _elevatorOpen2 = false;
    private bool _elevatorOpen3 = false;
    private bool _elevatorOpen4 = false;
    private bool _elevatorOpen5 = false;
    private bool _elevatorOpen6 = false;
    private bool _elevatorOpen7 = false;
    private bool _elevatorOpen8 = false;
    private bool _elevatorOpen9 = false;
    private bool _elevatorOpen10 = false;
    private bool _elevatorOpen11 = false;
    private bool _elevatorOpen12 = false;
    private bool _elevatorOpen13 = false;
    private bool _elevatorOpen14 = false;
    private bool _elevatorOpen15 = false;
    private bool _elevatorOpen16 = false;
    private bool _elevatorOpen17 = false;
    private bool _elevatorOpen18 = false;
    private bool _elevatorOpen19 = false;
    private bool _elevatorOpen20 = false;
    private bool _elevatorOpen21 = false;


    

    [SerializeField] private GameObject _elevator;
    [SerializeField] private GameObject _elevator2;
    [SerializeField] private GameObject _elevator3;
    [SerializeField] private GameObject _elevator4;
    [SerializeField] private GameObject _elevator5;
    [SerializeField] private GameObject _elevator6;
    [SerializeField] private GameObject _elevator7;
    [SerializeField] private GameObject _elevator8;
    [SerializeField] private GameObject _elevator9;
    [SerializeField] private GameObject _elevator10;
    [SerializeField] private GameObject _elevator11;
    [SerializeField] private GameObject _elevator12;
    [SerializeField] private GameObject _elevator13;
    [SerializeField] private GameObject _elevator14;
    [SerializeField] private GameObject _elevator15;
    [SerializeField] private GameObject _elevator16;
    [SerializeField] private GameObject _elevator17;
    [SerializeField] private GameObject _elevator18;
    [SerializeField] private GameObject _elevator19;
    [SerializeField] private GameObject _elevator20;
    [SerializeField] private GameObject _elevator21;
   



    private Vector3 _elevatorPosition;
    private Vector3 _elevatorPosition2;
    private Vector3 _elevatorPosition3;
    private Vector3 _elevatorPosition4;
    private Vector3 _elevatorPosition5;
    private Vector3 _elevatorPosition6;
    private Vector3 _elevatorPosition7;
    private Vector3 _elevatorPosition8;
    private Vector3 _elevatorPosition9;
    private Vector3 _elevatorPosition10;
    private Vector3 _elevatorPosition11;
    private Vector3 _elevatorPosition12;
    private Vector3 _elevatorPosition13;
    private Vector3 _elevatorPosition14;
    private Vector3 _elevatorPosition15;
    private Vector3 _elevatorPosition16;
    private Vector3 _elevatorPosition17;
    private Vector3 _elevatorPosition18;
    private Vector3 _elevatorPosition19;
    private Vector3 _elevatorPosition20;
    private Vector3 _elevatorPosition21;
  




    [SerializeField] private GameObject _leverElevatorBlock;
    [SerializeField] private GameObject _leverElevatorBlock2;
    [SerializeField] private GameObject _leverElevatorBlock3;
    [SerializeField] private GameObject _leverElevatorBlock4;
    [SerializeField] private GameObject _leverElevatorBlock5;
    [SerializeField] private GameObject _leverElevatorBlock6;
    [SerializeField] private GameObject _leverElevatorBlock7;
    [SerializeField] private GameObject _leverElevatorBlock8;
    [SerializeField] private GameObject _leverElevatorBlock9;
    [SerializeField] private GameObject _leverElevatorBlock10;
    [SerializeField] private GameObject _leverElevatorBlock11;
    [SerializeField] private GameObject _leverElevatorBlock12;
    [SerializeField] private GameObject _leverElevatorBlock13;
    [SerializeField] private GameObject _leverElevatorBlock14;
    [SerializeField] private GameObject _leverElevatorBlock15;
    [SerializeField] private GameObject _leverElevatorBlock16;
    [SerializeField] private GameObject _leverElevatorBlock17;
    [SerializeField] private GameObject _leverElevatorBlock18;
    [SerializeField] private GameObject _leverElevatorBlock19;
    [SerializeField] private GameObject _leverElevatorBlock20;
    [SerializeField] private GameObject _leverElevatorBlock21;



    [SerializeField] private GameObject _leverPlatformBlock1;

    private bool _leverPlatformActivated1 = false;
    private bool _leverPlatformTouch1 = false;




    private bool _leverElevatorActivated = false;
    private bool _leverElevatorActivated2 = false;
    private bool _leverElevatorActivated3 = false;
    private bool _leverElevatorActivated4 = false;
    private bool _leverElevatorActivated5 = false;
    private bool _leverElevatorActivated6 = false;
    private bool _leverElevatorActivated7 = false;
    private bool _leverElevatorActivated8 = false;
    private bool _leverElevatorActivated9 = false;
    private bool _leverElevatorActivated10 = false;
    private bool _leverElevatorActivated11 = false;
    private bool _leverElevatorActivated12 = false;
    private bool _leverElevatorActivated13 = false;
    private bool _leverElevatorActivated14 = false;
    private bool _leverElevatorActivated15 = false;
    private bool _leverElevatorActivated16 = false;
    private bool _leverElevatorActivated17 = false;
    private bool _leverElevatorActivated18 = false;
    private bool _leverElevatorActivated19 = false;
    private bool _leverElevatorActivated20 = false;
    private bool _leverElevatorActivated21 = false;






    [SerializeField] private float _timerElevator = 0f;
    [SerializeField] private float _speedElevator = 0f;

    [SerializeField] GameObject _pistol;
     private bool _shootPressed = false;


    private bool _leverRotationTouch = false;
    private bool _plaqueRotate = false;
    private bool _plaqueOpen = false;
    private bool _leverRotationActivated = false;
    private Quaternion _plaquePosition;

    private float _plaqueRotY = 0f;

    

    [SerializeField] private GameObject _plaque1;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        {
            if (_scriptCollision.GetColliding() == true && _velocityEnemy.y < 0)
            {
                _velocityEnemy.y = -0f;
            }
            else if (_scriptCollision.GetColliding() == false)
            {
                _velocityEnemy.y = _velocityEnemy.y - _gravityEnemy * Time.deltaTime;
            }
        }

        _tourniquet.transform.Rotate(new Vector3(0, 0.5f, 0));

        _tourniquet2.transform.Rotate(new Vector3(0, 1f, 0));

        _tourniquet3.transform.Rotate(new Vector3(0, 1f, 0));

        _tourniquet4.transform.Rotate(new Vector3(0f, 0f, 1f));

        _tourniquet5.transform.Rotate(new Vector3(2f, 2f, 2f));

        _murpic.transform.Translate(new Vector3(-0.05f, 0f, 0f));
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

        if (_elevatorOpen == true && _leverElevatorActivated == true)
        {
            _elevator.transform.position += transform.up * -2f * Time.deltaTime;

            if (_elevator.transform.position.y < _elevatorPosition.y + -9f)
            {
                _elevatorOpen = false;
            }
        }

        if (_elevatorOpen == false && _leverElevatorActivated == true)
        {
            _elevator.transform.position += transform.up * 6f * Time.deltaTime;

            if (_elevator.transform.position.y > _elevatorPosition.y + 4f)
            {
                _elevatorOpen = true;
            }
        }

        if (_elevatorOpen2 == true && _leverElevatorActivated == true)
        {
            _elevator2.transform.position += transform.up * -2f * Time.deltaTime;

            if (_elevator2.transform.position.y < _elevatorPosition2.y + -9f)
            {
                _elevatorOpen2 = false;
            }
        }

        if (_elevatorOpen2 == false && _leverElevatorActivated == true)
        {
            _elevator2.transform.position += transform.up * 6f * Time.deltaTime;

            if (_elevator2.transform.position.y > _elevatorPosition2.y + 4f)
            {
                _elevatorOpen2 = true;
            }


        }

        if (_elevatorOpen3 == true && _leverElevatorActivated == true)
        {
            _elevator3.transform.position += transform.up * -2f * Time.deltaTime;

            if (_elevator3.transform.position.y < _elevatorPosition3.y + -9f)
            {
                _elevatorOpen3 = false;
            }
        }

        if (_elevatorOpen3 == false && _leverElevatorActivated == true)
        {
            _elevator3.transform.position += transform.up * 6f * Time.deltaTime;

            if (_elevator3.transform.position.y > _elevatorPosition3.y + 4f)
            {
                _elevatorOpen3 = true;
            }


        }

        if (_elevatorOpen4 == true && _leverElevatorActivated4 == true)
        {
            _elevator4.transform.position += transform.up * -2f * Time.deltaTime;

            if (_elevator4.transform.position.y < _elevatorPosition.y + -8f)
            {
                _elevatorOpen4 = false;
            }
        }

        if (_elevatorOpen4 == false && _leverElevatorActivated4 == true)
        {
            _elevator4.transform.position += transform.up * 6f * Time.deltaTime;

            if (_elevator4.transform.position.y > _elevatorPosition4.y + 4f)
            {
                _elevatorOpen4 = true;
            }
        }

        if (_elevatorOpen5 == true && _leverElevatorActivated5 == true)
        {
            _elevator5.transform.position += transform.up * -2f * Time.deltaTime;

            if (_elevator5.transform.position.y < _elevatorPosition5.y + -8f)
            {
                _elevatorOpen5 = false;
            }
        }

        if (_elevatorOpen5 == false && _leverElevatorActivated5 == true)
        {
            _elevator5.transform.position += transform.up * 6f * Time.deltaTime;

            if (_elevator5.transform.position.y > _elevatorPosition5.y + 4f)
            {
                _elevatorOpen5 = true;
            }
        }

        if (_elevatorOpen6 == true && _leverElevatorActivated6 == true)
        {
            _elevator6.transform.position += transform.up * -2f * Time.deltaTime;

            if (_elevator6.transform.position.y < _elevatorPosition6.y + -8f)
            {
                _elevatorOpen6 = false;
            }
        }

        if (_elevatorOpen6 == false && _leverElevatorActivated6 == true)
        {
            _elevator6.transform.position += transform.up * 6f * Time.deltaTime;

            if (_elevator6.transform.position.y > _elevatorPosition6.y + 4f)
            {
                _elevatorOpen6 = true;
            }
        }

        if (_elevatorOpen7 == true && _leverElevatorActivated7 == true)
        {
            _elevator7.transform.position += transform.up * -2f * Time.deltaTime;

            if (_elevator7.transform.position.y < _elevatorPosition7.y + -8f)
            {
                _elevatorOpen7 = false;
            }
        }

        if (_elevatorOpen7 == false && _leverElevatorActivated7 == true)
        {
            _elevator7.transform.position += transform.up * 6f * Time.deltaTime;

            if (_elevator7.transform.position.y > _elevatorPosition7.y + 4f)
            {
                _elevatorOpen7 = true;
            }
        }

        if (_elevatorOpen8 == true && _leverElevatorActivated8 == true)
        {
            _elevator8.transform.position += transform.up * -2f * Time.deltaTime;

            if (_elevator8.transform.position.y < _elevatorPosition8.y + -8f)
            {
                _elevatorOpen8 = false;
            }
        }

        if (_elevatorOpen8 == false && _leverElevatorActivated8 == true)
        {
            _elevator8.transform.position += transform.up * 6f * Time.deltaTime;

            if (_elevator8.transform.position.y > _elevatorPosition8.y + 4f)
            {
                _elevatorOpen8 = true;
            }
        }


        if (_elevatorOpen9 == true && _leverElevatorActivated9 == true)
        {
            _elevator9.transform.position += transform.up * -2f * Time.deltaTime;

            if (_elevator9.transform.position.y < _elevatorPosition9.y + -8f)
            {
                _elevatorOpen9 = false;
            }
        }

        if (_elevatorOpen9 == false && _leverElevatorActivated9 == true)
        {
            _elevator9.transform.position += transform.up * 6f * Time.deltaTime;

            if (_elevator9.transform.position.y > _elevatorPosition9.y + 4f)
            {
                _elevatorOpen9 = true;
            }


        }

        if (_elevatorOpen10 == true && _leverElevatorActivated10 == true)
        {
            _elevator10.transform.position += transform.up * -2f * Time.deltaTime;

            if (_elevator10.transform.position.y < _elevatorPosition10.y + -8f)
            {
                _elevatorOpen10 = false;
            }
        }

        if (_elevatorOpen10 == false && _leverElevatorActivated10 == true)
        {
            _elevator10.transform.position += transform.up * 6f * Time.deltaTime;

            if (_elevator10.transform.position.y > _elevatorPosition10.y + 4f)
            {
                _elevatorOpen10 = true;
            }


        }

        if (_elevatorOpen11 == true && _leverElevatorActivated11 == true)
        {
            _elevator11.transform.position += transform.up * -2f * Time.deltaTime;

            if (_elevator11.transform.position.y < _elevatorPosition11.y + -8f)
            {
                _elevatorOpen11 = false;
            }
        }

        if (_elevatorOpen11 == false && _leverElevatorActivated11 == true)
        {
            _elevator11.transform.position += transform.up * 6f * Time.deltaTime;

            if (_elevator11.transform.position.y > _elevatorPosition11.y + 4f)
            {
                _elevatorOpen11 = true;
            }


        }

        if (_elevatorOpen12 == true && _leverElevatorActivated12 == true)
        {
            _elevator12.transform.position += transform.up * -2f * Time.deltaTime;

            if (_elevator12.transform.position.y < _elevatorPosition12.y + -8f)
            {
                _elevatorOpen12 = false;
            }
        }

        if (_elevatorOpen12 == false && _leverElevatorActivated12 == true)
        {
            _elevator12.transform.position += transform.up * 6f * Time.deltaTime;

            if (_elevator12.transform.position.y > _elevatorPosition12.y + 4f)
            {
                _elevatorOpen12 = true;
            }


        }

        if (_elevatorOpen13 == true && _leverElevatorActivated13 == true)
        {
            _elevator13.transform.position += transform.up * -2f * Time.deltaTime;

            if (_elevator13.transform.position.y < _elevatorPosition13.y + -8f)
            {
                _elevatorOpen13 = false;
            }
        }

        if (_elevatorOpen13 == false && _leverElevatorActivated13 == true)
        {
            _elevator13.transform.position += transform.up * 6f * Time.deltaTime;

            if (_elevator13.transform.position.y > _elevatorPosition13.y + 4f)
            {
                _elevatorOpen13 = true;
            }


        }

        if (_elevatorOpen14 == true && _leverElevatorActivated14 == true)
        {
            _elevator14.transform.position += transform.up * -2f * Time.deltaTime;

            if (_elevator14.transform.position.y < _elevatorPosition14.y + -8f)
            {
                _elevatorOpen14 = false;
            }
        }

        if (_elevatorOpen14 == false && _leverElevatorActivated14 == true)
        {
            _elevator14.transform.position += transform.up * 6f * Time.deltaTime;

            if (_elevator14.transform.position.y > _elevatorPosition14.y + 4f)
            {
                _elevatorOpen14 = true;
            }


        }

        if (_elevatorOpen15 == true && _leverElevatorActivated15 == true)
        {
            _elevator15.transform.position += transform.up * -2f * Time.deltaTime;

            if (_elevator15.transform.position.y < _elevatorPosition15.y + -8f)
            {
                _elevatorOpen15 = false;
            }
        }

        if (_elevatorOpen15 == false && _leverElevatorActivated15 == true)
        {
            _elevator15.transform.position += transform.up * 6f * Time.deltaTime;

            if (_elevator15.transform.position.y > _elevatorPosition15.y + 4f)
            {
                _elevatorOpen15 = true;
            }


        }

        if (_elevatorOpen16 == true && _leverElevatorActivated16 == true)
        {
            _elevator16.transform.position += transform.up * -2f * Time.deltaTime;

            if (_elevator16.transform.position.y < _elevatorPosition16.y + -8f)
            {
                _elevatorOpen16 = false;
            }
        }

        if (_elevatorOpen16 == false && _leverElevatorActivated16 == true)
        {
            _elevator16.transform.position += transform.up * 6f * Time.deltaTime;

            if (_elevator16.transform.position.y > _elevatorPosition16.y + 4f)
            {
                _elevatorOpen16 = true;
            }


        }

        if (_elevatorOpen17 == true && _leverElevatorActivated17 == true)
        {
            _elevator17.transform.position += transform.up * -2f * Time.deltaTime;

            if (_elevator17.transform.position.y < _elevatorPosition17.y + -8f)
            {
                _elevatorOpen17 = false;
            }
        }

        if (_elevatorOpen17 == false && _leverElevatorActivated17 == true)
        {
            _elevator17.transform.position += transform.up * 6f * Time.deltaTime;

            if (_elevator17.transform.position.y > _elevatorPosition17.y + 4f)
            {
                _elevatorOpen17 = true;
            }

        }

        if (_elevatorOpen18 == true && _leverElevatorActivated18 == true)
        {
            _elevator18.transform.position += transform.up * -2f * Time.deltaTime;

            if (_elevator18.transform.position.y < _elevatorPosition18.y + -8f)
            {
                _elevatorOpen18 = false;
            }
        }

        if (_elevatorOpen18 == false && _leverElevatorActivated18 == true)
        {
            _elevator18.transform.position += transform.up * 6f * Time.deltaTime;

            if (_elevator18.transform.position.y > _elevatorPosition18.y + 4f)
            {
                _elevatorOpen18 = true;
            }

        }

        if (_elevatorOpen19 == true && _leverElevatorActivated19 == true)
        {
            _elevator19.transform.position += transform.up * -2f * Time.deltaTime;

            if (_elevator19.transform.position.y < _elevatorPosition19.y + -8f)
            {
                _elevatorOpen19 = false;
            }
        }

        if (_elevatorOpen19 == false && _leverElevatorActivated19 == true)
        {
            _elevator19.transform.position += transform.up * 6f * Time.deltaTime;

            if (_elevator19.transform.position.y > _elevatorPosition19.y + 4f)
            {
                _elevatorOpen19 = true;
            }


        }

        if (_elevatorOpen20 == true && _leverElevatorActivated20 == true)
        {
            _elevator20.transform.position += transform.up * -2f * Time.deltaTime;

            if (_elevator20.transform.position.y < _elevatorPosition20.y + -8f)
            {
                _elevatorOpen20 = false;
            }
        }

        if (_elevatorOpen20 == false && _leverElevatorActivated20 == true)
        {
            _elevator20.transform.position += transform.up * 6f * Time.deltaTime;

            if (_elevator20.transform.position.y > _elevatorPosition20.y + 4f)
            {
                _elevatorOpen20 = true;
            }


        }

        if (_elevatorOpen21 == true && _leverElevatorActivated21 == true)
        {
            _elevator21.transform.position += transform.up * -2f * Time.deltaTime;

            if (_elevator21.transform.position.y < _elevatorPosition21.y + -8f)
            {
                _elevatorOpen21 = false;
            }
        }

        if (_elevatorOpen21 == false && _leverElevatorActivated21 == true)
        {
            _elevator21.transform.position += transform.up * 6f * Time.deltaTime;

            if (_elevator21.transform.position.y > _elevatorPosition21.y + 4f)
            {
                _elevatorOpen21 = true;
            }
        
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

        if (_platformOpen == true)
        {
            Platform1.transform.Translate(new Vector3(0f, -0.1f, 0f));

            if (Platform1.transform.position.y > _platformPosition1.y + 2.5f)
            {
                _platformOpen = false;
            }
        }

        if (_leverRotationActivated == true && (_plaque1.transform.rotation.eulerAngles.y < _plaqueRotY + 90|| _plaque1.transform.rotation.eulerAngles.y < _plaqueRotY + 90 - 360))
        {
            _plaque1.transform.Rotate (0, 5, 0);

            if (_plaque1.transform.rotation.eulerAngles.y >= _plaqueRotY + 90 || _plaque1.transform.rotation.eulerAngles.y <=1 )
            {
                float Angle = _plaqueRotY + 90;
                if (Angle == 360)
                {
                    Angle = 0;
                }
                _plaque1.transform.rotation = Quaternion.Euler(0, Angle, 0);
                _leverRotationActivated = false;
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




        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverPlatformColliding1() == true && _leverPlatformActivated1 == false)
        {
            _platformPosition1 = Platform1.transform.position;
            _platformOpen = true;
            _leverPlatformTouch1 = true;
            _leverPlatformActivated1 = true;

        }

        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverPlatformTouch1 = false;

        }

        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverColliding() == true && _leverActivated == false)
        {
            _doorPosition = Door.transform.position;
            _doorOpen = true;
            _leverTouch = true;
            _leverActivated = true;
            Debug.Log("LA PORTE");
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
            _elevatorPosition2 = _elevator2.transform.position;
            _elevatorPosition3 = _elevator3.transform.position;
            _elevatorOpen = true;
            _elevatorOpen2 = true;
            _elevatorOpen3 = true;
            _leverElevatorTouch = true;
            _leverElevatorActivated = true;
        }
        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverElevatorTouch = false;
        }

        
     /*   if (_gkUi == true && _scriptCollision.GetGDColliding() == true)
        {
            _gdOpen = true;
        }

        if (_gdOpen == true)
        {

            _GD.transform.Translate(new Vector3(0f, 0f, 0.1f));
        }
        if (_GD.transform.position.y > _GDPosition.y + 2.5f)
        {
            _gdOpen = false;
        }*/
              
        


       /* if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverElevatorColliding2() == true && _leverElevatorActivated2 == false)
        {
            _elevatorPosition2 = _elevator2.transform.position;
            _elevatorOpen2 = true;
            _leverElevatorTouch2 = true;
            _leverElevatorActivated2 = true;
        }
        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverElevatorTouch2 = false;
        }

        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverElevatorColliding2() == true && _leverElevatorActivated3 == false)
        {
            _elevatorPosition3 = _elevator3.transform.position;
            _elevatorOpen3 = true;
            _leverElevatorTouch3 = true;
            _leverElevatorActivated3 = true;
        }
        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverElevatorTouch3 = false;
        }*/

        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverElevatorColliding2() == true && _leverElevatorActivated4 == false)
        {
            _elevatorPosition4 = _elevator4.transform.position;
            _elevatorOpen4 = true;
            _leverElevatorTouch4 = true;
            _leverElevatorActivated4 = true;
        }
        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverElevatorTouch4 = false;
        }

        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverElevatorColliding2() == true && _leverElevatorActivated5 == false)
        {
            _elevatorPosition5 = _elevator5.transform.position;
            _elevatorOpen5 = true;
            _leverElevatorTouch5 = true;
            _leverElevatorActivated5 = true;
        }
        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverElevatorTouch5 = false;
        }

        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverElevatorColliding2() == true && _leverElevatorActivated6 == false)
        {
            _elevatorPosition6 = _elevator6.transform.position;
            _elevatorOpen6 = true;
            _leverElevatorTouch6 = true;
            _leverElevatorActivated6 = true;
        }
        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverElevatorTouch6 = false;
        }

        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverElevatorColliding2() == true && _leverElevatorActivated7 == false)
        {
            _elevatorPosition7 = _elevator7.transform.position;
            _elevatorOpen7= true;
            _leverElevatorTouch7 = true;
            _leverElevatorActivated7 = true;
        }
        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverElevatorTouch7 = false;
        }

        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverElevatorColliding2() == true && _leverElevatorActivated8 == false)
        {
            _elevatorPosition8 = _elevator8.transform.position;
            _elevatorOpen8 = true;
            _leverElevatorTouch8 = true;
            _leverElevatorActivated8 = true;
        }
        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverElevatorTouch8 = false;
        }

        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverElevatorColliding2() == true && _leverElevatorActivated9 == false)
        {
            _elevatorPosition9 = _elevator9.transform.position;
            _elevatorOpen9 = true;
            _leverElevatorTouch9 = true;
            _leverElevatorActivated9 = true;
        }
        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverElevatorTouch9 = false;
        }

        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverElevatorColliding2() == true && _leverElevatorActivated10 == false)
        {
            _elevatorPosition10 = _elevator10.transform.position;
            _elevatorOpen10 = true;
            _leverElevatorTouch10 = true;
            _leverElevatorActivated10 = true;
        }
        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverElevatorTouch10 = false;
        }

        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverElevatorColliding2() == true && _leverElevatorActivated11 == false)
        {
            _elevatorPosition11 = _elevator11.transform.position;
            _elevatorOpen11 = true;
            _leverElevatorTouch11 = true;
            _leverElevatorActivated11 = true;
        }
        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverElevatorTouch11 = false;
        }

        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverElevatorColliding2() == true && _leverElevatorActivated12 == false)
        {
            _elevatorPosition12 = _elevator12.transform.position;
            _elevatorOpen12 = true;
            _leverElevatorTouch12 = true;
            _leverElevatorActivated12 = true;
        }
        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverElevatorTouch12 = false;
        }

        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverElevatorColliding2() == true && _leverElevatorActivated13 == false)
        {
            _elevatorPosition13 = _elevator13.transform.position;
            _elevatorOpen13 = true;
            _leverElevatorTouch13 = true;
            _leverElevatorActivated13 = true;
        }
        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverElevatorTouch13 = false;
        }

        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverElevatorColliding2() == true && _leverElevatorActivated14 == false)
        {
            _elevatorPosition14 = _elevator14.transform.position;
            _elevatorOpen14 = true;
            _leverElevatorTouch14 = true;
            _leverElevatorActivated14 = true;
        }
        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverElevatorTouch14 = false;
        }

        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverElevatorColliding2() == true && _leverElevatorActivated15 == false)
        {
            _elevatorPosition15 = _elevator15.transform.position;
            _elevatorOpen15 = true;
            _leverElevatorTouch15 = true;
            _leverElevatorActivated15 = true;
        }
        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverElevatorTouch15 = false;
        }

        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverElevatorColliding2() == true && _leverElevatorActivated16 == false)
        {
            _elevatorPosition16 = _elevator16.transform.position;
            _elevatorOpen16 = true;
            _leverElevatorTouch16 = true;
            _leverElevatorActivated16 = true;
        }
        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverElevatorTouch16 = false;
        }

        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverElevatorColliding2() == true && _leverElevatorActivated17 == false)
        {
            _elevatorPosition17 = _elevator17.transform.position;
            _elevatorOpen17 = true;
            _leverElevatorTouch17 = true;
            _leverElevatorActivated17 = true;
        }
        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverElevatorTouch17 = false;
        }

        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverElevatorColliding2() == true && _leverElevatorActivated18 == false)
        {
            _elevatorPosition18 = _elevator18.transform.position;
            _elevatorOpen18 = true;
            _leverElevatorTouch18 = true;
            _leverElevatorActivated18 = true;
        }
        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverElevatorTouch18 = false;
        }

        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverElevatorColliding2() == true && _leverElevatorActivated19 == false)
        {
            _elevatorPosition19 = _elevator19.transform.position;
            _elevatorOpen19 = true;
            _leverElevatorTouch19 = true;
            _leverElevatorActivated19 = true;
        }
        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverElevatorTouch19 = false;
        }

        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverElevatorColliding2() == true && _leverElevatorActivated20 == false)
        {
            _elevatorPosition20 = _elevator20.transform.position;
            _elevatorOpen20 = true;
            _leverElevatorTouch20 = true;
            _leverElevatorActivated20 = true;
        }
        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverElevatorTouch20 = false;
        }

        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverElevatorColliding2() == true && _leverElevatorActivated21 == false)
        {
            _elevatorPosition21 = _elevator21.transform.position;
            _elevatorOpen21 = true;
            _leverElevatorTouch21 = true;
            _leverElevatorActivated21 = true;
        }
        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverElevatorTouch21 = false;
        }



        if (Context.phase == InputActionPhase.Started && _scriptCollision.GetLeverRotateColliding() == true && _leverRotationActivated == false)
        {
            _plaqueRotY = _plaque1.transform.rotation.eulerAngles.y;
            Debug.Log("Rot " + _plaqueRotY);
            _plaqueOpen = true;
            _leverRotationTouch = true;
            _leverRotationActivated = true;
        }
        else if (Context.phase == InputActionPhase.Canceled)
        {
            _leverRotationTouch = false;
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



