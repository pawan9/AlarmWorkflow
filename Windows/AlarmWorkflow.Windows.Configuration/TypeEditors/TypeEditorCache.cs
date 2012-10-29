﻿using System;
using System.Collections.Generic;
using AlarmWorkflow.Windows.ConfigurationContracts;

namespace AlarmWorkflow.Windows.Configuration.TypeEditors
{
    sealed class TypeEditorCache
    {
        private static readonly Dictionary<string, Type> TypeEditors;

        static TypeEditorCache()
        {
            TypeEditors = new Dictionary<string, Type>();
            TypeEditors[""] = typeof(TypeEditors.DefaultTypeEditor);
            TypeEditors["System.String"] = typeof(TypeEditors.StringTypeEditor);
            TypeEditors["System.Int32"] = typeof(TypeEditors.Int32TypeEditor);
            TypeEditors["System.Boolean"] = typeof(TypeEditors.BooleanTypeEditor);
            TypeEditors["StringArrayEditor"] = typeof(TypeEditors.StringArrayTypeEditor);
            TypeEditors["DirectoryTypeEditor"] = typeof(TypeEditors.DirectoryTypeEditor);
            // TODO: Better editors!
            TypeEditors["System.Double"] = typeof(TypeEditors.DoubleTypeEditor);
            TypeEditors["SimpleXmlTextEditor"] = typeof(TypeEditors.StringArrayTypeEditor);
        }

        internal static ITypeEditor CreateTypeEditor(string editor)
        {
            if (!TypeEditors.ContainsKey(editor))
            {
                editor = "";
            }

            return (ITypeEditor)Activator.CreateInstance(TypeEditors[editor]);
        }
    }
}
