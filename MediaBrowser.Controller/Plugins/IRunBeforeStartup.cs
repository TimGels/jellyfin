﻿#pragma warning disable CA1040 // Avoid empty interfaces

namespace MediaBrowser.Controller.Plugins
{
    /// <summary>
    /// Indicates that a <see cref="IServerEntryPoint"/> should be invoked as a pre-startup task.
    /// </summary>
    public interface IRunBeforeStartup
    {
    }
}