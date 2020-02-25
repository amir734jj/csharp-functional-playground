using System;

namespace Core
{
    public class Monad<T>
    {
        private readonly T _value;

        private Monad() { }
        
        public Monad(T value)
        {
            _value = value;
        }
        
        public Monad<TDestination> Bind<TDestination>(Func<T, Monad<TDestination>> func)
        {
            return func(_value);
        }
        
        public static Monad<T> Return(T instance)
        {
            return new Monad<T>(instance);
        }
    }
}