using System;

namespace Vector2Tests
{
    /// <summary>
    /// A vector denotes a displacement in the plane or in space or a force and is represented by 
    /// an arrow whose length and direction is exactly the length and direction of the displacement.
    /// </summary>
    internal class Vector2
    {
        internal float X;
        internal float Y;

        public Vector2()
        {

        }

        /// <summary>
        /// Copy Constructor
        /// </summary>
        /// <param name="VectorToCopy"><see cref="Vector2"/> to copy data from</param>
        public Vector2(Vector2 VectorToCopy)
        {
            X = VectorToCopy.X;
            Y = VectorToCopy.Y;
        }

        public Vector2(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public float Length
        {
            get
            {
                return (float)Math.Sqrt(X * X + Y * Y);
            }
            set
            {
                float multiplier = value / Length;

                X *= multiplier;
                Y *= multiplier;
            }
        }
        public float LengthSquared
        {
            get
            {
                return X * X + Y * Y;
            }
            set
            {
                Length = (float)Math.Sqrt(value);//hack: remove slow sqrt
            }
        }
        internal float Distance(Vector2 vB)
        {
            return (this - vB).Length;
        }

        internal virtual void Invert()
        {
            X *= -1;
            Y *= -1;
        }

        public static Vector2 operator +(Vector2 Alpha, Vector2 Beta)
        {
            return new Vector2(Alpha.X + Beta.X, Alpha.Y + Beta.Y);
        }
        public static Vector2 operator -(Vector2 Alpha, Vector2 Beta)
        {
            return new Vector2(Alpha.X - Beta.X, Alpha.Y - Beta.Y);
        }
    }
}