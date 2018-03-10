namespace Patterns.Factory
{
    using System;
    using Scenes;

    public class SceneFactory: ISceneFactory
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
