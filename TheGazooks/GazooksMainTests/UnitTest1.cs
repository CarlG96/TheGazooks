using FluentAssertions;
using TheGazooks;

namespace GazooksMainTests
{
    public class UnitTest1
    {
        [Fact]
        public void GameShouldRunTest()
        {
            // Arrange
            Game game = new Game();

            // Act
            game.Run();

            // Assert
            
        }

        
    }
}