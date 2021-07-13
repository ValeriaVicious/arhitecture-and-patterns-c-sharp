﻿using UnityEngine;


namespace MVC
{
    public static partial class BuilderExtension
    {
        public static GameObject AddBoxCollider2D(this GameObject gameObject)
        {
            gameObject.GetOrAddComponent<BoxCollider2D>();
            return gameObject;
        }

        public static GameObject SetName(this GameObject gameObject, string name)
        {
            gameObject.name = name;
            return gameObject;
        }

        public static GameObject AddRigidbody2d(this GameObject gameObject, float mass)
        {
            var component = gameObject.GetOrAddComponent<Rigidbody2D>();
            component.mass = mass;
            return gameObject;
        }
        public static GameObject AddSprite(this GameObject gameObject, Sprite sprite)
        {
            var component = gameObject.GetOrAddComponent<SpriteRenderer>();
            component.sprite = sprite;
            return gameObject;
        }

        public static GameObject AddCircleCollider2D(this GameObject gameObject)
        {
            gameObject.GetOrAddComponent<CircleCollider2D>();
            return gameObject;
        }

        public static GameObject AddTrailRenderer(this GameObject gameObject)
        {
            var componentInChildren = gameObject.GetComponentInChildren<TrailRenderer>();
            if (componentInChildren)
            {
                return gameObject;
            }
            var lineRendererGameObject = new GameObject(Constants.TrailRenderer);
            var lineRenderer = lineRendererGameObject.AddComponent<TrailRenderer>();
            lineRenderer.startWidth = 0.1f;
            lineRenderer.endWidth = 0.01f;
            lineRenderer.time = 0.1f;
            lineRenderer.material = new Material(Shader.Find(Constants.ShaderForTrailPath));
            lineRenderer.startColor = Color.red;
            lineRenderer.endColor = Color.blue;
            lineRendererGameObject.transform.SetParent(gameObject.transform);
            return gameObject;
        }

        public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
        {
            var result = gameObject.GetComponent<T>();
            if (!result)
            {
                result = gameObject.AddComponent<T>();
            }

            return result;
        }
    }
}
