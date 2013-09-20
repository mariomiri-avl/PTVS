﻿/* ****************************************************************************
 *
 * Copyright (c) Microsoft Corporation. 
 *
 * This source code is subject to terms and conditions of the Apache License, Version 2.0. A 
 * copy of the license can be found in the License.html file at the root of this distribution. If 
 * you cannot locate the Apache License, Version 2.0, please send an email to 
 * vspython@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
 * by the terms of the Apache License, Version 2.0.
 *
 * You must not remove this notice, or any other, from this software.
 *
 * ***************************************************************************/

using System;

namespace CanopyInterpreter {
    /// <summary>
    /// Provides constants used to identify interpreters that are detected from
    /// Canopy's registry settings.
    /// </summary>
    public static class CanopyInterpreterFactoryConstants {
        public const string BaseId32 = "{PLACE-NEW-GUID-HERE}";
        public const string BaseId64 = "{PLACE-NEW-GUID-HERE}";

        public const string UserId32 = "{PLACE-NEW-GUID-HERE}";
        public const string UserId64 = "{PLACE-NEW-GUID-HERE}";

        public static readonly Guid BaseGuid32 = new Guid(BaseId32);
        public static readonly Guid BaseGuid64 = new Guid(BaseId64);

        public static readonly Guid UserGuid32 = new Guid(UserId32);
        public static readonly Guid UserGuid64 = new Guid(UserId64);

        public const string ConsoleExecutable = "python.exe";
        public const string WindowsExecutable = "pythonw.exe";
        public const string LibrarySubPath = "lib";
        public const string PathEnvironmentVariableName = "PYTHONPATH";

        public const string BaseDescription = "Base Canopy";
        public const string UserDescription = "Canopy";

        // The {0} should be substituted with the Python language version
        public const string PythonDescription32 = " ({0} 32-bit)";
        public const string PythonDescription64 = " ({0} 64-bit)";
    }
}