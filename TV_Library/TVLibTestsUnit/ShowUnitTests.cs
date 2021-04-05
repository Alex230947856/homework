using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using TV_Library;
namespace TVLibTestsUnit
{
    [TestClass]
    public class ShowUnitTests
    {
        [TestMethod]
        public void ConstructorTestMethod()
        {
            var myMythbusters = CreateTestShow();
            Assert.AreEqual("Mythbusters", myMythbusters.ProgramTV);
            Assert.AreEqual("Adam Savage and Jamie Hyneman", myMythbusters.Host);
            Assert.AreEqual("Проверка легенд и мифов практическими экспериментами", myMythbusters.Description);
            Assert.AreEqual("20:00", myMythbusters.GetReleaseDate);
            Assert.AreEqual(FrequencyTypes.Daily, myMythbusters.Period);

        }
        [TestMethod]
        public void ToStringTestMethod()
        {
            var myMythbusters = CreateTestShow();
            Assert.AreEqual("Mythbusters, Adam Savage and Jamie Hyneman", myMythbusters.ToString());
        }

        [TestMethod]
        public void PrintInfoTestMethod()
        {

            var myMythbusters = CreateTestShow();
            var bearGrills = new Show("Running Wild with Bear Grylls", "Bear Grylls", "Шоу о применении навыков выживания", FrequencyTypes.NonPeriodic, "25.06.2021 11:00");
            var consoleOut = new[] { "Mythbusters, Adam Savage and Jamie Hyneman", $"Описание программы: Проверка легенд и мифов практическими экспериментами. Частота: ежедневно. Дата выхода: 20:00." , "Running Wild with Bear Grylls, Bear Grylls", "Описание программы: Шоу о применении навыков выживания. Частота: не указана. Дата выхода: 25.06.2021 11:00."};

            
            TextWriter oldOut = Console.Out; 
            StringWriter output = new StringWriter();
            Console.SetOut(output); 
            myMythbusters.PrintInfo();
            bearGrills.PrintInfo();
            Console.SetOut(oldOut); 
            var outputArray = output.ToString().Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries); 

            
            Assert.AreEqual(4, outputArray.Length);
            for (var i = 0; i < consoleOut.Length; i++)
                Assert.AreEqual(consoleOut[i], outputArray[i]);
        }
        [TestMethod]
            private Show CreateTestShow()
            {
                return new Show("Mythbusters", "Adam Savage and Jamie Hyneman", "Проверка легенд и мифов практическими экспериментами", FrequencyTypes.Daily, "29.07.2021 20:00");
            }
        }
    }

