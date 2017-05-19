namespace Factory
{
    using System;
    using Scenes;

    public class SceneFactory
    {
        public Scene GetScene(SceneEnum welcome)
        {
            switch (welcome)
            {
                case SceneEnum.Welcome:
                    return new WelcomeScene();
                case SceneEnum.End:
                    return new EndScene();
                default:
                    throw new ArgumentOutOfRangeException(nameof(welcome), welcome, null);
            }
        }
    }
}
