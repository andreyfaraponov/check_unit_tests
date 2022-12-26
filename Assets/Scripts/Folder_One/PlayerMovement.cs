using UnityEngine;

namespace Folder_One
{
    using DG.Tweening;

    public class PlayerMovement : MonoBehaviour
    {
        public const float MoveAnimationTimeSeconds = .3f;
        
        private Transform _transform;
        private bool _isMoving;

        private void Awake()
        {
            _transform = transform;
        }

        private void Update()
        {
            if (_isMoving)
            {
                return;
            }
            
            if (Input.GetKeyDown(KeyCode.A))
            {
                MoveLeft();
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                MoveRight();
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                MoveUp();
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                MoveDown();
            }
        }

        public void MoveDown()
        {
            _isMoving = true;
            
            var pos = _transform.position;
            pos.y -= 1;
            
            _transform.DOMove(pos, MoveAnimationTimeSeconds).OnComplete(() =>
            {
                _isMoving = false;
            });
        }

        public void MoveUp()
        {
            _isMoving = true;
            
            var pos = _transform.position;
            pos.y += 1;
            
            _transform.DOMove(pos, MoveAnimationTimeSeconds).OnComplete(() =>
            {
                _isMoving = false;
            });
        }

        public void MoveRight()
        {
            _isMoving = true;
            
            var pos = _transform.position;
            pos.x += 1;
            
            _transform.DOMove(pos, MoveAnimationTimeSeconds).OnComplete(() =>
            {
                _isMoving = false;
            });
        }

        public void MoveLeft()
        {
            _isMoving = true;
            
            var pos = _transform.position;
            pos.x -= 1;
            
            _transform.DOMove(pos, MoveAnimationTimeSeconds).OnComplete(() =>
            {
                _isMoving = false;
            });
        }
    }
}
