﻿using UnityEditor;

namespace JEngine.Editor
{
    [InitializeOnLoad]
    internal class EditorUpdate
    {
        /// <summary>
        /// 注册各种Update
        /// </summary>
        static EditorUpdate()
        {
            EditorApplication.update += Clean.Update;//处理DLL
            EditorApplication.update += XAsset.Update;//验证XAsset
            EditorApplication.update += AllowUnsafe.Update;//允许Unsafe code
        }
    }
}
