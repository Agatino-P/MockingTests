using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TestableService;

namespace TestableServiceTest
{
    [TestClass]
    public class TestableTest
    {
        [TestMethod]
        public void ToLetters()
        {
            Mock<ITestable> mockTestable = new Mock<ITestable>();

            mockTestable.Setup(mt => mt.ToLetters(
                It.Is<int>(i=>i==1)
                ))
                .Returns("Uno");
            
            mockTestable.Setup(mt => mt.ToLetters(
             It.Is<int>(i => i == 2)
             ))
             .Returns("Due");


            Debug.WriteLine(mockTestable.Object.ToLetters(1));
            
            Debug.WriteLine(mockTestable.Object.ToLetters(2));
        }
    }
}
