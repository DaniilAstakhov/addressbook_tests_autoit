using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_tests_autoit
{
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void GroupRemovalTest1()
        {                       
            if (app.Groups.GetGroupList().Count == 1)
            {
                GroupData newGroup = new GroupData()
                {
                    Name = "test"
                };

                app.Groups.Add(newGroup);
            }

            List<GroupData> oldGroups = app.Groups.GetGroupList();

            app.Groups.Remove();

            List<GroupData> newGroups = app.Groups.GetGroupList();

            Assert.AreEqual((oldGroups.Count - 1), newGroups.Count);

        }
    }
}
