namespace Assemente
{
    internal class Program
    {
        
            #region Q-1
            private char gender;
        public char Gender
        {
            get => gender;
            set
            {
                if (value == 'M' || value == 'F')
                    gender = value;
                else
                    gender = 'M'; // default
            }
        }
        #endregion
    }
    }

