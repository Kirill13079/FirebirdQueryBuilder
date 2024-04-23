using System;
using System.Collections.Generic;
using System.Linq;

namespace FirebirdQueryBuilder
{
    public abstract class Builder<TSubject, TSelf>
        where TSelf : Builder<TSubject, TSelf>
        where TSubject : new()
    {
        private readonly List<Func<TSubject, TSubject>> _actions
            = new List<Func<TSubject, TSubject>>();

        public TSelf Do(Action<TSubject> action)
            => AddAction(action);

        private TSelf AddAction(Action<TSubject> action)
        {
            _actions.Add(p => {
                action(p);
                return p;
            });

            return (TSelf)this;
        }

        public TSubject Build()
            => _actions.Aggregate(new TSubject(), (p, f) => f(p));
    }
}
