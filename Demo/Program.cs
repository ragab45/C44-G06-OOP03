using System.Reflection;

namespace Demo
{
    internal class car
    {

        #region V-1
        //     public struct PhoneBook
        //{
        //    public long this[string name]
        //    {
        //        get
        //        {
        //            for (int i = 0; i < names.Length; i++)
        //            {
        //                if (names[i] == name)
        //                    return numbers[i];
        //            }
        //            return -1;
        //        }
        //        set
        //        {
        //            for (int i = 0; i < names.Length; i++)
        //            {
        //                if (names[i] == name)
        //                    numbers[i] = value;
        //            }
        //        }
        //    }

        //    public string this[int index]
        //    {
        //        get
        //        {
        //            return $"Index = {index}, Name = {names[index]}, Number = {numbers[index]}";
        //        }
        //    }
        //}
        #endregion
        #region V-2
        public int Speed { get; set; }

        public Car(int id, string model, int speed)
        {
            Id = id;
            Model = model;
            Speed = speed;
        }

        public Car(int id, string model)
        {
            Id = id;
            Model = model;
        }

        public Car(int id)
        {
            Id = id;
        }
    
    }
    
    #endregion
}
    
}
