﻿// Copyright 2005-2015 Giacomo Stelluti Scala & Contributors. All rights reserved. See doc/License.md in the project root for license information.

using System;
using System.Text;

namespace CommandLine.Infrastructure
{
    static class StringBuilderExtensions
    {
            if (condition)

        public static StringBuilder AppendWhen(this StringBuilder builder, bool condition, params char[] values)
        {
            if (condition)
            {
                foreach (var value in values)
                {
                    builder.Append(value);
                }
            }
            return builder;
        }

        public static StringBuilder AppendFormatWhen(this StringBuilder builder, bool condition, string format, params object[] args)
        {
            if (condition)
            {
                builder.AppendFormat(format, args);
            }
            return builder;
        }

        public static StringBuilder AppendIf(this StringBuilder builder, bool condition, string ifTrue, string ifFalse)
        {
            return condition ? builder.Append(ifTrue) : builder.Append(ifFalse);
        }

        public static StringBuilder BimapIf(this StringBuilder builder, bool condition,
            Func<StringBuilder, StringBuilder> ifTrue, Func<StringBuilder, StringBuilder> ifFalse)
        {
            return condition ? ifTrue(builder) : ifFalse(builder);
        }

        public static StringBuilder MapIf(this StringBuilder builder, bool condition,
            Func<StringBuilder, StringBuilder> ifTrue)
        {
            return condition ? ifTrue(builder) : builder;
        }

        public static StringBuilder AppendIfNotEmpty(this StringBuilder builder, params string[] values)
        {
            foreach (var value in values)
            {
                if (value.Length > 0)
                {
                    builder.Append(value);
                }
            }
            return builder;
        }


        public static int SafeLength(this StringBuilder builder)
        {
            return builder == null ? 0 : builder.Length;
        }

        public static StringBuilder TrimEnd(this StringBuilder builder, char c)
        {
            return builder.Length > 0
                ? builder.Remove(builder.Length - 1, 1) : builder;
        }

            if (builder.Length > 0)
                if (builder[builder.Length - 1] == c)
                    builder.Remove(builder.Length - 1, 1);
}