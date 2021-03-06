// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Security.Permissions;

namespace System.ComponentModel
{
    /// <summary>
    ///    <para>Provides a way to synchronously or asynchronously execute a delegate.</para>
    /// </summary>
    public interface ISynchronizeInvoke
    {
        /// <summary>
        /// <para>Gets a value indicating whether the caller must call <see cref='System.ComponentModel.ISynchronizeInvoke.Invoke'/> when calling an object that implements 
        ///    this interface.</para>
        /// </summary>
        bool InvokeRequired { get; }

        /// <summary>
        ///    <para> 
        ///       Executes the given delegate on the main thread that this object executes on.</para>
        /// </summary>
        IAsyncResult BeginInvoke(Delegate method, object[] args);

        /// <summary>
        ///    <para>Waits until the process you started by 
        ///       calling <see cref='System.ComponentModel.ISynchronizeInvoke.BeginInvoke'/> completes, and then returns
        ///       the value generated by the process.</para>
        /// </summary>
        object EndInvoke(IAsyncResult result);

        /// <summary>
        ///    <para> 
        ///       Executes the given delegate on the main thread that this object
        ///       executes on.</para>
        /// </summary>
        object Invoke(Delegate method, object[] args);
    }
}
