using AutoItX3Lib;
using Competition_Task.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competition_Task.Pages
{
    public class ShareSkillPage : CommonDriver
    {


        private IWebElement shareSkillButton => driver.FindElement(By.XPath("//a[@class=\"ui basic green button\"]"));
        private IWebElement titleTextBox => driver.FindElement(By.Name("title"));
        private IWebElement descriptionTextBox => driver.FindElement(By.Name("description"));
        private IWebElement categoryDropdown => driver.FindElement(By.Name("categoryId"));
        private IWebElement selectCategory => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div/select/option[7]"));
        private IWebElement tagsTextBox => driver.FindElement(By.XPath("By.XPath(\"//input[@class=\\\"ReactTags__tagInputField\\\"]\")"));
        private IWebElement chooseMonday => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input"));
        private IWebElement chooseTuesday => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[4]/div[1]/div/input"));
        private IWebElement newTagTextBox => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
        private IWebElement workSamples => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i"));
        private IWebElement saveButton => driver.FindElement(By.XPath("//input[@class=\"ui teal button\"]"));
        public void ShareSkillAction()
        {
            //Identify the Share Skill button and click on it
            Wait.WaitToBeClickable(driver, "XPath", "//a[@class=\"ui basic green button\"]", 5);
            shareSkillButton.Click();

            //Identify the title textbox and enter title
            titleTextBox.SendKeys("Test Analyst Intern");

            //Identify description textbox and enter description
            descriptionTextBox.SendKeys("I am an intern at MVP Studio and I would like to learn new things.");

            //Identify category dropdown and select category
            categoryDropdown.Click();
            selectCategory.Click();

            //Identify tags textbox and enter tags
            tagsTextBox.SendKeys("Test Analyst, Selenium and C#.");
            tagsTextBox.SendKeys(Keys.Enter);

            //Identify available days and tick checkbox
            chooseMonday.Click();
            chooseTuesday.Click();

            //Identify Skill-Exchange textbox and enter tag
            newTagTextBox.SendKeys("Health Care");

            //Identify work samples and upload a picture
            workSamples.Click();
            Thread.Sleep(500);

            AutoItX3 autoIt = new AutoItX3();
            autoIt.WinActivate("Open");

            autoIt.Send(@"D:\\Downloads\\20201125_174405.jpg\");
            Thread.Sleep(1000);
            autoIt.Send("{ENTER}");
            Thread.Sleep(5000);

            //Identify save button and click 
            saveButton.Click();
            Thread.Sleep(1000);
        }
    }
}
