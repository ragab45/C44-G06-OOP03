namespace Demo
{
    internal class Program
    {
       
            #region V-1
             public struct PhoneBook
        {
            public long this[string name]
            {
                get
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i] == name)
                            return numbers[i];
                    }
                    return -1;
                }
                set
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i] == name)
                            numbers[i] = value;
                    }
                }
            }

            public string this[int index]
            {
                get
                {
                    return $"Index = {index}, Name = {names[index]}, Number = {numbers[index]}";
                }
            }
        }
        #endregion
    }
    
}
