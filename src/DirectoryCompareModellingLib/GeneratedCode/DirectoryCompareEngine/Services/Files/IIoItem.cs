﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace DirectoryCompareEngine.Services.Files
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public interface IIoItem 
	{
		bool Exists { get;set; }

		string Name { get;set; }

		IIoProvider IoProvider { get;set; }

		IIoDirectory Parent { get;set; }

	}
}

