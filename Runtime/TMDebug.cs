using UnityEngine;

namespace TMUtils
{
    public static class TMDebug
    {
        /// <summary>
        /// Draws a 3D box in the scene for debugging.
        /// </summary>
        /// <param name="center">The center of the box.</param>
        /// <param name="size">The size of the box.</param>
        /// <param name="orientation">The rotation of the box.</param>
        /// <param name="color">The color of the lines.</param>
        /// <param name="duration">How long the lines should persist.</param>
        public static void DrawDebugBox(Vector3 center, Vector3 size, Quaternion orientation, Color color, float duration = 0.5f)
        {
            Vector3[] corners = new Vector3[8];
            Vector3 halfSize = size / 2;

            // Define the box's corners
            corners[0] = center + orientation * new Vector3(-halfSize.x, -halfSize.y, -halfSize.z);
            corners[1] = center + orientation * new Vector3(halfSize.x, -halfSize.y, -halfSize.z);
            corners[2] = center + orientation * new Vector3(halfSize.x, -halfSize.y, halfSize.z);
            corners[3] = center + orientation * new Vector3(-halfSize.x, -halfSize.y, halfSize.z);
            corners[4] = center + orientation * new Vector3(-halfSize.x, halfSize.y, -halfSize.z);
            corners[5] = center + orientation * new Vector3(halfSize.x, halfSize.y, -halfSize.z);
            corners[6] = center + orientation * new Vector3(halfSize.x, halfSize.y, halfSize.z);
            corners[7] = center + orientation * new Vector3(-halfSize.x, halfSize.y, halfSize.z);

            // Draw the edges of the box
            Debug.DrawLine(corners[0], corners[1], color, duration); // Bottom face
            Debug.DrawLine(corners[1], corners[2], color, duration);
            Debug.DrawLine(corners[2], corners[3], color, duration);
            Debug.DrawLine(corners[3], corners[0], color, duration);

            Debug.DrawLine(corners[4], corners[5], color, duration); // Top face
            Debug.DrawLine(corners[5], corners[6], color, duration);
            Debug.DrawLine(corners[6], corners[7], color, duration);
            Debug.DrawLine(corners[7], corners[4], color, duration);

            Debug.DrawLine(corners[0], corners[4], color, duration); // Vertical edges
            Debug.DrawLine(corners[1], corners[5], color, duration);
            Debug.DrawLine(corners[2], corners[6], color, duration);
            Debug.DrawLine(corners[3], corners[7], color, duration);
        }
    }
}