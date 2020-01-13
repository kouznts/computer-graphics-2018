using System;
using System.Collections.Generic;
using System.Drawing;

namespace Lab2
{
    public class Turtle
    {
        #region статика
        public static readonly Color PEN_COLOR = Color.Black;

        public static readonly int MIN_PEN_WIDTH = 5;
        public static readonly int MAX_PEN_WIDTH = 10;

        public static readonly int MIN_TRAIL_LEN = 5;
        public static readonly int MAX_TRAIL_LEN = 10;

        public static readonly float START_X = 0f;
        public static readonly float START_Y = 0f;
        public static readonly double NORTH = -Math.PI / 2;
        #endregion /статика

        private struct TurtleState
        {
            public PointF Point { get; }
            public double Angle { get; }

            public TurtleState(PointF currPoint, double currAngle)
            {
                Point = currPoint;
                Angle = currAngle;
            }
        }

        private Pen pen;
        private int trailLen;
        private TurtleState state;
        private Stack<TurtleState> states;

        public Turtle()
        {
            pen = new Pen(PEN_COLOR, MIN_PEN_WIDTH);
            trailLen = MIN_TRAIL_LEN;
            state = new TurtleState(new PointF(START_X, START_Y), NORTH);
            states = new Stack<TurtleState>();
        }

        public Color PenColor
        {
            get
            {
                return pen.Color;
            }

            set
            {
                pen = new Pen(value, pen.Width);
            }
        }

        public float PenWidth
        {
            get
            {
                return pen.Width;
            }

            set
            {
                if (value < MIN_PEN_WIDTH)
                    throw new IndexOutOfRangeException();

                if (value > MAX_PEN_WIDTH)
                    throw new IndexOutOfRangeException();

                pen.Width = value;
            }
        }

        public int TrailLen
        {
            get
            {
                return trailLen;
            }

            set
            {
                if (value < MIN_TRAIL_LEN)
                    throw new IndexOutOfRangeException();

                if (value > MAX_TRAIL_LEN)
                    throw new IndexOutOfRangeException();

                trailLen = value;
            }
        }

        public double CurrAngle
        {
            get
            {
                return state.Angle;
            }
        }

        public PointF CurrPoint
        {
            get
            {
                return state.Point;
            }
        }

        public void Draw(Grammar grammar, Graphics graphics, PointF startPoint, double startAngle)
        {
            state = new TurtleState(startPoint, startAngle);

            foreach (char ch in grammar.Code)
            {
                switch (ch)
                {
                    case '-':
                        TurnRight(grammar.Angle);
                        break;

                    case '+':
                        TurnLeft(grammar.Angle);
                        break;

                    case 'F':
                        GoForwardDrawingLine(graphics);
                        break;

                    case 'f':
                        GoForward();
                        break;

                    case '[':
                        RememberState();
                        break;

                    case ']':
                        RecallState();
                        break;

                    default:
                        break;
                }
            }
        }

        private void TurnRight(double angle)
        {
            state = new TurtleState(state.Point, state.Angle - angle);
        }

        private void TurnLeft(double angle)
        {
            state = new TurtleState(state.Point, state.Angle + angle);
        }

        private void GoForwardDrawingLine(Graphics graphics)
        {
            PointF oldPoint = state.Point;
            GoForward();
            graphics.DrawLine(pen, oldPoint, state.Point);
        }

        private void GoForward()
        {
            float newX = state.Point.X + trailLen * (float)Math.Cos(state.Angle);
            float newY = state.Point.Y + trailLen * (float)Math.Sin(state.Angle);

            state = new TurtleState(new PointF(newX, newY), state.Angle);
        }

        private void RememberState()
        {
            states.Push(new TurtleState(state.Point, state.Angle));
        }

        private void RecallState()
        {
            state = states.Pop();
        }
    }
}