﻿// Copyright 2005-2010 Gallio Project - http://www.gallio.org/
// Portions Copyright 2000-2004 Jonathan de Halleux
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("MbUnit35")]
[assembly: AssemblyDescription("MbUnit test framework, .Net 3.5 extensions")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("MbUnit")]
[assembly: AssemblyCopyright("Copyright © 2005-2010 Gallio Project - http://www.gallio.org/")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("acdb5dd3-bb5d-4c87-8765-665db8539478")]

// Ensure CLS compliance for as much of the framework as possible.
// We will individually mark certain constructs non-compliant as needed
// but setting this attribute on the assembly lets the compiler help us.
[assembly: CLSCompliant(true)]

// Allow partially trusted callers to use the MbUnit framework.
// This isn't enough to ensure that we properly support partially trusted
// contexts but it's a beginning.  We also need to carefully review security
// demands throughout the framework and especially calls back into core services.
[assembly: AllowPartiallyTrustedCallers]

// The neutral resources language is US English.
// Telling the system that this is the case yields a small performance improvement during startup.
[assembly: NeutralResourcesLanguage("en-US")]


[assembly: InternalsVisibleTo("MbUnit.Tests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100afeba2c70157155869db20cf76a6d965e53139ff2e11a11f4b2c0a3bc8107e6dcd346d715f328e980db992ad5bdfe9d97474ff6fd3b21f42988d37a1cd21c0012730e77b446ac5fe24a857380f7cb34e3b90ba44c1dd95a8df74f5a91390efc0d7a4e57cd5f9ce5b76cb591c19df1ab69c8bb2060c97db095d8cca1830d82aaf")]
