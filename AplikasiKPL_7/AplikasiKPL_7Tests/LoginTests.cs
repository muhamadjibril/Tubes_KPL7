using Microsoft.VisualStudio.TestTools.UnitTesting;
using AplikasiKPL_7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiKPL_7.Tests
{
    [TestClass()]
    public class LoginTests
    {
        [TestMethod()]
        public void LoginTest()
        {
            GetHari Test = new GetHari(31);
        }
    }

    internal class GetHari
    {
        private object januari;

        public GetHari(object januari)
        {
            this.januari = januari;
        }
    }
}
//Maaf Pak saya menyerah dalam mengatasi error, t