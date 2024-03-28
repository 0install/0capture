// Copyright Bastian Eicher et al.
// Licensed under the GNU Lesser Public License

using System.Net;
using System.Security;
using NanoByte.Common;
using NanoByte.Common.Net;
using NanoByte.Common.Tasks;
using NDesk.Options;
using ZeroInstall.Publish;
using ZeroInstall.Publish.Capture.Cli;

ProcessUtils.SanitizeEnvironmentVariables();
NetUtils.ApplyProxy();
ServicePointManager.DefaultConnectionLimit = 16;

using var handler = new AnsiCliTaskHandler();

try
{
    new CaptureCommand(args is [] ? ["--help"] : args, handler).Execute();
    return (int)ExitCode.OK;
}
#region Error handling
catch (OperationCanceledException)
{
    return (int)ExitCode.UserCanceled;
}
catch (Exception ex) when (ex is ArgumentException or OptionException or KeyNotFoundException)
{
    handler.Error(ex);
    return (int)ExitCode.InvalidArguments;
}
catch (WebException ex)
{
    handler.Error(ex);
    return (int)ExitCode.WebError;
}
catch (InvalidDataException ex)
{
    handler.Error(ex);
    return (int)ExitCode.InvalidData;
}
catch (IOException ex)
{
    handler.Error(ex);
    return (int)ExitCode.IOError;
}
catch (Exception ex) when (ex is UnauthorizedAccessException or SecurityException)
{
    handler.Error(ex);
    return (int)ExitCode.AccessDenied;
}
catch (NotSupportedException ex)
{
    handler.Error(ex);
    return (int)ExitCode.NotSupported;
}
#endregion
