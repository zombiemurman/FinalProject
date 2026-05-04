using System;

namespace Assets._Project.Develop.Runtime.Utilities.Conditions
{
    public interface ICompositCondition : ICondition
    {
        ICompositCondition Add(ICondition condition, int order = 0, Func<bool, bool, bool> logicOperation = null);

        ICompositCondition Remove(ICondition condition);
    }
}
