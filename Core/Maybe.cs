using System;

namespace Core
{
    public abstract class Maybe<T> : Monad<T> {
        
        protected Maybe(T value) : base(value)
        {
        }
        
    }

    public class Nothing : Maybe<> { }
    
    public class Just : Maybe { }
}