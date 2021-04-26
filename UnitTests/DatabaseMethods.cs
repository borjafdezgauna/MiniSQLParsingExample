using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiniSQL;

namespace UnitTests
{
    [TestClass]
    public class DatabaseMethods
    {
        [TestMethod]
        public void Select()
        {
            //Database database = new Database();
            ////initialize database in a shared method or load it from file

            //string result = database.Select("People", new List<string>() { "Name", "Age", "Height" });
            //Assert.Equals("{'Name','Age','Height'}...", result);
        }

        [TestMethod]
        public void ParseAndSelect()
        {
            //Database database = new Database();
            ////initalize

            //string result = database.ExecuteMiniSQLQuery("SELECT ...");
            //Assert.Equals("{'Name','Age','Height'}...", result);
        }
    }
}
