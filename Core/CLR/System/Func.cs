﻿using Bridge.CLR;

namespace System
{
    [Name("Function")]
    [IgnoreGeneric,IgnoreCast]
    public delegate TResult Func<TResult>();

    [Name("Function")]
    [IgnoreGeneric,IgnoreCast]
    public delegate TResult Func<T, TResult>(T arg);

    [Name("Function")]
    [IgnoreGeneric,IgnoreCast]
    public delegate TResult Func<T1, T2, TResult>(T1 arg1, T2 arg2);

    [Name("Function")]
    [IgnoreGeneric,IgnoreCast]
    public delegate TResult Func<T1, T2, T3, TResult>(T1 arg1, T2 arg2, T3 arg3);

    [Name("Function")]
    [IgnoreGeneric,IgnoreCast]
    public delegate TResult Func<T1, T2, T3, T4, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4);

    [Name("Function")]
    [IgnoreGeneric,IgnoreCast]
    public delegate TResult Func<T1, T2, T3, T4, T5, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);

    [Name("Function")]
    [IgnoreGeneric,IgnoreCast]
    public delegate TResult Func<T1, T2, T3, T4, T5, T6, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);

    [Name("Function")]
    [IgnoreGeneric,IgnoreCast]
    public delegate TResult Func<T1, T2, T3, T4, T5, T6, T7, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);

    [Name("Function")]
    [IgnoreGeneric,IgnoreCast]
    public delegate TResult Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8); 
}
