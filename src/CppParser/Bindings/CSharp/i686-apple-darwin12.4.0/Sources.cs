//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace CppSharp
{
    namespace Parser
    {
        public unsafe partial struct SourceLocation
        {
            [StructLayout(LayoutKind.Explicit, Size = 4)]
            public partial struct Internal
            {
                [FieldOffset(0)]
                public uint ID;

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser14SourceLocationC2Ev")]
                internal static extern void ctor_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser14SourceLocationC2Ej")]
                internal static extern void ctor_1(global::System.IntPtr instance, uint ID);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser14SourceLocationC2ERKS1_")]
                internal static extern void cctor_2(global::System.IntPtr instance, global::System.IntPtr _0);
            }

            public static new SourceLocation __CreateInstance(global::System.IntPtr native)
            {
                return new SourceLocation((SourceLocation.Internal*) native);
            }

            internal SourceLocation(SourceLocation.Internal native)
                : this(&native)
            {
            }

            private SourceLocation(SourceLocation.Internal* native, bool isInternalImpl = false) : this()
            {
                var __ptr = native;
                ID = __ptr->ID;
            }

            internal Internal ToInternal()
            {
                var __native = new CppSharp.Parser.SourceLocation.Internal();
                var __ptr = &__native;
                __native.ID = ID;
                return __native;
            }

            internal void FromInternal(Internal* native)
            {
                var __ptr = native;
                ID = __ptr->ID;
            }

            public SourceLocation(uint ID)
                : this()
            {
                var __fixedInstance = ToInternal();
                Internal.ctor_1(new global::System.IntPtr(&__fixedInstance), ID);
                FromInternal(&__fixedInstance);
            }

            public uint ID
            {
                get;

                set;
            }
        }
    }
}
