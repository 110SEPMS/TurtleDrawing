using System;
using System.Drawing;

namespace TurtleDrawing
{
    public class Turtle
    {
        public int Angle { get; set; }
        public PointF Position { get; set; }
        public Pen Pen { get; set; }
        public Graphics Graphics { get; set; }
        
        /// <summary>
        /// 旋轉angle度。
        /// </summary>
        /// <param name="angle">angle為正數時為逆時針正向角，為負數時為順時針逆向角。</param>
        public void Turn(int angle)
        {
            Angle = (Angle + angle) % 360;
        }

        /// <summary>
        /// 移動length距離。
        /// </summary>
        /// <param name="length">移動距離</param>
        public void Move(double length)
        {
            PointF newPosition = new PointF(
                (float)(Position.X + length * Math.Cos(DegreeToRadian(Angle))),
                (float)(Position.Y - length * Math.Sin(DegreeToRadian(Angle))));
            Graphics.DrawLine(Pen, Position, newPosition);
            Position = newPosition;
        }

        /// <summary>
        /// 度數轉弧度
        /// </summary>
        /// <param name="degree">度數</param>
        /// <returns></returns>
        private double DegreeToRadian(int degree)
        {
            return degree * (Math.PI / 180.0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="angle"></param>
        /// <param name="length"></param>
        /// <param name="branch"></param>
        /// <param name="n"></param>
        public void DrawTree(int angle, double length, int branch, int n)
        {
            Turn(angle);
            Move(length);

            if (n > 0)
            {
                PointF oldPosition = Position;
                int oldAngle = Angle;

                DrawTree(branch, length * 0.65, branch, n - 1);

                Position = oldPosition;
                Angle = oldAngle;

                DrawTree(-branch, length * 0.65, branch, n - 1);
            }
        }

        
        public void DrawFern()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="length"></param>
        /// <param name="n"></param>
        public void DrawKoch(double length, int n)
        {
            if (n == 0)
            {
                Move(length);
            }
            else
            {
                double len = length / 3.0;
                DrawKoch(len, n - 1);
                Turn(60);
                DrawKoch(len, n - 1);
                Turn(-120);
                DrawKoch(len, n - 1);
                Turn(60);
                DrawKoch(len, n - 1);
            }
        }
    }
}
