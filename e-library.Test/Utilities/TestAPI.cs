using System;
using System.Collections.Generic;
using System.Text;

namespace e_library.Test.Utilities
{
    public static class TestAPI
    {
        /// <summary>
        /// Get test Method Name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetCurrentMethodName([System.Runtime.CompilerServices.CallerMemberName] string name = "")
        {
            return name;
        }
    }
}
