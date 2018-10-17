using System;
using Smooth.Delegates;
using UniRx;

namespace DefaultNamespace
{
    public static class RxExtension
    {
        public static IDisposable SubscribeOnComplit<T>(this UniRx.IObservable<T> stream, DelegateAction actopn)
        {
            return stream.Subscribe(_ => { }, () => actopn());
        }
    }
}