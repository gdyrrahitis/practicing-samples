namespace Factory.Tests.Unit.SceneFactoryTests
{
    using NUnit.Framework;
    using Scenes;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class GetScene
    {
        [Test]
        public void WelcomeSceneIsShowingWelcome()
        {
            // Arrange
            Scene scene = new WelcomeScene();

            // Act
            var result = scene.Show();

            // Assert
            AreEqual("Welcome", result);
        }

        [Test]
        public void EndSceneIsShowingEnd()
        {
            // Arrange
            Scene scene = new EndScene();

            // Act
            var result = scene.Show();

            // Assert
            AreEqual("End", result);
        }

        [Test]
        public void SelectsWelcomeAndShowsWelcome()
        {
            // Arrange
            var factory = new SceneFactory();
            var welcome = factory.GetScene(SceneEnum.Welcome);

            // Act
            var result = welcome.Show();

            // Assert
            AreEqual("Welcome", result);
        }


        [Test]
        public void SelectsEndAndShowsEnd()
        {
            // Arrange
            var factory = new SceneFactory();
            var welcome = factory.GetScene(SceneEnum.End);

            // Act
            var result = welcome.Show();

            // Assert
            AreEqual("End", result);
        }
    }
}