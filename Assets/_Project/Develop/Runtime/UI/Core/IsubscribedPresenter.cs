namespace Assets._Project.Develop.Runtime.UI.Core
{
    public interface IsubscribedPresenter : IPresenter
    {
        void Subscribe();

        void Unsubscribe();
    }
}
