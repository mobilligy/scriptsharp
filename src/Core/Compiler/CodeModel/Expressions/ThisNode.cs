// ThisNode.cs
// Script#/Core/ScriptSharp
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Diagnostics;

namespace ScriptSharp.CodeModel {

    internal sealed class ThisNode : ExpressionNode {

        public ThisNode(Token token)
            : base(ParseNodeType.This, token) {
        }
    }
}
