using System;
using Xunit;
using MauiApp1;

namespace MauiApp1.Tests
{
    public class MainApplicationTests
    {
        [Fact]
        public void CreateMauiApp_ShouldReturnMauiAppInstance()
        {
            // Arrange
            var handle = new IntPtr();
            var ownership = JniHandleOwnership.DoNotTransfer;
            var mainApplication = new MainApplication(handle, ownership);

            // Act
            var mauiApp = mainApplication.CreateMauiApp();

            // Assert
            Assert.NotNull(mauiApp);
        }
    }
}
