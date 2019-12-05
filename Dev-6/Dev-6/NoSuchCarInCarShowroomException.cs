using System;

namespace Dev_6
{
    /// <summary>
    /// Class of there is no such car exception
    /// </summary>
    class NoSuchCarInCarShowroomException:Exception
    {
        public override string Message => "There is no such car in the list"; 
    }
}
