using System;

namespace MyFirstClassLib
{
    public class Lady
    {
        private string name;

        public string Name
         { 
             get
             {
                 return name;
             }
             set
             {
                 name = value;
             }

             }

        


        private int height;

        public int Height
        { 
            get
            {
                return height;
            }
        set
        {
            if(value > 7)
            {
                height = 7;

            } 
            else
            {
                height = value;
            }
            
        }
         }

         public int Age { get {return 2;} set { value = 23;} }
    }
}
