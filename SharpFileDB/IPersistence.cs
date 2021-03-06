﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Patterns.Contracts;

namespace SharpFileDB
{
    /// <summary>
    /// 文件数据库使用此接口进行持久化相关的操作。
    /// <para>File database executes persistence operations via this interface.</para>
    /// </summary>
    public interface IPersistence
    {
        /// <summary>
        /// <see cref="FileObject"/>文件的扩展名。
        /// Extension name of <see cref="FileObject"/>'s file.
        /// </summary>
        string Extension { get; }

        /// <summary>
        /// 将文件对象序列化为文件。
        /// <para>Serialize the specified <paramref name="item"/> into <paramref name="fullname"/>.</para>
        /// </summary>
        /// <param name="item">要进行序列化的文件对象。<para>file object to be serialized.</para></param>
        /// <param name="fullname">要保存到的文件的绝对路径。<para>file's fullname.</para></param>
        /// <returns></returns>
        void Serialize([Required] FileObject item, [Required] string fullname);

        /// <summary>
        /// 将文件反序列化成文件对象。
        /// <para>Deserialize the specified file to an instance of <paramref name="TFileObject"/>.</para>
        /// </summary>
        /// <typeparam name="TFileObject"></typeparam>
        /// <param name="serializedFileObject"></param>
        /// <returns></returns>
        TFileObject Deserialize<TFileObject>([Required] string fullname) where TFileObject : FileObject;
    }
}
