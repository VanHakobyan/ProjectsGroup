using System;


namespace Vector
{
    public class vector
    {
        private Point p1,p2;
        private vector v1, v2;
        private float sinx = 0.0f;
        private int v;
        private int v3;

        public vector(vector v1,vector v2)
        {
            this.v1.p1 = v1.p1;
            this.v1.p2 = v1.p2;
            this.v2.p1 = v2.p1;
            this.v2.p2 = v2.p2;
            

        }

        public vector(int v, int v3)
        {
            this.v = v;
            this.v3 = v3;
        }

        public static vector operator +(vector vector1, vector vector2)
        {
                return new vector(vector1.v1, vector2.v2);
           
        }
        public static operator-(vector.v1,vector.v2)
        {
        // not implement
        } 
    }
}
