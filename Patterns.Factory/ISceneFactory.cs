namespace Patterns.Factory
{
    using Scenes;

    public interface ISceneFactory
    {
        Scene GetScene(SceneEnum welcome);
    }
}