using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    public static class GameObjectExtensions
    {
        #region Methods

        public static GameObject SetNameToTheObject(this GameObject gameObject, string name)
        {
            gameObject.name = name;
            return gameObject;
        }

        public static GameObject AddRigidBody2DToTheObject(this GameObject gameObject,
            float massOfBody)
        {
            var component = gameObject.GetOrAddComponentToTheObject<Rigidbody2D>();
            component.mass = massOfBody;
            return gameObject;
        }

        public static GameObject AddSpriteToTheObject(this GameObject gameObject,
            Sprite sprite)
        {
            var component = gameObject.GetOrAddComponentToTheObject<SpriteRenderer>();
            component.sprite = sprite;
            return gameObject;
        }

        public static GameObject AddCircleCollider2DToTheObject(this GameObject gameObject,
             float radius, bool isTrigger = false)
        {
            var component = gameObject.GetOrAddComponentToTheObject<CircleCollider2D>();
            component.radius = radius;
            component.isTrigger = isTrigger;
            return gameObject;
        }

        public static GameObject SetPositionToTheObject(this GameObject gameObject,
            Vector3 position)
        {
            gameObject.transform.position = position;
            return gameObject;
        }

        private static T GetOrAddComponentToTheObject<T>(this GameObject gameObject)
            where T : Component
        {
            var resultOfGetComponent = gameObject.GetComponent<T>();

            if (!resultOfGetComponent)
            {
                resultOfGetComponent = gameObject.AddComponent<T>();
            }
            return resultOfGetComponent;
        }

        #endregion
    }
}
