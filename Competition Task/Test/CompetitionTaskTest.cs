using Competition_Task.Pages;
using Competition_Task.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Competition_Task.Test
{
    [TestFixture]
    [Parallelizable]

    public class CompetitionTaskTest : CommonDriver
    {
        LoginPage loginPageObj;
        ShareSkillPage shareSkillPageObj;

        public CompetitionTaskTest()
        {
            loginPageObj = new LoginPage();
            shareSkillPageObj = new ShareSkillPage();
        }


        [Test, Order(1)]
        public void ShareSkill()
        {
            shareSkillPageObj.ShareSkillAction();
        }

    }




}


