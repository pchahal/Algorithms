
// ------------------------------------------------------------------------------

using System;
namespace GameProgrammingPatterns
{
    public enum Direction
    {
        DIR_LEFT,
        DIR_RIGHT
    }
    public class Volume
    {
    }

    public class Sprite
    {
    }
    public class World
    {
        public void resolveCollision(Volume volume, int x, int y, int velocity)
        {
        }

    }


    public class Controller
    {
        public static Direction getJoystickDirection()
        {
            return Direction.DIR_LEFT;
        }
    }

    public interface IInputComponent
    {
        void Update(GameObject _gameObject);
    }

    public class PlayerInputComponent : IInputComponent
    {
        private static readonly int WALK_ACCELERATION = 1;

        public void Update(GameObject _gameObject)
        {
            // Apply user input to hero's velocity.
            switch (Controller.getJoystickDirection())
            {
                case Direction.DIR_LEFT:
                    _gameObject.velocity -= WALK_ACCELERATION;
                    break;

                case Direction.DIR_RIGHT:
                    _gameObject.velocity += WALK_ACCELERATION;
                    break;
            }
        }
    }

    public interface IPhysicsComponent
    {
        void Update(GameObject _gameObject, World world);
    }

    public class BjornPhysicsComponent : IPhysicsComponent
    {
        private Volume volume_;

        public void Update(GameObject _gameObject, World world)
        {
            // Modify position by velocity.
            _gameObject.x += _gameObject.velocity;
            world.resolveCollision(volume_, _gameObject.x, _gameObject.y, _gameObject.velocity);
        }
    }

    public interface IGraphicsComponent
    {
        void Update(GameObject _gameObject, Graphics graphics);
    }

    public class Graphics
    {
        internal void Draw(Sprite sprite, int x, int y)
        {

        }
    }

    public class BjornGraphicsComponent : IGraphicsComponent
    {
        private GameObject _gameObject;
        private Sprite spriteStand_;
        private Sprite spriteWalkLeft_;
        private Sprite spriteWalkRight_;

        public void Update(GameObject _gameObject, Graphics graphics)
        {
            // Draw the appropriate sprite.
            Sprite sprite = spriteStand_;
            if (_gameObject.velocity < 0)
            {
                sprite = spriteWalkLeft_;
            }
            else if (_gameObject.velocity > 0)
            {
                sprite = spriteWalkRight_;
            }

            graphics.Draw(sprite, _gameObject.x, _gameObject.y);
        }
    }

    public class GameObject
    {
        public GameObject(IInputComponent _inputComponent, IPhysicsComponent _physicsComponent, IGraphicsComponent _graphicsComponent)
        {
            x = 0;
            y = 0;
            velocity = 0;

            inputComponent = _inputComponent;
            physicsComponent = _physicsComponent;
            graphicsComponent = _graphicsComponent;
        }

        public void Update(World world, Graphics graphics)
        {
            inputComponent.Update(this);

            physicsComponent.Update(this, world);

            graphicsComponent.Update(this, graphics);
        }


        public void Jump()
        {

        }
        public void fire()
        {

        }
        public int velocity { get; set; }
        public int x { get; set; }
        public int y { get; }

        private readonly IInputComponent inputComponent;
        private readonly IPhysicsComponent physicsComponent;
        private readonly IGraphicsComponent graphicsComponent;


    }
}




