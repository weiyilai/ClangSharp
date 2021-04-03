// Copyright (c) Microsoft and Contributors. All rights reserved. Licensed under the University of Illinois/NCSA Open Source License. See LICENSE.txt in the project root for license information.

// Ported from https://github.com/llvm/llvm-project/tree/llvmorg-11.0.0/clang/include/clang-c
// Original source is Copyright (c) the LLVM Project and Contributors. Licensed under the Apache License v2.0 with LLVM Exceptions. See NOTICE.txt in the project root for license information.

using System.Runtime.InteropServices;
using Xunit;

namespace ClangSharp.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CXTranslationUnitImpl" /> struct.</summary>
    public static unsafe class CXTranslationUnitImplTests
    {
        /// <summary>Validates that the <see cref="CXTranslationUnitImpl" /> struct is blittable.</summary>
        [Fact]
        public static void IsBlittableTest() => Assert.Equal(sizeof(CXTranslationUnitImpl), Marshal.SizeOf<CXTranslationUnitImpl>());

        /// <summary>Validates that the <see cref="CXTranslationUnitImpl" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Fact]
        public static void IsLayoutSequentialTest() => Assert.True(typeof(CXTranslationUnitImpl).IsLayoutSequential);

        /// <summary>Validates that the <see cref="CXTranslationUnitImpl" /> struct has the correct size.</summary>
        [Fact]
        public static void SizeOfTest() => Assert.Equal(1, sizeof(CXTranslationUnitImpl));
    }
}
